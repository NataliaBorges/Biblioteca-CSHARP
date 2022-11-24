namespace Biblioteca.Util
{
    partial class UsuarioControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.btnTrocarSenha = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(90, 14);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(49, 20);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "nome";
            // 
            // lbFuncao
            // 
            this.lbFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFuncao.ForeColor = System.Drawing.Color.White;
            this.lbFuncao.Location = new System.Drawing.Point(83, 53);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(57, 20);
            this.lbFuncao.TabIndex = 1;
            this.lbFuncao.Text = "funcao";
            // 
            // btnTrocarSenha
            // 
            this.btnTrocarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnTrocarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarSenha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTrocarSenha.FlatAppearance.BorderSize = 0;
            this.btnTrocarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarSenha.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrocarSenha.ForeColor = System.Drawing.Color.White;
            this.btnTrocarSenha.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnTrocarSenha.IconColor = System.Drawing.Color.Chocolate;
            this.btnTrocarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrocarSenha.IconSize = 30;
            this.btnTrocarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocarSenha.Location = new System.Drawing.Point(0, 84);
            this.btnTrocarSenha.Name = "btnTrocarSenha";
            this.btnTrocarSenha.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrocarSenha.Size = new System.Drawing.Size(228, 46);
            this.btnTrocarSenha.TabIndex = 5;
            this.btnTrocarSenha.Tag = "Trocar Senha";
            this.btnTrocarSenha.Text = "  Trocar Senha";
            this.btnTrocarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrocarSenha.UseVisualStyleBackColor = false;
            this.btnTrocarSenha.Click += new System.EventHandler(this.btnTrocarSenha_Click);
            // 
            // UsuarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnTrocarSenha);
            this.Controls.Add(this.lbFuncao);
            this.Controls.Add(this.panel1);
            this.Name = "UsuarioControl";
            this.Size = new System.Drawing.Size(228, 130);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbFuncao;
        private FontAwesome.Sharp.IconButton btnTrocarSenha;
    }
}
