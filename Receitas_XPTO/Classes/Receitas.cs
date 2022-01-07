using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_XPTO
{
    class Receitas : IReceita
    {
        #region Variaveis
        string opcaoMenu;
        //Int16 _ingredientes;
        #endregion

        #region Propriedades
        
        public string ReceitaNome { get; set; }
        public string Ingredientes { get; set; }
        //public int16 Quantidade {set; set;}
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Dificuldade { get; set; }
        public Int16 Duracao { get; set; }
        public string Testada { get; set; }
        public Int16 numero;
        
        List<Receitas> listaReceitas = new List<Receitas>();
        //Ingredientes ingredientes = new Ingredientes("tomate", "2 unidades");
        #endregion

        #region Construtores 
        public Receitas()
        {
            // Cria os construtores vazios
            ReceitaNome = string.Empty;
            Categoria = string.Empty;
            Ingredientes = string.Empty;
            Descricao = string.Empty;
            Dificuldade = string.Empty;
            Duracao = 0;
            //Testada = 0;
            //numero = 0;
        }

        public Receitas(string _receita, string _ingrediente, string _categoria, string _descricao, string _dificuldade, Int16 _duracao, string _testada)
        {
            // Cria a assinatura para o metodo das receitas
            ReceitaNome = _receita;
            Ingredientes = _ingrediente;
            Categoria = _categoria;
            Descricao = _descricao;
            Dificuldade = _dificuldade;
            Duracao= _duracao;
            Testada = _testada;
            //numero = 0;
        }

        #endregion

        #region Métodos

        // Menu a aparecer depois do login bem sucedido
        public void MenuUtilizador()
        {
            
            string[] menu = new string[]
            {
                "\t[Menu de Utilizador]\n",
                "\t[1] - Adicionar nova receita",
                "\t[2] - Listar receitas",
                "\t[3] - Comentar receitas",
                "\t[4] - Classificar receitas",
                "\t[s] - Sair do programa\n"
        };
            
            foreach (string item in menu)
            {
                Console.WriteLine(item);
                
            }

        }

        // Lê a opção do utilizador
        public void LerMenuUtilizador()
        {
            try
            {
                var _validar = true;
                while (_validar)
                {

                    opcaoMenu = Console.ReadLine();
                    switch (opcaoMenu)
                    {
                        case "1":
                            _validar = true;
                            NumeroReceitas();
                            ConteudosReceita();
                            MenuUtilizador();
                            break;
                        case "2":
                            _validar = true;
                            ListarReceitas();
                            MenuUtilizador();
                            
                            break;
                        case "3":
                            _validar = true;
                            Console.Write("---------- Opção em desenvolvimento, escolha outra opção ----------\n\n");
                            MenuUtilizador();
                            LerMenuUtilizador();
                            Console.ReadLine();
                            
                            break;
                        case "4":
                            _validar = true;
                            Console.Write("---------- Opção em desenvolvimento, escolha outra opção ----------\n\n");
                            MenuUtilizador();
                            LerMenuUtilizador();
                            Console.ReadLine();
                            break;
                        case "s":
                            _validar = true;
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente!\n");
                            _validar = false;
                            break;
                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Opção inválida. Tente novamente!\n");
            }
            
            
        } // Lê a opção do utilizador

        // Valida as opções do menu
        public bool ValidarMenu()
        {
            bool validador;

            switch (opcaoMenu)
            {

                case "1":
                    validador = true;
                    break;
                case "2":
                    validador = true;
                    break;
                case "3":
                    validador = true;
                    break;
                case "4":
                    validador = true;
                    break;
                case "s":
                    validador = true;
                    break;
                default:
                    validador = false;
                    break;
            }
            return validador;
        }

        // Pergunta o número de receitas a introduzir
        public void NumeroReceitas()
        {
            Console.Clear();
            try
            {
                Console.Write("\nQuantas receitas quer adicionar?: ");
                numero = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                {
                    Console.Write("Opção inválida. Tente novamente!\n");
                    numero = Convert.ToInt16(Console.ReadLine());
                }
                
            }
            

        }

        public void ConteudosReceita()
        {

            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"\nNome da {i}ª receita:");
                ReceitaNome = Console.ReadLine();

                
                Console.Write("\nQuais os ingredientes?:\n");
                Console.WriteLine("Ex: Água - 500l, Batata - 300g, Cenoura - 120g\n");
                Ingredientes = Console.ReadLine();
                //ingredientes.IngredientRecipe = ReceitaNome;
                //NumeroIgredientes();
                Console.Write("\nQual a categoria:\n\n");
                Console.Write("[Entradas] [Prato Principal] [Sobremesas] [Outros]\n\n");
                Categoria = Console.ReadLine();

                Console.Write("\nQual o grau de dificuldade:\n\n");
                Console.Write("[Fácil] [Médio] [Difícil]\n");
                Categoria = Console.ReadLine();

                Console.Write("\nQual a duração da preparação (em minutos): ");
                Duracao = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nDescreva o modo de preparação:");
                Descricao = Console.ReadLine();

                Console.Write("\nEsta receita já foi testada?: ");
                Testada = Console.ReadLine();

                Console.WriteLine("\n\nDados inseridos com sucesso...\n\n");
                Console.Write("Carregue em qualquer tecla para continuar\n\n");
                Console.ReadKey();
                Console.Clear();
            }
                //Ingredientes.Ingredientes();

                listaReceitas.Add(new Receitas(ReceitaNome, Ingredientes, Categoria, Descricao, Dificuldade, Duracao, Testada));   // incluir receita na lista
                
            }
        
        public void ListarReceitas()
        {
            if ( listaReceitas != null)
            {
                Console.Clear();
                Console.WriteLine("Ainda não existem receitas na nossa base de dados.\n");
            }
            for (int i = 1; i <= numero; i++)
            {
                Console.Clear();
                
                Console.WriteLine("Número de receitas na base de dados: {0}", listaReceitas.Count);
                foreach (Receitas item in listaReceitas)    // listar as receitas
                {
                        Console.WriteLine($"\n\n---------------- {item.ReceitaNome} ----------------");
                        Console.WriteLine($"\nNome da receita: {item.ReceitaNome}\n\n" + $"Ingredientes: {item.Ingredientes}\n\n" +
                        $"Categoria: {item.Categoria}\n\n" +
                        $"Grau de dificuldade: {item.Dificuldade}\n\n" +
                        $"Tempo de preparo: {item.Duracao} minutos\n\n" +
                        $"Modo de Preparo: {item.Descricao}\n\n" + $"Receita testada: {item.Testada}\n");
                        Console.WriteLine($"\n---------------------- Receita adicionada ----------------------\n\n");
                }
                
            }
        }



        // Métodos não implementados

        /*public void NumeroIgredientes()
        {
            try
            {
                for (int i = 0; i < _ingredientes; i++)
                {
                    Console.Write("\nQuantos ingredientes tem a receita?: ");
                    _ingredientes = Convert.ToInt16(Console.ReadLine());
                }
                
            }
            catch (Exception)
            {
                {
                    Console.Write("\nOcorreu um erro. Tente novamente:");
                    _ingredientes = Convert.ToInt16(Console.ReadLine());
                    throw;
                }

            }


        } */

        /*public void ListaReceitasTestadas()
        {
            if (listaReceitasTestadas != null ) && (_testada == true)
            {
                Console.Clear();
                Console.WriteLine("Estas sao as receitas.\n");
            }
            for (int i = 1; i <= numero; i++)
            {
                Console.Clear();

                Console.WriteLine("Número de receitas na base de dados: {0}", listaReceitas.Count);
                foreach (Receitas item in listaReceitas)    // listar as receitas
                {
                    Console.WriteLine($"\n\n---------------- {item.ReceitaNome} ----------------");
                    Console.WriteLine($"\nNome da receita: {item.ReceitaNome}\n\n" + $"Ingredientes: {item.Ingredientes}\n\n" +
                    $"Categoria: {item.Categoria}\n\n" +
                    $"Grau de dificuldade: {item.Dificuldade}\n\n" +
                    $"Tempo de preparo: {item.Duracao} minutos\n\n" +
                    $"Modo de Preparo: {item.Descricao}\n\n" + $"Receita testada: {item.Testada}\n\n");
                    //ingredientes.ListIngredients();
                    //Console.ReadKey();


                }

            }
        }*/

        #endregion 


        // Métodos CRUD não implementados
        #region Métodos CRUD


        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public void Apagar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Pesquisar()
        {
            throw new NotImplementedException();
        }

        //public List<Ingrediente> {get;set;}


        #endregion  

    }
}
