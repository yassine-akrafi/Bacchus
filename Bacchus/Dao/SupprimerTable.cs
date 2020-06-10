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
            SQLiteConnection Connexion = new SQLiteConnection("Data Source=C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
            Connexion.Open();

            //Suppression de la table familles
            SQLiteCommand DeleteFamilles = Connexion.CreateCommand();
            DeleteFamilles.CommandText = "Delete From Familles ";
            SQLiteDataReader ReadRequeteFamilles = DeleteFamilles.ExecuteReader();

            //suppression de la table sous-familles
            SQLiteCommand DeleteSousFamilles = Connexion.CreateCommand();
            DeleteSousFamilles.CommandText = "Delete From SousFamilles ";
            SQLiteDataReader ReadRequeteSousFamilles = DeleteSousFamilles.ExecuteReader();

            //suppresion de la table marque
            SQLiteCommand DeleteMarque = Connexion.CreateCommand();
            DeleteMarque.CommandText = "Delete From Marques ";
            SQLiteDataReader ReadRequeteMarque = DeleteMarque.ExecuteReader();

            //suppression de la table articles
            SQLiteCommand DeleteArticles = Connexion.CreateCommand();
            DeleteArticles.CommandText = "Delete From Articles ";
            SQLiteDataReader ReadRequeteArticles = DeleteArticles.ExecuteReader();

            Connexion.Close();
        }
    }
}
