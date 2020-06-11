﻿using Bacchus.Dao;
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
    public partial class AjouterFamilleConfirmation : Form
    {

        private string Nom;
        public AjouterFamilleConfirmation(string PNom)
        {
            InitializeComponent();
            this.Nom = PNom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Annuler_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            DaoFamille.AjouterFamille(Nom);
        }
    }
}
