namespace TerrorFlix
{   
    //Classe que representa um episódio de uma série. Ainda não foi implementada no programa.
    public class Episodio
    {
        public string NomeDoEpisodio{get; protected set;}
        public int DuracaodoEpisodio{get; protected set;}

        public Episodio(string nome, int duracao)
        {
            this.NomeDoEpisodio = nome;
            this.DuracaodoEpisodio = duracao;
        }
    }
}