using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    public class SousFamille
    {
        private int RefSousFamille;
        private int RefFamille;
        private String Nom;

        public SousFamille(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public SousFamille(int RefSousFamille, int RefFamille, String Nom)
        {
            this.RefSousFamille = RefSousFamille;
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public int RefSousFamille1 { get => RefSousFamille; set => RefSousFamille = value; }
        public int RefFamille1 { get => RefFamille; set => RefFamille = value; }
        public String Nom1 { get => Nom; set => Nom = value; }
    }
}
