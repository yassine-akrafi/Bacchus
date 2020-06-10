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

            Article article1 = new Article("Chaussures", "Test", 1, 1, 15, 2);
            Famille famille1 = new Famille(1, "Baskets");
            SousFamille sfamille1 = new SousFamille(1, "SousFamilleTest");
            Marque marquetest = new Marque(1, "Adidas");

            listMarques.Add(marquetest);
            listFamille.Add(famille1);
            SsListFamille.Add(sfamille1);
            listArticles.Add(article1);

          

            
            MarqueDao DaoMarque = new MarqueDao();
            listMarques = DaoMarque.TrouverMarques();

            FamilleDAO DaoFamille = new FamilleDAO();
            listFamille = DaoFamille.GetFamilles();

           SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            SsListFamille = DaoSousFamille.TrouverSousFamilles();

            ArticleDao DaoArticle = new ArticleDao();
            listArticles = DaoArticle.GetArticles();

            FenetrePrinciaple.ListFamilles1 = listFamille;
            FenetrePrinciaple.ListSousFamilles1 = SsListFamille;
            FenetrePrinciaple.ListMarques1 = listMarques;
            FenetrePrinciaple.ListArticles1 = listArticles;
            //Console.WriteLine(Leslie);

            Application.Run(FenetrePrinciaple);

        }
    }
}
