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
        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        // 🏠 Charger le Tableau de Bord avec les statistiques
        private void LoadDashboard()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques:\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🏠 Bouton Tableau de Bord
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            ResetButtonColors();
            btnDashboard.FillColor = Color.FromArgb(94, 148, 255);
        }

        // 🔍 Bouton Rechercher - Ouvrir dans une nouvelle fenêtre
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRechercher.FillColor = Color.FromArgb(79, 82, 201);

            RechercherMedicament formRechercher = new RechercherMedicament();
            formRechercher.ShowDialog(); // Ouvrir en mode Dialog (bloque la fenêtre parente)
                                         // Ou utilisez .Show() pour ouvrir sans bloquer

            LoadDashboard(); // Rafraîchir après fermeture
        }

        // ➕ Bouton Ajouter - Ouvrir dans une nouvelle fenêtre
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAjouter.FillColor = Color.FromArgb(21, 157, 74);

            AjouterMedicament formAjouter = new AjouterMedicament();
            formAjouter.ShowDialog();

            LoadDashboard(); // Rafraîchir le dashboard après l'ajout
        }

        // ✏️ Bouton Modifier - Ouvrir dans une nouvelle fenêtre
        private void btnModifier_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnModifier.FillColor = Color.FromArgb(49, 110, 226);

            ModifierMedicament formModifier = new ModifierMedicament();
            formModifier.ShowDialog();

            LoadDashboard(); // Rafraîchir après modification
        }

        // 🗑️ Bouton Supprimer - Ouvrir dans une nouvelle fenêtre
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSupprimer.FillColor = Color.FromArgb(219, 58, 58);

            SupprimerMedicament formSupprimer = new SupprimerMedicament();
            formSupprimer.ShowDialog();

            LoadDashboard(); // Rafraîchir après suppression
        }

        // ⚠️ Bouton Alertes - Afficher dans une fenêtre popup
        private void btnAlerte_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAlerte.FillColor = Color.FromArgb(225, 138, 1);

            try
            {
                var medicaments = medicament.get_all_medicaments();
                var alertes = medicaments.Where(m => m.quantite_stock < m.seuil_alerte).ToList();

                // Créer un formulaire pour afficher les alertes
                Form formAlertes = new Form
                {
                    Text = "⚠️ Alertes Stock",
                    Size = new Size(900, 600),
                    StartPosition = FormStartPosition.CenterScreen,
                    BackColor = Color.FromArgb(241, 245, 249),
                    AutoScroll = true // Le formulaire lui-même aura le scroll
                };

                // Panel principal avec scroll
                Panel mainPanel = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    BackColor = Color.Transparent,
                    Padding = new Padding(30)
                };

                // Titre
                Label lblTitle = new Label
                {
                    Text = $"⚠️ Médicaments en Alerte Stock ({alertes.Count})",
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    ForeColor = Color.FromArgb(245, 158, 11),
                    Location = new Point(30, 20),
                    AutoSize = true
                };
                mainPanel.Controls.Add(lblTitle);

                int yPos = 80;

                if (alertes.Count == 0)
                {
                    Label lblEmpty = new Label
                    {
                        Text = "✅ Aucun médicament en alerte.\nTous les stocks sont suffisants.",
                        Font = new Font("Segoe UI", 14),
                        ForeColor = Color.FromArgb(34, 197, 94),
                        Location = new Point(30, yPos),
                        AutoSize = true
                    };
                    mainPanel.Controls.Add(lblEmpty);
                }
                else
                {
                    foreach (var med in alertes)
                    {
                        Guna2Panel cardAlerte = new Guna2Panel
                        {
                            Size = new Size(820, 130),
                            Location = new Point(30, yPos),
                            BorderRadius = 10,
                            FillColor = Color.FromArgb(254, 242, 242),
                            BorderColor = Color.FromArgb(239, 68, 68),
                            BorderThickness = 2
                        };

                        Label lblNom = new Label
                        {
                            Text = $"⚠️ {med.nom}",
                            Font = new Font("Segoe UI", 13, FontStyle.Bold),
                            ForeColor = Color.FromArgb(220, 38, 38),
                            Location = new Point(15, 15),
                            AutoSize = true
                        };

                        Label lblRef = new Label
                        {
                            Text = $"Référence: {med.reference}",
                            Font = new Font("Segoe UI", 10),
                            ForeColor = Color.FromArgb(100, 116, 139),
                            Location = new Point(15, 45),
                            AutoSize = true
                        };

                        Label lblStock = new Label
                        {
                            Text = $"📦 Stock actuel: {med.quantite_stock} | ⚠️ Seuil: {med.seuil_alerte}",
                            Font = new Font("Segoe UI", 11, FontStyle.Bold),
                            ForeColor = Color.FromArgb(220, 38, 38),
                            Location = new Point(15, 70),
                            AutoSize = true
                        };

                        Label lblPrix = new Label
                        {
                            Text = $"💰 Prix unitaire: {med.prix:F2} DH",
                            Font = new Font("Segoe UI", 10),
                            ForeColor = Color.FromArgb(100, 116, 139),
                            Location = new Point(15, 95),
                            AutoSize = true
                        };

                        cardAlerte.Controls.Add(lblNom);
                        cardAlerte.Controls.Add(lblRef);
                        cardAlerte.Controls.Add(lblStock);
                        cardAlerte.Controls.Add(lblPrix);

                        mainPanel.Controls.Add(cardAlerte);
                        yPos += 145;
                    }
                }

                // Bouton fermer
                Guna2Button btnFermer = new Guna2Button
                {
                    Text = "✓ Fermer",
                    Location = new Point(30, yPos + 20),
                    Size = new Size(150, 45),
                    BorderRadius = 10,
                    FillColor = Color.FromArgb(148, 163, 184),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White
                };
                btnFermer.Click += (s, ev) => formAlertes.Close();
                mainPanel.Controls.Add(btnFermer);

                formAlertes.Controls.Add(mainPanel);
                formAlertes.ShowDialog();
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
                login.ShowDialog();
                this.Close();
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