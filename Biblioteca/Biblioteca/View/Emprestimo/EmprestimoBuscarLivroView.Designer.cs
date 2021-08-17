
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
            this.SuspendLayout();
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(152, 65);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(409, 23);
            this.tbBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(581, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LvLivros
            // 
            this.LvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Autor,
            this.Fornecedor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.LvLivros.FullRowSelect = true;
            this.LvLivros.HideSelection = false;
            this.LvLivros.HoverSelection = true;
            this.LvLivros.Location = new System.Drawing.Point(107, 129);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(575, 273);
            this.LvLivros.TabIndex = 18;
            this.LvLivros.UseCompatibleStateImageBehavior = false;
            this.LvLivros.View = System.Windows.Forms.View.Details;
            this.LvLivros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvLivros_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
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
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.Width = 100;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.Width = 80;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.Width = 100;
            // 
            // EmprestimoBuscarLivroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvLivros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoBuscarLivroView";
            this.Text = "Selecionar Livros";
            this.Load += new System.EventHandler(this.EmprestimoBuscarLivroView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}