using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;

namespace gestion_pharmacie
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }

        // 🔹 Inscription
        public bool Register()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO utilisateur (nomUtilisateur, mot_de_passe) VALUES (@nom, @mdp)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nom", NomUtilisateur);
                cmd.Parameters.AddWithValue("@mdp", MotDePasse);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 🔹 Connexion
        public static bool Login(string nom, string motDePasse)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM utilisateur WHERE nomUtilisateur = @nom AND mot_de_passe = @mdp";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@mdp", motDePasse);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
