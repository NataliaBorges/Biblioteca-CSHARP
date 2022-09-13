namespace Biblioteca.View.Livros
{
    partial class LivroPesquisarAutor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroPesquisarAutor));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.head1 = new Biblioteca.Util.Head();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeView = new System.Windows.Forms.Label();
            this.linkLblCadastrarAutor = new System.Windows.Forms.LinkLabel();
            this.LvAutor = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.livroModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1262, 687);
            this.pnltotal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.head1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblNomeView);
            this.panel1.Controls.Add(this.linkLblCadastrarAutor);
            this.panel1.Controls.Add(this.LvAutor);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(192, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 681);
            this.panel1.TabIndex = 21;
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1067, 37);
            this.head1.TabIndex = 29;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(272, 206);
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
            this.lblNomeView.Location = new System.Drawing.Point(431, 117);
            this.lblNomeView.Name = "lblNomeView";
            this.lblNomeView.Size = new System.Drawing.Size(294, 32);
            this.lblNomeView.TabIndex = 27;
            this.lblNomeView.Text = "SELECIONAR AUTOR";
            // 
            // linkLblCadastrarAutor
            // 
            this.linkLblCadastrarAutor.AutoSize = true;
            this.linkLblCadastrarAutor.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblCadastrarAutor.LinkColor = System.Drawing.Color.White;
            this.linkLblCadastrarAutor.Location = new System.Drawing.Point(662, 514);
            this.linkLblCadastrarAutor.Name = "linkLblCadastrarAutor";
            this.linkLblCadastrarAutor.Size = new System.Drawing.Size(113, 18);
            this.linkLblCadastrarAutor.TabIndex = 21;
            this.linkLblCadastrarAutor.TabStop = true;
            this.linkLblCadastrarAutor.Text = "Cadastrar Autor";
            this.linkLblCadastrarAutor.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // LvAutor
            // 
            this.LvAutor.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.LvAutor.BackColor = System.Drawing.Color.Black;
            this.LvAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvAutor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome});
            this.LvAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvAutor.ForeColor = System.Drawing.Color.White;
            this.LvAutor.FullRowSelect = true;
            this.LvAutor.HideSelection = false;
            this.LvAutor.HoverSelection = true;
            this.LvAutor.Location = new System.Drawing.Point(288, 260);
            this.LvAutor.Name = "LvAutor";
            this.LvAutor.Size = new System.Drawing.Size(487, 233);
            this.LvAutor.TabIndex = 17;
            this.LvAutor.UseCompatibleStateImageBehavior = false;
            this.LvAutor.View = System.Windows.Forms.View.Details;
            this.LvAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvAutor_MouseClick);
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
            this.tbBuscar.Location = new System.Drawing.Point(335, 201);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(400, 27);
            this.tbBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(741, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 28);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(183, 681);
            this.menuControl1.TabIndex = 22;
            // 
            // livroModelBindingSource
            // 
            this.livroModelBindingSource.DataSource = typeof(Biblioteca.Model.LivroModel);
            // 
            // LivroPesquisarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 687);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LivroPesquisarAutor";
            this.Text = "Selecionar Autor";
            this.Load += new System.EventHandler(this.LivroPesquisarAutor_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LvAutor;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.LinkLabel linkLblCadastrarAutor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeView;
        private System.Windows.Forms.BindingSource livroModelBindingSource;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
    }
}