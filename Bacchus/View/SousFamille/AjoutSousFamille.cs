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
    /// Classe de la vue d'ajout de sous famille
    /// </summary>
    public partial class AjoutSousFamille : Form
    {
        /// <summary>
        /// Listes des familles dans la base de données
        /// </summary>
        private List<Famille> ListFamilles1;

        /// <summary>
        /// Constructeur par défaut de la classe AjoutSousFamille
        /// </summary>
        public AjoutSousFamille()
        {
            InitializeComponent();

            // On recupere toutes les familles de la base de données
            FamilleDAO DaoFamille = new FamilleDAO();
            this.ListFamilles1 = DaoFamille.GetFamilles();

            //On ajoute dans le comboBox la liste des familles
            foreach (Famille famille in ListFamilles1)
            {
                this.comboBoxFamille.Items.Add(famille.Nom1);

            }
        }

        private void BouttonAjout_Click(object sender, EventArgs e)
        {
            //On initialise les Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            //On initialise la Reference de la famille
            int RefFamille = -1;

            //Si famille selectionnée dans le comboBox on affecte a RefFamille sa reference
            if (this.comboBoxFamille.SelectedItem != null)
            {
                 RefFamille = DaoFamille.GetRefFamille(this.comboBoxFamille.SelectedItem.ToString());
            }

            //On recupere le nom de la sous famille à ajouter
            string Nom = this.textNom.Text;

            //Si parametre correcte on effectue l'ajout
            if (Nom != "" && Nom != null && RefFamille!=-1)
            {
                AjouterSousFamilleConfirmation FenetreConfirmation = new AjouterSousFamilleConfirmation(RefFamille.ToString(), Nom);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
