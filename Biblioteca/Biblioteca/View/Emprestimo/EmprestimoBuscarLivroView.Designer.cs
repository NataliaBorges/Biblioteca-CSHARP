
namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoBuscarLivroView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoBuscarLivroView));
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LvLivros = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(280, 97);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(587, 27);
            this.tbBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(897, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LvLivros
            // 
            this.LvLivros.BackColor = System.Drawing.Color.DimGray;
            this.LvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Autor,
            this.Fornecedor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.LvLivros.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvLivros.ForeColor = System.Drawing.Color.White;
            this.LvLivros.FullRowSelect = true;
            this.LvLivros.HideSelection = false;
            this.LvLivros.HoverSelection = true;
            this.LvLivros.Location = new System.Drawing.Point(69, 154);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(983, 273);
            this.LvLivros.TabIndex = 18;
            this.LvLivros.UseCompatibleStateImageBehavior = false;
            this.LvLivros.View = System.Windows.Forms.View.Details;
            this.LvLivros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvLivros_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
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
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fornecedor.Width = 150;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edição.Width = 150;
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
            this.Aquisição.Width = 120;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LvLivros);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(143, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 704);
            this.panel1.TabIndex = 20;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1404, 710);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesquisar por nome:";
            // 
            // EmprestimoBuscarLivroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoBuscarLivroView";
            this.Text = "Selecionar Livros";
            this.Load += new System.EventHandler(this.EmprestimoBuscarLivroView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LvLivros;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}