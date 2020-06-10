using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Dao
{

    public class ExportCsv
    {

        public String Descritpion { get; set; }
        public String Ref { get; set; }
        public String Marque { get; set; }
        public String Famille { get; set; }
        public String SousFamille { get; set; }

        public String Prix { get; set; }


        public void ExporterCsv(String Path)
        {
 
            MarqueDao DaoMarque = new MarqueDao();
            FamilleDAO DaoFamille = new FamilleDAO();
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            ArticleDao DaoArticle = new ArticleDao();

            List<Article> ListesArticles = new List<Article>();
            ListesArticles = DaoArticle.TrouverArticles();

            List<ExportCsv> ListeAExporter = new List<ExportCsv>();
            foreach (Article article in ListesArticles)
            {
                ExportCsv LigneAAjouter = new ExportCsv();
                LigneAAjouter.Descritpion = article.Description1;
                LigneAAjouter.Ref = article.RefArticle1;
                LigneAAjouter.Marque = DaoMarque.TrouverParId(article.RefMarque1).Nom1;
                LigneAAjouter.Famille = DaoFamille.TrouverParId(DaoSousFamille.TrouverParId(article.RefSousFamille1).RefFamille1).Nom1;
                LigneAAjouter.SousFamille = DaoSousFamille.TrouverParId(article.RefSousFamille1).Nom1;
                LigneAAjouter.Prix = ""+article.PrixHT1;

                ListeAExporter.Add(LigneAAjouter);
            }
            Console.WriteLine("---------------------------------");
            foreach (ExportCsv export in ListeAExporter)
            {
                Console.WriteLine(export.Famille);
            }
            Console.WriteLine("---------------------------------");
            String path = Path + "\\DonnesExporter.csv";

            Console.WriteLine("Voila le path ou on crée le fichier : "+path);
            bool errorL = WriteFile<ExportCsv>(path, ListeAExporter);

        }

        public bool WriteFile<T>(string _path, List<T> _ListeAExporter) where T : class
        {
            Console.WriteLine("On est rentrée dans le WriteFile");
            CultureInfo test = new CultureInfo("fr-FR",false);
            CsvHelper.Configuration.CsvConfiguration CsvConf = new CsvHelper.Configuration.CsvConfiguration(test) { Delimiter = ";" };
            try
            {
                Console.WriteLine("On va rentrer dans le using");
                using (TextWriter tr = new StreamWriter(_path, true, Encoding.GetEncoding(1252)))
                {
                    Console.WriteLine("On rentre dans le using");

                    Console.WriteLine("On affecte la variable csv");
                    var csv = new CsvWriter(tr, CsvConf);

                    Console.WriteLine("On met le liste dans le csv");
                    csv.WriteRecords(_ListeAExporter);
                }
                return false;
            }
            catch(Exception)
            {
                Console.WriteLine("On est pas rentrer dans le try");
                return true;
            }
        }
    }
}
