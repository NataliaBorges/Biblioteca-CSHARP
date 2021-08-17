
namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoPrincipalView {
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
            this.button2 = new System.Windows.Forms.Button();
            this.lvEmprestimo = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.ID_Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.ID_Leitor = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Data_Empréstimo = new System.Windows.Forms.ColumnHeader();
            this.Data_Devolução = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvEmprestimo
            // 
            this.lvEmprestimo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ID_Funcionário,
            this.Funcionário,
            this.ID_Leitor,
            this.Leitor,
            this.Data_Empréstimo,
            this.Data_Devolução});
            this.lvEmprestimo.HideSelection = false;
            this.lvEmprestimo.Location = new System.Drawing.Point(74, 62);
            this.lvEmprestimo.MultiSelect = false;
            this.lvEmprestimo.Name = "lvEmprestimo";
            this.lvEmprestimo.Size = new System.Drawing.Size(662, 201);
            this.lvEmprestimo.TabIndex = 2;
            this.lvEmprestimo.UseCompatibleStateImageBehavior = false;
            this.lvEmprestimo.View = System.Windows.Forms.View.Details;
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
            // Data_Empréstimo
            // 
            this.Data_Empréstimo.Text = "Data_Empréstimo";
            this.Data_Empréstimo.Width = 110;
            // 
            // Data_Devolução
            // 
            this.Data_Devolução.Text = "Data_Devolução";
            this.Data_Devolução.Width = 100;
            // 
            // EmprestimoPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvEmprestimo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoPrincipalView";
            this.Text = "Empréstimo";
            this.Load += new System.EventHandler(this.EmprestimoPrincipalView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvEmprestimo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Funcionário;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader ID_Leitor;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Empréstimo;
        private System.Windows.Forms.ColumnHeader Data_Devolução;
    }
}