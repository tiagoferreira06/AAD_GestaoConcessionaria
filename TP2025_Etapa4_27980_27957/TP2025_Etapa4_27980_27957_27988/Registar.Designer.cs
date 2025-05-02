namespace TP2025_Etapa4_27980_27957_27988
{
    partial class Registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            pcbFundoBranco = new PictureBox();
            pcbLogo = new PictureBox();
            lblnomeconcessionaria = new Label();
            lblregistar = new Label();
            pcbPassword = new PictureBox();
            pcbUtilizador = new PictureBox();
            butregistar = new Button();
            txtNovaPassword = new TextBox();
            txtNovoUtilizador = new TextBox();
            txtIdFuncionario = new TextBox();
            pcbIdFuncionario = new PictureBox();
            txtConfirmarPassword = new TextBox();
            pcbOcultarPass = new PictureBox();
            pcbOcultarPass2 = new PictureBox();
            pcbFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtilizador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIdFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbOcultarPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbOcultarPass2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            SuspendLayout();
            // 
            // pcbFundoBranco
            // 
            pcbFundoBranco.BackColor = Color.WhiteSmoke;
            pcbFundoBranco.Location = new Point(421, -3);
            pcbFundoBranco.Name = "pcbFundoBranco";
            pcbFundoBranco.Size = new Size(385, 456);
            pcbFundoBranco.TabIndex = 1;
            pcbFundoBranco.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.WhiteSmoke;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(477, 63);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(273, 244);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // lblnomeconcessionaria
            // 
            lblnomeconcessionaria.AutoSize = true;
            lblnomeconcessionaria.BackColor = Color.WhiteSmoke;
            lblnomeconcessionaria.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnomeconcessionaria.ForeColor = Color.Black;
            lblnomeconcessionaria.Location = new Point(524, 346);
            lblnomeconcessionaria.Name = "lblnomeconcessionaria";
            lblnomeconcessionaria.Size = new Size(179, 34);
            lblnomeconcessionaria.TabIndex = 6;
            lblnomeconcessionaria.Text = "Stand Ferrari";
            // 
            // lblregistar
            // 
            lblregistar.AutoSize = true;
            lblregistar.BackColor = Color.Firebrick;
            lblregistar.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblregistar.ForeColor = Color.WhiteSmoke;
            lblregistar.Location = new Point(135, 74);
            lblregistar.Name = "lblregistar";
            lblregistar.Size = new Size(167, 38);
            lblregistar.TabIndex = 7;
            lblregistar.Text = "Registe-se";
            // 
            // pcbPassword
            // 
            pcbPassword.Image = (Image)resources.GetObject("pcbPassword.Image");
            pcbPassword.Location = new Point(43, 248);
            pcbPassword.Name = "pcbPassword";
            pcbPassword.Size = new Size(38, 32);
            pcbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPassword.TabIndex = 13;
            pcbPassword.TabStop = false;
            // 
            // pcbUtilizador
            // 
            pcbUtilizador.Image = (Image)resources.GetObject("pcbUtilizador.Image");
            pcbUtilizador.Location = new Point(43, 192);
            pcbUtilizador.Name = "pcbUtilizador";
            pcbUtilizador.Size = new Size(38, 32);
            pcbUtilizador.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUtilizador.TabIndex = 12;
            pcbUtilizador.TabStop = false;
            // 
            // butregistar
            // 
            butregistar.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butregistar.Location = new Point(158, 362);
            butregistar.Name = "butregistar";
            butregistar.Size = new Size(108, 33);
            butregistar.TabIndex = 11;
            butregistar.TabStop = false;
            butregistar.Text = "Registar";
            butregistar.UseVisualStyleBackColor = true;
            butregistar.Click += butregistar_Click;
            // 
            // txtNovaPassword
            // 
            txtNovaPassword.BackColor = Color.WhiteSmoke;
            txtNovaPassword.ForeColor = Color.Silver;
            txtNovaPassword.Location = new Point(87, 253);
            txtNovaPassword.Name = "txtNovaPassword";
            txtNovaPassword.Size = new Size(270, 27);
            txtNovaPassword.TabIndex = 10;
            txtNovaPassword.TabStop = false;
            txtNovaPassword.Text = "Nova Password";
            txtNovaPassword.Enter += txtNovaPassword_Enter;
            txtNovaPassword.Leave += txtNovaPassword_Leave;
            // 
            // txtNovoUtilizador
            // 
            txtNovoUtilizador.BackColor = Color.WhiteSmoke;
            txtNovoUtilizador.ForeColor = Color.Silver;
            txtNovoUtilizador.Location = new Point(87, 197);
            txtNovoUtilizador.Name = "txtNovoUtilizador";
            txtNovoUtilizador.Size = new Size(270, 27);
            txtNovoUtilizador.TabIndex = 9;
            txtNovoUtilizador.TabStop = false;
            txtNovoUtilizador.Text = "Novo Utilizador";
            txtNovoUtilizador.Enter += txtNovoUtilizador_Enter;
            txtNovoUtilizador.Leave += txtNovoUtilizador_Leave;
            // 
            // txtIdFuncionario
            // 
            txtIdFuncionario.BackColor = Color.WhiteSmoke;
            txtIdFuncionario.ForeColor = Color.Silver;
            txtIdFuncionario.Location = new Point(87, 141);
            txtIdFuncionario.Name = "txtIdFuncionario";
            txtIdFuncionario.Size = new Size(270, 27);
            txtIdFuncionario.TabIndex = 14;
            txtIdFuncionario.TabStop = false;
            txtIdFuncionario.Text = "Seu ID de Funcionário";
            txtIdFuncionario.Enter += txtIdFuncionario_Enter;
            txtIdFuncionario.Leave += txtIdFuncionario_Leave;
            // 
            // pcbIdFuncionario
            // 
            pcbIdFuncionario.Image = (Image)resources.GetObject("pcbIdFuncionario.Image");
            pcbIdFuncionario.Location = new Point(43, 136);
            pcbIdFuncionario.Name = "pcbIdFuncionario";
            pcbIdFuncionario.Size = new Size(38, 32);
            pcbIdFuncionario.SizeMode = PictureBoxSizeMode.Zoom;
            pcbIdFuncionario.TabIndex = 15;
            pcbIdFuncionario.TabStop = false;
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.BackColor = Color.WhiteSmoke;
            txtConfirmarPassword.ForeColor = Color.Silver;
            txtConfirmarPassword.Location = new Point(87, 304);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(270, 27);
            txtConfirmarPassword.TabIndex = 16;
            txtConfirmarPassword.TabStop = false;
            txtConfirmarPassword.Text = "Confirmar Password";
            txtConfirmarPassword.Enter += txtConfirmarPassword_Enter;
            txtConfirmarPassword.Leave += txtConfirmarPassword_Leave;
            // 
            // pcbOcultarPass
            // 
            pcbOcultarPass.Image = (Image)resources.GetObject("pcbOcultarPass.Image");
            pcbOcultarPass.Location = new Point(363, 261);
            pcbOcultarPass.Name = "pcbOcultarPass";
            pcbOcultarPass.Size = new Size(22, 19);
            pcbOcultarPass.SizeMode = PictureBoxSizeMode.Zoom;
            pcbOcultarPass.TabIndex = 17;
            pcbOcultarPass.TabStop = false;
            pcbOcultarPass.MouseDown += pcbOcultarPass_MouseDown;
            pcbOcultarPass.MouseUp += pcbOcultarPass_MouseUp;
            // 
            // pcbOcultarPass2
            // 
            pcbOcultarPass2.Image = (Image)resources.GetObject("pcbOcultarPass2.Image");
            pcbOcultarPass2.Location = new Point(363, 312);
            pcbOcultarPass2.Name = "pcbOcultarPass2";
            pcbOcultarPass2.Size = new Size(22, 19);
            pcbOcultarPass2.SizeMode = PictureBoxSizeMode.Zoom;
            pcbOcultarPass2.TabIndex = 18;
            pcbOcultarPass2.TabStop = false;
            pcbOcultarPass2.MouseDown += pcbOcultarPass2_MouseDown;
            pcbOcultarPass2.MouseUp += pcbOcultarPass2_MouseUp;
            // 
            // pcbFechar
            // 
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(377, 406);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(38, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 19;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // Registar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFechar);
            Controls.Add(pcbOcultarPass2);
            Controls.Add(pcbOcultarPass);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(pcbIdFuncionario);
            Controls.Add(txtIdFuncionario);
            Controls.Add(pcbPassword);
            Controls.Add(pcbUtilizador);
            Controls.Add(butregistar);
            Controls.Add(txtNovaPassword);
            Controls.Add(txtNovoUtilizador);
            Controls.Add(lblregistar);
            Controls.Add(lblnomeconcessionaria);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundoBranco);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registar";
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUtilizador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIdFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbOcultarPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbOcultarPass2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtNovaPassword_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pcbFundoBranco;
        private PictureBox pcbLogo;
        private Label lblnomeconcessionaria;
        private Label lblregistar;
        private PictureBox pcbPassword;
        private PictureBox pcbUtilizador;
        private Button butregistar;
        private TextBox txtNovaPassword;
        private TextBox txtNovoUtilizador;
        private TextBox txtIdFuncionario;
        private PictureBox pcbIdFuncionario;
        private TextBox txtConfirmarPassword;
        private PictureBox pcbOcultarPass;
        private PictureBox pcbOcultarPass2;
        private PictureBox pcbFechar;
    }
}