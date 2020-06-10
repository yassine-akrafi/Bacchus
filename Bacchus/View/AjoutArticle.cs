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
    public partial class AjoutArticle : Form
    {
        private List<SousFamille> ListSousFamilles1;
        private List<Marque> ListMarques1;
        public AjoutArticle()
        {
            InitializeComponent();
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            MarqueDao DaoMarque = new MarqueDao();
            this.ListSousFamilles1 = DaoSousFamille.TrouverSousFamilles();
            this.ListMarques1 = DaoMarque.TrouverMarques();
            foreach (SousFamille Sousfamille in ListSousFamilles1)
            {
                this.comboBox2.Items.Add(Sousfamille.Nom1);

            }
            foreach (Marque marque in ListMarques1)
            {
                this.comboBox1.Items.Add(marque.Nom1);

            }
        }

        private void Nom_Fichier_Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            MarqueDao DaoMarque = new MarqueDao();
            ArticleDao DaoArticle = new ArticleDao();
            int RefSousFamille = -1;
            int RefMarque = -1;
            if (this.comboBox2.Text != null)
            {
                RefSousFamille = DaoSousFamille.TrouverParNom(this.comboBox2.Text);
            }
            if (this.comboBox1.Text != null)
            {
                RefMarque = DaoMarque.TrouverParNom(this.comboBox1.Text);
            }
            string RefArticle = this.textBox1.Text;
            string Description = this.DescriptionText.Text;
            if(Description == "" || Description == null)
            {
                Description = "Sans Description";
            }
            string Prix = this.textBox2.Text;
            if (RefArticle != "" && Prix!="" && RefSousFamille != -1 && RefMarque!=-1)
            {
                DaoArticle.AjouterArticle(RefArticle, Description, RefSousFamille.ToString(), RefMarque.ToString(), float.Parse(Prix));
            }
        }
    }
}
