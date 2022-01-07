using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um novo utilizador e uma nova categoria digitada em consola.
            #region Criar

            Utilizadores.Create(); // Recebe os dados em consola e adiciona novo utilizador
            Categorias.Create(); // Recebe os dados em consola e adiciona nova categoria

            Console.ReadKey();

            #endregion

            // Lista os utilizadores, as categorias e as receitas na BD. 
            #region Ler

            Utilizadores.Read();
            Categorias.Read();
            Receitas.Read();

            Console.ReadKey();
            #endregion 

            // Altera dados pre-definidos no código.
            #region Alterar dados
            
            Utilizadores.Update();
            Categorias.Update();

            Console.ReadKey();
            #endregion

        }
    }
}
