using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace gestion_pharmacie
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
            panelMain.AutoScroll = true;
        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {
            // Charger le tableau de bord au démarrage
            LoadDashboard();
        }

        // 🏠 Charger le Tableau de Bord avec les statistiques
        private void LoadDashboard()
        {
            try
            {
                // Récupérer tous les médicaments
                var medicaments = medicament.get_all_medicaments();

                // 💊 Total des médicaments
                lblTotalMedicamentsValue.Text = medicaments.Count.ToString();

                // ⚠️ Médicaments en alerte (stock < seuil)
                int alerteCount = medicaments.Count(m => m.quantite_stock < m.seuil_alerte);
                lblAlerteValue.Text = alerteCount.ToString();

                // 📅 Médicaments bientôt périmés (< 30 jours)
                DateTime dateLimit = DateTime.Today.AddDays(30);
                int peremptionCount = medicaments.Count(m =>
                    m.dateP.ToDateTime(TimeOnly.MinValue) <= dateLimit &&
                    m.dateP.ToDateTime(TimeOnly.MinValue) >= DateTime.Today
                );
                lblPeremptionValue.Text = peremptionCount.ToString();

                // 💰 Valeur totale du stock
                float valeurTotale = medicaments.Sum(m => m.prix * m.quantite_stock);
                lblValeurStockValue.Text = $"{valeurTotale:N2} DH";

                // Afficher les cartes dashboard
                ShowDashboardCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques:\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Afficher les cartes du dashboard
        private void ShowDashboardCards()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(cardTotalMedicaments);
            panelMain.Controls.Add(cardAlerte);
            panelMain.Controls.Add(cardPeremption);
            panelMain.Controls.Add(cardValeurStock);
        }

        // 🏠 Bouton Tableau de Bord
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            ResetButtonColors();
            btnDashboard.FillColor = Color.FromArgb(94, 148, 255);
        }

        // 🔍 Bouton Rechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnRechercher.FillColor = Color.FromArgb(79, 82, 201);

            RechercherMedicament formRechercher = new RechercherMedicament
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                AutoScaleMode = AutoScaleMode.None,
                AutoSize = false,
                Width = panelMain.Width - 40,
                Height = panelMain.Height - 40
            };

            panelMain.Controls.Add(formRechercher);
            formRechercher.Show();
            formRechercher.FormClosed += (s, ev) => LoadDashboard();
        }

        // ➕ Bouton Ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnAjouter.FillColor = Color.FromArgb(21, 157, 74);

            AjouterMedicament formAjouter = new AjouterMedicament
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                AutoScaleMode = AutoScaleMode.None,
                AutoSize = false,
                Width = panelMain.Width - 20,
                Height = panelMain.Height - 20
            };

            panelMain.Controls.Add(formAjouter);
            formAjouter.Show();
            formAjouter.FormClosed += (s, ev) => LoadDashboard();
        }

        // ✏️ Bouton Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnModifier.FillColor = Color.FromArgb(49, 110, 226);

            ModifierMedicament formModifier = new ModifierMedicament
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                AutoScaleMode = AutoScaleMode.None,
                AutoSize = false,
                Width = panelMain.Width - 20,
                Height = panelMain.Height - 20
            };

            panelMain.Controls.Add(formModifier);
            formModifier.Show();
            formModifier.FormClosed += (s, ev) => LoadDashboard();
        }

        // 🗑️ Bouton Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnSupprimer.FillColor = Color.FromArgb(219, 58, 58);

            // Créer le formulaire de suppression avec la nouvelle taille
            SupprimerMedicament formSupprimer = new SupprimerMedicament
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                AutoScaleMode = AutoScaleMode.None,
                AutoSize = false,
                Width = 900,  // Largeur fixe adaptée au design
                Height = 600  // Hauteur fixe adaptée au design
            };

            // Centrer le formulaire dans panelMain
            int x = (panelMain.Width - formSupprimer.Width) / 2;
            int y = (panelMain.Height - formSupprimer.Height) / 2;

            // S'assurer que les coordonnées ne sont pas négatives
            x = Math.Max(x, 0);
            y = Math.Max(y, 0);

            formSupprimer.Location = new Point(x, y);

            panelMain.Controls.Add(formSupprimer);
            formSupprimer.Show();
            formSupprimer.FormClosed += (s, ev) => LoadDashboard();
        }

        // ⚠️ Bouton Alertes
        private void btnAlerte_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnAlerte.FillColor = Color.FromArgb(225, 138, 1);

            try
            {
                var medicaments = medicament.get_all_medicaments();
                var alertes = medicaments.Where(m => m.quantite_stock < m.seuil_alerte).ToList();

                Guna2Panel alertPanel = new Guna2Panel
                {
                    Size = new Size(900, 500),
                    Location = new Point(30, 30),
                    BorderRadius = 15,
                    FillColor = Color.White,
                    AutoScroll = true
                };

                Label lblTitle = new Label
                {
                    Text = $"⚠️ Médicaments en Alerte Stock ({alertes.Count})",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    ForeColor = Color.FromArgb(245, 158, 11),
                    Location = new Point(20, 20),
                    AutoSize = true
                };

                string alerteText = "";
                if (alertes.Count == 0)
                {
                    alerteText = "✅ Aucun médicament en alerte. Tous les stocks sont suffisants.";
                }
                else
                {
                    foreach (var med in alertes)
                    {
                        alerteText += $"⚠️ {med.nom}\n";
                        alerteText += $"   Référence: {med.reference}\n";
                        alerteText += $"   Stock actuel: {med.quantite_stock} | Seuil: {med.seuil_alerte}\n";
                        alerteText += $"   Prix unitaire: {med.prix} DH\n";
                        alerteText += "   ──────────────────────────────\n\n";
                    }
                }

                Label lblAlertes = new Label
                {
                    Text = alerteText,
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Location = new Point(20, 70),
                    Size = new Size(850, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                alertPanel.Controls.Add(lblTitle);
                alertPanel.Controls.Add(lblAlertes);
                panelMain.Controls.Add(alertPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des alertes:\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🚪 Déconnexion
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        // Réinitialiser les couleurs des boutons
        private void ResetButtonColors()
        {
            btnDashboard.FillColor = Color.FromArgb(94, 148, 255);
            btnRechercher.FillColor = Color.FromArgb(99, 102, 241);
            btnAjouter.FillColor = Color.FromArgb(34, 197, 94);
            btnModifier.FillColor = Color.FromArgb(59, 130, 246);
            btnSupprimer.FillColor = Color.FromArgb(239, 68, 68);
            btnAlerte.FillColor = Color.FromArgb(245, 158, 11);
        }
    }
}