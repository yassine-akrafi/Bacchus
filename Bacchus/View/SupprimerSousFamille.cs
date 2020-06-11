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
    /// Classe de la vue de suppression d'une sous famille
    /// </summary>
    public partial class SupprimerSousFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe SupprimerSousFamille
        /// </summary>
        public SupprimerSousFamille()
        {
            InitializeComponent();
        }

        private void bouttonSupprimer_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();

            //On recupere la reference de la sous famille si elle existe
            string RefSousFamille = this.textRefSousFamille.Text;

            //Si la reference d'une sous famille a été recuperé on effectue la suppression
            if (RefSousFamille != "" && RefSousFamille != null)
            {
                DaoSousFamille.SupprimerSousFamille(RefSousFamille);
            }
        }
    }
}
