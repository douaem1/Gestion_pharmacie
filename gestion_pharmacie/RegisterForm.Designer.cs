namespace gestion_pharmacie
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            labelTitre = new Label();
            labelNom = new Label();
            labelMdp = new Label();
            labelMdpConfirm = new Label();
            txtNomUtilisateur = new TextBox();
            txtMotDePasse = new TextBox();
            txtConfirmerMotDePasse = new TextBox();
            btnRegister = new Button();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitre.Location = new Point(83, 15);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(161, 30);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Inscription 👤";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 10F);
            labelNom.Location = new Point(35, 68);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(110, 19);
            labelNom.TabIndex = 1;
            labelNom.Text = "Nom utilisateur :";
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.Font = new Font("Segoe UI", 10F);
            labelMdp.Location = new Point(35, 112);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(99, 19);
            labelMdp.TabIndex = 2;
            labelMdp.Text = "Mot de passe :";
            // 
            // labelMdpConfirm
            // 
            labelMdpConfirm.AutoSize = true;
            labelMdpConfirm.Font = new Font("Segoe UI", 10F);
            labelMdpConfirm.Location = new Point(35, 158);
            labelMdpConfirm.Name = "labelMdpConfirm";
            labelMdpConfirm.Size = new Size(163, 19);
            labelMdpConfirm.TabIndex = 3;
            labelMdpConfirm.Text = "Confirmer mot de passe :";
            // 
            // txtNomUtilisateur
            // 
            txtNomUtilisateur.Font = new Font("Segoe UI", 10F);
            txtNomUtilisateur.Location = new Point(201, 64);
            txtNomUtilisateur.Margin = new Padding(3, 2, 3, 2);
            txtNomUtilisateur.Name = "txtNomUtilisateur";
            txtNomUtilisateur.Size = new Size(176, 25);
            txtNomUtilisateur.TabIndex = 4;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Font = new Font("Segoe UI", 10F);
            txtMotDePasse.Location = new Point(201, 109);
            txtMotDePasse.Margin = new Padding(3, 2, 3, 2);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.Size = new Size(176, 25);
            txtMotDePasse.TabIndex = 5;
            // 
            // txtConfirmerMotDePasse
            // 
            txtConfirmerMotDePasse.Font = new Font("Segoe UI", 10F);
            txtConfirmerMotDePasse.Location = new Point(201, 154);
            txtConfirmerMotDePasse.Margin = new Padding(3, 2, 3, 2);
            txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            txtConfirmerMotDePasse.PasswordChar = '*';
            txtConfirmerMotDePasse.Size = new Size(176, 25);
            txtConfirmerMotDePasse.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(79, 202);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 30);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "S'inscrire";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.Gray;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(219, 202);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(114, 30);
            btnRetour.TabIndex = 8;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 262);
            Controls.Add(btnRetour);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmerMotDePasse);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtNomUtilisateur);
            Controls.Add(labelMdpConfirm);
            Controls.Add(labelMdp);
            Controls.Add(labelNom);
            Controls.Add(labelTitre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription - Gestion Pharmacie";
            //Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Label labelMdpConfirm;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtConfirmerMotDePasse;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRetour;
    }
}
