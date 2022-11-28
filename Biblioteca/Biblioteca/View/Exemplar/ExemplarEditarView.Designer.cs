namespace Biblioteca.View.Exemplar
{
    partial class ExemplarEditarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExemplarEditarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.CalendarExemplar = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.icBtnSelecionarEdicao = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblBuscaLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnltotal.Controls.Add(this.panel1, 0, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1200, 726);
            this.pnltotal.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblBuscaLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(183, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 720);
            this.panel1.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.tbNome);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbAutor);
            this.groupBox4.Controls.Add(this.tbGenero);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbEditora);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(277, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 196);
            this.groupBox4.TabIndex = 127;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DADOS FIXOS";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Cursor = System.Windows.Forms.Cursors.No;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(36, 45);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(428, 27);
            this.tbNome.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome:";
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAutor.Cursor = System.Windows.Forms.Cursors.No;
            this.tbAutor.Enabled = false;
            this.tbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAutor.Location = new System.Drawing.Point(36, 94);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.ReadOnly = true;
            this.tbAutor.Size = new System.Drawing.Size(428, 27);
            this.tbAutor.TabIndex = 100;
            // 
            // tbGenero
            // 
            this.tbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenero.Cursor = System.Windows.Forms.Cursors.No;
            this.tbGenero.Enabled = false;
            this.tbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenero.Location = new System.Drawing.Point(282, 150);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.ReadOnly = true;
            this.tbGenero.Size = new System.Drawing.Size(182, 27);
            this.tbGenero.TabIndex = 112;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(32, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Autor:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(36, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Editora:";
            // 
            // tbEditora
            // 
            this.tbEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEditora.Cursor = System.Windows.Forms.Cursors.No;
            this.tbEditora.Enabled = false;
            this.tbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEditora.Location = new System.Drawing.Point(36, 150);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.ReadOnly = true;
            this.tbEditora.Size = new System.Drawing.Size(215, 27);
            this.tbEditora.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(280, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Gênero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbEditarStatus);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(254, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 87);
            this.groupBox3.TabIndex = 126;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STATUS";
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
            this.cbEditarStatus.Location = new System.Drawing.Point(17, 42);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(147, 28);
            this.cbEditarStatus.TabIndex = 120;
            // 
            // tbValor
            // 
            this.tbValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbValor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbValor.Location = new System.Drawing.Point(96, 177);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(140, 27);
            this.tbValor.TabIndex = 116;
            // 
            // tbISBN
            // 
            this.tbISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbISBN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbISBN.Location = new System.Drawing.Point(232, 101);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(197, 27);
            this.tbISBN.TabIndex = 107;
            // 
            // CalendarExemplar
            // 
            this.CalendarExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarExemplar.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarExemplar.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarExemplar.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarExemplar.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarExemplar.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarExemplar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarExemplar.Location = new System.Drawing.Point(96, 101);
            this.CalendarExemplar.Name = "CalendarExemplar";
            this.CalendarExemplar.Size = new System.Drawing.Size(113, 27);
            this.CalendarExemplar.TabIndex = 123;
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxAno.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxAno.Location = new System.Drawing.Point(376, 46);
            this.maskedTextBoxAno.Mask = "9999";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(44, 27);
            this.maskedTextBoxAno.TabIndex = 110;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEdicao.Enabled = false;
            this.tbEdicao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEdicao.Location = new System.Drawing.Point(96, 47);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.PlaceholderText = "Selecione uma edição";
            this.tbEdicao.Size = new System.Drawing.Size(221, 27);
            this.tbEdicao.TabIndex = 102;
            // 
            // icBtnSelecionarEdicao
            // 
            this.icBtnSelecionarEdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icBtnSelecionarEdicao.BackColor = System.Drawing.Color.CadetBlue;
            this.icBtnSelecionarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icBtnSelecionarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnSelecionarEdicao.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.icBtnSelecionarEdicao.IconColor = System.Drawing.Color.White;
            this.icBtnSelecionarEdicao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnSelecionarEdicao.IconSize = 23;
            this.icBtnSelecionarEdicao.Location = new System.Drawing.Point(323, 47);
            this.icBtnSelecionarEdicao.Name = "icBtnSelecionarEdicao";
            this.icBtnSelecionarEdicao.Size = new System.Drawing.Size(36, 27);
            this.icBtnSelecionarEdicao.TabIndex = 114;
            this.icBtnSelecionarEdicao.UseVisualStyleBackColor = false;
            this.icBtnSelecionarEdicao.Click += new System.EventHandler(this.icBtnSelecionarEdicao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BackColor = System.Drawing.Color.Olive;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(436, 634);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 45);
            this.btnSalvar.TabIndex = 119;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.icbtnVoltar.Location = new System.Drawing.Point(277, 96);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 90;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // lblBuscaLivro
            // 
            this.lblBuscaLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscaLivro.AutoSize = true;
            this.lblBuscaLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscaLivro.ForeColor = System.Drawing.Color.White;
            this.lblBuscaLivro.Location = new System.Drawing.Point(396, 96);
            this.lblBuscaLivro.Name = "lblBuscaLivro";
            this.lblBuscaLivro.Size = new System.Drawing.Size(334, 39);
            this.lblBuscaLivro.TabIndex = 30;
            this.lblBuscaLivro.Text = "EDITAR EXEMPLAR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1014, 37);
            this.head1.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(174, 720);
            this.menuControl1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.CalendarExemplar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbISBN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBoxAno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEdicao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.icBtnSelecionarEdicao);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(277, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 225);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMAÇÕES DO EXEMPLAR";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Aquisição:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Edição:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(94, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 95;
            this.label9.Text = "Valor:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(376, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 121;
            this.label5.Text = "(Selecione ativo ou inativo)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 122;
            this.label3.Text = "(Em reais (R$))";
            // 
            // ExemplarEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExemplarEditarView";
            this.Text = "ExemplarEditarView";
            this.Activated += new System.EventHandler(this.ExemplarEditarView_Activated);
            this.Load += new System.EventHandler(this.ExemplarEditarView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label lblBuscaLivro;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.TextBox tbValor;
        private FontAwesome.Sharp.IconButton icBtnSelecionarEdicao;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.DateTimePicker CalendarExemplar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}