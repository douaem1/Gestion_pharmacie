namespace gestion_pharmacie
{
    partial class AccueilForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserWelcome;
        private Guna.UI2.WinForms.Guna2Button btnDeconnexion;

        // Menu Sidebar
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private System.Windows.Forms.Label lblMenuTitle;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnRechercher;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnAlerte;
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private Guna.UI2.WinForms.Guna2Separator separator2;

        // Main Content Area
        private Guna.UI2.WinForms.Guna2Panel panelMain;

        // Dashboard Cards
        private Guna.UI2.WinForms.Guna2Panel cardTotalMedicaments;
        private Guna.UI2.WinForms.Guna2Panel cardAlerte;
        private Guna.UI2.WinForms.Guna2Panel cardPeremption;
        private Guna.UI2.WinForms.Guna2Panel cardValeurStock;

        private System.Windows.Forms.Label lblTotalMedicaments;
        private System.Windows.Forms.Label lblTotalMedicamentsValue;
        private System.Windows.Forms.Label lblTotalMedicamentsIcon;

        private System.Windows.Forms.Label lblAlerte;
        private System.Windows.Forms.Label lblAlerteValue;
        private System.Windows.Forms.Label lblAlerteIcon;

        private System.Windows.Forms.Label lblPeremption;
        private System.Windows.Forms.Label lblPeremptionValue;
        private System.Windows.Forms.Label lblPeremptionIcon;

        private System.Windows.Forms.Label lblValeurStock;
        private System.Windows.Forms.Label lblValeurStockValue;
        private System.Windows.Forms.Label lblValeurStockIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            lblUserWelcome = new Label();
            btnDeconnexion = new Guna.UI2.WinForms.Guna2Button();
            panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            lblMenuTitle = new Label();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            separator1 = new Guna.UI2.WinForms.Guna2Separator();
            btnRechercher = new Guna.UI2.WinForms.Guna2Button();
            btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            btnModifier = new Guna.UI2.WinForms.Guna2Button();
            btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            separator2 = new Guna.UI2.WinForms.Guna2Separator();
            btnAlerte = new Guna.UI2.WinForms.Guna2Button();
            panelMain = new Guna.UI2.WinForms.Guna2Panel();
            cardTotalMedicaments = new Guna.UI2.WinForms.Guna2Panel();
            lblTotalMedicamentsIcon = new Label();
            lblTotalMedicaments = new Label();
            lblTotalMedicamentsValue = new Label();
            cardAlerte = new Guna.UI2.WinForms.Guna2Panel();
            lblAlerteIcon = new Label();
            lblAlerte = new Label();
            lblAlerteValue = new Label();
            cardPeremption = new Guna.UI2.WinForms.Guna2Panel();
            lblPeremptionIcon = new Label();
            lblPeremption = new Label();
            lblPeremptionValue = new Label();
            cardValeurStock = new Guna.UI2.WinForms.Guna2Panel();
            lblValeurStockIcon = new Label();
            lblValeurStock = new Label();
            lblValeurStockValue = new Label();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            cardTotalMedicaments.SuspendLayout();
            cardAlerte.SuspendLayout();
            cardPeremption.SuspendLayout();
            cardValeurStock.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(94, 148, 255);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblUserWelcome);
            panelHeader.Controls.Add(btnDeconnexion);
            panelHeader.CustomizableEdges = customizableEdges3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💊 Gestion Pharmacie";
            // 
            // lblUserWelcome
            // 
            lblUserWelcome.AutoSize = true;
            lblUserWelcome.BackColor = Color.Transparent;
            lblUserWelcome.Font = new Font("Segoe UI", 10F);
            lblUserWelcome.ForeColor = Color.White;
            lblUserWelcome.Location = new Point(30, 52);
            lblUserWelcome.Name = "lblUserWelcome";
            lblUserWelcome.Size = new Size(170, 19);
            lblUserWelcome.TabIndex = 1;
            lblUserWelcome.Text = "Bienvenue, Administrateur";
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Right;
            btnDeconnexion.BorderRadius = 10;
            btnDeconnexion.CustomizableEdges = customizableEdges1;
            btnDeconnexion.FillColor = Color.FromArgb(239, 68, 68);
            btnDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeconnexion.ForeColor = Color.White;
            btnDeconnexion.Location = new Point(1040, 20);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeconnexion.Size = new Size(140, 45);
            btnDeconnexion.TabIndex = 2;
            btnDeconnexion.Text = "🚪 Déconnexion";
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(248, 250, 252);
            panelSidebar.BorderColor = Color.FromArgb(226, 232, 240);
            panelSidebar.BorderThickness = 1;
            panelSidebar.Controls.Add(lblMenuTitle);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(separator1);
            panelSidebar.Controls.Add(btnRechercher);
            panelSidebar.Controls.Add(btnAjouter);
            panelSidebar.Controls.Add(btnModifier);
            panelSidebar.Controls.Add(btnSupprimer);
            panelSidebar.Controls.Add(separator2);
            panelSidebar.Controls.Add(btnAlerte);
            panelSidebar.CustomizableEdges = customizableEdges17;
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 80);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelSidebar.Size = new Size(250, 620);
            panelSidebar.TabIndex = 1;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMenuTitle.Location = new Point(20, 20);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(80, 20);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "📋 MENU";
            // 
            // btnDashboard
            // 
            btnDashboard.BorderRadius = 8;
            btnDashboard.CustomizableEdges = customizableEdges5;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(15, 60);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDashboard.Size = new Size(220, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "🏠 Tableau de Bord";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // separator1
            // 
            separator1.Location = new Point(15, 120);
            separator1.Name = "separator1";
            separator1.Size = new Size(220, 10);
            separator1.TabIndex = 2;
            // 
            // btnRechercher
            // 
            btnRechercher.BorderRadius = 8;
            btnRechercher.CustomizableEdges = customizableEdges7;
            btnRechercher.FillColor = Color.FromArgb(99, 102, 241);
            btnRechercher.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRechercher.ForeColor = Color.White;
            btnRechercher.Location = new Point(15, 145);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRechercher.Size = new Size(220, 45);
            btnRechercher.TabIndex = 3;
            btnRechercher.Text = "🔍 Rechercher";
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BorderRadius = 8;
            btnAjouter.CustomizableEdges = customizableEdges9;
            btnAjouter.FillColor = Color.FromArgb(34, 197, 94);
            btnAjouter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(15, 200);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAjouter.Size = new Size(220, 45);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "➕ Ajouter Médicament";
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BorderRadius = 8;
            btnModifier.CustomizableEdges = customizableEdges11;
            btnModifier.FillColor = Color.FromArgb(59, 130, 246);
            btnModifier.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(15, 255);
            btnModifier.Name = "btnModifier";
            btnModifier.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnModifier.Size = new Size(220, 45);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "✏️ Modifier Médicament";
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BorderRadius = 8;
            btnSupprimer.CustomizableEdges = customizableEdges13;
            btnSupprimer.FillColor = Color.FromArgb(239, 68, 68);
            btnSupprimer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(15, 310);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSupprimer.Size = new Size(220, 45);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "🗑️ Supprimer Médicament";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // separator2
            // 
            separator2.Location = new Point(15, 370);
            separator2.Name = "separator2";
            separator2.Size = new Size(220, 10);
            separator2.TabIndex = 7;
            // 
            // btnAlerte
            // 
            btnAlerte.BorderRadius = 8;
            btnAlerte.CustomizableEdges = customizableEdges15;
            btnAlerte.FillColor = Color.FromArgb(245, 158, 11);
            btnAlerte.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAlerte.ForeColor = Color.White;
            btnAlerte.Location = new Point(15, 395);
            btnAlerte.Name = "btnAlerte";
            btnAlerte.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAlerte.Size = new Size(220, 45);
            btnAlerte.TabIndex = 8;
            btnAlerte.Text = "⚠️ Alertes Stock";
            btnAlerte.Click += btnAlerte_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(241, 245, 249);
            panelMain.Controls.Add(cardTotalMedicaments);
            panelMain.Controls.Add(cardAlerte);
            panelMain.Controls.Add(cardPeremption);
            panelMain.Controls.Add(cardValeurStock);
            panelMain.CustomizableEdges = customizableEdges27;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.ShadowDecoration.CustomizableEdges = customizableEdges28;
            panelMain.Size = new Size(950, 620);
            panelMain.TabIndex = 2;
            // 
            // cardTotalMedicaments
            // 
            cardTotalMedicaments.BackColor = Color.Transparent;
            cardTotalMedicaments.BorderRadius = 15;
            cardTotalMedicaments.Controls.Add(lblTotalMedicamentsIcon);
            cardTotalMedicaments.Controls.Add(lblTotalMedicaments);
            cardTotalMedicaments.Controls.Add(lblTotalMedicamentsValue);
            cardTotalMedicaments.CustomizableEdges = customizableEdges19;
            cardTotalMedicaments.FillColor = Color.White;
            cardTotalMedicaments.Location = new Point(56, 30);
            cardTotalMedicaments.Name = "cardTotalMedicaments";
            cardTotalMedicaments.ShadowDecoration.BorderRadius = 15;
            cardTotalMedicaments.ShadowDecoration.Color = Color.FromArgb(94, 148, 255);
            cardTotalMedicaments.ShadowDecoration.CustomizableEdges = customizableEdges20;
            cardTotalMedicaments.ShadowDecoration.Depth = 10;
            cardTotalMedicaments.ShadowDecoration.Enabled = true;
            cardTotalMedicaments.Size = new Size(166, 140);
            cardTotalMedicaments.TabIndex = 0;
            // 
            // lblTotalMedicamentsIcon
            // 
            lblTotalMedicamentsIcon.AutoSize = true;
            lblTotalMedicamentsIcon.Font = new Font("Segoe UI", 32F);
            lblTotalMedicamentsIcon.ForeColor = Color.FromArgb(94, 148, 255);
            lblTotalMedicamentsIcon.Location = new Point(15, 15);
            lblTotalMedicamentsIcon.Name = "lblTotalMedicamentsIcon";
            lblTotalMedicamentsIcon.Size = new Size(84, 59);
            lblTotalMedicamentsIcon.TabIndex = 0;
            lblTotalMedicamentsIcon.Text = "💊";
            // 
            // lblTotalMedicaments
            // 
            lblTotalMedicaments.AutoSize = true;
            lblTotalMedicaments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalMedicaments.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalMedicaments.Location = new Point(15, 80);
            lblTotalMedicaments.Name = "lblTotalMedicaments";
            lblTotalMedicaments.Size = new Size(135, 19);
            lblTotalMedicaments.TabIndex = 1;
            lblTotalMedicaments.Text = "Total Médicaments";
            // 
            // lblTotalMedicamentsValue
            // 
            lblTotalMedicamentsValue.AutoSize = true;
            lblTotalMedicamentsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalMedicamentsValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalMedicamentsValue.Location = new Point(15, 100);
            lblTotalMedicamentsValue.Name = "lblTotalMedicamentsValue";
            lblTotalMedicamentsValue.Size = new Size(28, 32);
            lblTotalMedicamentsValue.TabIndex = 2;
            lblTotalMedicamentsValue.Text = "0";
            // 
            // cardAlerte
            // 
            cardAlerte.BackColor = Color.Transparent;
            cardAlerte.BorderRadius = 15;
            cardAlerte.Controls.Add(lblAlerteIcon);
            cardAlerte.Controls.Add(lblAlerte);
            cardAlerte.Controls.Add(lblAlerteValue);
            cardAlerte.CustomizableEdges = customizableEdges21;
            cardAlerte.FillColor = Color.White;
            cardAlerte.Location = new Point(279, 30);
            cardAlerte.Name = "cardAlerte";
            cardAlerte.ShadowDecoration.BorderRadius = 15;
            cardAlerte.ShadowDecoration.Color = Color.FromArgb(245, 158, 11);
            cardAlerte.ShadowDecoration.CustomizableEdges = customizableEdges22;
            cardAlerte.ShadowDecoration.Depth = 10;
            cardAlerte.ShadowDecoration.Enabled = true;
            cardAlerte.Size = new Size(166, 140);
            cardAlerte.TabIndex = 1;
            // 
            // lblAlerteIcon
            // 
            lblAlerteIcon.AutoSize = true;
            lblAlerteIcon.Font = new Font("Segoe UI", 32F);
            lblAlerteIcon.ForeColor = Color.FromArgb(245, 158, 11);
            lblAlerteIcon.Location = new Point(15, 15);
            lblAlerteIcon.Name = "lblAlerteIcon";
            lblAlerteIcon.Size = new Size(84, 59);
            lblAlerteIcon.TabIndex = 0;
            lblAlerteIcon.Text = "⚠️";
            // 
            // lblAlerte
            // 
            lblAlerte.AutoSize = true;
            lblAlerte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlerte.ForeColor = Color.FromArgb(100, 116, 139);
            lblAlerte.Location = new Point(15, 80);
            lblAlerte.Name = "lblAlerte";
            lblAlerte.Size = new Size(103, 19);
            lblAlerte.TabIndex = 1;
            lblAlerte.Text = "Stock Critique";
            // 
            // lblAlerteValue
            // 
            lblAlerteValue.AutoSize = true;
            lblAlerteValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAlerteValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblAlerteValue.Location = new Point(15, 100);
            lblAlerteValue.Name = "lblAlerteValue";
            lblAlerteValue.Size = new Size(28, 32);
            lblAlerteValue.TabIndex = 2;
            lblAlerteValue.Text = "0";
            // 
            // cardPeremption
            // 
            cardPeremption.BackColor = Color.Transparent;
            cardPeremption.BorderRadius = 15;
            cardPeremption.Controls.Add(lblPeremptionIcon);
            cardPeremption.Controls.Add(lblPeremption);
            cardPeremption.Controls.Add(lblPeremptionValue);
            cardPeremption.CustomizableEdges = customizableEdges23;
            cardPeremption.FillColor = Color.White;
            cardPeremption.Location = new Point(496, 30);
            cardPeremption.Name = "cardPeremption";
            cardPeremption.ShadowDecoration.BorderRadius = 15;
            cardPeremption.ShadowDecoration.Color = Color.FromArgb(239, 68, 68);
            cardPeremption.ShadowDecoration.CustomizableEdges = customizableEdges24;
            cardPeremption.ShadowDecoration.Depth = 10;
            cardPeremption.ShadowDecoration.Enabled = true;
            cardPeremption.Size = new Size(167, 140);
            cardPeremption.TabIndex = 2;
            // 
            // lblPeremptionIcon
            // 
            lblPeremptionIcon.AutoSize = true;
            lblPeremptionIcon.Font = new Font("Segoe UI", 32F);
            lblPeremptionIcon.ForeColor = Color.FromArgb(239, 68, 68);
            lblPeremptionIcon.Location = new Point(15, 15);
            lblPeremptionIcon.Name = "lblPeremptionIcon";
            lblPeremptionIcon.Size = new Size(84, 59);
            lblPeremptionIcon.TabIndex = 0;
            lblPeremptionIcon.Text = "📅";
            // 
            // lblPeremption
            // 
            lblPeremption.AutoSize = true;
            lblPeremption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPeremption.ForeColor = Color.FromArgb(100, 116, 139);
            lblPeremption.Location = new Point(15, 80);
            lblPeremption.Name = "lblPeremption";
            lblPeremption.Size = new Size(115, 19);
            lblPeremption.TabIndex = 1;
            lblPeremption.Text = "Bientôt périmés";
            // 
            // lblPeremptionValue
            // 
            lblPeremptionValue.AutoSize = true;
            lblPeremptionValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPeremptionValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblPeremptionValue.Location = new Point(15, 100);
            lblPeremptionValue.Name = "lblPeremptionValue";
            lblPeremptionValue.Size = new Size(28, 32);
            lblPeremptionValue.TabIndex = 2;
            lblPeremptionValue.Text = "0";
            // 
            // cardValeurStock
            // 
            cardValeurStock.BackColor = Color.Transparent;
            cardValeurStock.BorderRadius = 15;
            cardValeurStock.Controls.Add(lblValeurStockIcon);
            cardValeurStock.Controls.Add(lblValeurStock);
            cardValeurStock.Controls.Add(lblValeurStockValue);
            cardValeurStock.CustomizableEdges = customizableEdges25;
            cardValeurStock.FillColor = Color.White;
            cardValeurStock.Location = new Point(712, 30);
            cardValeurStock.Name = "cardValeurStock";
            cardValeurStock.ShadowDecoration.BorderRadius = 15;
            cardValeurStock.ShadowDecoration.Color = Color.FromArgb(34, 197, 94);
            cardValeurStock.ShadowDecoration.CustomizableEdges = customizableEdges26;
            cardValeurStock.ShadowDecoration.Depth = 10;
            cardValeurStock.ShadowDecoration.Enabled = true;
            cardValeurStock.Size = new Size(169, 140);
            cardValeurStock.TabIndex = 3;
            // 
            // lblValeurStockIcon
            // 
            lblValeurStockIcon.AutoSize = true;
            lblValeurStockIcon.Font = new Font("Segoe UI", 32F);
            lblValeurStockIcon.ForeColor = Color.FromArgb(34, 197, 94);
            lblValeurStockIcon.Location = new Point(15, 15);
            lblValeurStockIcon.Name = "lblValeurStockIcon";
            lblValeurStockIcon.Size = new Size(84, 59);
            lblValeurStockIcon.TabIndex = 0;
            lblValeurStockIcon.Text = "💰";
            // 
            // lblValeurStock
            // 
            lblValeurStock.AutoSize = true;
            lblValeurStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValeurStock.ForeColor = Color.FromArgb(100, 116, 139);
            lblValeurStock.Location = new Point(15, 80);
            lblValeurStock.Name = "lblValeurStock";
            lblValeurStock.Size = new Size(92, 19);
            lblValeurStock.TabIndex = 1;
            lblValeurStock.Text = "Valeur Stock";
            // 
            // lblValeurStockValue
            // 
            lblValeurStockValue.AutoSize = true;
            lblValeurStockValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValeurStockValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblValeurStockValue.Location = new Point(15, 100);
            lblValeurStockValue.Name = "lblValeurStockValue";
            lblValeurStockValue.Size = new Size(65, 30);
            lblValeurStockValue.TabIndex = 2;
            lblValeurStockValue.Text = "0 DH";
            // 
            // AccueilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccueilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie";
            Load += AccueilForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            cardTotalMedicaments.ResumeLayout(false);
            cardTotalMedicaments.PerformLayout();
            cardAlerte.ResumeLayout(false);
            cardAlerte.PerformLayout();
            cardPeremption.ResumeLayout(false);
            cardPeremption.PerformLayout();
            cardValeurStock.ResumeLayout(false);
            cardValeurStock.PerformLayout();
            ResumeLayout(false);
        }
    }
}