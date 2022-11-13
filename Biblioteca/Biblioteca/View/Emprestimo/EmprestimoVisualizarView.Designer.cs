namespace Biblioteca.View.Emprestimo
{
    partial class EmprestimoVisualizarView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoVisualizarView));
            this.pnltotal = new System.Windows.Forms.TableLayoutPanel();
            this.menuControl1 = new Biblioteca.Util.MenuControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroLivro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtGridViewLivrosEmprestimo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDataReserva = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDataRetirada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCancelar = new System.Windows.Forms.RadioButton();
            this.rbDevolver = new System.Windows.Forms.RadioButton();
            this.rbInutilizar = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.head1 = new Biblioteca.Util.Head();
            this.icbtnVoltar = new FontAwesome.Sharp.IconButton();
            this.pnltotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivrosEmprestimo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltotal
            // 
            this.pnltotal.ColumnCount = 2;
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pnltotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.pnltotal.Controls.Add(this.menuControl1, 0, 0);
            this.pnltotal.Controls.Add(this.panel1, 1, 0);
            this.pnltotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltotal.Location = new System.Drawing.Point(0, 0);
            this.pnltotal.Margin = new System.Windows.Forms.Padding(2);
            this.pnltotal.Name = "pnltotal";
            this.pnltotal.RowCount = 1;
            this.pnltotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnltotal.Size = new System.Drawing.Size(1307, 686);
            this.pnltotal.TabIndex = 29;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl1.ForeColor = System.Drawing.Color.Transparent;
            this.menuControl1.Location = new System.Drawing.Point(3, 3);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Size = new System.Drawing.Size(190, 680);
            this.menuControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icbtnVoltar);
            this.panel1.Controls.Add(this.lblCadastroLivro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.head1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(199, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 680);
            this.panel1.TabIndex = 1;
            // 
            // lblCadastroLivro
            // 
            this.lblCadastroLivro.AutoSize = true;
            this.lblCadastroLivro.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroLivro.ForeColor = System.Drawing.Color.White;
            this.lblCadastroLivro.Location = new System.Drawing.Point(332, 62);
            this.lblCadastroLivro.Name = "lblCadastroLivro";
            this.lblCadastroLivro.Size = new System.Drawing.Size(460, 39);
            this.lblCadastroLivro.TabIndex = 95;
            this.lblCadastroLivro.Text = "VISUALIZAR EMPRÉSTIMO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 564);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBox4.Controls.Add(this.dtGridViewLivrosEmprestimo);
            this.groupBox4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(165, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(791, 234);
            this.groupBox4.TabIndex = 139;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LIVRO(S)";
            // 
            // dtGridViewLivrosEmprestimo
            // 
            this.dtGridViewLivrosEmprestimo.AllowUserToAddRows = false;
            this.dtGridViewLivrosEmprestimo.AllowUserToDeleteRows = false;
            this.dtGridViewLivrosEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewLivrosEmprestimo.BackgroundColor = System.Drawing.Color.Black;
            this.dtGridViewLivrosEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewLivrosEmprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewLivrosEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivrosEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridViewLivrosEmprestimo.ColumnHeadersHeight = 30;
            this.dtGridViewLivrosEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewLivrosEmprestimo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridViewLivrosEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewLivrosEmprestimo.EnableHeadersVisualStyles = false;
            this.dtGridViewLivrosEmprestimo.GridColor = System.Drawing.Color.SaddleBrown;
            this.dtGridViewLivrosEmprestimo.Location = new System.Drawing.Point(3, 23);
            this.dtGridViewLivrosEmprestimo.Name = "dtGridViewLivrosEmprestimo";
            this.dtGridViewLivrosEmprestimo.ReadOnly = true;
            this.dtGridViewLivrosEmprestimo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewLivrosEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridViewLivrosEmprestimo.RowHeadersVisible = false;
            this.dtGridViewLivrosEmprestimo.RowTemplate.Height = 25;
            this.dtGridViewLivrosEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewLivrosEmprestimo.Size = new System.Drawing.Size(785, 208);
            this.dtGridViewLivrosEmprestimo.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBox3.Controls.Add(this.lbTelefone);
            this.groupBox3.Controls.Add(this.lbEmail);
            this.groupBox3.Controls.Add(this.lbCPF);
            this.groupBox3.Controls.Add(this.lbNome);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.labelNome);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(165, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 139);
            this.groupBox3.TabIndex = 138;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LEITOR";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(273, 66);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(56, 20);
            this.lbTelefone.TabIndex = 24;
            this.lbTelefone.Text = "label10";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(81, 99);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "label10";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCPF.ForeColor = System.Drawing.Color.White;
            this.lbCPF.Location = new System.Drawing.Point(78, 65);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(56, 20);
            this.lbCPF.TabIndex = 22;
            this.lbCPF.Text = "label10";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(78, 32);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(56, 20);
            this.lbNome.TabIndex = 21;
            this.lbNome.Text = "label10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 20;
            this.label15.Text = "E-mail:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(225, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "Tel.:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(14, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(14, 29);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 21);
            this.labelNome.TabIndex = 17;
            this.labelNome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBox2.Controls.Add(this.lbDataReserva);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbDataRetirada);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(659, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 139);
            this.groupBox2.TabIndex = 137;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATAS";
            // 
            // lbDataReserva
            // 
            this.lbDataReserva.AutoSize = true;
            this.lbDataReserva.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDataReserva.ForeColor = System.Drawing.Color.White;
            this.lbDataReserva.Location = new System.Drawing.Point(41, 42);
            this.lbDataReserva.Name = "lbDataReserva";
            this.lbDataReserva.Size = new System.Drawing.Size(110, 21);
            this.lbDataReserva.TabIndex = 15;
            this.lbDataReserva.Text = "Data Reserva:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(170, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(170, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "label10";
            // 
            // lbDataRetirada
            // 
            this.lbDataRetirada.AutoSize = true;
            this.lbDataRetirada.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDataRetirada.ForeColor = System.Drawing.Color.White;
            this.lbDataRetirada.Location = new System.Drawing.Point(75, 77);
            this.lbDataRetirada.Name = "lbDataRetirada";
            this.lbDataRetirada.Size = new System.Drawing.Size(76, 21);
            this.lbDataRetirada.TabIndex = 10;
            this.lbDataRetirada.Text = "Retirada:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBox1.Controls.Add(this.rbCancelar);
            this.groupBox1.Controls.Add(this.rbDevolver);
            this.groupBox1.Controls.Add(this.rbInutilizar);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(165, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 139);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS";
            // 
            // rbCancelar
            // 
            this.rbCancelar.AutoSize = true;
            this.rbCancelar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCancelar.ForeColor = System.Drawing.Color.White;
            this.rbCancelar.Location = new System.Drawing.Point(36, 61);
            this.rbCancelar.Name = "rbCancelar";
            this.rbCancelar.Size = new System.Drawing.Size(89, 24);
            this.rbCancelar.TabIndex = 127;
            this.rbCancelar.TabStop = true;
            this.rbCancelar.Text = "Cancelar";
            this.rbCancelar.UseVisualStyleBackColor = true;
            // 
            // rbDevolver
            // 
            this.rbDevolver.AutoSize = true;
            this.rbDevolver.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDevolver.ForeColor = System.Drawing.Color.White;
            this.rbDevolver.Location = new System.Drawing.Point(36, 31);
            this.rbDevolver.Name = "rbDevolver";
            this.rbDevolver.Size = new System.Drawing.Size(93, 24);
            this.rbDevolver.TabIndex = 125;
            this.rbDevolver.TabStop = true;
            this.rbDevolver.Text = "Devolver";
            this.rbDevolver.UseVisualStyleBackColor = true;
            // 
            // rbInutilizar
            // 
            this.rbInutilizar.AutoSize = true;
            this.rbInutilizar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbInutilizar.ForeColor = System.Drawing.Color.White;
            this.rbInutilizar.Location = new System.Drawing.Point(36, 91);
            this.rbInutilizar.Name = "rbInutilizar";
            this.rbInutilizar.Size = new System.Drawing.Size(93, 24);
            this.rbInutilizar.TabIndex = 128;
            this.rbInutilizar.TabStop = true;
            this.rbInutilizar.Text = "Inutilizar";
            this.rbInutilizar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Olive;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(784, 454);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(169, 47);
            this.btnSalvar.TabIndex = 135;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1105, 37);
            this.head1.TabIndex = 0;
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
            this.icbtnVoltar.Location = new System.Drawing.Point(168, 62);
            this.icbtnVoltar.Name = "icbtnVoltar";
            this.icbtnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbtnVoltar.Size = new System.Drawing.Size(54, 46);
            this.icbtnVoltar.TabIndex = 96;
            this.icbtnVoltar.Tag = "";
            this.icbtnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnVoltar.UseVisualStyleBackColor = true;
            // 
            // EmprestimoVisualizarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1307, 686);
            this.Controls.Add(this.pnltotal);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmprestimoVisualizarView";
            this.Text = "EmprestimoVisualizarView";
            this.Load += new System.EventHandler(this.EmprestimoVisualizarView_Load);
            this.pnltotal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLivrosEmprestimo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnltotal;
        private Util.MenuControl menuControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Util.Head head1;
        private System.Windows.Forms.Label lblCadastroLivro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtGridViewLivrosEmprestimo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDataReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDataRetirada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCancelar;
        private System.Windows.Forms.RadioButton rbDevolver;
        private System.Windows.Forms.RadioButton rbInutilizar;
        private System.Windows.Forms.Button btnSalvar;
        private FontAwesome.Sharp.IconButton icbtnVoltar;
    }
}