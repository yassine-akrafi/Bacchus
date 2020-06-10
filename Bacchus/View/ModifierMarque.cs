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
    public partial class ModifierMarque : Form
    {
        public ModifierMarque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarqueDao DaoMarque = new MarqueDao();
            string RefMarque = this.textBox1.Text;
            string Nom = this.textBox2.Text;
            if (RefMarque != null)
            {
                DaoMarque.ModifierMarque(RefMarque, Nom);
            }
        }
    }
}
