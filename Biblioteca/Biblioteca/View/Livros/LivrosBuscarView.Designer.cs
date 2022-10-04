
namespace Biblioteca.View.Livros {
    partial class LivrosBuscarView {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivrosBuscarView));
            this.rbEditora = new System.Windows.Forms.RadioButton();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddExemplar = new FontAwesome.Sharp.IconButton();
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.btnCadastrarLivro = new FontAwesome.Sharp.IconButton();
            this.dtGridViewLivros = new System.Windows.Forms.DataGridView();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblBuscaLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.livroModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNotFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivros)).BeginInit();
            this.pnltotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEditora
            // 
            this.rbEditora.BackColor = System.Drawing.Color.Transparent;
            this.rbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEditora.ForeColor = System.Drawing.Color.White;
            this.rbEditora.Location = new System.Drawing.Point(687, 55);
            this.rbEditora.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbEditora.Name = "rbEditora";
            this.rbEditora.Size = new System.Drawing.Size(105, 20);
            this.rbEditora.TabIndex = 18;
            this.rbEditora.TabStop = true;
            this.rbEditora.Text = "Editora";
            this.rbEditora.UseVisualStyleBackColor = false;
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.BackColor = System.Drawing.Color.Transparent;
            this.rbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAutor.ForeColor = System.Drawing.Color.White;
            this.rbAutor.Location = new System.Drawing.Point(592, 55);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(69, 24);
            this.rbAutor.TabIndex = 15;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(486, 55);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 14;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(350, 160);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(460, 27);
            this.tbBuscar.TabIndex = 13;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblBuscaLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(208, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 743);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.btnAddExemplar);
            this.panel3.Controls.Add(this.rbGenero);
            this.panel3.Controls.Add(this.rbEditora);
            this.panel3.Controls.Add(this.rbAutor);
            this.panel3.Controls.Add(this.rbNome);
            this.panel3.Controls.Add(this.btnCadastrarLivro);
            this.panel3.Controls.Add(this.dtGridViewLivros);
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Controls.Add(this.lblSelecionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 578);
            this.panel3.TabIndex = 33;
            // 
            // btnAddExemplar
            // 
            this.btnAddExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddExemplar.FlatAppearance.BorderSize = 0;
            this.btnAddExemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExemplar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExemplar.ForeColor = System.Drawing.Color.White;
            this.btnAddExemplar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddExemplar.IconColor = System.Drawing.Color.Olive;
            this.btnAddExemplar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddExemplar.IconSize = 30;
            this.btnAddExemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExemplar.Location = new System.Drawing.Point(732, 498);
            this.btnAddExemplar.Name = "btnAddExemplar";
            this.btnAddExemplar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddExemplar.Size = new System.Drawing.Size(191, 38);
            this.btnAddExemplar.TabIndex = 97;
            this.btnAddExemplar.Tag = "";
            this.btnAddExemplar.Text = "Adicionar Exemplar";
            this.btnAddExemplar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddExemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddExemplar.UseVisualStyleBackColor = true;
            // 
            // rbGenero
            // 
            this.rbGenero.BackColor = System.Drawing.Color.Transparent;
            this.rbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGenero.ForeColor = System.Drawing.Color.White;
            this.rbGenero.Location = new System.Drawing.Point(798, 55);
            this.rbGenero.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(105, 20);
            this.rbGenero.TabIndex = 32;
            this.rbGenero.TabStop = true;
            this.rbGenero.Text = "Gênero";
            this.rbGenero.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarLivro.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLivro.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarLivro.IconColor = System.Drawing.Color.Olive;
            this.btnCadastrarLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarLivro.IconSize = 30;
            this.btnCadastrarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(920, 498);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrarLivro.Size = new System.Drawing.Size(164, 30);
            this.btnCadastrarLivro.TabIndex = 91;
            this.btnCadastrarLivro.Tag = "";
            this.btnCadastrarLivro.Text = "Cadastrar Livro";
            this.btnCadastrarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // dtGridViewLivros
            // 
            this.dtGridViewLivros.AllowUserToAddRows = false;
            this.dtGridViewLivros.AllowUserToDeleteRows = false;
            this.dtGridViewLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtGridViewLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewLivros.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewLivros.ColumnHeadersHeight = 30;
            this.dtGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewLivros.EnableHeadersVisualStyles = false;
            this.dtGridViewLivros.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewLivros.Location = new System.Drawing.Point(89, 194);
            this.dtGridViewLivros.Name = "dtGridViewLivros";
            this.dtGridViewLivros.ReadOnly = true;
            this.dtGridViewLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewLivros.RowHeadersVisible = false;
            this.dtGridViewLivros.RowTemplate.Height = 25;
            this.dtGridViewLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewLivros.Size = new System.Drawing.Size(983, 298);
            this.dtGridViewLivros.TabIndex = 37;
            this.dtGridViewLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewLivros_CellContentClick_1);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelecionar.ForeColor = System.Drawing.Color.White;
            this.lblSelecionar.Location = new System.Drawing.Point(287, 57);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(193, 20);
            this.lblSelecionar.TabIndex = 28;
            this.lblSelecionar.Text = "Selecione o tipo da busca:";
            // 
            // icbtnVoltar
            // 
            this.icbtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtnVoltar.FlatAppearance.BorderSize = 0;
            this.icbtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icbtnVoltar.ForeColor = System.Drawing.Color.White;
            this.icbtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.icbtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.icbtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnVoltar.IconSize = 30;
            this.icbtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnVoltar.Location = new System.Drawing.Point(219, 96);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 90;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // lblBuscaLivro
            // 
            this.lblBuscaLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscaLivro.AutoSize = true;
            this.lblBuscaLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscaLivro.ForeColor = System.Drawing.Color.White;
            this.lblBuscaLivro.Location = new System.Drawing.Point(474, 96);
            this.lblBuscaLivro.Name = "lblBuscaLivro";
            this.lblBuscaLivro.Size = new System.Drawing.Size(269, 39);
            this.lblBuscaLivro.TabIndex = 30;
            this.lblBuscaLivro.Text = "BUSCAR LIVRO";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1159, 37);
            this.head1.TabIndex = 29;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1370, 749);
            this.pnltotal.TabIndex = 21;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(183, 743);
            this.menuControl1.TabIndex = 21;
            // 
            // livroModelBindingSource
            // 
            this.livroModelBindingSource.DataSource = typeof(Biblioteca.Model.LivroModel);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(515, 311);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 98;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // LivrosBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LivrosBuscarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Livros";
            this.Activated += new System.EventHandler(this.LivrosBuscarView_Activated);
            this.Load += new System.EventHandler(this.LivrosBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivros)).EndInit();
            this.pnltotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livroModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEditora;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Label lblSelecionar;
        private Util.Head head1;
        private System.Windows.Forms.Label lblBuscaLivro;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.RadioButton rbGenero;
        private System.Windows.Forms.BindingSource livroModelBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridViewLivros;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private FontAwesome.Sharp.IconButton btnCadastrarLivro;
        private System.Windows.Forms.DataGridView dtGridViewLivro;
        private FontAwesome.Sharp.IconButton btnAddExemplar;
        private System.Windows.Forms.Label lblNotFound;
    }
}