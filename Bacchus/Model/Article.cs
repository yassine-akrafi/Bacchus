using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    /// <summary>
    /// Classe permet de creer un article
    /// </summary>
    /// 
    public class Article
    {
        /// <summary>
        /// La reference de l'article
        /// </summary>
        private String RefArticle;

        /// <summary>
        /// La description de l'article
        /// </summary>
        private String Description;

        /// <summary>
        /// La reference de la sous-famille de l'article
        /// </summary>
        private int RefSousFamille;

        /// <summary>
        /// La reference de la marque
        /// </summary>
        private int RefMarque;

        /// <summary>
        /// Le prix de l'article
        /// </summary>
        private float PrixHT;

        /// <summary>
        /// La quantité de l'article
        /// </summary>
        private int Quantite;

        /// <summary>
        /// Constructeur de Confort de l'article
        /// </summary>
        /// <param name="RefArticle"> La reference de l'article </param>
        /// <param name="Description">La description de l'article </param>
        /// <param name="RefSousFamille">La reference de la sous-famille de l'article </param>
        /// <param name="RefMarque">La reference de la marque l'article </param>
        /// <param name="PrixHT">Le prix H.T de l'article </param>
        /// <param name="Quantite">La quantite de l'article </param>
        public Article(String RefArticle, String Description, int RefSousFamille, int RefMarque, float PrixHT, int Quantite)
        {
            this.RefArticle = RefArticle;
            this.Description = Description;
            this.RefSousFamille = RefSousFamille;
            this.RefMarque = RefMarque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }

        public String RefArticle1 { get => RefArticle; set => RefArticle = value; }

        public String Description1 { get => Description; set => Description = value; }

        public int RefSousFamille1 { get => RefSousFamille; set => RefSousFamille = value; }

        public int RefMarque1 { get => RefMarque; set => RefMarque = value; }

        public float PrixHT1 { get => PrixHT; set => PrixHT = value; }

        public int Quantite1 { get => Quantite; set => Quantite = value; }

    }
}
