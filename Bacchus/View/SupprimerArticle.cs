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

        /// <summary>
        /// Fonction appelé lorsque le bouton Supprimer est cliqué
        /// </summary>
        private void bouttonSupprimer_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            ArticleDao DaoArticle = new ArticleDao();
           
            //On recupere la reference de l'article si elle existe
            string RefArticle = this.textRefArticle.Text;

            //Si la reference d'un article a été recuperé on effectue la suppression
            if (RefArticle != "" && RefArticle != null)
            {
                DaoArticle.SupprimerArticle(RefArticle);
            }
        }
    }
}
