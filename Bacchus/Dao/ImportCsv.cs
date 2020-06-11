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
    /// Cette classe permet de faire l'import CSV
    /// </summary>
    public class ImportCsv
    {
        /// <summary>
        /// Cette fonction permet d'importer des données dans une ligne  
        /// </summary>
        /// <param name="Line">Correspond à la ligne à importer</param>
        public void ImporterLigneCsv(String Line)
        {  
            String Description;
            String Ref;
            String Marque;
            String Famille;
            String SousFamille;
            String Prix;

            //Variable qui nous permet de nous situé dans notre chaine de caractères
            int Index1;

            if (Line != null)
            {
                //On recupere la description de l'article
                Index1 = Line.IndexOf(';');
                Description = Line.Substring(0, Index1 );

                //On recupere la reference de l'article
                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Ref = Line.Substring(0, Index1);

                //On recupere la marque de l'article
                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Marque = Line.Substring(0, Index1);

                //On recupere la famille de l'article
                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                Famille = Line.Substring(0, Index1 );

                //On recupere la sous famille de l'article
                Line = Line.Substring(Index1 + 1);
                Index1 = Line.IndexOf(';');
                SousFamille = Line.Substring(0, Index1 );

                //On recupere le prix de l'article
                Line = Line.Substring(Index1 + 1);
                Prix = Line;

                // On ajoute la marque récuperé à la base de donnees
                MarqueDao DaoMarque = new MarqueDao();
                DaoMarque.AjouterMarque(Marque);

                // On ajoute la famille récuperé à la base de donnees
                FamilleDAO DaoFamille = new FamilleDAO();
                DaoFamille.AjouterFamille(Famille);

                // On ajoute la sous-famille récuperé à la base de donnees
                SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                DaoSousFamille.AjouterSousFamille(Famille, SousFamille);

                // On ajoute l'article récuperé à la base de donnees
                ArticleDao DaoArticle = new ArticleDao();   
                DaoArticle.AjouterArticle(Ref, Description, SousFamille, Marque, float.Parse(Prix));
            }
        }
    }
}
