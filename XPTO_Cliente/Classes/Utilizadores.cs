using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO_DAL;

namespace XPTO_Cliente
{
    public partial class Utilizadores
    {

        #region Métodos

        public static void Create()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                XPTO_DAL.Utilizador utilizador = new XPTO_DAL.Utilizador();
                Console.Write("\n\n-----------------------\nRegisto de novo utilizador\n-------------------------------\n\n");
                Console.Write("Nome de utilizador:");
                utilizador.Username = Console.ReadLine();
                Console.Write("Password:");
                utilizador.Password = Console.ReadLine();
                Console.Write("PIN:");
                utilizador.Pin = Console.ReadLine();
                db.Utilizador.Add(utilizador);
                db.SaveChanges();
                Console.WriteLine($"\nNovo utilizador registado\n");
                Console.WriteLine($"\nPressione qualquer tecla para continuar\n\n\n");

            }

        }

        public static void Read()
        {

            using (var db = new ReceitasXPTOEntities())
            {
                var query = db.Utilizador.Select(r => r).OrderBy(r => r.Username);

                Console.WriteLine("\n\n-----------------------\nLista de utilizadores registados\n-----------------------");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Username);
                }

            }

        }

        public static void Update()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                var nome = db.Utilizador.First(c => c.Username == "UtilizadorAlterado");

                nome.Username = "Ana";

                db.SaveChanges();
                Console.WriteLine($"\nO username UtilizadorAlterado foi alterada para Ana");
            }

        }


        // Método para eliminar utilizador. Não foi invocado.
        public static void Delete()
        {

            
            using (var db = new ReceitasXPTOEntities())
            {

                var user = db.Utilizador.Single(c => c.UtilizadorID == 1);

                db.Utilizador.Remove(user);

                db.SaveChanges();

            }
            

        }

        #endregion

    }
}
