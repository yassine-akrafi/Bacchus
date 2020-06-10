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
    public partial class FormImporter : Form
    {
        public FormImporter()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "csv";
            openFileDialog.Filter = "Fichier CSV (*.csv)|*.csv";
            openFileDialog.ShowDialog();
            String NomFichier = openFileDialog.FileName;
            this.File_Name_TextBox.Text = NomFichier;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.File_Name_TextBox.Text != "")
            {
                System.IO.TextReader Reader = new System.IO.StreamReader(this.File_Name_TextBox.Text);

                string Line = Reader.ReadLine();
                int CountLines = Line.Length;
                ImportCsv Import = new ImportCsv();
                while (Line != null)
                {
                    Line = Reader.ReadLine();
                    CountLines++;
                    this.progressBar1.Increment(CountLines);
                    Import.ImporterLigneCsv(Line);
                }
                this.textBox1.Text = "Le fichier importé est :" + this.File_Name_TextBox.Text + ", " + CountLines + " lignes ont été ajoutés à la base de données .";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.File_Name_TextBox.Text != "")
            {
                System.IO.TextReader Reader = new System.IO.StreamReader(this.File_Name_TextBox.Text);
                SupprimerTable Ecraser = new SupprimerTable();
                Ecraser.SupprimerToutesTable();
                string Line = Reader.ReadLine();
                int CountLines = Line.Length;
                ImportCsv Import = new ImportCsv();
                while (Line != null)
                {
                    Line = Reader.ReadLine();
                    CountLines++;
                    this.progressBar1.Increment(CountLines);
                    Import.ImporterLigneCsv(Line);
                }
                this.textBox1.Text = "Le fichier importé est :" + this.File_Name_TextBox.Text + ", " + CountLines + " lignes ont été ajoutés à la base de données .";
            }
        }
    }
}
