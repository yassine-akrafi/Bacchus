﻿using Bacchus.Dao;
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
    /// Classe de la vue de suppression de famille
    /// </summary>
    public partial class SupprimerFamille : Form
    {
        /// <summary>
        /// Constructeur par défaut de la classe SupprimerFamille
        /// </summary>
        public SupprimerFamille()
        {
            InitializeComponent();
        }

        public TextBox TextRefFamille1 { get => this.TextRefFamille; set => this.TextRefFamille = value; }
        /// <summary>
        /// Fonction appelé lorsque le bouton Supprimer est cliqué
        /// </summary>
        private void bouttonSupprimer_Click(object sender, EventArgs e)
        {
            //On recupere la reference de la famille si elle existe
            string RefFamille = this.TextRefFamille.Text;

            //Si la reference d'une famille a été recuperé on effectue la suppression
            if (RefFamille != "" && RefFamille!=null)
            {
                SupprimerFamilleConfirmation FenetreConfirmation = new SupprimerFamilleConfirmation(RefFamille);
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
        }
    }
}
