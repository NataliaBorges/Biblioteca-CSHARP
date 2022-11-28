﻿
namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoBuscarView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoBuscarView));
            this.rbLeitor = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbStatusEmprestimo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatusExemplar = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbISBN = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.dtFinalizado = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.head1 = new Biblioteca.Util.Head();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmprestimo)).BeginInit();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLeitor
            // 
            this.rbLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLeitor.AutoSize = true;
            this.rbLeitor.BackColor = System.Drawing.Color.Transparent;
            this.rbLeitor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLeitor.ForeColor = System.Drawing.Color.White;
            this.rbLeitor.Location = new System.Drawing.Point(19, 73);
            this.rbLeitor.Name = "rbLeitor";
            this.rbLeitor.Size = new System.Drawing.Size(70, 24);
            this.rbLeitor.TabIndex = 21;
            this.rbLeitor.TabStop = true;
            this.rbLeitor.Text = "Leitor";
            this.rbLeitor.UseVisualStyleBackColor = false;
            this.rbLeitor.CheckedChanged += new System.EventHandler(this.rbLeitor_CheckedChanged);
            // 
            // rbLivro
            // 
            this.rbLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLivro.AutoSize = true;
            this.rbLivro.BackColor = System.Drawing.Color.Transparent;
            this.rbLivro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLivro.ForeColor = System.Drawing.Color.White;
            this.rbLivro.Location = new System.Drawing.Point(172, 48);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(96, 24);
            this.rbLivro.TabIndex = 20;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "Exemplar";
            this.rbLivro.UseVisualStyleBackColor = false;
            this.rbLivro.CheckedChanged += new System.EventHandler(this.rbLivro_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(511, 102);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(421, 27);
            this.tbBuscar.TabIndex = 19;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(219, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 772);
            this.panel1.TabIndex = 25;
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
            this.icbtnVoltar.Location = new System.Drawing.Point(265, 78);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 94;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.dtGridViewEmprestimo);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 598);
            this.panel3.TabIndex = 93;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(985, 533);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 43);
            this.btnEditar.TabIndex = 101;
            this.btnEditar.Text = "VISUALIZAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.dtFinalizado);
            this.panel2.Controls.Add(this.dtFinal);
            this.panel2.Controls.Add(this.dtInicial);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 154);
            this.panel2.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cbStatusEmprestimo);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(422, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 63);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STATUS EMPRÉSTIMO";
            // 
            // cbStatusEmprestimo
            // 
            this.cbStatusEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatusEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatusEmprestimo.FormattingEnabled = true;
            this.cbStatusEmprestimo.Items.AddRange(new object[] {
            "Todos",
            "Em Aberto",
            "Pendente",
            "Finalizado",
            "Cancelado"});
            this.cbStatusEmprestimo.Location = new System.Drawing.Point(29, 26);
            this.cbStatusEmprestimo.Name = "cbStatusEmprestimo";
            this.cbStatusEmprestimo.Size = new System.Drawing.Size(197, 28);
            this.cbStatusEmprestimo.TabIndex = 96;
            this.cbStatusEmprestimo.SelectedIndexChanged += new System.EventHandler(this.cbStatusEmprestimo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbStatusExemplar);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(686, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 63);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS DO EXEMPLAR";
            // 
            // cbStatusExemplar
            // 
            this.cbStatusExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatusExemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatusExemplar.FormattingEnabled = true;
            this.cbStatusExemplar.Items.AddRange(new object[] {
            "Todos",
            "Devolvido",
            "Extraviado",
            "Emprestado"});
            this.cbStatusExemplar.Location = new System.Drawing.Point(29, 21);
            this.cbStatusExemplar.Name = "cbStatusExemplar";
            this.cbStatusExemplar.Size = new System.Drawing.Size(197, 28);
            this.cbStatusExemplar.TabIndex = 96;
            this.cbStatusExemplar.SelectedIndexChanged += new System.EventHandler(this.cbStatusExemplar_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.rbCPF);
            this.groupBox3.Controls.Add(this.rbISBN);
            this.groupBox3.Controls.Add(this.rbLivro);
            this.groupBox3.Controls.Add(this.rbLeitor);
            this.groupBox3.Controls.Add(this.rbCodigo);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(55, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 114);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE BUSCA";
            // 
            // rbCPF
            // 
            this.rbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(19, 48);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(57, 24);
            this.rbCPF.TabIndex = 27;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // rbISBN
            // 
            this.rbISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbISBN.AutoSize = true;
            this.rbISBN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbISBN.ForeColor = System.Drawing.Color.White;
            this.rbISBN.Location = new System.Drawing.Point(172, 77);
            this.rbISBN.Name = "rbISBN";
            this.rbISBN.Size = new System.Drawing.Size(63, 24);
            this.rbISBN.TabIndex = 26;
            this.rbISBN.TabStop = true;
            this.rbISBN.Text = "ISBN";
            this.rbISBN.UseVisualStyleBackColor = true;
            this.rbISBN.CheckedChanged += new System.EventHandler(this.rbISBN_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(89, 21);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(80, 24);
            this.rbCodigo.TabIndex = 25;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // dtFinalizado
            // 
            this.dtFinalizado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFinalizado.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalizado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalizado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalizado.Location = new System.Drawing.Point(1036, 102);
            this.dtFinalizado.Name = "dtFinalizado";
            this.dtFinalizado.Size = new System.Drawing.Size(139, 27);
            this.dtFinalizado.TabIndex = 40;
            this.dtFinalizado.ValueChanged += new System.EventHandler(this.dtFinalizado_ValueChanged);
            // 
            // dtFinal
            // 
            this.dtFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFinal.AutoSize = true;
            this.dtFinal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinal.ForeColor = System.Drawing.Color.White;
            this.dtFinal.Location = new System.Drawing.Point(1036, 79);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(86, 20);
            this.dtFinal.TabIndex = 39;
            this.dtFinal.Text = "Data Final:";
            // 
            // dtInicial
            // 
            this.dtInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInicial.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicial.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dtInicial.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(1036, 31);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(134, 27);
            this.dtInicial.TabIndex = 38;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1036, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Data Inicial: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pesquisar:";
            // 
            // lblNotFound
            // 
            this.lblNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(569, 351);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 95;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4181, 1959);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(4243, 1956);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 28);
            this.cbStatus.TabIndex = 93;
            // 
            // dtGridViewEmprestimo
            // 
            this.dtGridViewEmprestimo.AllowUserToAddRows = false;
            this.dtGridViewEmprestimo.AllowUserToDeleteRows = false;
            this.dtGridViewEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridViewEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewEmprestimo.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewEmprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewEmprestimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewEmprestimo.EnableHeadersVisualStyles = false;
            this.dtGridViewEmprestimo.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewEmprestimo.Location = new System.Drawing.Point(55, 200);
            this.dtGridViewEmprestimo.Name = "dtGridViewEmprestimo";
            this.dtGridViewEmprestimo.ReadOnly = true;
            this.dtGridViewEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewEmprestimo.RowHeadersVisible = false;
            this.dtGridViewEmprestimo.RowTemplate.Height = 25;
            this.dtGridViewEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewEmprestimo.Size = new System.Drawing.Size(1116, 318);
            this.dtGridViewEmprestimo.TabIndex = 30;
            this.dtGridViewEmprestimo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewEmprestimo_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(2993, 1245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 27);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1220, 37);
            this.head1.TabIndex = 92;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(496, 86);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(369, 38);
            this.lblCadastroLivro.TabIndex = 91;
            this.lblCadastroLivro.Text = "BUSCAR EMPRÉSTIMO";
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1442, 778);
            this.pnltotal.TabIndex = 26;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(210, 772);
            this.menuControl1.TabIndex = 26;
            // 
            // EmprestimoBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 778);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmprestimoBuscarView";
            this.Text = "Buscar Empréstimo";
            this.Activated += new System.EventHandler(this.EmprestimoBuscarView_Activated);
            this.Load += new System.EventHandler(this.EmpretimoBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmprestimo)).EndInit();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLeitor;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Label lblCadastroLivro;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dtGridViewEmprestimo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtFinalizado;
        private System.Windows.Forms.Label dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbStatusExemplar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbStatusEmprestimo;
        private System.Windows.Forms.RadioButton rbISBN;
        private System.Windows.Forms.RadioButton rbCPF;
    }
}