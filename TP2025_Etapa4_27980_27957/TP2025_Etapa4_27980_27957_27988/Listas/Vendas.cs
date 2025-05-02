using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2025_Etapa4_27980_27957_27988.Modelos;

namespace TP2025_Etapa4_27980_27957_27988.Listas
{
    
    public class Vendas
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;

        public List<Venda> ListaVendas()
        {
            var ListaVendas = new List<Venda>();

            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT IdVenda, DataVenda, ValorFinal, Custo, Carros.Modelo, Clientes.NomeCliente, Funcionario.NomeFuncionario FROM Vendas " +
                    "INNER JOIN Carros ON Carros.IdCarro=Vendas.IdCarro " +
                    "INNER JOIN Clientes ON Clientes.IdCliente=Vendas.IdCliente " +
                    "INNER JOIN Funcionario ON Funcionario.IdFuncionario=Vendas.IdFuncionario", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Venda venda = new Venda();
                    venda.id = reader.GetInt32(0);
                    venda.dataVenda = reader.GetDateTime(1);
                    venda.valorFinal = reader.GetInt32(2);
                    venda.custo = reader.GetInt32(3);
                    venda.nomeCarro = reader.GetString(4);
                    venda.nomeCliente = reader.GetString(5);
                    venda.NomeFuncionario = reader.GetString(6);

                    ListaVendas.Add(venda);
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

            return ListaVendas;
        }

        #region CRUD

        public Venda? ProcurarVendas(int id)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT * FROM Vendas WHERE IdVenda=@id", conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Venda v = new Venda();
                    v.id = reader.GetInt32(0);
                    v.dataVenda = reader.GetDateTime(1);
                    v.valorFinal = reader.GetInt32(2);
                    v.custo = reader.GetInt32(3);
                    v.idCarro = reader.GetInt32(4);
                    v.idCliente = reader.GetInt32(5);

                    return v;
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

            return null;
        }

        public bool CriarVenda(Venda v)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("INSERT INTO Vendas(DataVenda, ValorFinal, Custo, IdCarro, IdCliente, IdFuncionario) VALUES(@data, @valorFinal, @custo, @idCarro, @idCliente, @idFuncionario)", conn);
                cmd.Parameters.AddWithValue("@data", v.dataVenda);
                cmd.Parameters.AddWithValue("@valorFinal", v.valorFinal);
                cmd.Parameters.AddWithValue("@custo", v.custo);
                cmd.Parameters.AddWithValue("@idCarro", v.idCarro);
                cmd.Parameters.AddWithValue("@idCliente", v.idCliente);
                cmd.Parameters.AddWithValue("@idFuncionario", v.idFuncionario);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool EliminarVenda(int id)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("DELETE FROM Vendas WHERE idVenda = @id");
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

        public bool AtualizarVenda(Venda v)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("UPDATE Vendas SET DataVenda = @data, ValorFinal = @valorFinal, Custo = @custo, IdCarro = @idCarro, IdCliente = @idCliente, IdFuncionario = @idFuncionario WHERE IdVenda = @id", conn);
                cmd.Parameters.AddWithValue("@data", v.dataVenda);
                cmd.Parameters.AddWithValue("@valorFinal", v.valorFinal);
                cmd.Parameters.AddWithValue("@custo", v.custo);
                cmd.Parameters.AddWithValue("@idCarro", v.idCarro);
                cmd.Parameters.AddWithValue("@idCliente", v.idCliente);
                cmd.Parameters.AddWithValue("@idFuncionario", v.idFuncionario);

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
    }
}
