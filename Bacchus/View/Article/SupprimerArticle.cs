using Bacchus.Dao;
using Bacchus.View.ConfirmationView;
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
    /// <summary>
    /// Classe de la vue de suppression d'article
    /// </summary>
    public partial class SupprimerArticle : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe SupprimerArticle
        /// </summary>
        public SupprimerArticle()
        {
            InitializeComponent();
        }

        public TextBox TextRefArticle1 { get => this.TextRefArticle; set => this.TextRefArticle = value; }

        /// <summary>
        /// Fonction appelé lorsque le bouton Supprimer est cliqué
        /// </summary>
        private void bouttonSupprimer_Click(object sender, EventArgs e)
        {
           
            //On recupere la reference de l'article si elle existe
            string RefArticle = this.TextRefArticle.Text;

            //Si la reference d'un article a été recuperé on effectue la suppression
            if (RefArticle != "" && RefArticle != null)
            {
                SupprimerArticleConfirmation FenetreConfirmation = new SupprimerArticleConfirmation(RefArticle);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
            
        }
    }
}
