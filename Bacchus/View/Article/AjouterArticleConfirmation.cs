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
    /// Classe de la vue permettant la confirmation d'ajout d'article
    /// </summary>
    public partial class AjouterArticleConfirmation : Form
    {

        private string RefArticle;
        private string Description;
        private string SousFamille;
        private string Marque;
        float Prix;

        public AjouterArticleConfirmation(string PRefArticle, string PDescription, string PSousFamille, string PMarque, float PPrix)
        {
            InitializeComponent();
            this.RefArticle = PRefArticle;
            this.Description = PDescription;
            this.SousFamille = PSousFamille;
            this.Marque = PMarque;
            this.Prix = PPrix;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Fonction appelé si l'utilisateur ne confirme pas 
        /// </summary>
        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Fonction appelé si l'utilisateur ne confirme  
        /// </summary>
        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On appel la fonction qui va effectuer la requete sur la Base de données
            ArticleDao DaoArticle = new ArticleDao();
            DaoArticle.AjouterArticle(this.RefArticle, this.Description, this.SousFamille, this.Marque, this.Prix);
            this.Hide();
        }
    }
}
