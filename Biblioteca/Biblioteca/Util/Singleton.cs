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
        private List<AutorModel> autor = new List<AutorModel>();
        private LeitorModel leitor;
        private bool addExemplar = false;
        private bool addAutor = false;

        //Tela buscar Livro para Editar
        private LivroModel livroExemplar;
        //

        // Buscar genero no cadastro de livro
        private GeneroModel generoBusca;
        private bool buscarGenero = false;

        private FuncaoModel funcaoBusca;

        public void setBuscarGenero(bool busca)
        {
            this.buscarGenero = busca;
        }

        public bool getBuscarGenero()
        {
            return this.buscarGenero;
        }

        public void setGeneroBusca(GeneroModel genero)
        {
            generoBusca = genero;
        }

        public GeneroModel getGeneroBusca()
        {
            return this.generoBusca;
        }

        public void setFuncaoBusca(FuncaoModel funcao)
        {
            funcaoBusca = funcao;
        }

        public FuncaoModel getFuncaoBusca()
        {
            return this.funcaoBusca;
        }

        // Buscar editora no cadastro de livro
        private EditoraModel editoraBusca;
        private bool buscarEditora = false;

        public void setBuscarEditora(bool busca)
        {
            this.buscarEditora = busca;
        }

        public bool getBuscarEditora()
        {
            return this.buscarEditora;
        }

        public void setEditoraBusca(EditoraModel editora)
        {
            editoraBusca = editora;
        }

        public EditoraModel getEditoraBusca()
        {
            return this.editoraBusca;
        }


        // Buscar autor no cadastro de livro
        private AutorModel autorBusca;
        private bool buscarAutor = false;

        public void setBuscarAutor(bool busca)
        {
            this.buscarAutor = busca;
        }

        public bool getBuscarAutor()
        {
            return this.buscarAutor;
        }

        public void setAutorBusca(AutorModel autor)
        {
            autorBusca = autor;
        }

        public AutorModel getAutorBusca()
        {
            return this.autorBusca;
        }
        //Selecionar edição
        private EdicaoModel edicaoBusca;

        private bool buscarEdicao = false;

        public void setBuscarEdicao(bool busca)
        {
            this.buscarEdicao = busca;
        }

        public bool getBuscarEdicao()
        {
            return this.buscarEdicao;
        }
        public void setEdicaoBusca(EdicaoModel edicao)
        {
            edicaoBusca = edicao;
        }

        public EdicaoModel getEdicaoBusca()
        {
            return this.edicaoBusca;
        }

        public static Singleton GetInstancia() {
            if (instancia == null) {
                instancia = new Singleton();
            }
            return instancia;
        }
        public bool getAddExemplar() {
            return this.addExemplar;
        }
        public void setAddAutor(bool addAutor)
        {
            this.addAutor = addAutor;
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

        //Tela buscar Livro para Editar
        public LivroModel getLivroExemplar()
        {
            return this.livroExemplar;
        }
        public void setLivroExemplar(LivroModel livro)
        {
            this.livroExemplar = livro;
        }
        //
    }
}
