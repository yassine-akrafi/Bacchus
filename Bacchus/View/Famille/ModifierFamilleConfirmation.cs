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
    /// Classe de la vue permettant la confirmation de modification d'une famille
    /// </summary>
    public partial class ModifierFamilleConfirmation : Form
    {
        private string RefFamille, Nom;
        public ModifierFamilleConfirmation(string PRefFamille, string PNom)
        {
            InitializeComponent();
            this.RefFamille = PRefFamille;
            this.Nom = PNom;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            FamilleDAO DaoFamille = new FamilleDAO();
            DaoFamille.ModifierFamille(RefFamille, Nom);
            this.Hide();
        }
    }
}
