using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus
{
    public class Article
    {
        private String RefArticle;
        private String Description;
        private int RefSousFamille;
        private int RefMarque;
        private float PrixHT;
        private int Quantite;

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
