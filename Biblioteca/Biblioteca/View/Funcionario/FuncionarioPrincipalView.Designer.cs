
namespace Biblioteca.View.Funcionario {
    partial class FuncionarioPrincipalView {
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Lvfuncionario = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Nascimento = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Endereco = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(449, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "CADASTRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(199, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 57);
            this.button3.TabIndex = 6;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lvfuncionario
            // 
            this.Lvfuncionario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Nascimento,
            this.Telefone,
            this.CPF,
            this.Endereco,
            this.Email});
            this.Lvfuncionario.HideSelection = false;
            this.Lvfuncionario.Location = new System.Drawing.Point(52, 52);
            this.Lvfuncionario.Name = "Lvfuncionario";
            this.Lvfuncionario.Size = new System.Drawing.Size(756, 215);
            this.Lvfuncionario.TabIndex = 5;
            this.Lvfuncionario.UseCompatibleStateImageBehavior = false;
            this.Lvfuncionario.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // Nascimento
            // 
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.Width = 100;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 100;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereco";
            this.Endereco.Width = 200;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // FuncionarioPrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lvfuncionario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioPrincipalView";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.funcionarioPrincipalView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView Lvfuncionario;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Email;
    }
}