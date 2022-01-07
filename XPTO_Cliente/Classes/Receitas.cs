using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO_DAL;

namespace XPTO_Cliente
{
    public partial class Receitas
    {

        #region Métodos

        public static void Create()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                XPTO_DAL.Receita receita = new XPTO_DAL.Receita();
                receita.ReceitaNome = "Bacalhau";
                receita.Duração = 180;
                receita.Descrição = "Desfiar o bacalhau";
                db.Receita.Add(receita);
                db.SaveChanges();

            }

        } // Método criado, mas não invocado.

        public static void Read()
        {

            using (var db = new ReceitasXPTOEntities())
            {
                var query = db.Receita.Select(r => r).OrderBy(r => r.ReceitaNome);

                Console.WriteLine("\n\n-----------------------\nLista de receitas\n-----------------------");

                foreach (var item in query)
                {
                    Console.WriteLine(item.ReceitaNome);
                }

            }

        }

        public static void Update()
        {

            using (var db = new ReceitasXPTOEntities())
            {

                var nome = db.Utilizador.First(c => c.Username == "UtilizadorTeste");

                nome.Username = "UtilizadorAlterado";

                db.SaveChanges();

            }

        } // Método criado, mas não invocado.

        // Método para eliminar categoria. Não foi invocado.
        public static void Delete()
        {


            using (var db = new ReceitasXPTOEntities())
            {

                var categoria = db.Categoria.Single(c => c.CategoriaID == 1);

                db.Categoria.Remove(categoria);

                db.SaveChanges();

            }


        }



        #endregion

    }
}
