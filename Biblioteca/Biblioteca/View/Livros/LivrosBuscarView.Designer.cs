
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.dtGridViewLivros = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblBuscaLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.btnCadastrarLivro = new FontAwesome.Sharp.IconButton();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.livroModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivros)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnltotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEditora
            // 
            this.rbEditora.BackColor = System.Drawing.Color.Black;
            this.rbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEditora.ForeColor = System.Drawing.Color.White;
            this.rbEditora.Location = new System.Drawing.Point(127, 38);
            this.rbEditora.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbEditora.Name = "rbEditora";
            this.rbEditora.Size = new System.Drawing.Size(85, 20);
            this.rbEditora.TabIndex = 18;
            this.rbEditora.TabStop = true;
            this.rbEditora.Text = "Editora";
            this.rbEditora.UseVisualStyleBackColor = false;
            this.rbEditora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbEditora_MouseClick);
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.BackColor = System.Drawing.Color.Black;
            this.rbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAutor.ForeColor = System.Drawing.Color.White;
            this.rbAutor.Location = new System.Drawing.Point(20, 68);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(69, 24);
            this.rbAutor.TabIndex = 15;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            this.rbAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAutor_MouseClick);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Black;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(20, 38);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 14;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            this.rbNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNome_MouseClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(366, 93);
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
            this.panel1.Controls.Add(this.btnCadastrarLivro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(208, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 743);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.dtGridViewLivros);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 544);
            this.panel3.TabIndex = 33;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(899, 482);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 42);
            this.btnEditar.TabIndex = 106;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(536, 304);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 98;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
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
            this.dtGridViewLivros.Location = new System.Drawing.Point(89, 178);
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
            this.dtGridViewLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewLivros_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 132);
            this.panel2.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.CbEstado);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(886, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 107);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // CbEstado
            // 
            this.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEstado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Ambos",
            "Ativo",
            "Inativo"});
            this.CbEstado.Location = new System.Drawing.Point(9, 50);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(171, 28);
            this.CbEstado.TabIndex = 107;
            this.CbEstado.SelectedValueChanged += new System.EventHandler(this.CbEstado_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.rbNome);
            this.groupBox3.Controls.Add(this.rbAutor);
            this.groupBox3.Controls.Add(this.rbEditora);
            this.groupBox3.Controls.Add(this.rbGenero);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(89, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 117);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE BUSCA";
            // 
            // rbGenero
            // 
            this.rbGenero.BackColor = System.Drawing.Color.Black;
            this.rbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGenero.ForeColor = System.Drawing.Color.White;
            this.rbGenero.Location = new System.Drawing.Point(127, 68);
            this.rbGenero.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(85, 20);
            this.rbGenero.TabIndex = 32;
            this.rbGenero.TabStop = true;
            this.rbGenero.Text = "Gênero";
            this.rbGenero.UseVisualStyleBackColor = false;
            this.rbGenero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbGenero_MouseClick);
            // 
            // icbtnVoltar
            // 
            this.icbtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbtnVoltar.FlatAppearance.BorderSize = 0;
            this.icbtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icbtnVoltar.ForeColor = System.Drawing.Color.White;
            this.icbtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.icbtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.icbtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnVoltar.IconSize = 30;
            this.icbtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtnVoltar.Location = new System.Drawing.Point(238, 78);
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
            this.lblBuscaLivro.Location = new System.Drawing.Point(493, 78);
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
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarLivro.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLivro.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarLivro.IconColor = System.Drawing.Color.Olive;
            this.btnCadastrarLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarLivro.IconSize = 30;
            this.btnCadastrarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(986, 146);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}