using Bacchus.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain FenetrePrinciaple = new FormMain();

            List<Marque> listMarques = new List<Marque>();
            List<Famille> listFamille = new List<Famille>();
            List<SousFamille> SsListFamille = new List<SousFamille>();
            List<Article> listArticles = new List<Article>();
            SupprimerTable suppr = new SupprimerTable();
            suppr.SupprimerToutesTable();
            MarqueDao DaoMarque = new MarqueDao();
            listMarques = DaoMarque.GetMarques();

            FamilleDAO DaoFamille = new FamilleDAO();
            listFamille = DaoFamille.GetFamilles();

           SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            SsListFamille = DaoSousFamille.GetFamilles();

            ArticleDao DaoArticle = new ArticleDao();
            listArticles = DaoArticle.GetArticles();

            FenetrePrinciaple.ListFamilles1 = listFamille;
            FenetrePrinciaple.ListSousFamilles1 = SsListFamille;
            FenetrePrinciaple.ListMarques1 = listMarques;
            FenetrePrinciaple.ListArticles1 = listArticles;

            Application.Run(FenetrePrinciaple);

        }
    }
}
