using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace gestion_pharmacie
{
    public partial class FormAjouterMedicament : Form
    {
        public FormAjouterMedicament()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs saisies par l'utilisateur
                string nom = txtNom.Text;
                string description = txtDescription.Text;
                float prix = (float)nudPrix.Value;
                int quantite = (int)nudQuantite.Value;
                int seuil = (int)nudSeuil.Value;
                DateOnly dateE = DateOnly.FromDateTime(dtpDateE.Value);
                DateOnly dateP = DateOnly.FromDateTime(dtpDateP.Value);

                // Créer l'objet medicament
                medicament m = new medicament(0, nom, description, prix, quantite, seuil, dateE, dateP);

                // Appeler la méthode pour ajouter dans la base
                m.ajouter_medicament();

                MessageBox.Show("Médicament ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionnel : vider les champs
                txtNom.Clear();
                txtDescription.Clear();
                nudPrix.Value = 0;
                nudQuantite.Value = 0;
                nudSeuil.Value = 0;
                dtpDateE.Value = DateTime.Now;
                dtpDateP.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
