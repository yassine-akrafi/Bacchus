using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
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

        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        String Connexion = "Data Source= Dao//Bacchus.SQLite";
        
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
                return -1;
            }
            else
            {

                // On recupere la reference de la sous famille de l'article à partir du nom
                SousFamilleDAO SousDaoFamille = new SousFamilleDAO();
                int ReferenceSousFamille = SousDaoFamille.GetRefSousFamille(NomSousFamille);

                // On recupere la reference de la marque de l'article à partir du nom
                MarqueDao DaoMarque = new MarqueDao();
                int ReferenceMarque = DaoMarque.GetRefMarque(NomMarque);

                // On execute la commande Sql pour ajouter l'article à la base de données
                String sql = "INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES ('" + RefArticle + "','" + Description + "','" + ReferenceSousFamille + "','" + ReferenceMarque + "','" + Prix + "','" + 10 + "')"; ;
                using (SQLiteConnection c = new SQLiteConnection(Connexion))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return 0;


            }
        }

        /// <summary>
        /// Récupere la reference d'un article à partir de son nom,
        /// retourne -1 si l'article n'existe pas, 0 sinon
        /// </summary>
        /// <param name="RefArticle">Reference de l'article</param>
        /// <returns></returns>
        public int GetRefArticle(String RefArticle)
        {
            // On met en place la commande Sql pour récuperer l'article 
            String sql = "SELECT RefArticle FROM Articles WHERE RefArticle ='" + RefArticle + "'";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if(rdr.Read())
                        {
                            return 0;
                        }
                        else
                        {
                            return -1;
                        }
                        
                    }
                }
            }
        }

        /// <summary>
        /// Verifie si un article existe à partir de sa reference
        /// retourne -1 si l'article n'existe pas, 0 sinon
        /// </summary>
        /// <param name="RefArticle">Reference de l'article</param>
        /// <returns></returns>
        public int RefArticleExiste(String RefArticle)
        {

            // On met en place la commande Sql pour récuperer l'article 
            String sql = "SELECT RefArticle FROM Articles WHERE RefArticle = '" + RefArticle+"'";
           
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
        /// Retourne Tous les Articles présents dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Article> GetArticles()
        {
            //Liste d'articles à retourner
            List<Article> ListeArticles;
            int NombreArticles = 0;
            // On met en place la commande Sql pour récuperer tous les articles 
            String sql = "SELECT * FROM Articles";
            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        ListeArticles = new List<Article>();
                       
                        while (rdr.Read())
                        {
 

                            try
                            {
                                float Prix = float.Parse(rdr.GetString(4));
                                ListeArticles.Add(new Article(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3), Prix, rdr.GetInt32(5)));
                                NombreArticles++;
                            }
                            catch(Exception)
                            {
                                try
                                {
                                    float Prix = (float)rdr.GetInt32(4);
                                    ListeArticles.Add(new Article(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3), Prix, rdr.GetInt32(5)));
                                    NombreArticles++;
                                }
                                catch (Exception)
                                {
                                    float Prix = (float)rdr.GetFloat(4);
                                    ListeArticles.Add(new Article(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3), Prix, rdr.GetInt32(5)));
                                    NombreArticles++;
                                }
                            }
                        }
                        
                    }
                }
            }

            if (NombreArticles == 0)
            {
                return null;
            }
            else
            {
                return ListeArticles;
            }

            
        }

        /// <summary>
        /// Supprime un article de la base de données,
        /// retroune vrai si l'article existe et a été supprimé
        /// </summary>
        /// <param name="RefArticle">Reference de l'article à supprimer</param>
        /// <returns></returns>
        public Boolean SupprimerArticle(string RefArticle)
        {
            // On verfie si l'article n'existe pas 
            if(RefArticleExiste(RefArticle) == -1)
            {
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            String sql = "DELETE FROM Articles WHERE RefArticle ='" + RefArticle + "'";

            using (SQLiteConnection c = new SQLiteConnection(Connexion))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Si l'article n'existe plus, on retourne vrai
            if (RefArticleExiste(RefArticle) == 0)
            {
                return true;
            }
            else
            {
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

            // On verfie, si l'article n'existe pas on retourne false 
            if (RefArticle == null || RefArticleExiste(RefArticle) == -1)
            {
                return false;
            }

            // Si une description est passé en paramètre on modifie la description de l'article
            if (Description != null)
            {
                String sql = "UPDATE Articles SET Description ='" + Description+ "' WHERE RefArticle ='" + RefArticle + "'";

                using (SQLiteConnection c = new SQLiteConnection(Connexion))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Si la reference d'une sous famille est passé en paramètre on modifie la sous famille de l'article
            if (RefSousFamille != -1)
            {

                String sql = "UPDATE Articles SET RefSousFamille ='" + RefSousFamille + "' WHERE RefArticle ='" + RefArticle + "'";

                using (SQLiteConnection c = new SQLiteConnection(Connexion))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Si une marque est passé en paramètre on modifie la marque de l'article
            if (RefMarque != -1)
            {
                String sql = "UPDATE Articles SET RefMarque ='" + RefMarque + "' WHERE RefArticle ='" + RefArticle + "'";

                using (SQLiteConnection c = new SQLiteConnection(Connexion))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Si un prix est passé en paramètre on modifie le prix de l'article
            if (Prix != -1)
            {
                String sql = "UPDATE Articles SET PrixHT ='" + Prix + "' WHERE RefArticle ='" + RefArticle + "'";

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
