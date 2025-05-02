namespace TP2025_Etapa4_27980_27957_27988
{
    partial class GerirServiços
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirServiços));
            pcbFundo = new PictureBox();
            pcbLogo = new PictureBox();
            lblservicos = new Label();
            tabelaServicos = new DataGridView();
            pcbFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).BeginInit();
            SuspendLayout();
            // 
            // pcbFundo
            // 
            pcbFundo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbFundo.BackColor = Color.Firebrick;
            pcbFundo.Location = new Point(0, 1);
            pcbFundo.Name = "pcbFundo";
            pcbFundo.Size = new Size(925, 72);
            pcbFundo.TabIndex = 1;
            pcbFundo.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbLogo.BackColor = Color.Firebrick;
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(12, 1);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(66, 62);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // lblservicos
            // 
            lblservicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblservicos.AutoSize = true;
            lblservicos.BackColor = Color.Firebrick;
            lblservicos.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblservicos.ForeColor = Color.WhiteSmoke;
            lblservicos.Location = new Point(84, 22);
            lblservicos.Name = "lblservicos";
            lblservicos.Size = new Size(177, 26);
            lblservicos.TabIndex = 29;
            lblservicos.Text = "Últimos Serviços";
            lblservicos.Click += lblservicos_Click;
            // 
            // tabelaServicos
            // 
            tabelaServicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaServicos.Location = new Point(60, 113);
            tabelaServicos.MultiSelect = false;
            tabelaServicos.Name = "tabelaServicos";
            tabelaServicos.RowHeadersWidth = 51;
            tabelaServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaServicos.Size = new Size(786, 267);
            tabelaServicos.TabIndex = 30;
            // 
            // pcbFechar
            // 
            pcbFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbFechar.BackColor = Color.Firebrick;
            pcbFechar.Image = (Image)resources.GetObject("pcbFechar.Image");
            pcbFechar.Location = new Point(877, 16);
            pcbFechar.Name = "pcbFechar";
            pcbFechar.Size = new Size(38, 32);
            pcbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pcbFechar.TabIndex = 31;
            pcbFechar.TabStop = false;
            pcbFechar.Click += pcbFechar_Click_1;
            // 
            // GerirServiços
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(pcbFechar);
            Controls.Add(tabelaServicos);
            Controls.Add(lblservicos);
            Controls.Add(pcbLogo);
            Controls.Add(pcbFundo);
            MaximizeBox = false;
            Name = "GerirServiços";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerir Serviços";
            ((System.ComponentModel.ISupportInitialize)pcbFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFundo;
        private PictureBox pcbLogo;
        private Label lblservicos;
        private DataGridView tabelaServicos;
        private PictureBox pcbFechar;
    }
}