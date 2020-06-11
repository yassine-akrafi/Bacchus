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
    /// Classe de la vue de modification de famille
    /// </summary>
    public partial class ModifierFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe ModifierFamille
        /// </summary>
        public ModifierFamille()
        {
            InitializeComponent();
        }

        public TextBox textRefFamille1 { get => this.textRefFamille; set => this.textRefFamille = value; }

        /// <summary>
        /// Fonction appelé lorsque le bouton Modifier est cliqué
        /// </summary>
        private void bouttonModifier_Click(object sender, EventArgs e)
        {

            //On recupere les champs que l'utilisateur a remplit
            string RefFamille = this.textRefFamille.Text;
            string Nom = this.textNom.Text;

            //Si la reference d'une famille a été ecrite on effectue le changement
            if (RefFamille != null )
            {
                ModifierFamilleConfirmation FenetreConfirmation = new ModifierFamilleConfirmation(RefFamille, Nom);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
        }
    }
}
