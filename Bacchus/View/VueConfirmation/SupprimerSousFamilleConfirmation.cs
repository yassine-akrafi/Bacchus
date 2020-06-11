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
   
    public partial class SupprimerSousFamilleConfirmation : Form
    {
        private string RefSousFamille;
        public SupprimerSousFamilleConfirmation(string PRefSousFamille)
        {
            InitializeComponent();
            this.RefSousFamille = PRefSousFamille;
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            SousFamilleDAO DaoSousFamille = new SousFamilleDAO();

            DaoSousFamille.SupprimerSousFamille(RefSousFamille);

        }
    }
}
