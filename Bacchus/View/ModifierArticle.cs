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
    public partial class ModifierArticle : Form
    {
        public ModifierArticle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            MarqueDao DaoMarque = new MarqueDao();
            ArticleDao DaoArticle = new ArticleDao();
            int RefSousFamille = -1;
            int RefMarque = -1;
            string RefArticle = this.textBox1.Text;
            string Description = this.DescriptionText.Text;
            string Prix = this.textBox2.Text;
            if (RefArticle != null)
            {
                if (this.comboBox2.Text != null)
                {
                    RefSousFamille = DaoSousFamille.TrouverParNom(this.comboBox2.Text);
                }
                if (this.comboBox1.Text != null)
                {
                    RefMarque = DaoMarque.TrouverParNom(this.comboBox1.Text);
                }

                DaoArticle.ModifierArticle(RefArticle, Description, RefSousFamille, RefMarque, float.Parse(Prix));
                
            }
            
        }
    }
}
