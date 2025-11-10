using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class SupprimerMedicament : Form
    {
        public SupprimerMedicament()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Veuillez saisir l'identifiant du médicament.", "Champ obligatoire",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("L'identifiant doit être un nombre entier.", "Valeur invalide",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                txtId.SelectAll();
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce médicament ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                medicament.supprimer_par_id(id);

                MessageBox.Show("Médicament supprimé avec succès.", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression :\n{ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

