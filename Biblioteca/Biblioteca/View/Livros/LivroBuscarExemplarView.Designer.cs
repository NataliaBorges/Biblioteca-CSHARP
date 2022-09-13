
namespace Biblioteca.View.Livros {
    partial class LivroBuscarExemplarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroBuscarExemplarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.LinkLblCadastroEmprestimo = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMais = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.LvExemplar = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Editora = new System.Windows.Forms.ColumnHeader();
            this.Gênero = new System.Windows.Forms.ColumnHeader();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.BackColor = System.Drawing.Color.Black;
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1299, 788);
            this.pnltotal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.LinkLblCadastroEmprestimo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LvExemplar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(197, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 782);
            this.panel1.TabIndex = 0;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(415, 69);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(332, 38);
            this.lblCadastroLivro.TabIndex = 35;
            this.lblCadastroLivro.Text = "BUSCAR EXEMPLAR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1099, 37);
            this.head1.TabIndex = 34;
            // 
            // LinkLblCadastroEmprestimo
            // 
            this.LinkLblCadastroEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LinkLblCadastroEmprestimo.AutoSize = true;
            this.LinkLblCadastroEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLblCadastroEmprestimo.LinkColor = System.Drawing.Color.White;
            this.LinkLblCadastroEmprestimo.Location = new System.Drawing.Point(15, 272);
            this.LinkLblCadastroEmprestimo.Name = "LinkLblCadastroEmprestimo";
            this.LinkLblCadastroEmprestimo.Size = new System.Drawing.Size(152, 18);
            this.LinkLblCadastroEmprestimo.TabIndex = 33;
            this.LinkLblCadastroEmprestimo.TabStop = true;
            this.LinkLblCadastroEmprestimo.Text = "Cadastrar Empréstimo";
            this.LinkLblCadastroEmprestimo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnMais);
            this.panel2.Controls.Add(this.lblQuantidade);
            this.panel2.Controls.Add(this.tbQuantidade);
            this.panel2.Location = new System.Drawing.Point(15, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 70);
            this.panel2.TabIndex = 30;
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.White;
            this.btnMais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMais.BackgroundImage")));
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMais.Location = new System.Drawing.Point(313, 22);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(29, 29);
            this.btnMais.TabIndex = 29;
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(33, 25);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(212, 20);
            this.lblQuantidade.TabIndex = 27;
            this.lblQuantidade.Text = "Adicionar mais exemplares: ";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuantidade.Location = new System.Drawing.Point(251, 22);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(56, 27);
            this.tbQuantidade.TabIndex = 28;
            this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LvExemplar
            // 
            this.LvExemplar.BackColor = System.Drawing.Color.Black;
            this.LvExemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvExemplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Edição,
            this.Ano,
            this.ISBN,
            this.Aquisição,
            this.Autor,
            this.Editora,
            this.Gênero});
            this.LvExemplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LvExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvExemplar.ForeColor = System.Drawing.Color.White;
            this.LvExemplar.FullRowSelect = true;
            this.LvExemplar.HideSelection = false;
            this.LvExemplar.HoverSelection = true;
            this.LvExemplar.Location = new System.Drawing.Point(0, 328);
            this.LvExemplar.Name = "LvExemplar";
            this.LvExemplar.Size = new System.Drawing.Size(1099, 454);
            this.LvExemplar.TabIndex = 25;
            this.LvExemplar.UseCompatibleStateImageBehavior = false;
            this.LvExemplar.View = System.Windows.Forms.View.Details;
            this.LvExemplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvExemplar_MouseClick_1);
            this.LvExemplar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvExemplar_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 200;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edição.Width = 150;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ano.Width = 100;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBN.Width = 100;
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aquisição.Width = 150;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Autor.Width = 200;
            // 
            // Editora
            // 
            this.Editora.Text = "Editora";
            this.Editora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editora.Width = 150;
            // 
            // Gênero
            // 
            this.Gênero.Text = "Gênero";
            this.Gênero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gênero.Width = 150;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(188, 782);
            this.menuControl1.TabIndex = 1;
            // 
            // LivroBuscarExemplarView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1299, 788);
            this.Controls.Add(this.pnltotal);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LivroBuscarExemplarView";
            this.Text = "LivroBuscarExemplar";
            this.Load += new System.EventHandler(this.LivroBuscarExemplarView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LvExemplar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Editora;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.LinkLabel LinkLblCadastroEmprestimo;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.ColumnHeader Gênero;
    }
}