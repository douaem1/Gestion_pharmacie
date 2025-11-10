using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class RechercherMedicament : Form
    {
        public RechercherMedicament()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoScroll = true;
            ConfigurerDataGridView();
            ViderDetails();
        }

        // Configuration du DataGridView
        private void ConfigurerDataGridView()
        {
            dgvResultats.Columns.Clear();
            dgvResultats.Columns.Add("idM", "ID");
            dgvResultats.Columns.Add("reference", "Référence");
            dgvResultats.Columns.Add("nom", "Nom");
            dgvResultats.Columns.Add("prix", "Prix (DH)");
            dgvResultats.Columns.Add("quantite_stock", "Stock");
            dgvResultats.Columns.Add("seuil_alerte", "Seuil");

            // Ajuster les largeurs
            dgvResultats.Columns["idM"].Width = 60;
            dgvResultats.Columns["reference"].Width = 120;
            dgvResultats.Columns["nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvResultats.Columns["prix"].Width = 100;
            dgvResultats.Columns["quantite_stock"].Width = 80;
            dgvResultats.Columns["seuil_alerte"].Width = 80;
        }

        // Bouton Rechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecherche.Text))
            {
                MessageBox.Show("Veuillez entrer un terme de recherche.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvResultats.Rows.Clear();
                ViderDetails();

                if (radioId.Checked)
                {
                    // Recherche par ID
                    int id = int.Parse(txtRecherche.Text);
                    medicament med = medicament.rechercher_par_id(id);

                    if (med != null)
                    {
                        AjouterLigneDataGridView(med);
                        MessageBox.Show("Médicament trouvé !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucun médicament trouvé avec cet ID.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioReference.Checked)
                {
                    // Recherche par Référence
                    medicament med = medicament.rechercher_par_reference(txtRecherche.Text.Trim());

                    if (med != null)
                    {
                        AjouterLigneDataGridView(med);
                        MessageBox.Show("Médicament trouvé !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucun médicament trouvé avec cette référence.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioNom.Checked)
                {
                    // Recherche par Nom
                    List<medicament> medicaments = medicament.rechercher_par_nom(txtRecherche.Text.Trim());

                    if (medicaments.Count > 0)
                    {
                        foreach (medicament med in medicaments)
                        {
                            AjouterLigneDataGridView(med);
                        }
                        MessageBox.Show($"{medicaments.Count} médicament(s) trouvé(s) !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucun médicament trouvé avec ce nom.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format invalide. Veuillez entrer un nombre pour la recherche par ID.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ajouter une ligne au DataGridView
        private void AjouterLigneDataGridView(medicament med)
        {
            int index = dgvResultats.Rows.Add();
            DataGridViewRow row = dgvResultats.Rows[index];

            row.Cells["idM"].Value = med.idM;
            row.Cells["reference"].Value = med.reference;
            row.Cells["nom"].Value = med.nom;
            row.Cells["prix"].Value = med.prix.ToString("F2");
            row.Cells["quantite_stock"].Value = med.quantite_stock;
            row.Cells["seuil_alerte"].Value = med.seuil_alerte;

            // Stocker l'objet complet dans la propriété Tag de la ligne
            row.Tag = med;

            // Appliquer une couleur si le stock est faible
            if (med.quantite_stock <= med.seuil_alerte)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 57, 43);
            }
        }

        // Événement lors de la sélection d'une ligne
        private void dgvResultats_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResultats.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvResultats.SelectedRows[0];
                medicament med = row.Tag as medicament;

                if (med != null)
                {
                    AfficherDetails(med);
                }
            }
        }

        // Afficher les détails d'un médicament
        private void AfficherDetails(medicament med)
        {
            lblDetailId.Text = $"ID : {med.idM}";
            lblDetailReference.Text = $"Référence : {med.reference}";
            lblDetailNom.Text = $"Nom : {med.nom}";
            lblDetailDescription.Text = $"Description :\n{med.description_medicament}";
            lblDetailPrix.Text = $"Prix : {med.prix:F2} DH";
            lblDetailQuantite.Text = $"Quantité en stock : {med.quantite_stock}";
            lblDetailSeuil.Text = $"Seuil d'alerte : {med.seuil_alerte}";
            lblDetailDateE.Text = $"Date d'expiration : {med.dateE:dd/MM/yyyy}";
            lblDetailDateP.Text = $"Date de production : {med.dateP:dd/MM/yyyy}";

            // Changer la couleur du stock si nécessaire
            if (med.quantite_stock <= med.seuil_alerte)
            {
                lblDetailQuantite.ForeColor = Color.FromArgb(192, 57, 43);
                lblDetailSeuil.ForeColor = Color.FromArgb(192, 57, 43);
            }
            else
            {
                lblDetailQuantite.ForeColor = Color.FromArgb(52, 73, 94);
                lblDetailSeuil.ForeColor = Color.FromArgb(52, 73, 94);
            }

            // Vérifier si le médicament est expiré
            if (med.dateE < DateOnly.FromDateTime(DateTime.Now))
            {
                lblDetailDateE.ForeColor = Color.FromArgb(192, 57, 43);
                lblDetailDateE.Text += " ⚠️ EXPIRÉ";
            }
            else
            {
                lblDetailDateE.ForeColor = Color.FromArgb(52, 73, 94);
            }
        }

        // Vider les détails
        private void ViderDetails()
        {
            lblDetailId.Text = "ID : -";
            lblDetailReference.Text = "Référence : -";
            lblDetailNom.Text = "Nom : -";
            lblDetailDescription.Text = "Description : -";
            lblDetailPrix.Text = "Prix : -";
            lblDetailQuantite.Text = "Quantité en stock : -";
            lblDetailSeuil.Text = "Seuil d'alerte : -";
            lblDetailDateE.Text = "Date d'expiration : -";
            lblDetailDateP.Text = "Date de production : -";

            // Réinitialiser les couleurs
            lblDetailQuantite.ForeColor = Color.FromArgb(52, 73, 94);
            lblDetailSeuil.ForeColor = Color.FromArgb(52, 73, 94);
            lblDetailDateE.ForeColor = Color.FromArgb(52, 73, 94);
        }

        // Bouton Réinitialiser
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtRecherche.Clear();
            dgvResultats.Rows.Clear();
            ViderDetails();
            radioId.Checked = true;
            txtRecherche.Focus();
        }

        // Bouton Fermer
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validation KeyPress pour la recherche par ID
        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si recherche par ID, autoriser seulement les chiffres
            if (radioId.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            // Permettre d'appuyer sur Entrée pour rechercher
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRechercher_Click(sender, e);
                e.Handled = true;
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}