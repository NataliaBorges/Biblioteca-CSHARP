
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
            this.lvReserva = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.ID_Leitor = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Data_Reserva = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.rbLeitor = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
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
            this.lvReserva.Location = new System.Drawing.Point(103, 178);
            this.lvReserva.MultiSelect = false;
            this.lvReserva.Name = "lvReserva";
            this.lvReserva.Size = new System.Drawing.Size(562, 201);
            this.lvReserva.TabIndex = 28;
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
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(575, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbLeitor
            // 
            this.rbLeitor.AutoSize = true;
            this.rbLeitor.Location = new System.Drawing.Point(130, 94);
            this.rbLeitor.Name = "rbLeitor";
            this.rbLeitor.Size = new System.Drawing.Size(55, 19);
            this.rbLeitor.TabIndex = 26;
            this.rbLeitor.TabStop = true;
            this.rbLeitor.Text = "Leitor";
            this.rbLeitor.UseVisualStyleBackColor = true;
            // 
            // rbLivro
            // 
            this.rbLivro.AutoSize = true;
            this.rbLivro.BackColor = System.Drawing.Color.Transparent;
            this.rbLivro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbLivro.Location = new System.Drawing.Point(130, 69);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(51, 19);
            this.rbLivro.TabIndex = 25;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "Livro";
            this.rbLivro.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(236, 80);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(321, 23);
            this.tbBuscar.TabIndex = 24;
            // 
            // ReservaBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbLeitor);
            this.Controls.Add(this.rbLivro);
            this.Controls.Add(this.tbBuscar);
            this.Name = "ReservaBuscarView";
            this.Text = "Buscar Reserva";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbLeitor;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}