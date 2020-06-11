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

        /// <summary>
        /// Le node actuel du treeview
        /// </summary>
        private string SelectedNodeText;

        //Getters && Setters

        public List<Article> ListArticles1 {
            get { return ListArticles; }
            set { ListArticles = value; }

        }

        public List<Famille> ListFamilles1 {

            get { return ListFamilles; }
            set { ListFamilles = value; }
        }

        public List<SousFamille> ListSousFamilles1 {

            get { return ListSousFamilles; }
            set { ListSousFamilles = value; }
        }

        public List<Marque> ListMarques1 {

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
        private void importerClicked(object sender, EventArgs e)
        {
            FormImporter form = new FormImporter();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur exporter
        /// </summary>
        private void exporterClicked(object sender, EventArgs e)
        {
            FormExporter form = new FormExporter();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur actualiser
        /// </summary>
        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On recupere toutes les marques de la base de données
            MarqueDao DaoMarque = new MarqueDao();
            this.ListMarques1 = DaoMarque.GetMarques();
            if (ListMarques1 != null)
            {
                this.toolStripStatusMarque.Text = ListMarques1.Count() + " Marques ";
            }


            // On recupere toutes les familles de la base de données
            FamilleDAO DaoFamille = new FamilleDAO();
            this.ListFamilles1 = DaoFamille.GetFamilles();
            if (ListFamilles1 != null)
            {
                this.toolStripStatusFamille.Text = ListFamilles1.Count() + " Familles ";
            }

            // On recupere toutes les sous familles de la base de données
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            this.ListSousFamilles1 = DaoSousFamille.GetFamilles();
            if (ListSousFamilles1 != null)
            {
                this.toolStripStatusSousFamille.Text = ListSousFamilles1.Count() + " SousFamilles ";
            }

            // On recupere toutes les articles de la base de données
            ArticleDao DaoArticle = new ArticleDao();
            this.ListArticles1 = DaoArticle.GetArticles();

            //On actualise le texte du StatusStrip
            if (ListArticles1 != null)
            {
                this.toolStripStatusArticle.Text = ListArticles1.Count() + " Articles ";
            }

            //On efface les elements presents dans la listView
            if (this.listView1 != null)
            {
                this.listView1.Clear();
            }

        }
        /// <summary>
        /// La fonction appelé lors de l'evenement de clavier F5
        /// </summary>
        private void ActualiserClavier(object sender, KeyEventArgs e)
        {
            //On vérifie que la touche est bien F5 si oui on actualise 
          if(e.KeyCode == Keys.F5)
            {
                // On recupere toutes les marques de la base de données
                MarqueDao DaoMarque = new MarqueDao();
                this.ListMarques1 = DaoMarque.GetMarques();
                if(ListMarques1!=null)
                {
                    this.toolStripStatusMarque.Text = ListMarques1.Count() + " Marques ";
                }
                

                // On recupere toutes les familles de la base de données
                FamilleDAO DaoFamille = new FamilleDAO();
                this.ListFamilles1 = DaoFamille.GetFamilles();
                if (ListFamilles1 != null)
                {
                    this.toolStripStatusFamille.Text = ListFamilles1.Count() + " Familles ";
                }

                // On recupere toutes les sous familles de la base de données
                SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                this.ListSousFamilles1 = DaoSousFamille.GetFamilles();
                if (ListSousFamilles1 != null)
                {
                    this.toolStripStatusSousFamille.Text = ListSousFamilles1.Count() + " SousFamilles ";
                }

                // On recupere toutes les articles de la base de données
                ArticleDao DaoArticle = new ArticleDao();
                this.ListArticles1 = DaoArticle.GetArticles();

                //On actualise le texte du StatusStrip
                if (ListArticles1 != null)
                {
                    this.toolStripStatusArticle.Text = ListArticles1.Count() + " Articles ";
                }

                //On efface les elements presents dans la listView
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }
            }

        }

        /// <summary>
        /// Fonction appelé lors de l'evenement clavier Suppr dans la listView
        /// </summary>
        private void SupprClavier(object sender, KeyEventArgs e)
        {
            //On verifie l'evenement clavier
            if (e.KeyCode == Keys.Delete)
            {
                //On verifie dans quel Node du treeview on se situe
                if (SelectedNodeText == "Articles")
                {
                    
                        //On tente de recuperer un item selectionné, s'il n'y en a pas on ouvre le formulaire de suppresion normal
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
                    //On tente de recuperer un item selectionné, s'il n'y en a pas on ouvre le formulaire de suppresion normal
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
                    //On tente de recuperer un item selectionné, s'il n'y en a pas on ouvre le formulaire de suppresion normal
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
                    //On tente de recuperer un item selectionné, s'il n'y en a pas on ouvre le formulaire de suppresion normal
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

        /// <summary>
        /// Fonction appelé lors de l'evenement clavier Entree dans la listView
        /// </summary>
        private void EntreeClavier(object sender, KeyEventArgs e)
        {
            //On verifie l'evenement
            if (e.KeyCode == Keys.Enter)
            {
                //On verifie dans quel Node du treeview on se situe
                if (SelectedNodeText == "Articles")
                {
                    //On tente de recuperer un item selectionné, le cas echeant on ouvre sa fenetre de modification
                    try
                    {
                        ModifierArticle FenetreModification = new ModifierArticle();
                        FenetreModification.TextRefArticle1.Text = listView1.SelectedItems[0].SubItems[1].Text;
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
                        FenetreModification.TextRefMarque1.Text = listView1.SelectedItems[0].SubItems[0].Text;
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
                        FenetreModification.TextRefFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
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
                        FenetreModification.TextRefSousFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {
       
                    }
                }
            }

        }

        /// <summary>
        /// La fonction appelé lors de l'evenement de souris double clique dans la listView
        /// </summary>
        private void DoubleCliqueSouris(object sender, MouseEventArgs e)
        {

                //On verifie dans quel Node du treeview on se situe
                if (SelectedNodeText == "Articles")
                {
                //On tente de recuperer un item selectionné, le cas echeant on ouvre sa fenetre de modification
                try
                {
                        ModifierArticle FenetreModification = new ModifierArticle();
                        FenetreModification.TextRefArticle1.Text = listView1.SelectedItems[0].SubItems[1].Text;
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
                        FenetreModification.TextRefMarque1.Text = listView1.SelectedItems[0].SubItems[0].Text;
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
                        FenetreModification.TextRefFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
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
                        FenetreModification.TextRefSousFamille1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                        FenetreModification.ShowDialog(this);
                    }
                    catch (Exception)
                    {

                    }
                }
        }

        /// <summary>
        /// Fonction appelé lors du clic droit dans la listView
        /// </summary>
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

        /// <summary>
        /// Régle la propriété ListViewItemSorter sur un nouveau ListViewItemComparer 
        /// </summary>
        private void ListViewColonneTri(object sender, ColumnClickEventArgs e)
        {
            // La mise en place de cette propriété permet de trier immédiatement l'objet 
            // ListView en utilisant l'objet ListViewItemComparer.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        /// <summary>
        /// Met en œuvre le tri manuel des articles par colonnes.
        /// </summary>
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
                this.listView1.Columns.Add("Famille");
                this.listView1.Columns.Add("Sous-Famille");
                this.listView1.Columns.Add("Marque");
                this.listView1.Columns.Add("Prix");

                if(ListArticles1 != null)
                {
                    string NomFamille = " ";
                    string NomSousFamille = " ";
                    string NomMarque = " ";

                    SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
                    FamilleDAO DaoFamille = new FamilleDAO();
                    MarqueDao DaoMarque = new MarqueDao();

                    //On ajoute les items à la listView
                    foreach (Article article in ListArticles1)
                    {
                        SousFamille SousFamilleActuel = DaoSousFamille.GetSousFamille(article.RefSousFamille1);
                        if(SousFamilleActuel != null)
                        {
                            NomSousFamille = SousFamilleActuel.Nom1;
                            Famille FamilleActuel = DaoFamille.GetFamille(SousFamilleActuel.RefFamille1);
                            if(FamilleActuel != null)
                            {
                                NomFamille = FamilleActuel.Nom1;
                            }
                        }

                        Marque MarqueActuel = DaoMarque.GetMarque(article.RefMarque1);
                        if (MarqueActuel != null)
                        {
                            NomMarque = MarqueActuel.Nom1;
                        }
                            this.listView1.Items.Add(new ListViewItem(new string[] { article.Description1, article.RefArticle1, NomFamille, NomSousFamille ,NomMarque ,article.PrixHT1.ToString() }));
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
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Article avec une reference
        /// </summary>
        private void ArticleModifier_Click(object sender, EventArgs e, string RefArticle)
        {
            ModifierArticle Form = new ModifierArticle();
            Form.TextRefArticle1.Text = RefArticle;
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
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Article avec une reference
        /// </summary>
        private void ArticleSupprimer_Click(object sender, EventArgs e, string RefArticle)
        {
            SupprimerArticle Form = new SupprimerArticle();
            Form.TextRefArticle1.Text = RefArticle ;
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
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Famille
        /// </summary>
        private void FamilleModifier_Click(object sender, EventArgs e, string RefFamille)
        {
            ModifierFamille Form = new ModifierFamille();
            Form.TextRefFamille1.Text = RefFamille;
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
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Famille
        /// </summary>
        private void FamilleSupprimer_Click(object sender, EventArgs e, string RefFamille)
        {
            SupprimerFamille Form = new SupprimerFamille();
            Form.TextRefFamille1.Text = RefFamille;
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
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu SousFamille
        /// </summary>
        private void SousFamilleModifier_Click(object sender, EventArgs e,string RefSousFamille)
        {
            ModifierSousFamille Form = new ModifierSousFamille();
            Form.TextRefSousFamille1.Text = RefSousFamille;
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
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu SousFamille
        /// </summary>
        private void SousFamilleSupprimer_Click(object sender, EventArgs e, string RefSousFamille)
        {
            SupprimerSousFamille Form = new SupprimerSousFamille();
            Form.TextRefSousFamille1.Text = RefSousFamille;
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
        /// Fonction appelé lorsque qu'on on appuie sur Modifier du menu Marque
        /// </summary>
        private void MarqueModifier_Click(object sender, EventArgs e,string RefMarque)
        {
            ModifierMarque Form = new ModifierMarque();
            Form.TextRefMarque1.Text = RefMarque;
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

        /// <summary>
        /// Fonction appelé lorsque qu'on on appuie sur Supprimer du menu Marque
        /// </summary>
        private void MarqueSupprimer_Click(object sender, EventArgs e, string RefMarque)
        {
            SupprimerMarque Form = new SupprimerMarque();
            Form.TextRefMarque1.Text = RefMarque;
            Form.ShowDialog(this);
        }

        private void StatusStrip_FormMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
                try
                {
                    ArticleModifier_Click(sender, e, listView1.SelectedItems[0].SubItems[1].Text);
                }
                catch (Exception)
                {
                    ArticleModifier_Click(sender, e);
                }
            }
            else if (SelectedNodeText == "Familles")
            {
                try
                {
                    FamilleModifier_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    FamilleModifier_Click(sender, e);
                }
 

            }
            else if (SelectedNodeText == "Marques")
            {
                try
                {
                    MarqueModifier_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    MarqueModifier_Click(sender, e);
                }

            }
            else if (SelectedNodeText == "Sous familles")
            {
                try
                {
                    SousFamilleModifier_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    SousFamilleModifier_Click(sender, e);
                }
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
                
                try
                {
                    ArticleSupprimer_Click(sender, e, listView1.SelectedItems[0].SubItems[1].Text);
                }
                catch (Exception)
                {
                    ArticleSupprimer_Click(sender, e);
                }
            }
            else if (SelectedNodeText == "Familles")
            {
                
                try
                {
                    FamilleSupprimer_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    FamilleSupprimer_Click(sender, e);
                }

            }
            else if (SelectedNodeText == "Marques")
            {
                try
                {
                    MarqueSupprimer_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    MarqueSupprimer_Click(sender, e);
                }

            }
            else if (SelectedNodeText == "Sous familles")
            {
                try
                {
                    SousFamilleSupprimer_Click(sender, e, listView1.SelectedItems[0].SubItems[0].Text);
                }
                catch (Exception)
                {
                    SousFamilleSupprimer_Click(sender, e);
                }

            }
        }

    }
}
