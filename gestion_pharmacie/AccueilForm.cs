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
            int formHeight = 600; // Hauteur totale du contenu (à adapter selon tes contrôles)
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = formHeight - this.ClientSize.Height;
            vScrollBar1.SmallChange = 10; // défilement petit
            vScrollBar1.LargeChange = 50; // défilement grand
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

            // Créer un panel de recherche
            Guna2Panel searchPanel = new Guna2Panel
            {
                Size = new Size(900, 500),
                Location = new Point(30, 30),
                BorderRadius = 15,
                FillColor = Color.White
            };

            Label lblTitle = new Label
            {
                Text = "🔍 Rechercher un Médicament",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Guna2TextBox txtSearch = new Guna2TextBox
            {
                PlaceholderText = "Entrez le nom ou la référence du médicament...",
                Size = new Size(600, 40),
                Location = new Point(20, 70),
                BorderRadius = 8
            };

            Guna2Button btnSearch = new Guna2Button
            {
                Text = "Rechercher",
                Size = new Size(150, 40),
                Location = new Point(640, 70),
                BorderRadius = 8,
                FillColor = Color.FromArgb(99, 102, 241)
            };

            Label lblResult = new Label
            {
                Text = "Entrez un terme de recherche pour commencer...",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(20, 130),
                Size = new Size(850, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            btnSearch.Click += (s, ev) =>
            {
                string searchTerm = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Veuillez entrer un terme de recherche.", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var medicaments = medicament.get_all_medicaments();
                var results = medicaments.Where(m =>
                    m.nom.ToLower().Contains(searchTerm.ToLower()) ||
                    m.reference.ToLower().Contains(searchTerm.ToLower())
                ).ToList();

                if (results.Count == 0)
                {
                    lblResult.Text = "❌ Aucun médicament trouvé.";
                }
                else
                {
                    string resultText = $"✅ {results.Count} médicament(s) trouvé(s):\n\n";
                    foreach (var med in results)
                    {
                        resultText += $"📦 {med.nom} (Réf: {med.reference})\n";
                        resultText += $"   Stock: {med.quantite_stock} | Prix: {med.prix} DH\n";
                        resultText += $"   Péremption: {med.dateP}\n\n";
                    }
                    lblResult.Text = resultText;
                }
            };

            searchPanel.Controls.Add(lblTitle);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Controls.Add(lblResult);
            panelMain.Controls.Add(searchPanel);
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
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Add(formAjouter);
            formAjouter.Show();

            // Rafraîchir le dashboard après la fermeture
            formAjouter.FormClosed += (s, ev) => LoadDashboard();
        }

        // ✏️ Bouton Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnModifier.FillColor = Color.FromArgb(49, 110, 226);

            Label lbl = new Label
            {
                Text = "✏️ Modifier un Médicament\n\n(Fonctionnalité à venir...)\n\nSélectionnez un médicament depuis la liste pour le modifier.",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                AutoSize = true,
                Location = new Point(50, 50)
            };
            panelMain.Controls.Add(lbl);
        }

        // 🗑️ Bouton Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ResetButtonColors();
            btnSupprimer.FillColor = Color.FromArgb(219, 58, 58);

            Label lbl = new Label
            {
                Text = "🗑️ Supprimer un Médicament\n\n(Fonctionnalité à venir...)\n\nSélectionnez un médicament depuis la liste pour le supprimer.",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                AutoSize = true,
                Location = new Point(50, 50)
            };
            panelMain.Controls.Add(lbl);
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
                    FillColor = Color.White
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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Décale tous les contrôles verticalement selon la valeur de la scrollbar
            foreach (Control ctrl in this.Controls)
            {
                // On ignore la scrollbar elle-même
                if (ctrl != vScrollBar1)
                    ctrl.Top = ctrl.Top - (e.NewValue - e.OldValue);
            }
        }
    }
}