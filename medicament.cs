using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;

namespace gestion_pharmacie
{
    internal class medicament
    {

        public int idM;
        public string nom;
        public string description_medicament;
        public float prix;
        public int quantite_stock;
        public int seuil_alerte;
        public DateOnly dateE;
        public DateOnly dateP;
        private string ConnectionString = "Data Source=DOUAE;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";

        public medicament(int idM, string nom, string description_medicament, float prix, int quantite_stock, int seuil_alerte, DateOnly dateE, DateOnly dateP)
        {
            this.idM = idM;
            this.nom = nom;
            this.description_medicament = description_medicament;
            this.prix = prix;
            this.quantite_stock = quantite_stock;
            this.seuil_alerte = seuil_alerte;
            this.dateE = dateE;
            this.dateP = dateP;
        }
        public int getIdM()
        {
            return idM;
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
        public void toString()
        {
            Console.WriteLine("idM: " + idM + " nom: " + nom + " description_medicament: " + description_medicament + " prix: " + prix + " quantite_stock: " + quantite_stock + " seuil_alerte: " + seuil_alerte + " dateE: " + dateE + " dateP: " + dateP);
        }
        public void ajouter_medicament()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"INSERT INTO medicament 
                                 (nom, description_medicament, prix, quantite_stock, seuil_alerte, dateE, dateP) 
                                 VALUES (@nom, @description_medicament, @prix, @quantite_stock, @seuil_alerte, @dateE, @dateP)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // IdM généralement auto-incrémenté dans SQL Server, donc pas nécessaire
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
    }
}