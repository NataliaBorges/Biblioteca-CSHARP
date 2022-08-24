
namespace Biblioteca.View.Funcionario {
    partial class FuncionarioBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioBuscarView));
            this.button1 = new System.Windows.Forms.Button();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.Lvfuncionario = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Nascimento = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Endereco = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinkCadastrarFuncionario = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(810, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 27);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.BackColor = System.Drawing.Color.Transparent;
            this.rbEmail.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(3, 35);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(74, 24);
            this.rbEmail.TabIndex = 14;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "E-mail";
            this.rbEmail.UseVisualStyleBackColor = false;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(6, 5);
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
            this.tbBuscar.Location = new System.Drawing.Point(244, 138);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(534, 27);
            this.tbBuscar.TabIndex = 12;
            // 
            // Lvfuncionario
            // 
            this.Lvfuncionario.BackColor = System.Drawing.Color.DimGray;
            this.Lvfuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lvfuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Nascimento,
            this.Telefone,
            this.CPF,
            this.Endereco,
            this.Email});
            this.Lvfuncionario.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lvfuncionario.ForeColor = System.Drawing.Color.White;
            this.Lvfuncionario.FullRowSelect = true;
            this.Lvfuncionario.HideSelection = false;
            this.Lvfuncionario.Location = new System.Drawing.Point(26, 177);
            this.Lvfuncionario.Name = "Lvfuncionario";
            this.Lvfuncionario.Size = new System.Drawing.Size(1047, 400);
            this.Lvfuncionario.TabIndex = 16;
            this.Lvfuncionario.UseCompatibleStateImageBehavior = false;
            this.Lvfuncionario.View = System.Windows.Forms.View.Details;
            this.Lvfuncionario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lvfuncionario_MouseClick);
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
            this.Telefone.Width = 130;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPF.Width = 140;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereco";
            this.Endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Endereco.Width = 450;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 200;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LinkCadastrarFuncionario);
            this.panel1.Controls.Add(this.Lvfuncionario);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(140, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 773);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecione o tipo da busca:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.rbNome);
            this.panel2.Controls.Add(this.rbEmail);
            this.panel2.Location = new System.Drawing.Point(446, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 69);
            this.panel2.TabIndex = 23;
            // 
            // LinkCadastrarFuncionario
            // 
            this.LinkCadastrarFuncionario.AutoSize = true;
            this.LinkCadastrarFuncionario.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkCadastrarFuncionario.LinkColor = System.Drawing.Color.White;
            this.LinkCadastrarFuncionario.Location = new System.Drawing.Point(923, 144);
            this.LinkCadastrarFuncionario.Name = "LinkCadastrarFuncionario";
            this.LinkCadastrarFuncionario.Size = new System.Drawing.Size(150, 18);
            this.LinkCadastrarFuncionario.TabIndex = 22;
            this.LinkCadastrarFuncionario.TabStop = true;
            this.LinkCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.LinkCadastrarFuncionario.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LinkCadastrarFuncionario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastrarFuncionario_LinkClicked);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 779);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // FuncionarioBuscarView
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 779);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioBuscarView";
            this.Text = "Buscar Funcionário";
            this.Load += new System.EventHandler(this.FuncionarioBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ListView Lvfuncionario;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkCadastrarFuncionario;
    }
}