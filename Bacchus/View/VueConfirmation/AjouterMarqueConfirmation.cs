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
    public partial class AjouterMarqueConfirmation : Form
    {
        private string Nom;
        public AjouterMarqueConfirmation(string PNom)
        {
            InitializeComponent();
            this.Nom = PNom;
        }

        private void AjouterMarqueConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //On initialise le Dao
            MarqueDao DaoMarque = new MarqueDao();
            DaoMarque.AjouterMarque(Nom);
        }
    }
}
