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

namespace Bacchus.View
{
    public partial class AjoutMarque : Form
    {
        public AjoutMarque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarqueDao DaoMarque = new MarqueDao();
            string Nom = this.textBox2.Text;
            if (Nom != "")
            {
                DaoMarque.AjouterMarque(Nom);
            }
        }
    }
}
