namespace gestion_pharmacie
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Nettoyage des ressources.
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
            label1 = new Label();
            label2 = new Label();
            txtNomUtilisateur = new TextBox();
            txtMotDePasse = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            labelTitre = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(35, 68);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 1;
            label1.Text = "Nom utilisateur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(35, 112);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe :";
            // 
            // txtNomUtilisateur
            // 
            txtNomUtilisateur.Font = new Font("Segoe UI", 10F);
            txtNomUtilisateur.Location = new Point(166, 64);
            txtNomUtilisateur.Margin = new Padding(3, 2, 3, 2);
            txtNomUtilisateur.Name = "txtNomUtilisateur";
            txtNomUtilisateur.Size = new Size(176, 25);
            txtNomUtilisateur.TabIndex = 3;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Font = new Font("Segoe UI", 10F);
            txtMotDePasse.Location = new Point(166, 109);
            txtMotDePasse.Margin = new Padding(3, 2, 3, 2);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.Size = new Size(176, 25);
            txtMotDePasse.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(61, 158);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(210, 158);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "S'inscrire";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitre.Location = new Point(96, 15);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(159, 30);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Connexion 🔐";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 225);
            Controls.Add(labelTitre);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtNomUtilisateur);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion - Gestion Pharmacie";
            //Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelTitre;
    }
}
