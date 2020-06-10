using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{
    /// <summary>
    /// Cette classe permet de faire l'import CSV
    /// </summary>
    public class ImportCsv
    {
        /// <summary>
        /// Cette fonction permet d'importer 
        /// </summary>
        /// <param name="Line">Correspond à la ligne à importer</param>
        public void ImporterLigneCsv(String Line)
        {
            //Initialise la connexion à la bdd
            SQLiteConnection Connexion = new SQLiteConnection("Data Source=C:\\Users\\Lenovo\\Desktop\\Cours\\.Net\\TP\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");
            Connexion.Open();

            
            String Description;
            String Ref;
            String Marque;
            String Famille;
            String SousFamille;
            String Prix;
            int Index1;

            if (Line != null)
            {
                Index1 = Line.IndexOf(';');
                Description = Line.Substring(0, Index1 );

                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Ref = Line.Substring(0, Index1);

                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Marque = Line.Substring(0, Index1);

                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Famille = Line.Substring(0, Index1 );

                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                SousFamille = Line.Substring(0, Index1 );

                Line = Line.Substring(Index1 + 1);
                Prix = Line;

                // On ajoute la marque à la base de donnees
                MarqueDao DaoMarque = new MarqueDao();
                DaoMarque.AjouterMarque(Marque);

                // On ajoute la famille à la base de donnees
                FamilleDAO DaoFamille = new FamilleDAO();
                DaoFamille.AjouterFamille(Famille);

                // On ajoute la sous-famille à la base de donnees
                SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                DaoSousFamille.AjouterSousFamille(Famille, SousFamille);

                // On ajoute l'article à la base de donnees
                ArticleDao DaoArticle = new ArticleDao();   
                DaoArticle.AjouterArticle(Ref, Description, SousFamille, Marque, float.Parse(Prix));


            }


            Connexion.Close();
        }
    }
}
