namespace Biblioteca.Util
{
    partial class Head
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
            this.panelTituloBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pnlMaxmin = new System.Windows.Forms.Panel();
            this.icButtonFechar = new FontAwesome.Sharp.IconButton();
            this.icButtonMin = new FontAwesome.Sharp.IconButton();
            this.icButtonMax = new FontAwesome.Sharp.IconButton();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pboxUser = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.pnlWindows = new System.Windows.Forms.Panel();
            this.iconButtonFechar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximizar = new FontAwesome.Sharp.IconButton();
            this.panelTituloBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.pnlMaxmin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).BeginInit();
            this.pnlWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTituloBar
            // 
            this.panelTituloBar.BackColor = System.Drawing.Color.Black;
            this.panelTituloBar.Controls.Add(this.panel1);
            this.panelTituloBar.Controls.Add(this.pnlMaxmin);
            this.panelTituloBar.Controls.Add(this.pnlUser);
            this.panelTituloBar.Controls.Add(this.pnlWindows);
            this.panelTituloBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTituloBar.ForeColor = System.Drawing.Color.Black;
            this.panelTituloBar.Location = new System.Drawing.Point(0, 0);
            this.panelTituloBar.Name = "panelTituloBar";
            this.panelTituloBar.Size = new System.Drawing.Size(1063, 37);
            this.panelTituloBar.TabIndex = 2;
            this.panelTituloBar.Resize += new System.EventHandler(this.panelTituloBar_Resize_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Location = new System.Drawing.Point(918, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 39);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "L";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Chocolate;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Sienna;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(0, -1);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 4;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // pnlMaxmin
            // 
            this.pnlMaxmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaxmin.BackColor = System.Drawing.Color.DimGray;
            this.pnlMaxmin.Controls.Add(this.icButtonFechar);
            this.pnlMaxmin.Controls.Add(this.icButtonMin);
            this.pnlMaxmin.Controls.Add(this.icButtonMax);
            this.pnlMaxmin.Location = new System.Drawing.Point(956, 0);
            this.pnlMaxmin.Name = "pnlMaxmin";
            this.pnlMaxmin.Size = new System.Drawing.Size(107, 38);
            this.pnlMaxmin.TabIndex = 8;
            // 
            // icButtonFechar
            // 
            this.icButtonFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icButtonFechar.FlatAppearance.BorderSize = 0;
            this.icButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icButtonFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icButtonFechar.IconColor = System.Drawing.Color.White;
            this.icButtonFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icButtonFechar.IconSize = 20;
            this.icButtonFechar.Location = new System.Drawing.Point(66, 0);
            this.icButtonFechar.Name = "icButtonFechar";
            this.icButtonFechar.Size = new System.Drawing.Size(41, 38);
            this.icButtonFechar.TabIndex = 2;
            this.icButtonFechar.Tag = "";
            this.icButtonFechar.UseVisualStyleBackColor = false;
            this.icButtonFechar.Click += new System.EventHandler(this.icButtonFechar_Click);
            // 
            // icButtonMin
            // 
            this.icButtonMin.BackColor = System.Drawing.Color.Black;
            this.icButtonMin.FlatAppearance.BorderSize = 0;
            this.icButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icButtonMin.IconColor = System.Drawing.Color.White;
            this.icButtonMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icButtonMin.IconSize = 20;
            this.icButtonMin.Location = new System.Drawing.Point(0, 0);
            this.icButtonMin.Name = "icButtonMin";
            this.icButtonMin.Size = new System.Drawing.Size(35, 38);
            this.icButtonMin.TabIndex = 4;
            this.icButtonMin.Tag = "";
            this.icButtonMin.UseVisualStyleBackColor = false;
            this.icButtonMin.Click += new System.EventHandler(this.icButtonMin_Click);
            // 
            // icButtonMax
            // 
            this.icButtonMax.BackColor = System.Drawing.Color.Black;
            this.icButtonMax.FlatAppearance.BorderSize = 0;
            this.icButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icButtonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icButtonMax.IconColor = System.Drawing.Color.White;
            this.icButtonMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icButtonMax.IconSize = 20;
            this.icButtonMax.Location = new System.Drawing.Point(32, 0);
            this.icButtonMax.Name = "icButtonMax";
            this.icButtonMax.Size = new System.Drawing.Size(37, 38);
            this.icButtonMax.TabIndex = 3;
            this.icButtonMax.Tag = "";
            this.icButtonMax.UseVisualStyleBackColor = false;
            this.icButtonMax.Click += new System.EventHandler(this.icButtonMax_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.BackColor = System.Drawing.Color.Black;
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Controls.Add(this.pboxUser);
            this.pnlUser.Location = new System.Drawing.Point(1783, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(40, 39);
            this.pnlUser.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(19, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "L";
            // 
            // pboxUser
            // 
            this.pboxUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pboxUser.BorderColor = System.Drawing.Color.Chocolate;
            this.pboxUser.BorderColor2 = System.Drawing.Color.Sienna;
            this.pboxUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pboxUser.BorderSize = 2;
            this.pboxUser.GradientAngle = 50F;
            this.pboxUser.Location = new System.Drawing.Point(0, -1);
            this.pboxUser.Name = "pboxUser";
            this.pboxUser.Size = new System.Drawing.Size(39, 39);
            this.pboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUser.TabIndex = 4;
            this.pboxUser.TabStop = false;
            // 
            // pnlWindows
            // 
            this.pnlWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWindows.BackColor = System.Drawing.Color.DimGray;
            this.pnlWindows.Controls.Add(this.iconButtonFechar);
            this.pnlWindows.Controls.Add(this.iconButtonMinimizar);
            this.pnlWindows.Controls.Add(this.iconButtonMaximizar);
            this.pnlWindows.Location = new System.Drawing.Point(1820, 0);
            this.pnlWindows.Name = "pnlWindows";
            this.pnlWindows.Size = new System.Drawing.Size(108, 38);
            this.pnlWindows.TabIndex = 5;
            // 
            // iconButtonFechar
            // 
            this.iconButtonFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButtonFechar.FlatAppearance.BorderSize = 0;
            this.iconButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonFechar.IconColor = System.Drawing.Color.White;
            this.iconButtonFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFechar.IconSize = 20;
            this.iconButtonFechar.Location = new System.Drawing.Point(68, 0);
            this.iconButtonFechar.Name = "iconButtonFechar";
            this.iconButtonFechar.Size = new System.Drawing.Size(40, 38);
            this.iconButtonFechar.TabIndex = 2;
            this.iconButtonFechar.Tag = "";
            this.iconButtonFechar.UseVisualStyleBackColor = false;
            // 
            // iconButtonMinimizar
            // 
            this.iconButtonMinimizar.BackColor = System.Drawing.Color.Black;
            this.iconButtonMinimizar.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimizar.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimizar.IconSize = 20;
            this.iconButtonMinimizar.Location = new System.Drawing.Point(0, 0);
            this.iconButtonMinimizar.Name = "iconButtonMinimizar";
            this.iconButtonMinimizar.Size = new System.Drawing.Size(35, 38);
            this.iconButtonMinimizar.TabIndex = 4;
            this.iconButtonMinimizar.Tag = "";
            this.iconButtonMinimizar.UseVisualStyleBackColor = false;
            // 
            // iconButtonMaximizar
            // 
            this.iconButtonMaximizar.BackColor = System.Drawing.Color.Black;
            this.iconButtonMaximizar.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaximizar.IconColor = System.Drawing.Color.White;
            this.iconButtonMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaximizar.IconSize = 20;
            this.iconButtonMaximizar.Location = new System.Drawing.Point(32, 0);
            this.iconButtonMaximizar.Name = "iconButtonMaximizar";
            this.iconButtonMaximizar.Size = new System.Drawing.Size(37, 38);
            this.iconButtonMaximizar.TabIndex = 3;
            this.iconButtonMaximizar.Tag = "";
            this.iconButtonMaximizar.UseVisualStyleBackColor = false;
            // 
            // Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTituloBar);
            this.Name = "Head";
            this.Size = new System.Drawing.Size(1063, 37);
            this.panelTituloBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.pnlMaxmin.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).EndInit();
            this.pnlWindows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloBar;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUser;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pboxUser;
        private System.Windows.Forms.Panel pnlWindows;
        private FontAwesome.Sharp.IconButton iconButtonFechar;
        private FontAwesome.Sharp.IconButton iconButtonMinimizar;
        private FontAwesome.Sharp.IconButton iconButtonMaximizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel pnlMaxmin;
        private FontAwesome.Sharp.IconButton icButtonFechar;
        private FontAwesome.Sharp.IconButton icButtonMin;
        private FontAwesome.Sharp.IconButton icButtonMax;
    }
}
