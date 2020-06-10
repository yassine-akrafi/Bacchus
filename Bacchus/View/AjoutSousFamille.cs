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
    public partial class AjoutSousFamille : Form
    {
        private List<Famille> ListFamilles1;
        public AjoutSousFamille()
        {
            InitializeComponent();
            FamilleDAO DaoFamille = new FamilleDAO();
            this.ListFamilles1 = DaoFamille.GetFamilles();

            foreach (Famille famille in ListFamilles1)
            {
                this.comboBox2.Items.Add(famille.Nom1);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            FamilleDAO DaoFamille = new FamilleDAO();
            int RefFamille = -1;
            if (this.comboBox2.Text != null) {
                 RefFamille = DaoFamille.GetRefFamille(this.comboBox2.Text);
            }
            string Nom = this.textBox2.Text;
            if (Nom != "" && RefFamille!=-1)
            {
                DaoSousFamille.AjouterSousFamille(RefFamille.ToString(), Nom);
            }
        }
    }
}
