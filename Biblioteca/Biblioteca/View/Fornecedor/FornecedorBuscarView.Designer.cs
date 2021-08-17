
namespace Biblioteca.View.Fornecedor {
    partial class FornecedorBuscarView {
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.LvFornecedor = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Endereco = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.CNPJ = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(596, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(143, 92);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 19);
            this.rbCNPJ.TabIndex = 14;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbNome.Location = new System.Drawing.Point(143, 67);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(58, 19);
            this.rbNome.TabIndex = 13;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(260, 78);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(321, 23);
            this.tbBuscar.TabIndex = 12;
            // 
            // LvFornecedor
            // 
            this.LvFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.CNPJ});
            this.LvFornecedor.FullRowSelect = true;
            this.LvFornecedor.HideSelection = false;
            this.LvFornecedor.Location = new System.Drawing.Point(114, 148);
            this.LvFornecedor.Name = "LvFornecedor";
            this.LvFornecedor.Size = new System.Drawing.Size(573, 201);
            this.LvFornecedor.TabIndex = 16;
            this.LvFornecedor.UseCompatibleStateImageBehavior = false;
            this.LvFornecedor.View = System.Windows.Forms.View.Details;
            this.LvFornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvFornecedor_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereco";
            this.Endereco.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 100;
            // 
            // CNPJ
            // 
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.Width = 100;
            // 
            // FornecedorBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvFornecedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.tbBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FornecedorBuscarView";
            this.Text = "Buscar Fornecedor";
            this.Load += new System.EventHandler(this.FornecedorBuscarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ListView LvFornecedor;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader CNPJ;
    }
}