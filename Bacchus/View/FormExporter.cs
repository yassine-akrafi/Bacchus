using Bacchus.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{
    /// <summary>
    /// Classe de la vue de l'exportation de la base de données
    /// </summary>
    public partial class FormExporter : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe FormExporter
        /// </summary>
        public FormExporter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque on souhaite selectionner un dossier
        /// </summary>
        private void SelectionDossier_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();
            this.label1.Text = openFolderDialog.SelectedPath;
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fonction appelé lorsque on souhaite exporter la base de donénes
        /// </summary>
        private void Exporter_Click(object sender, EventArgs e)
        {
            //On recupere le dossier selectionnée et on appel la fonction ExporterCsv
            ExportCsv CsvExport = new ExportCsv();
            int ResultatExport;

            this.progressBar1.Increment(50);

            ResultatExport = CsvExport.ExporterCsv(this.label1.Text);

            this.progressBar1.Increment(100);

            // Message affiché à la fin de l'importation
            this.textStatus.Text = "Le fichier a été exporté avec succés";
        }

        private void FormExporter_Load(object sender, EventArgs e)
        {

        }
    }
}
