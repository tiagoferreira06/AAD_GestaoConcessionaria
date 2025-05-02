using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2025_Etapa4_27980_27957_27988.Modelos;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TP2025_Etapa4_27980_27957_27988.Listas
{
    public class Servicos
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;

        #region TabelaServicos

        public List<Servico> ListaServicos()
        {
            var ListaServicos = new List<Servico>();

            try
            {
                conn.Open();

                //Stored Procedure - CREATE PROCEDURE ListaServicos AS
                //SELECT IdServiço, TipoServiço, DataServiço, Custo, Clientes.NomeCliente, Carros.Modelo, Promocoes.NomePromocao FROM Serviços
                //INNER JOIN Clientes ON Clientes.IdCliente = Serviços.IdCliente
                //LEFT JOIN Carros ON Carros.IdCarro = Serviços.IdCarro
                //LEFT JOIN Promocoes ON Promocoes.IdPromocao = Serviços.IdPromocao;

                cmd = new SqlCommand("EXEC ListaServicos", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Servico servico = new Servico();
                    servico.id = reader.GetInt32(0);
                    servico.tipoServico = reader.GetString(1);
                    servico.dataServico = reader.GetDateTime(2);
                    servico.custo = reader.GetDouble(3);
                    servico.nomeCliente = reader.GetString(4);
                    servico.nomeCarro = reader.IsDBNull(5) ? (string?)null : reader.GetString(5);
                    servico.nomePromocao = reader.IsDBNull(6) ? (string?)null : reader.GetString(6);

                    ListaServicos.Add(servico);
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

            return ListaServicos;
        }

        #endregion
    }
}
