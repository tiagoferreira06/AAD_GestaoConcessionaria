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
    public partial class GerirAgendamentos : Form
    {
        public GerirAgendamentos()
        {
            InitializeComponent();
            LerTestDrives();
        }

        private void LerTestDrives()
        {
            DataTable tabelaTestDrives = new DataTable();

            tabelaTestDrives.Columns.Add("ID");
            tabelaTestDrives.Columns.Add("Nome do Funcionario");
            tabelaTestDrives.Columns.Add("Nome do Cliente");
            tabelaTestDrives.Columns.Add("Modelo do Carro");
            tabelaTestDrives.Columns.Add("Data");

            var x = new Agendamentos();
            var ListaT = x.ListaTestDrive();

            foreach (TestDrive t in ListaT)
            {
                var l = tabelaTestDrives.NewRow();
                l["ID"] = t.id;
                l["Nome do Funcionario"] = t.funcionario;
                l["Nome do Cliente"] = t.cliente;
                l["Modelo do Carro"] = t.modelo;
                l["Data"] = t.data;

                tabelaTestDrives.Rows.Add(l);
            }

            this.tabelaTestDrives.DataSource = tabelaTestDrives;
        }

        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Close();
            Gerente g = new Gerente();
            g.Show();
        }
    }
}
