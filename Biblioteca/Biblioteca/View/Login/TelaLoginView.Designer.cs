
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginView));
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
            this.IbMinimizar = new FontAwesome.Sharp.IconButton();
            this.IbFechar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.PnlEmail = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PnlSenha = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.PnlEmail.SuspendLayout();
            this.PnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::Biblioteca.Properties.Resources.BOOF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 558);
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(300, 133);
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
            this.tbEmail.BorderRadius = 0;
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(45, 1);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "E-mail";
            this.tbEmail.Size = new System.Drawing.Size(251, 34);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = true;
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.BorderColor = System.Drawing.Color.BurlyWood;
            this.tbSenha.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.tbSenha.BorderRadius = 0;
            this.tbSenha.BorderSize = 2;
            this.tbSenha.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSenha.Location = new System.Drawing.Point(49, 4);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenha.Multiline = false;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSenha.PasswordChar = true;
            this.tbSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSenha.PlaceholderText = "Senha";
            this.tbSenha.Size = new System.Drawing.Size(247, 33);
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
            this.btLogar.Location = new System.Drawing.Point(250, 418);
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
            this.lbCancelar.Location = new System.Drawing.Point(300, 475);
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
            this.ibtSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ibtSenha.IconColor = System.Drawing.Color.SaddleBrown;
            this.ibtSenha.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtSenha.IconSize = 20;
            this.ibtSenha.Location = new System.Drawing.Point(302, 8);
            this.ibtSenha.Name = "ibtSenha";
            this.ibtSenha.Size = new System.Drawing.Size(27, 27);
            this.ibtSenha.TabIndex = 9;
            this.ibtSenha.Tag = "";
            this.ibtSenha.UseVisualStyleBackColor = false;
            this.ibtSenha.Click += new System.EventHandler(this.ibtSenha_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox1.IconColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(7, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbCancel
            // 
            this.lbCancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.Location = new System.Drawing.Point(273, 460);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(50, 15);
            this.lbCancel.TabIndex = 11;
            this.lbCancel.TabStop = true;
            this.lbCancel.Text = "Cancelar";
            this.lbCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCancel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.LinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Location = new System.Drawing.Point(349, 460);
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
            this.ibtSenhaAberta.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtSenhaAberta.IconColor = System.Drawing.Color.SaddleBrown;
            this.ibtSenhaAberta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtSenhaAberta.IconSize = 20;
            this.ibtSenhaAberta.Location = new System.Drawing.Point(302, 8);
            this.ibtSenhaAberta.Name = "ibtSenhaAberta";
            this.ibtSenhaAberta.Size = new System.Drawing.Size(27, 27);
            this.ibtSenhaAberta.TabIndex = 13;
            this.ibtSenhaAberta.Tag = "";
            this.ibtSenhaAberta.UseVisualStyleBackColor = false;
            this.ibtSenhaAberta.Click += new System.EventHandler(this.ibtSenhaAberta_Click);
            // 
            // IbMinimizar
            // 
            this.IbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IbMinimizar.BackColor = System.Drawing.Color.SaddleBrown;
            this.IbMinimizar.FlatAppearance.BorderSize = 0;
            this.IbMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.IbMinimizar.IconColor = System.Drawing.Color.White;
            this.IbMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbMinimizar.IconSize = 20;
            this.IbMinimizar.Location = new System.Drawing.Point(496, -2);
            this.IbMinimizar.Name = "IbMinimizar";
            this.IbMinimizar.Size = new System.Drawing.Size(40, 26);
            this.IbMinimizar.TabIndex = 15;
            this.IbMinimizar.Tag = "";
            this.IbMinimizar.UseVisualStyleBackColor = false;
            this.IbMinimizar.Click += new System.EventHandler(this.IbMinimizar_Click);
            // 
            // IbFechar
            // 
            this.IbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IbFechar.BackColor = System.Drawing.Color.SaddleBrown;
            this.IbFechar.FlatAppearance.BorderSize = 0;
            this.IbFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.IbFechar.IconColor = System.Drawing.Color.White;
            this.IbFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbFechar.IconSize = 20;
            this.IbFechar.Location = new System.Drawing.Point(532, -2);
            this.IbFechar.Name = "IbFechar";
            this.IbFechar.Size = new System.Drawing.Size(40, 26);
            this.IbFechar.TabIndex = 14;
            this.IbFechar.Tag = "";
            this.IbFechar.UseVisualStyleBackColor = false;
            this.IbFechar.Click += new System.EventHandler(this.IbFechar_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 5);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 16;
            this.iconPictureBox2.TabStop = false;
            // 
            // PnlEmail
            // 
            this.PnlEmail.BorderRadius = 20;
            this.PnlEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.PnlEmail.Controls.Add(this.tbEmail);
            this.PnlEmail.Controls.Add(this.iconPictureBox1);
            this.PnlEmail.Location = new System.Drawing.Point(173, 285);
            this.PnlEmail.Name = "PnlEmail";
            this.PnlEmail.Size = new System.Drawing.Size(338, 39);
            this.PnlEmail.TabIndex = 17;
            // 
            // PnlSenha
            // 
            this.PnlSenha.BorderRadius = 20;
            this.PnlSenha.Controls.Add(this.iconPictureBox3);
            this.PnlSenha.Controls.Add(this.iconPictureBox2);
            this.PnlSenha.Controls.Add(this.tbSenha);
            this.PnlSenha.Controls.Add(this.ibtSenhaAberta);
            this.PnlSenha.Controls.Add(this.ibtSenha);
            this.PnlSenha.Location = new System.Drawing.Point(173, 349);
            this.PnlSenha.Name = "PnlSenha";
            this.PnlSenha.Size = new System.Drawing.Size(338, 40);
            this.PnlSenha.TabIndex = 18;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox3.IconColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox3.IconSize = 35;
            this.iconPictureBox3.Location = new System.Drawing.Point(79, -72);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 564);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Controls.Add(this.PnlSenha);
            this.panel1.Controls.Add(this.btLogar);
            this.panel1.Controls.Add(this.PnlEmail);
            this.panel1.Controls.Add(this.lbCancelar);
            this.panel1.Controls.Add(this.IbMinimizar);
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Controls.Add(this.IbFechar);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(577, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 558);
            this.panel1.TabIndex = 1;
            // 
            // TelaLoginView
            // 
            this.AcceptButton = this.btLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1149, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.PnlEmail.ResumeLayout(false);
            this.PnlEmail.PerformLayout();
            this.PnlSenha.ResumeLayout(false);
            this.PnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private RJCodeAdvance.RJControls.RJTextBox tbSenha;
        private RJCodeAdvance.RJControls.RJButton btLogar;
        private System.Windows.Forms.Label lbCancelar;
        private FontAwesome.Sharp.IconButton ibtSenha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.LinkLabel lbCancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton ibtSenhaAberta;
        private FontAwesome.Sharp.IconButton IbMinimizar;
        private FontAwesome.Sharp.IconButton IbFechar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PnlEmail;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PnlSenha;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}