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
    public partial class SupprimerMarqueConfirmation : Form
    {
        private string RefMarque;
        public SupprimerMarqueConfirmation(string PRefMarque)
        {
            InitializeComponent();
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();
            DaoMarque.SupprimerMarque(RefMarque);
        }
    }
}
