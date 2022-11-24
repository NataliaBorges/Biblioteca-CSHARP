
using System;

namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoCadastroView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoCadastroView));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalendarDevolucap = new System.Windows.Forms.DateTimePicker();
            this.CalendarEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TextObservacao = new System.Windows.Forms.RichTextBox();
            this.btnBuscarLivros = new FontAwesome.Sharp.IconButton();
            this.btnBuscarLeitor = new FontAwesome.Sharp.IconButton();
            this.dtGridViewExemplares = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IcnBtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplares)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(614, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "EMPRÉSTIMO:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(616, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "DEVOLUÇÃO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.CalendarDevolucap);
            this.panel1.Controls.Add(this.CalendarEmprestimo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TextObservacao);
            this.panel1.Controls.Add(this.btnBuscarLivros);
            this.panel1.Controls.Add(this.btnBuscarLeitor);
            this.panel1.Controls.Add(this.dtGridViewExemplares);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IcnBtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(196, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 714);
            this.panel1.TabIndex = 18;
            // 
            // CalendarDevolucap
            // 
            this.CalendarDevolucap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarDevolucap.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarDevolucap.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarDevolucap.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarDevolucap.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarDevolucap.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarDevolucap.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarDevolucap.Location = new System.Drawing.Point(740, 523);
            this.CalendarDevolucap.Name = "CalendarDevolucap";
            this.CalendarDevolucap.Size = new System.Drawing.Size(299, 27);
            this.CalendarDevolucap.TabIndex = 107;
            // 
            // CalendarEmprestimo
            // 
            this.CalendarEmprestimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarEmprestimo.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarEmprestimo.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarEmprestimo.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarEmprestimo.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarEmprestimo.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarEmprestimo.Location = new System.Drawing.Point(740, 457);
            this.CalendarEmprestimo.Name = "CalendarEmprestimo";
            this.CalendarEmprestimo.Size = new System.Drawing.Size(299, 27);
            this.CalendarEmprestimo.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(630, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 105;
            this.label9.Text = "Observações";
            // 
            // TextObservacao
            // 
            this.TextObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.TextObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextObservacao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextObservacao.ForeColor = System.Drawing.Color.White;
            this.TextObservacao.Location = new System.Drawing.Point(633, 216);
            this.TextObservacao.Name = "TextObservacao";
            this.TextObservacao.Size = new System.Drawing.Size(406, 120);
            this.TextObservacao.TabIndex = 104;
            this.TextObservacao.Text = "";
            // 
            // btnBuscarLivros
            // 
            this.btnBuscarLivros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarLivros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarLivros.FlatAppearance.BorderSize = 0;
            this.btnBuscarLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLivros.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarLivros.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLivros.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnBuscarLivros.IconColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarLivros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarLivros.IconSize = 30;
            this.btnBuscarLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLivros.Location = new System.Drawing.Point(409, 360);
            this.btnBuscarLivros.Name = "btnBuscarLivros";
            this.btnBuscarLivros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarLivros.Size = new System.Drawing.Size(174, 37);
            this.btnBuscarLivros.TabIndex = 103;
            this.btnBuscarLivros.Tag = "";
            this.btnBuscarLivros.Text = "  Selecionar Livros";
            this.btnBuscarLivros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarLivros.UseVisualStyleBackColor = false;
            this.btnBuscarLivros.Click += new System.EventHandler(this.btnBuscarLivros_Click);
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
            this.btnBuscarLeitor.Location = new System.Drawing.Point(409, 174);
            this.btnBuscarLeitor.Name = "btnBuscarLeitor";
            this.btnBuscarLeitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarLeitor.Size = new System.Drawing.Size(174, 36);
            this.btnBuscarLeitor.TabIndex = 102;
            this.btnBuscarLeitor.Tag = "";
            this.btnBuscarLeitor.Text = "  Selecionar Leitor";
            this.btnBuscarLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLeitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarLeitor.UseVisualStyleBackColor = false;
            this.btnBuscarLeitor.Click += new System.EventHandler(this.btnBuscarLeitor_Click);
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
            this.dtGridViewExemplares.Location = new System.Drawing.Point(99, 403);
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
            this.dtGridViewExemplares.TabIndex = 101;
            this.dtGridViewExemplares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewExemplares_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 100;
            this.label2.Text = "Livros";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leitor";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Olive;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(804, 622);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(213, 45);
            this.btnCadastrar.TabIndex = 99;
            this.btnCadastrar.Text = "SALVAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.lbTelefone);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.lbCpf);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(99, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 120);
            this.panel2.TabIndex = 95;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(267, 49);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(56, 20);
            this.lbTelefone.TabIndex = 8;
            this.lbTelefone.Text = "label10";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(75, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "label10";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCpf.ForeColor = System.Drawing.Color.White;
            this.lbCpf.Location = new System.Drawing.Point(72, 48);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(56, 20);
            this.lbCpf.TabIndex = 6;
            this.lbCpf.Text = "label10";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(72, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(56, 20);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(219, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tel.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
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
            this.IcnBtnVoltar.Location = new System.Drawing.Point(219, 71);
            this.IcnBtnVoltar.Name = "IcnBtnVoltar";
            this.IcnBtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IcnBtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.IcnBtnVoltar.TabIndex = 92;
            this.IcnBtnVoltar.Tag = "";
            this.IcnBtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcnBtnVoltar.UseVisualStyleBackColor = true;
            this.IcnBtnVoltar.Click += new System.EventHandler(this.IcnBtnVoltar_Click);
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(335, 71);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(464, 39);
            this.lblCadastroLivro.TabIndex = 91;
            this.lblCadastroLivro.Text = "CADASTRAR EMPRÉSTIMO";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1093, 37);
            this.head1.TabIndex = 17;
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
            this.pnltotal.Size = new System.Drawing.Size(1292, 720);
            this.pnltotal.TabIndex = 19;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(187, 714);
            this.menuControl1.TabIndex = 19;
            // 
            // EmprestimoCadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 720);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoCadastroView";
            this.Text = "Cadastrar empréstimo";
            this.Activated += new System.EventHandler(this.EmprestimoCadastroView_Activated);
            this.Load += new System.EventHandler(this.EmprestimoCadastroView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplares)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void tbObs_TextChanged(object sender, EventArgs e) {
           
        }

        private void label5_Click(object sender, EventArgs e) {
            
        }

        private void tbDevolucao_TextChanged(object sender, EventArgs e) {
            
        }

        private void tbEmprestimo_TextChanged(object sender, EventArgs e) {
            
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.MenuControl menuControl1;
        private Util.Head head1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridViewExemplares;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox TextObservacao;
        private FontAwesome.Sharp.IconButton btnBuscarLivros;
        private FontAwesome.Sharp.IconButton btnBuscarLeitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker CalendarDevolucap;
        private System.Windows.Forms.DateTimePicker CalendarEmprestimo;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private FontAwesome.Sharp.IconButton IcnBtnVoltar;
    }
}