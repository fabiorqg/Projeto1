using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_XPTO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estanciar
            Receitas receita01 = new Receitas();
            Utilizador user01 = new Utilizador("fabio", "123");
            

            #endregion

            #region Invocar os métodos

            user01.MenuInicial();
            user01.LerMenuInicial();
            receita01.MenuUtilizador();
            receita01.LerMenuUtilizador();
            receita01.ValidarMenu();

            #endregion

        }
    }
}
