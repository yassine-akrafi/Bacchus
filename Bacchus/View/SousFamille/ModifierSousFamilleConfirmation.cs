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
    /// Classe de la vue permettant la confirmation de modification d'une sous famille
    /// </summary>
    public partial class ModifierSousFamilleConfirmation : Form
    {
        private string RefSousFamille, Nom;
        private int RefFamille;

        public ModifierSousFamilleConfirmation(string PRefSousFamille, string PNom, int PRefFamille)
        {
            InitializeComponent();
            this.RefSousFamille = PRefSousFamille;
            this.Nom = PNom;
            this.RefFamille = PRefFamille;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            DaoSousFamille.ModifierSousFamille(RefSousFamille, Nom, RefFamille);
            this.Hide();
        }
    }
}
