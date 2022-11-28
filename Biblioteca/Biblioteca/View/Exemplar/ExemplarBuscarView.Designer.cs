namespace Biblioteca.View.Exemplar
{
    partial class ExemplarBuscarView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExemplarBuscarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarExemplar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.rbEditora = new System.Windows.Forms.RadioButton();
            this.dtGridViewExemplar = new System.Windows.Forms.DataGridView();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblBuscaLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnltotal.Controls.Add(this.panel1, 0, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1304, 763);
            this.pnltotal.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnCadastrarExemplar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblBuscaLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 757);
            this.panel1.TabIndex = 22;
            // 
            // btnCadastrarExemplar
            // 
            this.btnCadastrarExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarExemplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarExemplar.FlatAppearance.BorderSize = 0;
            this.btnCadastrarExemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarExemplar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarExemplar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarExemplar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarExemplar.IconColor = System.Drawing.Color.Olive;
            this.btnCadastrarExemplar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarExemplar.IconSize = 30;
            this.btnCadastrarExemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarExemplar.Location = new System.Drawing.Point(903, 151);
            this.btnCadastrarExemplar.Name = "btnCadastrarExemplar";
            this.btnCadastrarExemplar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrarExemplar.Size = new System.Drawing.Size(191, 30);
            this.btnCadastrarExemplar.TabIndex = 92;
            this.btnCadastrarExemplar.Tag = "";
            this.btnCadastrarExemplar.Text = "Cadastrar Exemplar";
            this.btnCadastrarExemplar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarExemplar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarExemplar.UseVisualStyleBackColor = true;
            this.btnCadastrarExemplar.Click += new System.EventHandler(this.btnCadastrarExemplar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNotFound);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtGridViewExemplar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 570);
            this.panel2.TabIndex = 91;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(495, 308);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 104;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(870, 508);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 42);
            this.btnEditar.TabIndex = 105;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(361, 86);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(460, 27);
            this.tbBuscar.TabIndex = 102;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 129);
            this.panel3.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.CbEstado);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(857, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 107);
            this.groupBox1.TabIndex = 115;
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
            this.CbEstado.Location = new System.Drawing.Point(8, 43);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(170, 28);
            this.CbEstado.TabIndex = 114;
            this.CbEstado.SelectedValueChanged += new System.EventHandler(this.CbEstado_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.rbCodigo);
            this.groupBox3.Controls.Add(this.rbNome);
            this.groupBox3.Controls.Add(this.rbAutor);
            this.groupBox3.Controls.Add(this.rbGenero);
            this.groupBox3.Controls.Add(this.rbEditora);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(60, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 117);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE BUSCA";
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.rbCodigo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(17, 26);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(80, 24);
            this.rbCodigo.TabIndex = 116;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = false;
            this.rbCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCodigo_MouseClick);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(17, 54);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 109;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            this.rbNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNome_MouseClick);
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.BackColor = System.Drawing.Color.Transparent;
            this.rbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAutor.ForeColor = System.Drawing.Color.White;
            this.rbAutor.Location = new System.Drawing.Point(17, 84);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(69, 24);
            this.rbAutor.TabIndex = 110;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = false;
            this.rbAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAutor_MouseClick);
            // 
            // rbGenero
            // 
            this.rbGenero.BackColor = System.Drawing.Color.Transparent;
            this.rbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGenero.ForeColor = System.Drawing.Color.White;
            this.rbGenero.Location = new System.Drawing.Point(132, 66);
            this.rbGenero.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(105, 20);
            this.rbGenero.TabIndex = 113;
            this.rbGenero.TabStop = true;
            this.rbGenero.Text = "Gênero";
            this.rbGenero.UseVisualStyleBackColor = false;
            this.rbGenero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbGenero_MouseClick);
            // 
            // rbEditora
            // 
            this.rbEditora.BackColor = System.Drawing.Color.Transparent;
            this.rbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEditora.ForeColor = System.Drawing.Color.White;
            this.rbEditora.Location = new System.Drawing.Point(132, 40);
            this.rbEditora.MaximumSize = new System.Drawing.Size(180, 192);
            this.rbEditora.Name = "rbEditora";
            this.rbEditora.Size = new System.Drawing.Size(105, 20);
            this.rbEditora.TabIndex = 111;
            this.rbEditora.TabStop = true;
            this.rbEditora.Text = "Editora";
            this.rbEditora.UseVisualStyleBackColor = false;
            this.rbEditora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbEditora_MouseClick);
            // 
            // dtGridViewExemplar
            // 
            this.dtGridViewExemplar.AllowUserToAddRows = false;
            this.dtGridViewExemplar.AllowUserToDeleteRows = false;
            this.dtGridViewExemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtGridViewExemplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewExemplar.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewExemplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewExemplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewExemplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewExemplar.ColumnHeadersHeight = 30;
            this.dtGridViewExemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewExemplar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewExemplar.EnableHeadersVisualStyles = false;
            this.dtGridViewExemplar.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewExemplar.Location = new System.Drawing.Point(60, 152);
            this.dtGridViewExemplar.Name = "dtGridViewExemplar";
            this.dtGridViewExemplar.ReadOnly = true;
            this.dtGridViewExemplar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExemplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewExemplar.RowHeadersVisible = false;
            this.dtGridViewExemplar.RowTemplate.Height = 25;
            this.dtGridViewExemplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewExemplar.Size = new System.Drawing.Size(983, 352);
            this.dtGridViewExemplar.TabIndex = 103;
            this.dtGridViewExemplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewExemplar_CellClick);
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
            this.icbtnVoltar.Location = new System.Drawing.Point(300, 119);
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
            this.lblBuscaLivro.Location = new System.Drawing.Point(421, 116);
            this.lblBuscaLivro.Name = "lblBuscaLivro";
            this.lblBuscaLivro.Size = new System.Drawing.Size(343, 39);
            this.lblBuscaLivro.TabIndex = 30;
            this.lblBuscaLivro.Text = "BUSCAR EXEMPLAR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1103, 37);
            this.head1.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(189, 757);
            this.menuControl1.TabIndex = 21;
            // 
            // ExemplarBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1304, 763);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExemplarBuscarView";
            this.Text = "ExemplarBuscarView";
            this.Activated += new System.EventHandler(this.ExemplarBuscarView_Activated);
            this.Load += new System.EventHandler(this.ExemplarBuscarView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExemplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label lblBuscaLivro;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.DataGridView dtGridViewExemplar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.RadioButton rbGenero;
        private System.Windows.Forms.RadioButton rbEditora;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbAutor;
        private FontAwesome.Sharp.IconButton btnCadastrarExemplar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}