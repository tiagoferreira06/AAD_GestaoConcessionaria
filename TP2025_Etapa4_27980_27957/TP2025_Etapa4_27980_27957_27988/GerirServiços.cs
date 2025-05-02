using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2025_Etapa4_27980_27957_27988.Listas;
using TP2025_Etapa4_27980_27957_27988.Modelos;

namespace TP2025_Etapa4_27980_27957_27988
{
    public partial class GerirServiços : Form
    {
        public GerirServiços()
        {
            InitializeComponent();
            LerServiços();
        }

        #region TabelaServiços

        private void LerServiços()
        {
            DataTable tabelaServicos = new DataTable();

            tabelaServicos.Columns.Add("ID");
            tabelaServicos.Columns.Add("Tipo de Serviço");
            tabelaServicos.Columns.Add("Data do Serviço");
            tabelaServicos.Columns.Add("Custo");
            tabelaServicos.Columns.Add("Nome do Cliente");
            tabelaServicos.Columns.Add("Modelo do Carro");
            tabelaServicos.Columns.Add("Nome da Promoção");

            var x = new Servicos();
            var ListaServicos = x.ListaServicos();

            foreach (Servico servico in ListaServicos)
            {
                var l = tabelaServicos.NewRow();
                l["ID"] = servico.id;
                l["Tipo de Serviço"] = servico.tipoServico;
                l["Data do Serviço"] = servico.dataServico;
                l["Custo"] = servico.custo;
                l["Nome do Cliente"] = servico.nomeCliente;
                l["Modelo do Carro"] = servico.nomeCarro;
                l["Nome da Promoção"] = servico.nomePromocao;

                tabelaServicos.Rows.Add(l);
            }

            this.tabelaServicos.DataSource = tabelaServicos;
        }

        #endregion

        #region Fechar Botao
        private void pcbFechar_Click_1(object sender, EventArgs e)
        {
            Close();
            Gerente g = new Gerente();
            g.Show();
        }
        #endregion

        private void lblservicos_Click(object sender, EventArgs e)
        {

        }


    }
}

