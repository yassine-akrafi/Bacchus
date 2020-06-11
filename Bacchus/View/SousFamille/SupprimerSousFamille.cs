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
        public TextBox TextRefSousFamille1 { get => this.TextRefSousFamille; set => this.TextRefSousFamille = value; }
        private void BouttonSupprimer_Click(object sender, EventArgs e)
        {

            //On recupere la reference de la sous famille si elle existe
            string RefSousFamille = this.TextRefSousFamille.Text;

            //Si la reference d'une sous famille a été recuperé on effectue la suppression
            if (RefSousFamille != "" && RefSousFamille != null)
            {
                SupprimerSousFamilleConfirmation FenetreConfirmation = new SupprimerSousFamilleConfirmation(RefSousFamille);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
        }
    }
}
