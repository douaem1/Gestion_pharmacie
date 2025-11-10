namespace gestion_pharmacie
{
    partial class ModifierMedicament
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBoxDates = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpProduction = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBoxStock = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSeuil = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelRecherche = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChercher = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdRecherche = new System.Windows.Forms.Label();
            this.txtQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrix = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReference = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelRecherche.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            this.groupBoxStock.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.BorderRadius = 20;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Location = new System.Drawing.Point(890, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(90, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Modifier Médicament";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.ImageRotate = 0F;
            this.pictureBoxIcon.Location = new System.Drawing.Point(20, 15);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.UseTransparentBackground = true;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panelMain.Controls.Add(this.panelRecherche);
            this.panelMain.Controls.Add(this.groupBoxDates);
            this.panelMain.Controls.Add(this.groupBoxStock);
            this.panelMain.Controls.Add(this.groupBoxInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(950, 650);
            this.panelMain.TabIndex = 1;
            // 
            // panelRecherche
            // 
            this.panelRecherche.BackColor = System.Drawing.Color.White;
            this.panelRecherche.BorderRadius = 15;
            this.panelRecherche.Controls.Add(this.btnChercher);
            this.panelRecherche.Controls.Add(this.txtIdRecherche);
            this.panelRecherche.Controls.Add(this.lblIdRecherche);
            this.panelRecherche.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panelRecherche.Location = new System.Drawing.Point(20, 20);
            this.panelRecherche.Name = "panelRecherche";
            this.panelRecherche.ShadowDecoration.BorderRadius = 15;
            this.panelRecherche.ShadowDecoration.Depth = 10;
            this.panelRecherche.ShadowDecoration.Enabled = true;
            this.panelRecherche.Size = new System.Drawing.Size(910, 80);
            this.panelRecherche.TabIndex = 3;
            // 
            // lblIdRecherche
            // 
            this.lblIdRecherche.AutoSize = true;
            this.lblIdRecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblIdRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdRecherche.ForeColor = System.Drawing.Color.White;
            this.lblIdRecherche.Location = new System.Drawing.Point(20, 25);
            this.lblIdRecherche.Name = "lblIdRecherche";
            this.lblIdRecherche.Size = new System.Drawing.Size(246, 20);
            this.lblIdRecherche.TabIndex = 0;
            this.lblIdRecherche.Text = "🔍 ID du Médicament à Modifier :";
            // 
            // txtIdRecherche
            // 
            this.txtIdRecherche.Animated = true;
            this.txtIdRecherche.BorderColor = System.Drawing.Color.White;
            this.txtIdRecherche.BorderRadius = 10;
            this.txtIdRecherche.BorderThickness = 2;
            this.txtIdRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdRecherche.DefaultText = "";
            this.txtIdRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdRecherche.FocusedState.BorderColor = System.Drawing.Color.White;
            this.txtIdRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtIdRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtIdRecherche.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtIdRecherche.Location = new System.Drawing.Point(280, 20);
            this.txtIdRecherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRecherche.Name = "txtIdRecherche";
            this.txtIdRecherche.PasswordChar = '\0';
            this.txtIdRecherche.PlaceholderText = "Entrez l\'ID...";
            this.txtIdRecherche.SelectedText = "";
            this.txtIdRecherche.Size = new System.Drawing.Size(400, 40);
            this.txtIdRecherche.TabIndex = 1;
            this.txtIdRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdRecherche_KeyPress);
            // 
            // btnChercher
            // 
            this.btnChercher.Animated = true;
            this.btnChercher.BorderRadius = 10;
            this.btnChercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChercher.FillColor = System.Drawing.Color.White;
            this.btnChercher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnChercher.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnChercher.Location = new System.Drawing.Point(700, 20);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(190, 40);
            this.btnChercher.TabIndex = 2;
            this.btnChercher.Text = "🔍 Chercher";
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBoxDates.BorderRadius = 15;
            this.groupBoxDates.BorderThickness = 2;
            this.groupBoxDates.Controls.Add(this.dtpProduction);
            this.groupBoxDates.Controls.Add(this.dtpExpiration);
            this.groupBoxDates.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBoxDates.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxDates.ForeColor = System.Drawing.Color.White;
            this.groupBoxDates.Location = new System.Drawing.Point(500, 430);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(430, 200);
            this.groupBoxDates.TabIndex = 2;
            this.groupBoxDates.Text = "📅 Dates";
            // 
            // dtpProduction
            // 
            this.dtpProduction.Animated = true;
            this.dtpProduction.BorderRadius = 10;
            this.dtpProduction.Checked = true;
            this.dtpProduction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dtpProduction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpProduction.ForeColor = System.Drawing.Color.White;
            this.dtpProduction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProduction.Location = new System.Drawing.Point(20, 140);
            this.dtpProduction.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProduction.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProduction.Name = "dtpProduction";
            this.dtpProduction.Size = new System.Drawing.Size(390, 40);
            this.dtpProduction.TabIndex = 1;
            this.dtpProduction.Value = new System.DateTime(2025, 11, 8, 0, 0, 0, 0);
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Animated = true;
            this.dtpExpiration.BorderRadius = 10;
            this.dtpExpiration.Checked = true;
            this.dtpExpiration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dtpExpiration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpExpiration.ForeColor = System.Drawing.Color.White;
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiration.Location = new System.Drawing.Point(20, 70);
            this.dtpExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(390, 40);
            this.dtpExpiration.TabIndex = 0;
            this.dtpExpiration.Value = new System.DateTime(2025, 11, 8, 0, 0, 0, 0);
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.groupBoxStock.BorderRadius = 15;
            this.groupBoxStock.BorderThickness = 2;
            this.groupBoxStock.Controls.Add(this.txtSeuil);
            this.groupBoxStock.Controls.Add(this.txtQuantite);
            this.groupBoxStock.Controls.Add(this.txtPrix);
            this.groupBoxStock.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.groupBoxStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxStock.ForeColor = System.Drawing.Color.White;
            this.groupBoxStock.Location = new System.Drawing.Point(20, 430);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.Size = new System.Drawing.Size(460, 200);
            this.groupBoxStock.TabIndex = 1;
            this.groupBoxStock.Text = "📦 Stock && Prix";
            // 
            // txtSeuil
            // 
            this.txtSeuil.Animated = true;
            this.txtSeuil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtSeuil.BorderRadius = 10;
            this.txtSeuil.BorderThickness = 2;
            this.txtSeuil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeuil.DefaultText = "";
            this.txtSeuil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeuil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeuil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeuil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeuil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtSeuil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSeuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtSeuil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtSeuil.Location = new System.Drawing.Point(240, 140);
            this.txtSeuil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.PasswordChar = '\0';
            this.txtSeuil.PlaceholderText = "Seuil d\'alerte";
            this.txtSeuil.SelectedText = "";
            this.txtSeuil.Size = new System.Drawing.Size(200, 40);
            this.txtSeuil.TabIndex = 2;
            this.txtSeuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeuil_KeyPress);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Animated = true;
            this.txtQuantite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtQuantite.BorderRadius = 10;
            this.txtQuantite.BorderThickness = 2;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.DefaultText = "";
            this.txtQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtQuantite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtQuantite.Location = new System.Drawing.Point(20, 140);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.PasswordChar = '\0';
            this.txtQuantite.PlaceholderText = "Quantité en stock";
            this.txtQuantite.SelectedText = "";
            this.txtQuantite.Size = new System.Drawing.Size(200, 40);
            this.txtQuantite.TabIndex = 1;
            this.txtQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantite_KeyPress);
            // 
            // txtPrix
            // 
            this.txtPrix.Animated = true;
            this.txtPrix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtPrix.BorderRadius = 10;
            this.txtPrix.BorderThickness = 2;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.DefaultText = "";
            this.txtPrix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPrix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtPrix.Location = new System.Drawing.Point(20, 70);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PasswordChar = '\0';
            this.txtPrix.PlaceholderText = "Prix (DH)";
            this.txtPrix.SelectedText = "";
            this.txtPrix.Size = new System.Drawing.Size(420, 40);
            this.txtPrix.TabIndex = 0;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.groupBoxInfo.BorderRadius = 15;
            this.groupBoxInfo.BorderThickness = 2;
            this.groupBoxInfo.Controls.Add(this.txtDescription);
            this.groupBoxInfo.Controls.Add(this.txtNom);
            this.groupBoxInfo.Controls.Add(this.txtReference);
            this.groupBoxInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.White;
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(910, 300);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.Text = "ℹ️ Informations Générales";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderThickness = 2;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtDescription.Location = new System.Drawing.Point(20, 190);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Description du médicament...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(870, 90);
            this.txtDescription.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Animated = true;
            this.txtNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNom.BorderRadius = 10;
            this.txtNom.BorderThickness = 2;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtNom.Location = new System.Drawing.Point(460, 120);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "Nom du médicament";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(430, 40);
            this.txtNom.TabIndex = 1;
            // 
            // txtReference
            // 
            this.txtReference.Animated = true;
            this.txtReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtReference.BorderRadius = 10;
            this.txtReference.BorderThickness = 2;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.DefaultText = "";
            this.txtReference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtReference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.txtReference.Location = new System.Drawing.Point(20, 120);
            this.txtReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.PlaceholderText = "Référence";
            this.txtReference.SelectedText = "";
            this.txtReference.Size = new System.Drawing.Size(420, 40);
            this.txtReference.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Animated = true;
            this.btnAnnuler.BorderRadius = 15;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAnnuler.Location = new System.Drawing.Point(500, 760);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(200, 50);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Animated = true;
            this.btnModifier.BorderRadius = 15;
            this.btnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(76)))));
            this.btnModifier.Location = new System.Drawing.Point(730, 760);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 50);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // ModifierMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(950, 830);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifierMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier Médicament";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxStock.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelRecherche;
        private Guna.UI2.WinForms.Guna2Button btnChercher;
        private Guna.UI2.WinForms.Guna2TextBox txtIdRecherche;
        private System.Windows.Forms.Label lblIdRecherche;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtReference;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxStock;
        private Guna.UI2.WinForms.Guna2TextBox txtSeuil;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantite;
        private Guna.UI2.WinForms.Guna2TextBox txtPrix;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDates;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProduction;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiration;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
    }
}