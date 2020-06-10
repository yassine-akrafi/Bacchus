using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bacchus.Dao
{
    public class MarqueDao
    {
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        public int AjouterMarque(String Nom)
        {
            SQLiteConnection.ClearAllPools();
            Console.WriteLine("Je suis dans Ajouter Marque avec le nom = " + Nom);
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            if (TrouverParNom(Nom) != -1)
            {
                return 1;
            }
            SQLiteConnection.ClearAllPools();
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            try
            {
                Console.WriteLine("Je vais crée une marque");
                SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO Marques (Nom) VALUES (:Nom)", Connexion);
                CommandInsert.Parameters.AddWithValue(":Nom", Nom);
                CommandInsert.ExecuteNonQuery();
                Connexion.Close();
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
        }


        public Boolean SupprimerMarque(string RefMarque)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefMarque) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                SQLiteCommand Command = new SQLiteCommand("DELETE FROM Marques WHERE RefMarque = :RefMarque", Connexion);
                Command.Parameters.AddWithValue(":RefMarque", RefMarque);
                Command.ExecuteNonQuery();
                if (TrouverParNom(RefMarque) != -1)
                {
                    Connexion.Close();
                    return true;
                }
                Connexion.Close();
                return false;
            }

        }

        public Marque TrouverParId(int Id)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Marques WHERE RefMarque = :Id", Connexion);
            Command.Parameters.AddWithValue(":Id", Id);
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                Marque Marque = new Marque(Reader.GetInt32(0), Reader.GetString(1));
                Connexion.Close();
                return Marque;
            }
            Connexion.Close();
            return null;
        }

        public int TrouverParNom(String Nom)
        {
            SQLiteCommand Command = new SQLiteCommand("SELECT RefMarque FROM Marques WHERE Nom = :Nom", Connexion);
            Command.Parameters.AddWithValue(":Nom", Nom);
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            int Ref = -1;
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {

                Ref = Reader.GetInt32(0);

            }
            Reader.Close();
            Connexion.Close();
            return Ref;
        }

        public List<Marque> TrouverMarques()
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Marques", Connexion);
            SQLiteDataReader Reader = Command.ExecuteReader();
            List<Marque> ListeMarque = new List<Marque>();
            while (Reader.Read())
            {
                ListeMarque.Add(new Marque(Reader.GetInt32(0), Reader.GetString(1)));
            }
            Connexion.Close();
            return ListeMarque;
        }

        public Boolean ModifierMarque(string RefMarque, string Nom)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefMarque) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET Nom = :Nom WHERE RefMarque = :RefMarque", Connexion);
                Command.Parameters.AddWithValue(":RefMarque", RefMarque);
                Command.Parameters.AddWithValue(":Nom", Nom);
                Command.ExecuteNonQuery();
                if (TrouverParNom(RefMarque) != -1)
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