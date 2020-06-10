using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    public class Famille
    {
        private int RefFamille;
        private String Nom;

        public Famille(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public int RefFamille1 { get => RefFamille; set => RefFamille = value; }
        public String Nom1 { get => Nom; set => Nom = value; }
    }
}
