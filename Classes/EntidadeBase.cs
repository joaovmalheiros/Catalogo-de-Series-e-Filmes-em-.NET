namespace TerrorFlix //A classe vale para  todo mundo que estiver no namespace TerrorFlix
{
    //Classe abstrata usada para implementar as classes Serie e Filme. Ela possui atributos e métodos comuns
    //às duas classes. Classes abstratas não podem ser implentadas.
    public abstract class EntidadeBase
    {
        //Atributos comuns às classes Filme e Serie:
        public int Id {get; protected set;}
        public Subgenero Subgenero {get; protected set;} //Subgenero do Genero Terror
        public string Titulo {get; protected set;} //Titulo da serie ou filme
        public string Descricao {get; protected set;} //Descricao da serie ou filme
        public int Ano {get; protected set;} //Ano de lançamento da série ou filme

        public bool Excluido {get; protected set;} //Mostra se campo está excluído ou não

        //Construtor da classe EntidadeBase.
        public EntidadeBase(int id, Subgenero subgenero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Subgenero = subgenero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        //Função que retorna o título da série ou filme.
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        //Função que retorna o id da série ou filme.
        public int retornaId()
        {
            return this.Id;
        }
        
        //Função para "excluir" um objeto das classes Serie ou Filme. Na verdade o objeto continua existindo,
        //Porém o valor do atributo Excluido é setado como "True", indicando que o item está excluído.
        public void Excluir()
        {
            this.Excluido = true;
        }

        //Função que retorna o valor do atributo Excluido.
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

    }
}