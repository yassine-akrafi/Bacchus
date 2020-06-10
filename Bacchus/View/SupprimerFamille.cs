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
    /// Classe de la vue de suppression de famille
    /// </summary>
    public partial class SupprimerFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe SupprimerFamille
        /// </summary>
        public SupprimerFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque le bouton Supprimer est cliqué
        /// </summary>
        private void bouttonSupprimer_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            //On recupere la reference de la famille si elle existe
            string RefFamille = this.textRefFamille.Text;

            //Si la reference d'une famille a été recuperé on effectue la suppression
            if (RefFamille != "" && RefFamille!=null)
            {
                DaoFamille.SupprimerFamille(RefFamille);
            }
        }
    }
}
