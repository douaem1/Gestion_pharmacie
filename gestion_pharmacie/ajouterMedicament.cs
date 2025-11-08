using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class AjouterMedicamentForm : Form
    {
        public AjouterMedicamentForm()
        {
            InitializeComponent();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification simple des champs obligatoires
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MessageBox.Show("Veuillez saisir le nom du médicament.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Veuillez saisir la description du médicament.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Créer un objet medicament avec les valeurs du formulaire
                medicament med = new medicament(
                    idM: 0, // Id auto-incrémenté ou généré par la DB
                    nom: txtNom.Text,
                    description_medicament: txtDescription.Text,
                    prix: (float)nudPrix.Value,
                    quantite_stock: (int)nudQuantite.Value,
                    seuil_alerte: (int)nudSeuil.Value,
                    dateE: DateOnly.FromDateTime(dtpDateE.Value),
                    dateP: DateOnly.FromDateTime(dtpDateP.Value)
                );

                // Appel de la méthode pour ajouter à la base de données
                med.ajouter_medicament();

                MessageBox.Show("Médicament ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser les champs
                txtNom.Text = "";
                txtDescription.Text = "";
                nudPrix.Value = 0;
                nudQuantite.Value = 0;
                nudSeuil.Value = 0;
                dtpDateE.Value = DateTime.Today;
                dtpDateP.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
