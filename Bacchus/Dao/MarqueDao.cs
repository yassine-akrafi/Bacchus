using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permettant l'accés au données des Marques
    /// </summary>
    public class MarqueDao
    {
        //**************A enleverrrrrr


        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        /// <summary>
        /// Ajoute une marque à la base de données
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>retourne 0 si succés, -1 echec</returns>
        public int AjouterMarque(String Nom)
        {
            //Si la marque existe on ne la crée pas
            if (GetRefMarque(Nom) != -1)
            {
                return -1;
            }

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            try
            {
                // On execute la commande Sql pour ajouter la famille à la base de données
                SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO Marques (Nom) VALUES (:Nom)", Connexion);
                CommandInsert.Parameters.AddWithValue(":Nom", Nom);
                CommandInsert.ExecuteNonQuery();

                Connexion.Close();
                return 0;
            }
            catch (Exception)
            {
                Connexion.Close();
                return -1;
            }
        }

        /// <summary>
        /// Supprime une marque 
        /// retroune vrai si la marque existe et a été supprimé
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean SupprimerMarque(string RefMarque)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }


            // On verfie si la marque n'existe pas 
            if (GetMarque(int.Parse(RefMarque)) == null)
            {
                Connexion.Close();
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM Marques WHERE RefMarque = :RefMarque", Connexion);
            Command.Parameters.AddWithValue(":RefMarque", RefMarque);
            Command.ExecuteNonQuery();


            // On verfie si la marque n'existe plus 
            if (GetMarque(int.Parse(RefMarque)) == null)
            {
                Connexion.Close();
                return true;
            }

            Connexion.Close();
            return false;
        }

        /// <summary>i
        /// Récupere la marque à partir de sa reference ,null si la marque n'existe pas
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <returns>La marque ou null si elle n'existe pas</returns>
        public Marque GetMarque(int RefMarque)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la famille
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Marques WHERE RefMarque = :RefMarque", Connexion);
            Command.Parameters.AddWithValue(":RefMarque", RefMarque);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on crée la marque à retourner et on la retourne
            if (Reader.Read())
            {
                Marque Marque = new Marque(Reader.GetInt32(0), Reader.GetString(1));
                Connexion.Close();
                return Marque;
            }
            Connexion.Close();
            return null;
        }

        /// <summary>
        /// Récupere la reference d'une marque à partir de son nom,
        /// retourne -1 si la marque n'existe pas
        /// </summary>
        /// <param name="Nom">Nom de la marque</param>
        /// <returns>-1 si la marque existe, la reference de la marque sinon</returns>
        public int GetRefMarque(String Nom)
        {

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la famille 
            SQLiteCommand Command = new SQLiteCommand("SELECT RefMarque FROM Marques WHERE Nom = :Nom", Connexion);
            Command.Parameters.AddWithValue(":Nom", Nom);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on retourne la reference de la marque
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

        /// <summary>
        /// Retourne toutes les marques présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de marques</returns>
        public List<Marque> GetArticles()
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer toutes les familles 
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Marques", Connexion);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On crée une listes de marques et on lui ajoute toutes les marques recupérés à partir de la commande sql
            List<Marque> ListeMarque = new List<Marque>();
            while (Reader.Read())
            {
                ListeMarque.Add(new Marque(Reader.GetInt32(0), Reader.GetString(1)));
            }
            Connexion.Close();
            return ListeMarque;
        }

        /// <summary>
        /// Modifie la marque dans la base de données
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <param name="Nom">Nom de la marque</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean ModifierMarque(string RefMarque, string Nom)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }


            // On verfie si la famille n'existe pas 
            if (GetMarque(int.Parse(RefMarque)) == null)
            {
                Connexion.Close();
                return false;
            }

            // Si un nom est passé en paramètre on modifie le nom de la famille
            if (Nom != null)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Marques SET Nom = :Nom WHERE RefMarque = :RefMarque", Connexion);
                Command.Parameters.AddWithValue(":RefMarque", RefMarque);
                Command.Parameters.AddWithValue(":Nom", Nom);
                Command.ExecuteNonQuery();
            }


            Connexion.Close();
            return true;

        }
    }
}