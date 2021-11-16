using System;
using System.Collections.Generic;
using TerrorFlix.Interfaces;

namespace TerrorFlix
{
    //Classe que representa um repositório de séries. Ela herda as assinaturas de funções
    //do repositório IRepositório:
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //Declara e inicializa uma lista de objetos da classe Serie:
        private List<Serie> listaSerie = new List<Serie>();

        //Recebe objeto do tipo série e coloca na posicao da listaSerie:
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        //Função para excluir um objeto da lista de objetos da classe Filme.
        public void Exclui(int id) 
        {
            listaSerie[id].Excluir();//Aqui está considerando que o próprio id é o índice do vetor
            //Toda vez que excluir uma série, colocar uma mensagem (Dá para fazer outra classe também)
        }

        //Função para inserir um objeto na lista de objetos da classe Filme.
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);//Aqui é utilizado o método Add da classe List
        }

        //Retorna a lista de filmes do repositório criado.
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        //Retorna o número de elementos da lista de filmes do repositório criado.
        //Essa função é utilizada para mostrar qual será o id da próxima série instanciada.
        public int ProximoId()
        {
            return listaSerie.Count; //Quando o Count é zero, significa que não tem nenhum registro
        }
        
        //Retorna um objeto da lista de filmes do repositório criado.
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}