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
    /// Classe de la vue d'ajout de marque
    /// </summary>
    public partial class AjoutMarque : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe AjoutMarque
        /// </summary>
        public AjoutMarque()
        {
            InitializeComponent();
        }

        private void boutonAjout_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();

            //On recupere le nom de la marque a ajouter
            string Nom = this.textBox2.Text;

            //Si le nom existe on ajoute la marque
            if (Nom != "" && Nom != null)
            {
                DaoMarque.AjouterMarque(Nom);
            }
        }
    }
}
