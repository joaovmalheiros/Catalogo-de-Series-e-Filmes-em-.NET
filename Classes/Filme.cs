namespace TerrorFlix
{
    //Classe que representa um filme. Ela herde os atributos e métodos da classe abstrata EntidadeBase
    //e implementa itens característicos de um filme, como a duração do filme.
    public class Filme : EntidadeBase
    {
        //Atributos específicos da classe Filme:
        public int Duracao {get; protected set;}

        //O construtor de Filme chama o construtor da classe base e inicializa seus atributos específicos
        //(no caso o atributo duração):
        public Filme(int id, Subgenero subgenero, string titulo, string descricao, int ano, 
                    int duracao) : base(id, subgenero, titulo, descricao, ano)
        {
            this.Duracao = duracao;
            this.Excluido = false;
        }

        //Aqui é sobrescrita o método ToString para que sejam fornecidas as informações específicas da classe
        //Filme:
        public override string ToString()
        {
            string retorno = "";
            retorno += "Subgenero: " + this.Subgenero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Duracao: " + this.Duracao + " min" + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    }
}