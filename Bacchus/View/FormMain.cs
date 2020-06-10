using Bacchus.Dao;
using Bacchus.View;
using System;
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
    public partial class FormMain : Form
    {

        private List<Article> ListArticles;
        private List<Famille> ListFamilles;
        private List<SousFamille> ListSousFamilles;
        private List<Marque> ListMarques;

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

        public FormMain()
        {
            InitializeComponent();
            InitializeTreeView();
        }

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
        private void importerClicked(object sender, EventArgs e)
        {
            FormImporter form = new FormImporter();
            form.ShowDialog(this);
        }

        private void exporterClicked(object sender, EventArgs e)
        {
            FormExporter form = new FormExporter();
            form.ShowDialog(this);
        }


        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarqueDao DaoMarque = new MarqueDao();

            FamilleDAO DaoFamille = new FamilleDAO();

            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();

            ArticleDao DaoArticle = new ArticleDao();

            this.ListFamilles1 = DaoFamille.GetFamilles();
            this.ListSousFamilles1 = DaoSousFamille.GetFamilles();
            this.ListMarques1 = DaoMarque.GetArticles();
            this.ListArticles1 = DaoArticle.GetArticles();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Text == "Articles")
            {
                Console.WriteLine("Articles");
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                this.listView1.Columns.Add("Description");
                this.listView1.Columns.Add("Ref");
                this.listView1.Columns.Add("Marque");
                this.listView1.Columns.Add("Famille");
                this.listView1.Columns.Add("Sous-famille");
                this.listView1.Columns.Add("Prix H.T.");
                this.listView1.Columns.Add("Quantité");

                foreach (Article article in ListArticles1)
                {
                    this.listView1.Items.Add(article.Description1);
                    // (article.Description1, article.RefArticle1, article.RefMarque1.ToString(), article.RefSousFamille1.ToString(), article.RefSousFamille1.ToString(), article.PrixHT1.ToString(), article.Quantite1.ToString());
                }

            }
            else if (e.Node.Text == "Marques")
            {
                Console.WriteLine("Marques");
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }

                this.listView1.Columns.Add("Ref");
                this.listView1.Columns.Add("Nom");

                foreach (Marque marque in ListMarques1)
                {
                    this.listView1.Items.Add(marque.Nom1);
              
                }

            }
            else if (e.Node.Text == "Familles")
            {
                Console.WriteLine("Familles");
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }
                this.listView1.Columns.Add("Ref");
                this.listView1.Columns.Add("Nom");

                foreach (Famille famille in ListFamilles1)
                {
                    this.listView1.Items.Add(famille.Nom1);

                }

            }
            else if (e.Node.Text == "Sous familles")
            {
                Console.WriteLine("Sous familles");
                if (this.listView1 != null)
                {
                    this.listView1.Clear();
                }
                this.listView1.Columns.Add("Ref famille");
                this.listView1.Columns.Add("Ref sous-famille");
                this.listView1.Columns.Add("Nom");


                foreach (SousFamille SousFamille in ListSousFamilles1)
                {
                    this.listView1.Items.Add(SousFamille.Nom1);

                }
            }

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutArticle Form = new AjoutArticle();
            Form.ShowDialog(this);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ModifierArticle Form = new ModifierArticle();
            Form.ShowDialog(this);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerArticle Form = new SupprimerArticle();
            Form.ShowDialog(this);
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterFamille Form = new AjouterFamille();
            Form.ShowDialog(this);
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifierFamille Form = new ModifierFamille();
            Form.ShowDialog(this);
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupprimerFamille Form = new SupprimerFamille();
            Form.ShowDialog(this);
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AjoutSousFamille Form = new AjoutSousFamille();
            Form.ShowDialog(this);
        }

        private void modifierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModifierSousFamille Form = new ModifierSousFamille();
            Form.ShowDialog(this);
        }

        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupprimerSousFamille Form = new SupprimerSousFamille();
            Form.ShowDialog(this);
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AjoutMarque Form = new AjoutMarque();
            Form.ShowDialog(this);
        }

        private void modifierToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModifierMarque Form = new ModifierMarque();
            Form.ShowDialog(this);
        }

        private void supprimerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SupprimerMarque Form = new SupprimerMarque();
            Form.ShowDialog(this);
        }
    }
}
