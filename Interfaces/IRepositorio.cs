using System.Collections.Generic; //Pesquisar

namespace TerrorFlix.Interfaces
{
    //Interface criada para
    //Interfaces agem como um contrato. Sempre que é necessário definir algo, opta-se por utilizar interfaces.
    //O propósito é de posteriormente implementar a interface em uma outra classe.
    //No caso, é definida uma classe IRepositorio que contém assinaturas de métodos que serão implementados
    //pelas classes FilmeRepositorio e SerieRepositorio. Dá para ter várias classes implementando o mesmo
    //contrato.
    //Interfaces só permitem assinaturas de métodos, implementações não são possíveis.
    //O <T> é um tipo genérico. Com isso dá pra fazer repositórios de classes diferentes.
    public interface IRepositorio<T>
    {
        //Retorna uma lista de <T>:
        List<T> Lista(); 
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}