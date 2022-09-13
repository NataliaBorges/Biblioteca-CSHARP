namespace Biblioteca.View.Livros
{
    partial class LivroPesquisarGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroPesquisarGenero));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.head1 = new Biblioteca.Util.Head();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeView = new System.Windows.Forms.Label();
            this.linkLblCadastrarGenero = new System.Windows.Forms.LinkLabel();
            this.LvGenero = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.56633F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.43367F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1093, 671);
            this.pnltotal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblNomeView);
            this.panel1.Controls.Add(this.linkLblCadastrarGenero);
            this.panel1.Controls.Add(this.LvGenero);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 665);
            this.panel1.TabIndex = 21;
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(896, 37);
            this.head1.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(204, 206);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 20);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            // 
            // lblNomeView
            // 
            this.lblNomeView.AutoSize = true;
            this.lblNomeView.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeView.ForeColor = System.Drawing.Color.White;
            this.lblNomeView.Location = new System.Drawing.Point(321, 115);
            this.lblNomeView.Name = "lblNomeView";
            this.lblNomeView.Size = new System.Drawing.Size(312, 32);
            this.lblNomeView.TabIndex = 27;
            this.lblNomeView.Text = "SELECIONAR GÊNERO";
            // 
            // linkLblCadastrarGenero
            // 
            this.linkLblCadastrarGenero.AutoSize = true;
            this.linkLblCadastrarGenero.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblCadastrarGenero.LinkColor = System.Drawing.Color.White;
            this.linkLblCadastrarGenero.Location = new System.Drawing.Point(588, 512);
            this.linkLblCadastrarGenero.Name = "linkLblCadastrarGenero";
            this.linkLblCadastrarGenero.Size = new System.Drawing.Size(119, 18);
            this.linkLblCadastrarGenero.TabIndex = 21;
            this.linkLblCadastrarGenero.TabStop = true;
            this.linkLblCadastrarGenero.Text = "Cadastrar gênero";
            this.linkLblCadastrarGenero.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // LvGenero
            // 
            this.LvGenero.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.LvGenero.BackColor = System.Drawing.Color.Black;
            this.LvGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvGenero.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome});
            this.LvGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvGenero.ForeColor = System.Drawing.Color.White;
            this.LvGenero.FullRowSelect = true;
            this.LvGenero.HideSelection = false;
            this.LvGenero.HoverSelection = true;
            this.LvGenero.Location = new System.Drawing.Point(220, 260);
            this.LvGenero.Name = "LvGenero";
            this.LvGenero.Size = new System.Drawing.Size(487, 233);
            this.LvGenero.TabIndex = 17;
            this.LvGenero.UseCompatibleStateImageBehavior = false;
            this.LvGenero.View = System.Windows.Forms.View.Details;
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
            this.Nome.Width = 400;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(267, 201);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(400, 27);
            this.tbBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(673, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 28);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(183, 665);
            this.menuControl1.TabIndex = 22;
            // 
            // LivroPesquisarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1093, 671);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LivroPesquisarGenero";
            this.Text = "Selecionar Gênero";
            this.Load += new System.EventHandler(this.LivroPesquisarGenero_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private Util.Head head1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeView;
        private System.Windows.Forms.LinkLabel linkLblCadastrarGenero;
        private System.Windows.Forms.ListView LvGenero;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private Util.MenuControl menuControl1;
    }
}