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
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.labelMdpConfirm = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtConfirmerMotDePasse = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(95, 20);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(232, 37);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Inscription 👤";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNom.Location = new System.Drawing.Point(40, 90);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(133, 23);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom utilisateur :";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMdp.Location = new System.Drawing.Point(40, 150);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(111, 23);
            this.labelMdp.TabIndex = 2;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // labelMdpConfirm
            // 
            this.labelMdpConfirm.AutoSize = true;
            this.labelMdpConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMdpConfirm.Location = new System.Drawing.Point(40, 210);
            this.labelMdpConfirm.Name = "labelMdpConfirm";
            this.labelMdpConfirm.Size = new System.Drawing.Size(172, 23);
            this.labelMdpConfirm.TabIndex = 3;
            this.labelMdpConfirm.Text = "Confirmer mot de passe :";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNomUtilisateur.Location = new System.Drawing.Point(230, 85);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(200, 30);
            this.txtNomUtilisateur.TabIndex = 4;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotDePasse.Location = new System.Drawing.Point(230, 145);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(200, 30);
            this.txtMotDePasse.TabIndex = 5;
            // 
            // txtConfirmerMotDePasse
            // 
            this.txtConfirmerMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmerMotDePasse.Location = new System.Drawing.Point(230, 205);
            this.txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            this.txtConfirmerMotDePasse.PasswordChar = '*';
            this.txtConfirmerMotDePasse.Size = new System.Drawing.Size(200, 30);
            this.txtConfirmerMotDePasse.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(90, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 40);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "S'inscrire";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Gray;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(250, 270);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(130, 40);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            //this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmerMotDePasse);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.labelMdpConfirm);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelTitre);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription - Gestion Pharmacie";
            this.ResumeLayout(false);
            this.PerformLayout();

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
