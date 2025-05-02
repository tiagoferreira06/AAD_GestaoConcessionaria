namespace TP2025_Etapa4_27980_27957_27988
{
    partial class AdicionarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarFuncionario));
            pcbFundoBranco = new PictureBox();
            pcbLogo = new PictureBox();
            lbladicionarfuncionario = new Label();
            txtnome = new TextBox();
            txtendereço = new TextBox();
            txttelefone = new TextBox();
            txtemail = new TextBox();
            pcbUtilizador = new PictureBox();
            dataNascimento = new DateTimePicker();
            cmbCargo = new ComboBox();
            pcbDataNascimento = new PictureBox();
            pcbEndereco = new PictureBox();
            pcbTelefone = new PictureBox();
            pcbEmail = new PictureBox();
            butregistar = new Button();
            pcbFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtilizador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDataNascimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEndereco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTelefone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            SuspendLayout();
            // 
            // pcbFundoBranco
            // 
            pcbFundoBranco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbFundoBranco.BackColor = Color.WhiteSmoke;
            pcbFundoBranco.Location = new Point(418, -3);
            pcbFundoBranco.Name = "pcbFundoBranco";
            pcbFundoBranco.Size = new Size(385, 456);
            pcbFundoBranco.TabIndex = 2;
            pcbFundoBranco.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbLogo.BackColor = Color.WhiteSmoke;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(430, 58);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(348, 322);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 3;
            pcbLogo.TabStop = false;
            // 
            // lbladicionarfuncionario
            // 
            lbladicionarfuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbladicionarfuncionario.AutoSize = true;
            lbladicionarfuncionario.BackColor = Color.Firebrick;
            lbladicionarfuncionario.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladicionarfuncionario.ForeColor = Color.WhiteSmoke;
            lbladicionarfuncionario.Location = new Point(36, 26);
            lbladicionarfuncionario.Name = "lbladicionarfuncionario";
            lbladicionarfuncionario.Size = new Size(325, 38);
            lbladicionarfuncionario.TabIndex = 8;
            lbladicionarfuncionario.Text = "Registar Funcionário";
            // 
            // txtnome
            // 
            txtnome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnome.BackColor = Color.WhiteSmoke;
            txtnome.ForeColor = Color.Silver;
            txtnome.Location = new Point(65, 96);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(270, 27);
            txtnome.TabIndex = 10;
            txtnome.TabStop = false;
            txtnome.Text = "Nome";
            txtnome.Enter += txtNome_Enter;
            txtnome.Leave += txtnome_Leave;
            // 
            // txtendereço
            // 
            txtendereço.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtendereço.BackColor = Color.WhiteSmoke;
            txtendereço.ForeColor = Color.Silver;
            txtendereço.Location = new Point(65, 199);
            txtendereço.Name = "txtendereço";
            txtendereço.Size = new Size(270, 27);
            txtendereço.TabIndex = 12;
            txtendereço.TabStop = false;
            txtendereço.Text = "Endereço";
            txtendereço.Enter += txtendereco_Enter;
            txtendereço.Leave += txtendereco_Leave;
            // 
            // txttelefone
            // 
            txttelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttelefone.BackColor = Color.WhiteSmoke;
            txttelefone.ForeColor = Color.Silver;
            txttelefone.Location = new Point(65, 249);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(270, 27);
            txttelefone.TabIndex = 13;
            txttelefone.TabStop = false;
            txttelefone.Text = "Telefone";
            txttelefone.Enter += txttelefone_Enter;
            txttelefone.Leave += txttelefone_Leave;
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.Silver;
            txtemail.Location = new Point(65, 301);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(270, 27);
            txtemail.TabIndex = 14;
            txtemail.TabStop = false;
            txtemail.Text = "Email";
            txtemail.Enter += txtemail_Enter;
            txtemail.Leave += txtemail_Leave;
            // 
            // pcbUtilizador
            // 
            pcbUtilizador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbUtilizador.Image = (Image)resources.GetObject("pcbUtilizador.Image");
            pcbUtilizador.Location = new Point(21, 91);
            pcbUtilizador.Name = "pcbUtilizador";
            pcbUtilizador.Size = new Size(38, 32);
            pcbUtilizador.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUtilizador.TabIndex = 15;
            pcbUtilizador.TabStop = false;
            // 
            // dataNascimento
            // 
            dataNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataNascimento.Location = new Point(65, 149);
            dataNascimento.MaxDate = new DateTime(2024, 12, 29, 0, 0, 0, 0);
            dataNascimento.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(270, 27);
            dataNascimento.TabIndex = 16;
            dataNascimento.Value = new DateTime(2024, 12, 29, 0, 0, 0, 0);
            // 
            // cmbCargo
            // 
            cmbCargo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Gerente", "Sub-Gerente", "Funcionário" });
            cmbCargo.Location = new Point(65, 352);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(151, 28);
            cmbCargo.TabIndex = 17;
            // 
            // pcbDataNascimento
            // 
            pcbDataNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbDataNascimento.Image = (Image)resources.GetObject("pcbDataNascimento.Image");
            pcbDataNascimento.Location = new Point(21, 149);
            pcbDataNascimento.Name = "pcbDataNascimento";
            pcbDataNascimento.Size = new Size(38, 27);
            pcbDataNascimento.SizeMode = PictureBoxSizeMode.Zoom;
            pcbDataNascimento.TabIndex = 18;
            pcbDataNascimento.TabStop = false;
            // 
            // pcbEndereco
            // 
            pcbEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbEndereco.Image = (Image)resources.GetObject("pcbEndereco.Image");
            pcbEndereco.Location = new Point(21, 199);
            pcbEndereco.Name = "pcbEndereco";
            pcbEndereco.Size = new Size(38, 27);
            pcbEndereco.SizeMode = PictureBoxSizeMode.Zoom;
            pcbEndereco.TabIndex = 19;
            pcbEndereco.TabStop = false;
            // 
            // pcbTelefone
            // 
            pcbTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbTelefone.Image = (Image)resources.GetObject("pcbTelefone.Image");
            pcbTelefone.Location = new Point(21, 249);
            pcbTelefone.Name = "pcbTelefone";
            pcbTelefone.Size = new Size(38, 27);
            pcbTelefone.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTelefone.TabIndex = 20;
            pcbTelefone.TabStop = false;
            // 
            // pcbEmail
            // 
            pcbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(21, 301);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(38, 27);
            pcbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pcbEmail.TabIndex = 21;
            pcbEmail.TabStop = false;
            // 
            // butregistar
            // 
            butregistar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butregistar.Location = new Point(236, 352);
            butregistar.Name = "butregistar";
            butregistar.Size = new Size(99, 29);
            butregistar.TabIndex = 22;
            butregistar.Text = "Registar";
            butregistar.UseVisualStyleBackColor = true;
            butregistar.Click += butregistar_Click;
            // 
            // pcbFechar
            // 
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(374, 406);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(38, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 23;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // AdicionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFechar);
            Controls.Add(butregistar);
            Controls.Add(pcbEmail);
            Controls.Add(pcbTelefone);
            Controls.Add(pcbEndereco);
            Controls.Add(pcbDataNascimento);
            Controls.Add(cmbCargo);
            Controls.Add(dataNascimento);
            Controls.Add(pcbUtilizador);
            Controls.Add(txtemail);
            Controls.Add(txttelefone);
            Controls.Add(txtendereço);
            Controls.Add(txtnome);
            Controls.Add(lbladicionarfuncionario);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundoBranco);
            Name = "AdicionarFuncionario";
            Text = "Adicionar Funcionario";
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtilizador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDataNascimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEndereco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTelefone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFundoBranco;
        private PictureBox pcbLogo;
        private Label lbladicionarfuncionario;
        private TextBox txtnome;
        private TextBox txtendereço;
        private TextBox txttelefone;
        private TextBox txtemail;
        private PictureBox pcbUtilizador;
        private DateTimePicker dataNascimento;
        private ComboBox cmbCargo;
        private PictureBox pcbDataNascimento;
        private PictureBox pcbEndereco;
        private PictureBox pcbTelefone;
        private PictureBox pcbEmail;
        private Button butregistar;
        private PictureBox pcbFechar;
    }
}