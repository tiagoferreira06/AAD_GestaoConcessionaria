namespace TP2025_Etapa4_27980_27957_27988
{
    partial class GerirVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirVendas));
            pcbFundo = new PictureBox();
            pcbLogo = new PictureBox();
            tabelaVendas = new DataGridView();
            lblvendas = new Label();
            pcbFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            SuspendLayout();
            // 
            // pcbFundo
            // 
            pcbFundo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbFundo.BackColor = Color.Firebrick;
            pcbFundo.Location = new Point(3, -1);
            pcbFundo.Name = "pcbFundo";
            pcbFundo.Size = new Size(897, 73);
            pcbFundo.TabIndex = 1;
            pcbFundo.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbLogo.BackColor = Color.Firebrick;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(12, -1);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(57, 62);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // tabelaVendas
            // 
            tabelaVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaVendas.Location = new Point(43, 113);
            tabelaVendas.MultiSelect = false;
            tabelaVendas.Name = "tabelaVendas";
            tabelaVendas.RowHeadersWidth = 51;
            tabelaVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaVendas.Size = new Size(801, 267);
            tabelaVendas.TabIndex = 27;
            // 
            // lblvendas
            // 
            lblvendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblvendas.AutoSize = true;
            lblvendas.BackColor = Color.Firebrick;
            lblvendas.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblvendas.ForeColor = Color.WhiteSmoke;
            lblvendas.Location = new Point(89, 23);
            lblvendas.Name = "lblvendas";
            lblvendas.Size = new Size(174, 26);
            lblvendas.TabIndex = 28;
            lblvendas.Text = "Últimas Vendas:";
            // 
            // pcbFechar
            // 
            pcbFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbFechar.BackColor = Color.Firebrick;
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(843, 17);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(38, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 29;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click;
            // 
            // GerirVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(893, 450);
            Controls.Add(pcbFechar);
            Controls.Add(lblvendas);
            Controls.Add(tabelaVendas);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundo);
            MaximizeBox = false;
            Name = "GerirVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)pcbFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFundo;
        private PictureBox pcbLogo;
        private DataGridView tabelaVendas;
        private Label lblvendas;
        private PictureBox pcbFechar;
    }
}