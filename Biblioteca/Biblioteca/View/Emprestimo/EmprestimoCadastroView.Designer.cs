
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLivros
            // 
            this.lvLivros.BackColor = System.Drawing.Color.DimGray;
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
            this.lvLivros.Location = new System.Drawing.Point(69, 63);
            this.lvLivros.Name = "lvLivros";
            this.lvLivros.Size = new System.Drawing.Size(841, 129);
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
            this.Aquisição.Width = 150;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.iconpeople;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(926, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 106);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(937, 172);
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
            this.label2.Location = new System.Drawing.Point(926, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecionar Leitor";
            // 
            // lvLeitor
            // 
            this.lvLeitor.BackColor = System.Drawing.Color.DimGray;
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
            this.lvLeitor.Location = new System.Drawing.Point(69, 244);
            this.lvLeitor.Name = "lvLeitor";
            this.lvLeitor.Size = new System.Drawing.Size(841, 141);
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
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Endereco";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 450;
            // 
            // calendarEmprestimo
            // 
            this.calendarEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendarEmprestimo.Location = new System.Drawing.Point(196, 463);
            this.calendarEmprestimo.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.calendarEmprestimo.Name = "calendarEmprestimo";
            this.calendarEmprestimo.TabIndex = 8;
            this.calendarEmprestimo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarEmprestimo_DateChanged);
            // 
            // calendarDevolucao
            // 
            this.calendarDevolucao.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendarDevolucao.Location = new System.Drawing.Point(456, 463);
            this.calendarDevolucao.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.calendarDevolucao.Name = "calendarDevolucao";
            this.calendarDevolucao.TabIndex = 9;
            this.calendarDevolucao.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarDevolucao_DateChanged);
            // 
            // tbEmprestimo
            // 
            this.tbEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmprestimo.Location = new System.Drawing.Point(196, 438);
            this.tbEmprestimo.Name = "tbEmprestimo";
            this.tbEmprestimo.Size = new System.Drawing.Size(228, 27);
            this.tbEmprestimo.TabIndex = 10;
            this.tbEmprestimo.TextChanged += new System.EventHandler(this.tbEmprestimo_TextChanged);
            // 
            // tbDevolucao
            // 
            this.tbDevolucao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDevolucao.Location = new System.Drawing.Point(456, 438);
            this.tbDevolucao.Name = "tbDevolucao";
            this.tbDevolucao.Size = new System.Drawing.Size(227, 27);
            this.tbDevolucao.TabIndex = 11;
            this.tbDevolucao.TextChanged += new System.EventHandler(this.tbDevolucao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(196, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Empréstimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(456, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Devolução";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(758, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "CADASTRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbObs
            // 
            this.tbObs.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbObs.Location = new System.Drawing.Point(758, 441);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(192, 120);
            this.tbObs.TabIndex = 15;
            this.tbObs.Text = "";
            this.tbObs.TextChanged += new System.EventHandler(this.tbObs_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(758, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Observação";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(69, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lvLivros);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lvLeitor);
            this.panel1.Controls.Add(this.tbObs);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.calendarEmprestimo);
            this.panel1.Controls.Add(this.tbDevolucao);
            this.panel1.Controls.Add(this.calendarDevolucao);
            this.panel1.Controls.Add(this.tbEmprestimo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(145, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 740);
            this.panel1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = global::Biblioteca.Properties.Resources.LivroIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(926, 75);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(134, 94);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 746);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // EmprestimoCadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 746);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoCadastroView";
            this.Text = "Cadastrar empréstimo";
            this.Load += new System.EventHandler(this.EmprestimoCadastroView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvLivros;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}