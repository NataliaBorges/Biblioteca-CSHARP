﻿namespace Biblioteca.View.Funcionario
{
    partial class FuncionarioSelecionarColaboradorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioSelecionarColaboradorView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelecionarAutor = new System.Windows.Forms.Label();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            this.tbLyPnlDataGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dtGridViewAutor = new System.Windows.Forms.DataGridView();
            this.linkLblCadastrarEditora = new System.Windows.Forms.LinkLabel();
            this.head1 = new Biblioteca.Util.Head();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbLyPnlDataGrid.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAutor)).BeginInit();
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
            this.pnltotal.Size = new System.Drawing.Size(1245, 784);
            this.pnltotal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblSelecionarAutor);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.tbLyPnlDataGrid);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(189, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 778);
            this.panel1.TabIndex = 21;
            // 
            // lblSelecionarAutor
            // 
            this.lblSelecionarAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecionarAutor.AutoSize = true;
            this.lblSelecionarAutor.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelecionarAutor.ForeColor = System.Drawing.Color.White;
            this.lblSelecionarAutor.Location = new System.Drawing.Point(318, 77);
            this.lblSelecionarAutor.Name = "lblSelecionarAutor";
            this.lblSelecionarAutor.Size = new System.Drawing.Size(510, 39);
            this.lblSelecionarAutor.TabIndex = 72;
            this.lblSelecionarAutor.Text = "SELECIONAR COLABORADOR";
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
            this.btnVoltar.Location = new System.Drawing.Point(193, 77);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(54, 46);
            this.btnVoltar.TabIndex = 71;
            this.btnVoltar.Tag = "";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tbLyPnlDataGrid
            // 
            this.tbLyPnlDataGrid.ColumnCount = 1;
            this.tbLyPnlDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLyPnlDataGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLyPnlDataGrid.Controls.Add(this.panel4, 0, 0);
            this.tbLyPnlDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLyPnlDataGrid.Location = new System.Drawing.Point(0, 192);
            this.tbLyPnlDataGrid.Name = "tbLyPnlDataGrid";
            this.tbLyPnlDataGrid.RowCount = 1;
            this.tbLyPnlDataGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLyPnlDataGrid.Size = new System.Drawing.Size(1053, 586);
            this.tbLyPnlDataGrid.TabIndex = 70;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel4.Controls.Add(this.lblNotFound);
            this.panel4.Controls.Add(this.tbBuscar);
            this.panel4.Controls.Add(this.dtGridViewAutor);
            this.panel4.Controls.Add(this.linkLblCadastrarEditora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1047, 580);
            this.panel4.TabIndex = 32;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.BackColor = System.Drawing.Color.Black;
            this.lblNotFound.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotFound.ForeColor = System.Drawing.Color.White;
            this.lblNotFound.Location = new System.Drawing.Point(458, 296);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(128, 21);
            this.lblNotFound.TabIndex = 65;
            this.lblNotFound.Text = "Não Encontrado";
            this.lblNotFound.Visible = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuscar.Location = new System.Drawing.Point(343, 46);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.PlaceholderText = "Digite aqui";
            this.tbBuscar.Size = new System.Drawing.Size(401, 27);
            this.tbBuscar.TabIndex = 61;
            // 
            // dtGridViewAutor
            // 
            this.dtGridViewAutor.AllowUserToAddRows = false;
            this.dtGridViewAutor.AllowUserToDeleteRows = false;
            this.dtGridViewAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewAutor.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewAutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewAutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewAutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewAutor.ColumnHeadersHeight = 30;
            this.dtGridViewAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewAutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewAutor.EnableHeadersVisualStyles = false;
            this.dtGridViewAutor.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewAutor.Location = new System.Drawing.Point(89, 128);
            this.dtGridViewAutor.Name = "dtGridViewAutor";
            this.dtGridViewAutor.ReadOnly = true;
            this.dtGridViewAutor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewAutor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewAutor.RowHeadersVisible = false;
            this.dtGridViewAutor.RowTemplate.Height = 25;
            this.dtGridViewAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewAutor.Size = new System.Drawing.Size(873, 366);
            this.dtGridViewAutor.TabIndex = 30;
            // 
            // linkLblCadastrarEditora
            // 
            this.linkLblCadastrarEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblCadastrarEditora.AutoSize = true;
            this.linkLblCadastrarEditora.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblCadastrarEditora.LinkColor = System.Drawing.Color.White;
            this.linkLblCadastrarEditora.Location = new System.Drawing.Point(2067, 1167);
            this.linkLblCadastrarEditora.Name = "linkLblCadastrarEditora";
            this.linkLblCadastrarEditora.Size = new System.Drawing.Size(123, 18);
            this.linkLblCadastrarEditora.TabIndex = 64;
            this.linkLblCadastrarEditora.TabStop = true;
            this.linkLblCadastrarEditora.Text = "Cadastrar Editora";
            this.linkLblCadastrarEditora.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1053, 37);
            this.head1.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(180, 778);
            this.menuControl1.TabIndex = 22;
            // 
            // FuncionarioSelecionarColaboradorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1245, 784);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuncionarioSelecionarColaboradorView";
            this.Text = "FuncionarioSelecionarColaboradorView";
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbLyPnlDataGrid.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecionarAutor;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private System.Windows.Forms.TableLayoutPanel tbLyPnlDataGrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dtGridViewAutor;
        private System.Windows.Forms.LinkLabel linkLblCadastrarEditora;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
    }
}