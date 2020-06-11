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
    /// Classe de la vue permettant la confirmation d'ajout d'une sous famille
    /// </summary>
    public partial class AjouterSousFamilleConfirmation : Form
    {
        private string RefFamille;
        private string Nom;

        public AjouterSousFamilleConfirmation(string PRefNom, string PNom)
        {
            InitializeComponent();
            this.RefFamille = PRefNom;
            this.Nom = PNom;
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            DaoSousFamille.AjouterSousFamille(RefFamille, Nom);
            this.Hide();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
