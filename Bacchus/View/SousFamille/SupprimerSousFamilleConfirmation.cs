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
    /// Classe de la vue permettant la confirmation de suppression d'une sous famille
    /// </summary>
    public partial class SupprimerSousFamilleConfirmation : Form
    {
        private string RefSousFamille;
        public SupprimerSousFamilleConfirmation(string PRefSousFamille)
        {
            InitializeComponent();
            this.RefSousFamille = PRefSousFamille;
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();

            DaoSousFamille.SupprimerSousFamille(RefSousFamille);
            this.Hide();

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
