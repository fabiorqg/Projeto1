using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_XPTO
{
    class Utilizador : IUtilizador
    {

        #region Variáveis
        string opcaoMenu;
        #endregion

        #region Propriedades

        public string Username { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }
        

        #endregion

        #region Construtores

        public Utilizador()
        {

        }

        public Utilizador(string _username, string _password)
        {
            Username = _username;
            Password = _password;

        }

        public Utilizador(int _pin)
        {
            Pin = _pin;

        }

        #endregion

        #region Métodos  

        public void MenuInicial()
        {
            string[] menu = new string[]
            {
                " [a] - Com username e password",
                " [b] - Com PIN",
                " [s] - Sair do programa\n"
            };
            Console.WriteLine("-----------Bem-vindo ao receitas XPTO -----------\n");
            Console.WriteLine("\t     [Menu de Autenticação]\n");
            Console.WriteLine("[Escolha uma das opções de Login disponíveis]\n");
            ///Console.WriteLine("\n**** Dados de acesso predefinidos ****\nUsername: fabio | Password: 123 | Pin: 4444\n\n");

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

        } // Apresenta o menu inicial de autenticação

        public void LerMenuInicial() // Lê a opção de LOGIN do utilizador
        {
            try
            {
                var _validar = false;
                while (!_validar)
                {

                    opcaoMenu = Console.ReadLine();
                    switch (opcaoMenu)
                    {
                        case "a":
                            _validar = true;
                            Login(Username, Password);
                            break;
                        case "b":
                            _validar = true;
                            Login(Pin);
                            break;
                        case "s":
                            _validar = true;
                            Console.WriteLine("sair");
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida. Tente novamente!\n\n");
                            _validar = false;
                            break;

                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\nOpção inválida. Tente novamente!\n\n");
                Login(Pin); 

            }
        }

        public bool Login(string username, string password)
        {


            Console.Write("---------- Login com credenciais ----------\n\n");

            {
                Console.WriteLine("Digite os dados: \n");
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (Username == username && Password == password)
                {
                    Console.WriteLine("Login feito com sucesso\n\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("Atenção: Dados incorretos. Tente novamente!\n\n");
                    Login(username, password);
                    return false;
                }
            }


        } // Método Password e Password

        public bool Login(int pin)
        {


            Console.Write("---------- Login com PIN ----------\n\n");

            {
                Console.Write("PIN: ");
                Pin = Convert.ToInt32(Console.ReadLine());

                if (Pin == 4444)
                {
                    Console.WriteLine("Login feito com sucesso\n\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("Atenção: Dados incorretos. Tente novamente!\n\n");
                    Login(Pin);
                    return false;

                }

            }


        } // Método Password e Password

        public bool ValidarMenu()
        {
            bool validador;

            switch (opcaoMenu)
            {

                case "a":
                    validador = true;
                    break;
                case "b":
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

        #endregion

    }
}
