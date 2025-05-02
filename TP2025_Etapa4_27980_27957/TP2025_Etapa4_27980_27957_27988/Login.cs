using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace TP2025_Etapa4_27980_27957_27988
{
    public partial class Login : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        #region Login Botao

        private void butLogin_Click(object sender, EventArgs e)
        {
            string utilizador = txtUtilizador.Text.Trim();
            string password = txtPassword.Text.Trim();

            #region Verificações de Campos

            if (password == "Password" || password == "")
            {
                MessageBox.Show("Insira a sua password.");
                return;
            }

            if (utilizador == "Utilizador" || utilizador == "")
            {
                MessageBox.Show("Insira o seu nome de utilizador.");
                return;
            }

            #endregion

            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT * FROM Login WHERE nome=@nome AND password=@password", conn);
                cmd.Parameters.AddWithValue("@nome", utilizador);
                cmd.Parameters.AddWithValue("@password", password);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Hide();
                    Gerente g = new Gerente();
                    g.Show();
                }
                else
                {
                    MessageBox.Show("Falha no Login, Tente outra vez!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        #endregion

        #region Aparencia

        #region Password TextBox

        // Remove o texto password e coloca a senha oculta
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Silver;

            }


        }

        #endregion

        #region Utilizador TextBox

        // Remove o texto utilizador
        private void txtUtilizador_Enter(object sender, EventArgs e)
        {
            if (txtUtilizador.Text == "Utilizador")
            {
                txtUtilizador.Text = "";
                txtUtilizador.ForeColor = Color.Black;
            }


        }
        private void txtUtilizador_Leave(object sender, EventArgs e)
        {
            if (txtUtilizador.Text == "")
            {
                txtUtilizador.Text = "Utilizador";
                txtUtilizador.ForeColor = Color.Silver;
            }


        }

        #endregion

        #region AbrirRegistarForms

        private void lblRegistar_Click(object sender, EventArgs e)
        {
            Hide();
            Registar registar = new Registar();
            registar.Show();
        }

        private void pcbRegistar_Click(object sender, EventArgs e)
        {
            Hide();
            Registar registar = new Registar();
            registar.Show();
        }

        #endregion

        #region FecharAplicaçao
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #endregion

        private void lblnomeconcessionaria_Click(object sender, EventArgs e)
        {

        }
    }
}
