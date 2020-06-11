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
    /// Classe permettant l'accés au données des Sous familles
    /// </summary>
    public class SousFamilleDAO
    {


        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        String Connexion = "Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite";
        /// <summary>
        /// Ajoute une sous famille à la base de données
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="NomFamille">Nom de la famille de la sous famille</param>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>0 si succés, -1 echec</returns>
        public int AjouterSousFamille(String NomFamille, String Nom)
        {
            // Si la sous famille existe on ne le crée pas
            if (Nom == null || GetRefSousFamille(Nom) != -1)
            {
                return -1;
            }
      
            // On recupere la reference de la famille de la sous famille à partir de son nom
            FamilleDAO DaoFamille = new FamilleDAO();
            int RefFamille = DaoFamille.GetRefFamille(NomFamille);

            // On execute la commande Sql pour ajouter la sous famille à la base de données
            String sql = "INSERT INTO SousFamilles(RefFamille, Nom) Values('" + RefFamille + "','" + Nom + "')";
            Console.Write("J'ajoute une sous famille avec les parametres " + RefFamille + "  et " + Nom);
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
        /// Supprime une famille 
        /// retroune vrai si la sous famille existe et a été supprimé
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille a supprimer</param>
        /// <returns>vrai si la sous famille existe et a été supprimé</returns>
        public Boolean SupprimerSousFamille(string RefSousFamille)
        {

            // On verfie si la sous famille n'existe pas 
            if (RefSousFamille == null || GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            String sql = "DELETE FROM SousFamilles WHERE RefSousFamille ='" + RefSousFamille + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Si l'article n'existe plus, on retourne vrai
            if (GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                return true;
            }
            return false;
 
        }

        /// <summary>
        /// Récupere la sous famille à partir de sa reference ,null si la sous famille n'existe pas
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille</param>
        /// <returns>Retourne la sous famille</returns>
        public SousFamille GetSousFamille(int RefSousFamille)
        {

            // On met en place la commande Sql pour récuperer la famille
            String sql = "SELECT * FROM SousFamilles WHERE RefSousFamille = '" + RefSousFamille + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            SousFamille SousFamille = new SousFamille(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2));
                            return SousFamille;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Récupere la reference d'une sous famille à partir de son nom,
        /// retourne -1 si la sous famille n'existe pas
        /// </summary>
        /// <param name="Nom">Nom de la sous famille</param>
        /// <returns></returns>
        public int GetRefSousFamille(String Nom)
        {

            // On met en place la commande Sql pour récuperer la sous famille 
            String sql = "SELECT RefSousFamille FROM SousFamilles WHERE Nom = '" + Nom + "'";

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
        /// Retourne Toutes les sous familles présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de sous familles</returns>
        public List<SousFamille> GetFamilles()
        {
            List<SousFamille> ListeSousFamille = new List<SousFamille>();

            // On met en place la commande Sql pour récuperer toutes les familles 
            String sql = "SELECT * FROM SousFamilles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            ListeSousFamille.Add(new SousFamille(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2)));
                            while (rdr.Read())
                            {
                                ListeSousFamille.Add(new SousFamille(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2)));
                            }
                            return ListeSousFamille;
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
        /// Modifie la sous famille de la base de données
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille</param>
        /// <param name="Nom">Nom de la sous famille</param>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean ModifierSousFamille(string RefSousFamille, string Nom, int RefFamille)
        {

            // On verfie si la famille n'existe pas 
            if (RefSousFamille == null || GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                return false;
            }

            // Si un nom est passé en paramètre on modifie le nom de la sous famille
            if (Nom != null)
                {
                    String sql = "UPDATE SousFamilles SET Nom ='" + Nom + "' WHERE RefSousFamille ='" + RefSousFamille + "'";
                    using (SQLiteConnection c = new SQLiteConnection(Connexion))
                    {
                        c.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
            }

            // Si une Reference de famille est passé en paramètre on modifie la famille de la sous famille
            if (RefFamille != -1)
            {
                String sql = "UPDATE SousFamilles SET RefFamille ='" + RefFamille + "' WHERE RefSousFamille ='" + RefSousFamille + "'";
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

