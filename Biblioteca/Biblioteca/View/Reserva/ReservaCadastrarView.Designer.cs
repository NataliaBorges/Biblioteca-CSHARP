﻿
namespace Biblioteca.View.Reserva {
    partial class ReservaCadastrarView {
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReserva = new System.Windows.Forms.TextBox();
            this.calendarEmprestimo = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvLeitor = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lvLivros = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Observação";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(368, 401);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(207, 144);
            this.tbObs.TabIndex = 30;
            this.tbObs.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "CADASTRAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reserva";
            // 
            // tbReserva
            // 
            this.tbReserva.Location = new System.Drawing.Point(98, 366);
            this.tbReserva.Name = "tbReserva";
            this.tbReserva.Size = new System.Drawing.Size(171, 23);
            this.tbReserva.TabIndex = 25;
            // 
            // calendarEmprestimo
            // 
            this.calendarEmprestimo.Location = new System.Drawing.Point(98, 401);
            this.calendarEmprestimo.Name = "calendarEmprestimo";
            this.calendarEmprestimo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Selecionar Leitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adionar livro";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = global::Biblioteca.Properties.Resources.LivroIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(644, 28);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(134, 88);
            this.button2.TabIndex = 20;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.iconpeople;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(644, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 99);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
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
            this.lvLeitor.Location = new System.Drawing.Point(50, 200);
            this.lvLeitor.Name = "lvLeitor";
            this.lvLeitor.Size = new System.Drawing.Size(551, 132);
            this.lvLeitor.TabIndex = 18;
            this.lvLeitor.UseCompatibleStateImageBehavior = false;
            this.lvLeitor.View = System.Windows.Forms.View.Details;
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
            this.lvLivros.Location = new System.Drawing.Point(50, 12);
            this.lvLivros.Name = "lvLivros";
            this.lvLivros.Size = new System.Drawing.Size(551, 121);
            this.lvLivros.TabIndex = 17;
            this.lvLivros.UseCompatibleStateImageBehavior = false;
            this.lvLivros.View = System.Windows.Forms.View.Details;
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
            // ReservaCadastrarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 581);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReserva);
            this.Controls.Add(this.calendarEmprestimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvLeitor);
            this.Controls.Add(this.lvLivros);
            this.Name = "ReservaCadastrarView";
            this.Text = "Cadastrar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbObs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReserva;
        private System.Windows.Forms.MonthCalendar calendarEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvLeitor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvLivros;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
    }
}