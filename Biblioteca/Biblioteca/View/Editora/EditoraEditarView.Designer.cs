
namespace Biblioteca.View.Editora {
    partial class EditoraEditarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditoraEditarView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbEditarStatus);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maskedTextBoxCNPJ);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.maskedTextBoxTelefone);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbRua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCidade);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(186, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 759);
            this.panel1.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(514, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Status:";
            // 
            // cbEditarStatus
            // 
            this.cbEditarStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditarStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEditarStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEditarStatus.FormattingEnabled = true;
            this.cbEditarStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEditarStatus.Location = new System.Drawing.Point(572, 387);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(147, 28);
            this.cbEditarStatus.TabIndex = 99;
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
            this.icbtnVoltar.Location = new System.Drawing.Point(219, 121);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 92;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(405, 454);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(187, 45);
            this.btnAtualizar.TabIndex = 90;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(356, 121);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(308, 39);
            this.lblCadastroLivro.TabIndex = 89;
            this.lblCadastroLivro.Text = "EDITAR EDITORA";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(928, 37);
            this.head1.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Email:";
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(572, 344);
            this.maskedTextBoxCNPJ.Mask = "99,999,999/9999-99";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(147, 27);
            this.maskedTextBoxCNPJ.TabIndex = 87;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(281, 387);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(230, 27);
            this.tbEmail.TabIndex = 74;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(602, 304);
            this.maskedTextBoxTelefone.Mask = "(99)99999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(117, 27);
            this.maskedTextBoxTelefone.TabIndex = 86;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(281, 226);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(438, 27);
            this.tbNome.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(216, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Cidade:";
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRua.Location = new System.Drawing.Point(281, 263);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(295, 27);
            this.tbRua.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(517, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(216, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Rua:";
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCidade.Location = new System.Drawing.Point(281, 344);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(230, 27);
            this.tbCidade.TabIndex = 84;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumero.Location = new System.Drawing.Point(619, 263);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 27);
            this.tbNumero.TabIndex = 80;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBairro.Location = new System.Drawing.Point(281, 304);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(230, 27);
            this.tbBairro.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(514, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(582, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Nº:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(216, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Bairro:";
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.38317F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.61683F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1117, 765);
            this.pnltotal.TabIndex = 72;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(177, 759);
            this.menuControl1.TabIndex = 72;
            // 
            // EditoraEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1117, 765);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditoraEditarView";
            this.Text = "Editar Editora";
            this.Load += new System.EventHandler(this.EditoraEditarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.Button btnAtualizar;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEditarStatus;
    }
}