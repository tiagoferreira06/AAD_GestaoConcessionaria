namespace TP2025_Etapa4_27980_27957_27988
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pcbFundoBranco = new PictureBox();
            pcbLogo = new PictureBox();
            lblBemVindo = new Label();
            txtUtilizador = new TextBox();
            txtPassword = new TextBox();
            lblnomeconcessionaria = new Label();
            pcbutilizador = new PictureBox();
            pcbpassword = new PictureBox();
            butLogin = new Button();
            lblRegistar = new Label();
            pcbRegistar = new PictureBox();
            pcbFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbutilizador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbpassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRegistar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            SuspendLayout();
            // 
            // pcbFundoBranco
            // 
            pcbFundoBranco.BackColor = Color.WhiteSmoke;
            pcbFundoBranco.Location = new Point(420, -1);
            pcbFundoBranco.Name = "pcbFundoBranco";
            pcbFundoBranco.Size = new Size(385, 456);
            pcbFundoBranco.TabIndex = 0;
            pcbFundoBranco.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.WhiteSmoke;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(475, 55);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(273, 244);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.BackColor = Color.Firebrick;
            lblBemVindo.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.WhiteSmoke;
            lblBemVindo.Location = new Point(117, 103);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(185, 38);
            lblBemVindo.TabIndex = 2;
            lblBemVindo.Text = "Bem-Vindo";
            // 
            // txtUtilizador
            // 
            txtUtilizador.BackColor = Color.WhiteSmoke;
            txtUtilizador.ForeColor = Color.Silver;
            txtUtilizador.Location = new Point(77, 169);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.Size = new Size(270, 27);
            txtUtilizador.TabIndex = 3;
            txtUtilizador.TabStop = false;
            txtUtilizador.Text = "Utilizador";
            txtUtilizador.Enter += txtUtilizador_Enter;
            txtUtilizador.Leave += txtUtilizador_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(77, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TabStop = false;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblnomeconcessionaria
            // 
            lblnomeconcessionaria.AutoSize = true;
            lblnomeconcessionaria.BackColor = Color.WhiteSmoke;
            lblnomeconcessionaria.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnomeconcessionaria.ForeColor = Color.Black;
            lblnomeconcessionaria.Location = new Point(526, 336);
            lblnomeconcessionaria.Name = "lblnomeconcessionaria";
            lblnomeconcessionaria.Size = new Size(179, 34);
            lblnomeconcessionaria.TabIndex = 5;
            lblnomeconcessionaria.Text = "Stand Ferrari";
            lblnomeconcessionaria.Click += lblnomeconcessionaria_Click;
            // 
            // pcbutilizador
            // 
            pcbutilizador.Image = (Image)resources.GetObject("pcbutilizador.Image");
            pcbutilizador.Location = new Point(33, 164);
            pcbutilizador.Name = "pcbutilizador";
            pcbutilizador.Size = new Size(38, 32);
            pcbutilizador.SizeMode = PictureBoxSizeMode.Zoom;
            pcbutilizador.TabIndex = 7;
            pcbutilizador.TabStop = false;
            // 
            // pcbpassword
            // 
            pcbpassword.Image = (Image)resources.GetObject("pcbpassword.Image");
            pcbpassword.Location = new Point(33, 226);
            pcbpassword.Name = "pcbpassword";
            pcbpassword.Size = new Size(38, 32);
            pcbpassword.SizeMode = PictureBoxSizeMode.Zoom;
            pcbpassword.TabIndex = 8;
            pcbpassword.TabStop = false;
            // 
            // butLogin
            // 
            butLogin.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butLogin.Location = new Point(156, 314);
            butLogin.Name = "butLogin";
            butLogin.Size = new Size(108, 33);
            butLogin.TabIndex = 6;
            butLogin.TabStop = false;
            butLogin.Text = "Login";
            butLogin.UseVisualStyleBackColor = true;
            butLogin.Click += butLogin_Click;
            // 
            // lblRegistar
            // 
            lblRegistar.AutoSize = true;
            lblRegistar.BackColor = Color.Firebrick;
            lblRegistar.Font = new Font("Garamond", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistar.ForeColor = Color.WhiteSmoke;
            lblRegistar.Location = new Point(46, 415);
            lblRegistar.Name = "lblRegistar";
            lblRegistar.Size = new Size(69, 14);
            lblRegistar.TabIndex = 9;
            lblRegistar.Text = "Criar conta";
            lblRegistar.Click += lblRegistar_Click;
            // 
            // pcbRegistar
            // 
            pcbRegistar.Image = (Image)resources.GetObject("pcbRegistar.Image");
            pcbRegistar.Location = new Point(12, 406);
            pcbRegistar.Name = "pcbRegistar";
            pcbRegistar.Size = new Size(38, 32);
            pcbRegistar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbRegistar.TabIndex = 10;
            pcbRegistar.TabStop = false;
            pcbRegistar.Click += pcbRegistar_Click;
            // 
            // pcbFechar
            // 
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(376, 406);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(38, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 11;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(pcbFechar);
            Controls.Add(pcbRegistar);
            Controls.Add(lblRegistar);
            Controls.Add(pcbpassword);
            Controls.Add(pcbutilizador);
            Controls.Add(butLogin);
            Controls.Add(lblnomeconcessionaria);
            Controls.Add(txtPassword);
            Controls.Add(txtUtilizador);
            Controls.Add(lblBemVindo);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundoBranco);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcbFundoBranco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbutilizador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbpassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRegistar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFundoBranco;
        private PictureBox pcbLogo;
        private Label lblBemVindo;
        private TextBox txtUtilizador;
        private TextBox txtPassword;
        private Label lblnomeconcessionaria;
        private PictureBox pcbutilizador;
        private PictureBox pcbpassword;
        private Button butLogin;
        private Label lblRegistar;
        private PictureBox pcbRegistar;
        private PictureBox pcbFechar;
    }
}
