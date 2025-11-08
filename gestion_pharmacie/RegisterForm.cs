using gestion_pharmacie;
using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Utilisateur u = new Utilisateur()
            {
                NomUtilisateur = txtNomUtilisateur.Text,
                MotDePasse = txtMotDePasse.Text
            };

            if (u.Register())
            {
                MessageBox.Show("Inscription réussie !");
                // Ouvre le Dashboard
                AccueilForm accueil = new AccueilForm();
                accueil.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de l’inscription !");
            }
        }

    }
}
