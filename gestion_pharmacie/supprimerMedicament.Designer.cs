using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    partial class SupprimerMedicament
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelMain = new Guna2Panel();
            btnAnnuler = new Guna2Button();
            btnSupprimer = new Guna2Button();
            txtId = new Guna2TextBox();
            lblId = new Label();
            panelWarning = new Guna2Panel();
            lblWarning = new Label();
            separator1 = new Guna2Separator();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelWarning.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(239, 71, 111);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.Size = new Size(700, 98);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(35, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(318, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Supprimer un Médicament";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(35, 63);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(238, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Cette action est définitive et irréversible";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnAnnuler);
            panelMain.Controls.Add(btnSupprimer);
            panelMain.Controls.Add(txtId);
            panelMain.Controls.Add(lblId);
            panelMain.Controls.Add(panelWarning);
            panelMain.Controls.Add(separator1);
            panelMain.CustomizableEdges = customizableEdges9;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 98);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(35, 23, 35, 35);
            panelMain.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelMain.Size = new Size(700, 402);
            panelMain.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BorderColor = Color.FromArgb(239, 71, 111);
            btnAnnuler.BorderRadius = 8;
            btnAnnuler.BorderThickness = 2;
            btnAnnuler.CustomizableEdges = customizableEdges3;
            btnAnnuler.DisabledState.BorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAnnuler.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnnuler.FillColor = Color.White;
            btnAnnuler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.FromArgb(239, 71, 111);
            btnAnnuler.Location = new Point(359, 328);
            btnAnnuler.Margin = new Padding(4, 3, 4, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAnnuler.Size = new Size(139, 35);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "✕ Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BorderRadius = 8;
            btnSupprimer.CustomizableEdges = customizableEdges5;
            btnSupprimer.DisabledState.BorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSupprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSupprimer.FillColor = Color.FromArgb(239, 71, 111);
            btnSupprimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(515, 328);
            btnSupprimer.Margin = new Padding(4, 3, 4, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSupprimer.Size = new Size(149, 35);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "🗑️ Supprimer";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // txtId
            // 
            txtId.BorderRadius = 8;
            txtId.Cursor = Cursors.IBeam;
            txtId.CustomizableEdges = customizableEdges7;
            txtId.DefaultText = "";
            txtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtId.FocusedState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.HoverState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.Location = new Point(35, 239);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.MaxLength = 10;
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Ex: 102";
            txtId.SelectedText = "";
            txtId.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtId.Size = new Size(630, 46);
            txtId.TabIndex = 4;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(64, 64, 64);
            lblId.Location = new Point(35, 210);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(190, 19);
            lblId.TabIndex = 3;
            lblId.Text = "Identifiant du médicament *";
            // 
            // panelWarning
            // 
            panelWarning.BackColor = Color.FromArgb(255, 245, 248);
            panelWarning.BorderColor = Color.FromArgb(239, 71, 111);
            panelWarning.BorderRadius = 8;
            panelWarning.BorderThickness = 1;
            panelWarning.Controls.Add(lblWarning);
            //panelWarning.CustomizableEdges = customizableEdges11;
            panelWarning.Location = new Point(35, 58);
            panelWarning.Margin = new Padding(4, 3, 4, 3);
            panelWarning.Name = "panelWarning";
            panelWarning.Padding = new Padding(15);
            //panelWarning.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelWarning.Size = new Size(630, 130);
            panelWarning.TabIndex = 2;
            // 
            // lblWarning
            // 
            lblWarning.Dock = DockStyle.Fill;
            lblWarning.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.FromArgb(239, 71, 111);
            lblWarning.Location = new Point(15, 15);
            lblWarning.Margin = new Padding(4, 0, 4, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(600, 100);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "⚠️ ATTENTION : La suppression d\'un médicament est définitive.\r\n\r\nTous les données" +
    " associées seront perdues.\r\nAssurez-vous que l\'identifiant est correct avant de " +
    "continuer.";
            lblWarning.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // separator1
            // 
            separator1.Location = new Point(35, 23);
            separator1.Margin = new Padding(4, 3, 4, 3);
            separator1.Name = "separator1";
            separator1.Size = new Size(630, 12);
            separator1.TabIndex = 1;
            // 
            // SupprimerMedicament
            // 
            AcceptButton = btnSupprimer;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnAnnuler;
            ClientSize = new Size(700, 500);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupprimerMedicament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Pharmacie - Supprimer Médicament";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelWarning.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna2Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Guna2Panel panelMain;
        private Guna2Separator separator1;
        private Guna2Panel panelWarning;
        private Label lblWarning;
        private Label lblId;
        private Guna2TextBox txtId;
        private Guna2Button btnSupprimer;
        private Guna2Button btnAnnuler;
    }
}