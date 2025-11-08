namespace gestion_pharmacie
{
    partial class AjouterMedicamentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrix;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantite;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSeuil;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateE;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateP;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.Label lblDateE;
        private System.Windows.Forms.Label lblDateP;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudPrix = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudQuantite = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudSeuil = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtpDateE = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDateP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.lblDateE = new System.Windows.Forms.Label();
            this.lblDateP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(30, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(150, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(250, 25);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Size = new System.Drawing.Size(250, 80);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(30, 160);
            this.lblPrix.Text = "Prix :";
            // 
            // nudPrix
            // 
            this.nudPrix.Location = new System.Drawing.Point(150, 157);
            this.nudPrix.DecimalPlaces = 2;
            this.nudPrix.Maximum = 10000;
            this.nudPrix.Minimum = 0;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(30, 200);
            this.lblQuantite.Text = "Quantité :";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(150, 197);
            this.nudQuantite.Maximum = 10000;
            this.nudQuantite.Minimum = 0;
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.Location = new System.Drawing.Point(30, 240);
            this.lblSeuil.Text = "Seuil alerte :";
            // 
            // nudSeuil
            // 
            this.nudSeuil.Location = new System.Drawing.Point(150, 237);
            this.nudSeuil.Maximum = 1000;
            this.nudSeuil.Minimum = 0;
            // 
            // lblDateE
            // 
            this.lblDateE.AutoSize = true;
            this.lblDateE.Location = new System.Drawing.Point(30, 280);
            this.lblDateE.Text = "Date entrée :";
            // 
            // dtpDateE
            // 
            this.dtpDateE.Location = new System.Drawing.Point(150, 277);
            this.dtpDateE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblDateP
            // 
            this.lblDateP.AutoSize = true;
            this.lblDateP.Location = new System.Drawing.Point(30, 320);
            this.lblDateP.Text = "Date péremption :";
            // 
            // dtpDateP
            // 
            this.dtpDateP.Location = new System.Drawing.Point(150, 317);
            this.dtpDateP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(150, 370);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 35);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // AjouterMedicamentForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.lblSeuil);
            this.Controls.Add(this.nudSeuil);
            this.Controls.Add(this.lblDateE);
            this.Controls.Add(this.dtpDateE);
            this.Controls.Add(this.lblDateP);
            this.Controls.Add(this.dtpDateP);
            this.Controls.Add(this.btnAjouter);
            this.Name = "AjouterMedicamentForm";
            this.Text = "Ajouter un médicament";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeuil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
