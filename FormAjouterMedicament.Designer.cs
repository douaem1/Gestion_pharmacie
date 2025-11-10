namespace gestion_pharmacie
{
    partial class FormAjouterMedicament
    {
        /// <summary>
        /// Variable d'instance requise par le concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources gérées doivent être libérées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur de formulaires Windows

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur.
        /// Ne modifiez pas le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.nudSeuil = new System.Windows.Forms.NumericUpDown();
            this.dtpDateE = new System.Windows.Forms.DateTimePicker();
            this.dtpDateP = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // nudPrix
            // 
            this.nudPrix.Location = new System.Drawing.Point(12, 64);
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(200, 20);
            this.nudPrix.TabIndex = 2;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(12, 90);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(200, 20);
            this.nudQuantite.TabIndex = 3;
            // 
            // nudSeuil
            // 
            this.nudSeuil.Location = new System.Drawing.Point(12, 116);
            this.nudSeuil.Name = "nudSeuil";
            this.nudSeuil.Size = new System.Drawing.Size(200, 20);
            this.nudSeuil.TabIndex = 4;
            // 
            // dtpDateE
            // 
            this.dtpDateE.Location = new System.Drawing.Point(12, 142);
            this.dtpDateE.Name = "dtpDateE";
            this.dtpDateE.Size = new System.Drawing.Size(200, 20);
            this.dtpDateE.TabIndex = 5;
            // 
            // dtpDateP
            // 
            this.dtpDateP.Location = new System.Drawing.Point(12, 168);
            this.dtpDateP.Name = "dtpDateP";
            this.dtpDateP.Size = new System.Drawing.Size(200, 20);
            this.dtpDateP.TabIndex = 6;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 194);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 231);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dtpDateP);
            this.Controls.Add(this.dtpDateE);
            this.Controls.Add(this.nudSeuil);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNom);
            this.Name = "FormAjouterMedicament";
            this.Text = "Ajouter un médicament";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.NumericUpDown nudSeuil;
        private System.Windows.Forms.DateTimePicker dtpDateE;
        private System.Windows.Forms.DateTimePicker dtpDateP;
        private System.Windows.Forms.Button btnAjouter;
    }
}