﻿namespace Bacchus.View
{
    partial class ModifierSousFamille
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextRefSousFamille = new System.Windows.Forms.TextBox();
            this.comboBoxFamille = new System.Windows.Forms.ComboBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(45, 65);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(111, 17);
            this.Nom_Fichier_Label.TabIndex = 12;
            this.Nom_Fichier_Label.Text = "RefSousFamille*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Famille";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom";
            // 
            // TextRefSousFamille
            // 
            this.TextRefSousFamille.Location = new System.Drawing.Point(293, 62);
            this.TextRefSousFamille.Multiline = true;
            this.TextRefSousFamille.Name = "TextRefSousFamille";
            this.TextRefSousFamille.Size = new System.Drawing.Size(200, 36);
            this.TextRefSousFamille.TabIndex = 17;
            // 
            // comboBoxFamille
            // 
            this.comboBoxFamille.FormattingEnabled = true;
            this.comboBoxFamille.Location = new System.Drawing.Point(293, 147);
            this.comboBoxFamille.Name = "comboBoxFamille";
            this.comboBoxFamille.Size = new System.Drawing.Size(200, 24);
            this.comboBoxFamille.TabIndex = 18;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(293, 215);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(200, 36);
            this.textNom.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bouttonModifier_Click);
            // 
            // ModifierSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.comboBoxFamille);
            this.Controls.Add(this.TextRefSousFamille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "ModifierSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifierSousFamille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextRefSousFamille;
        private System.Windows.Forms.ComboBox comboBoxFamille;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button button1;
    }
}