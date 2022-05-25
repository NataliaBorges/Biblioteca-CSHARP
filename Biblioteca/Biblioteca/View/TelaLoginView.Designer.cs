
namespace Biblioteca.View {
    partial class TelaLoginView {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.tbEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbSenha = new RJCodeAdvance.RJControls.RJTextBox();
            this.btLogar = new RJCodeAdvance.RJControls.RJButton();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.ibtSenha = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbCancel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ibtSenhaAberta = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Biblioteca.Properties.Resources.BOOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 488);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.BurlyWood;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Chocolate;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::Biblioteca.Properties.Resources.IconeLendo;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(474, 55);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.BurlyWood;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.tbEmail.BorderRadius = 15;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(412, 198);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "E-mail";
            this.tbEmail.Size = new System.Drawing.Size(228, 33);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = true;
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.BorderColor = System.Drawing.Color.BurlyWood;
            this.tbSenha.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.tbSenha.BorderRadius = 15;
            this.tbSenha.BorderSize = 2;
            this.tbSenha.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSenha.Location = new System.Drawing.Point(412, 239);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenha.Multiline = false;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSenha.PasswordChar = true;
            this.tbSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSenha.PlaceholderText = "Senha";
            this.tbSenha.Size = new System.Drawing.Size(228, 33);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.Texts = "";
            this.tbSenha.UnderlinedStyle = true;
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.Color.BurlyWood;
            this.btLogar.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.btLogar.BorderColor = System.Drawing.Color.Chocolate;
            this.btLogar.BorderRadius = 20;
            this.btLogar.BorderSize = 0;
            this.btLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogar.FlatAppearance.BorderSize = 0;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btLogar.Location = new System.Drawing.Point(412, 294);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(196, 39);
            this.btLogar.TabIndex = 5;
            this.btLogar.Text = "Logar";
            this.btLogar.TextColor = System.Drawing.Color.SaddleBrown;
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancelar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbCancelar.Location = new System.Drawing.Point(490, 351);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(0, 15);
            this.lbCancelar.TabIndex = 6;
            // 
            // ibtSenha
            // 
            this.ibtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtSenha.BackColor = System.Drawing.Color.Transparent;
            this.ibtSenha.FlatAppearance.BorderSize = 0;
            this.ibtSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ibtSenha.IconColor = System.Drawing.Color.SaddleBrown;
            this.ibtSenha.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtSenha.IconSize = 30;
            this.ibtSenha.Location = new System.Drawing.Point(365, 239);
            this.ibtSenha.Name = "ibtSenha";
            this.ibtSenha.Size = new System.Drawing.Size(40, 36);
            this.ibtSenha.TabIndex = 9;
            this.ibtSenha.Tag = "";
            this.ibtSenha.UseVisualStyleBackColor = false;
            this.ibtSenha.Click += new System.EventHandler(this.ibtSenha_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox1.IconColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.Location = new System.Drawing.Point(373, 201);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbCancel
            // 
            this.lbCancel.ActiveLinkColor = System.Drawing.Color.Red;
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.Location = new System.Drawing.Point(440, 336);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(50, 15);
            this.lbCancel.TabIndex = 11;
            this.lbCancel.TabStop = true;
            this.lbCancel.Text = "Cancelar";
            this.lbCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCancel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.LinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Location = new System.Drawing.Point(505, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci a senha";
            // 
            // ibtSenhaAberta
            // 
            this.ibtSenhaAberta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtSenhaAberta.BackColor = System.Drawing.Color.Transparent;
            this.ibtSenhaAberta.FlatAppearance.BorderSize = 0;
            this.ibtSenhaAberta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtSenhaAberta.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.ibtSenhaAberta.IconColor = System.Drawing.Color.SaddleBrown;
            this.ibtSenhaAberta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtSenhaAberta.IconSize = 30;
            this.ibtSenhaAberta.Location = new System.Drawing.Point(373, 239);
            this.ibtSenhaAberta.Name = "ibtSenhaAberta";
            this.ibtSenhaAberta.Size = new System.Drawing.Size(40, 36);
            this.ibtSenhaAberta.TabIndex = 13;
            this.ibtSenhaAberta.Tag = "";
            this.ibtSenhaAberta.UseVisualStyleBackColor = false;
            this.ibtSenhaAberta.Click += new System.EventHandler(this.ibtSenhaAberta_Click);
            // 
            // TelaLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(665, 484);
            this.Controls.Add(this.ibtSenhaAberta);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.ibtSenha);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLoginView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private RJCodeAdvance.RJControls.RJTextBox tbSenha;
        private RJCodeAdvance.RJControls.RJButton btLogar;
        private System.Windows.Forms.Label lbCancelar;
        private FontAwesome.Sharp.IconButton ibtSenha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.LinkLabel lbCancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton ibtSenhaAberta;
    }
}