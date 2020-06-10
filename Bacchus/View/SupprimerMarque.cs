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
    /// Classe de la vue de suppression de marque
    /// </summary>
    public partial class SupprimerMarque : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe SupprimerMarque
        /// </summary>
        public SupprimerMarque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque le bouton Supprimer est cliqué
        /// </summary>
        private void bouttonSuppriemr_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();

            //On recupere la reference de la famille si elle existe
            string Refmarque = this.textRefMarque.Text;

            //Si la reference d'une famille a été recuperé on effectue la suppression
            if (Refmarque != "" && Refmarque!= null)
            {
                DaoMarque.SupprimerMarque(Refmarque);
            }
        }
    }
}
