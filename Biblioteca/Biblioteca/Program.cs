using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Util;
using Biblioteca.View;
using Biblioteca.View.Autor;
using Biblioteca.View.Funcionario;
using Biblioteca.View.Livros;

namespace Biblioteca {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Singleton singleton = Singleton.GetInstancia();
            Application.Run(new FuncionarioBuscarView());
        }
    }
}
