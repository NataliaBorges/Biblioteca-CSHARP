using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Emprestimo;
using Biblioteca.View.Fornecedor;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Leitor;
using Biblioteca.View.Livros;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Util
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
        private void MenuControl_Load(object sender, EventArgs e)
                {
                    ddmCadastro.IsMainMenu = true;
                    ddmCadastro.PrimaryColor = Color.Chocolate;
                    ddmCadastro.MenuItemTextColor = Color.Chocolate;

                    ddmBuscar.IsMainMenu = true;
                    ddmBuscar.PrimaryColor = Color.Chocolate;
                    ddmBuscar.MenuItemTextColor = Color.Chocolate;

                    ddmEmprestimo.IsMainMenu = true;
                    ddmEmprestimo.PrimaryColor = Color.Chocolate;
                    ddmEmprestimo.MenuItemTextColor = Color.Chocolate;

                    ddmReserva.IsMainMenu = true;
                    ddmReserva.PrimaryColor = Color.Chocolate;
                    ddmReserva.MenuItemTextColor = Color.Chocolate;

                }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ddmCadastro.Show(btnHome, btnHome.Width, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ddmBuscar.Show(btnBuscar, btnBuscar.Width, 0);
        }

        private void btnEmrestimo_Click(object sender, EventArgs e)
        {
            ddmEmprestimo.Show(btnEmprestimo, btnEmprestimo.Width, 0);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ddmReserva.Show(btnReserva, btnReserva.Width, 0);
        }

        
    }
}
