﻿namespace Bacchus.View
{
    partial class ModifierFamille
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(47, 75);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(79, 17);
            this.Nom_Fichier_Label.TabIndex = 12;
            this.Nom_Fichier_Label.Text = "RefFamille*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 36);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 165);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 36);
            this.textBox2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModifierFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "ModifierFamille";
            this.Text = "ModifierFamille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}