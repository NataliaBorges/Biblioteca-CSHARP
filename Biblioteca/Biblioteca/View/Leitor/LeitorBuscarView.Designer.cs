
namespace Biblioteca.View.Leitor {
    partial class LeitorBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeitorBuscarView));
            this.LvLeitor = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Nascimento = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Endereço = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvLeitor
            // 
            this.LvLeitor.BackColor = System.Drawing.Color.DimGray;
            this.LvLeitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvLeitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Nascimento,
            this.Telefone,
            this.CPF,
            this.Endereço,
            this.Email});
            this.LvLeitor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvLeitor.ForeColor = System.Drawing.Color.White;
            this.LvLeitor.FullRowSelect = true;
            this.LvLeitor.HideSelection = false;
            this.LvLeitor.HoverSelection = true;
            this.LvLeitor.Location = new System.Drawing.Point(26, 189);
            this.LvLeitor.Name = "LvLeitor";
            this.LvLeitor.Size = new System.Drawing.Size(1071, 408);
            this.LvLeitor.TabIndex = 11;
            this.LvLeitor.UseCompatibleStateImageBehavior = false;
            this.LvLeitor.View = System.Windows.Forms.View.Details;
            this.LvLeitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvLeitor_MouseClick);
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
            // Nascimento
            // 
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nascimento.Width = 120;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefone.Width = 120;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPF.Width = 150;
            // 
            // Endereço
            // 
            this.Endereço.DisplayIndex = 6;
            this.Endereço.Text = "Endereço";
            this.Endereço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Endereço.Width = 450;
            // 
            // Email
            // 
            this.Email.DisplayIndex = 5;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 200;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(913, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.BackColor = System.Drawing.Color.Transparent;
            this.rbCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbCPF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(202, 100);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(57, 24);
            this.rbCPF.TabIndex = 9;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = false;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbAutor_CheckedChanged_1);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(202, 75);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 8;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(314, 97);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(571, 27);
            this.tbBuscar.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LvLeitor);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.rbNome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rbCPF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 696);
            this.panel1.TabIndex = 16;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1395, 702);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // LeitorBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1395, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeitorBuscarView";
            this.Text = "Buscar Leitor";
            this.Load += new System.EventHandler(this.LeitorBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LvLeitor;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader Endereço;
    }
}