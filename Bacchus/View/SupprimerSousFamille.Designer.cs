namespace Bacchus.View
{
    partial class SupprimerSousFamille
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
            this.textRefSousFamille = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(49, 111);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(111, 17);
            this.Nom_Fichier_Label.TabIndex = 12;
            this.Nom_Fichier_Label.Text = "RefSousFamille*";
            // 
            // textBox1
            // 
            this.textRefSousFamille.Location = new System.Drawing.Point(275, 108);
            this.textRefSousFamille.Multiline = true;
            this.textRefSousFamille.Name = "textBox1";
            this.textRefSousFamille.Size = new System.Drawing.Size(170, 36);
            this.textRefSousFamille.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bouttonSupprimer_Click);
            // 
            // SupprimerSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRefSousFamille);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "SupprimerSousFamille";
            this.Text = "SupprimerSousFamille";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.TextBox textRefSousFamille;
        private System.Windows.Forms.Button button1;
    }
}