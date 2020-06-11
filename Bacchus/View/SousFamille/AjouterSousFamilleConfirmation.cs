using Bacchus.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.View.ConfirmationView
{

    public partial class AjouterSousFamilleConfirmation : Form
    {
        private string RefFamille;
        private string Nom;
        public AjouterSousFamilleConfirmation(string PRefNom, string PNom)
        {
            InitializeComponent();
            this.RefFamille = PRefNom;
            this.Nom = PNom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();
            DaoSousFamille.AjouterSousFamille(RefFamille, Nom);
            this.Hide();
        }
    }
}
