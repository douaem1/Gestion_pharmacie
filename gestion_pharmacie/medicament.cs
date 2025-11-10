using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;

namespace gestion_pharmacie
{
    internal class medicament
    {
        public int idM;
        public string reference;
        public string nom;
        public string description_medicament;
        public float prix;
        public int quantite_stock;
        public int seuil_alerte;
        public DateOnly dateE;
        public DateOnly dateP;
        private string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

        public medicament(int idM, string reference, string nom, string description_medicament, float prix, int quantite_stock, int seuil_alerte, DateOnly dateE, DateOnly dateP)
        {
            this.idM = idM;
            this.reference = reference;
            this.nom = nom;
            this.description_medicament = description_medicament;
            this.prix = prix;
            this.quantite_stock = quantite_stock;
            this.seuil_alerte = seuil_alerte;
            this.dateE = dateE;
            this.dateP = dateP;
        }

        // ==================== GETTERS ====================
        public int getIdM()
        {
            return idM;
        }

        public string getReference()
        {
            return reference;
        }

        public string getNom()
        {
            return nom;
        }

        public string getDescription_medicament()
        {
            return description_medicament;
        }

        public float getPrix()
        {
            return prix;
        }

        public int getQuantite_stock()
        {
            return quantite_stock;
        }

        public int getSeuil_alerte()
        {
            return seuil_alerte;
        }

        public DateOnly getDateE()
        {
            return dateE;
        }

        public DateOnly getDateP()
        {
            return dateP;
        }

        // ==================== SETTERS ====================
        public void setReference(string reference)
        {
            this.reference = reference;
        }

        public void setQuantite_stock(int quantite_stock)
        {
            this.quantite_stock = quantite_stock;
        }

        public void setSeuil_alerte(int seuil_alerte)
        {
            this.seuil_alerte = seuil_alerte;
        }

        public void setPrix(float prix)
        {
            this.prix = prix;
        }

        public void setDescription_medicament(string description_medicament)
        {
            this.description_medicament = description_medicament;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setDateE(DateOnly dateE)
        {
            this.dateE = dateE;
        }

        public void setDateP(DateOnly dateP)
        {
            this.dateP = dateP;
        }

        public void setIdM(int idM)
        {
            this.idM = idM;
        }

        // ==================== MÉTHODES ====================
        public void toString()
        {
            Console.WriteLine("idM: " + idM + " reference: " + reference + " nom: " + nom + " description_medicament: " + description_medicament + " prix: " + prix + " quantite_stock: " + quantite_stock + " seuil_alerte: " + seuil_alerte + " dateE: " + dateE + " dateP: " + dateP);
        }

        // ➕ AJOUTER un médicament
        public void ajouter_medicament()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"INSERT INTO medicament 
                                 (reference, nom, description_medicament, prix, quantite_stock, seuil_alerte, dateE, dateP) 
                                 VALUES (@reference, @nom, @description_medicament, @prix, @quantite_stock, @seuil_alerte, @dateE, @dateP)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reference", reference);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@description_medicament", description_medicament);
                    cmd.Parameters.AddWithValue("@prix", prix);
                    cmd.Parameters.AddWithValue("@quantite_stock", quantite_stock);
                    cmd.Parameters.AddWithValue("@seuil_alerte", seuil_alerte);
                    cmd.Parameters.AddWithValue("@dateE", dateE.ToDateTime(new TimeOnly(0, 0)));
                    cmd.Parameters.AddWithValue("@dateP", dateP.ToDateTime(new TimeOnly(0, 0)));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void modifier_medicament()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"UPDATE medicament 
                                 SET reference = @reference,
                                     nom = @nom, 
                                     description_medicament = @description_medicament, 
                                     prix = @prix, 
                                     quantite_stock = @quantite_stock, 
                                     seuil_alerte = @seuil_alerte, 
                                     dateE = @dateE, 
                                     dateP = @dateP
                                 WHERE idM = @idM";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idM", idM);
                    cmd.Parameters.AddWithValue("@reference", reference);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@description_medicament", description_medicament);
                    cmd.Parameters.AddWithValue("@prix", prix);
                    cmd.Parameters.AddWithValue("@quantite_stock", quantite_stock);
                    cmd.Parameters.AddWithValue("@seuil_alerte", seuil_alerte);
                    cmd.Parameters.AddWithValue("@dateE", dateE.ToDateTime(new TimeOnly(0, 0)));
                    cmd.Parameters.AddWithValue("@dateP", dateP.ToDateTime(new TimeOnly(0, 0)));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void supprimer_medicament()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"DELETE FROM medicament WHERE idM = @idM";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idM", idM);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void supprimer_par_id(int idM)
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"DELETE FROM medicament WHERE idM = @idM";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idM", idM);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<medicament> rechercher_par_nom(string nom)
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
            List<medicament> medicaments = new List<medicament>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament WHERE nom LIKE @nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", "%" + nom + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicaments.Add(new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            ));
                        }
                    }
                }
            }
            return medicaments;
        }


        // 📋 RÉCUPÉRER tous les médicaments (STATIC)
        public static List<medicament> get_all_medicaments()
        {
            List<medicament> medicaments = new List<medicament>();
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament ORDER BY nom";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicaments.Add(new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            ));
                        }
                    }
                }
            }

            return medicaments;
        }
        public static medicament rechercher_par_reference(string reference)
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament WHERE reference = @reference";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reference", reference);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            );
                        }
                    }
                }
            }
            return null;
        }

        // ⚠️ OBTENIR les médicaments en alerte (stock < seuil) (STATIC)
        public static List<medicament> get_medicaments_en_alerte()
        {
            List<medicament> medicaments = new List<medicament>();
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament WHERE quantite_stock < seuil_alerte ORDER BY quantite_stock";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicaments.Add(new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            ));
                        }
                    }
                }
            }

            return medicaments;
        }
        public static medicament rechercher_par_id(int id)
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament WHERE idM = @idM";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idM", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            );
                        }
                    }
                }
            }
            return null;
        }

        // 📅 OBTENIR les médicaments bientôt périmés (STATIC)
        public static List<medicament> get_medicaments_bientot_perimes(int jours = 30)
        {
            List<medicament> medicaments = new List<medicament>();
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
            DateTime dateLimit = DateTime.Today.AddDays(jours);

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM medicament WHERE dateP <= @dateLimit AND dateP >= @today ORDER BY dateP";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateLimit", dateLimit);
                    cmd.Parameters.AddWithValue("@today", DateTime.Today);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicaments.Add(new medicament(
                                reader.GetInt32(reader.GetOrdinal("idM")),
                                reader.GetString(reader.GetOrdinal("reference")),
                                reader.GetString(reader.GetOrdinal("nom")),
                                reader.GetString(reader.GetOrdinal("description_medicament")),
                                (float)reader.GetDouble(reader.GetOrdinal("prix")),
                                reader.GetInt32(reader.GetOrdinal("quantite_stock")),
                                reader.GetInt32(reader.GetOrdinal("seuil_alerte")),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateE"))),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("dateP")))
                            ));
                        }
                    }
                }
            }

            return medicaments;
        }


        public static float calculer_valeur_stock()
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
            float valeurTotale = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT SUM(prix * quantite_stock) AS valeur_totale FROM medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        valeurTotale = Convert.ToSingle(result);
                    }
                }
            }

            return valeurTotale;
        }

        // 📊 COMPTER le nombre de médicaments (STATIC)
        public static int compter_medicaments()
        {
            string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM medicament";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    count = (int)cmd.ExecuteScalar();
                }
            }

            return count;
            
        }
    }
}