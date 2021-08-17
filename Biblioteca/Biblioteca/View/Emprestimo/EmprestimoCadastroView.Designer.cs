
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoCadastroView));
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
            this.calendarEmprestimo = new System.Windows.Forms.MonthCalendar();
            this.calendarDevolucao = new System.Windows.Forms.MonthCalendar();
            this.tbEmprestimo = new System.Windows.Forms.TextBox();
            this.tbDevolucao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbObs = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLivros
            // 
            this.lvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Fornecedor,
            this.Nome,
            this.Autor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.lvLivros.FullRowSelect = true;
            this.lvLivros.HideSelection = false;
            this.lvLivros.Location = new System.Drawing.Point(13, 47);
            this.lvLivros.Name = "lvLivros";
            this.lvLivros.Size = new System.Drawing.Size(551, 121);
            this.lvLivros.TabIndex = 1;
            this.lvLivros.UseCompatibleStateImageBehavior = false;
            this.lvLivros.View = System.Windows.Forms.View.Details;
            this.lvLivros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLivros_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 100;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Aquisição.Width = 80;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.iconpeople;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(607, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 99);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = global::Biblioteca.Properties.Resources.LivroIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(607, 63);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(134, 88);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adionar livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecionar Leitor";
            // 
            // lvLeitor
            // 
            this.lvLeitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLeitor.FullRowSelect = true;
            this.lvLeitor.HideSelection = false;
            this.lvLeitor.Location = new System.Drawing.Point(13, 235);
            this.lvLeitor.Name = "lvLeitor";
            this.lvLeitor.Size = new System.Drawing.Size(551, 132);
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
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nascimento";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Endereco";
            this.columnHeader6.Width = 140;
            // 
            // calendarEmprestimo
            // 
            this.calendarEmprestimo.Location = new System.Drawing.Point(27, 440);
            this.calendarEmprestimo.Name = "calendarEmprestimo";
            this.calendarEmprestimo.TabIndex = 8;
            this.calendarEmprestimo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarEmprestimo_DateChanged);
            // 
            // calendarDevolucao
            // 
            this.calendarDevolucao.Location = new System.Drawing.Point(272, 440);
            this.calendarDevolucao.Name = "calendarDevolucao";
            this.calendarDevolucao.TabIndex = 9;
            this.calendarDevolucao.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarDevolucao_DateChanged);
            // 
            // tbEmprestimo
            // 
            this.tbEmprestimo.Location = new System.Drawing.Point(27, 405);
            this.tbEmprestimo.Name = "tbEmprestimo";
            this.tbEmprestimo.Size = new System.Drawing.Size(171, 23);
            this.tbEmprestimo.TabIndex = 10;
            // 
            // tbDevolucao
            // 
            this.tbDevolucao.Location = new System.Drawing.Point(272, 405);
            this.tbDevolucao.Name = "tbDevolucao";
            this.tbDevolucao.Size = new System.Drawing.Size(164, 23);
            this.tbDevolucao.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Empréstimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Devolução";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(591, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "CADASTRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(578, 419);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(192, 113);
            this.tbObs.TabIndex = 15;
            this.tbObs.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Observação";
            // 
            // EmprestimoCadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDevolucao);
            this.Controls.Add(this.tbEmprestimo);
            this.Controls.Add(this.calendarDevolucao);
            this.Controls.Add(this.calendarEmprestimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvLeitor);
            this.Controls.Add(this.lvLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoCadastroView";
            this.Text = "Cadastrar empréstimo";
            this.Load += new System.EventHandler(this.EmprestimoCadastroView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MonthCalendar calendarEmprestimo;
        private System.Windows.Forms.MonthCalendar calendarDevolucao;
        private System.Windows.Forms.TextBox tbEmprestimo;
        private System.Windows.Forms.TextBox tbDevolucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox tbObs;
        private System.Windows.Forms.Label label5;
    }
}