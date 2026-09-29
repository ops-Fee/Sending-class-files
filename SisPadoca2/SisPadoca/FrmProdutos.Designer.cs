namespace SisPadoca
{
    partial class FrmProdutos
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            LblNCM = new Label();
            LblDescricao = new Label();
            LblBarras = new Label();
            LblLote = new Label();
            LblUM = new Label();
            TxbNCM = new TextBox();
            TxbDescricao = new TextBox();
            TxbBarra = new TextBox();
            TxbLote = new TextBox();
            CbxUM = new ComboBox();
            BtnNovo = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ImgLista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolo_comunidade;
            pictureBox1.Location = new Point(21, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(172, 25);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 1;
            LblNCM.Text = "NCM";
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(172, 87);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 2;
            LblDescricao.Text = "Descrição";
            // 
            // LblBarras
            // 
            LblBarras.AutoSize = true;
            LblBarras.Location = new Point(172, 149);
            LblBarras.Name = "LblBarras";
            LblBarras.Size = new Size(149, 25);
            LblBarras.TabIndex = 3;
            LblBarras.Text = "Código de Barras";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(383, 149);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 4;
            LblLote.Text = "Lote";
            // 
            // LblUM
            // 
            LblUM.AutoSize = true;
            LblUM.Location = new Point(383, 87);
            LblUM.Name = "LblUM";
            LblUM.Size = new Size(178, 25);
            LblUM.TabIndex = 5;
            LblUM.Text = "Unindade de Medida";
            // 
            // TxbNCM
            // 
            TxbNCM.Location = new Point(172, 53);
            TxbNCM.Name = "TxbNCM";
            TxbNCM.Size = new Size(150, 31);
            TxbNCM.TabIndex = 6;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(172, 115);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(150, 31);
            TxbDescricao.TabIndex = 7;
            // 
            // TxbBarra
            // 
            TxbBarra.Location = new Point(172, 177);
            TxbBarra.Name = "TxbBarra";
            TxbBarra.Size = new Size(150, 31);
            TxbBarra.TabIndex = 8;
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(383, 177);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(150, 31);
            TxbLote.TabIndex = 9;
            // 
            // CbxUM
            // 
            CbxUM.FormattingEnabled = true;
            CbxUM.Location = new Point(383, 115);
            CbxUM.Name = "CbxUM";
            CbxUM.Size = new Size(182, 33);
            CbxUM.TabIndex = 10;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(21, 242);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(112, 34);
            BtnNovo.TabIndex = 11;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(139, 242);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 34);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(257, 242);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(112, 34);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(375, 242);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(112, 34);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(493, 242);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(112, 34);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(CbxUM);
            Controls.Add(TxbLote);
            Controls.Add(TxbBarra);
            Controls.Add(TxbDescricao);
            Controls.Add(TxbNCM);
            Controls.Add(LblUM);
            Controls.Add(LblLote);
            Controls.Add(LblBarras);
            Controls.Add(LblDescricao);
            Controls.Add(LblNCM);
            Controls.Add(pictureBox1);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblNCM;
        private Label LblDescricao;
        private Label LblBarras;
        private Label LblLote;
        private Label LblUM;
        private TextBox TxbNCM;
        private TextBox TxbDescricao;
        private TextBox TxbBarra;
        private TextBox TxbLote;
        private ComboBox CbxUM;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ImageList ImgLista;
    }
}