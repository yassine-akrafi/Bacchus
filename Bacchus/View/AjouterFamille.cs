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
    public partial class AjouterFamille : Form
    {
        public AjouterFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilleDAO DaoFamille = new FamilleDAO();
            string Nom = this.textBox2.Text;
            if (Nom!= "")
            {
                DaoFamille.AjouterFamille(Nom);
            }
        }
    }
}
