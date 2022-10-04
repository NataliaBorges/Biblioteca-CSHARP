
namespace Biblioteca.View.Livros {
    partial class LivrosCadastrarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivrosCadastrarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnGenero = new FontAwesome.Sharp.IconButton();
            this.BtnEditora = new FontAwesome.Sharp.IconButton();
            this.BtnAutor = new FontAwesome.Sharp.IconButton();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.head1 = new Biblioteca.Util.Head();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltotal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.BackColor = System.Drawing.Color.Black;
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Controls.Add(this.pnlPrincipal, 1, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1224, 590);
            this.pnltotal.TabIndex = 22;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(177, 584);
            this.menuControl1.TabIndex = 22;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pnlPrincipal.Controls.Add(this.BtnGenero);
            this.pnlPrincipal.Controls.Add(this.BtnEditora);
            this.pnlPrincipal.Controls.Add(this.BtnAutor);
            this.pnlPrincipal.Controls.Add(this.icbtnVoltar);
            this.pnlPrincipal.Controls.Add(this.head1);
            this.pnlPrincipal.Controls.Add(this.tbEditora);
            this.pnlPrincipal.Controls.Add(this.label9);
            this.pnlPrincipal.Controls.Add(this.tbGenero);
            this.pnlPrincipal.Controls.Add(this.tbNome);
            this.pnlPrincipal.Controls.Add(this.lblCadastroLivro);
            this.pnlPrincipal.Controls.Add(this.label6);
            this.pnlPrincipal.Controls.Add(this.tbAutor);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.btnCadastrar);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(186, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1035, 584);
            this.pnlPrincipal.TabIndex = 28;
            // 
            // BtnGenero
            // 
            this.BtnGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenero.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenero.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnGenero.IconColor = System.Drawing.Color.White;
            this.BtnGenero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGenero.IconSize = 23;
            this.BtnGenero.Location = new System.Drawing.Point(771, 310);
            this.BtnGenero.Name = "BtnGenero";
            this.BtnGenero.Size = new System.Drawing.Size(36, 27);
            this.BtnGenero.TabIndex = 97;
            this.BtnGenero.UseVisualStyleBackColor = false;
            this.BtnGenero.Click += new System.EventHandler(this.BtnGenero_Click);
            // 
            // BtnEditora
            // 
            this.BtnEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditora.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditora.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnEditora.IconColor = System.Drawing.Color.White;
            this.BtnEditora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditora.IconSize = 23;
            this.BtnEditora.Location = new System.Drawing.Point(770, 266);
            this.BtnEditora.Name = "BtnEditora";
            this.BtnEditora.Size = new System.Drawing.Size(36, 27);
            this.BtnEditora.TabIndex = 96;
            this.BtnEditora.UseVisualStyleBackColor = false;
            this.BtnEditora.Click += new System.EventHandler(this.BtnEditora_Click);
            // 
            // BtnAutor
            // 
            this.BtnAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAutor.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutor.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnAutor.IconColor = System.Drawing.Color.White;
            this.BtnAutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAutor.IconSize = 23;
            this.BtnAutor.Location = new System.Drawing.Point(770, 225);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(36, 27);
            this.BtnAutor.TabIndex = 95;
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // icbtnVoltar
            // 
            this.icbtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtnVoltar.FlatAppearance.BorderSize = 0;
            this.icbtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icbtnVoltar.ForeColor = System.Drawing.Color.White;
            this.icbtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.icbtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.icbtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnVoltar.IconSize = 30;
            this.icbtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnVoltar.Location = new System.Drawing.Point(270, 80);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 72;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // head1
            // 
            this.head1.BackColor = System.Drawing.Color.Black;
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1035, 37);
            this.head1.TabIndex = 28;
            // 
            // tbEditora
            // 
            this.tbEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEditora.Location = new System.Drawing.Point(341, 266);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.PlaceholderText = "Selecione uma editora";
            this.tbEditora.Size = new System.Drawing.Size(423, 27);
            this.tbEditora.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(261, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Gênero:";
            // 
            // tbGenero
            // 
            this.tbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenero.Location = new System.Drawing.Point(341, 309);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.PlaceholderText = "Selecione um gênero";
            this.tbGenero.Size = new System.Drawing.Size(423, 27);
            this.tbGenero.TabIndex = 28;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(342, 183);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(464, 27);
            this.tbNome.TabIndex = 1;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(371, 80);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(378, 39);
            this.lblCadastroLivro.TabIndex = 26;
            this.lblCadastroLivro.Text = "CADASTRO DE LIVRO";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(261, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editora:";
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAutor.Location = new System.Drawing.Point(342, 225);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.PlaceholderText = "Selecione um autor";
            this.tbAutor.Size = new System.Drawing.Size(422, 27);
            this.tbAutor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Olive;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(485, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 45);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "SALVAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // LivrosCadastrarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 590);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LivrosCadastrarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Livros";
            this.Activated += new System.EventHandler(this.LivrosCadastrarView_Activated);
            this.Load += new System.EventHandler(this.LivrosCadastrarView_Load_1);
            this.pnltotal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAquisição;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Util.Head head1;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private FontAwesome.Sharp.IconButton BtnGenero;
        private FontAwesome.Sharp.IconButton BtnEditora;
        private FontAwesome.Sharp.IconButton BtnAutor;
    }
}