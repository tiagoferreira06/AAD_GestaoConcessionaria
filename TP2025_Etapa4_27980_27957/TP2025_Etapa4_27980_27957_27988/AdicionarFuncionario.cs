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
    public partial class AdicionarFuncionario : Form
    {
        public AdicionarFuncionario()
        {
            InitializeComponent();
        }

        #region Registar Funcionario Botao
        private void butregistar_Click(object sender, EventArgs e)
        {

            #region Attributes

            string nome = txtnome.Text.Trim();
            string endereco = txtendereço.Text.Trim();
            string email = txtemail.Text.Trim();
            int telefone;

            DateTime DataNascimento = dataNascimento.Value;

            #endregion

            #region Verificações de Campos

            if (nome == "" || nome == "Nome")
            {
                MessageBox.Show("Nome Invalido.");
                return;
            }
            if (endereco == "" || endereco == "Endereço")
            {
                MessageBox.Show("Endereço Invalido.");
                return;
            }
            if (email == "" || email == "Email")
            {
                MessageBox.Show("Email Invalido.");
                return;
            }
            if (Int32.TryParse(txttelefone.Text, out telefone) == false || txttelefone.Text == "")
            {
                MessageBox.Show("Numero de Telefone invalido.");
                return;
            }

            #endregion

            Funcionario f = new Funcionario();

            f.nome = nome;
            f.endereco = endereco;
            f.email = email;
            f.telefone = telefone;
            f.DataDeNascimento = DataNascimento;
            f.cargo = cmbCargo.SelectedItem.ToString();

            var x = new Funcionarios();

            int idFuncionario = x.CriarFuncionario(f);

            if (idFuncionario > 0)
            {
                // Perguntar ao usuário se deseja adicionar vendas
                var result = MessageBox.Show("Funcionario criado com sucesso, deseja adicionar vendas associadas a esse funcionario?",
                                             "Adicionar Vendas",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perguntar quantas vendas adicionar
                    int numeroVendas = 0;
                    while (true)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Quantas vendas deseja adicionar?",
                                                                                  "Quantidade de Vendas",
                                                                                  "0");
                        if (int.TryParse(input, out numeroVendas) && numeroVendas > 0)
                        {
                            break;
                        }
                        MessageBox.Show("Por favor, insira um número válido maior que 0.");
                    }

                    // Adicionar cada venda
                    for (int i = 1; i <= numeroVendas; i++)
                    {
                        Venda venda = new Venda();

                        // Pedir Data da Venda
                        string dataVendaInput = Microsoft.VisualBasic.Interaction.InputBox($"Digite a data da venda {i} (formato: DD-MM-AAAA):",
                                                                                           "Data da Venda");
                        if (!DateTime.TryParse(dataVendaInput, out DateTime dataVenda))
                        {
                            MessageBox.Show("Data inválida. Venda ignorada.");
                            continue;
                        }
                        venda.dataVenda = dataVenda;

                        // Pedir Valor Final
                        string valorFinalInput = Microsoft.VisualBasic.Interaction.InputBox($"Digite o valor final da venda {i}:",
                                                                                            "Valor Final");
                        if (!int.TryParse(valorFinalInput, out int valorFinal))
                        {
                            MessageBox.Show("Valor final inválido. Venda ignorada.");
                            continue;
                        }
                        venda.valorFinal = valorFinal;

                        // Pedir Custo
                        string custoInput = Microsoft.VisualBasic.Interaction.InputBox($"Digite o custo da venda {i}:",
                                                                                       "Custo");
                        if (!int.TryParse(custoInput, out int custo))
                        {
                            MessageBox.Show("Custo inválido. Venda ignorada.");
                            continue;
                        }
                        venda.custo = custo;

                        // Pedir IdCarro
                        string idCarroInput = Microsoft.VisualBasic.Interaction.InputBox($"Digite o ID do carro para a venda {i}:",
                                                                                         "ID do Carro");
                        if (!int.TryParse(idCarroInput, out int idCarro))
                        {
                            MessageBox.Show("ID do carro inválido. Venda ignorada.");
                            continue;
                        }
                        venda.idCarro = idCarro;

                        // Pedir IdCliente
                        string idClienteInput = Microsoft.VisualBasic.Interaction.InputBox($"Digite o ID do cliente para a venda {i}:",
                                                                                           "ID do Cliente");
                        if (!int.TryParse(idClienteInput, out int idCliente))
                        {
                            MessageBox.Show("ID do cliente inválido. Venda ignorada.");
                            continue;
                        }
                        venda.idCliente = idCliente;

                        // Associar o IdFuncionario do funcionário recém-criado
                        venda.idFuncionario = idFuncionario;

                        // Criar a venda
                        var x1 = new Vendas();
                        if (x1.CriarVenda(venda))
                        {
                            MessageBox.Show($"Venda {i} adicionada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show($"Erro ao adicionar a venda {i}.");
                        }
                    }
                }
                return;
            }
            else
            {
                MessageBox.Show("Erro ao criar funcionario.");
                return;

            }
        }

        #endregion

        #region Fechar Botao
        private void pcbFechar_Click(object sender, EventArgs e)
        {
            Close();
            Gerente ger = new Gerente();
            ger.Show();
        }
        #endregion

        #region Aparencia

        #region Nome TextBox

        // Remove o texto inicial
        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtnome.Text == "Nome")
            {
                txtnome.Text = "";
                txtnome.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtnome_Leave(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                txtnome.Text = "Nome";
                txtnome.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region Endereço TextBox

        // Remove o texto inicial
        private void txtendereco_Enter(object sender, EventArgs e)
        {
            if (txtendereço.Text == "Endereço")
            {
                txtendereço.Text = "";
                txtendereço.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtendereco_Leave(object sender, EventArgs e)
        {
            if (txtendereço.Text == "")
            {
                txtendereço.Text = "Endereço";
                txtendereço.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region Telefone TextBox

        // Remove o texto inicial
        private void txttelefone_Enter(object sender, EventArgs e)
        {
            if (txttelefone.Text == "Telefone")
            {
                txttelefone.Text = "";
                txttelefone.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txttelefone_Leave(object sender, EventArgs e)
        {
            if (txttelefone.Text == "")
            {
                txttelefone.Text = "Telefone";
                txttelefone.ForeColor = Color.Silver;

            }
        }

        #endregion

        #region Email TextBox

        // Remove o texto inicial
        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        // Coloca o texto inicial caso o utilizador deixe a caixa de texto vazia
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email";
                txtemail.ForeColor = Color.Silver;

            }
        }

        #endregion

        #endregion

    }
}
