using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permet de supprimer les tables
    /// </summary>
    /// 
    public class SupprimerTable
    {
        /// <summary>
        /// Cette fonction permet de supprimer toutes les tables
        /// </summary>
        public void SupprimerToutesTable()
        {
            //SQLiteConnection Connexion = new SQLiteConnection("Data Source=C:\\Users\\Lenovo\\Desktop\\Cours\\.Net\\TP\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
            String Connexion = "Data Source= C:\\Users\\Lenovo\\Desktop\\Cours\\.Net\\TP\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite";

            //Suppression de la table familles
            String sql = "DELETE From Familles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            //suppression de la table sous-familles
            sql = "DELETE From SousFamilles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            //suppresion de la table marque
            sql = "DELETE From Marques";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            //suppression de la table articles
            sql = "DELETE From Articles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
