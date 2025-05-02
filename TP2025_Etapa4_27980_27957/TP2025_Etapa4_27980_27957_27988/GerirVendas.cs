using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2025_Etapa4_27980_27957_27988.Modelos;
using TP2025_Etapa4_27980_27957_27988.Listas;

namespace TP2025_Etapa4_27980_27957_27988
{
    public partial class GerirVendas : Form
    {
        public GerirVendas()
        {
            InitializeComponent();
            LerVendas();
        }

        #region TabelaVendas

        private void LerVendas()
        {
            DataTable tabelaVenda = new DataTable();

            tabelaVenda.Columns.Add("ID");
            tabelaVenda.Columns.Add("Data de Venda");
            tabelaVenda.Columns.Add("Valor Final");
            tabelaVenda.Columns.Add("Custo");
            tabelaVenda.Columns.Add("Modelo do Carro");
            tabelaVenda.Columns.Add("Nome do Cliente");
            tabelaVenda.Columns.Add("Nome do Funcionario");

            var x = new Vendas();
            var ListaVendas = x.ListaVendas();

            foreach (Venda venda in ListaVendas)
            {
                var l = tabelaVenda.NewRow();
                l["ID"] = venda.id;
                l["Data de Venda"] = venda.dataVenda;
                l["Valor Final"] = venda.valorFinal;
                l["Custo"] = venda.custo;
                l["Modelo do Carro"] = venda.nomeCarro;
                l["Nome do Cliente"] = venda.nomeCliente;
                l["Nome do Funcionario"] = venda.NomeFuncionario;

                tabelaVenda.Rows.Add(l);
            }

            this.tabelaVendas.DataSource = tabelaVenda;
        }

        #endregion

        #region Fechar Botao
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Close();
            Gerente g = new Gerente();
            g.Show();
        }
        #endregion
    }
}
