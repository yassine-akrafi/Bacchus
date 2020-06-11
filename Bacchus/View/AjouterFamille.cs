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
    /// Classe de la vue d'ajout de famille
    /// </summary>
    public partial class AjouterFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe AjouterFamille
        /// </summary>
        public AjouterFamille()
        {
            InitializeComponent();
        }


        private void boutonAjout_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            //On recupere le nom de la famille a ajouter
            string Nom = this.textNom.Text;

            //Si le nom existe on ajoute la famille
            if (Nom!= "" && Nom!=null)
            {
                DaoFamille.AjouterFamille(Nom);
            }
        }
    }
}
