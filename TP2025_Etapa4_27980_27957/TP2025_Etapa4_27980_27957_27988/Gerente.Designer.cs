namespace TP2025_Etapa4_27980_27957_27988
{
    partial class Gerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerente));
            pcbLogo = new PictureBox();
            tabelaFuncionarios = new DataGridView();
            pcbFechar = new PictureBox();
            lblbemvindo = new Label();
            lbltabelafunc = new Label();
            butcriarfuncionario = new Button();
            butremoverfuncionario = new Button();
            lblclientes = new Label();
            tabelaClientes = new DataGridView();
            butAtualizarFunc = new Button();
            butvendas = new Button();
            butservicos = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            butagendamentos = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbLogo.BackColor = Color.Firebrick;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(-3, 12);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(174, 126);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // tabelaFuncionarios
            // 
            tabelaFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFuncionarios.Location = new Point(207, 382);
            tabelaFuncionarios.Margin = new Padding(3, 4, 3, 4);
            tabelaFuncionarios.MultiSelect = false;
            tabelaFuncionarios.Name = "tabelaFuncionarios";
            tabelaFuncionarios.RowHeadersWidth = 51;
            tabelaFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaFuncionarios.Size = new Size(861, 221);
            tabelaFuncionarios.TabIndex = 2;
            // 
            // pcbFechar
            // 
            pcbFechar.BackColor = Color.Firebrick;
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(1230, 20);
            pcbFechar.Margin = new Padding(3, 4, 3, 4);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(57, 38);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 20;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // lblbemvindo
            // 
            lblbemvindo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblbemvindo.AutoSize = true;
            lblbemvindo.BackColor = Color.Firebrick;
            lblbemvindo.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbemvindo.ForeColor = Color.WhiteSmoke;
            lblbemvindo.Location = new Point(174, 20);
            lblbemvindo.Name = "lblbemvindo";
            lblbemvindo.Size = new Size(194, 38);
            lblbemvindo.TabIndex = 21;
            lblbemvindo.Text = "Bem-Vindo!";
            // 
            // lbltabelafunc
            // 
            lbltabelafunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbltabelafunc.AutoSize = true;
            lbltabelafunc.BackColor = SystemColors.ControlLight;
            lbltabelafunc.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltabelafunc.ForeColor = Color.Black;
            lbltabelafunc.Location = new Point(207, 353);
            lbltabelafunc.Name = "lbltabelafunc";
            lbltabelafunc.Size = new Size(329, 26);
            lbltabelafunc.TabIndex = 22;
            lbltabelafunc.Text = "Funcionários ativos na empresa:";
            // 
            // butcriarfuncionario
            // 
            butcriarfuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butcriarfuncionario.BackColor = Color.Firebrick;
            butcriarfuncionario.FlatAppearance.BorderColor = Color.Firebrick;
            butcriarfuncionario.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butcriarfuncionario.FlatStyle = FlatStyle.Flat;
            butcriarfuncionario.Font = new Font("Garamond", 12F);
            butcriarfuncionario.ForeColor = Color.WhiteSmoke;
            butcriarfuncionario.Location = new Point(0, 151);
            butcriarfuncionario.Margin = new Padding(3, 4, 3, 4);
            butcriarfuncionario.Name = "butcriarfuncionario";
            butcriarfuncionario.Size = new Size(171, 80);
            butcriarfuncionario.TabIndex = 23;
            butcriarfuncionario.Text = "Adicionar Funcionário";
            butcriarfuncionario.UseVisualStyleBackColor = false;
            butcriarfuncionario.Click += butcriarfuncionario_Click;
            // 
            // butremoverfuncionario
            // 
            butremoverfuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butremoverfuncionario.FlatAppearance.BorderColor = Color.Firebrick;
            butremoverfuncionario.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butremoverfuncionario.FlatStyle = FlatStyle.Flat;
            butremoverfuncionario.Font = new Font("Garamond", 12F);
            butremoverfuncionario.ForeColor = Color.WhiteSmoke;
            butremoverfuncionario.Location = new Point(0, 354);
            butremoverfuncionario.Margin = new Padding(3, 4, 3, 4);
            butremoverfuncionario.Name = "butremoverfuncionario";
            butremoverfuncionario.Size = new Size(171, 80);
            butremoverfuncionario.TabIndex = 24;
            butremoverfuncionario.Text = "Remover Funcionário";
            butremoverfuncionario.UseVisualStyleBackColor = true;
            butremoverfuncionario.Click += butremoverfuncionario_Click;
            // 
            // lblclientes
            // 
            lblclientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblclientes.AutoSize = true;
            lblclientes.BackColor = SystemColors.ControlLight;
            lblclientes.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclientes.ForeColor = Color.Black;
            lblclientes.Location = new Point(207, 102);
            lblclientes.Name = "lblclientes";
            lblclientes.Size = new Size(183, 26);
            lblclientes.TabIndex = 25;
            lblclientes.Text = "Últimos Clientes:";
            // 
            // tabelaClientes
            // 
            tabelaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientes.Location = new Point(207, 131);
            tabelaClientes.Margin = new Padding(3, 4, 3, 4);
            tabelaClientes.MultiSelect = false;
            tabelaClientes.Name = "tabelaClientes";
            tabelaClientes.RowHeadersWidth = 51;
            tabelaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaClientes.Size = new Size(861, 196);
            tabelaClientes.TabIndex = 26;
            // 
            // butAtualizarFunc
            // 
            butAtualizarFunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butAtualizarFunc.FlatAppearance.BorderColor = Color.Firebrick;
            butAtualizarFunc.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butAtualizarFunc.FlatStyle = FlatStyle.Flat;
            butAtualizarFunc.Font = new Font("Garamond", 12F);
            butAtualizarFunc.ForeColor = Color.WhiteSmoke;
            butAtualizarFunc.Location = new Point(0, 254);
            butAtualizarFunc.Margin = new Padding(3, 4, 3, 4);
            butAtualizarFunc.Name = "butAtualizarFunc";
            butAtualizarFunc.Size = new Size(171, 80);
            butAtualizarFunc.TabIndex = 27;
            butAtualizarFunc.Text = "Atualizar Funcionário";
            butAtualizarFunc.UseVisualStyleBackColor = true;
            butAtualizarFunc.Click += butAtualizarFunc_Click;
            // 
            // butvendas
            // 
            butvendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butvendas.BackColor = Color.Firebrick;
            butvendas.FlatAppearance.BorderColor = Color.Firebrick;
            butvendas.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butvendas.FlatStyle = FlatStyle.Flat;
            butvendas.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butvendas.ForeColor = Color.WhiteSmoke;
            butvendas.Location = new Point(542, 0);
            butvendas.Margin = new Padding(3, 4, 3, 4);
            butvendas.Name = "butvendas";
            butvendas.Size = new Size(159, 75);
            butvendas.TabIndex = 28;
            butvendas.Text = "Últimas Vendas";
            butvendas.UseVisualStyleBackColor = false;
            butvendas.Click += butvendas_Click;
            // 
            // butservicos
            // 
            butservicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butservicos.BackColor = Color.Firebrick;
            butservicos.FlatAppearance.BorderColor = Color.Firebrick;
            butservicos.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butservicos.FlatStyle = FlatStyle.Flat;
            butservicos.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butservicos.ForeColor = Color.WhiteSmoke;
            butservicos.Location = new Point(374, 0);
            butservicos.Margin = new Padding(3, 4, 3, 4);
            butservicos.Name = "butservicos";
            butservicos.Size = new Size(173, 75);
            butservicos.TabIndex = 29;
            butservicos.Text = "Últimos Serviços";
            butservicos.UseVisualStyleBackColor = false;
            butservicos.Click += butservicos_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(butremoverfuncionario);
            panel1.Controls.Add(pcbLogo);
            panel1.Controls.Add(butAtualizarFunc);
            panel1.Controls.Add(butcriarfuncionario);
            panel1.Location = new Point(-2, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 667);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.Controls.Add(butagendamentos);
            panel2.Controls.Add(pcbFechar);
            panel2.Controls.Add(lblbemvindo);
            panel2.Controls.Add(butservicos);
            panel2.Controls.Add(butvendas);
            panel2.Location = new Point(1, -2);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 75);
            panel2.TabIndex = 32;
            // 
            // butagendamentos
            // 
            butagendamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butagendamentos.BackColor = Color.Firebrick;
            butagendamentos.FlatAppearance.BorderColor = Color.Firebrick;
            butagendamentos.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            butagendamentos.FlatStyle = FlatStyle.Flat;
            butagendamentos.Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butagendamentos.ForeColor = Color.WhiteSmoke;
            butagendamentos.Location = new Point(686, 0);
            butagendamentos.Margin = new Padding(3, 4, 3, 4);
            butagendamentos.Name = "butagendamentos";
            butagendamentos.Size = new Size(332, 75);
            butagendamentos.TabIndex = 30;
            butagendamentos.Text = "Agendamentos Test-Drive Marcados";
            butagendamentos.UseVisualStyleBackColor = false;
            butagendamentos.Click += butagendamentos_Click;
            // 
            // Gerente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1325, 635);
            Controls.Add(panel1);
            Controls.Add(tabelaClientes);
            Controls.Add(lblclientes);
            Controls.Add(lbltabelafunc);
            Controls.Add(tabelaFuncionarios);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de Gerente";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbLogo;
        private DataGridView tabelaFuncionarios;
        private PictureBox pcbFechar;
        private Label lblbemvindo;
        private Label lbltabelafunc;
        private Button butcriarfuncionario;
        private Button butremoverfuncionario;
        private Label lblclientes;
        private DataGridView tabelaClientes;
        private Button butAtualizarFunc;
        private Button butvendas;
        private Button butservicos;
        private Panel panel1;
        private Panel panel2;
        private Button butagendamentos;
    }
}