using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2025_Etapa4_27980_27957_27988.Modelos;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TP2025_Etapa4_27980_27957_27988.Listas
{
    public class Clientes
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;

        #region ListaClientes

        public List<Cliente> ListaClientes()
        {
            var ListaClientes = new List<Cliente>();

            try
            {
                conn.Open();


                // Stored Procedure - CREATE PROCEDURE ListaClientes AS SELECT * FROM Clientes ORDER BY IdCliente DESC;

                cmd = new SqlCommand("EXEC ListaClientes", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.id = reader.GetInt32(0);
                    cliente.nome = reader.GetString(1);
                    cliente.dataNascimento = reader.GetDateTime(2);
                    cliente.endereco = reader.GetString(3);
                    cliente.telefone = reader.GetInt32(4);
                    cliente.email = reader.GetString(5);

                    ListaClientes.Add(cliente);

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
            return ListaClientes;
        }

        #endregion

    }
}
