using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2025_Etapa4_27980_27957_27988
{

    public partial class Registar : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Registar()
        {
            InitializeComponent();
        }

        #region Aparencia

        #region NovaPassword TextBox

        // Remove o texto nova password e colocar a senha oculta
        private void txtNovaPassword_Enter(object sender, EventArgs e)
        {
            if (txtNovaPassword.Text == "Nova Password")
            {
                txtNovaPassword.Text = "";
                txtNovaPassword.UseSystemPasswordChar = true;
                txtNovaPassword.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtNovaPassword_Leave(object sender, EventArgs e)
        {
            if (txtNovaPassword.Text == "")
            {
                txtNovaPassword.Text = "Nova Password";
                txtNovaPassword.UseSystemPasswordChar = false;
                txtNovaPassword.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region ConfirmarPassword TextBox

        // Remove o texto Confirmar password e colocar a senha oculta
        private void txtConfirmarPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.Text == "Confirmar Password")
            {
                txtConfirmarPassword.Text = "";
                txtConfirmarPassword.UseSystemPasswordChar = true;
                txtConfirmarPassword.ForeColor = Color.Black;
            }
        }

        // Colocar o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtConfirmarPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.Text == "")
            {
                txtConfirmarPassword.Text = "Confirmar Password";
                txtConfirmarPassword.UseSystemPasswordChar = false;
                txtConfirmarPassword.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region NovoUtilizador TextBox

        // Remove o texto Novo utilizador e coloca a senha oculta
        private void txtNovoUtilizador_Enter(object sender, EventArgs e)
        {
            if (txtNovoUtilizador.Text == "Novo Utilizador")
            {
                txtNovoUtilizador.Text = "";
                txtNovoUtilizador.ForeColor = Color.Black;
            }
        }

        // Colocar o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtNovoUtilizador_Leave(object sender, EventArgs e)
        {
            if (txtNovoUtilizador.Text == "")
            {
                txtNovoUtilizador.Text = "Novo Utilizador";
                txtNovoUtilizador.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region IdFuncionario TextBox

        // Remove o texto Novo utilizador e coloca a senha oculta
        private void txtIdFuncionario_Enter(object sender, EventArgs e)
        {
            if (txtIdFuncionario.Text == "Seu ID de Funcionário")
            {
                txtIdFuncionario.Text = "";
                txtIdFuncionario.ForeColor = Color.Black;
            }
        }

        // Colocar o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtIdFuncionario_Leave(object sender, EventArgs e)
        {
            if (txtIdFuncionario.Text == "")
            {
                txtIdFuncionario.Text = "Seu ID de Funcionário";
                txtIdFuncionario.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region MostrarPassword Botoes

        private void pcbOcultarPass_MouseDown(object sender, EventArgs e)
        {
            txtNovaPassword.UseSystemPasswordChar = false;
        }
        private void pcbOcultarPass_MouseUp(object sender, EventArgs e)
        {
            txtNovaPassword.UseSystemPasswordChar = true;
        }

        private void pcbOcultarPass2_MouseDown(object sender, EventArgs e)
        {
            txtConfirmarPassword.UseSystemPasswordChar = false;
        }
        private void pcbOcultarPass2_MouseUp(object sender, EventArgs e)
        {
            txtConfirmarPassword.UseSystemPasswordChar = true;
        }

        #endregion

        #region FecharForms
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
        #endregion

        #endregion

        #region Registar Botao

        private void butregistar_Click(object sender, EventArgs e)
        {
            string nomeUtilizador = txtNovoUtilizador.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();
            string textoIdFuncionario = txtIdFuncionario.Text.Trim();
            string password = txtNovaPassword.Text.Trim();

            int id;

            #region Verificações de Campos

            if (Int32.TryParse(textoIdFuncionario, out id ) == false )
            {
                MessageBox.Show("Insira um ID de Funcionário válido.");
                return;
            }

            if (nomeUtilizador == "" || nomeUtilizador == "Novo Utilizador")
            {
                MessageBox.Show("Preencha o seu nome de utilizador.");
                return;
            }

            if (confirmarPassword == "" || password == "")
            {
                MessageBox.Show("Preencha os dois campos com sua password.");
                return;
            }

            if (confirmarPassword != password)
            {
                MessageBox.Show("As passwords não correspondem.");
                return;
            }

            if (password == "Password" || nomeUtilizador == "Utilizador")
            {
                MessageBox.Show("Password ou Nome Inválido");
                return;
            }
            if (password.Length < 5)
            {
                MessageBox.Show("A password não cumpre os requisitos.");
                return;
            }

            #endregion

            string sql = "SELECT * FROM Funcionario WHERE IdFuncionario = '" + id + "'";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    reader.Close();

                    cmd = new SqlCommand("SELECT * FROM Login WHERE idutilizador = '" + id + "'", conn);
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows == false)
                    {
                        reader.Close();
                        cmd = new SqlCommand("INSERT INTO Login(idutilizador,nome,password) VALUES (@id, @nome, @password)", conn);

                        cmd.Parameters.AddWithValue("@nome", nomeUtilizador);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Utilizador Registado.");

                    }
                    else
                    {
                        MessageBox.Show("ID de Funcionário não encontrado ou ja existe um utilizador associado.");
                    }
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

    }
}
