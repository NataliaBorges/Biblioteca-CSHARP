
namespace Biblioteca.View.Reserva {
    partial class ReservaCadastroView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaCadastroView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IcnBtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalendarDevolucap = new System.Windows.Forms.DateTimePicker();
            this.CalendarEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlLeitor = new System.Windows.Forms.Panel();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarLivros = new FontAwesome.Sharp.IconButton();
            this.dtGridViewExemplares = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.btnBuscarLeitor = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLeitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplares)).BeginInit();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.IcnBtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 720);
            this.panel1.TabIndex = 18;
            // 
            // IcnBtnVoltar
            // 
            this.IcnBtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IcnBtnVoltar.FlatAppearance.BorderSize = 0;
            this.IcnBtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcnBtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IcnBtnVoltar.ForeColor = System.Drawing.Color.White;
            this.IcnBtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcnBtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.IcnBtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnBtnVoltar.IconSize = 30;
            this.IcnBtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcnBtnVoltar.Location = new System.Drawing.Point(249, 86);
            this.IcnBtnVoltar.Name = "IcnBtnVoltar";
            this.IcnBtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IcnBtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.IcnBtnVoltar.TabIndex = 94;
            this.IcnBtnVoltar.Tag = "";
            this.IcnBtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcnBtnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(366, 86);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(393, 39);
            this.lblCadastroLivro.TabIndex = 93;
            this.lblCadastroLivro.Text = "CADASTRAR RESERVA";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1083, 37);
            this.head1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(39)))), ((int)(((byte)(2)))));
            this.panel2.Controls.Add(this.btnBuscarLeitor);
            this.panel2.Controls.Add(this.CalendarDevolucap);
            this.panel2.Controls.Add(this.CalendarEmprestimo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pnlLeitor);
            this.panel2.Controls.Add(this.btnBuscarLivros);
            this.panel2.Controls.Add(this.dtGridViewExemplares);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 582);
            this.panel2.TabIndex = 96;
            // 
            // CalendarDevolucap
            // 
            this.CalendarDevolucap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarDevolucap.CalendarForeColor = System.Drawing.Color.White;
            this.CalendarDevolucap.CalendarMonthBackground = System.Drawing.Color.Black;
            this.CalendarDevolucap.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.CalendarDevolucap.CalendarTitleForeColor = System.Drawing.Color.White;
            this.CalendarDevolucap.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarDevolucap.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CalendarDevolucap.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarDevolucap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarDevolucap.Location = new System.Drawing.Point(826, 219);
            this.CalendarDevolucap.Name = "CalendarDevolucap";
            this.CalendarDevolucap.Size = new System.Drawing.Size(135, 27);
            this.CalendarDevolucap.TabIndex = 115;
            // 
            // CalendarEmprestimo
            // 
            this.CalendarEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarEmprestimo.CalendarForeColor = System.Drawing.Color.White;
            this.CalendarEmprestimo.CalendarMonthBackground = System.Drawing.Color.Black;
            this.CalendarEmprestimo.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.CalendarEmprestimo.CalendarTitleForeColor = System.Drawing.Color.White;
            this.CalendarEmprestimo.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarEmprestimo.CustomFormat = "";
            this.CalendarEmprestimo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CalendarEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarEmprestimo.Location = new System.Drawing.Point(826, 153);
            this.CalendarEmprestimo.Name = "CalendarEmprestimo";
            this.CalendarEmprestimo.Size = new System.Drawing.Size(135, 27);
            this.CalendarEmprestimo.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(737, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "RETIRAR:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(683, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 112;
            this.label9.Text = "DATA RESERVA:";
            // 
            // pnlLeitor
            // 
            this.pnlLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLeitor.BackColor = System.Drawing.Color.Black;
            this.pnlLeitor.Controls.Add(this.lbTelefone);
            this.pnlLeitor.Controls.Add(this.lbEmail);
            this.pnlLeitor.Controls.Add(this.lbCpf);
            this.pnlLeitor.Controls.Add(this.lbNome);
            this.pnlLeitor.Controls.Add(this.label8);
            this.pnlLeitor.Controls.Add(this.label7);
            this.pnlLeitor.Controls.Add(this.label6);
            this.pnlLeitor.Controls.Add(this.label5);
            this.pnlLeitor.Location = new System.Drawing.Point(60, 98);
            this.pnlLeitor.Name = "pnlLeitor";
            this.pnlLeitor.Size = new System.Drawing.Size(484, 143);
            this.pnlLeitor.TabIndex = 111;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(266, 61);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(56, 20);
            this.lbTelefone.TabIndex = 16;
            this.lbTelefone.Text = "label10";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(74, 94);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "label10";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCpf.ForeColor = System.Drawing.Color.White;
            this.lbCpf.Location = new System.Drawing.Point(71, 60);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(56, 20);
            this.lbCpf.TabIndex = 14;
            this.lbCpf.Text = "label10";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(71, 27);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(56, 20);
            this.lbNome.TabIndex = 13;
            this.lbNome.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(218, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tel.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome:";
            // 
            // btnBuscarLivros
            // 
            this.btnBuscarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
            this.btnBuscarLivros.FlatAppearance.BorderSize = 0;
            this.btnBuscarLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLivros.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarLivros.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLivros.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnBuscarLivros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(114)))), ((int)(((byte)(10)))));
            this.btnBuscarLivros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLivros.IconSize = 30;
            this.btnBuscarLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLivros.Location = new System.Drawing.Point(370, 305);
            this.btnBuscarLivros.Name = "btnBuscarLivros";
            this.btnBuscarLivros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarLivros.Size = new System.Drawing.Size(174, 37);
            this.btnBuscarLivros.TabIndex = 106;
            this.btnBuscarLivros.Tag = "";
            this.btnBuscarLivros.Text = "  Selecionar Livros";
            this.btnBuscarLivros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarLivros.UseVisualStyleBackColor = false;
            // 
            // dtGridViewExemplares
            // 
            this.dtGridViewExemplares.AllowUserToAddRows = false;
            this.dtGridViewExemplares.AllowUserToDeleteRows = false;
            this.dtGridViewExemplares.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridViewExemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewExemplares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.dtGridViewExemplares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewExemplares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewExemplares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewExemplares.ColumnHeadersHeight = 30;
            this.dtGridViewExemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewExemplares.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewExemplares.EnableHeadersVisualStyles = false;
            this.dtGridViewExemplares.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewExemplares.Location = new System.Drawing.Point(60, 348);
            this.dtGridViewExemplares.Name = "dtGridViewExemplares";
            this.dtGridViewExemplares.ReadOnly = true;
            this.dtGridViewExemplares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplares.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewExemplares.RowHeadersVisible = false;
            this.dtGridViewExemplares.RowTemplate.Height = 25;
            this.dtGridViewExemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewExemplares.Size = new System.Drawing.Size(484, 182);
            this.dtGridViewExemplares.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Livros";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Olive;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(748, 424);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(213, 45);
            this.btnCadastrar.TabIndex = 100;
            this.btnCadastrar.Text = "SALVAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81197F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.18803F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1293, 726);
            this.pnltotal.TabIndex = 19;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(198, 720);
            this.menuControl1.TabIndex = 19;
            // 
            // btnBuscarLeitor
            // 
            this.btnBuscarLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarLeitor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarLeitor.FlatAppearance.BorderSize = 0;
            this.btnBuscarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLeitor.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarLeitor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLeitor.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnBuscarLeitor.IconColor = System.Drawing.Color.LightBlue;
            this.btnBuscarLeitor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLeitor.IconSize = 30;
            this.btnBuscarLeitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLeitor.Location = new System.Drawing.Point(370, 58);
            this.btnBuscarLeitor.Name = "btnBuscarLeitor";
            this.btnBuscarLeitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarLeitor.Size = new System.Drawing.Size(174, 36);
            this.btnBuscarLeitor.TabIndex = 116;
            this.btnBuscarLeitor.Tag = "";
            this.btnBuscarLeitor.Text = "  Selecionar Leitor";
            this.btnBuscarLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLeitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarLeitor.UseVisualStyleBackColor = false;
            // 
            // ReservaCadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 726);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaCadastroView";
            this.Text = "Cadastrar reserva";
            this.Load += new System.EventHandler(this.ReservaCadastroView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLeitor.ResumeLayout(false);
            this.pnlLeitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplares)).EndInit();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private FontAwesome.Sharp.IconButton IcnBtnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private FontAwesome.Sharp.IconButton btnBuscarLivros;
        private System.Windows.Forms.DataGridView dtGridViewExemplares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLeitor;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker CalendarDevolucap;
        private System.Windows.Forms.DateTimePicker CalendarEmprestimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnBuscarLeitor;
    }
}