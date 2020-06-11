namespace Bacchus.View
{
    partial class SupprimerMarque
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
            this.TextRefMarque = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(39, 97);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(83, 17);
            this.Nom_Fichier_Label.TabIndex = 13;
            this.Nom_Fichier_Label.Text = "RefMarque*";
            // 
            // textRefMarque
            // 
            this.TextRefMarque.Location = new System.Drawing.Point(201, 97);
            this.TextRefMarque.Multiline = true;
            this.TextRefMarque.Name = "textRefMarque";
            this.TextRefMarque.Size = new System.Drawing.Size(183, 36);
            this.TextRefMarque.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BouttonSupprimer_Click);
            // 
            // SupprimerMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextRefMarque);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "SupprimerMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SupprimerMarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.TextBox TextRefMarque;
        private System.Windows.Forms.Button button1;
    }
}