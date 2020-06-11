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
    /// Classe de la vue de modification de famille
    /// </summary>
    public partial class ModifierMarque : Form
    {

        /// <summary>
        /// Constructeur par défaut de la classe ModifierFamille
        /// </summary>
        public ModifierMarque()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé lorsque le bouton Modifier est cliqué
        /// </summary>
        private void bouttonModifier_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();

            //On recupere les champs que l'utilisateur a remplit
            string RefMarque = this.textMarque.Text;
            string Nom = this.textNom.Text;

            //Si la reference d'une marque a été ecrite on effectue le changement
            if (RefMarque != null)
            {
                DaoMarque.ModifierMarque(RefMarque, Nom);
            }
        }
    }
}
