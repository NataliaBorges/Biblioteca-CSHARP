﻿namespace Biblioteca.View.Exemplar
{
    partial class ExemplarEditarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExemplarEditarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEditarStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.lblBuscaLivro = new System.Windows.Forms.Label();
            this.head1 = new Biblioteca.Util.Head();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.CalendarExemplar = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnltotal.Size = new System.Drawing.Size(1200, 726);
            this.pnltotal.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.CalendarExemplar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbEditarStatus);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.tbValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.tbEditora);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbGenero);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbEdicao);
            this.panel1.Controls.Add(this.maskedTextBoxAno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbAutor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbISBN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblBuscaLivro);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(183, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 720);
            this.panel1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(496, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Status:";
            // 
            // cbEditarStatus
            // 
            this.cbEditarStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEditarStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditarStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEditarStatus.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEditarStatus.FormattingEnabled = true;
            this.cbEditarStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbEditarStatus.Location = new System.Drawing.Point(558, 448);
            this.cbEditarStatus.Name = "cbEditarStatus";
            this.cbEditarStatus.Size = new System.Drawing.Size(91, 28);
            this.cbEditarStatus.TabIndex = 120;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BackColor = System.Drawing.Color.Olive;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(443, 541);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(178, 45);
            this.btnSalvar.TabIndex = 119;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbValor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbValor.Location = new System.Drawing.Point(658, 412);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(95, 27);
            this.tbValor.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(576, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Valor: R$";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.CadetBlue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 23;
            this.iconButton2.Location = new System.Drawing.Point(505, 412);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 27);
            this.iconButton2.TabIndex = 114;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // tbEditora
            // 
            this.tbEditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEditora.Enabled = false;
            this.tbEditora.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEditora.Location = new System.Drawing.Point(324, 287);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.ReadOnly = true;
            this.tbEditora.Size = new System.Drawing.Size(175, 27);
            this.tbEditora.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(505, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "Gênero:";
            // 
            // tbGenero
            // 
            this.tbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenero.Enabled = false;
            this.tbGenero.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGenero.Location = new System.Drawing.Point(576, 287);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.ReadOnly = true;
            this.tbGenero.Size = new System.Drawing.Size(177, 27);
            this.tbGenero.TabIndex = 112;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(325, 204);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(428, 27);
            this.tbNome.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(658, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Ano:";
            // 
            // tbEdicao
            // 
            this.tbEdicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEdicao.Enabled = false;
            this.tbEdicao.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEdicao.Location = new System.Drawing.Point(325, 412);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.PlaceholderText = "Selecione uma edição";
            this.tbEdicao.Size = new System.Drawing.Size(174, 27);
            this.tbEdicao.TabIndex = 102;
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxAno.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxAno.Location = new System.Drawing.Point(715, 449);
            this.maskedTextBoxAno.Mask = "9999";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(38, 27);
            this.maskedTextBoxAno.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "Edição:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(242, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "Editora:";
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAutor.Enabled = false;
            this.tbAutor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAutor.Location = new System.Drawing.Point(325, 246);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.ReadOnly = true;
            this.tbAutor.Size = new System.Drawing.Size(428, 27);
            this.tbAutor.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(252, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 106;
            this.label7.Text = "ISBN:";
            // 
            // tbISBN
            // 
            this.tbISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbISBN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbISBN.Location = new System.Drawing.Point(324, 448);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(159, 27);
            this.tbISBN.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Nome:";
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
            this.icbtnVoltar.Location = new System.Drawing.Point(255, 89);
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
            this.lblBuscaLivro.Location = new System.Drawing.Point(394, 89);
            this.lblBuscaLivro.Name = "lblBuscaLivro";
            this.lblBuscaLivro.Size = new System.Drawing.Size(334, 39);
            this.lblBuscaLivro.TabIndex = 30;
            this.lblBuscaLivro.Text = "EDITAR EXEMPLAR";
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1014, 37);
            this.head1.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(174, 720);
            this.menuControl1.TabIndex = 21;
            // 
            // CalendarExemplar
            // 
            this.CalendarExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarExemplar.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.CalendarExemplar.CalendarMonthBackground = System.Drawing.Color.Purple;
            this.CalendarExemplar.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.CalendarExemplar.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalendarExemplar.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.CalendarExemplar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarExemplar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarExemplar.Location = new System.Drawing.Point(505, 493);
            this.CalendarExemplar.Name = "CalendarExemplar";
            this.CalendarExemplar.Size = new System.Drawing.Size(130, 27);
            this.CalendarExemplar.TabIndex = 123;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(414, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 122;
            this.label11.Text = "Aquisição:";
            // 
            // ExemplarEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.pnltotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExemplarEditarView";
            this.Text = "ExemplarEditarView";
            this.Load += new System.EventHandler(this.ExemplarEditarView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
        private System.Windows.Forms.Label lblBuscaLivro;
        private Util.Head head1;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEditarStatus;
        private System.Windows.Forms.DateTimePicker CalendarExemplar;
        private System.Windows.Forms.Label label11;
    }
}