﻿namespace Bacchus.View
{
    partial class SupprimerArticle
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
            this.Nom_Fichier_Label = new System.Windows.Forms.Label();
            this.TextRefArticle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(64, 72);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(74, 17);
            this.Nom_Fichier_Label.TabIndex = 11;
            this.Nom_Fichier_Label.Text = "RefArticle*";
            // 
            // textRefArticle
            // 
            this.TextRefArticle.Location = new System.Drawing.Point(187, 69);
            this.TextRefArticle.Multiline = true;
            this.TextRefArticle.Name = "textRefArticle";
            this.TextRefArticle.Size = new System.Drawing.Size(170, 36);
            this.TextRefArticle.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bouttonSupprimer_Click);
            // 
            // SupprimerArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextRefArticle);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "SupprimerArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SupprimerArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.TextBox TextRefArticle;
        public System.Windows.Forms.TextBox RefArticle1 { get => TextRefArticle; set => TextRefArticle = value; }
        private System.Windows.Forms.Button button1;
    }
}