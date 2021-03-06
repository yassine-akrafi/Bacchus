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
    /// Classe de la vue d'ajout d'article
    /// </summary>
    public partial class AjoutArticle : Form
    {

        /// <summary>
        /// Listes des sous familles dans la base de données
        /// </summary>
        private List<SousFamille> ListSousFamilles1;

        /// <summary>
        /// Liste des marques dans la base de données
        /// </summary>
        private List<Marque> ListMarques1;

        /// <summary>
        /// Constructeur par défaut de la classe AjoutArticle
        /// </summary>
        public AjoutArticle()
        {
            InitializeComponent();

            // On recupere toutes les familles de la base de données
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            this.ListSousFamilles1 = DaoSousFamille.GetFamilles();

            //On récupere toutes les marques de la base de données
            MarqueDao DaoMarque = new MarqueDao();
            this.ListMarques1 = DaoMarque.GetMarques();

            //On ajoute dans le comboBox la liste des sous familles
            foreach (SousFamille Sousfamille in ListSousFamilles1)
            {
                this.comboBoxSousFamille.Items.Add(Sousfamille.Nom1);

            }

            //On ajoute dans le comboBox de marque la liste des marques
            foreach (Marque marque in ListMarques1)
            {
                this.comboBoxMarque.Items.Add(marque.Nom1);

            }
        }

        private void bouttonAjouter_Click(object sender, EventArgs e)
        {
            //On initialise les Dao
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            MarqueDao DaoMarque = new MarqueDao();

            // Cette variable sera mis à true si une erreur est passé dans le formulaire
            Boolean Executer = true;


            //Si sous famille existe on affecte a RefSousFamille sa reference
            if (this.comboBoxSousFamille.SelectedItem == null)
            {
                Executer = false;
            }

            //Si marque existe on affecte a RefMarque sa reference
            if (this.comboBoxMarque.SelectedItem == null)
            {
                Executer = false;
            }

            //Recuperation de la reference de l'article
            string RefArticle = this.textRefArticle.Text;
            if (RefArticle == "" || RefArticle == null)
            {
                Executer = false;
            }

            //Récuperation du prix
            string Prix = this.textPrix.Text;
            if (Prix == "" || Prix == null)
            {
                Executer = false;
            }

            //On recupere la description ajouté, s'il y'en a pas on met une description par défaut
            string Description = this.DescriptionText.Text;
            if(Description == "" || Description == null)
            {
                Description = "Sans Description";
            }

            //Si Aucune erreur on effectue demande la confirmation de l'ajout
            if (Executer == true)
            {
                AjouterArticleConfirmation FenetreConfirmation = new AjouterArticleConfirmation(RefArticle, Description, this.comboBoxSousFamille.SelectedItem.ToString(), this.comboBoxMarque.SelectedItem.ToString(), (float)Convert.ToDouble(Prix));
                FenetreConfirmation.ShowDialog(this);
                this.Hide();
            }
        }


        private void Nom_Fichier_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
