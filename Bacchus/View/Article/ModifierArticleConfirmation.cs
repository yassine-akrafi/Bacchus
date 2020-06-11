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

namespace Bacchus.View.ConfirmationView
{
    public partial class ModifierArticleConfirmation : Form
    {
        private string RefArticle, Description, Prix;
        private int RefSousFamille, RefMarque;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public ModifierArticleConfirmation(string PRefArticle, string PDescription, int PRefSousFamille, int PRefMarque, string PPrix)
        {
            InitializeComponent();
            this.RefArticle = PRefArticle;
            this.Description = PDescription;
            this.RefSousFamille = PRefSousFamille;
            this.RefMarque = PRefMarque;
            this.Prix = PPrix;
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            ArticleDao DaoArticle = new ArticleDao();
            Console.WriteLine("Le prix est " + Prix);
            if(Prix == null || Prix == "")
            {
                DaoArticle.ModifierArticle(RefArticle, Description, RefSousFamille, RefMarque, -1);

            }
            else
            {
                DaoArticle.ModifierArticle(RefArticle, Description, RefSousFamille, RefMarque, float.Parse(Prix));
            }

            this.Hide();

        }
    }
}
