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
    /// Classe de la vue d'importation Csv
    /// </summary>
    public partial class FormImporter : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe FormImporter
        /// </summary>
        public FormImporter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque on souhaite selectionner un fichier
        /// </summary>
        private void SelectionnerFichier_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "csv";
            openFileDialog.Filter = "Fichier CSV (*.csv)|*.csv";
            openFileDialog.ShowDialog();
            String NomFichier = openFileDialog.FileName;
            this.File_Name_TextBox.Text = NomFichier;
        }

        /// <summary>
        /// Fonction appelé lorsque on souhaite importer un fichier csv en mode ajout
        /// </summary>
        private void ImporterAjout_Click(object sender, EventArgs e)
        {

            //Si aucun fichier n'a été selectionnée on ne fait rien
            if (this.File_Name_TextBox.Text != "")
            {

                //On recupere le fichier selectionnée et on se met en mode lecture
                System.IO.TextReader Reader = new System.IO.StreamReader(this.File_Name_TextBox.Text);
                string Line = Reader.ReadLine();
                int CountLines = Line.Length;

                //Pour chaque ligne du fichier Csv on appel la fonction ImporterLigneCsv
                ImportCsv Import = new ImportCsv();
                while (Line != null)
                {
                    Console.Write("Form Importer Je retourne la ligne :" + Line+" pour import");
                    Line = Reader.ReadLine();
                    CountLines++;

                    //Barre de progression
                    this.progressBar1.Increment(CountLines);

                    Import.ImporterLigneCsv(Line);
                }

                // Message affiché à la fin de l'importation
                this.textStatus.Text = "Le fichier importé est :" + this.File_Name_TextBox.Text + ", " + CountLines + " lignes ont été ajoutés à la base de données .";
            }
        }

        /// <summary>
        /// Fonction appelé lorsque on souhaite importer un fichier csv en mode écraser
        /// </summary>
        private void ImporterEcrasement_Click(object sender, EventArgs e)
        {
            //Si aucun fichier n'a été selectionnée on ne fait rien
            if (this.File_Name_TextBox.Text != "")
            {
                //On recupere le ficheir selectionnée et on se met en mode lecture
                System.IO.TextReader Reader = new System.IO.StreamReader(this.File_Name_TextBox.Text);

                //On supprimer toutes les tables de la base de données
                SupprimerTable Ecraser = new SupprimerTable();
                Ecraser.SupprimerToutesTable();

                string Line = Reader.ReadLine();
                int CountLines = Line.Length;

                //Pour chaque ligne du fichier Csv on appel la fonction ImporterLigneCsv
                ImportCsv Import = new ImportCsv();
                while (Line != null)
                {
                    Line = Reader.ReadLine();
                    CountLines++;

                    //Barre de progression
                    this.progressBar1.Increment(CountLines);

                    Import.ImporterLigneCsv(Line);
                }
                // Message affiché à la fin de l'importation
                this.textStatus.Text = "Le fichier importé est :" + this.File_Name_TextBox.Text + ", " + CountLines + " lignes ont été ajoutés à la base de données .";
            }
        }
    }
}
