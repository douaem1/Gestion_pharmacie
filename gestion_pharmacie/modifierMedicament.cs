using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gestion_pharmacie
{
    public partial class ModifierMedicament : Form
    {
        private string ConnectionString = "Data Source=LAPTOP-S4HO4VR1;Initial Catalog=gestion_pharmacie;Integrated Security=SSPI;TrustServerCertificate=True;";
        private int idMedicament = 0;
        private bool medicamentTrouve = false;

        public ModifierMedicament()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoScroll = true;
            DesactiverChamps();
            ConfigureScrolling();
        }

        private void ConfigureScrolling()
        {
            // Active le scroll automatique du formulaire
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 800);
        }

        private void DesactiverChamps()
        {
            txtReference.Enabled = false;
            txtNom.Enabled = false;
            txtDescription.Enabled = false;
            txtPrix.Enabled = false;
            txtQuantite.Enabled = false;
            txtSeuil.Enabled = false;
            dtpExpiration.Enabled = false;
            dtpProduction.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void ActiverChamps()
        {
            txtReference.Enabled = true;
            txtNom.Enabled = true;
            txtDescription.Enabled = true;
            txtPrix.Enabled = true;
            txtQuantite.Enabled = true;
            txtSeuil.Enabled = true;
            dtpExpiration.Enabled = true;
            dtpProduction.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdRecherche.Text))
            {
                MessageBox.Show("Veuillez entrer un ID de médicament", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdRecherche.Focus();
                return;
            }

            if (!int.TryParse(txtIdRecherche.Text, out idMedicament))
            {
                MessageBox.Show("L'ID doit être un nombre valide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdRecherche.Focus();
                return;
            }

            ChargerMedicament();
        }

        private void ChargerMedicament()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM medicament WHERE idM = @idM";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idM", idMedicament);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtReference.Text = reader["reference"].ToString();
                            txtNom.Text = reader["nom"].ToString();
                            txtDescription.Text = reader["description_medicament"].ToString();
                            txtPrix.Text = reader["prix"].ToString();
                            txtQuantite.Text = reader["quantite_stock"].ToString();
                            txtSeuil.Text = reader["seuil_alerte"].ToString();
                            dtpExpiration.Value = Convert.ToDateTime(reader["dateE"]);
                            dtpProduction.Value = Convert.ToDateTime(reader["dateP"]);

                            medicamentTrouve = true;
                            ActiverChamps();
                            MessageBox.Show("Médicament trouvé ! Vous pouvez maintenant le modifier.", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            medicamentTrouve = false;
                            DesactiverChamps();
                            ViderChamps();
                            MessageBox.Show("Aucun médicament trouvé avec cet ID", "Introuvable",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche: " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViderChamps()
        {
            txtReference.Clear();
            txtNom.Clear();
            txtDescription.Clear();
            txtPrix.Clear();
            txtQuantite.Clear();
            txtSeuil.Clear();
            dtpExpiration.Value = DateTime.Now;
            dtpProduction.Value = DateTime.Now;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!medicamentTrouve)
                {
                    MessageBox.Show("Veuillez d'abord chercher un médicament valide", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValiderChamps())
                {
                    medicament med = new medicament(
                        idMedicament,
                        txtReference.Text,
                        txtNom.Text,
                        txtDescription.Text,
                        float.Parse(txtPrix.Text),
                        int.Parse(txtQuantite.Text),
                        int.Parse(txtSeuil.Text),
                        DateOnly.FromDateTime(dtpExpiration.Value),
                        DateOnly.FromDateTime(dtpProduction.Value)
                    );

                    med.modifier_medicament();

                    MessageBox.Show("Médicament modifié avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Réinitialiser le formulaire
                    txtIdRecherche.Clear();
                    ViderChamps();
                    DesactiverChamps();
                    medicamentTrouve = false;
                    txtIdRecherche.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtReference.Text))
            {
                MessageBox.Show("Veuillez entrer la référence", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReference.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez entrer le nom", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }
            if (!float.TryParse(txtPrix.Text, out float prix) || prix <= 0)
            {
                MessageBox.Show("Veuillez entrer un prix valide", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrix.Focus();
                return false;
            }
            if (!int.TryParse(txtQuantite.Text, out int qte) || qte < 0)
            {
                MessageBox.Show("Veuillez entrer une quantité valide", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantite.Focus();
                return false;
            }
            if (!int.TryParse(txtSeuil.Text, out int seuil) || seuil < 0)
            {
                MessageBox.Show("Veuillez entrer un seuil valide", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSeuil.Focus();
                return false;
            }
            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSeuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Appuyer sur Enter pour chercher
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnChercher_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtSeuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}