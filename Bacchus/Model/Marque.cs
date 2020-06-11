using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    /// <summary>
    /// Classe permet de creer une marque
    /// </summary>
    /// 
    public class Marque
    {
        /// <summary>
        /// La reference d'une marque
        /// </summary>
        private int RefMarque;

        /// <summary>
        /// Le nom d'une marque
        /// </summary>
        private String Nom;

        /// <summary>
        /// Constructeur de confort d'une marque
        /// </summary>
        /// <param name="RefMarque">La reference d'une marque</param>
        /// <param name="Nom">Le nom d'une marque</param>
        public Marque(int RefMarque, String Nom)
        {
            this.RefMarque = RefMarque;
            this.Nom = Nom;
        }

        public int RefMarque1 { get => RefMarque; set => RefMarque = value; }
        

        public String Nom1 { get => Nom; set => Nom = value; }
    }
}
