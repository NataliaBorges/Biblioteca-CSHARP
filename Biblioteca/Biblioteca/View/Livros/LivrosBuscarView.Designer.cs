
namespace Biblioteca.View.Livros {
    partial class LivrosBuscarView {
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
            this.rbEditora = new System.Windows.Forms.RadioButton();
            this.LvLivros = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbEditora
            // 
            this.rbEditora.Location = new System.Drawing.Point(144, 100);
            this.rbEditora.MaximumSize = new System.Drawing.Size(180, 180);
            this.rbEditora.Name = "rbEditora";
            this.rbEditora.Size = new System.Drawing.Size(105, 19);
            this.rbEditora.TabIndex = 18;
            this.rbEditora.TabStop = true;
            this.rbEditora.Text = "Editora";
            this.rbEditora.UseVisualStyleBackColor = true;
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
            this.LvLivros.Location = new System.Drawing.Point(113, 153);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(567, 259);
            this.LvLivros.TabIndex = 17;
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
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(607, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Location = new System.Drawing.Point(144, 75);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(55, 19);
            this.rbAutor.TabIndex = 15;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbNome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbNome.Location = new System.Drawing.Point(144, 50);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(58, 19);
            this.rbNome.TabIndex = 14;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(261, 71);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(321, 23);
            this.tbBuscar.TabIndex = 13;
            // 
            // LivrosBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.rbEditora);
            this.Controls.Add(this.LvLivros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbAutor);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.tbBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LivrosBuscarView";
            this.Text = "Buscar Livros";
            this.Load += new System.EventHandler(this.LivrosBuscarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEditora;
        private System.Windows.Forms.ListView LvLivros;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ColumnHeader Fornecedor;
    }
}