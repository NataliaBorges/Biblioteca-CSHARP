
namespace Biblioteca.View.Relatorio {
    partial class RelatorioLeitorView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioLeitorView));
            this.button1 = new System.Windows.Forms.Button();
            this.tbFim = new System.Windows.Forms.MaskedTextBox();
            this.tbInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LvLeitor = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Nascimento = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.CPF = new System.Windows.Forms.ColumnHeader();
            this.Endereco = new System.Windows.Forms.ColumnHeader();
            this.Emprestimos = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFim
            // 
            this.tbFim.Location = new System.Drawing.Point(186, 38);
            this.tbFim.Mask = "00/00/0000";
            this.tbFim.Name = "tbFim";
            this.tbFim.Size = new System.Drawing.Size(100, 23);
            this.tbFim.TabIndex = 23;
            this.tbFim.ValidatingType = typeof(System.DateTime);
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(44, 38);
            this.tbInicio.Mask = "00/00/0000";
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(100, 23);
            this.tbInicio.TabIndex = 22;
            this.tbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Até: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Do dia: ";
            // 
            // LvLeitor
            // 
            this.LvLeitor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Nascimento,
            this.Telefone,
            this.CPF,
            this.Endereco,
            this.Emprestimos});
            this.LvLeitor.FullRowSelect = true;
            this.LvLeitor.HideSelection = false;
            this.LvLeitor.HoverSelection = true;
            this.LvLeitor.Location = new System.Drawing.Point(44, 92);
            this.LvLeitor.Name = "LvLeitor";
            this.LvLeitor.Size = new System.Drawing.Size(711, 328);
            this.LvLeitor.TabIndex = 25;
            this.LvLeitor.UseCompatibleStateImageBehavior = false;
            this.LvLeitor.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // Nascimento
            // 
            this.Nascimento.Text = "Nascimento";
            this.Nascimento.Width = 100;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 80;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            // 
            // Endereco
            // 
            this.Endereco.Text = "Endereco";
            this.Endereco.Width = 150;
            // 
            // Emprestimos
            // 
            this.Emprestimos.Text = "Emprestimos";
            this.Emprestimos.Width = 100;
            // 
            // RelatorioLeitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LvLeitor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFim);
            this.Controls.Add(this.tbInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioLeitorView";
            this.Text = "Relatório de Leitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tbFim;
        private System.Windows.Forms.MaskedTextBox tbInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LvLeitor;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascimento;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Emprestimos;
    }
}