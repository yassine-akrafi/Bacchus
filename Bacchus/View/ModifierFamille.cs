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
    public partial class ModifierFamille : Form
    {
        public ModifierFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilleDAO DaoFamille = new FamilleDAO();
            string RefFamille = this.textBox1.Text;
            string Nom = this.textBox2.Text;
            if (RefFamille != null )
            {
                DaoFamille.ModifierFamille(RefFamille, Nom);
            }
        }
    }
}
