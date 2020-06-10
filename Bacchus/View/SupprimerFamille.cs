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

namespace Bacchus.View
{
    public partial class SupprimerFamille : Form
    {
        public SupprimerFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilleDAO DaoFamille = new FamilleDAO();

            string RefFamille = this.textBox1.Text;

            if (RefFamille != "")
            {
                DaoFamille.SupprimerFamille(RefFamille);
            }
        }
    }
}
