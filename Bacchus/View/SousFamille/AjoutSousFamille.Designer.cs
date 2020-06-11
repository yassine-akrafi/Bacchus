namespace Bacchus.View
{
    partial class AjoutSousFamille
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFamille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Famille*";
            // 
            // comboBoxFamille
            // 
            this.comboBoxFamille.FormattingEnabled = true;
            this.comboBoxFamille.Location = new System.Drawing.Point(243, 64);
            this.comboBoxFamille.Name = "comboBoxFamille";
            this.comboBoxFamille.Size = new System.Drawing.Size(192, 24);
            this.comboBoxFamille.TabIndex = 14;
            this.comboBoxFamille.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom*";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(243, 134);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(192, 36);
            this.textNom.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BouttonAjout_Click);
            // 
            // AjoutSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFamille);
            this.Controls.Add(this.label2);
            this.Name = "AjoutSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjoutSousFamille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button button1;
    }
}