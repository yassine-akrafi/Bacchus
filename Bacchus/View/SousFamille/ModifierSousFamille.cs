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
    /// Classe de la vue de modification de sous famille
    /// </summary>
    public partial class ModifierSousFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe ModifierSousFamille
        /// </summary>
        public ModifierSousFamille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque le bouton Modifier est cliqué
        /// </summary>
        private void bouttonModifier_Click(object sender, EventArgs e)
        {
            //On initialise les Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            //On initialise la Reference de la famille
            int RefFamille = -1;

            //On recupere les champs que l'utilisateur a remplit
            string Nom = this.textNom.Text;
            string RefSousFamille = this.textRefSousFamille.Text;

            //Si la reference d'une sous famille a été recuperé on effectue le changement
            if (RefSousFamille != null)
            {
                //On recupere la reference de la famille si elle est selectionnée
                if (this.comboBoxFamille.SelectedItem != null)
                {
                    RefFamille = DaoFamille.GetRefFamille(this.comboBoxFamille.SelectedItem.ToString());
                }

                ModifierSousFamilleConfirmation FenetreConfirmation = new ModifierSousFamilleConfirmation(RefSousFamille, Nom, RefFamille);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
           
        }
    }
}
