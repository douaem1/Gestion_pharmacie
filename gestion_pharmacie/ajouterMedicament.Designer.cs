namespace gestion_pharmacie
{
    partial class AjouterMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtReference = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.nudPrix = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.nudQuantite = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.nudSeuil = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblDateE = new System.Windows.Forms.Label();
            this.dtpDateE = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateP = new System.Windows.Forms.Label();
            this.dtpDateP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ajouter un Médicament";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(362, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Remplissez les informations du nouveau médicament";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btnAnnuler);
            this.panelMain.Controls.Add(this.btnAjouter);
            this.panelMain.Controls.Add(this.dtpDateP);
            this.panelMain.Controls.Add(this.lblDateP);
            this.panelMain.Controls.Add(this.dtpDateE);
            this.panelMain.Controls.Add(this.lblDateE);
            this.panelMain.Controls.Add(this.nudSeuil);
            this.panelMain.Controls.Add(this.lblSeuil);
            this.panelMain.Controls.Add(this.nudQuantite);
            this.panelMain.Controls.Add(this.lblQuantite);
            this.panelMain.Controls.Add(this.nudPrix);
            this.panelMain.Controls.Add(this.lblPrix);
            this.panelMain.Controls.Add(this.txtDescription);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.txtNom);
            this.panelMain.Controls.Add(this.lblNom);
            this.panelMain.Controls.Add(this.txtReference);
            this.panelMain.Controls.Add(this.lblReference);
            this.panelMain.Controls.Add(this.separator1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 20, 30, 30);
            this.panelMain.Size = new System.Drawing.Size(600, 630);
            this.panelMain.TabIndex = 1;
            // 
            // separator1
            // 
            this.separator1.Location = new System.Drawing.Point(30, 20);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(540, 10);
            this.separator1.TabIndex = 0;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReference.Location = new System.Drawing.Point(30, 50);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(90, 19);
            this.lblReference.TabIndex = 1;
            this.lblReference.Text = "Référence *";
            // 
            // txtReference
            // 
            this.txtReference.BorderRadius = 8;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.DefaultText = "";
            this.txtReference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.Location = new System.Drawing.Point(30, 75);
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.PlaceholderText = "Ex: MED-2025-001";
            this.txtReference.SelectedText = "";
            this.txtReference.Size = new System.Drawing.Size(540, 40);
            this.txtReference.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNom.Location = new System.Drawing.Point(30, 130);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(182, 19);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom du médicament *";
            // 
            // txtNom
            // 
            this.txtNom.BorderRadius = 8;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Location = new System.Drawing.Point(30, 155);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "Ex: Paracétamol 500mg";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(540, 40);
            this.txtNom.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 210);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 19);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description *";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(30, 235);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Décrivez les indications et posologie...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(540, 80);
            this.txtDescription.TabIndex = 6;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrix.Location = new System.Drawing.Point(30, 330);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(76, 19);
            this.lblPrix.TabIndex = 7;
            this.lblPrix.Text = "Prix (DH) *";
            // 
            // nudPrix
            // 
            this.nudPrix.BackColor = System.Drawing.Color.Transparent;
            this.nudPrix.BorderRadius = 8;
            this.nudPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPrix.DecimalPlaces = 2;
            this.nudPrix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPrix.Location = new System.Drawing.Point(30, 355);
            this.nudPrix.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(165, 40);
            this.nudPrix.TabIndex = 8;
            this.nudPrix.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantite.Location = new System.Drawing.Point(217, 330);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(135, 19);
            this.lblQuantite.TabIndex = 9;
            this.lblQuantite.Text = "Quantité en stock";
            // 
            // nudQuantite
            // 
            this.nudQuantite.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantite.BorderRadius = 8;
            this.nudQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantite.Location = new System.Drawing.Point(217, 355);
            this.nudQuantite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(165, 40);
            this.nudQuantite.TabIndex = 10;
            this.nudQuantite.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeuil.Location = new System.Drawing.Point(405, 330);
            this.lblSeuil.Name = "lblSeuil";
            this.lblSeuil.Size = new System.Drawing.Size(103, 19);
            this.lblSeuil.TabIndex = 11;
            this.lblSeuil.Text = "Seuil d\'alerte";
            // 
            // nudSeuil
            // 
            this.nudSeuil.BackColor = System.Drawing.Color.Transparent;
            this.nudSeuil.BorderRadius = 8;
            this.nudSeuil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSeuil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudSeuil.Location = new System.Drawing.Point(405, 355);
            this.nudSeuil.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSeuil.Name = "nudSeuil";
            this.nudSeuil.Size = new System.Drawing.Size(165, 40);
            this.nudSeuil.TabIndex = 12;
            this.nudSeuil.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudSeuil.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblDateE
            // 
            this.lblDateE.AutoSize = true;
            this.lblDateE.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateE.Location = new System.Drawing.Point(30, 410);
            this.lblDateE.Name = "lblDateE";
            this.lblDateE.Size = new System.Drawing.Size(108, 19);
            this.lblDateE.TabIndex = 13;
            this.lblDateE.Text = "Date d\'entrée";
            // 
            // dtpDateE
            // 
            this.dtpDateE.BorderRadius = 8;
            this.dtpDateE.Checked = true;
            this.dtpDateE.FillColor = System.Drawing.Color.White;
            this.dtpDateE.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateE.Location = new System.Drawing.Point(30, 435);
            this.dtpDateE.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateE.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateE.Name = "dtpDateE";
            this.dtpDateE.Size = new System.Drawing.Size(255, 40);
            this.dtpDateE.TabIndex = 14;
            this.dtpDateE.Value = new System.DateTime(2025, 11, 8, 0, 0, 0, 0);
            // 
            // lblDateP
            // 
            this.lblDateP.AutoSize = true;
            this.lblDateP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateP.Location = new System.Drawing.Point(315, 410);
            this.lblDateP.Name = "lblDateP";
            this.lblDateP.Size = new System.Drawing.Size(155, 19);
            this.lblDateP.TabIndex = 15;
            this.lblDateP.Text = "Date de péremption";
            // 
            // dtpDateP
            // 
            this.dtpDateP.BorderRadius = 8;
            this.dtpDateP.Checked = true;
            this.dtpDateP.FillColor = System.Drawing.Color.White;
            this.dtpDateP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateP.Location = new System.Drawing.Point(315, 435);
            this.dtpDateP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateP.Name = "dtpDateP";
            this.dtpDateP.Size = new System.Drawing.Size(255, 40);
            this.dtpDateP.TabIndex = 16;
            this.dtpDateP.Value = new System.DateTime(2026, 11, 8, 0, 0, 0, 0);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BorderRadius = 8;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(370, 530);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 45);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "✓ Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAnnuler.BorderRadius = 8;
            this.btnAnnuler.BorderThickness = 2;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.White;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAnnuler.Location = new System.Drawing.Point(150, 530);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(200, 45);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "✕ Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // AjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 730);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Pharmacie - Ajouter Médicament";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private System.Windows.Forms.Label lblReference;
        private Guna.UI2.WinForms.Guna2TextBox txtReference;
        private System.Windows.Forms.Label lblNom;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblPrix;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrix;
        private System.Windows.Forms.Label lblQuantite;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSeuil;
        private System.Windows.Forms.Label lblDateE;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateE;
        private System.Windows.Forms.Label lblDateP;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateP;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
    }
}