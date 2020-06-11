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
    /// <summary>
    /// Classe de la vue permettant la confirmation de modificatin d'article
    /// </summary>
    public partial class ModifierArticleConfirmation : Form
    {
        private string RefArticle, Description, Prix;
        private int RefSousFamille, RefMarque;

        public ModifierArticleConfirmation(string PRefArticle, string PDescription, int PRefSousFamille, int PRefMarque, string PPrix)
        {
            InitializeComponent();
            this.RefArticle = PRefArticle;
            this.Description = PDescription;
            this.RefSousFamille = PRefSousFamille;
            this.RefMarque = PRefMarque;
            this.Prix = PPrix;
        }

        /// <summary>
        /// Fonction appelé si l'utilisateur ne confirme pas 
        /// </summary>
        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Fonction appelé si l'utilisateur ne confirme  
        /// </summary>
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
