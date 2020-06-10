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
    public partial class SupprimerMarque : Form
    {
        public SupprimerMarque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarqueDao DaoMarque = new MarqueDao();

            string Refmarque = this.textBox1.Text;

            if (Refmarque != "")
            {
                DaoMarque.SupprimerMarque(Refmarque);
            }

            if (Refmarque != null)
            {
                DaoMarque.SupprimerMarque(Refmarque);
            }
        }
    }
}
