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
    /// <summary>
    /// Cette classe permet de faire l'export CSV
    /// </summary>
    public class ExportCsv
    {

        public String Descritpion { get; set; }

        public String Ref { get; set; }

        public String Marque { get; set; }

        public String Famille { get; set; }

        public String SousFamille { get; set; }

        public String Prix { get; set; }

        /// <summary>
        /// Cette fonction permet de faire l'export CSV
        /// </summary>
        /// <param name="Path">Le chemin du dossier dans lequel on exporte les informations contenues dans la base de donne</param>
        public void ExporterCsv(String Path)
        {
            //On declare et initialise les dao
            MarqueDao DaoMarque = new MarqueDao();
            FamilleDAO DaoFamille = new FamilleDAO();
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            ArticleDao DaoArticle = new ArticleDao();

            //On déclare et initialise la liste des articles
            List<Article> ListesArticles = new List<Article>();
            ListesArticles = DaoArticle.GetArticles();

            List<ExportCsv> ListeAExporter = new List<ExportCsv>();
            foreach (Article article in ListesArticles)
            {
                ExportCsv LigneAAjouter = new ExportCsv();
                LigneAAjouter.Descritpion = article.Description1;
                LigneAAjouter.Ref = article.RefArticle1;
                LigneAAjouter.Marque = DaoMarque.GetMarque(article.RefMarque1).Nom1;
                LigneAAjouter.Famille = DaoFamille.GetFamille(DaoSousFamille.GetSousFamille(article.RefSousFamille1).RefFamille1).Nom1;
                LigneAAjouter.SousFamille = DaoSousFamille.GetSousFamille(article.RefSousFamille1).Nom1;
                LigneAAjouter.Prix = ""+article.PrixHT1;

                ListeAExporter.Add(LigneAAjouter);
            }
         
            String path = Path + "\\DonnesExporter.csv";

            WriteFile<ExportCsv>(path, ListeAExporter);

        }

       /// <summary>
       /// Cette fonction permet de creer et d'ecrire les donnees dans le fichier CSV
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="_path">Le chemin du dossier dans lequel sera contenues les données à exporter</param>
       /// <param name="_ListeAExporter">La liste des elements à exporter</param>
       /// <returns></returns>
        public bool WriteFile<T>(string _path, List<T> _ListeAExporter) where T : class
        {
            CultureInfo test = new CultureInfo("fr-FR",false);
            CsvHelper.Configuration.CsvConfiguration CsvConf = new CsvHelper.Configuration.CsvConfiguration(test) { Delimiter = ";" };
            try
            {
                using (TextWriter tr = new StreamWriter(_path, true, Encoding.GetEncoding(1252)))
                {

                    var csv = new CsvWriter(tr, CsvConf);

                    csv.WriteRecords(_ListeAExporter);
                }
                return false;
            }
            catch(Exception)
            {
                return true;
            }
        }
    }
}
