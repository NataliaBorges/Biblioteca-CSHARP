using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Model;

namespace Biblioteca.Util {
    class Singleton {
        private Singleton() { }
        private static Singleton instancia;
        private FuncionarioModel funcionarioModel { get; set; }

        private List<ExemplarModel> exemplar = new List<ExemplarModel>();
        private LeitorModel leitor;
        private bool addExemplar = false;

        
        public static Singleton GetInstancia() {
            if (instancia == null) {
                instancia = new Singleton();
            }
            return instancia;
        }
        public bool getAddExemplar() {
            return this.addExemplar;
        }
        public void setAddExemplar(bool addExemplar) {
            this.addExemplar = addExemplar;
        }
        public FuncionarioModel getFuncionario() {
            return this.funcionarioModel;
        }
        public void setFuncionario(FuncionarioModel funcionarioModel) {
            this.funcionarioModel = funcionarioModel;
        }
        public List<ExemplarModel> getExemplar() {
            return this.exemplar;
        }
        public void setExemplar(ExemplarModel exemplar) {
            this.exemplar.Add(exemplar);
        }
        public LeitorModel getLeitor() {
            return this.leitor;
        }
        public void setLeitor(LeitorModel leitor) {
            this.leitor = leitor;
        }
        public void removerExemplarLista(ExemplarModel exemplar) {
            int posicao = this.exemplar.FindIndex(item => item.getId() == exemplar.getId());
            this.exemplar.RemoveAt(posicao);
        }
        public void clearEmprestimo() {
            this.exemplar = new List<ExemplarModel>();
            this.leitor = null;
        }

        public void clearReserva() {
            this.exemplar = new List<ExemplarModel>();
            this.leitor = null;
        }
    }
}
