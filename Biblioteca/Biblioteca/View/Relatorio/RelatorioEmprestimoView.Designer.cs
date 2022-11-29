
namespace Biblioteca.View.Relatorio {
    partial class RelatorioEmprestimoView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEmprestimoView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcEmprestimo = new System.Windows.Forms.TabControl();
            this.Empréstimo = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtGridViewEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnImprimirEmprestimo = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.dtFinalEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLeitorEmprestimo = new System.Windows.Forms.RadioButton();
            this.rbCodigoEmprestimo = new System.Windows.Forms.RadioButton();
            this.tbBuscarEmprestimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbStatusExemplarEmprestimo = new System.Windows.Forms.ComboBox();
            this.cbStatusEmprestimo = new System.Windows.Forms.ComboBox();
            this.dtInicialEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.Exemplar = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtGridViewExemplar = new System.Windows.Forms.DataGridView();
            this.btnImprimirExemplar = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFinalExemplar = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLeitorExemplar = new System.Windows.Forms.RadioButton();
            this.rbExemplarExemplar = new System.Windows.Forms.RadioButton();
            this.rbCodigoExemplar = new System.Windows.Forms.RadioButton();
            this.tbBuscarExemplar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cbExemplarExemplar = new System.Windows.Forms.ComboBox();
            this.cbStatusExemplar = new System.Windows.Forms.ComboBox();
            this.dtInicialExemplar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcEmprestimo.SuspendLayout();
            this.Empréstimo.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmprestimo)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Exemplar.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplar)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.pnltotal.Size = new System.Drawing.Size(1320, 787);
            this.pnltotal.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.tcEmprestimo);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(201, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 781);
            this.panel1.TabIndex = 59;
            // 
            // tcEmprestimo
            // 
            this.tcEmprestimo.Controls.Add(this.Empréstimo);
            this.tcEmprestimo.Controls.Add(this.Exemplar);
            this.tcEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tcEmprestimo.HotTrack = true;
            this.tcEmprestimo.Location = new System.Drawing.Point(0, 37);
            this.tcEmprestimo.Multiline = true;
            this.tcEmprestimo.Name = "tcEmprestimo";
            this.tcEmprestimo.SelectedIndex = 0;
            this.tcEmprestimo.Size = new System.Drawing.Size(1116, 744);
            this.tcEmprestimo.TabIndex = 81;
            // 
            // Empréstimo
            // 
            this.Empréstimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(17)))));
            this.Empréstimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Empréstimo.Controls.Add(this.label19);
            this.Empréstimo.Controls.Add(this.panel10);
            this.Empréstimo.Controls.Add(this.panel3);
            this.Empréstimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empréstimo.Location = new System.Drawing.Point(4, 30);
            this.Empréstimo.Name = "Empréstimo";
            this.Empréstimo.Size = new System.Drawing.Size(1108, 710);
            this.Empréstimo.TabIndex = 5;
            this.Empréstimo.Text = "Empréstimo";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(345, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(505, 39);
            this.label19.TabIndex = 82;
            this.label19.Text = "RELATÓRIO DE EMPRÉSTIMO";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.dtGridViewEmprestimo);
            this.panel10.Controls.Add(this.btnImprimirEmprestimo);
            this.panel10.Location = new System.Drawing.Point(67, 202);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(981, 509);
            this.panel10.TabIndex = 37;
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
            this.dtGridViewEmprestimo.Location = new System.Drawing.Point(3, 3);
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
            this.dtGridViewEmprestimo.Size = new System.Drawing.Size(975, 412);
            this.dtGridViewEmprestimo.TabIndex = 98;
            // 
            // btnImprimirEmprestimo
            // 
            this.btnImprimirEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(154)))), ((int)(((byte)(107)))));
            this.btnImprimirEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnImprimirEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.btnImprimirEmprestimo.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirEmprestimo.IconColor = System.Drawing.Color.Black;
            this.btnImprimirEmprestimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirEmprestimo.IconSize = 30;
            this.btnImprimirEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirEmprestimo.Location = new System.Drawing.Point(855, 429);
            this.btnImprimirEmprestimo.Name = "btnImprimirEmprestimo";
            this.btnImprimirEmprestimo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImprimirEmprestimo.Size = new System.Drawing.Size(123, 36);
            this.btnImprimirEmprestimo.TabIndex = 97;
            this.btnImprimirEmprestimo.Tag = "";
            this.btnImprimirEmprestimo.Text = "  Imprimir";
            this.btnImprimirEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirEmprestimo.UseVisualStyleBackColor = false;
            this.btnImprimirEmprestimo.Click += new System.EventHandler(this.btnImprimirEmprestimo_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(66)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.label41);
            this.panel3.Controls.Add(this.dtFinalEmprestimo);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.tbBuscarEmprestimo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbStatusExemplarEmprestimo);
            this.panel3.Controls.Add(this.cbStatusEmprestimo);
            this.panel3.Controls.Add(this.dtInicialEmprestimo);
            this.panel3.Location = new System.Drawing.Point(1, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 99);
            this.panel3.TabIndex = 36;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(260, 28);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 20);
            this.label41.TabIndex = 127;
            this.label41.Text = "Pesquisar";
            // 
            // dtFinalEmprestimo
            // 
            this.dtFinalEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFinalEmprestimo.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalEmprestimo.Location = new System.Drawing.Point(658, 72);
            this.dtFinalEmprestimo.Name = "dtFinalEmprestimo";
            this.dtFinalEmprestimo.Size = new System.Drawing.Size(139, 27);
            this.dtFinalEmprestimo.TabIndex = 123;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.rbLeitorEmprestimo);
            this.groupBox3.Controls.Add(this.rbCodigoEmprestimo);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(66, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 88);
            this.groupBox3.TabIndex = 126;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE BUSCA";
            // 
            // rbLeitorEmprestimo
            // 
            this.rbLeitorEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLeitorEmprestimo.AutoSize = true;
            this.rbLeitorEmprestimo.BackColor = System.Drawing.Color.Transparent;
            this.rbLeitorEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLeitorEmprestimo.ForeColor = System.Drawing.Color.White;
            this.rbLeitorEmprestimo.Location = new System.Drawing.Point(19, 24);
            this.rbLeitorEmprestimo.Name = "rbLeitorEmprestimo";
            this.rbLeitorEmprestimo.Size = new System.Drawing.Size(70, 24);
            this.rbLeitorEmprestimo.TabIndex = 115;
            this.rbLeitorEmprestimo.TabStop = true;
            this.rbLeitorEmprestimo.Text = "Leitor";
            this.rbLeitorEmprestimo.UseVisualStyleBackColor = false;
            this.rbLeitorEmprestimo.CheckedChanged += new System.EventHandler(this.rbLeitorEmprestimo_CheckedChanged);
            // 
            // rbCodigoEmprestimo
            // 
            this.rbCodigoEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCodigoEmprestimo.AutoSize = true;
            this.rbCodigoEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCodigoEmprestimo.ForeColor = System.Drawing.Color.White;
            this.rbCodigoEmprestimo.Location = new System.Drawing.Point(19, 54);
            this.rbCodigoEmprestimo.Name = "rbCodigoEmprestimo";
            this.rbCodigoEmprestimo.Size = new System.Drawing.Size(80, 24);
            this.rbCodigoEmprestimo.TabIndex = 116;
            this.rbCodigoEmprestimo.TabStop = true;
            this.rbCodigoEmprestimo.Text = "Código";
            this.rbCodigoEmprestimo.UseVisualStyleBackColor = true;
            this.rbCodigoEmprestimo.CheckedChanged += new System.EventHandler(this.rbCodigoEmprestimo_CheckedChanged);
            // 
            // tbBuscarEmprestimo
            // 
            this.tbBuscarEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscarEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscarEmprestimo.Location = new System.Drawing.Point(260, 49);
            this.tbBuscarEmprestimo.Name = "tbBuscarEmprestimo";
            this.tbBuscarEmprestimo.PlaceholderText = "Digite aqui";
            this.tbBuscarEmprestimo.Size = new System.Drawing.Size(364, 27);
            this.tbBuscarEmprestimo.TabIndex = 113;
            this.tbBuscarEmprestimo.TextChanged += new System.EventHandler(this.tbBuscarEmprestimo_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(863, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(863, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Exemplar:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(658, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 120;
            this.label17.Text = "Data Inicial: ";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(658, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 122;
            this.label18.Text = "Data Final:";
            // 
            // cbStatusExemplarEmprestimo
            // 
            this.cbStatusExemplarEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatusExemplarEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusExemplarEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatusExemplarEmprestimo.FormattingEnabled = true;
            this.cbStatusExemplarEmprestimo.Items.AddRange(new object[] {
            "Todos",
            "Devolvido",
            "Extraviado",
            "Emprestado"});
            this.cbStatusExemplarEmprestimo.Location = new System.Drawing.Point(863, 71);
            this.cbStatusExemplarEmprestimo.Name = "cbStatusExemplarEmprestimo";
            this.cbStatusExemplarEmprestimo.Size = new System.Drawing.Size(184, 28);
            this.cbStatusExemplarEmprestimo.TabIndex = 112;
            this.cbStatusExemplarEmprestimo.SelectedIndexChanged += new System.EventHandler(this.cbStatusExemplarEmprestimo_SelectedIndexChanged);
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
            this.cbStatusEmprestimo.Location = new System.Drawing.Point(863, 21);
            this.cbStatusEmprestimo.Name = "cbStatusEmprestimo";
            this.cbStatusEmprestimo.Size = new System.Drawing.Size(184, 28);
            this.cbStatusEmprestimo.TabIndex = 124;
            this.cbStatusEmprestimo.SelectedIndexChanged += new System.EventHandler(this.cbStatusEmprestimo_SelectedIndexChanged);
            // 
            // dtInicialEmprestimo
            // 
            this.dtInicialEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInicialEmprestimo.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicialEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicialEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicialEmprestimo.Location = new System.Drawing.Point(658, 22);
            this.dtInicialEmprestimo.Name = "dtInicialEmprestimo";
            this.dtInicialEmprestimo.Size = new System.Drawing.Size(134, 27);
            this.dtInicialEmprestimo.TabIndex = 121;
            // 
            // Exemplar
            // 
            this.Exemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(17)))));
            this.Exemplar.Controls.Add(this.panel5);
            this.Exemplar.Controls.Add(this.panel4);
            this.Exemplar.Controls.Add(this.label5);
            this.Exemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exemplar.Location = new System.Drawing.Point(4, 30);
            this.Exemplar.Name = "Exemplar";
            this.Exemplar.Padding = new System.Windows.Forms.Padding(3);
            this.Exemplar.Size = new System.Drawing.Size(1108, 710);
            this.Exemplar.TabIndex = 1;
            this.Exemplar.Text = "Exemplar";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.dtGridViewExemplar);
            this.panel5.Controls.Add(this.btnImprimirExemplar);
            this.panel5.Location = new System.Drawing.Point(67, 202);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(981, 509);
            this.panel5.TabIndex = 85;
            // 
            // dtGridViewExemplar
            // 
            this.dtGridViewExemplar.AllowUserToAddRows = false;
            this.dtGridViewExemplar.AllowUserToDeleteRows = false;
            this.dtGridViewExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridViewExemplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewExemplar.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewExemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewExemplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewExemplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridViewExemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewExemplar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridViewExemplar.EnableHeadersVisualStyles = false;
            this.dtGridViewExemplar.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewExemplar.Location = new System.Drawing.Point(6, 3);
            this.dtGridViewExemplar.Name = "dtGridViewExemplar";
            this.dtGridViewExemplar.ReadOnly = true;
            this.dtGridViewExemplar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridViewExemplar.RowHeadersVisible = false;
            this.dtGridViewExemplar.RowTemplate.Height = 25;
            this.dtGridViewExemplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewExemplar.Size = new System.Drawing.Size(975, 412);
            this.dtGridViewExemplar.TabIndex = 106;
            // 
            // btnImprimirExemplar
            // 
            this.btnImprimirExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirExemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(154)))), ((int)(((byte)(107)))));
            this.btnImprimirExemplar.FlatAppearance.BorderSize = 0;
            this.btnImprimirExemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirExemplar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirExemplar.ForeColor = System.Drawing.Color.Black;
            this.btnImprimirExemplar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirExemplar.IconColor = System.Drawing.Color.Black;
            this.btnImprimirExemplar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirExemplar.IconSize = 30;
            this.btnImprimirExemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirExemplar.Location = new System.Drawing.Point(855, 433);
            this.btnImprimirExemplar.Name = "btnImprimirExemplar";
            this.btnImprimirExemplar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImprimirExemplar.Size = new System.Drawing.Size(123, 36);
            this.btnImprimirExemplar.TabIndex = 105;
            this.btnImprimirExemplar.Tag = "";
            this.btnImprimirExemplar.Text = "  Imprimir";
            this.btnImprimirExemplar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirExemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirExemplar.UseVisualStyleBackColor = false;
            this.btnImprimirExemplar.Click += new System.EventHandler(this.btnImprimirExemplar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(66)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtFinalExemplar);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.tbBuscarExemplar);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.cbExemplarExemplar);
            this.panel4.Controls.Add(this.cbStatusExemplar);
            this.panel4.Controls.Add(this.dtInicialExemplar);
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1108, 99);
            this.panel4.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(258, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 149;
            this.label8.Text = "Pesquisar";
            // 
            // dtFinalExemplar
            // 
            this.dtFinalExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFinalExemplar.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFinalExemplar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalExemplar.Location = new System.Drawing.Point(656, 72);
            this.dtFinalExemplar.Name = "dtFinalExemplar";
            this.dtFinalExemplar.Size = new System.Drawing.Size(139, 27);
            this.dtFinalExemplar.TabIndex = 145;
            this.dtFinalExemplar.ValueChanged += new System.EventHandler(this.dtFinalExemplar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.rbLeitorExemplar);
            this.groupBox2.Controls.Add(this.rbExemplarExemplar);
            this.groupBox2.Controls.Add(this.rbCodigoExemplar);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(64, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 91);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO DE BUSCA";
            // 
            // rbLeitorExemplar
            // 
            this.rbLeitorExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLeitorExemplar.AutoSize = true;
            this.rbLeitorExemplar.BackColor = System.Drawing.Color.Transparent;
            this.rbLeitorExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLeitorExemplar.ForeColor = System.Drawing.Color.White;
            this.rbLeitorExemplar.Location = new System.Drawing.Point(19, 21);
            this.rbLeitorExemplar.Name = "rbLeitorExemplar";
            this.rbLeitorExemplar.Size = new System.Drawing.Size(70, 24);
            this.rbLeitorExemplar.TabIndex = 117;
            this.rbLeitorExemplar.TabStop = true;
            this.rbLeitorExemplar.Text = "Leitor";
            this.rbLeitorExemplar.UseVisualStyleBackColor = false;
            this.rbLeitorExemplar.CheckedChanged += new System.EventHandler(this.rbLeitorExemplar_CheckedChanged);
            // 
            // rbExemplarExemplar
            // 
            this.rbExemplarExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbExemplarExemplar.AutoSize = true;
            this.rbExemplarExemplar.BackColor = System.Drawing.Color.Transparent;
            this.rbExemplarExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbExemplarExemplar.ForeColor = System.Drawing.Color.White;
            this.rbExemplarExemplar.Location = new System.Drawing.Point(19, 43);
            this.rbExemplarExemplar.Name = "rbExemplarExemplar";
            this.rbExemplarExemplar.Size = new System.Drawing.Size(96, 24);
            this.rbExemplarExemplar.TabIndex = 115;
            this.rbExemplarExemplar.TabStop = true;
            this.rbExemplarExemplar.Text = "Exemplar";
            this.rbExemplarExemplar.UseVisualStyleBackColor = false;
            this.rbExemplarExemplar.CheckedChanged += new System.EventHandler(this.rbExemplarExemplar_CheckedChanged);
            // 
            // rbCodigoExemplar
            // 
            this.rbCodigoExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCodigoExemplar.AutoSize = true;
            this.rbCodigoExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCodigoExemplar.ForeColor = System.Drawing.Color.White;
            this.rbCodigoExemplar.Location = new System.Drawing.Point(19, 64);
            this.rbCodigoExemplar.Name = "rbCodigoExemplar";
            this.rbCodigoExemplar.Size = new System.Drawing.Size(80, 24);
            this.rbCodigoExemplar.TabIndex = 116;
            this.rbCodigoExemplar.TabStop = true;
            this.rbCodigoExemplar.Text = "Código";
            this.rbCodigoExemplar.UseVisualStyleBackColor = true;
            this.rbCodigoExemplar.CheckedChanged += new System.EventHandler(this.rbCodigoExemplar_CheckedChanged);
            // 
            // tbBuscarExemplar
            // 
            this.tbBuscarExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscarExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscarExemplar.Location = new System.Drawing.Point(258, 49);
            this.tbBuscarExemplar.Name = "tbBuscarExemplar";
            this.tbBuscarExemplar.PlaceholderText = "Digite aqui";
            this.tbBuscarExemplar.Size = new System.Drawing.Size(364, 27);
            this.tbBuscarExemplar.TabIndex = 140;
            this.tbBuscarExemplar.TextChanged += new System.EventHandler(this.tbBuscarExemplar_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(861, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 147;
            this.label12.Text = "Status:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(861, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 141;
            this.label13.Text = "Exemplar:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(656, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 142;
            this.label14.Text = "Data Inicial: ";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(656, 52);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(86, 20);
            this.label43.TabIndex = 144;
            this.label43.Text = "Data Final:";
            // 
            // cbExemplarExemplar
            // 
            this.cbExemplarExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbExemplarExemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExemplarExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbExemplarExemplar.FormattingEnabled = true;
            this.cbExemplarExemplar.Items.AddRange(new object[] {
            "Todos",
            "Devolvido",
            "Extraviado",
            "Emprestado"});
            this.cbExemplarExemplar.Location = new System.Drawing.Point(861, 71);
            this.cbExemplarExemplar.Name = "cbExemplarExemplar";
            this.cbExemplarExemplar.Size = new System.Drawing.Size(184, 28);
            this.cbExemplarExemplar.TabIndex = 139;
            this.cbExemplarExemplar.SelectedIndexChanged += new System.EventHandler(this.cbExemplarExemplar_SelectedIndexChanged);
            // 
            // cbStatusExemplar
            // 
            this.cbStatusExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatusExemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatusExemplar.FormattingEnabled = true;
            this.cbStatusExemplar.Items.AddRange(new object[] {
            "Todos",
            "Em Aberto",
            "Pendente",
            "Finalizado",
            "Cancelado"});
            this.cbStatusExemplar.Location = new System.Drawing.Point(861, 21);
            this.cbStatusExemplar.Name = "cbStatusExemplar";
            this.cbStatusExemplar.Size = new System.Drawing.Size(184, 28);
            this.cbStatusExemplar.TabIndex = 146;
            this.cbStatusExemplar.SelectedIndexChanged += new System.EventHandler(this.cbStatusExemplar_SelectedIndexChanged);
            // 
            // dtInicialExemplar
            // 
            this.dtInicialExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInicialExemplar.CalendarFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicialExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtInicialExemplar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicialExemplar.Location = new System.Drawing.Point(656, 22);
            this.dtInicialExemplar.Name = "dtInicialExemplar";
            this.dtInicialExemplar.Size = new System.Drawing.Size(134, 27);
            this.dtInicialExemplar.TabIndex = 143;
            this.dtInicialExemplar.ValueChanged += new System.EventHandler(this.dtInicialExemplar_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(177, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(772, 39);
            this.label5.TabIndex = 83;
            this.label5.Text = "RELATÓRIO DE EMPRÉSTIMO POR EXEMPLAR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1116, 37);
            this.head1.TabIndex = 80;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(192, 781);
            this.menuControl1.TabIndex = 60;
            // 
            // RelatorioEmprestimoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 787);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioEmprestimoView";
            this.Text = "Relatório de Empréstimo";
            this.Load += new System.EventHandler(this.RelatorioEmprestimoView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tcEmprestimo.ResumeLayout(false);
            this.Empréstimo.ResumeLayout(false);
            this.Empréstimo.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmprestimo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Exemplar.ResumeLayout(false);
            this.Exemplar.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcEmprestimo;
        private System.Windows.Forms.TabPage Livro;
        private System.Windows.Forms.TabPage Exemplar;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage Empréstimo;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnImprimirEmprestimo;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnImprimirLivro;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnImprimirExemplar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFinalEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbStatusEmprestimo;
        private System.Windows.Forms.RadioButton rbCodigoEmprestimo;
        private System.Windows.Forms.DateTimePicker dtInicialEmprestimo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbLeitorEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatusExemplarEmprestimo;
        private System.Windows.Forms.TextBox tbBuscarEmprestimo;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFinalLivro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLivroLivro;
        private System.Windows.Forms.RadioButton rbLivroCodigo;
        private System.Windows.Forms.TextBox tbBuscarLivro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cbExemplarLivro;
        private System.Windows.Forms.ComboBox cbStatusLivro;
        private System.Windows.Forms.DateTimePicker dtInicialLivro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFinalExemplar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLeitorExemplar;
        private System.Windows.Forms.RadioButton rbExemplarExemplar;
        private System.Windows.Forms.RadioButton rbCodigoExemplar;
        private System.Windows.Forms.TextBox tbBuscarExemplar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbExemplarExemplar;
        private System.Windows.Forms.ComboBox cbStatusExemplar;
        private System.Windows.Forms.DateTimePicker dtInicialExemplar;
        private System.Windows.Forms.DataGridView dtGridViewEmprestimo;
        private System.Windows.Forms.DataGridView dtGridViewLivro;
        private System.Windows.Forms.DataGridView dtGridViewExemplar;
    }
}