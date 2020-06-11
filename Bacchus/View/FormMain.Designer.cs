using System.Windows.Forms;

namespace Bacchus
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip_FormMain = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip_FormMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusArticle = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMarque = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFamille = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSousFamille = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_FormMain.SuspendLayout();
            this.StatusStrip_FormMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_FormMain
            // 
            this.MenuStrip_FormMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_FormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.articleToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.sousFamilleToolStripMenuItem,
            this.marqueToolStripMenuItem});
            this.MenuStrip_FormMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_FormMain.Name = "MenuStrip_FormMain";
            this.MenuStrip_FormMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip_FormMain.Size = new System.Drawing.Size(802, 33);
            this.MenuStrip_FormMain.TabIndex = 0;
            this.MenuStrip_FormMain.Text = "menuStrip1";
            this.MenuStrip_FormMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActualiserClavier);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem,
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.ActualiserToolStripMenuItem_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.ImporterClicked);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.ExporterClicked);
            // 
            // articleToolStripMenuItem
            // 
            this.articleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.articleToolStripMenuItem.Name = "articleToolStripMenuItem";
            this.articleToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.articleToolStripMenuItem.Text = "Article";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ArticleAjouter_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ArticleModifier_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.ArticleSupprimer_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(179, 30);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.FamilleAjouter_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.FamilleModifier_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.FamilleSupprimer_Click);
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.modifierToolStripMenuItem2,
            this.supprimerToolStripMenuItem2});
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.sousFamilleToolStripMenuItem.Text = "SousFamille";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(179, 30);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.SousFamilleAjouter_Click);
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            this.modifierToolStripMenuItem2.Click += new System.EventHandler(this.SousFamilleModifier_Click);
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            this.supprimerToolStripMenuItem2.Click += new System.EventHandler(this.SousFamilleSupprimer_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.modifierToolStripMenuItem3,
            this.supprimerToolStripMenuItem3});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(179, 30);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.MarqueAjouter_Click);
            // 
            // modifierToolStripMenuItem3
            // 
            this.modifierToolStripMenuItem3.Name = "modifierToolStripMenuItem3";
            this.modifierToolStripMenuItem3.Size = new System.Drawing.Size(179, 30);
            this.modifierToolStripMenuItem3.Text = "Modifier";
            this.modifierToolStripMenuItem3.Click += new System.EventHandler(this.MarqueModifier_Click);
            // 
            // supprimerToolStripMenuItem3
            // 
            this.supprimerToolStripMenuItem3.Name = "supprimerToolStripMenuItem3";
            this.supprimerToolStripMenuItem3.Size = new System.Drawing.Size(179, 30);
            this.supprimerToolStripMenuItem3.Text = "Supprimer";
            this.supprimerToolStripMenuItem3.Click += new System.EventHandler(this.MarqueSupprimer_Click);
            // 
            // StatusStrip_FormMain
            // 
            this.StatusStrip_FormMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip_FormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusArticle,
            this.toolStripStatusMarque,
            this.toolStripStatusFamille,
            this.toolStripStatusSousFamille});
            this.StatusStrip_FormMain.Location = new System.Drawing.Point(0, 540);
            this.StatusStrip_FormMain.Name = "StatusStrip_FormMain";
            this.StatusStrip_FormMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip_FormMain.Size = new System.Drawing.Size(802, 30);
            this.StatusStrip_FormMain.TabIndex = 1;
            this.StatusStrip_FormMain.Text = "statusStrip";
            this.StatusStrip_FormMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip_FormMain_ItemClicked);
            // 
            // toolStripStatusArticle
            // 
            this.toolStripStatusArticle.Name = "toolStripStatusArticle";
            this.toolStripStatusArticle.Size = new System.Drawing.Size(17, 25);
            this.toolStripStatusArticle.Text = " ";
            // 
            // toolStripStatusMarque
            // 
            this.toolStripStatusMarque.Name = "toolStripStatusMarque";
            this.toolStripStatusMarque.Size = new System.Drawing.Size(17, 25);
            this.toolStripStatusMarque.Text = " ";
            // 
            // toolStripStatusFamille
            // 
            this.toolStripStatusFamille.Name = "toolStripStatusFamille";
            this.toolStripStatusFamille.Size = new System.Drawing.Size(17, 25);
            this.toolStripStatusFamille.Text = " ";
            // 
            // toolStripStatusSousFamille
            // 
            this.toolStripStatusSousFamille.Name = "toolStripStatusSousFamille";
            this.toolStripStatusSousFamille.Size = new System.Drawing.Size(17, 25);
            this.toolStripStatusSousFamille.Text = " ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(802, 507);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 507);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupprClavier);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(532, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewColumn_Click);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntreeClavier);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CliqueDroitSouris);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DoubleCliqueSouris);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CliqueDroitSouris);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem4,
            this.modifierToolStripMenuItem4,
            this.supprimerToolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 94);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ajouterToolStripMenuItem4
            // 
            this.ajouterToolStripMenuItem4.Name = "ajouterToolStripMenuItem4";
            this.ajouterToolStripMenuItem4.Size = new System.Drawing.Size(167, 30);
            this.ajouterToolStripMenuItem4.Text = "Ajouter";
            this.ajouterToolStripMenuItem4.Click += new System.EventHandler(this.AjouterTout);
            // 
            // modifierToolStripMenuItem4
            // 
            this.modifierToolStripMenuItem4.Name = "modifierToolStripMenuItem4";
            this.modifierToolStripMenuItem4.Size = new System.Drawing.Size(167, 30);
            this.modifierToolStripMenuItem4.Text = "Modifier";
            this.modifierToolStripMenuItem4.Click += new System.EventHandler(this.ModifierTout);
            // 
            // supprimerToolStripMenuItem4
            // 
            this.supprimerToolStripMenuItem4.Name = "supprimerToolStripMenuItem4";
            this.supprimerToolStripMenuItem4.Size = new System.Drawing.Size(167, 30);
            this.supprimerToolStripMenuItem4.Text = "Supprimer";
            this.supprimerToolStripMenuItem4.Click += new System.EventHandler(this.SupprimerTout);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.StatusStrip_FormMain);
            this.Controls.Add(this.MenuStrip_FormMain);
            this.MainMenuStrip = this.MenuStrip_FormMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActualiserClavier);
            this.MenuStrip_FormMain.ResumeLayout(false);
            this.MenuStrip_FormMain.PerformLayout();
            this.StatusStrip_FormMain.ResumeLayout(false);
            this.StatusStrip_FormMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_FormMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip_FormMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem articleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusArticle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMarque;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFamille;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSousFamille;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ajouterToolStripMenuItem4;
        private ToolStripMenuItem modifierToolStripMenuItem4;
        private ToolStripMenuItem supprimerToolStripMenuItem4;
    }
}

