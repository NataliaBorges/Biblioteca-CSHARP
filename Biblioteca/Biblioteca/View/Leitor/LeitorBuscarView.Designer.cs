
namespace Biblioteca.View.Leitor {
    partial class LeitorBuscarView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeitorBuscarView));
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarLeitor = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtGridViewLeitor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLeitor)).BeginInit();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.BackColor = System.Drawing.Color.Transparent;
            this.rbCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbCPF.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(640, 62);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(57, 24);
            this.rbCPF.TabIndex = 9;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = false;
            this.rbCPF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCPF_MouseClick);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.Color.Transparent;
            this.rbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(547, 62);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(71, 24);
            this.rbNome.TabIndex = 8;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            this.rbNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNome_MouseClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(238, 110);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(571, 27);
            this.tbBuscar.TabIndex = 7;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnCadastrarLeitor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(188, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 757);
            this.panel1.TabIndex = 16;
            // 
            // btnCadastrarLeitor
            // 
            this.btnCadastrarLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarLeitor.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLeitor.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarLeitor.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLeitor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarLeitor.IconColor = System.Drawing.Color.Olive;
            this.btnCadastrarLeitor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarLeitor.IconSize = 30;
            this.btnCadastrarLeitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarLeitor.Location = new System.Drawing.Point(867, 167);
            this.btnCadastrarLeitor.Name = "btnCadastrarLeitor";
            this.btnCadastrarLeitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrarLeitor.Size = new System.Drawing.Size(180, 40);
            this.btnCadastrarLeitor.TabIndex = 95;
            this.btnCadastrarLeitor.Tag = "";
            this.btnCadastrarLeitor.Text = "Cadastrar Leitor";
            this.btnCadastrarLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarLeitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarLeitor.UseVisualStyleBackColor = true;
            this.btnCadastrarLeitor.Click += new System.EventHandler(this.btnCadastrarLeitor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.rbCPF);
            this.panel3.Controls.Add(this.rbNome);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.dtGridViewLeitor);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 544);
            this.panel3.TabIndex = 33;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(824, 475);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(197, 42);
            this.btnEditar.TabIndex = 109;
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
            this.lblNotFound.Location = new System.Drawing.Point(467, 280);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 93;
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
            this.label11.Location = new System.Drawing.Point(762, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ambos",
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(824, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 28);
            this.cbStatus.TabIndex = 91;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // dtGridViewLeitor
            // 
            this.dtGridViewLeitor.AllowUserToAddRows = false;
            this.dtGridViewLeitor.AllowUserToDeleteRows = false;
            this.dtGridViewLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewLeitor.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewLeitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewLeitor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewLeitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLeitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewLeitor.ColumnHeadersHeight = 30;
            this.dtGridViewLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewLeitor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewLeitor.EnableHeadersVisualStyles = false;
            this.dtGridViewLeitor.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewLeitor.Location = new System.Drawing.Point(27, 143);
            this.dtGridViewLeitor.Name = "dtGridViewLeitor";
            this.dtGridViewLeitor.ReadOnly = true;
            this.dtGridViewLeitor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLeitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewLeitor.RowHeadersVisible = false;
            this.dtGridViewLeitor.RowTemplate.Height = 25;
            this.dtGridViewLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewLeitor.Size = new System.Drawing.Size(994, 326);
            this.dtGridViewLeitor.TabIndex = 30;
            this.dtGridViewLeitor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewLeitor_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecione o tipo da busca:";
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
            this.icbtnVoltar.Location = new System.Drawing.Point(270, 76);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 89;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            this.icbtnVoltar.Click += new System.EventHandler(this.icbtnVoltar_Click);
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(423, 76);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(317, 39);
            this.lblCadastroLivro.TabIndex = 62;
            this.lblCadastroLivro.Text = "BUSCA DE LEITOR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1050, 37);
            this.head1.TabIndex = 32;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98791F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.01208F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1241, 763);
            this.pnltotal.TabIndex = 17;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(179, 757);
            this.menuControl1.TabIndex = 17;
            // 
            // LeitorBuscarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1241, 763);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeitorBuscarView";
            this.Text = "Buscar Leitor";
            this.Activated += new System.EventHandler(this.LeitorBuscarView_Activated);
            this.Load += new System.EventHandler(this.LeitorBuscarView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLeitor)).EndInit();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Label label1;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridViewLeitor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblNotFound;
        private FontAwesome.Sharp.IconButton btnCadastrarLeitor;
        private System.Windows.Forms.Button btnEditar;
    }
}