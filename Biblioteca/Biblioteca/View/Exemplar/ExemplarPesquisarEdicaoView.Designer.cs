namespace Biblioteca.View.Exemplar
{
    partial class ExemplarPesquisarEdicaoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExemplarPesquisarEdicaoView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblSelecionarAutor = new System.Windows.Forms.Label();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dtGridViewEdicao = new System.Windows.Forms.DataGridView();
            this.head1 = new Biblioteca.Util.Head();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnltotal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEdicao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.BackColor = System.Drawing.Color.Black;
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Controls.Add(this.pnlPrincipal, 1, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1226, 725);
            this.pnltotal.TabIndex = 24;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(177, 719);
            this.menuControl1.TabIndex = 22;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Black;
            this.pnlPrincipal.Controls.Add(this.lblSelecionarAutor);
            this.pnlPrincipal.Controls.Add(this.btnVoltar);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.head1);
            this.pnlPrincipal.Controls.Add(this.btnCadastrar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(186, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1037, 719);
            this.pnlPrincipal.TabIndex = 28;
            // 
            // lblSelecionarAutor
            // 
            this.lblSelecionarAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecionarAutor.AutoSize = true;
            this.lblSelecionarAutor.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelecionarAutor.ForeColor = System.Drawing.Color.White;
            this.lblSelecionarAutor.Location = new System.Drawing.Point(371, 98);
            this.lblSelecionarAutor.Name = "lblSelecionarAutor";
            this.lblSelecionarAutor.Size = new System.Drawing.Size(376, 39);
            this.lblSelecionarAutor.TabIndex = 77;
            this.lblSelecionarAutor.Text = "SELECIONAR EDIÇÃO";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.btnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoltar.IconSize = 30;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(228, 98);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(54, 46);
            this.btnVoltar.TabIndex = 76;
            this.btnVoltar.Tag = "";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.lblNotFound);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.dtGridViewEdicao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 540);
            this.panel1.TabIndex = 29;
            // 
            // lblNotFound
            // 
            this.lblNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(473, 247);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 75;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(346, 43);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(401, 27);
            this.tbBuscar.TabIndex = 74;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // dtGridViewEdicao
            // 
            this.dtGridViewEdicao.AllowUserToAddRows = false;
            this.dtGridViewEdicao.AllowUserToDeleteRows = false;
            this.dtGridViewEdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridViewEdicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewEdicao.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewEdicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewEdicao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewEdicao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEdicao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewEdicao.ColumnHeadersHeight = 30;
            this.dtGridViewEdicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewEdicao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewEdicao.EnableHeadersVisualStyles = false;
            this.dtGridViewEdicao.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewEdicao.Location = new System.Drawing.Point(165, 94);
            this.dtGridViewEdicao.Name = "dtGridViewEdicao";
            this.dtGridViewEdicao.ReadOnly = true;
            this.dtGridViewEdicao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewEdicao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewEdicao.RowHeadersVisible = false;
            this.dtGridViewEdicao.RowTemplate.Height = 25;
            this.dtGridViewEdicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewEdicao.Size = new System.Drawing.Size(730, 366);
            this.dtGridViewEdicao.TabIndex = 73;
            this.dtGridViewEdicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewEdicao_CellClick);
            // 
            // head1
            // 
            this.head1.BackColor = System.Drawing.Color.Black;
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1037, 37);
            this.head1.TabIndex = 28;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Olive;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(886, 851);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 45);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "SALVAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // ExemplarPesquisarEdicaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 725);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExemplarPesquisarEdicaoView";
            this.Text = "ExemplarPesquisarEdicaoView";
            this.Load += new System.EventHandler(this.ExemplarPesquisarEdicaoView_Load);
            this.pnltotal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEdicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Util.Head head1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecionarAutor;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dtGridViewEdicao;
    }
}