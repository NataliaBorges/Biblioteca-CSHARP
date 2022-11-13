
namespace Biblioteca.View.Editora {
    partial class EditoraBuscarView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditoraBuscarView));
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarEditora = new FontAwesome.Sharp.IconButton();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridViewEditora = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEditora)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.rbCNPJ.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCNPJ.ForeColor = System.Drawing.Color.White;
            this.rbCNPJ.Location = new System.Drawing.Point(27, 56);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(66, 24);
            this.rbCNPJ.TabIndex = 14;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = false;
            this.rbCNPJ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCNPJ_MouseClick);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(27, 26);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 13;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            this.rbNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNome_MouseClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(287, 71);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(450, 27);
            this.tbBuscar.TabIndex = 12;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.btnCadastrarEditora);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(189, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 743);
            this.panel1.TabIndex = 18;
            // 
            // btnCadastrarEditora
            // 
            this.btnCadastrarEditora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCadastrarEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarEditora.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEditora.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarEditora.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEditora.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarEditora.IconColor = System.Drawing.Color.Olive;
            this.btnCadastrarEditora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarEditora.IconSize = 30;
            this.btnCadastrarEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEditora.Location = new System.Drawing.Point(865, 130);
            this.btnCadastrarEditora.Name = "btnCadastrarEditora";
            this.btnCadastrarEditora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrarEditora.Size = new System.Drawing.Size(180, 30);
            this.btnCadastrarEditora.TabIndex = 93;
            this.btnCadastrarEditora.Tag = "";
            this.btnCadastrarEditora.Text = "Cadastrar Editora";
            this.btnCadastrarEditora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarEditora.UseVisualStyleBackColor = true;
            this.btnCadastrarEditora.Click += new System.EventHandler(this.btnCadastrarEditora_Click);
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
            this.icbtnVoltar.Location = new System.Drawing.Point(246, 67);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 92;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.dtGridViewEditora);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 566);
            this.panel3.TabIndex = 63;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(817, 476);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 42);
            this.btnEditar.TabIndex = 107;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(463, 273);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 95;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1572, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(1634, 616);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 28);
            this.cbStatus.TabIndex = 93;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(1689, 576);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 27);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dtGridViewEditora
            // 
            this.dtGridViewEditora.AllowUserToAddRows = false;
            this.dtGridViewEditora.AllowUserToDeleteRows = false;
            this.dtGridViewEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridViewEditora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewEditora.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewEditora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewEditora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewEditora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEditora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewEditora.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewEditora.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewEditora.EnableHeadersVisualStyles = false;
            this.dtGridViewEditora.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewEditora.Location = new System.Drawing.Point(46, 145);
            this.dtGridViewEditora.Name = "dtGridViewEditora";
            this.dtGridViewEditora.ReadOnly = true;
            this.dtGridViewEditora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEditora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewEditora.RowHeadersVisible = false;
            this.dtGridViewEditora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGridViewEditora.RowTemplate.Height = 25;
            this.dtGridViewEditora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewEditora.Size = new System.Drawing.Size(944, 325);
            this.dtGridViewEditora.TabIndex = 30;
            this.dtGridViewEditora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewEditora_CellClick);
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
            this.panel2.Size = new System.Drawing.Size(1054, 112);
            this.panel2.TabIndex = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.CbEstado);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(804, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 88);
            this.groupBox1.TabIndex = 104;
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
            this.CbEstado.Location = new System.Drawing.Point(27, 35);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(140, 28);
            this.CbEstado.TabIndex = 97;
            this.CbEstado.SelectedValueChanged += new System.EventHandler(this.CbEstado_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.rbCNPJ);
            this.groupBox3.Controls.Add(this.rbNome);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(46, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 88);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE BUSCA";
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(420, 74);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(317, 39);
            this.lblCadastroLivro.TabIndex = 60;
            this.lblCadastroLivro.Text = "BUSCAR EDITORA";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1054, 37);
            this.head1.TabIndex = 31;
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
            this.pnltotal.Size = new System.Drawing.Size(1246, 749);
            this.pnltotal.TabIndex = 19;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(180, 743);
            this.menuControl1.TabIndex = 19;
            // 
            // EditoraBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1246, 749);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditoraBuscarView";
            this.Text = "Buscar Editora";
            this.Activated += new System.EventHandler(this.EditoraBuscarView_Activated);
            this.Load += new System.EventHandler(this.FornecedorBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEditora)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dtGridViewEditora;
        private System.Windows.Forms.Button btnBuscar;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private FontAwesome.Sharp.IconButton btnCadastrarEditora;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}