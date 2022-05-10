
namespace Biblioteca.View.Livros {
    partial class LivroBuscarExemplarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroBuscarExemplarView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.LvExemplar = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Autor = new System.Windows.Forms.ColumnHeader();
            this.Editora = new System.Windows.Forms.ColumnHeader();
            this.ISBN = new System.Windows.Forms.ColumnHeader();
            this.Edição = new System.Windows.Forms.ColumnHeader();
            this.Ano = new System.Windows.Forms.ColumnHeader();
            this.Aquisição = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.Situação = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 799);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LvExemplar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 793);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(852, 551);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 18);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar Empréstimo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbQuantidade);
            this.panel2.Location = new System.Drawing.Point(354, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 70);
            this.panel2.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(313, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adicionar mais exemplares: ";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuantidade.Location = new System.Drawing.Point(251, 22);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(56, 27);
            this.tbQuantidade.TabIndex = 28;
            this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LvExemplar
            // 
            this.LvExemplar.BackColor = System.Drawing.Color.Black;
            this.LvExemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvExemplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Autor,
            this.Editora,
            this.ISBN,
            this.Edição,
            this.Ano,
            this.Aquisição,
            this.Situação});
            this.LvExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvExemplar.ForeColor = System.Drawing.Color.White;
            this.LvExemplar.FullRowSelect = true;
            this.LvExemplar.HideSelection = false;
            this.LvExemplar.HoverSelection = true;
            this.LvExemplar.Location = new System.Drawing.Point(40, 109);
            this.LvExemplar.Name = "LvExemplar";
            this.LvExemplar.Size = new System.Drawing.Size(964, 403);
            this.LvExemplar.TabIndex = 25;
            this.LvExemplar.UseCompatibleStateImageBehavior = false;
            this.LvExemplar.View = System.Windows.Forms.View.Details;
            this.LvExemplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvExemplar_MouseClick_1);
            this.LvExemplar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvExemplar_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
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
            this.Editora.Text = "Editora";
            this.Editora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editora.Width = 150;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBN.Width = 100;
            // 
            // Edição
            // 
            this.Edição.Text = "Edição";
            this.Edição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Edição.Width = 150;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ano.Width = 100;
            // 
            // Aquisição
            // 
            this.Aquisição.Text = "Aquisição";
            this.Aquisição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aquisição.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Situação
            // 
            this.Situação.Text = "Situação";
            this.Situação.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Situação.Width = 150;
            // 
            // LivroBuscarExemplarView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1299, 799);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LivroBuscarExemplarView";
            this.Text = "LivroBuscarExemplar";
            this.Load += new System.EventHandler(this.LivroBuscarExemplarView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LvExemplar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Editora;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Edição;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader Aquisição;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ColumnHeader Situação;
    }
}