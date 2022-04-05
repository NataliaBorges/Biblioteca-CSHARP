
namespace Biblioteca.View.Reserva {
    partial class ReservaBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaBuscarView));
            this.button1 = new System.Windows.Forms.Button();
            this.rbLeitor = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lvReserva = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Livro = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Data_reserva = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(790, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLeitor
            // 
            this.rbLeitor.AutoSize = true;
            this.rbLeitor.BackColor = System.Drawing.Color.Transparent;
            this.rbLeitor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLeitor.ForeColor = System.Drawing.Color.White;
            this.rbLeitor.Location = new System.Drawing.Point(166, 127);
            this.rbLeitor.Name = "rbLeitor";
            this.rbLeitor.Size = new System.Drawing.Size(70, 24);
            this.rbLeitor.TabIndex = 21;
            this.rbLeitor.TabStop = true;
            this.rbLeitor.Text = "Leitor";
            this.rbLeitor.UseVisualStyleBackColor = false;
            // 
            // rbLivro
            // 
            this.rbLivro.AutoSize = true;
            this.rbLivro.BackColor = System.Drawing.Color.Transparent;
            this.rbLivro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLivro.ForeColor = System.Drawing.Color.White;
            this.rbLivro.Location = new System.Drawing.Point(166, 102);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(66, 24);
            this.rbLivro.TabIndex = 20;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "Livro";
            this.rbLivro.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(272, 113);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(454, 27);
            this.tbBuscar.TabIndex = 19;
            // 
            // lvReserva
            // 
            this.lvReserva.BackColor = System.Drawing.Color.DimGray;
            this.lvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReserva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Leitor,
            this.Livro,
            this.Funcionário,
            this.Data_reserva});
            this.lvReserva.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvReserva.ForeColor = System.Drawing.Color.White;
            this.lvReserva.FullRowSelect = true;
            this.lvReserva.HideSelection = false;
            this.lvReserva.Location = new System.Drawing.Point(78, 184);
            this.lvReserva.Name = "lvReserva";
            this.lvReserva.Size = new System.Drawing.Size(814, 317);
            this.lvReserva.TabIndex = 23;
            this.lvReserva.UseCompatibleStateImageBehavior = false;
            this.lvReserva.View = System.Windows.Forms.View.Details;
            this.lvReserva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvReserva_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Leitor
            // 
            this.Leitor.Text = "Leitor";
            this.Leitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Leitor.Width = 200;
            // 
            // Livro
            // 
            this.Livro.Text = "Livro";
            this.Livro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Livro.Width = 200;
            // 
            // Funcionário
            // 
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Funcionário.Width = 200;
            // 
            // Data_reserva
            // 
            this.Data_reserva.Text = "Data_reserva";
            this.Data_reserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data_reserva.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.rbLivro);
            this.panel1.Controls.Add(this.lvReserva);
            this.panel1.Controls.Add(this.rbLeitor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(124, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 733);
            this.panel1.TabIndex = 25;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 739);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // ReservaBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 739);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaBuscarView";
            this.Text = "Buscar Reserva";
            this.Load += new System.EventHandler(this.EmpretimoBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbLeitor;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ListView lvReserva;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_reserva;
        private System.Windows.Forms.ColumnHeader Livro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}