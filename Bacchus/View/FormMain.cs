using Bacchus.Dao;
using Bacchus.View;
using Bacchus.View.ConfirmationView;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{

    /// <summary>
    /// Classe de la vue de la fenetre principale
    /// </summary>
    public partial class FormMain : Form
    {

        /// <summary>
        /// Listes des articles dans la base de données
        /// </summary>
        private List<Article> ListArticles;

        /// <summary>
        /// Listes des familles dans la base de données
        /// </summary>
        private List<Famille> ListFamilles;

        /// <summary>
        /// Listes des sous familles dans la base de données
        /// </summary>
        private List<SousFamille> ListSousFamilles;

        /// <summary>
        /// Listes des marques dans la base de données
        /// </summary>
        private List<Marque> ListMarques;

        private string SelectedNodeText;

        private ContextMenuStrip ContextMenuStrip;

        //Getters && Setters

        public List<Article> ListArticles1
        {
            get { return ListArticles; }
            set { ListArticles = value; }

        }

        public List<Famille> ListFamilles1
        {

            get { return ListFamilles; }
            set { ListFamilles = value; }
        }

        public List<SousFamille> ListSousFamilles1
        {

            get { return ListSousFamilles; }
            set { ListSousFamilles = value; }
        }

        public List<Marque> ListMarques1
        {

            get { return ListMarques; }
            set { ListMarques = value; }
        }

        /// <summary>
        /// Constructeur par défaut de la classe FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        /// <summary>
        /// Initialise les noeuds du Tree View
        /// </summary>
        private void InitializeTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Articles");
            treeView1.Nodes.Add("Marques");
            treeView1.Nodes.Add("Familles");
            treeView1.Nodes.Add("Sous familles");
            treeView1.EndUpdate();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur importer
        /// </summary>
        private void ImporterClicked(object sender, EventArgs e)
        {
            FormImporter form = new FormImporter();
            form.ShowDialog(this);
        }

        /// <summary>
        /// La fonction appelé lors d'evenement de clavier
        /// </summary>
        private void ActualiserClavier(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                // On recupere toutes les marques de la base de données
                MarqueDao DaoMarque = new MarqueDao();
                this.ListMarques1 = DaoMarque.GetArticles();
                this.toolStripStatusMarque.Text = ListMarques1.Count() + " Marques ";

                // On recupere toutes les familles de la base de données
                FamilleDAO DaoFamille = new FamilleDAO();
                this.ListFamilles1 = DaoFamille.GetFamilles();
                this.toolStripStatusFamille.Text = ListFamilles1.Count() + " Familles ";

                // On recupere toutes les sous familles de la base de données
                SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                this.ListSousFamilles1 = DaoSousFamille.GetFamilles();
                this.toolStripStatusSousFamille.Text = ListSousFamilles1.Count() + " SousFamilles ";

                // On recupere toutes les articles de la base de données
                ArticleDao DaoArticle = new ArticleDao();
                this.ListArticles1 = DaoArticle.GetArticles();
                this.toolStripStatusArticle.Text = ListArticles1.Count() + " Articles ";
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }
            }

        }

        private void SupprClavier(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (SelectedNodeText == "Articles")
                {

                    try
                    {
                        SupprimerArticleConfirmation FenetreSuppression = new SupprimerArticleConfirmation(listView1.SelectedItems[0].SubItems[1].Text);
                        FenetreSuppression.ShowDialog(this);
                    }
                    catch (Exception)
                    {
                        SupprimerArticle FenetreSuppression = new SupprimerArticle();
                        FenetreSuppression.ShowDialog(this);
                    }

                }
                // Si le noeud selectionné est Marques
                else if (SelectedNodeText == "Marques")
                {
                    try
                    {
                        SupprimerMarqueConfirmation FenetreSuppression = new SupprimerMarqueConfirmation(listView1.SelectedItems[0].SubItems[0].Text);
                        FenetreSuppression.ShowDialog(this);
                    }
                    catch (Exception)
                    {
                        SupprimerMarque FenetreSuppression = new SupprimerMarque();
                        FenetreSuppression.ShowDialog(this);
                    }

                }
                // Si le noeud selectionné est Familles
                else if (SelectedNodeText == "Familles")
                {
                    try
                    {
                        SupprimerFamilleConfirmation FenetreSuppression = new SupprimerFamilleConfirmation(listView1.SelectedItems[0].SubItems[0].Text);
                        FenetreSuppression.ShowDialog(this);
                    }
                    catch (Exception)
                    {
                        SupprimerFamille FenetreSuppression = new SupprimerFamille();
                        FenetreSuppression.ShowDialog(this);
                    }

                }
                // Si le noeud selectionné est Sous familles
                else if (SelectedNodeText == "Sous familles")
                {
                    try
                    {
                        SupprimerSousFamilleConfirmation FenetreSuppression = new SupprimerSousFamilleConfirmation(listView1.SelectedItems[0].SubItems[0].Text);
                        FenetreSuppression.ShowDialog(this);
                    }
                    catch (Exception)
                    {
                        SupprimerSousFamille FenetreSuppression = new SupprimerSousFamille();
                        FenetreSuppression.ShowDialog(this);
                    }
                }
            }

        }

        private void EntreeClavier(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (SelectedNodeText == "Articles")
                {

                    try
                    {
                        ModifierArticle FenetreModification = new ModifierArticle();
                        FenetreModification.textRefArticle1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {

                    }

                }
                // Si le noeud selectionné est Marques
                else if (SelectedNodeText == "Marques")
                {
                    try
                    {
                        ModifierMarque FenetreModification = new ModifierMarque();
                        FenetreModification.textRefMarque1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {

                    }

                }
                // Si le noeud selectionné est Familles
                else if (SelectedNodeText == "Familles")
                {
                    try
                    {
                        ModifierFamille FenetreModification = new ModifierFamille();
                        FenetreModification.textRefFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {

                    }

                }
                // Si le noeud selectionné est Sous familles
                else if (SelectedNodeText == "Sous familles")
                {
                    try
                    {
                        ModifierSousFamille FenetreModification = new ModifierSousFamille();
                        FenetreModification.textRefSousFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {

                    }
                }
            }

        }

        private void DoubleCliqueSouris(object sender, MouseEventArgs e)
        {

            if (SelectedNodeText == "Articles")
            {

                try
                {
                    ModifierArticle FenetreModification = new ModifierArticle();
                    FenetreModification.textRefArticle1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    FenetreModification.ShowDialog(this);
                }
                catch (Exception)
                {

                }

            }
            // Si le noeud selectionné est Marques
            else if (SelectedNodeText == "Marques")
            {
                try
                {
                    ModifierMarque FenetreModification = new ModifierMarque();
                    FenetreModification.textRefMarque1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    FenetreModification.ShowDialog(this);
                }
                catch (Exception)
                {

                }

            }
            // Si le noeud selectionné est Familles
            else if (SelectedNodeText == "Familles")
            {
                try
                {
                    ModifierFamille FenetreModification = new ModifierFamille();
                    FenetreModification.textRefFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    FenetreModification.ShowDialog(this);
                }
                catch (Exception)
                {

                }

            }
            // Si le noeud selectionné est Sous familles
            else if (SelectedNodeText == "Sous familles")
            {
                try
                {
                    ModifierSousFamille FenetreModification = new ModifierSousFamille();
                    FenetreModification.textRefSousFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    FenetreModification.ShowDialog(this);
                }
                catch (Exception)
                {

                }
            }
        }

        private void CliqueDroitSouris(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }

            }


        }

        private void listViewColumn_Click(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        // Implements the manual sorting of items by columns.
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }



        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur exporter
        /// </summary>
        private void ExporterClicked(object sender, EventArgs e)
        {
            FormExporter form = new FormExporter();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur actualiser
        /// </summary>
        private void ActualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On recupere toutes les marques de la base de données
            MarqueDao DaoMarque = new MarqueDao();
            this.ListMarques1 = DaoMarque.GetArticles();
            this.toolStripStatusMarque.Text = ListMarques1.Count() + " Marques ";

            // On recupere toutes les familles de la base de données
            FamilleDAO DaoFamille = new FamilleDAO();
            this.ListFamilles1 = DaoFamille.GetFamilles();
            this.toolStripStatusFamille.Text = ListFamilles1.Count() + " Familles ";

            // On recupere toutes les sous familles de la base de données
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            this.ListSousFamilles1 = DaoSousFamille.GetFamilles();
            this.toolStripStatusSousFamille.Text = ListSousFamilles1.Count() + " SousFamilles ";

            // On recupere toutes les articles de la base de données
            ArticleDao DaoArticle = new ArticleDao();
            this.ListArticles1 = DaoArticle.GetArticles();
            this.toolStripStatusArticle.Text = ListArticles1.Count() + " Articles ";
            if (this.listView1 != null)
            {
                this.listView1.Clear();
            }

        }

        /// <summary>
        /// Fonction appelé lorsque on appuie sur un noeud du TreeView
        /// </summary>
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedNodeText = e.Node.Text;
            // Si le noeud selectionné est Articles
            if (SelectedNodeText == "Articles")
            {
                //On supprimer la listView si elle existe deja
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                //On affecte les colonnes
                this.listView1.Columns.Add("Description");
                this.listView1.Columns.Add("RefArticle");
                this.listView1.Columns.Add("Sous-Famille");
                this.listView1.Columns.Add("Prix");

                if (ListArticles1 != null)
                {
                    //On ajoute les items à la listView
                    foreach (Article article in ListArticles1)
                    {
                        this.listView1.Items.Add(new ListViewItem(new string[] { article.Description1, article.RefArticle1, article.RefSousFamille1.ToString(), article.PrixHT1.ToString() }));

                    }
                }
            }
            // Si le noeud selectionné est Marques
            else if (SelectedNodeText == "Marques")
            {
                //On supprimer la listView si elle existe deja
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                //On affecte les colonnes
                this.listView1.Columns.Add("RefMarque");
                this.listView1.Columns.Add("Nom");

                if (ListMarques1 != null)
                {
                    //On ajoute les items à la listView
                    foreach (Marque marque in ListMarques1)
                    {
                        this.listView1.Items.Add(new ListViewItem(new string[] { marque.RefMarque1.ToString(), marque.Nom1 }));
                    }
                }

            }
            // Si le noeud selectionné est Familles
            else if (SelectedNodeText == "Familles")
            {
                //On supprimer la listView si elle existe deja
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                //On affecte les colonnes
                this.listView1.Columns.Add("RefFamille");
                this.listView1.Columns.Add("Nom");

                if (ListFamilles1 != null)
                {
                    //On ajoute les items à la listView
                    foreach (Famille famille in ListFamilles1)
                    {
                        this.listView1.Items.Add(new ListViewItem(new string[] { famille.RefFamille1.ToString(), famille.Nom1 }));
                    }
                }

            }
            // Si le noeud selectionné est Sous familles
            else if (SelectedNodeText == "Sous familles")
            {
                //On supprimer la listView si elle existe deja
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                //On affecte les colonnes
                this.listView1.Columns.Add("Ref sous-famille");
                this.listView1.Columns.Add("Nom");
                this.listView1.Columns.Add("RefFamille");

                if (ListSousFamilles1 != null)
                {
                    //On ajoute les items à la listView
                    foreach (SousFamille SousFamille in ListSousFamilles1)
                    {
                        this.listView1.Items.Add(new ListViewItem(new string[] { SousFamille.RefSousFamille1.ToString(), SousFamille.Nom1, SousFamille.RefFamille1.ToString() }));
                    }
                }
            }

        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Ajouter du menu Article
        /// </summary>
        private void ArticleAjouter_Click(object sender, EventArgs e)
        {
            AjoutArticle Form = new AjoutArticle();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Article
        /// </summary>
        private void ArticleModifier_Click(object sender, EventArgs e)
        {
            ModifierArticle Form = new ModifierArticle();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Article
        /// </summary>
        private void ArticleSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerArticle Form = new SupprimerArticle();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Ajouter du menu Famille
        /// </summary>
        private void FamilleAjouter_Click(object sender, EventArgs e)
        {
            AjouterFamille Form = new AjouterFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Famille
        /// </summary>
        private void FamilleModifier_Click(object sender, EventArgs e)
        {
            ModifierFamille Form = new ModifierFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Famille
        /// </summary>
        private void FamilleSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerFamille Form = new SupprimerFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Ajouter du menu SousFamille
        /// </summary>
        private void SousFamilleAjouter_Click(object sender, EventArgs e)
        {
            AjoutSousFamille Form = new AjoutSousFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu SousFamille
        /// </summary>
        private void SousFamilleModifier_Click(object sender, EventArgs e)
        {
            ModifierSousFamille Form = new ModifierSousFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu SousFamille
        /// </summary>
        private void SousFamilleSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerSousFamille Form = new SupprimerSousFamille();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Ajouter du menu Marque
        /// </summary>
        private void MarqueAjouter_Click(object sender, EventArgs e)
        {
            AjoutMarque Form = new AjoutMarque();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Marque
        /// </summary>
        private void MarqueModifier_Click(object sender, EventArgs e)
        {
            ModifierMarque Form = new ModifierMarque();
            Form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Marque
        /// </summary>
        private void MarqueSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerMarque Form = new SupprimerMarque();
            Form.ShowDialog(this);
        }

        private void StatusStrip_FormMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        /// <summary>
        /// Cette fonction permet de faire l'ajout en fonction du type de l'element(articles,familles,sous famille et marque)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterTout(object sender, EventArgs e)
        {
            if (SelectedNodeText == "Articles")
            {

                ArticleAjouter_Click(sender, e);
            }
            else if (SelectedNodeText == "Familles")
            {
                FamilleAjouter_Click(sender, e);

            }
            else if (SelectedNodeText == "Marques")
            {
                MarqueAjouter_Click(sender, e);

            }
            else if (SelectedNodeText == "Sous familles")
            {
                SousFamilleAjouter_Click(sender, e);

            }
        }
        /// <summary>
        /// Cette fonction permet de modifier en fonction du type de l'element(articles,familles,sous famille et marque)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierTout(object sender, EventArgs e)
        {
            if (SelectedNodeText == "Articles")
            {

                ArticleModifier_Click(sender, e);
            }
            else if (SelectedNodeText == "Familles")
            {
                FamilleModifier_Click(sender, e);

            }
            else if (SelectedNodeText == "Marques")
            {
                MarqueModifier_Click(sender, e);

            }
            else if (SelectedNodeText == "Sous familles")
            {
                SousFamilleModifier_Click(sender, e);

            }
        }
        /// <summary>
        /// Cette fonction permet de supprimer en fonction du type de l'element(articles,familles,sous famille et marque)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupprimerTout(object sender, EventArgs e)
        {
            if (SelectedNodeText == "Articles")
            {

                ArticleSupprimer_Click(sender, e);
            }
            else if (SelectedNodeText == "Familles")
            {
                FamilleSupprimer_Click(sender, e);

            }
            else if (SelectedNodeText == "Marques")
            {
                MarqueSupprimer_Click(sender, e);

            }
            else if (SelectedNodeText == "Sous familles")
            {
                SousFamilleSupprimer_Click(sender, e);

            }
        }
    }
}