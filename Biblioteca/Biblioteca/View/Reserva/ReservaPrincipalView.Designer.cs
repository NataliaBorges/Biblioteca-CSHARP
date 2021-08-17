
namespace Biblioteca.View.Reserva {
    partial class ReservaPrincipalView {
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
            this.button2 = new System.Windows.Forms.Button();
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
            this.lvReserva.Location = new System.Drawing.Point(109, 73);
            this.lvReserva.MultiSelect = false;
            this.lvReserva.Name = "lvReserva";
            this.lvReserva.Size = new System.Drawing.Size(565, 201);
            this.lvReserva.TabIndex = 5;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReservaPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvReserva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ReservaPrincipalView";
            this.Text = "Reserva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReserva;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Funcionário;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader ID_Leitor;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Reserva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}