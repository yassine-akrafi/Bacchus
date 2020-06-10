using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    public class Marque
    {
        private int RefMarque;
        private String Nom;

        public Marque(int RefMarque, String Nom)
        {
            this.RefMarque = RefMarque;
            this.Nom = Nom;
        }

        public int RefMarque1 { get => RefMarque; set => RefMarque = value; }
        public String Nom1 { get => Nom; set => Nom = value; }
    }
}
