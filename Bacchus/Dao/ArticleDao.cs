using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{
    public class ArticleDao
    {
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source=C:\\Users\\Lenovo\\Desktop\\Cours\\.Net\\TP\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        public int AjouterArticle(String RefArticle, String Description, String RefSousFamille, String RefMarque, float Prix)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }


            int SfIfExists = TrouverParNom(RefArticle);

            if (SfIfExists != -1)
            {
                Connexion.Close();
                return 0;
            }
            else
            {
                if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
                {
                    Connexion.Open();
                }
                SousFamilleDAO SousDaoFamille = new SousFamilleDAO();
                MarqueDao DaoMarque = new MarqueDao();
                int SousFamille = SousDaoFamille.TrouverParNom(RefSousFamille);
                int Marque = DaoMarque.TrouverParNom(RefMarque);

                    SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (:RefArticle, :Description, :RefSousFamille, :RefMarque, :PrixHT,10)", Connexion);
                    CommandInsert.Parameters.AddWithValue(":RefArticle", RefArticle);
                    CommandInsert.Parameters.AddWithValue(":Description", Description);
                    CommandInsert.Parameters.AddWithValue(":RefSousFamille", SousFamille);
                    CommandInsert.Parameters.AddWithValue(":RefMarque", Marque);
                    CommandInsert.Parameters.AddWithValue(":PrixHT", Prix);
                    CommandInsert.ExecuteNonQuery();
             
            }
            Connexion.Close();
            return 1;
        }


        public int TrouverParNom(String Nom)
        {
            SQLiteCommand Command = new SQLiteCommand("SELECT RefArticle FROM Articles WHERE RefArticle = :RefArticle", Connexion);
            Command.Parameters.AddWithValue(":RefArticle", Nom);
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                Connexion.Close();
                return 0;
            }
            Connexion.Close();
            return -1;
        }

        public int TrouverParDescription(String Nom)
        {
            SQLiteCommand Command = new SQLiteCommand("SELECT RefArticle FROM Articles WHERE Description = :Description", Connexion);
            Command.Parameters.AddWithValue(":Description", Nom);
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            SQLiteDataReader Reader = Command.ExecuteReader();
            if (Reader.Read())
            {
                Connexion.Close();
                return 0;
            }
            Connexion.Close();
            return -1;
        }

        public List<Article> TrouverArticles()
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Articles", Connexion);
            SQLiteDataReader Reader = Command.ExecuteReader();
            List<Article> ListeArticles = new List<Article>();
            while (Reader.Read())
            {
                ListeArticles.Add(new Article(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), Reader.GetFloat(4), Reader.GetInt32(5)));
            }
            Connexion.Close();
            return ListeArticles;
        }

        public Boolean SupprimerArticle(string RefArticle)
        {
            if ((Connexion == null) || (ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }
            if (TrouverParNom(RefArticle) != -1)
            {
                Connexion.Close();
                return false;
            }
            else
            {
                SQLiteCommand Command = new SQLiteCommand("DELETE FROM Articles WHERE RefArticle = :RefArticle", Connexion);
                Command.Parameters.AddWithValue(":RefArticle", RefArticle);
                Command.ExecuteNonQuery();
                if (TrouverParNom(RefArticle) != -1)
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
