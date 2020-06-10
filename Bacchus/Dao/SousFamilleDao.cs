using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bacchus.Dao
{

    public class SousFamilleDAO
    {
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
        public int AjouterSousFamille(String RefFamille, String Nom)
        {
            //AjouterFamille
            SQLiteConnection.ClearAllPools();
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            int SfIfExists = TrouverParNom(Nom);
            int Ref = 0;
            if (SfIfExists != -1)
            {
                Connexion.Close();
                return 1;
            }
            else
            {
                try
                {
                    if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
                    {
                        Connexion.Open();
                    }
                    FamilleDAO DaoFamille = new FamilleDAO();

                    int Famille = DaoFamille.GetRefFamille(RefFamille);

                    SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO SousFamilles (RefFamille, Nom) VALUES (:RefFamille, :Nom)", Connexion);
                    CommandInsert.Parameters.AddWithValue(":RefFamille", Famille);
                    CommandInsert.Parameters.AddWithValue(":Nom", Nom);
                    CommandInsert.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            Connexion.Close();
            return Ref;
        }


        public Boolean SupprimerSousFamille(string RefSousFamille)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefSousFamille) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                SQLiteCommand Command = new SQLiteCommand("DELETE FROM SousFamilles WHERE RefSousFamille = :RefSousFamille", Connexion);
                Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);
                Command.ExecuteNonQuery();
                if (TrouverParNom(RefSousFamille) != -1)
                {
                    Connexion.Close();
                    return true;
                }
                Connexion.Close();
                return false;
            }
        }

        public SousFamille TrouverParId(int Id)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM SousFamilles WHERE RefSousFamille = :Id", Connexion);
            Command.Parameters.AddWithValue(":Id", Id);
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                SousFamille SousFamille = new SousFamille(Reader.GetInt32(0), Reader.GetInt32(1), Reader.GetString(2));
                Connexion.Close();
                return SousFamille;
            }
            Connexion.Close();
            return null;
        }

        public int TrouverParNom(String Nom)
        {
            SQLiteCommand Command = new SQLiteCommand("SELECT RefSousFamille FROM SousFamilles WHERE Nom = :Nom", Connexion);
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
            Connexion.Close();
            return -1;
        }

        public List<SousFamille> TrouverSousFamilles()
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM SousFamilles", Connexion);
            SQLiteDataReader Reader = Command.ExecuteReader();
            List<SousFamille> ListeSousFamille = new List<SousFamille>();
            while (Reader.Read())
            {
                ListeSousFamille.Add(new SousFamille(Reader.GetInt32(0), Reader.GetInt32(1), Reader.GetString(2)));
            }
            Connexion.Close();
            return ListeSousFamille;
        }

        public Boolean ModifierSousFamille(string RefSousFamille, string Nom, int RefFamille)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefSousFamille) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                if (Nom != null)
                {
                    SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET Nom = :Nom WHERE RefSousFamille = :RefSousFamille", Connexion);
                    Command.Parameters.AddWithValue(":RefMarque", RefSousFamille);
                    Command.Parameters.AddWithValue(":Nom", Nom);
                    Command.ExecuteNonQuery();
                }
                if (RefFamille != -1)
                {
                    SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET RefFamille = :RefFamille WHERE RefSousFamille = :RefSousFamille", Connexion);
                    Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);
                    Command.Parameters.AddWithValue(":RefFamille", RefFamille);
                    Command.ExecuteNonQuery();
                }

                if (TrouverParNom(RefSousFamille) != -1)
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
