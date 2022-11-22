namespace Biblioteca.View.Login
{
    partial class RecuperarSenhaView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarSenhaView));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCancel = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlEmail = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tbEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btLogar = new RJCodeAdvance.RJControls.RJButton();
            this.pnEnviado = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnEnviado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(36)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(99, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECUPERAÇÃO DE SENHA";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.96356F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.03644F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 550);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Biblioteca.Properties.Resources.ICON;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 544);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.pnEnviado);
            this.panel2.Controls.Add(this.lbCancel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PnlEmail);
            this.panel2.Controls.Add(this.btLogar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(466, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 544);
            this.panel2.TabIndex = 2;
            // 
            // lbCancel
            // 
            this.lbCancel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(24)))), ((int)(((byte)(1)))));
            this.lbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCancel.AutoSize = true;
            this.lbCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lbCancel.Location = new System.Drawing.Point(221, 431);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(50, 15);
            this.lbCancel.TabIndex = 23;
            this.lbCancel.TabStop = true;
            this.lbCancel.Text = "Cancelar";
            this.lbCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCancel_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.BurlyWood;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(47, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 78);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Encaminharemos um e-mail com sua senha.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(187, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Insira seu e-mail.";
            // 
            // PnlEmail
            // 
            this.PnlEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlEmail.BorderRadius = 20;
            this.PnlEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.PnlEmail.Controls.Add(this.iconPictureBox2);
            this.PnlEmail.Controls.Add(this.tbEmail);
            this.PnlEmail.Controls.Add(this.iconPictureBox1);
            this.PnlEmail.Location = new System.Drawing.Point(47, 298);
            this.PnlEmail.Name = "PnlEmail";
            this.PnlEmail.Size = new System.Drawing.Size(424, 39);
            this.PnlEmail.TabIndex = 19;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox2.IconColor = System.Drawing.Color.SaddleBrown;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(9, 1);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
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
            this.tbEmail.Location = new System.Drawing.Point(45, 2);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "E-mail";
            this.tbEmail.Size = new System.Drawing.Size(353, 34);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = true;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(119, -76);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // btLogar
            // 
            this.btLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btLogar.Location = new System.Drawing.Point(149, 389);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(196, 39);
            this.btLogar.TabIndex = 18;
            this.btLogar.Text = "ENVIAR";
            this.btLogar.TextColor = System.Drawing.Color.SaddleBrown;
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnEnviado
            // 
            this.pnEnviado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnEnviado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            this.pnEnviado.Controls.Add(this.label4);
            this.pnEnviado.Location = new System.Drawing.Point(131, 344);
            this.pnEnviado.Name = "pnEnviado";
            this.pnEnviado.Size = new System.Drawing.Size(233, 39);
            this.pnEnviado.TabIndex = 24;
            this.pnEnviado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(87)))), ((int)(((byte)(31)))));
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-mail enviado com sucesso!";
            // 
            // RecuperarSenhaView
            // 
            this.AcceptButton = this.btLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecuperarSenhaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarSenhaView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnlEmail.ResumeLayout(false);
            this.PnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnEnviado.ResumeLayout(false);
            this.pnEnviado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton btLogar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PnlEmail;
        private RJCodeAdvance.RJControls.RJTextBox tbEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbCancel;
        private System.Windows.Forms.Panel pnEnviado;
        private System.Windows.Forms.Label label4;
    }
}