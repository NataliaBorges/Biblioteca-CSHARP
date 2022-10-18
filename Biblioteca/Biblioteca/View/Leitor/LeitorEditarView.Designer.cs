
namespace Biblioteca.View.Leitor {
    partial class LeitorEditarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeitorEditarView));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalendarLeitor = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(383, 428);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(205, 45);
            this.btnAtualizar.TabIndex = 47;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(624, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 45);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.CalendarLeitor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.maskedTextBoxTelefone);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.maskedTextCPF);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.tbRua);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(195, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 802);
            this.panel1.TabIndex = 62;
            // 
            // CalendarLeitor
            // 
            this.CalendarLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarLeitor.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarLeitor.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarLeitor.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarLeitor.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarLeitor.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarLeitor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarLeitor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarLeitor.Location = new System.Drawing.Point(383, 362);
            this.CalendarLeitor.Name = "CalendarLeitor";
            this.CalendarLeitor.Size = new System.Drawing.Size(151, 27);
            this.CalendarLeitor.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(272, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Nascimento:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(562, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativar",
            "Inativar"});
            this.cbStatus.Location = new System.Drawing.Point(624, 364);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 28);
            this.cbStatus.TabIndex = 89;
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
            this.icbtnVoltar.Location = new System.Drawing.Point(316, 76);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 88;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(483, 76);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(276, 39);
            this.lblCadastroLivro.TabIndex = 87;
            this.lblCadastroLivro.Text = "EDITAR LEITOR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1088, 37);
            this.head1.TabIndex = 86;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(696, 246);
            this.maskedTextBoxTelefone.Mask = "(99)99999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxTelefone.TabIndex = 84;
            // 
            // maskedTextCPF
            // 
            this.maskedTextCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextCPF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextCPF.Location = new System.Drawing.Point(702, 282);
            this.maskedTextCPF.Mask = "999,999,999-99";
            this.maskedTextCPF.Name = "maskedTextCPF";
            this.maskedTextCPF.Size = new System.Drawing.Size(119, 27);
            this.maskedTextCPF.TabIndex = 83;
            // 
            // tbRua
            // 
            this.tbRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRua.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRua.Location = new System.Drawing.Point(383, 211);
            this.tbRua.Margin = new System.Windows.Forms.Padding(4);
            this.tbRua.Name = "tbRua";
            this.tbRua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRua.Size = new System.Drawing.Size(288, 27);
            this.tbRua.TabIndex = 72;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(383, 174);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNome.Size = new System.Drawing.Size(438, 27);
            this.tbNome.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(313, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Rua:";
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumero.Location = new System.Drawing.Point(724, 211);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumero.Size = new System.Drawing.Size(97, 27);
            this.tbNumero.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(685, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Nº:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Telefone: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(313, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Bairro:";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(383, 320);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(438, 27);
            this.tbEmail.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(646, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "E-mail:";
            // 
            // tbBairro
            // 
            this.tbBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBairro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBairro.Location = new System.Drawing.Point(383, 246);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBairro.Size = new System.Drawing.Size(220, 27);
            this.tbBairro.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Cidade: ";
            // 
            // tbCidade
            // 
            this.tbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCidade.Location = new System.Drawing.Point(383, 283);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCidade.Size = new System.Drawing.Size(242, 27);
            this.tbCidade.TabIndex = 77;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1286, 808);
            this.pnltotal.TabIndex = 63;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(186, 802);
            this.menuControl1.TabIndex = 63;
            // 
            // LeitorEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 808);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeitorEditarView";
            this.Text = "Editar Leitor";
            this.Load += new System.EventHandler(this.LeitorEditarView_Load);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextCPF;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCidade;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker CalendarLeitor;
        private System.Windows.Forms.Label label4;
    }
}