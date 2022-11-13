namespace Biblioteca.View.Relatorio
{
    partial class RelatorioEditoraView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEditoraView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrarFuncionario = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.BtnAnterior = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvEditora = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.pnltotal.Size = new System.Drawing.Size(1293, 719);
            this.pnltotal.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(196, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 713);
            this.panel1.TabIndex = 59;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 631);
            this.tabControl1.TabIndex = 81;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editora e Quantidade de Títulos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.btnCadastrarFuncionario);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.BtnAnterior);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lvEditora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, -16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 611);
            this.panel2.TabIndex = 80;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnCadastrarFuncionario.IconColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarFuncionario.IconSize = 30;
            this.btnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(936, 555);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(123, 36);
            this.btnCadastrarFuncionario.TabIndex = 94;
            this.btnCadastrarFuncionario.Tag = "";
            this.btnCadastrarFuncionario.Text = "  Imprimir";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton2.Location = new System.Drawing.Point(610, 555);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(89, 31);
            this.iconButton2.TabIndex = 24;
            this.iconButton2.Text = "Próximo";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnterior.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAnterior.ForeColor = System.Drawing.Color.White;
            this.BtnAnterior.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.BtnAnterior.IconColor = System.Drawing.Color.White;
            this.BtnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnterior.IconSize = 20;
            this.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAnterior.Location = new System.Drawing.Point(521, 555);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(89, 31);
            this.BtnAnterior.TabIndex = 23;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnterior.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.tbPesquisar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 108);
            this.panel3.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPesquisar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPesquisar.Location = new System.Drawing.Point(271, 42);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.PlaceholderText = "Digite aqui";
            this.tbPesquisar.Size = new System.Drawing.Size(255, 27);
            this.tbPesquisar.TabIndex = 28;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pesquisar:";
            // 
            // lvEditora
            // 
            this.lvEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvEditora.BackColor = System.Drawing.Color.Black;
            this.lvEditora.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEditora.HideSelection = false;
            this.lvEditora.Location = new System.Drawing.Point(40, 131);
            this.lvEditora.Name = "lvEditora";
            this.lvEditora.Size = new System.Drawing.Size(1019, 418);
            this.lvEditora.TabIndex = 34;
            this.lvEditora.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.tabPage2.Controls.Add(this.iconButton1);
            this.tabPage2.Controls.Add(this.iconButton3);
            this.tabPage2.Controls.Add(this.iconButton4);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1083, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editora e Títulos";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(932, 552);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(123, 36);
            this.iconButton1.TabIndex = 98;
            this.iconButton1.Tag = "";
            this.iconButton1.Text = "  Imprimir";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton3.Location = new System.Drawing.Point(606, 552);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(89, 31);
            this.iconButton3.TabIndex = 96;
            this.iconButton3.Text = "Próximo";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(517, 552);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(89, 31);
            this.iconButton4.TabIndex = 95;
            this.iconButton4.Text = "Anterior";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1019, 418);
            this.listView1.TabIndex = 97;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 93);
            this.panel4.TabIndex = 36;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(601, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(682, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(272, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Digite aqui";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pesquisar:";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1094, 37);
            this.head1.TabIndex = 80;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(497, 40);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(172, 39);
            this.lblCadastroLivro.TabIndex = 77;
            this.lblCadastroLivro.Text = "EDITORA";
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(187, 713);
            this.menuControl1.TabIndex = 60;
            // 
            // RelatorioEditoraView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 719);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioEditoraView";
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private Util.Head head1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvEditora;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnCadastrarFuncionario;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BtnAnterior;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}