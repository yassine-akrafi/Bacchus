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
    public partial class FormExporter : Form
    {
        public FormExporter()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();
            this.label1.Text = openFolderDialog.SelectedPath;
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportCsv CsvExport = new ExportCsv();
            Console.WriteLine("On appel la fonction Exporter Csv avec la path "+ this.label1.Text);

            CsvExport.ExporterCsv(this.label1.Text);
        }

        private void FormExporter_Load(object sender, EventArgs e)
        {

        }
    }
}
