using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO_DAL;

namespace XPTO_Cliente
{
    public partial class Categorias
    {

        #region Métodos

        public static void Create()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                XPTO_DAL.Categoria categoria = new XPTO_DAL.Categoria();
                Console.Write("\n\n-------------------------------\nRegisto de nova categoria\n-------------------------------\n\n");
                Console.Write("Escreva o nome da nova categoria: ");
                categoria.CategoriaNome = Console.ReadLine();
                db.Categoria.Add(categoria);
                db.SaveChanges();
                Console.WriteLine($"\nA categoria: {categoria.CategoriaNome} foi salva.\n\n\n");
                Console.WriteLine($"\nPressione qualquer tecla para continuar\n\n\n");

            }

        }

        public static void Read()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                var query = db.Categoria.Select(r => r).OrderBy(r => r.CategoriaID);

                Console.WriteLine("\n\n-----------------------\nLista de Categorias\n-----------------------");

                foreach (var item in query)
                {
                    Console.WriteLine(item.CategoriaNome);
                }

            }

        }

        public static void Update()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                var nome = db.Categoria.First(c => c.CategoriaNome == "Doces");

                nome.CategoriaNome = "Entradas";

                db.SaveChanges();
                Console.WriteLine($"\nA categoria foi alterada");
            }

        }

         // Método para eliminar uma receita. Não foi invocado.
        public static void Delete()
        {

            
            using (var db = new ReceitasXPTOEntities())
            {

                var receita = db.Receita.Single(c => c.ReceitaID == 1);

                db.Receita.Remove(receita);

                db.SaveChanges();

            }
            

        }



        #endregion

    }
}
