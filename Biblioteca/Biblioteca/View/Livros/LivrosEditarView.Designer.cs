
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnGenero = new FontAwesome.Sharp.IconButton();
            this.BtnEditora = new FontAwesome.Sharp.IconButton();
            this.BtnAutor = new FontAwesome.Sharp.IconButton();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdicaoLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.BtnGenero);
            this.panel1.Controls.Add(this.BtnEditora);
            this.panel1.Controls.Add(this.BtnAutor);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEdicaoLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.tbEditora);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbGenero);
            this.panel1.Controls.Add(this.tbAutor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbQuantidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(191, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 700);
            this.panel1.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbEditarStatus);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(421, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 102);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 106;
            this.label5.Text = "(Selecione ativo ou inativo)";
            // 
            // cbEditarStatus
            // 
            this.cbEditarStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEditarStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditarStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEditarStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEditarStatus.FormattingEnabled = true;
            this.cbEditarStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEditarStatus.Location = new System.Drawing.Point(23, 56);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(189, 28);
            this.cbEditarStatus.TabIndex = 101;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BackColor = System.Drawing.Color.Olive;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(454, 595);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(178, 45);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnGenero
            // 
            this.BtnGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenero.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenero.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnGenero.IconColor = System.Drawing.Color.White;
            this.BtnGenero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGenero.IconSize = 23;
            this.BtnGenero.Location = new System.Drawing.Point(733, 414);
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
            this.BtnEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditora.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnEditora.IconColor = System.Drawing.Color.White;
            this.BtnEditora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditora.IconSize = 23;
            this.BtnEditora.Location = new System.Drawing.Point(733, 349);
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
            this.BtnAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutor.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnAutor.IconColor = System.Drawing.Color.White;
            this.BtnAutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAutor.IconSize = 23;
            this.BtnAutor.Location = new System.Drawing.Point(733, 285);
            this.BtnAutor.Name = "BtnAutor";
            this.BtnAutor.Size = new System.Drawing.Size(36, 27);
            this.BtnAutor.TabIndex = 95;
            this.BtnAutor.UseVisualStyleBackColor = false;
            this.BtnAutor.Click += new System.EventHandler(this.BtnAutor_Click);
            // 
            // icbtnVoltar
            // 
            this.icbtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnVoltar.FlatAppearance.BorderSize = 0;
            this.icbtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icbtnVoltar.ForeColor = System.Drawing.Color.White;
            this.icbtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.icbtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.icbtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnVoltar.IconSize = 30;
            this.icbtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnVoltar.Location = new System.Drawing.Point(314, 91);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 73;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(320, 225);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(450, 27);
            this.tbNome.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome:";
            // 
            // lblEdicaoLivro
            // 
            this.lblEdicaoLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdicaoLivro.AutoSize = true;
            this.lblEdicaoLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdicaoLivro.ForeColor = System.Drawing.Color.White;
            this.lblEdicaoLivro.Location = new System.Drawing.Point(431, 91);
            this.lblEdicaoLivro.Name = "lblEdicaoLivro";
            this.lblEdicaoLivro.Size = new System.Drawing.Size(260, 39);
            this.lblEdicaoLivro.TabIndex = 51;
            this.lblEdicaoLivro.Text = "EDITAR LIVRO";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1003, 37);
            this.head1.TabIndex = 50;
            // 
            // tbEditora
            // 
            this.tbEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEditora.Enabled = false;
            this.tbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEditora.Location = new System.Drawing.Point(317, 349);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(409, 27);
            this.tbEditora.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(316, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Gênero:";
            // 
            // tbGenero
            // 
            this.tbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenero.Enabled = false;
            this.tbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenero.Location = new System.Drawing.Point(318, 413);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(410, 27);
            this.tbGenero.TabIndex = 45;
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAutor.Enabled = false;
            this.tbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAutor.Location = new System.Drawing.Point(317, 285);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(408, 27);
            this.tbAutor.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Autor:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQuantidade.Enabled = false;
            this.tbQuantidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuantidade.Location = new System.Drawing.Point(895, 95);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.ReadOnly = true;
            this.tbQuantidade.Size = new System.Drawing.Size(46, 27);
            this.tbQuantidade.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(843, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "Qtd.:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(314, 326);
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
            this.pnltotal.Size = new System.Drawing.Size(1197, 706);
            this.pnltotal.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(182, 700);
            this.menuControl1.TabIndex = 29;
            // 
            // LivrosEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1197, 706);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LivrosEditarView";
            this.Text = "Editar Livros";
            this.Activated += new System.EventHandler(this.LivrosEditarView_Activated);
            this.Load += new System.EventHandler(this.LivrosItemView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblEdicaoLivro;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private FontAwesome.Sharp.IconButton BtnGenero;
        private FontAwesome.Sharp.IconButton BtnEditora;
        private FontAwesome.Sharp.IconButton BtnAutor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}