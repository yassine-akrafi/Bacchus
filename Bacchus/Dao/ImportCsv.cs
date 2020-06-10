using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{
    public class ImportCsv
    {
        public void ImporterLigneCsv(String Line)
        {
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


                MarqueDao DaoMarque = new MarqueDao();
                FamilleDAO DaoFamille = new FamilleDAO();
                SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                ArticleDao DaoArticle = new ArticleDao();

                
                DaoFamille.AjouterFamille(Famille);
                DaoMarque.AjouterMarque(Marque);
                DaoSousFamille.AjouterSousFamille(Famille,SousFamille);
                DaoArticle.AjouterArticle(Ref, Description, SousFamille, Marque, float.Parse(Prix));

                Console.WriteLine("Famille = "+Famille + " Marque = "+Marque + " Article = "+Ref+" SousFamille = "+SousFamille);

            }


            Console.WriteLine("Je suis dans import avant close");
            Connexion.Close();
            Console.WriteLine("Je suis dans import apres close");
        }
    }
}
