using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    partial class SupprimerMedicament
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            picIcone = new Guna.UI2.WinForms.Guna2PictureBox();
            controlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            lblTitre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            lblWarning = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtId = new Guna.UI2.WinForms.Guna2TextBox();
            panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            btnAnnuler = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelContainer.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
            panelContent.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 20;
            guna2ShadowForm1.ShadowColor = Color.FromArgb(239, 71, 111);
            guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = panelContainer;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.BorderRadius = 20;
            panelContainer.Controls.Add(panelButtons);
            panelContainer.Controls.Add(panelContent);
            panelContainer.Controls.Add(panelHeader);
            panelContainer.FillColor = Color.White;
            panelContainer.Location = new Point(20, 20);
            panelContainer.Name = "panelContainer";
            panelContainer.ShadowDecoration.BorderRadius = 20;
            panelContainer.ShadowDecoration.Depth = 15;
            panelContainer.ShadowDecoration.Enabled = true;
            panelContainer.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelContainer.Size = new Size(560, 450);
            panelContainer.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(picIcone);
            panelHeader.Controls.Add(controlBoxClose);
            panelHeader.Controls.Add(lblTitre);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.FromArgb(239, 71, 111);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(560, 120);
            panelHeader.TabIndex = 0;
            // 
            // picIcone
            // 
            picIcone.BackColor = Color.Transparent;
            picIcone.FillColor = Color.Transparent;
            picIcone.ImageRotate = 0F;
            picIcone.Location = new Point(30, 32);
            picIcone.Name = "picIcone";
            picIcone.Size = new Size(52, 52);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 3;
            picIcone.TabStop = false;
            // 
            // controlBoxClose
            // 
            controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxClose.BorderRadius = 8;
            controlBoxClose.FillColor = Color.Transparent;
            controlBoxClose.HoverState.FillColor = Color.FromArgb(220, 53, 89);
            controlBoxClose.IconColor = Color.White;
            controlBoxClose.Location = new Point(420, 20);
            controlBoxClose.Name = "controlBoxClose";
            controlBoxClose.Size = new Size(35, 35);
            controlBoxClose.TabIndex = 1;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = false;
            lblTitre.BackColor = Color.Transparent;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(92, 32);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(380, 36);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Supprimer un médicament";
            lblTitre.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = false;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 230);
            lblSubtitle.Location = new Point(92, 68);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 24);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Cette action est irréversible";
            lblSubtitle.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(lblWarning);
            panelContent.Controls.Add(txtId);
            panelContent.Controls.Add(lblId);
            panelContent.Dock = DockStyle.Fill;
            panelContent.FillColor = Color.White;
            panelContent.Location = new Point(0, 120);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(35, 30, 35, 25);
            panelContent.Size = new Size(560, 330);
            panelContent.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = false;
            lblWarning.BackColor = Color.FromArgb(255, 245, 248);
            lblWarning.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.FromArgb(239, 71, 111);
            lblWarning.Location = new Point(35, 30);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(18, 15, 18, 15);
            lblWarning.Size = new Size(490, 75);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "⚠️ Attention : La suppression d'un médicament est définitive.\r\nAssurez-vous que l'identifiant est correct avant de continuer.";
            lblWarning.TextAlignment = ContentAlignment.TopLeft;
            // 
            // lblId
            // 
            lblId.AutoSize = false;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.FromArgb(51, 65, 85);
            lblId.Location = new Point(35, 130);
            lblId.Name = "lblId";
            lblId.Size = new Size(280, 24);
            lblId.TabIndex = 1;
            lblId.Text = "Identifiant du médicament *";
            lblId.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.Animated = true;
            txtId.BorderColor = Color.FromArgb(226, 232, 240);
            txtId.BorderRadius = 12;
            txtId.BorderThickness = 2;
            txtId.Cursor = Cursors.IBeam;
            txtId.DefaultText = "";
            txtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtId.DisabledState.FillColor = Color.FromArgb(240, 240, 240);
            txtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtId.FocusedState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(30, 41, 59);
            txtId.HoverState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.IconLeft = null;
            txtId.IconLeftOffset = new Point(12, 0);
            txtId.IconLeftSize = new Size(20, 20);
            txtId.Location = new Point(35, 160);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.MaxLength = 10;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            txtId.PlaceholderText = "Saisissez l'ID (ex: 102)";
            txtId.SelectedText = "";
            txtId.Size = new Size(490, 54);
            txtId.TabIndex = 2;
            txtId.TextOffset = new Point(8, 0);
            txtId.KeyPress += txtId_KeyPress;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(248, 250, 252);
            panelButtons.Controls.Add(btnAnnuler);
            panelButtons.Controls.Add(btnSupprimer);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.FillColor = Color.FromArgb(248, 250, 252);
            panelButtons.Location = new Point(0, 370);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(35, 18, 35, 22);
            panelButtons.Size = new Size(560, 80);
            panelButtons.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Animated = true;
            btnSupprimer.BorderRadius = 12;
            btnSupprimer.DisabledState.BorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.FillColor = Color.FromArgb(200, 200, 200);
            btnSupprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSupprimer.FillColor = Color.FromArgb(239, 71, 111);
            btnSupprimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.HoverState.FillColor = Color.FromArgb(220, 53, 89);
            btnSupprimer.Location = new Point(280, 18);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.BorderRadius = 12;
            btnSupprimer.ShadowDecoration.Color = Color.FromArgb(239, 71, 111);
            btnSupprimer.ShadowDecoration.Depth = 8;
            btnSupprimer.ShadowDecoration.Enabled = true;
            btnSupprimer.Size = new Size(245, 52);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "🗑️  Supprimer";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Animated = true;
            btnAnnuler.BorderColor = Color.FromArgb(226, 232, 240);
            btnAnnuler.BorderRadius = 12;
            btnAnnuler.BorderThickness = 2;
            btnAnnuler.DialogResult = DialogResult.Cancel;
            btnAnnuler.DisabledState.BorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.FillColor = Color.FromArgb(220, 220, 220);
            btnAnnuler.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnnuler.FillColor = Color.White;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnuler.ForeColor = Color.FromArgb(71, 85, 105);
            btnAnnuler.HoverState.BorderColor = Color.FromArgb(203, 213, 225);
            btnAnnuler.HoverState.FillColor = Color.FromArgb(248, 250, 252);
            btnAnnuler.Location = new Point(35, 18);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(235, 52);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // SupprimerMedicament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = btnSupprimer;
            BackColor = Color.FromArgb(15, 23, 42);
            CancelButton = btnAnnuler;
            ClientSize = new Size(600, 490);
            Controls.Add(panelContainer);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupprimerMedicament";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Supprimer un médicament";
            panelContainer.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
            panelContent.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picIcone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarning;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblId;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2Panel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnAnnuler;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxClose;
    }
}