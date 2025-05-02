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
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
            LerFuncionarios();
            LerClíentes();
        }

        #region TabelaClientes

        private void LerClíentes()
        {
            DataTable tabelaClientes = new DataTable();

            tabelaClientes.Columns.Add("ID");
            tabelaClientes.Columns.Add("Nome");
            tabelaClientes.Columns.Add("Data de Nascimento");
            tabelaClientes.Columns.Add("Endereço");
            tabelaClientes.Columns.Add("Telefone");
            tabelaClientes.Columns.Add("Email");

            var x = new Clientes();
            var ListaC = x.ListaClientes();

            foreach (Cliente c in ListaC)
            {
                var l = tabelaClientes.NewRow();
                l["ID"] = c.id;
                l["Nome"] = c.nome;
                l["Data de Nascimento"] = c.dataNascimento;
                l["Endereço"] = c.endereco;
                l["Telefone"] = c.telefone;
                l["Email"] = c.email;

                tabelaClientes.Rows.Add(l);
            }

            this.tabelaClientes.DataSource = tabelaClientes;
        }

        #endregion

        #region TabelaFuncionarios

        private void LerFuncionarios()
        {
            DataTable tabelaFunc = new DataTable();

            tabelaFunc.Columns.Add("ID");
            tabelaFunc.Columns.Add("Cargo");
            tabelaFunc.Columns.Add("Nome");
            tabelaFunc.Columns.Add("Data de Nascimento");
            tabelaFunc.Columns.Add("Endereço");
            tabelaFunc.Columns.Add("Telefone");
            tabelaFunc.Columns.Add("Email");

            var x = new Funcionarios();
            var ListaFuncionarios = x.ListaFuncionarios();

            foreach (Funcionario f in ListaFuncionarios)
            {
                var l = tabelaFunc.NewRow();
                l["ID"] = f.id;
                l["Cargo"] = f.cargo;
                l["Nome"] = f.nome;
                l["Data de Nascimento"] = f.DataDeNascimento;
                l["Endereço"] = f.endereco;
                l["Telefone"] = f.telefone;
                l["Email"] = f.email;

                tabelaFunc.Rows.Add(l);
            }

            this.tabelaFuncionarios.DataSource = tabelaFunc;
        }
        #endregion

        #region Fechar Botao
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }
        #endregion

        #region CriarFuncionario Botao

        private void butcriarfuncionario_Click(object sender, EventArgs e)
        {
            Close();
            AdicionarFuncionario add = new AdicionarFuncionario();
            add.Show();
        }

        #endregion

        #region RemoverFuncionario

        private void butremoverfuncionario_Click(object sender, EventArgs e)
        {
            var FuncSelecionado = this.tabelaFuncionarios.SelectedRows[0].Cells[0].Value.ToString();

            if (FuncSelecionado == null)
            {
                return;
            }
            //Passar a string para uma variavel id
            int id = int.Parse(FuncSelecionado);

            //Mensagem para confirmar
            DialogResult pergunta = MessageBox.Show("Tem certeza que quer remover Funcionario " + id + "?", "Confirmar", MessageBoxButtons.YesNo);

            if (pergunta == DialogResult.Yes)
            {
                var x = new Funcionarios();
                x.EliminarFuncionario(id);
                LerFuncionarios();
            }
            else
            {
                return;
            }

        }
        #endregion

        #region AtualizarFuncionario

        private void butAtualizarFunc_Click(object sender, EventArgs e)
        {

            if (tabelaFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um funcionario valido.");
                return;
            }

            var func = this.tabelaFuncionarios.SelectedRows[0].Cells[0].Value.ToString();

            if (func == null)
            {
                MessageBox.Show("Erro no funcionario selecionado.");
                return;
            }
            int id = int.Parse(func);

            var x = new Funcionarios();
            Funcionario f = x.ProcurarFuncionario(id);

            if (f == null)
            {
                MessageBox.Show("Funcionario não encontrado.");
                return;
            }

            #region AtualizarParametros

            // Atualizar os campos do funcionário interativamente
            // Nome
            string novoNome = Microsoft.VisualBasic.Interaction.InputBox($"Nome atual: {f.nome}\nDigite o novo nome:",
                                                                         "Atualizar Nome", f.nome);
            if (!string.IsNullOrEmpty(novoNome))
            {
                f.nome = novoNome.Trim();
            }

            // Cargo
            string novoCargo = Microsoft.VisualBasic.Interaction.InputBox($"Cargo atual: {f.cargo}\nDigite o novo cargo:",
                                                                          "Atualizar Cargo", f.cargo);
            if (!string.IsNullOrEmpty(novoCargo))
            {
                f.cargo = novoCargo.Trim();
            }

            // Data de Nascimento
            string novaDataNascimento = Microsoft.VisualBasic.Interaction.InputBox($"Data de Nascimento atual: {f.DataDeNascimento}\nDigite a nova data de nascimento:",
                                                                                   "Atualizar Data de Nascimento", f.DataDeNascimento.ToString("dd-MM-yyyy"));
            if (!string.IsNullOrEmpty(novaDataNascimento) && DateTime.TryParse(novaDataNascimento, out DateTime dataNascimentoAtualizada))
            {
                f.DataDeNascimento = dataNascimentoAtualizada;
            }

            // Endereço
            string novoEndereco = Microsoft.VisualBasic.Interaction.InputBox($"Endereço atual: {f.endereco}\nDigite o novo endereço:",
                                                                             "Atualizar Endereço", f.endereco);
            if (!string.IsNullOrEmpty(novoEndereco))
            {
                f.endereco = novoEndereco.Trim();
            }

            // Telefone
            string novoTelefone = Microsoft.VisualBasic.Interaction.InputBox($"Telefone atual: {f.telefone}\nDigite o novo telefone:",
                                                                             "Atualizar Telefone", f.telefone.ToString());
            if (!string.IsNullOrEmpty(novoTelefone) && int.TryParse(novoTelefone, out int telefoneAtualizado))
            {
                f.telefone = telefoneAtualizado;
            }

            // Email
            string novoEmail = Microsoft.VisualBasic.Interaction.InputBox($"Email atual: {f.email}\nDigite o novo email:",
                                                                          "Atualizar Email", f.email);
            if (!string.IsNullOrEmpty(novoEmail))
            {
                f.email = novoEmail.Trim();
            }

            #endregion

            if (x.AtualizarFuncionario(f, id))
            {
                MessageBox.Show("Funcionário atualizado com sucesso.");
                LerFuncionarios();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o funcionario.");
            }

        }

        #endregion

        #region Botoes MostrarForms

        private void butvendas_Click(object sender, EventArgs e)
        {
            Close();
            GerirVendas v = new GerirVendas();
            v.Show();
        }

        private void butservicos_Click(object sender, EventArgs e)
        {
            Close();
            GerirServiços s = new GerirServiços();
            s.Show();
        }

        #endregion

        private void butagendamentos_Click(object sender, EventArgs e)
        {
            Close();
            Form x = new GerirAgendamentos();
            x.Show();
        }
    }
}
