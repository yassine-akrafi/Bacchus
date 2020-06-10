using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    /// <summary>
    /// Classe permet de creer une famille
    /// </summary>
    /// 
    public class Famille
    {
        /// <summary>
        /// La reference d'une famille
        /// </summary>
        private int RefFamille;

        /// <summary>
        /// Le nom d'une famille
        /// </summary>
        private String Nom;

        /// <summary>
        /// Constructeur de Confort d'une famille
        /// </summary>
        /// <param name="RefFamille">La reference d'une famille</param>
        /// <param name="Nom">Le nom d'une famille</param>
        public Famille(int RefFamille, String Nom)
        {
            this.RefFamille = RefFamille;
            this.Nom = Nom;
        }

        public int RefFamille1 { get => RefFamille; set => RefFamille = value; }

        public String Nom1 { get => Nom; set => Nom = value; }
    }
}
