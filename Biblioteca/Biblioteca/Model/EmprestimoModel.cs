using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model {
    class EmprestimoModel {
        int ID { get; set; }
        public int IdFuncionario { get; set; }
        public int IdLeitor { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public String Obs { get; set; }

        public String Leitor { get; set; }

        public String Funcionario { get; set;  }

        public String Status { get; set; }

        public EmprestimoModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataDevolucao, DateTime DataEmprestimo, String Obs) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataDevolucao = DataDevolucao;
            this.DataEmprestimo = DataEmprestimo;
            this.Obs = Obs;
        }
        public EmprestimoModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataDevolucao, DateTime DataEmprestimo) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataDevolucao = DataDevolucao;
            this.DataEmprestimo = DataEmprestimo;
        }
        public EmprestimoModel(int ID, int IdFuncionario, int IdLeitor, DateTime DataDevolucao, DateTime DataEmprestimo, String Leitor, String Funcionario, String Status) {
            this.ID = ID;
            this.IdFuncionario = IdFuncionario;
            this.IdLeitor = IdLeitor;
            this.DataDevolucao = DataDevolucao;
            this.DataEmprestimo = DataEmprestimo;
            this.Leitor = Leitor;
            this.Funcionario = Funcionario;
            this.Status = Status;
        }
        public int getId() {
            return this.ID;
        }
    }
}
