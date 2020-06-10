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
    public partial class ModifierSousFamille : Form
    {
        public ModifierSousFamille()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            FamilleDAO DaoFamille = new FamilleDAO();
            int RefFamille = -1;
            string Nom = this.textBox2.Text;
            string RefSousFamille = this.textBox1.Text;
            if(RefSousFamille != null)
            {
                if (this.comboBox2.Text != null)
                {
                    RefFamille = DaoFamille.GetRefFamille(this.comboBox2.Text);
                }

                DaoSousFamille.ModifierSousFamille(RefSousFamille, Nom, RefFamille);
            }
           
        }
    }
}
