
namespace Biblioteca.View.Livros {
    partial class LivrosEditarView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivrosEditarView));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesqGenero = new System.Windows.Forms.Button();
            this.lblEdicaoLivro = new System.Windows.Forms.Label();
            this.btlPesqEditora = new System.Windows.Forms.Button();
            this.head1 = new Biblioteca.Util.Head();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.linlLblVerExemplar = new System.Windows.Forms.LinkLabel();
            this.btnPesqAutor = new System.Windows.Forms.Button();
            this.linkLblAdicExemplar = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Black;
            this.btnAtualizar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(570, 409);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(169, 46);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Black;
            this.btnExcluir.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(570, 461);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(169, 46);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPesqGenero);
            this.panel1.Controls.Add(this.lblEdicaoLivro);
            this.panel1.Controls.Add(this.btlPesqEditora);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.tbEditora);
            this.panel1.Controls.Add(this.linlLblVerExemplar);
            this.panel1.Controls.Add(this.btnPesqAutor);
            this.panel1.Controls.Add(this.linkLblAdicExemplar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.tbGenero);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tbEdicao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBoxAno);
            this.panel1.Controls.Add(this.tbISBN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbQuantidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(186, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 650);
            this.panel1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(289, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 27);
            this.textBox1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome:";
            // 
            // btnPesqGenero
            // 
            this.btnPesqGenero.BackColor = System.Drawing.Color.Black;
            this.btnPesqGenero.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesqGenero.ForeColor = System.Drawing.Color.White;
            this.btnPesqGenero.Location = new System.Drawing.Point(542, 339);
            this.btnPesqGenero.Name = "btnPesqGenero";
            this.btnPesqGenero.Size = new System.Drawing.Size(87, 27);
            this.btnPesqGenero.TabIndex = 49;
            this.btnPesqGenero.Text = "Pesquisar";
            this.btnPesqGenero.UseVisualStyleBackColor = false;
            // 
            // lblEdicaoLivro
            // 
            this.lblEdicaoLivro.AutoSize = true;
            this.lblEdicaoLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdicaoLivro.ForeColor = System.Drawing.Color.White;
            this.lblEdicaoLivro.Location = new System.Drawing.Point(331, 71);
            this.lblEdicaoLivro.Name = "lblEdicaoLivro";
            this.lblEdicaoLivro.Size = new System.Drawing.Size(307, 38);
            this.lblEdicaoLivro.TabIndex = 51;
            this.lblEdicaoLivro.Text = "EDIÇÃO DE LIVRO";
            // 
            // btlPesqEditora
            // 
            this.btlPesqEditora.BackColor = System.Drawing.Color.Black;
            this.btlPesqEditora.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btlPesqEditora.ForeColor = System.Drawing.Color.White;
            this.btlPesqEditora.Location = new System.Drawing.Point(502, 257);
            this.btlPesqEditora.Name = "btlPesqEditora";
            this.btlPesqEditora.Size = new System.Drawing.Size(87, 27);
            this.btlPesqEditora.TabIndex = 48;
            this.btlPesqEditora.Text = "Pesquisar";
            this.btlPesqEditora.UseVisualStyleBackColor = false;
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(973, 37);
            this.head1.TabIndex = 50;
            // 
            // tbEditora
            // 
            this.tbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEditora.Location = new System.Drawing.Point(288, 257);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(208, 27);
            this.tbEditora.TabIndex = 47;
            // 
            // linlLblVerExemplar
            // 
            this.linlLblVerExemplar.AutoSize = true;
            this.linlLblVerExemplar.LinkColor = System.Drawing.Color.White;
            this.linlLblVerExemplar.Location = new System.Drawing.Point(650, 550);
            this.linlLblVerExemplar.Name = "linlLblVerExemplar";
            this.linlLblVerExemplar.Size = new System.Drawing.Size(92, 16);
            this.linlLblVerExemplar.TabIndex = 49;
            this.linlLblVerExemplar.TabStop = true;
            this.linlLblVerExemplar.Text = "Ver exemplares";
            // 
            // btnPesqAutor
            // 
            this.btnPesqAutor.BackColor = System.Drawing.Color.Black;
            this.btnPesqAutor.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesqAutor.ForeColor = System.Drawing.Color.White;
            this.btnPesqAutor.Location = new System.Drawing.Point(652, 216);
            this.btnPesqAutor.Name = "btnPesqAutor";
            this.btnPesqAutor.Size = new System.Drawing.Size(87, 27);
            this.btnPesqAutor.TabIndex = 46;
            this.btnPesqAutor.Text = "Pesquisar";
            this.btnPesqAutor.UseVisualStyleBackColor = false;
            // 
            // linkLblAdicExemplar
            // 
            this.linkLblAdicExemplar.AutoSize = true;
            this.linkLblAdicExemplar.LinkColor = System.Drawing.Color.White;
            this.linkLblAdicExemplar.Location = new System.Drawing.Point(615, 523);
            this.linkLblAdicExemplar.Name = "linkLblAdicExemplar";
            this.linkLblAdicExemplar.Size = new System.Drawing.Size(127, 16);
            this.linkLblAdicExemplar.TabIndex = 48;
            this.linkLblAdicExemplar.TabStop = true;
            this.linkLblAdicExemplar.Text = "Adicionar Exemplares";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(217, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Gênero:";
            // 
            // tbGenero
            // 
            this.tbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenero.Location = new System.Drawing.Point(288, 339);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(248, 27);
            this.tbGenero.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(646, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ano:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(289, 216);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(349, 27);
            this.tbNome.TabIndex = 34;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEdicao.Location = new System.Drawing.Point(615, 299);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(124, 27);
            this.tbEdicao.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Autor:";
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxAno.Location = new System.Drawing.Point(695, 338);
            this.maskedTextBoxAno.Mask = "9999";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(44, 27);
            this.maskedTextBoxAno.TabIndex = 43;
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbISBN.Location = new System.Drawing.Point(289, 299);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(247, 27);
            this.tbISBN.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(547, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Edição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "ISBN:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuantidade.Location = new System.Drawing.Point(693, 256);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(46, 27);
            this.tbQuantidade.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(591, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(217, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Editora:";
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1162, 656);
            this.pnltotal.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(177, 650);
            this.menuControl1.TabIndex = 29;
            // 
            // LivrosEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1162, 656);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LivrosEditarView";
            this.Text = "Editar Livros";
            this.Load += new System.EventHandler(this.LivrosItemView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.LinkLabel linkLblAdicExemplar;
        private System.Windows.Forms.LinkLabel linlLblVerExemplar;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblEdicaoLivro;
        private System.Windows.Forms.Button btnPesqGenero;
        private System.Windows.Forms.Button btlPesqEditora;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Button btnPesqAutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}