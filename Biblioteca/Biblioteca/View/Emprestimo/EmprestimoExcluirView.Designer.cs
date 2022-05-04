
namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoExcluirView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoExcluirView));
            this.button1 = new System.Windows.Forms.Button();
            this.lvEmprestimo = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.ID_Leitor = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Data_Empréstimo = new System.Windows.Forms.ColumnHeader();
            this.Data_Devolução = new System.Windows.Forms.ColumnHeader();
            this.LvLivros = new System.Windows.Forms.ListView();
            this.id2 = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.ObsText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(592, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvEmprestimo
            // 
            this.lvEmprestimo.BackColor = System.Drawing.Color.DimGray;
            this.lvEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEmprestimo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Funcionário,
            this.Funcionário,
            this.ID_Leitor,
            this.Leitor,
            this.Data_Empréstimo,
            this.Data_Devolução});
            this.lvEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lvEmprestimo.HideSelection = false;
            this.lvEmprestimo.Location = new System.Drawing.Point(14, 191);
            this.lvEmprestimo.MultiSelect = false;
            this.lvEmprestimo.Name = "lvEmprestimo";
            this.lvEmprestimo.Size = new System.Drawing.Size(1071, 123);
            this.lvEmprestimo.TabIndex = 3;
            this.lvEmprestimo.UseCompatibleStateImageBehavior = false;
            this.lvEmprestimo.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ID_Funcionário
            // 
            this.ID_Funcionário.Text = "ID_Funcionário";
            this.ID_Funcionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Funcionário.Width = 140;
            // 
            // Funcionário
            // 
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Funcionário.Width = 250;
            // 
            // ID_Leitor
            // 
            this.ID_Leitor.Text = "ID_Leitor";
            this.ID_Leitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Leitor.Width = 80;
            // 
            // Leitor
            // 
            this.Leitor.Text = "Leitor";
            this.Leitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Leitor.Width = 240;
            // 
            // Data_Empréstimo
            // 
            this.Data_Empréstimo.Text = "Data_Empréstimo";
            this.Data_Empréstimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data_Empréstimo.Width = 150;
            // 
            // Data_Devolução
            // 
            this.Data_Devolução.Text = "Data_Devolução";
            this.Data_Devolução.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data_Devolução.Width = 150;
            // 
            // LvLivros
            // 
            this.LvLivros.BackColor = System.Drawing.Color.DimGray;
            this.LvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id2,
            this.Nome,
            this.Autor,
            this.Fornecedor,
            this.ISBN,
            this.Edição,
            this.Ano});
            this.LvLivros.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvLivros.ForeColor = System.Drawing.Color.White;
            this.LvLivros.HideSelection = false;
            this.LvLivros.HoverSelection = true;
            this.LvLivros.Location = new System.Drawing.Point(14, 334);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(1071, 124);
            this.LvLivros.TabIndex = 18;
            this.LvLivros.UseCompatibleStateImageBehavior = false;
            this.LvLivros.View = System.Windows.Forms.View.Details;
            // 
            // id2
            // 
            this.id2.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 240;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Autor.Width = 240;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fornecedor.Width = 150;
            // 
            // Edição
            // 
            this.Edição.DisplayIndex = 4;
            this.Edição.Text = "Edição";
            this.Edição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edição.Width = 150;
            // 
            // Ano
            // 
            this.Ano.DisplayIndex = 5;
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ano.Width = 140;
            // 
            // ObsText
            // 
            this.ObsText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObsText.Location = new System.Drawing.Point(153, 508);
            this.ObsText.Name = "ObsText";
            this.ObsText.Size = new System.Drawing.Size(770, 96);
            this.ObsText.TabIndex = 19;
            this.ObsText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Observação";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(327, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 70);
            this.button2.TabIndex = 21;
            this.button2.Text = "DEVOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(69, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 22;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lvEmprestimo);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.LvLivros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ObsText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(141, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 726);
            this.panel1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(327, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 70);
            this.button4.TabIndex = 23;
            this.button4.Text = "DEVOLVIDO";
            this.button4.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 732);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // ISBN
            // 
            this.ISBN.DisplayIndex = 6;
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 150;
            // 
            // EmprestimoExcluirView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoExcluirView";
            this.Text = "Excluir Empréstimo";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvEmprestimo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Funcionário;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader ID_Leitor;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Empréstimo;
        private System.Windows.Forms.ColumnHeader Data_Devolução;
        private System.Windows.Forms.ListView LvLivros;
        private System.Windows.Forms.ColumnHeader id2;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.RichTextBox ObsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader ISBN;
    }
}