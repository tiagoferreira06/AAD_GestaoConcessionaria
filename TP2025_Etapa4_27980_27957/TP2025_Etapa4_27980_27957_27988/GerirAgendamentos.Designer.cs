namespace TP2025_Etapa4_27980_27957_27988
{
    partial class GerirAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirAgendamentos));
            pcbFechar = new PictureBox();
            lblagendamentos = new Label();
            pcbLogo = new PictureBox();
            pcbFundo = new PictureBox();
            tabelaTestDrives = new DataGridView();
            lblTestDrives = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTestDrives).BeginInit();
            SuspendLayout();
            // 
            // pcbFechar
            // 
            pcbFechar.BackColor = Color.Firebrick;
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(763, 18);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(53, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 35;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // lblagendamentos
            // 
            lblagendamentos.AutoSize = true;
            lblagendamentos.BackColor = Color.Firebrick;
            lblagendamentos.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblagendamentos.ForeColor = Color.WhiteSmoke;
            lblagendamentos.Location = new Point(104, 18);
            lblagendamentos.Name = "lblagendamentos";
            lblagendamentos.Size = new Size(354, 26);
            lblagendamentos.TabIndex = 34;
            lblagendamentos.Text = "Últimos Agendamentos Test-Drive";
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.Firebrick;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(11, -3);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(87, 62);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 33;
            pcbLogo.TabStop = false;
            // 
            // pcbFundo
            // 
            pcbFundo.BackColor = Color.Firebrick;
            pcbFundo.Location = new Point(-1, -3);
            pcbFundo.Name = "pcbFundo";
            pcbFundo.Size = new Size(844, 72);
            pcbFundo.TabIndex = 32;
            pcbFundo.TabStop = false;
            // 
            // tabelaTestDrives
            // 
            tabelaTestDrives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaTestDrives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTestDrives.Location = new Point(35, 141);
            tabelaTestDrives.MultiSelect = false;
            tabelaTestDrives.Name = "tabelaTestDrives";
            tabelaTestDrives.RowHeadersWidth = 51;
            tabelaTestDrives.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaTestDrives.Size = new Size(764, 267);
            tabelaTestDrives.TabIndex = 36;
            // 
            // lblTestDrives
            // 
            lblTestDrives.AutoSize = true;
            lblTestDrives.BackColor = SystemColors.ControlLight;
            lblTestDrives.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestDrives.ForeColor = Color.Black;
            lblTestDrives.Location = new Point(35, 102);
            lblTestDrives.Name = "lblTestDrives";
            lblTestDrives.Size = new Size(133, 26);
            lblTestDrives.TabIndex = 38;
            lblTestDrives.Text = "Test-Drives:";
            // 
            // GerirAgendamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(837, 450);
            Controls.Add(lblTestDrives);
            Controls.Add(tabelaTestDrives);
            Controls.Add(pcbFechar);
            Controls.Add(lblagendamentos);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundo);
            Name = "GerirAgendamentos";
            Text = "GerirAgendamentos";
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTestDrives).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFechar;
        private Label lblagendamentos;
        private PictureBox pcbLogo;
        private PictureBox pcbFundo;
        private DataGridView tabelaTestDrives;
        private Label lblTestDrives;
    }
}