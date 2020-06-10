using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permettant l'accés au données des Sous familles
    /// </summary>
    public class SousFamilleDAO
    {

        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        /// <summary>
        /// Ajoute une sous famille à la base de données
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="NomFamille">Nom de la famille de la sous famille</param>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>0 si succés, -1 echec</returns>
        public int AjouterSousFamille(String NomFamille, String Nom)
        {
            // Si la sous famille existe on ne le crée pas
            if (GetRefSousFamille(Nom) != -1)
            {
                Connexion.Close();
                return -1;
            }
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            try
            {
                // On recupere la reference de la famille de la sous famille à partir de son nom
                FamilleDAO DaoFamille = new FamilleDAO();
                int RefFamille = DaoFamille.GetRefFamille(NomFamille);

                // On execute la commande Sql pour ajouter la sous famille à la base de données
                SQLiteCommand CommandInsert = new SQLiteCommand("INSERT INTO SousFamilles (RefFamille, Nom) VALUES (:RefFamille, :Nom)", Connexion);
                CommandInsert.Parameters.AddWithValue(":RefFamille", RefFamille);
                CommandInsert.Parameters.AddWithValue(":Nom", Nom);
                CommandInsert.ExecuteNonQuery();

                Connexion.Close();
                return 0;
            }
            catch (Exception)
            {
                Connexion.Close();
                return -1;
            }

        }

        /// <summary>
        /// Supprime une famille 
        /// retroune vrai si la sous famille existe et a été supprimé
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille a supprimer</param>
        /// <returns>vrai si la sous famille existe et a été supprimé</returns>
        public Boolean SupprimerSousFamille(string RefSousFamille)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie si la sous famille n'existe pas 
            if (GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                Connexion.Close();
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM SousFamilles WHERE RefSousFamille = :RefSousFamille", Connexion);
            Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);
            Command.ExecuteNonQuery();

            // Si l'article n'existe plus, on retourne vrai
            if (GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                Connexion.Close();
                return true;
            }
            Connexion.Close();
            return false;
 
        }

        /// <summary>
        /// Récupere la sous famille à partir de sa reference ,null si la sous famille n'existe pas
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille</param>
        /// <returns>Retourne la sous famille</returns>
        public SousFamille GetSousFamille(int RefSousFamille)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la famille
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM SousFamilles WHERE RefSousFamille = :RefSousFamille", Connexion);
            Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on crée la famille à retourner et on la retourne
            if (Reader.Read())
            {
                SousFamille SousFamille = new SousFamille(Reader.GetInt32(0), Reader.GetInt32(1), Reader.GetString(2));
                Connexion.Close();
                return SousFamille;
            }
            Connexion.Close();
            return null;
        }

        /// <summary>
        /// Récupere la reference d'une sous famille à partir de son nom,
        /// retourne -1 si la sous famille n'existe pas
        /// </summary>
        /// <param name="Nom">Nom de la sous famille</param>
        /// <returns></returns>
        public int GetRefSousFamille(String Nom)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la sous famille 
            SQLiteCommand Command = new SQLiteCommand("SELECT RefSousFamille FROM SousFamilles WHERE Nom = :Nom", Connexion);
            Command.Parameters.AddWithValue(":Nom", Nom);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on retourne la reference de la sous famille
            if (Reader.Read())
            {
                int Ref = Reader.GetInt32(0);
                Reader.Close();
                Connexion.Close();
                return Ref;
            }

            Connexion.Close();
            return -1;
        }

        /// <summary>
        /// Retourne Toutes les sous familles présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de sous familles</returns>
        public List<SousFamille> GetFamilles()
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer toutes les familles 
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM SousFamilles", Connexion);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On crée une listes de sous familles et on lui ajoute toutes les sous familles recupérés à partir de la commande sql
            List<SousFamille> ListeSousFamille = new List<SousFamille>();
            while (Reader.Read())
            {
                ListeSousFamille.Add(new SousFamille(Reader.GetInt32(0), Reader.GetInt32(1), Reader.GetString(2)));
            }

            Connexion.Close();
            return ListeSousFamille;
        }

        /// <summary>
        /// Modifie la sous famille de la base de données
        /// </summary>
        /// <param name="RefSousFamille">Reference de la sous famille</param>
        /// <param name="Nom">Nom de la sous famille</param>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <returns>Retourne true si succés</returns>
        public Boolean ModifierSousFamille(string RefSousFamille, string Nom, int RefFamille)
        {

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie si la famille n'existe pas 
            if (GetSousFamille(int.Parse(RefSousFamille)) == null)
            {
                Connexion.Close();
                return false;
            }

            // Si un nom est passé en paramètre on modifie le nom de la sous famille
            if (Nom != null)
                {
                    SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET Nom = :Nom WHERE RefSousFamille = :RefSousFamille", Connexion);
                    Command.Parameters.AddWithValue(":RefMarque", RefSousFamille);
                    Command.Parameters.AddWithValue(":Nom", Nom);
                    Command.ExecuteNonQuery();
                }

            // Si une Reference de famille est passé en paramètre on modifie la famille de la sous famille
            if (RefFamille != -1)
                {
                    SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET RefFamille = :RefFamille WHERE RefSousFamille = :RefSousFamille", Connexion);
                    Command.Parameters.AddWithValue(":RefSousFamille", RefSousFamille);
                    Command.Parameters.AddWithValue(":RefFamille", RefFamille);
                    Command.ExecuteNonQuery();
                }

            Connexion.Close();
            return true;
            }

        }
    }
}
