namespace Bacchus.View
{
    partial class ModifierArticle
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
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSousFamille = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(30, 51);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(74, 17);
            this.Nom_Fichier_Label.TabIndex = 11;
            this.Nom_Fichier_Label.Text = "RefArticle*";
            // 
            // textBox1
            // 
            this.TextRefArticle.Location = new System.Drawing.Point(247, 48);
            this.TextRefArticle.Multiline = true;
            this.TextRefArticle.Name = "textBox1";
            this.TextRefArticle.Size = new System.Drawing.Size(170, 36);
            this.TextRefArticle.TabIndex = 12;
            this.TextRefArticle.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(182, 109);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(235, 60);
            this.DescriptionText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "SousFamille";
            // 
            // comboBox2
            // 
            this.comboBoxSousFamille.FormattingEnabled = true;
            this.comboBoxSousFamille.Location = new System.Drawing.Point(237, 200);
            this.comboBoxSousFamille.Name = "comboBox2";
            this.comboBoxSousFamille.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSousFamille.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Marque";
            // 
            // comboBox1
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(247, 267);
            this.comboBoxMarque.Name = "comboBox1";
            this.comboBoxMarque.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMarque.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Prix";
            // 
            // textBox2
            // 
            this.textPrix.Location = new System.Drawing.Point(237, 328);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textBox2";
            this.textPrix.Size = new System.Drawing.Size(170, 36);
            this.textPrix.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BouttonModifier_Click);
            // 
            // ModifierArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSousFamille);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextRefArticle);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Name = "ModifierArticle";
            this.Text = "ModifierArticle";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        }

        #endregion

        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.TextBox TextRefArticle;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSousFamille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Button button1;
    }
}