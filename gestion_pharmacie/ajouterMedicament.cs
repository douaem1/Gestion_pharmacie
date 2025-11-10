using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class AjouterMedicament : Form
    {
        public AjouterMedicament()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoScroll = true;
            ConfigureScrolling();
        }

        private void ConfigureScrolling()
        {
            // Active le scroll automatique du formulaire
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 800);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation des champs
                if (string.IsNullOrWhiteSpace(txtReference.Text))
                {
                    MessageBox.Show("Veuillez saisir la référence du médicament.", "Champ obligatoire",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MessageBox.Show("Veuillez saisir le nom du médicament.", "Champ obligatoire",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Veuillez saisir la description du médicament.", "Champ obligatoire",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                    return;
                }

                if (nudPrix.Value <= 0)
                {
                    MessageBox.Show("Le prix doit être supérieur à 0.", "Valeur invalide",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudPrix.Focus();
                    return;
                }

                if (dtpDateP.Value <= dtpDateE.Value)
                {
                    MessageBox.Show("La date de péremption doit être postérieure à la date d'entrée.",
                        "Dates invalides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Créer l'objet médicament
                medicament med = new medicament(
                    idM: 0,
                    reference: txtReference.Text.Trim(),
                    nom: txtNom.Text.Trim(),
                    description_medicament: txtDescription.Text.Trim(),
                    prix: (float)nudPrix.Value,
                    quantite_stock: (int)nudQuantite.Value,
                    seuil_alerte: (int)nudSeuil.Value,
                    dateE: DateOnly.FromDateTime(dtpDateE.Value),
                    dateP: DateOnly.FromDateTime(dtpDateP.Value)
                );

                // Ajouter à la base de données
                med.ajouter_medicament();

                MessageBox.Show("Médicament ajouté avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser le formulaire
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout :\n{ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetForm()
        {
            txtReference.Clear();
            txtNom.Clear();
            txtDescription.Clear();
            nudPrix.Value = 0;
            nudQuantite.Value = 0;
            nudSeuil.Value = 10;
            dtpDateE.Value = DateTime.Today;
            dtpDateP.Value = DateTime.Today.AddYears(1);
            txtReference.Focus();

            // Remettre le scroll en haut après reset
            this.AutoScrollPosition = new System.Drawing.Point(0, 0);
        }
    }
}