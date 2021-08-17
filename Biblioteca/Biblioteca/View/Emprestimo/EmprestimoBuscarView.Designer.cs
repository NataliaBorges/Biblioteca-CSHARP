﻿
namespace Biblioteca.View.Emprestimo {
    partial class EmprestimoBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoBuscarView));
            this.button1 = new System.Windows.Forms.Button();
            this.rbLeitor = new System.Windows.Forms.RadioButton();
            this.rbLivro = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lvEmprestimo = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Leitor = new System.Windows.Forms.ColumnHeader();
            this.Livro = new System.Windows.Forms.ColumnHeader();
            this.Funcionário = new System.Windows.Forms.ColumnHeader();
            this.Data_Empréstimo = new System.Windows.Forms.ColumnHeader();
            this.Data_Devolução = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(576, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLeitor
            // 
            this.rbLeitor.AutoSize = true;
            this.rbLeitor.Location = new System.Drawing.Point(131, 90);
            this.rbLeitor.Name = "rbLeitor";
            this.rbLeitor.Size = new System.Drawing.Size(55, 19);
            this.rbLeitor.TabIndex = 21;
            this.rbLeitor.TabStop = true;
            this.rbLeitor.Text = "Leitor";
            this.rbLeitor.UseVisualStyleBackColor = true;
            // 
            // rbLivro
            // 
            this.rbLivro.AutoSize = true;
            this.rbLivro.BackColor = System.Drawing.Color.Transparent;
            this.rbLivro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbLivro.Location = new System.Drawing.Point(131, 65);
            this.rbLivro.Name = "rbLivro";
            this.rbLivro.Size = new System.Drawing.Size(51, 19);
            this.rbLivro.TabIndex = 20;
            this.rbLivro.TabStop = true;
            this.rbLivro.Text = "Livro";
            this.rbLivro.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(237, 76);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(321, 23);
            this.tbBuscar.TabIndex = 19;
            // 
            // lvEmprestimo
            // 
            this.lvEmprestimo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Leitor,
            this.Livro,
            this.Funcionário,
            this.Data_Empréstimo,
            this.Data_Devolução});
            this.lvEmprestimo.FullRowSelect = true;
            this.lvEmprestimo.HideSelection = false;
            this.lvEmprestimo.Location = new System.Drawing.Point(70, 176);
            this.lvEmprestimo.Name = "lvEmprestimo";
            this.lvEmprestimo.Size = new System.Drawing.Size(662, 201);
            this.lvEmprestimo.TabIndex = 23;
            this.lvEmprestimo.UseCompatibleStateImageBehavior = false;
            this.lvEmprestimo.View = System.Windows.Forms.View.Details;
            this.lvEmprestimo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvEmprestimo_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Leitor
            // 
            this.Leitor.Text = "Leitor";
            this.Leitor.Width = 130;
            // 
            // Livro
            // 
            this.Livro.Text = "Livro";
            this.Livro.Width = 130;
            // 
            // Funcionário
            // 
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.Width = 130;
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
            // EmprestimoBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvEmprestimo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbLeitor);
            this.Controls.Add(this.rbLivro);
            this.Controls.Add(this.tbBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmprestimoBuscarView";
            this.Text = "Buscar Empréstimo";
            this.Load += new System.EventHandler(this.EmpretimoBuscarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbLeitor;
        private System.Windows.Forms.RadioButton rbLivro;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ListView lvEmprestimo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Funcionário;
        private System.Windows.Forms.ColumnHeader Leitor;
        private System.Windows.Forms.ColumnHeader Data_Empréstimo;
        private System.Windows.Forms.ColumnHeader Data_Devolução;
        private System.Windows.Forms.ColumnHeader Livro;
    }
}