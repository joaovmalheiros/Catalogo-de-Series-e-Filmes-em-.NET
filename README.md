# **Terror Flix** 💀🍿📺

Projeto desenvolvido em .NET com a Digital Innovation One e Eliézer Zarpelão. Foi feito um algoritmo simples de cadastro de séries para praticar conhecimentos de orientação a objetos. Contribui com a minha versão implementando um catálogo de filmes e série de terror.

# **Começando**

Para executar o projeto, será necessário instalar os seguintes programas:
- JDK (kit de desenvolvimento necessário para executar o projeto): https://dotnet.microsoft.com/download
- Visual Studio (IDE para desenvolvimento do projeto): https://visualstudio.microsoft.com/pt-br/downloads/

# **Desenvolvimento**

Para iniciar o desenvolvimento, é necessário clonar o projeto do GitHub num diretório de sua preferência:

cd "diretorio de sua preferencia"
git clone https://github.com/joaovmalheiros/Meus-Projetos/tree/main/Projetos%20C%23/TerrorFlix

# **Features**

Diferentemente do projeto original, em que foi implementado apenas um cadastro de séries, desenvolvi algumas funcionalidades para que o usuário escolha se quer fazer alguma operação com filmes ou com séries.

Basicamente, dependendo da opção do usuário, o programa imprime o catálogo com os filmes e séries cadastrados, insere um novo filme/série, atualiza um filme/série existente, exclui um filme/série ou visualiza um filme/série específico definido pelo usuário.

Foram implementadas as classes Serie e Filme, que herdam os atributos e métodos da classe abstrata EntidadeBase e possuem também seus atributos específicos. Também foram implementados repositórios para cada uma (SerieRepositorio e FilmeRepositorio), que implementaram as assinaturas dos métodos da Interface IRepositorio.

Os subgeneros de terror que são utilizados como atributos tanto da classe Serie quanto da classe Filme foram definidos por meio de um Enum Subgenero.

# **Implementações que ainda pretendo fazer:**
- [ ] Implementar a classe Episodio, que foi criada, porém não é utilizada no programa. A classe Serie deverá possuir uma lista da classe Episodio. Pretendo colocar uma opção em que o usuário possa definir o nome e duração de cada episódio de uma série. 
- [ ] Tratar possíveis erros e exceções que podem ocorrer durante a execução do programa.
- [ ] Melhorar a saída dos dados para que fique visualmente mais intuitivo para o usuário que utilizar o programa.