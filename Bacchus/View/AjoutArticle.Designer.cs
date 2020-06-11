namespace Bacchus.View
{
    partial class AjoutArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.textRefArticle = new System.Windows.Forms.TextBox();
            this.comboBoxSousFamille = new System.Windows.Forms.ComboBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.Nom_Fichier_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(259, 264);
            this.comboBoxMarque.Name = "comboBox1";
            this.comboBoxMarque.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMarque.TabIndex = 0;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(184, 126);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(235, 60);
            this.DescriptionText.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textRefArticle.Location = new System.Drawing.Point(249, 63);
            this.textRefArticle.Multiline = true;
            this.textRefArticle.Name = "textBox1";
            this.textRefArticle.Size = new System.Drawing.Size(170, 36);
            this.textRefArticle.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBoxSousFamille.FormattingEnabled = true;
            this.comboBoxSousFamille.Location = new System.Drawing.Point(259, 214);
            this.comboBoxSousFamille.Name = "comboBox2";
            this.comboBoxSousFamille.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSousFamille.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textPrix.Location = new System.Drawing.Point(249, 320);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textBox2";
            this.textPrix.Size = new System.Drawing.Size(170, 36);
            this.textPrix.TabIndex = 9;
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(27, 66);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(74, 17);
            this.Nom_Fichier_Label.TabIndex = 10;
            this.Nom_Fichier_Label.Text = "RefArticle*";
            this.Nom_Fichier_Label.Click += new System.EventHandler(this.Nom_Fichier_Label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "SousFamille";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Marque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prix*";
            // 
            // button1
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(168, 387);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(125, 27);
            this.boutonAjouter.TabIndex = 15;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.bouttonAjouter_Click);
            // 
            // AjoutArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 448);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.comboBoxSousFamille);
            this.Controls.Add(this.textRefArticle);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.comboBoxMarque);
            this.Name = "AjoutArticle";
            this.Text = "AjoutArticle";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.TextBox textRefArticle;
        private System.Windows.Forms.ComboBox comboBoxSousFamille;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonAjouter;
    }
}