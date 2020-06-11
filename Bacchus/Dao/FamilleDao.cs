using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permettant l'accés au données des Familles
    /// </summary>
    /// 
    public class FamilleDAO
    {


        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        // private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Lenovo\\Desktop\\Cours\\.Net\\TP\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
        String Connexion = "Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite";

        /// <summary>
        /// Ajoute une famille à la base de données
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>retourne 0 si succés, -1 echec</returns>
        public int AjouterFamille(String Nom)
        {
            // Si la famille existe on ne le crée pas
            if (GetRefFamille(Nom) != -1)
            {
                return -1;
            }

            // On execute la commande Sql pour ajouter la famille à la base de données
            String sql = "INSERT INTO Familles(Nom) Values('"+Nom+"')";
            Console.Write("J'ajoute une famille avec les parametres "  + Nom);
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
        /// Récupere la famille à partir de sa reference ,null si la famille n'existe pas
        /// </summary>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <returns>Retourne la famille</returns>
        public Famille GetFamille(int RefFamille)
        {
            Famille Famille;
            // On met en place la commande Sql pour récuperer la famille
            String sql = "SELECT * FROM Familles WHERE RefFamille = '" + RefFamille + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            Famille = new Famille(rdr.GetInt32(0), rdr.GetString(1));
                            return Famille;
                        }
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// Récupere la reference d'une famille à partir de son nom,
        /// retourne -1 si la famille n'existe pas
        /// </summary>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>-1 si la famille existe, la reference de la famille sinon</returns>
        public int GetRefFamille(String Nom)
        {
            // On met en place la commande Sql pour récuperer la famille 
            String sql = "SELECT RefFamille FROM Familles WHERE Nom ='" + Nom + "'";

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
        /// Retourne Tous les Familles présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de famille</returns>
        public List<Famille> GetFamilles()
        {
            List<Famille> ListeFamille = new List<Famille>();

            // On met en place la commande Sql pour récuperer toutes les familles 
            String sql = "SELECT * FROM Familles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                       if(rdr.Read())
                        {
                            ListeFamille.Add(new Famille(rdr.GetInt32(0), rdr.GetString(1)));
                            while (rdr.Read())
                            {
                                ListeFamille.Add(new Famille(rdr.GetInt32(0), rdr.GetString(1)));
                            }
                            return ListeFamille;
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
        /// Supprime une famille 
        /// retroune vrai si la famille existe et a été supprimé
        /// </summary>
        /// <param name="RefFamille">Reference de la famille a supprimer</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean SupprimerFamille(string RefFamille)
        { 

            // On verfie si la famille n'existe pas 
            if (RefFamille == null || GetFamille(int.Parse(RefFamille)) == null)
            {
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            String sql = "DELETE FROM Familles WHERE RefFamille ='" + RefFamille + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Si l'article n'existe plus, on retourne vrai
            if (GetFamille(int.Parse(RefFamille)) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Modifie la famille dans la base de données
        /// </summary>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean ModifierFamille(string RefFamille, string Nom)
        {

            // On verfie si la famille n'existe pas 
            if (RefFamille == null || GetFamille(int.Parse(RefFamille)) == null)
            {
                return false;
            }

            // Si un nom est passé en paramètre on modifie le nom de la famille
            if (Nom != null)
            {
                String sql = "UPDATE Familles SET Nom ='" + Nom + "' WHERE RefFamille ='" + RefFamille + "'";
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
