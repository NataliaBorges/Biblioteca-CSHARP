namespace Biblioteca.Util
{
    partial class MenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.Panel();
            this.btnFuncionario = new FontAwesome.Sharp.IconButton();
            this.btnGrafico = new FontAwesome.Sharp.IconButton();
            this.btnRelatório = new FontAwesome.Sharp.IconButton();
            this.btnPrateleira = new FontAwesome.Sharp.IconButton();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnReserva = new FontAwesome.Sharp.IconButton();
            this.btnEmprestimo = new FontAwesome.Sharp.IconButton();
            this.btnLeitor = new FontAwesome.Sharp.IconButton();
            this.btnLivro = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icnButtonBar = new FontAwesome.Sharp.IconButton();
            this.lbNome = new System.Windows.Forms.Label();
            this.ddmLivro = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarExemplar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarEditora = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastrarEdicao = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarExemplar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarEditora = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarEdicao = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmLeitor = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.itemCadastrarLeitor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarLeitor = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmEmprestimo = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.itemCadastrarEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmReserva = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.itemCadastrarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmRelatorio = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.livrotoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.autortoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmFuncionario = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.itemCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ddmLivro.SuspendLayout();
            this.ddmLeitor.SuspendLayout();
            this.ddmEmprestimo.SuspendLayout();
            this.ddmReserva.SuspendLayout();
            this.ddmRelatorio.SuspendLayout();
            this.ddmFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Black;
            this.Menu.Controls.Add(this.btnFuncionario);
            this.Menu.Controls.Add(this.btnGrafico);
            this.Menu.Controls.Add(this.btnRelatório);
            this.Menu.Controls.Add(this.btnPrateleira);
            this.Menu.Controls.Add(this.btnSair);
            this.Menu.Controls.Add(this.btnReserva);
            this.Menu.Controls.Add(this.btnEmprestimo);
            this.Menu.Controls.Add(this.btnLeitor);
            this.Menu.Controls.Add(this.btnLivro);
            this.Menu.Controls.Add(this.btnHome);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(198, 703);
            this.Menu.TabIndex = 6;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnFuncionario.IconColor = System.Drawing.Color.Chocolate;
            this.btnFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuncionario.IconSize = 30;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 416);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFuncionario.Size = new System.Drawing.Size(198, 46);
            this.btnFuncionario.TabIndex = 4;
            this.btnFuncionario.Tag = "Funcionário";
            this.btnFuncionario.Text = " Funcionário";
            this.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGrafico.ForeColor = System.Drawing.Color.White;
            this.btnGrafico.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnGrafico.IconColor = System.Drawing.Color.Chocolate;
            this.btnGrafico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrafico.IconSize = 30;
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(0, 370);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGrafico.Size = new System.Drawing.Size(198, 46);
            this.btnGrafico.TabIndex = 9;
            this.btnGrafico.Tag = "Gráficos";
            this.btnGrafico.Text = " Gráficos";
            this.btnGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrafico.UseVisualStyleBackColor = true;
            // 
            // btnRelatório
            // 
            this.btnRelatório.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatório.FlatAppearance.BorderSize = 0;
            this.btnRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatório.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRelatório.ForeColor = System.Drawing.Color.White;
            this.btnRelatório.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnRelatório.IconColor = System.Drawing.Color.Chocolate;
            this.btnRelatório.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatório.IconSize = 30;
            this.btnRelatório.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatório.Location = new System.Drawing.Point(0, 324);
            this.btnRelatório.Name = "btnRelatório";
            this.btnRelatório.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelatório.Size = new System.Drawing.Size(198, 46);
            this.btnRelatório.TabIndex = 8;
            this.btnRelatório.Tag = "Relatórios";
            this.btnRelatório.Text = " Relatórios";
            this.btnRelatório.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatório.UseVisualStyleBackColor = true;
            this.btnRelatório.Click += new System.EventHandler(this.btnRelatório_Click);
            // 
            // btnPrateleira
            // 
            this.btnPrateleira.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrateleira.FlatAppearance.BorderSize = 0;
            this.btnPrateleira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrateleira.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrateleira.ForeColor = System.Drawing.Color.White;
            this.btnPrateleira.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnPrateleira.IconColor = System.Drawing.Color.Chocolate;
            this.btnPrateleira.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrateleira.IconSize = 30;
            this.btnPrateleira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrateleira.Location = new System.Drawing.Point(0, 278);
            this.btnPrateleira.Name = "btnPrateleira";
            this.btnPrateleira.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrateleira.Size = new System.Drawing.Size(198, 46);
            this.btnPrateleira.TabIndex = 7;
            this.btnPrateleira.Tag = "Prateleira";
            this.btnPrateleira.Text = "Prateleira";
            this.btnPrateleira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrateleira.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.Chocolate;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 30;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 657);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.btnSair.Size = new System.Drawing.Size(198, 46);
            this.btnSair.TabIndex = 7;
            this.btnSair.Tag = "Sair";
            this.btnSair.Text = " Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserva.ForeColor = System.Drawing.Color.White;
            this.btnReserva.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnReserva.IconColor = System.Drawing.Color.Chocolate;
            this.btnReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReserva.IconSize = 30;
            this.btnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.Location = new System.Drawing.Point(0, 232);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReserva.Size = new System.Drawing.Size(198, 46);
            this.btnReserva.TabIndex = 6;
            this.btnReserva.Tag = "Reserva";
            this.btnReserva.Text = "Reserva";
            this.btnReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimo.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnEmprestimo.IconColor = System.Drawing.Color.Chocolate;
            this.btnEmprestimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmprestimo.IconSize = 30;
            this.btnEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.Location = new System.Drawing.Point(0, 186);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmprestimo.Size = new System.Drawing.Size(198, 46);
            this.btnEmprestimo.TabIndex = 5;
            this.btnEmprestimo.Tag = "Empréstimo";
            this.btnEmprestimo.Text = " Empréstimo";
            this.btnEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.BtnEmprestimo_Click);
            // 
            // btnLeitor
            // 
            this.btnLeitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeitor.FlatAppearance.BorderSize = 0;
            this.btnLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitor.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeitor.ForeColor = System.Drawing.Color.White;
            this.btnLeitor.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnLeitor.IconColor = System.Drawing.Color.Chocolate;
            this.btnLeitor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeitor.IconSize = 30;
            this.btnLeitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeitor.Location = new System.Drawing.Point(0, 140);
            this.btnLeitor.Name = "btnLeitor";
            this.btnLeitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLeitor.Size = new System.Drawing.Size(198, 46);
            this.btnLeitor.TabIndex = 3;
            this.btnLeitor.Tag = "Leitor";
            this.btnLeitor.Text = " Leitor";
            this.btnLeitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeitor.UseVisualStyleBackColor = true;
            this.btnLeitor.Click += new System.EventHandler(this.BtnLeitor_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivro.FlatAppearance.BorderSize = 0;
            this.btnLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivro.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLivro.ForeColor = System.Drawing.Color.White;
            this.btnLivro.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnLivro.IconColor = System.Drawing.Color.Chocolate;
            this.btnLivro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLivro.IconSize = 30;
            this.btnLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivro.Location = new System.Drawing.Point(0, 94);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLivro.Size = new System.Drawing.Size(198, 46);
            this.btnLivro.TabIndex = 2;
            this.btnLivro.Tag = "Livro";
            this.btnLivro.Text = "Livro";
            this.btnLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.BtnLivro_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Chocolate;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 48);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(198, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.icnButtonBar);
            this.panel3.Controls.Add(this.lbNome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 48);
            this.panel3.TabIndex = 0;
            // 
            // icnButtonBar
            // 
            this.icnButtonBar.FlatAppearance.BorderSize = 0;
            this.icnButtonBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnButtonBar.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icnButtonBar.ForeColor = System.Drawing.Color.White;
            this.icnButtonBar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.icnButtonBar.IconColor = System.Drawing.Color.Chocolate;
            this.icnButtonBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnButtonBar.IconSize = 30;
            this.icnButtonBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnButtonBar.Location = new System.Drawing.Point(135, 1);
            this.icnButtonBar.Name = "icnButtonBar";
            this.icnButtonBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icnButtonBar.Size = new System.Drawing.Size(57, 46);
            this.icnButtonBar.TabIndex = 10;
            this.icnButtonBar.Tag = "";
            this.icnButtonBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnButtonBar.UseVisualStyleBackColor = true;
            this.icnButtonBar.Click += new System.EventHandler(this.icnButtonBar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Book Antiqua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.Chocolate;
            this.lbNome.Location = new System.Drawing.Point(16, 10);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(113, 25);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Dark Read";
            // 
            // ddmLivro
            // 
            this.ddmLivro.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmLivro.IsMainMenu = false;
            this.ddmLivro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.leitorToolStripMenuItem});
            this.ddmLivro.MenuItemHeight = 50;
            this.ddmLivro.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmLivro.Name = "rjDropdownMenu1";
            this.ddmLivro.PrimaryColor = System.Drawing.Color.Black;
            this.ddmLivro.Size = new System.Drawing.Size(140, 48);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastrarLivro,
            this.itemCadastrarExemplar,
            this.itemCadastrarEditora,
            this.itemCadastrarAutor,
            this.itemCadastrarGenero,
            this.itemCadastrarEdicao});
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.livroToolStripMenuItem.Text = "Cadastrar";
            // 
            // itemCadastrarLivro
            // 
            this.itemCadastrarLivro.Name = "itemCadastrarLivro";
            this.itemCadastrarLivro.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarLivro.Text = "Livro";
            this.itemCadastrarLivro.Click += new System.EventHandler(this.itemCadastrarLivro_Click);
            // 
            // itemCadastrarExemplar
            // 
            this.itemCadastrarExemplar.Name = "itemCadastrarExemplar";
            this.itemCadastrarExemplar.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarExemplar.Text = "Exemplar";
            this.itemCadastrarExemplar.Click += new System.EventHandler(this.itemCadastrarExemplar_Click);
            // 
            // itemCadastrarEditora
            // 
            this.itemCadastrarEditora.Name = "itemCadastrarEditora";
            this.itemCadastrarEditora.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarEditora.Text = "Editora";
            this.itemCadastrarEditora.Click += new System.EventHandler(this.itemCadastrarEditora_Click);
            // 
            // itemCadastrarAutor
            // 
            this.itemCadastrarAutor.Name = "itemCadastrarAutor";
            this.itemCadastrarAutor.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarAutor.Text = "Autor";
            this.itemCadastrarAutor.Click += new System.EventHandler(this.itemCadastrarAutor_Click);
            // 
            // itemCadastrarGenero
            // 
            this.itemCadastrarGenero.Name = "itemCadastrarGenero";
            this.itemCadastrarGenero.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarGenero.Text = "Gênero";
            this.itemCadastrarGenero.Click += new System.EventHandler(this.ItemCadastrarGenero_Click);
            // 
            // itemCadastrarEdicao
            // 
            this.itemCadastrarEdicao.Name = "itemCadastrarEdicao";
            this.itemCadastrarEdicao.Size = new System.Drawing.Size(180, 22);
            this.itemCadastrarEdicao.Text = "Edição";
            this.itemCadastrarEdicao.Click += new System.EventHandler(this.itemCadastrarEdicao_Click);
            // 
            // leitorToolStripMenuItem
            // 
            this.leitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBuscarLivro,
            this.itemBuscarExemplar,
            this.itemBuscarEditora,
            this.itemBuscarAutor,
            this.itemBuscarGenero,
            this.itemBuscarEdicao});
            this.leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            this.leitorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.leitorToolStripMenuItem.Text = "Buscar";
            // 
            // itemBuscarLivro
            // 
            this.itemBuscarLivro.Name = "itemBuscarLivro";
            this.itemBuscarLivro.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarLivro.Text = "Livro";
            this.itemBuscarLivro.Click += new System.EventHandler(this.itemBuscarLivro_Click);
            // 
            // itemBuscarExemplar
            // 
            this.itemBuscarExemplar.Name = "itemBuscarExemplar";
            this.itemBuscarExemplar.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarExemplar.Text = "Exemplar";
            this.itemBuscarExemplar.Click += new System.EventHandler(this.itemBuscarExemplar_Click);
            // 
            // itemBuscarEditora
            // 
            this.itemBuscarEditora.Name = "itemBuscarEditora";
            this.itemBuscarEditora.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarEditora.Text = "Editora";
            this.itemBuscarEditora.Click += new System.EventHandler(this.itemBuscarEditora_Click);
            // 
            // itemBuscarAutor
            // 
            this.itemBuscarAutor.Name = "itemBuscarAutor";
            this.itemBuscarAutor.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarAutor.Text = "Autor";
            this.itemBuscarAutor.Click += new System.EventHandler(this.itemBuscarAutor_Click);
            // 
            // itemBuscarGenero
            // 
            this.itemBuscarGenero.Name = "itemBuscarGenero";
            this.itemBuscarGenero.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarGenero.Text = "Gênero";
            this.itemBuscarGenero.Click += new System.EventHandler(this.itemBuscarGenero_Click);
            // 
            // itemBuscarEdicao
            // 
            this.itemBuscarEdicao.Name = "itemBuscarEdicao";
            this.itemBuscarEdicao.Size = new System.Drawing.Size(180, 22);
            this.itemBuscarEdicao.Text = "Edição";
            this.itemBuscarEdicao.Click += new System.EventHandler(this.itemBuscarEdicao_Click);
            // 
            // ddmLeitor
            // 
            this.ddmLeitor.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmLeitor.IsMainMenu = false;
            this.ddmLeitor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastrarLeitor,
            this.itemBuscarLeitor});
            this.ddmLeitor.MenuItemHeight = 25;
            this.ddmLeitor.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmLeitor.Name = "rjDropdownMenu1";
            this.ddmLeitor.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmLeitor.Size = new System.Drawing.Size(140, 48);
            // 
            // itemCadastrarLeitor
            // 
            this.itemCadastrarLeitor.ForeColor = System.Drawing.Color.Black;
            this.itemCadastrarLeitor.Name = "itemCadastrarLeitor";
            this.itemCadastrarLeitor.Size = new System.Drawing.Size(139, 22);
            this.itemCadastrarLeitor.Text = "Cadastrar";
            this.itemCadastrarLeitor.Click += new System.EventHandler(this.itemCadastrarLeitor_Click);
            // 
            // itemBuscarLeitor
            // 
            this.itemBuscarLeitor.Name = "itemBuscarLeitor";
            this.itemBuscarLeitor.Size = new System.Drawing.Size(139, 22);
            this.itemBuscarLeitor.Text = "Buscar";
            this.itemBuscarLeitor.Click += new System.EventHandler(this.itemBuscarLeitor_Click);
            // 
            // ddmEmprestimo
            // 
            this.ddmEmprestimo.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmEmprestimo.IsMainMenu = false;
            this.ddmEmprestimo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastrarEmprestimo,
            this.itemBuscarEmprestimo});
            this.ddmEmprestimo.MenuItemHeight = 25;
            this.ddmEmprestimo.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmEmprestimo.Name = "rjDropdownMenu1";
            this.ddmEmprestimo.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmEmprestimo.Size = new System.Drawing.Size(140, 48);
            // 
            // itemCadastrarEmprestimo
            // 
            this.itemCadastrarEmprestimo.Name = "itemCadastrarEmprestimo";
            this.itemCadastrarEmprestimo.Size = new System.Drawing.Size(139, 22);
            this.itemCadastrarEmprestimo.Text = "Cadastrar";
            this.itemCadastrarEmprestimo.Click += new System.EventHandler(this.itemCadastrarEmprestimo_Click);
            // 
            // itemBuscarEmprestimo
            // 
            this.itemBuscarEmprestimo.Name = "itemBuscarEmprestimo";
            this.itemBuscarEmprestimo.Size = new System.Drawing.Size(139, 22);
            this.itemBuscarEmprestimo.Text = "Buscar";
            this.itemBuscarEmprestimo.Click += new System.EventHandler(this.itemBuscarEmprestimo_Click);
            // 
            // ddmReserva
            // 
            this.ddmReserva.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmReserva.IsMainMenu = false;
            this.ddmReserva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastrarReserva,
            this.itemBuscarReserva});
            this.ddmReserva.MenuItemHeight = 25;
            this.ddmReserva.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmReserva.Name = "rjDropdownMenu1";
            this.ddmReserva.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmReserva.Size = new System.Drawing.Size(140, 48);
            // 
            // itemCadastrarReserva
            // 
            this.itemCadastrarReserva.Name = "itemCadastrarReserva";
            this.itemCadastrarReserva.Size = new System.Drawing.Size(139, 22);
            this.itemCadastrarReserva.Text = "Cadastrar";
            this.itemCadastrarReserva.Click += new System.EventHandler(this.itemCadastrarReserva_Click);
            // 
            // itemBuscarReserva
            // 
            this.itemBuscarReserva.Name = "itemBuscarReserva";
            this.itemBuscarReserva.Size = new System.Drawing.Size(139, 22);
            this.itemBuscarReserva.Text = "Buscar";
            this.itemBuscarReserva.Click += new System.EventHandler(this.itemBuscarReserva_Click);
            // 
            // ddmRelatorio
            // 
            this.ddmRelatorio.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmRelatorio.IsMainMenu = false;
            this.ddmRelatorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrotoolStripMenu,
            this.autortoolStripMenu,
            this.editoraToolStripMenu,
            this.generoToolStripMenu,
            this.leitorToolStripMenu,
            this.funcionarioToolStripMenu,
            this.emprestimoToolStripMenu,
            this.reservaToolStripMenu});
            this.ddmRelatorio.MenuItemHeight = 25;
            this.ddmRelatorio.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmRelatorio.Name = "rjDropdownMenu1";
            this.ddmRelatorio.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmRelatorio.Size = new System.Drawing.Size(154, 180);
            // 
            // livrotoolStripMenu
            // 
            this.livrotoolStripMenu.Name = "livrotoolStripMenu";
            this.livrotoolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.livrotoolStripMenu.Text = "Livro";
            // 
            // autortoolStripMenu
            // 
            this.autortoolStripMenu.Name = "autortoolStripMenu";
            this.autortoolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.autortoolStripMenu.Text = "Autor";
            // 
            // editoraToolStripMenu
            // 
            this.editoraToolStripMenu.Name = "editoraToolStripMenu";
            this.editoraToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.editoraToolStripMenu.Text = "Editora";
            // 
            // generoToolStripMenu
            // 
            this.generoToolStripMenu.Name = "generoToolStripMenu";
            this.generoToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.generoToolStripMenu.Text = "Gênero";
            // 
            // leitorToolStripMenu
            // 
            this.leitorToolStripMenu.Name = "leitorToolStripMenu";
            this.leitorToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.leitorToolStripMenu.Text = "Leitor";
            // 
            // funcionarioToolStripMenu
            // 
            this.funcionarioToolStripMenu.Name = "funcionarioToolStripMenu";
            this.funcionarioToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.funcionarioToolStripMenu.Text = "Funcionário";
            // 
            // emprestimoToolStripMenu
            // 
            this.emprestimoToolStripMenu.Name = "emprestimoToolStripMenu";
            this.emprestimoToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.emprestimoToolStripMenu.Text = "Empréstimo";
            // 
            // reservaToolStripMenu
            // 
            this.reservaToolStripMenu.Name = "reservaToolStripMenu";
            this.reservaToolStripMenu.Size = new System.Drawing.Size(153, 22);
            this.reservaToolStripMenu.Text = "Reserva";
            // 
            // ddmFuncionario
            // 
            this.ddmFuncionario.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ddmFuncionario.IsMainMenu = false;
            this.ddmFuncionario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastrarFuncionario,
            this.itemBuscarFuncionario});
            this.ddmFuncionario.MenuItemHeight = 25;
            this.ddmFuncionario.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmFuncionario.Name = "rjDropdownMenu1";
            this.ddmFuncionario.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmFuncionario.Size = new System.Drawing.Size(140, 48);
            // 
            // itemCadastrarFuncionario
            // 
            this.itemCadastrarFuncionario.ForeColor = System.Drawing.Color.Black;
            this.itemCadastrarFuncionario.Name = "itemCadastrarFuncionario";
            this.itemCadastrarFuncionario.Size = new System.Drawing.Size(139, 22);
            this.itemCadastrarFuncionario.Text = "Cadastrar";
            this.itemCadastrarFuncionario.Click += new System.EventHandler(this.itemCadastrarFuncionario_Click);
            // 
            // itemBuscarFuncionario
            // 
            this.itemBuscarFuncionario.Name = "itemBuscarFuncionario";
            this.itemBuscarFuncionario.Size = new System.Drawing.Size(139, 22);
            this.itemBuscarFuncionario.Text = "Buscar";
            this.itemBuscarFuncionario.Click += new System.EventHandler(this.itemBuscarFuncionario_Click);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(198, 703);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.Menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ddmLivro.ResumeLayout(false);
            this.ddmLeitor.ResumeLayout(false);
            this.ddmEmprestimo.ResumeLayout(false);
            this.ddmReserva.ResumeLayout(false);
            this.ddmRelatorio.ResumeLayout(false);
            this.ddmFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private FontAwesome.Sharp.IconButton btnRelatório;
        private FontAwesome.Sharp.IconButton btnPrateleira;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnReserva;
        private FontAwesome.Sharp.IconButton btnEmprestimo;
        private FontAwesome.Sharp.IconButton btnLeitor;
        private FontAwesome.Sharp.IconButton btnLivro;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNome;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmLivro;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitorToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmLeitor;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarLeitor;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarLeitor;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmEmprestimo;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarEmprestimo;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarEmprestimo;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmReserva;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarReserva;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarReserva;
        private FontAwesome.Sharp.IconButton icnButtonBar;
        private FontAwesome.Sharp.IconButton btnGrafico;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem livrotoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem autortoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem leitorToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem emprestimoToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarLivro;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarExemplar;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarEditora;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarAutor;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarGenero;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarEdicao;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarLivro;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarExemplar;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarEditora;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarAutor;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarGenero;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarEdicao;
        private FontAwesome.Sharp.IconButton btnFuncionario;
        private RJCodeAdvance.RJControls.RJDropdownMenu ddmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem itemCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem itemBuscarFuncionario;
    }
}
