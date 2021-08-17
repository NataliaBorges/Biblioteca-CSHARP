
namespace Biblioteca.View.Reserva {
    partial class ReservaExcluirView {
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
            this.lvReserva = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.ID_Leitor = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Data_Reserva = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.ObsText = new System.Windows.Forms.RichTextBox();
            this.LvLivros = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvReserva
            // 
            this.lvReserva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Funcionário,
            this.Funcionário,
            this.ID_Leitor,
            this.Leitor,
            this.Data_Reserva});
            this.lvReserva.HideSelection = false;
            this.lvReserva.Location = new System.Drawing.Point(112, 31);
            this.lvReserva.MultiSelect = false;
            this.lvReserva.Name = "lvReserva";
            this.lvReserva.Size = new System.Drawing.Size(565, 101);
            this.lvReserva.TabIndex = 6;
            this.lvReserva.UseCompatibleStateImageBehavior = false;
            this.lvReserva.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // ID_Funcionário
            // 
            this.ID_Funcionário.Text = "ID_Funcionário";
            this.ID_Funcionário.Width = 80;
            // 
            // Funcionário
            // 
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.Width = 100;
            // 
            // ID_Leitor
            // 
            this.ID_Leitor.Text = "ID_Leitor";
            this.ID_Leitor.Width = 80;
            // 
            // Leitor
            // 
            this.Leitor.Text = "Leitor";
            this.Leitor.Width = 100;
            // 
            // Data_Reserva
            // 
            this.Data_Reserva.Text = "Data_Reserva";
            this.Data_Reserva.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Observação";
            // 
            // ObsText
            // 
            this.ObsText.Location = new System.Drawing.Point(112, 330);
            this.ObsText.Name = "ObsText";
            this.ObsText.Size = new System.Drawing.Size(214, 96);
            this.ObsText.TabIndex = 23;
            this.ObsText.Text = "";
            // 
            // LvLivros
            // 
            this.LvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Nome,
            this.Autor,
            this.Fornecedor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.LvLivros.FullRowSelect = true;
            this.LvLivros.HideSelection = false;
            this.LvLivros.HoverSelection = true;
            this.LvLivros.Location = new System.Drawing.Point(69, 165);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(675, 124);
            this.LvLivros.TabIndex = 22;
            this.LvLivros.UseCompatibleStateImageBehavior = false;
            this.LvLivros.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 150;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.Width = 80;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.Width = 100;
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
            this.button1.Location = new System.Drawing.Point(476, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReservaExcluirView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObsText);
            this.Controls.Add(this.LvLivros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvReserva);
            this.Name = "ReservaExcluirView";
            this.Text = "Excluir Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvReserva;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Funcionário;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader ID_Leitor;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ObsText;
        private System.Windows.Forms.ListView LvLivros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.Button button1;
    }
}