using Azure.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2025_Etapa4_27980_27957_27988.Modelos;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TP2025_Etapa4_27980_27957_27988.Listas
{

    public class Funcionarios
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;

        #region TabelaFuncionarios
        public List<Funcionario> ListaFuncionarios()
        {
            var ListaFunc = new List<Funcionario>();

            try
            {
                conn.Open();

                //Store Procedure - CREATE PROCEDURE ListaFuncionarios AS SELECT * FROM Funcionario ORDER BY IdFuncionario;

                cmd = new SqlCommand("EXEC ListaFuncionarios", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    f.id = reader.GetInt32(0);
                    f.cargo = reader.GetString(1);
                    f.nome = reader.GetString(2);
                    f.DataDeNascimento = reader.GetDateTime(3);
                    f.endereco = reader.GetString(4);
                    f.telefone = reader.GetInt32(5);
                    f.email = reader.GetString(6);

                    ListaFunc.Add(f);
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

            return ListaFunc;
        }
        #endregion

        #region CRUD

        #region ProcurarFuncionario
        public Funcionario ProcurarFuncionario(int id)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT * FROM Funcionario WHERE IdFuncionario=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Funcionario f = new Funcionario();
                    //f.id = reader.GetInt32(0);
                    f.cargo = reader.GetString(1);
                    f.nome = reader.GetString(2);
                    f.DataDeNascimento = reader.GetDateTime(3);
                    f.endereco = reader.GetString(4);
                    f.telefone = reader.GetInt32(5);
                    f.email = reader.GetString(6);

                    return f;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar funcionario: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
        #endregion

        #region CriarFuncionario
        public int CriarFuncionario(Funcionario f)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("INSERT INTO Funcionario(Cargo,NomeFuncionario,DataNascimento,Endereço,Telefone,Email) " +
                    "OUTPUT INSERTED.IdFuncionario " +
                    "VALUES (@cargo,@nome,@data,@endereco,@telefone,@email)", conn);
                cmd.Parameters.AddWithValue("@cargo", f.cargo);
                cmd.Parameters.AddWithValue("@nome", f.nome);
                cmd.Parameters.AddWithValue("@data", f.DataDeNascimento);
                cmd.Parameters.AddWithValue("@endereco", f.endereco);
                cmd.Parameters.AddWithValue("@telefone", f.telefone);
                cmd.Parameters.AddWithValue("@email", f.email);

                //cmd.ExecuteNonQuery();
                int idFuncionario = (int)cmd.ExecuteScalar();
                return idFuncionario;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }
        #endregion

        #region EliminarFuncionario
        public bool EliminarFuncionario(int id)
        {
            try
            {
                conn.Open();

                //Remover da tabela Login
                cmd = new SqlCommand("DELETE FROM Login WHERE idutilizador = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                //Remover da tabela Funcionarios
                cmd = new SqlCommand("DELETE FROM Funcionario WHERE IdFuncionario = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        #endregion

        #region AtualizarFuncionario
        public bool AtualizarFuncionario(Funcionario f, int id)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("UPDATE Funcionario SET NomeFuncionario = @nome, Cargo = @cargo, DataNascimento = @DataDeNascimento, Endereço = @endereco, Telefone = @telefone, Email = @email WHERE IdFuncionario = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", f.nome);
                cmd.Parameters.AddWithValue("@cargo", f.cargo);
                cmd.Parameters.AddWithValue("@DataDeNascimento", f.DataDeNascimento);
                cmd.Parameters.AddWithValue("@endereco", f.endereco);
                cmd.Parameters.AddWithValue("@telefone", f.telefone);
                cmd.Parameters.AddWithValue("@email", f.email);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        #endregion

        #endregion
    }
}
