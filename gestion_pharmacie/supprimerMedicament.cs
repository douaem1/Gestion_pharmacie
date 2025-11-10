using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class SupprimerMedicament : Form
    {
        public SupprimerMedicament()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            // Désactiver le redimensionnement automatique
            this.AutoScaleMode = AutoScaleMode.None;

            // Focus sur le champ ID au démarrage
            txtId.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Validation du champ ID
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show(
                    "Veuillez saisir l'identifiant du médicament.",
                    "Champ obligatoire",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            // Validation du format numérique
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "L'identifiant doit être un nombre entier valide.",
                    "Valeur invalide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtId.Focus();
                txtId.SelectAll();
                return;
            }

            // Validation ID positif
            if (id <= 0)
            {
                MessageBox.Show(
                    "L'identifiant doit être un nombre positif.",
                    "Valeur invalide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtId.Focus();
                txtId.SelectAll();
                return;
            }

            // Confirmation de suppression
            DialogResult confirmation = MessageBox.Show(
                $"⚠️ Êtes-vous absolument sûr de vouloir supprimer le médicament ID: {id} ?\n\n" +
                "Cette action est DÉFINITIVE et IRRÉVERSIBLE.\n" +
                "Toutes les données associées seront perdues.",
                "⚠️ Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Button2 = Non par défaut

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            // Tentative de suppression
            try
            {
                medicament.supprimer_par_id(id);

                MessageBox.Show(
                    $"✓ Le médicament (ID: {id}) a été supprimé avec succès.",
                    "Suppression réussie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Réinitialiser le formulaire
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ Erreur lors de la suppression du médicament :\n\n{ex.Message}",
                    "Erreur de suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Garder le focus sur le champ pour permettre une nouvelle tentative
                txtId.Focus();
                txtId.SelectAll();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Demander confirmation si un ID est saisi
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment annuler ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Autoriser uniquement les chiffres et les touches de contrôle (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                // Feedback visuel/audio optionnel
                System.Media.SystemSounds.Beep.Play();
            }

            // Permettre Enter pour déclencher la suppression
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSupprimer.PerformClick();
            }
        }

        private void ResetForm()
        {
            // Vider le champ
            txtId.Clear();

            // Remettre le focus
            txtId.Focus();
        }
    }
}