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

        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        String Connexion = "Data Source=Bacchus.SQLite";

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

            // On execute la commande Sql pour ajouter la famille à la base de données
            String sql = "INSERT INTO Marques (Nom) Values('" + Nom + "')";
            Console.Write("J'ajoute une Marques avec les parametres " + Nom);
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return 0;
                        }
                    }
                }
            }
            return -1;
           
        }

        /// <summary>
        /// Supprime une marque 
        /// retroune vrai si la marque existe et a été supprimé
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean SupprimerMarque(string RefMarque)
        {
            // On verfie si la marque n'existe pas 
            if (GetMarque(int.Parse(RefMarque)) == null)
            {
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            String sql = "DELETE FROM Marques WHERE RefMarque ='" + RefMarque + "'";

            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // On verfie si la marque n'existe plus 
            if (GetMarque(int.Parse(RefMarque)) == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Récupere la marque à partir de sa reference ,null si la marque n'existe pas
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <returns>La marque ou null si elle n'existe pas</returns>
        public Marque GetMarque(int RefMarque)
        {
            Marque Marque;
            // On met en place la commande Sql pour récuperer la famille
            String sql = "SELECT * FROM Marques WHERE RefMarque = '" + RefMarque + "'";

            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            Marque = new Marque(rdr.GetInt32(0), rdr.GetString(1));
                            return Marque;
                        }
                    }
                }
            }
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

            // On met en place la commande Sql pour récuperer la famille 
            String sql = "SELECT RefMarque FROM Marques WHERE Nom = '" + Nom + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            int Ref = rdr.GetInt32(0);
                            return Ref;
                        }
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Retourne toutes les marques présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de marques</returns>
        public List<Marque> GetArticles()
        {
            List<Marque> ListeMarque = new List<Marque>();

            // On met en place la commande Sql pour récuperer toutes les familles 
            String sql = "SELECT * FROM Marques";

            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            ListeMarque.Add(new Marque(rdr.GetInt32(0), rdr.GetString(1)));
                            while (rdr.Read())
                            {
                                ListeMarque.Add(new Marque(rdr.GetInt32(0), rdr.GetString(1)));
                            }
                            return ListeMarque;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Modifie la marque dans la base de données
        /// </summary>
        /// <param name="RefMarque">Reference de la marque</param>
        /// <param name="Nom">Nom de la marque</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean ModifierMarque(string RefMarque, string Nom)
        {

            // On verfie si la famille n'existe pas 
            if (RefMarque == null || GetMarque(int.Parse(RefMarque)) == null)
            {
                return false;
            }

            
            // Si un nom est passé en paramètre on modifie le nom de la famille
            if (Nom != null)
            {
                String sql = "UPDATE Marques SET Nom ='" + Nom + "' WHERE RefMarque ='" + RefMarque + "'";
                using (SQLiteConnection c = new SQLiteConnection(Connexion))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return true;

        }
    }
}