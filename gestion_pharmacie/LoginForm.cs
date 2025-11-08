using gestion_pharmacie;
using System;
using System.Windows.Forms;

namespace gestion_pharmacie
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nom = txtNomUtilisateur.Text;
            string mdp = txtMotDePasse.Text;

            if (Utilisateur.Login(nom, mdp))
            {
                MessageBox.Show("Connexion réussie !");

                // Crée et ouvre le form d'accueil
                AccueilForm accueil = new AccueilForm();
                accueil.Show();
                // 👉 ouvrir le menu principal ou autre form
                this.Hide();

            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }
    }
}
