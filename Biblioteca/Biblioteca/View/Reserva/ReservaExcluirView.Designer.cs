
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaExcluirView));
            this.button1 = new System.Windows.Forms.Button();
            this.lvReserva = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.ID_Leitor = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Data_Reserva = new System.Windows.Forms.ColumnHeader();
            this.LvLivros = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.ObsText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(434, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvReserva
            // 
            this.lvReserva.BackColor = System.Drawing.Color.Black;
            this.lvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReserva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Funcionário,
            this.Funcionário,
            this.ID_Leitor,
            this.Leitor,
            this.Data_Reserva});
            this.lvReserva.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvReserva.ForeColor = System.Drawing.Color.White;
            this.lvReserva.HideSelection = false;
            this.lvReserva.Location = new System.Drawing.Point(32, 247);
            this.lvReserva.MultiSelect = false;
            this.lvReserva.Name = "lvReserva";
            this.lvReserva.Size = new System.Drawing.Size(963, 123);
            this.lvReserva.TabIndex = 3;
            this.lvReserva.UseCompatibleStateImageBehavior = false;
            this.lvReserva.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ID_Funcionário
            // 
            this.ID_Funcionário.Text = "ID_Funcionário";
            this.ID_Funcionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Funcionário.Width = 200;
            // 
            // Funcionário
            // 
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Funcionário.Width = 200;
            // 
            // ID_Leitor
            // 
            this.ID_Leitor.Text = "ID_Leitor";
            this.ID_Leitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Leitor.Width = 100;
            // 
            // Leitor
            // 
            this.Leitor.Text = "Leitor";
            this.Leitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Leitor.Width = 200;
            // 
            // Data_Reserva
            // 
            this.Data_Reserva.Text = "Data_Reserva";
            this.Data_Reserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data_Reserva.Width = 200;
            // 
            // LvLivros
            // 
            this.LvLivros.BackColor = System.Drawing.Color.Black;
            this.LvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Nome,
            this.Autor,
            this.Fornecedor,
            this.Edição,
            this.Ano,
            this.Aquisição});
            this.LvLivros.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvLivros.ForeColor = System.Drawing.Color.White;
            this.LvLivros.HideSelection = false;
            this.LvLivros.HoverSelection = true;
            this.LvLivros.Location = new System.Drawing.Point(32, 415);
            this.LvLivros.Name = "LvLivros";
            this.LvLivros.Size = new System.Drawing.Size(963, 124);
            this.LvLivros.TabIndex = 18;
            this.LvLivros.UseCompatibleStateImageBehavior = false;
            this.LvLivros.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
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
            // Editora
            // 
            this.Fornecedor.Text = "Editora";
            this.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fornecedor.Width = 150;
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
            this.Ano.Width = 130;
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aquisição.Width = 120;
            // 
            // ObsText
            // 
            this.ObsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ObsText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObsText.Location = new System.Drawing.Point(202, 604);
            this.ObsText.Name = "ObsText";
            this.ObsText.Size = new System.Drawing.Size(677, 96);
            this.ObsText.TabIndex = 19;
            this.ObsText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Observação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvReserva);
            this.panel1.Controls.Add(this.ObsText);
            this.panel1.Controls.Add(this.LvLivros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 770);
            this.panel1.TabIndex = 22;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(367, 82);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(354, 38);
            this.lblCadastroLivro.TabIndex = 95;
            this.lblCadastroLivro.Text = "STATUS DA RESERVA";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1016, 37);
            this.head1.TabIndex = 21;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.72104F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.27895F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1226, 776);
            this.pnltotal.TabIndex = 23;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(198, 770);
            this.menuControl1.TabIndex = 23;
            // 
            // ReservaExcluirView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 776);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaExcluirView";
            this.Text = "Excluir Reserva";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvReserva;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Funcionário;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader ID_Leitor;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Reserva;
        private System.Windows.Forms.ListView LvLivros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.RichTextBox ObsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
    }
}