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
    public partial class ModifierMarqueConfirmation : Form
    {
        private string RefMarque, Nom;
        public ModifierMarqueConfirmation(string PRefMarque, string PNom)
        {
            InitializeComponent();
            this.RefMarque = PRefMarque;
            this.Nom = PNom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();

            DaoMarque.ModifierMarque(RefMarque, Nom);
            this.Hide();
        }
    }
}
