using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Bacchus.Dao
{
    public class FamilleDAO
    {
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
        public int AjouterFamille(String Nom)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            int SfIfExists = TrouverParNom(Nom);
            if (SfIfExists != -1)
            {
                Connexion.Close();
                return 1;
            }
            SQLiteCommand Requete = Connexion.CreateCommand();
            Requete.CommandText = "Insert into Familles(Nom) Values(@nom)";
            Requete.Parameters.Add(new SQLiteParameter("@nom", Nom));
            SQLiteDataReader LectureRequette = Requete.ExecuteReader();
            Connexion.Close();
            return 0;

        }

        public Famille TrouverParId(int Id)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Familles WHERE RefFamille = :Id", Connexion);
            Command.Parameters.AddWithValue(":Id", Id);
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                Famille Famille = new Famille(Reader.GetInt32(0), Reader.GetString(1));
                Connexion.Close();
                return Famille;
            }
            Connexion.Close();
            return null;
        }

        public int TrouverParNom(String Nom)
        {
            SQLiteCommand Command = new SQLiteCommand("SELECT RefFamille FROM Familles WHERE Nom = :Nom", Connexion);
            Command.Parameters.AddWithValue(":Nom", Nom);
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                int Ref = Reader.GetInt32(0);
                Reader.Close();
                Connexion.Close();
                return Ref;
            }
            return -1;
        }
        public List<Famille> TrouverFamille()
        {
          
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Familles", Connexion);
            SQLiteDataReader Reader = Command.ExecuteReader();
            List<Famille> ListeFamille = new List<Famille>();
            while (Reader.Read())
            {
                ListeFamille.Add(new Famille(Reader.GetInt32(0), Reader.GetString(1)));
            }
            Connexion.Close();
            return ListeFamille;
        }

        public Boolean SupprimerFamille(string RefFamille)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefFamille) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                SQLiteCommand Command = new SQLiteCommand("DELETE FROM Familles WHERE RefFamille = :RefFamille", Connexion);
                Command.Parameters.AddWithValue(":RefFamille", RefFamille);
                Command.ExecuteNonQuery();
                if (TrouverParNom(RefFamille) != -1)
                {
                    Connexion.Close();
                    return true;
                }
                Connexion.Close();
                return false;
            }
        }

    }


}
