namespace TerrorFlix
{
    class Program
    {
        static SerieRepositorio repositorioSeries = new  SerieRepositorio();
        static FilmeRepositorio repositorioFilmes = new  FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        MostrarCatalogo();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                }                
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        //Função que implementa um menu para escolher a opção desejada pelo usuário:
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("----------Bem-vindo à plataforma TerrorFlix!-----------");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Mostrar catálogo");
            Console.WriteLine("2- Inserir filme ou série no catálogo");    
            Console.WriteLine("3- Atualizar filme ou série do catálogo");    
            Console.WriteLine("4- Excluir filme ou série do catálogo");
            Console.WriteLine("5- Visualizar filme ou série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        //Função que mostra na tela os catálogos de séries e de filmes.
        //A função MostrarCatalogo() chama as funções ListarSeries() e ListarFilmes()
        private static void MostrarCatalogo()
        {
            Console.WriteLine("----------Catálogo da TerrorFlix:----------");
            Console.WriteLine();
            ListarSeries();
            Console.WriteLine();
            ListarFilmes();
        }
        
        //Função que mostra na tela a lista com todas as séries cadastradas.
        private static void ListarSeries()
        {
            var lista = repositorioSeries.Lista();

            //Caso a função count do repositório retorne 0, quer dizer que ainda não há nenhum item cadastrado
            Console.WriteLine("Catálogo de Séries: ");
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                Console.WriteLine();
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                Console.WriteLine($"#ID: {serie.retornaId()} - {serie.retornaTitulo()} - {(excluido ? "*Excluido*" : "")}");
            }
        }
        
