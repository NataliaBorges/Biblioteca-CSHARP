
namespace Biblioteca.View.Reserva {
    partial class ReservaBuscarLivroView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaBuscarLivroView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtGridViewLivros = new System.Windows.Forms.DataGridView();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.IcnBtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivros)).BeginInit();
            this.pnltotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.IcnBtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(227, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 776);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.lblNotFound);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbStatus);
            this.panel3.Controls.Add(this.dtGridViewLivros);
            this.panel3.Controls.Add(this.tbPesquisar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 521);
            this.panel3.TabIndex = 98;
            // 
            // lblNotFound
            // 
            this.lblNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(465, 263);
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
            this.label11.Location = new System.Drawing.Point(3309, 1461);
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
            this.cbStatus.Location = new System.Drawing.Point(3371, 1458);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 28);
            this.cbStatus.TabIndex = 93;
            // 
            // dtGridViewLivros
            // 
            this.dtGridViewLivros.AllowUserToAddRows = false;
            this.dtGridViewLivros.AllowUserToDeleteRows = false;
            this.dtGridViewLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewLivros.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewLivros.ColumnHeadersHeight = 30;
            this.dtGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewLivros.EnableHeadersVisualStyles = false;
            this.dtGridViewLivros.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewLivros.Location = new System.Drawing.Point(73, 106);
            this.dtGridViewLivros.Name = "dtGridViewLivros";
            this.dtGridViewLivros.ReadOnly = true;
            this.dtGridViewLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewLivros.RowHeadersVisible = false;
            this.dtGridViewLivros.RowTemplate.Height = 25;
            this.dtGridViewLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewLivros.Size = new System.Drawing.Size(889, 348);
            this.dtGridViewLivros.TabIndex = 30;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPesquisar.Location = new System.Drawing.Point(320, 53);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.PlaceholderText = "Digite aqui";
            this.tbPesquisar.Size = new System.Drawing.Size(477, 27);
            this.tbPesquisar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackgroundImage = global::Biblioteca.Properties.Resources.Lupa_icon1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(2557, 996);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 27);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // IcnBtnVoltar
            // 
            this.IcnBtnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IcnBtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IcnBtnVoltar.FlatAppearance.BorderSize = 0;
            this.IcnBtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcnBtnVoltar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IcnBtnVoltar.ForeColor = System.Drawing.Color.White;
            this.IcnBtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IcnBtnVoltar.IconColor = System.Drawing.Color.Chocolate;
            this.IcnBtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnBtnVoltar.IconSize = 30;
            this.IcnBtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcnBtnVoltar.Location = new System.Drawing.Point(249, 101);
            this.IcnBtnVoltar.Name = "IcnBtnVoltar";
            this.IcnBtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IcnBtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.IcnBtnVoltar.TabIndex = 97;
            this.IcnBtnVoltar.Tag = "";
            this.IcnBtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcnBtnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(405, 109);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(349, 39);
            this.lblCadastroLivro.TabIndex = 96;
            this.lblCadastroLivro.Text = "SELECIONAR LIVRO";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1051, 37);
            this.head1.TabIndex = 22;
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5644F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.4356F));
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1281, 782);
            this.pnltotal.TabIndex = 21;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(218, 776);
            this.menuControl1.TabIndex = 21;
            // 
            // ReservaBuscarLivroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 782);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservaBuscarLivroView";
            this.Text = "Selecionar Livros";
            this.Load += new System.EventHandler(this.ReservaBuscarLivroView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivros)).EndInit();
            this.pnltotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private FontAwesome.Sharp.IconButton IcnBtnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dtGridViewLivros;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Button btnBuscar;
    }
}