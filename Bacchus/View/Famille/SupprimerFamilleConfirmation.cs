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
    public partial class SupprimerFamilleConfirmation : Form
    {
        private string RefFamille;
        public SupprimerFamilleConfirmation(string PRefFamille)
        {
            InitializeComponent();
            RefFamille = PRefFamille;
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            FamilleDAO DaoFamille = new FamilleDAO();

            DaoFamille.SupprimerFamille(RefFamille);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
