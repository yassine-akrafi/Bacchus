using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permettant l'accés au données des Articles
    /// </summary>
    /// 
    public class ArticleDao
    {
        //**************A enleverrrrrr

        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        /// <summary>
        /// Ajoute un article dans la base de données, 
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="RefArticle">Reference de l'article</param>
        /// <param name="Description">Description de l'article</param>
        /// <param name="NomSousFamille">Nom de la sous famille de l'article</param>
        /// <param name="NomMarque">Nom de la marque de l'article</param>
        /// <param name="Prix">Prix de l'article</param>
        /// <returns></returns>
        public int AjouterArticle(String RefArticle, String Description, String NomSousFamille, String NomMarque, float Prix)
        {

            // Si l'article existe on ne le crée pas
            if (GetRefArticle(RefArticle) != -1)
            {
                Connexion.Close();
                return -1;
            }
            else
            {
                // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
                if ((ConnectionState.Closed == Connexion.State))
                {
                    Connexion.Open();
                }

                // On recupere la reference de la sous famille de l'article à partir du nom
                SousFamilleDAO SousDaoFamille = new SousFamilleDAO();
                int ReferenceSousFamille = SousDaoFamille.GetRefSousFamille(NomSousFamille);

                // On recupere la reference de la marque de l'article à partir du nom
                MarqueDao DaoMarque = new MarqueDao();
                int ReferenceMarque = DaoMarque.GetRefMarque(NomMarque);

                try
                {
                    // On execute la commande Sql pour ajouter l'article à la base de données
                    SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (:RefArticle, :Description, :RefSousFamille, :RefMarque, :PrixHT,10)", Connexion);
                    CommandInsert.Parameters.AddWithValue(":RefArticle", RefArticle);
                    CommandInsert.Parameters.AddWithValue(":Description", Description);
                    CommandInsert.Parameters.AddWithValue(":RefSousFamille", ReferenceSousFamille);
                    CommandInsert.Parameters.AddWithValue(":RefMarque", ReferenceMarque);
                    CommandInsert.Parameters.AddWithValue(":PrixHT", Prix);
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
        }

        /// <summary>
        /// Récupere la reference d'un article à partir de son nom,
        /// retourne -1 si l'article n'existe pas, 0 sinon
        /// </summary>
        /// <param name="Description">Description de l'article</param>
        /// <returns></returns>
        public int GetRefArticle(String Description)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer l'article 
            SQLiteCommand Command = new SQLiteCommand("SELECT RefArticle FROM Articles WHERE Description = :Description", Connexion);
            Command.Parameters.AddWithValue(":Description", Description);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe
            if (Reader.Read())
            {
                Connexion.Close();
                return 0;
            }
            Connexion.Close();
            return -1;
        }

        /// <summary>
        /// Verifie si un article existe à partir de sa reference
        /// retourne -1 si l'article n'existe pas, 0 sinon
        /// </summary>
        /// <param name="RefArticle">Reference de l'article</param>
        /// <returns></returns>
        public int RefArticleExiste(String RefArticle)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer l'article 
            SQLiteCommand Command = new SQLiteCommand("SELECT RefArticle FROM Articles WHERE RefArticle = :RefArticle", Connexion);
            Command.Parameters.AddWithValue(":RefArticle", RefArticle);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe
            if (Reader.Read())
            {
                Connexion.Close();
                return 0;
            }
            Connexion.Close();
            return -1;
        }


        /// <summary>
        /// Retourne Tous les Articles présents dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Article> GetArticles()
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer tous les articles 
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Articles", Connexion);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On crée une listes d'articles et on lui ajoute tous les articles recupérés à partir de la commande sql
            List<Article> ListeArticles = new List<Article>();
            while (Reader.Read())
            {
                ListeArticles.Add(new Article(Reader.GetString(0), Reader.GetString(1), Reader.GetInt32(2), Reader.GetInt32(3), Reader.GetFloat(4), Reader.GetInt32(5)));
            }

            Connexion.Close();
            return ListeArticles;
        }

        /// <summary>
        /// Supprime un article de la base de données,
        /// retroune vrai si l'article existe et a été supprimé
        /// </summary>
        /// <param name="RefArticle">Reference de l'article à supprimer</param>
        /// <returns></returns>
        public Boolean SupprimerArticle(string RefArticle)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie si l'article n'existe pas 
            if(RefArticleExiste(RefArticle) == -1)
            {
                Connexion.Close();
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM Articles WHERE RefArticle = :RefArticle", Connexion);
            Command.Parameters.AddWithValue(":RefArticle", RefArticle);
            Command.ExecuteNonQuery();

            // Si l'article n'existe plus, on retourne vrai
            if (RefArticleExiste(RefArticle) == 0)
            {
                Connexion.Close();
                return true;
            }
            else
            {
                Connexion.Close();
                return false;
            }
        }


        /// <summary>
        /// Modifie un article dans la base de données
        /// </summary>
        /// <param name="RefArticle">Reference de l'article</param>
        /// <param name="Description">Description de l'article</param>
        /// <param name="RefSousFamille">Reference de la sous famille de l'article</param>
        /// <param name="RefMarque">Reference de la marque de l'article </param>
        /// <param name="Prix">Prix de l'article</param>
        /// <returns></returns>
        public Boolean ModifierArticle(String RefArticle, String Description, int RefSousFamille, int RefMarque, float Prix)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie, si l'article n'existe pas on retourne false 
            if (RefArticleExiste(RefArticle) == -1)
            {
                Connexion.Close();
                return false;
            }

            // Si une description est passé en paramètre on modifie la description de l'article
            if (Description != null)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET Description = :Description WHERE RefArticle = :RefArticle", Connexion);
                Command.Parameters.AddWithValue(":RefArticle", RefArticle);
                Command.Parameters.AddWithValue(":Description", Description);
                Command.ExecuteNonQuery();
            }

            // Si la reference d'une sous famille est passé en paramètre on modifie la sous famille de l'article
            if (RefSousFamille != -1)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET RefSousFamille = :RefSousFamille WHERE RefArticle = :RefArticle", Connexion);
                Command.Parameters.AddWithValue(":RefArticle", RefArticle);
                Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);
                Command.ExecuteNonQuery();
            }

            // Si une marque est passé en paramètre on modifie la marque de l'article
            if (RefMarque != -1)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET RefMarque = :RefMarque WHERE RefArticle = :RefArticle", Connexion);
                Command.Parameters.AddWithValue(":RefArticle", RefArticle);
                Command.Parameters.AddWithValue(":RefMarque", RefMarque);
                Command.ExecuteNonQuery();
            }

            // Si un prix est passé en paramètre on modifie le prix de l'article
            if (Prix != -1)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET PrixHT = :Prix WHERE RefArticle = :RefArticle", Connexion);
                Command.Parameters.AddWithValue(":RefArticle", RefArticle);
                Command.Parameters.AddWithValue(":Prix", Prix);
                Command.ExecuteNonQuery();
            }

            Connexion.Close();
            return true;


        }
    }
}
