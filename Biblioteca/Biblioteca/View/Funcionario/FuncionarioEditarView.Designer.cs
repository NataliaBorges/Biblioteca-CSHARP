
namespace Biblioteca.View.Funcionario {
    partial class FuncionarioEditarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioEditarView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalendarFuncionario = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.head1 = new Biblioteca.Util.Head();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.CalendarFuncionario);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbEditarStatus);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbFuncao);
            this.panel1.Controls.Add(this.maskedTextBoxCPF);
            this.panel1.Controls.Add(this.maskedTextBoxTelefone);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbRua);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(196, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 792);
            this.panel1.TabIndex = 86;
            // 
            // CalendarFuncionario
            // 
            this.CalendarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarFuncionario.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarFuncionario.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarFuncionario.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarFuncionario.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarFuncionario.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarFuncionario.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarFuncionario.Location = new System.Drawing.Point(380, 386);
            this.CalendarFuncionario.Name = "CalendarFuncionario";
            this.CalendarFuncionario.Size = new System.Drawing.Size(236, 27);
            this.CalendarFuncionario.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(649, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 118;
            this.label12.Text = "Status:";
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
            this.cbEditarStatus.Location = new System.Drawing.Point(711, 390);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(147, 28);
            this.cbEditarStatus.TabIndex = 117;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(515, 477);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(217, 45);
            this.btnAtualizar.TabIndex = 115;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(398, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 39);
            this.label10.TabIndex = 113;
            this.label10.Text = "EDITAR COLABORADOR";
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
            this.icbtnVoltar.Location = new System.Drawing.Point(265, 104);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 112;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1092, 37);
            this.head1.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(637, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Função:";
            // 
            // cbFuncao
            // 
            this.cbFuncao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFuncao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Bibliotecário"});
            this.cbFuncao.Location = new System.Drawing.Point(715, 270);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(141, 28);
            this.cbFuncao.TabIndex = 88;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxCPF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(743, 347);
            this.maskedTextBoxCPF.Mask = "999,999,999-99";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(113, 27);
            this.maskedTextBoxCPF.TabIndex = 108;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(745, 309);
            this.maskedTextBoxTelefone.Mask = "(99)99999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(111, 27);
            this.maskedTextBoxTelefone.TabIndex = 107;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(380, 197);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(476, 27);
            this.tbNome.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(662, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Telefone:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(380, 347);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(303, 27);
            this.tbEmail.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "E-mail:";
            // 
            // tbRua
            // 
            this.tbRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRua.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRua.Location = new System.Drawing.Point(380, 234);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(374, 27);
            this.tbRua.TabIndex = 96;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumero.Location = new System.Drawing.Point(804, 234);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(52, 27);
            this.tbNumero.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(266, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Nascimento:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(322, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "Rua:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(760, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Nº:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(299, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(307, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "Bairro:";
            // 
            // tbCidade
            // 
            this.tbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCidade.Location = new System.Drawing.Point(380, 309);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(276, 27);
            this.tbCidade.TabIndex = 101;
            // 
            // tbBairro
            // 
            this.tbBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBairro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBairro.Location = new System.Drawing.Point(380, 271);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(251, 27);
            this.tbBairro.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(689, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "CPF:";
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
            this.pnltotal.Size = new System.Drawing.Size(1291, 798);
            this.pnltotal.TabIndex = 87;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(187, 792);
            this.menuControl1.TabIndex = 87;
            // 
            // FuncionarioEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1291, 798);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioEditarView";
            this.Text = "Editar Funcionário";
            this.Load += new System.EventHandler(this.FuncionarioEditarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFuncao;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.DateTimePicker CalendarFuncionario;
    }
}