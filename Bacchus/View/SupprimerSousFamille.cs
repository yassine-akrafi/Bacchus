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
    public partial class SupprimerSousFamille : Form
    {
        public SupprimerSousFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();

            string RefSousFamille = this.textBox1.Text;

            if (RefSousFamille != "")
            {
                DaoSousFamille.SupprimerSousFamille(RefSousFamille);
            }
        }
    }
}
