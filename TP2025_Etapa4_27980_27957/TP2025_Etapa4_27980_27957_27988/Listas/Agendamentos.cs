using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2025_Etapa4_27980_27957_27988.Modelos;

namespace TP2025_Etapa4_27980_27957_27988.Listas
{
    public class Agendamentos
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Trabalho_AAD;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader reader;

        #region TabelaAgendamentos
        public List<TestDrive> ListaTestDrive()
        {
            var ListaTestDrive = new List<TestDrive>();

            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT IdTestDrive, Funcionario.NomeFuncionario, Clientes.NomeCliente, Carros.Modelo, Data FROM AgendamentoTestDrive " +
                    "INNER JOIN Carros ON Carros.IdCarro=AgendamentoTestDrive.IdCarro " +
                    "INNER JOIN Clientes ON Clientes.IdCliente=AgendamentoTestDrive.IdCliente " +
                    "INNER JOIN Funcionario ON Funcionario.IdFuncionario=AgendamentoTestDrive.IdFuncionario", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TestDrive t = new TestDrive();
                    t.id = reader.GetInt32(0);
                    t.funcionario = reader.GetString(1);
                    t.cliente = reader.GetString(2);
                    t.modelo = reader.GetString(3);
                    t.data = reader.GetDateTime(4);

                    ListaTestDrive.Add(t);

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

            return ListaTestDrive;
        }
        #endregion
    }
}
