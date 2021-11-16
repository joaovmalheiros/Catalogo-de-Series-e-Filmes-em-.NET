namespace TerrorFlix
{
    //Classe que representa uma série. Ela herde os atributos e métodos da classe abstrata EntidadeBase
    //e implementa itens característicos de uma série, como o número de episódios.
    public class Serie : EntidadeBase //Serie herda de EntidadeBase
    {
        //Atributos específicos da classe Serie:
        public int NumeroDeEpisodios{get; protected set;}

        //O construtor de Serie chama o construtor da classe base e inicializa seus atributos específicos
        //(no caso o atributo número de episódios):
        public Serie(int id, Subgenero subgenero, string titulo, string descricao, int ano,
                    int numeroDeEpisodios) : base(id, subgenero, titulo, descricao, ano)
        {
            this.NumeroDeEpisodios = numeroDeEpisodios;
            this.Excluido = false;
        }

        //Aqui é sobrescrita o método ToString para que sejam fornecidas as informações específicas da classe
        //Serie:
        public override string ToString()
        {
            string retorno = "";
            retorno += "Subgenero: " + this.Subgenero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Número de Episódios: " + this.NumeroDeEpisodios + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    }
}