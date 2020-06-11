namespace Bacchus
{
    partial class FormImporter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.File_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Nom_Fichier_Label = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selectionez un fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectionnerFichier_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ImporterAjout_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ecraser";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ImporterEcrasement_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 253);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(255, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // File_Name_TextBox
            // 
            this.File_Name_TextBox.Location = new System.Drawing.Point(27, 114);
            this.File_Name_TextBox.Multiline = true;
            this.File_Name_TextBox.Name = "File_Name_TextBox";
            this.File_Name_TextBox.Size = new System.Drawing.Size(255, 63);
            this.File_Name_TextBox.TabIndex = 5;
            // 
            // Nom_Fichier_Label
            // 
            this.Nom_Fichier_Label.AutoSize = true;
            this.Nom_Fichier_Label.Location = new System.Drawing.Point(64, 84);
            this.Nom_Fichier_Label.Name = "Nom_Fichier_Label";
            this.Nom_Fichier_Label.Size = new System.Drawing.Size(183, 17);
            this.Nom_Fichier_Label.TabIndex = 6;
            this.Nom_Fichier_Label.Text = "Nom du fichier sélectionné :";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(79, 302);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(150, 17);
            this.Status_Label.TabIndex = 7;
            this.Status_Label.Text = "Message d\'importation";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(27, 337);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(255, 112);
            this.textStatus.TabIndex = 8;
            // 
            // FormImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 481);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Nom_Fichier_Label);
            this.Controls.Add(this.File_Name_TextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormImporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox File_Name_TextBox;
        private System.Windows.Forms.Label Nom_Fichier_Label;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.TextBox textStatus;
    }
}