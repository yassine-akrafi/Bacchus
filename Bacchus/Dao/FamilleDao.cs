using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Bacchus.Dao
{
    /// <summary>
    /// Classe permettant l'accés au données des Familles
    /// </summary>
    /// 
    public class FamilleDAO
    {

        /// <summary>
        /// Initialise la connexion avec la Base de données "Bacchus.SQLite"
        /// </summary>
        private static SQLiteConnection Connexion = new SQLiteConnection("Data Source= C:\\Users\\Leslie Kiav\\source\\repos\\yassine-akrafi\\Bacchus\\Bacchus\\Dao\\Bacchus.SQLite");

        /// <summary>
        /// Ajoute une famille à la base de données
        /// retourne 0 si succés, -1 echec
        /// </summary>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns></returns>
        public int AjouterFamille(String Nom)
        {
            // // Si la famille existe on ne le crée pas
            if (GetRefFamille(Nom) != -1)
            {
                Connexion.Close();
                return -1;
            }

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On execute la commande Sql pour ajouter la famille à la base de données
            SQLiteCommand CommandInsert = Connexion.CreateCommand();
            CommandInsert.CommandText = "INSERT INTO Familles(Nom) Values(:Nom)";
            CommandInsert.Parameters.Add(new SQLiteParameter(":Nom", Nom));
            CommandInsert.ExecuteNonQuery();

            Connexion.Close();
            return 0;

        }

        /// <summary>
        /// Récupere la famille à partir du nom ,null si la famille n'existe pas
        /// </summary>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <returns>Retourne la famille</returns>
        public Famille GetFamille(int RefFamille)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la famille
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Familles WHERE RefFamille = :RefFamille", Connexion);
            Command.Parameters.AddWithValue(":RefFamille", RefFamille);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on crée la famille à retourner
            if (Reader.Read())
            {
                Famille Famille = new Famille(Reader.GetInt32(0), Reader.GetString(1));
                Connexion.Close();
                return Famille;
            }
            Connexion.Close();
            return null;
        }


        /// <summary>
        /// Récupere la reference d'une famille à partir de son nom,
        /// retourne -1 si l'article n'existe pas
        /// </summary>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns>-1 si l'article existe, la reference de la famille sinon</returns>
        public int GetRefFamille(String Nom)
        {

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer la famille 
            SQLiteCommand Command = new SQLiteCommand("SELECT RefFamille FROM Familles WHERE Nom = :Nom", Connexion);
            Command.Parameters.AddWithValue(":Nom", Nom);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On vérifie que le résultat existe, si oui on retourne la reference de la famille
            if (Reader.Read())
            {
                int Ref = Reader.GetInt32(0);
                Reader.Close();
                Connexion.Close();
                return Ref;
            }
            return -1;
        }


        /// <summary>
        /// Retourne Tous les Familles présentes dans la base de données
        /// </summary>
        /// <returns>Une liste de famille</returns>
        public List<Famille> GetFamilles()
        {

            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On met en place la commande Sql pour récuperer toutes les familles 
            SQLiteCommand Command = new SQLiteCommand("SELECT * FROM Familles", Connexion);

            // On execute et recupere le résultat de la commande Sql dans un lecteur
            SQLiteDataReader Reader = Command.ExecuteReader();

            // On crée une listes de familles et on lui ajoute toutes les familles recupérés à partir de la commande sql
            List<Famille> ListeFamille = new List<Famille>();
            while (Reader.Read())
            {
                ListeFamille.Add(new Famille(Reader.GetInt32(0), Reader.GetString(1)));
            }

            Connexion.Close();
            return ListeFamille;
        }

        /// <summary>
        /// Supprime une famille 
        /// retroune vrai si la famille existe et a été supprimé
        /// </summary>
        /// <param name="RefFamille">Reference de la famille a supprimer</param>
        /// <returns></returns>
        public Boolean SupprimerFamille(string RefFamille)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie si la famille n'existe pas 
            if (GetFamille(int.Parse(RefFamille)) == null)
            {
                Connexion.Close();
                return false;
            }

            // On execute la commande Sql pour supprimer l'article de la base de données
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM Familles WHERE RefFamille = :RefFamille", Connexion);
            Command.Parameters.AddWithValue(":RefFamille", RefFamille);
            Command.ExecuteNonQuery();

            // Si l'article n'existe plus, on retourne vrai
            if (GetFamille(int.Parse(RefFamille)) == null)
            {
                Connexion.Close();
                return true;
            }
            else
            {
                Connexion.Close();
                return false;
            }
        }

        /// <summary>
        /// Modifie la famille dans la base de données
        /// </summary>
        /// <param name="RefFamille">Reference de la famille</param>
        /// <param name="Nom">Nom de la famille</param>
        /// <returns></returns>
        public Boolean ModifierFamille(string RefFamille, string Nom)
        {
            // Si l'état de la connexion est fermé, on l'ouvre pour pouvoir effectuer ajouter l'article
            if ((ConnectionState.Closed == Connexion.State))
            {
                Connexion.Open();
            }

            // On verfie si la famille n'existe pas 
            if (GetFamille(int.Parse(RefFamille)) == null)
            {
                Connexion.Close();
                return false;
            }

            // Si un nom est passé en paramètre on modifie le nom de la famille
            if (Nom != null)
            {
                SQLiteCommand Command = new SQLiteCommand("UPDATE Familles SET Nom = :Nom WHERE RefFamille = :RefFamille", Connexion);
                Command.Parameters.AddWithValue(":RefFamille", RefFamille);
                Command.Parameters.AddWithValue(":Nom", Nom);
                Command.ExecuteNonQuery();
            }

            Connexion.Close();
            return true;
            
        }

    }


}
