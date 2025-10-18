using System;
using System.Windows.Forms;
using Npgsql;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        // Chaîne de connexion PostgreSQL
        private readonly string connString = "Host=localhost;Port=5432;Username=postgres;Password=2012704;Database=chatserver";

        // État de connexion
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            btnLoginLogout.Text = "Connexion"; // texte initial
        }

        // Bouton unique Connexion/Déconnexion
        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                // Tentative de connexion
                try
                {
                    using var conn = new NpgsqlConnection(connString);
                    conn.Open();

                    string sql = "SELECT * FROM users WHERE username = @u AND password = crypt(@p, password)";
                    using var cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("u", txtUser.Text);
                    cmd.Parameters.AddWithValue("p", txtPassword.Text);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string prenom = reader["firstname"] is DBNull
                            ? string.Empty
                            : reader["firstname"].ToString()!;

                        lblStatus.Text = "✅ Connexion réussie, bienvenue " + prenom;
                        isConnected = true;

                        // ✅ Changement du bouton
                        btnLoginLogout.Text = "Déconnexion";
                        btnLoginLogout.BackColor = Color.Red;
                        btnLoginLogout.ForeColor = Color.White;
                    }
                    else
                    {
                        lblStatus.Text = "❌ Nom d’utilisateur ou mot de passe incorrect.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Erreur : " + ex.Message;
                }
            }
            else
            {
                // Déconnexion
                isConnected = false;
                lblStatus.Text = "🔴 Déconnecté.";

                // ✅ Retour au style initial
                btnLoginLogout.Text = "Connexion";
                btnLoginLogout.BackColor = Color.Green;
                btnLoginLogout.ForeColor = Color.White;

                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }
    }
}