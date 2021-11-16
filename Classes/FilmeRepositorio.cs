using System;
using System.Collections.Generic;
using TerrorFlix.Interfaces;

namespace TerrorFlix
{
    //Classe que representa um repositório de filmes. Ela herda as assinaturas de funções
    //do repositório IRepositório:
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        //Declara e inicializa uma lista de objetos da classe Filme:
        private List<Filme> listaFilme = new List<Filme>();
        //Recebe objeto do tipo série e coloca na posicao da listaFilme:
        public void Atualiza(int id, Filme objeto)
        {
            listaFilme[id] = objeto;
        }

        //Função para excluir um objeto da lista de objetos da classe Filme.
        public void Exclui(int id) 
        {
            listaFilme[id].Excluir();//Aqui está considerando que o próprio id é o índice do vetor
            //Toda vez que excluir uma série, colocar uma mensagem (Dá para fazer outra classe também)
        }

        //Função para inserir um objeto na lista de objetos da classe Filme.
        public void Insere(Filme objeto)
        {
            listaFilme.Add(objeto); //Aqui é utilizado o método Add da classe List.
        }

        //Retorna a lista de filmes do repositório criado.
        public List<Filme> Lista()
        {
            return listaFilme;
        }

        //Retorna o número de elementos da lista de filmes do repositório criado.
        //Essa função é utilizada para mostrar qual será o id do próximo fime instanciado.
        public int ProximoId()
        {
            return listaFilme.Count; //Quando o Count é zero, significa que não tem nenhum registro
        }

        //Retorna um objeto da lista de filmes do repositório criado.
        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}