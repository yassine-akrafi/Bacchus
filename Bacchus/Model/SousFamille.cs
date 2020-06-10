using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    public class SousFamille
    {
        /// <summary>
        /// La reference d'une sous-famille
        /// </summary>
        private int RefSousFamille;

        /// <summary>
        /// La reference d'une famille
        /// </summary>
        private int RefFamille;

        /// <summary>
        /// Le nom d'une sous-famille
        /// </summary>
        private String Nom;

        /// <summary>
        /// Cette fonction permet d'initialiser une sous-famille avec la reference d'une famille et le nom de la sous-famille
        /// </summary>
        /// <param name="RefFamille">La reference d'une famille</param>
        /// <param name="Nom">Le nom d'une sous-famille</param>
        public SousFamille(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        /// <summary>
        /// Cette fonction permet d'initialiser une sous-famille avec la reference d'une sous-famille, la reference de la famille et le nom de la sous-famille
        /// </summary>
        /// <param name="RefSousFamille">La reference d'une sous-famille</param>
        /// <param name="RefFamille">La reference de la famille </param>
        /// <param name="Nom">Le nom de la sous-famille</param>
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