        //Função que mostra na tela a lista com todos os filmes cadastrados.
        private static void ListarFilmes()
        {
            var lista = repositorioFilmes.Lista();
            
            //Caso a função count do repositório retorne 0, quer dizer que ainda não há nenhum item cadastrado
            Console.WriteLine("Catálogo de Filmes: ");
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                Console.WriteLine();
                return;
            }
            foreach(var filme in lista)
            {
                Console.WriteLine($"#ID: {filme.retornaId()} - {filme.retornaTitulo()}");
            }
        }

        //Função que obtém do usuário se ele quer fazer uma operação com o séries, filmes, ou 
        //voltar para o menu e retorna a opção escolhida.
        private static string FilmeOuSerie(string nomeDaFuncao)
        {
            Console.WriteLine($" {nomeDaFuncao} Filme Ou Série:");
            Console.WriteLine("1 - Série");
            Console.WriteLine("2 - Filme");
            Console.WriteLine("X - Voltar");
            Console.Write("Digite a opção escolhida: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }

        //Função para Inserir filmes ou séries. Ela chama as funções InserirSerie() ou InserirFilme(),
        //dependendo da opção escolhida pelo usuário.
        private static void Inserir()
        {
            string opcaoUsuario = FilmeOuSerie("Inserir");            
            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        InserirSerie();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                }  
                Console.WriteLine();
                opcaoUsuario = FilmeOuSerie("Inserir");
            }
        }

        //Função para inserir uma nova série.
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série:");

            //Instrução de interação foreach.
            //Enumera os elementos do Enum Subgenero e executa seu corpo para cada elemento da coleção.
            //Utilizado para mostrar ao usuário os subgeneros de terror que podem ser escolhidos.
            foreach(int i in Enum.GetValues(typeof(Subgenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenero), i));
            }

            Console.Write("Digite o Subgênero entre as opções acima: ");
            int entradaSubgenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o número de episódios da série: ");
            int entradaEpisódios = int.Parse(Console.ReadLine());

            //Aqui é instanciado um objeto da classe Serie com os valores digitados pelo usuário de parâmetro
            //para o construtor da classe.    
            Serie novaSerie = new Serie(id: repositorioSeries.ProximoId(),
                                        subgenero: (Subgenero)entradaSubgenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        numeroDeEpisodios: entradaEpisódios);
            //Aqui a nova série instanciada é alocada no repositório de séries.
            repositorioSeries.Insere(novaSerie);
        }

        //Função para inserir um novo filme.
        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme:");

            //Instrução de interação foreach.
            //Enumera os elementos do Enum Subgenero e executa seu corpo para cada elemento da coleção.
            //Utilizado para mostrar ao usuário os subgeneros de terror que podem ser escolhidos.
            foreach(int i in Enum.GetValues(typeof(Subgenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenero), i));
            }

            Console.Write("Digite o Subgênero entre as opções acima: ");
            int entradaSubgenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a duração do filme em minutos: ");
            int entradaDuracao = int.Parse(Console.ReadLine());
            
            //Aqui é instanciado um objeto da classe Filme com os valores digitados pelo usuário de parâmetro
            //para o construtor da classe.
            Filme novoFilme = new Filme(id: repositorioFilmes.ProximoId(),
                                        subgenero: (Subgenero)entradaSubgenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        duracao: entradaDuracao);
            //Aqui o novo filme instanciado é alocado no repositório de séries.
            repositorioFilmes.Insere(novoFilme);
        }

        //Função para Atualizar filmes ou séries. Ela chama as funções AtualizarSerie() ou AtualizarFilme(),
        //dependendo da opção escolhida pelo usuário.
        private static void Atualizar()
        {
            string opcaoUsuario = FilmeOuSerie("Atualizar");

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        AtualizarSerie();
                        break;
                    case "2":
                        AtualizarFilme();
                        break;
                }
                Console.WriteLine();
                opcaoUsuario = FilmeOuSerie("Atualizar");
            }
        }

        //Função para atualizar uma nova série.
        private static void AtualizarSerie()
        {
            Console.Write("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Subgenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenero), i));
            }
            Console.WriteLine();

            Console.Write("Digite o Subgênero entre as opções acima: ");
            int entradaSubgenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite o número de episódios da série: ");
            int entradaEpisódios = int.Parse(Console.ReadLine());

            Serie atualizaSerie = new Serie(id: indiceSerie, //próprio id que o usuário digitou
                                            subgenero: (Subgenero)entradaSubgenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao,
                                            numeroDeEpisodios: entradaEpisódios);
            repositorioSeries.Atualiza(indiceSerie, atualizaSerie);
        }

        //Função para atualizar um novo filme.
        private static void AtualizarFilme()
        {
            Console.Write("Digite o Id da série: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Subgenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenero), i));
            }

            Console.Write("Digite o Subgênero entre as opções acima: ");
            int entradaSubgenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a duração do filme em minutos: ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        subgenero: (Subgenero)entradaSubgenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        duracao: entradaDuracao);
            repositorioFilmes.Atualiza(indiceFilme, atualizaFilme);
        }

        //Função para Excluir filmes ou séries. Ela chama as funções ExcluirSerie() ou ExcluirFilme(),
        //dependendo da opção escolhida pelo usuário.
        private static void Excluir()
        {
            string opcaoUsuario = FilmeOuSerie("Excluir");
            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ExcluirSerie();
                        break;
                    case "2":
                        ExcluirFilme();
                        break;
                }
                Console.WriteLine();
                opcaoUsuario = FilmeOuSerie("Excluir");
            }
        }

        //Função para excluir uma série. Ela pede o id da série que o usuário deseja excluir e chama
        //o método Exclui do repositório de séries.
        private static void ExcluirSerie()
        {
            Console.Write("Digite o Id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSeries.Exclui(indiceSerie);
        }
        
        //Função para excluir um filme. Ela pede o id do filme que o usuário deseja excluir e chama
        //o método Exclui do repositório de filmes.
        private static void ExcluirFilme()
        {
            Console.Write("Digite o Id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorioFilmes.Exclui(indiceFilme);
        }


        //Função para Visualizar filmes ou séries. Ela chama as funções VisualizarSerie() ou VisualizarFilme(),
        //dependendo da opção escolhida pelo usuário.
        private static void Visualizar()
        {
            string opcaoUsuario = FilmeOuSerie("Visualizar");

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        VisualizarSerie();
                        break;
                    case "2":
                        VisualizarFilme();
                        break;
                }

                Console.WriteLine();
                opcaoUsuario = FilmeOuSerie("Visualizar");
            }
        }        

        //Função para visualizar uma série. Ela pede o id da série que o usuário deseja visualizar e
        //chama o método RetornaPorId do repositório de séries. Diferente da função MostrarCatálogo(),
        //o método RetornaPorId retorna todo o objeto escolhido, assim é possível mostrar todos os atributos
        //na tela.
        private static void VisualizarSerie()
        {
            Console.Write("Digite o Id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSeries.RetornaPorId(indiceSerie);
            
            Console.WriteLine();
            //Imprime os atributos da série. O método WriteLine foi sobrescrito para a classe, assim é
            //possível fazer uma impressão personalizada.
            Console.WriteLine(serie);
            Console.WriteLine();
        }

        //Função para visualizar um filme. Ela pede o id do filme que o usuário deseja visualizar e
        //chama o método RetornaPorId do repositório de filmes. Diferente da função MostrarCatálogo(),
        //o método RetornaPorId retorna todo o objeto escolhido, assim é possível mostrar todos os atributos
        //na tela.
        private static void VisualizarFilme()
        {
            Console.Write("Digite o Id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilmes.RetornaPorId(indiceFilme);

            Console.WriteLine();
            //Imprime os atributos do filme. O método WriteLine foi sobrescrito para a classe, assim é
            //possível fazer uma impressão personalizada.
            Console.WriteLine(filme);
            Console.WriteLine();
        }
    }
}