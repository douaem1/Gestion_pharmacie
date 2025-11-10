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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna2BorderlessForm(components);
            guna2ShadowForm1 = new Guna2ShadowForm(components);
            panelContainer = new Guna2Panel();
            panelButtons = new Guna2Panel();
            btnAnnuler = new Guna2Button();
            btnSupprimer = new Guna2Button();
            panelContent = new Guna2Panel();
            lblWarning = new Guna2HtmlLabel();
            txtId = new Guna2TextBox();
            lblId = new Guna2HtmlLabel();
            panelHeader = new Guna2Panel();
            lblSubtitle = new Guna2HtmlLabel();
            picIcone = new Guna2PictureBox();
            controlBoxClose = new Guna2ControlBox();
            lblTitre = new Guna2HtmlLabel();
            guna2Elipse1 = new Guna2Elipse(components);
            panelContainer.SuspendLayout();
            panelButtons.SuspendLayout();
            panelContent.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcone).BeginInit();
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
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.BorderRadius = 20;
            panelContainer.Controls.Add(panelButtons);
            panelContainer.Controls.Add(panelContent);
            panelContainer.Controls.Add(panelHeader);
            panelContainer.CustomizableEdges = customizableEdges17;
            panelContainer.FillColor = Color.White;
            panelContainer.Location = new Point(23, 27);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.ShadowDecoration.BorderRadius = 20;
            panelContainer.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelContainer.ShadowDecoration.Depth = 15;
            panelContainer.ShadowDecoration.Enabled = true;
            panelContainer.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelContainer.Size = new Size(640, 600);
            panelContainer.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(248, 250, 252);
            panelButtons.Controls.Add(btnAnnuler);
            panelButtons.Controls.Add(btnSupprimer);
            panelButtons.CustomizableEdges = customizableEdges5;
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.FillColor = Color.FromArgb(248, 250, 252);
            panelButtons.Location = new Point(0, 493);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(40, 24, 40, 29);
            panelButtons.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelButtons.Size = new Size(640, 107);
            panelButtons.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Animated = true;
            btnAnnuler.BorderColor = Color.FromArgb(226, 232, 240);
            btnAnnuler.BorderRadius = 12;
            btnAnnuler.BorderThickness = 2;
            btnAnnuler.CustomizableEdges = customizableEdges3;
            btnAnnuler.DialogResult = DialogResult.Cancel;
            btnAnnuler.DisabledState.BorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnnuler.DisabledState.FillColor = Color.FromArgb(220, 220, 220);
            btnAnnuler.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnnuler.FillColor = Color.White;
            btnAnnuler.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.FromArgb(71, 85, 105);
            btnAnnuler.HoverState.BorderColor = Color.FromArgb(203, 213, 225);
            btnAnnuler.HoverState.FillColor = Color.FromArgb(248, 250, 252);
            btnAnnuler.Location = new Point(40, 24);
            btnAnnuler.Margin = new Padding(3, 4, 3, 4);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAnnuler.Size = new Size(269, 69);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Animated = true;
            btnSupprimer.BackColor = Color.Transparent;
            btnSupprimer.BorderRadius = 12;
            btnSupprimer.CustomizableEdges = customizableEdges1;
            btnSupprimer.DisabledState.BorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSupprimer.DisabledState.FillColor = Color.FromArgb(200, 200, 200);
            btnSupprimer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSupprimer.FillColor = Color.FromArgb(239, 71, 111);
            btnSupprimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.HoverState.FillColor = Color.FromArgb(220, 53, 89);
            btnSupprimer.Location = new Point(320, 24);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.ShadowDecoration.BorderRadius = 12;
            btnSupprimer.ShadowDecoration.Color = Color.FromArgb(239, 71, 111);
            btnSupprimer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSupprimer.ShadowDecoration.Depth = 8;
            btnSupprimer.ShadowDecoration.Enabled = true;
            btnSupprimer.Size = new Size(280, 69);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "🗑️  Supprimer";
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(lblWarning);
            panelContent.Controls.Add(txtId);
            panelContent.Controls.Add(lblId);
            panelContent.CustomizableEdges = customizableEdges9;
            panelContent.Dock = DockStyle.Fill;
            panelContent.FillColor = Color.White;
            panelContent.Location = new Point(0, 160);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40, 40, 40, 33);
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelContent.Size = new Size(640, 440);
            panelContent.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = false;
            lblWarning.BackColor = Color.FromArgb(255, 245, 248);
            lblWarning.Font = new Font("Segoe UI", 10F);
            lblWarning.ForeColor = Color.FromArgb(239, 71, 111);
            lblWarning.Location = new Point(40, 40);
            lblWarning.Margin = new Padding(3, 4, 3, 4);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(21, 20, 21, 20);
            lblWarning.Size = new Size(560, 100);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "⚠️ Attention : La suppression d'un médicament est définitive.\r\nAssurez-vous que l'identifiant est correct avant de continuer.";
            // 
            // txtId
            // 
            txtId.Animated = true;
            txtId.BorderColor = Color.FromArgb(226, 232, 240);
            txtId.BorderRadius = 12;
            txtId.BorderThickness = 2;
            txtId.Cursor = Cursors.IBeam;
            txtId.CustomizableEdges = customizableEdges7;
            txtId.DefaultText = "";
            txtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtId.DisabledState.FillColor = Color.FromArgb(240, 240, 240);
            txtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtId.FocusedState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(30, 41, 59);
            txtId.HoverState.BorderColor = Color.FromArgb(239, 71, 111);
            txtId.IconLeftOffset = new Point(12, 0);
            txtId.Location = new Point(40, 213);
            txtId.Margin = new Padding(5, 7, 5, 7);
            txtId.MaxLength = 10;
            txtId.Name = "txtId";
            txtId.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            txtId.PlaceholderText = "Saisissez l'ID (ex: 102)";
            txtId.SelectedText = "";
            txtId.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtId.Size = new Size(560, 72);
            txtId.TabIndex = 2;
            txtId.TextOffset = new Point(8, 0);
            txtId.KeyPress += txtId_KeyPress;
            // 
            // lblId
            // 
            lblId.AutoSize = false;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(51, 65, 85);
            lblId.Location = new Point(40, 173);
            lblId.Margin = new Padding(3, 4, 3, 4);
            lblId.Name = "lblId";
            lblId.Size = new Size(320, 32);
            lblId.TabIndex = 1;
            lblId.Text = "Identifiant du médicament *";
            lblId.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(picIcone);
            panelHeader.Controls.Add(controlBoxClose);
            panelHeader.Controls.Add(lblTitre);
            panelHeader.CustomizableEdges = customizableEdges15;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.FromArgb(239, 71, 111);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelHeader.Size = new Size(640, 160);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = false;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSubtitle.ForeColor = Color.FromArgb(255, 220, 230);
            lblSubtitle.Location = new Point(86, 124);
            lblSubtitle.Margin = new Padding(3, 4, 3, 4);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(434, 32);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Cette action est irréversible";
            lblSubtitle.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // picIcone
            // 
            picIcone.BackColor = Color.Transparent;
            picIcone.CustomizableEdges = customizableEdges11;
            picIcone.FillColor = Color.Transparent;
            picIcone.ImageRotate = 0F;
            picIcone.Location = new Point(34, 43);
            picIcone.Margin = new Padding(3, 4, 3, 4);
            picIcone.Name = "picIcone";
            picIcone.ShadowDecoration.CustomizableEdges = customizableEdges12;
            picIcone.Size = new Size(59, 69);
            picIcone.SizeMode = PictureBoxSizeMode.Zoom;
            picIcone.TabIndex = 3;
            picIcone.TabStop = false;
            // 
            // controlBoxClose
            // 
            controlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxClose.BorderRadius = 8;
            controlBoxClose.CustomizableEdges = customizableEdges13;
            controlBoxClose.FillColor = Color.Transparent;
            controlBoxClose.HoverState.FillColor = Color.FromArgb(220, 53, 89);
            controlBoxClose.IconColor = Color.White;
            controlBoxClose.Location = new Point(480, 27);
            controlBoxClose.Margin = new Padding(3, 4, 3, 4);
            controlBoxClose.Name = "controlBoxClose";
            controlBoxClose.ShadowDecoration.CustomizableEdges = customizableEdges14;
            controlBoxClose.Size = new Size(40, 47);
            controlBoxClose.TabIndex = 1;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = false;
            lblTitre.BackColor = Color.Transparent;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(66, 27);
            lblTitre.Margin = new Padding(3, 4, 3, 4);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(434, 105);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Supprimer un médicament";
            lblTitre.TextAlignment = ContentAlignment.MiddleLeft;
            lblTitre.Click += lblTitre_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = panelContainer;
            // 
            // SupprimerMedicament
            // 
            AcceptButton = btnSupprimer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            CancelButton = btnAnnuler;
            ClientSize = new Size(686, 653);
            Controls.Add(panelContainer);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupprimerMedicament";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Supprimer un médicament";
            panelContainer.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcone).EndInit();
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