﻿
namespace Biblioteca.View.Fornecedor {
    partial class EditoraBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditoraBuscarView));
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(865, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 27);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.rbCNPJ.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCNPJ.ForeColor = System.Drawing.Color.White;
            this.rbCNPJ.Location = new System.Drawing.Point(177, 124);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(66, 24);
            this.rbCNPJ.TabIndex = 14;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = false;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(177, 99);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 13;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(294, 110);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(508, 27);
            this.tbBuscar.TabIndex = 12;
            // 
            // LvFornecedor
            // 
            this.LvFornecedor.BackColor = System.Drawing.Color.DimGray;
            this.LvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.CNPJ,
            this.Email});
            this.LvFornecedor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvFornecedor.ForeColor = System.Drawing.Color.White;
            this.LvFornecedor.FullRowSelect = true;
            this.LvFornecedor.HideSelection = false;
            this.LvFornecedor.Location = new System.Drawing.Point(111, 188);
            this.LvFornecedor.Name = "LvFornecedor";
            this.LvFornecedor.Size = new System.Drawing.Size(882, 337);
            this.LvFornecedor.TabIndex = 16;
            this.LvFornecedor.UseCompatibleStateImageBehavior = false;
            this.LvFornecedor.View = System.Windows.Forms.View.Details;
            this.LvFornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvFornecedor_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 200;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereco";
            this.Endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Endereco.Width = 300;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefone.Width = 150;
            // 
            // CNPJ
            // 
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNPJ.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LvFornecedor);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.rbNome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rbCNPJ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(139, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 656);
            this.panel1.TabIndex = 18;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1361, 662);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 150;
            // 
            // EditoraBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1361, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditoraBuscarView";
            this.Text = "Buscar Fornecedor";
            this.Load += new System.EventHandler(this.FornecedorBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader Email;
    }
}