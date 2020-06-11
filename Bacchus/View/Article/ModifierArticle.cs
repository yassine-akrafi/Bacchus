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
    /// Classe de la vue de modification d'article
    /// </summary>
    public partial class ModifierArticle : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe ModifierArticle
        /// </summary>
        public ModifierArticle()
        {
            InitializeComponent();

        }

        //Getters & Setters
        public TextBox TextRefArticle1 { get => this.TextRefArticle; set => this.TextRefArticle = value; }

        /// <summary>
        /// Fonction appelé lorsque le bouton Modifier est cliqué
        /// </summary>
        private void BouttonModifier_Click(object sender, EventArgs e)
        {
            //On initialise les Dao
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            MarqueDao DaoMarque = new MarqueDao();

            //On initialise la Reference de la sous famille et de la marque 
            int RefSousFamille = -1;
            int RefMarque = -1;

            //On recupere les champs que l'utilisateur a remplit
            string RefArticle = this.TextRefArticle.Text;
            string Description = this.DescriptionText.Text;
            string Prix = this.textPrix.Text;

            //Si la reference d'un article a été recuperé on effectue le changement
            if (RefArticle != null)
            {
                //On recupere la reference de la sous famille si elle est selectionnée
                if (this.comboBoxSousFamille.SelectedItem != null)
                {
                    RefSousFamille = DaoSousFamille.GetRefSousFamille(this.comboBoxSousFamille.SelectedItem.ToString());
                }

                //On recupere la marque de la sous famille si elle est selectionnée
                if (this.comboBoxMarque.SelectedItem != null)
                {
                    RefMarque = DaoMarque.GetRefMarque(this.comboBoxMarque.SelectedItem.ToString());
                }

                //On demande la confirmation de modification
                ModifierArticleConfirmation FenetreConfirmation =  new ModifierArticleConfirmation(RefArticle, Description, RefSousFamille, RefMarque, Prix);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
            
        }
    }
}
