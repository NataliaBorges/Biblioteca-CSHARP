﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaCadastroView));
            this.lvLivros = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLeitor = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.calendarReserva = new System.Windows.Forms.MonthCalendar();
            this.tbReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tbObs = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLivros
            // 
            this.lvLivros.BackColor = System.Drawing.Color.Black;
            this.lvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Fornecedor,
            this.Nome,
            this.Autor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.lvLivros.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvLivros.ForeColor = System.Drawing.Color.White;
            this.lvLivros.FullRowSelect = true;
            this.lvLivros.HideSelection = false;
            this.lvLivros.Location = new System.Drawing.Point(30, 133);
            this.lvLivros.Name = "lvLivros";
            this.lvLivros.Size = new System.Drawing.Size(608, 129);
            this.lvLivros.TabIndex = 1;
            this.lvLivros.UseCompatibleStateImageBehavior = false;
            this.lvLivros.View = System.Windows.Forms.View.Details;
            this.lvLivros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLivros_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Editora
            // 
            this.Fornecedor.Text = "Editora";
            this.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fornecedor.Width = 120;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 200;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Autor.Width = 200;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edição.Width = 100;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ano.Width = 100;
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aquisição.Width = 100;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.iconpeople;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(729, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 73);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = global::Biblioteca.Properties.Resources.LivroIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(729, 155);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(80, 61);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(720, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adionar livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(708, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecionar Leitor";
            // 
            // lvLeitor
            // 
            this.lvLeitor.BackColor = System.Drawing.Color.Black;
            this.lvLeitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLeitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLeitor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvLeitor.ForeColor = System.Drawing.Color.White;
            this.lvLeitor.FullRowSelect = true;
            this.lvLeitor.HideSelection = false;
            this.lvLeitor.Location = new System.Drawing.Point(30, 315);
            this.lvLeitor.Name = "lvLeitor";
            this.lvLeitor.Size = new System.Drawing.Size(608, 141);
            this.lvLeitor.TabIndex = 3;
            this.lvLeitor.UseCompatibleStateImageBehavior = false;
            this.lvLeitor.View = System.Windows.Forms.View.Details;
            this.lvLeitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLeitor_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nascimento";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Endereco";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 300;
            // 
            // calendarReserva
            // 
            this.calendarReserva.BackColor = System.Drawing.Color.Black;
            this.calendarReserva.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendarReserva.Location = new System.Drawing.Point(70, 532);
            this.calendarReserva.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.calendarReserva.Name = "calendarReserva";
            this.calendarReserva.TabIndex = 8;
            this.calendarReserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarReserva_DateChanged);
            // 
            // tbReserva
            // 
            this.tbReserva.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReserva.Location = new System.Drawing.Point(70, 509);
            this.tbReserva.Name = "tbReserva";
            this.tbReserva.Size = new System.Drawing.Size(228, 27);
            this.tbReserva.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reserva";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(676, 573);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(192, 46);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbObs
            // 
            this.tbObs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbObs.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbObs.Location = new System.Drawing.Point(368, 509);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(230, 185);
            this.tbObs.TabIndex = 15;
            this.tbObs.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(368, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Observação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.lvLivros);
            this.panel1.Controls.Add(this.lvLeitor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbObs);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbReserva);
            this.panel1.Controls.Add(this.calendarReserva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(188, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 729);
            this.panel1.TabIndex = 18;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(317, 71);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(406, 38);
            this.lblCadastroLivro.TabIndex = 93;
            this.lblCadastroLivro.Text = "CADASTRO DE RESERVA";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(979, 37);
            this.head1.TabIndex = 17;
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
            this.pnltotal.Size = new System.Drawing.Size(1170, 735);
            this.pnltotal.TabIndex = 19;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(179, 729);
            this.menuControl1.TabIndex = 19;
            // 
            // ReservaCadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 735);
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
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvLivros;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvLeitor;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.MonthCalendar calendarReserva;
        private System.Windows.Forms.TextBox tbReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RichTextBox tbObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
    }
}