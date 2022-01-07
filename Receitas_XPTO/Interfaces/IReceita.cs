using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_XPTO
{
    interface IReceita
    {
        #region Propriedades

        string ReceitaNome { get; }
        string Categoria { get; }
        string Ingredientes { get; }
        //string Quantidade {get; set;}
        string Descricao { get; }
        string Dificuldade { get; }
        Int16 Duracao { get; }
        //List<Ingrediente> Ingrediente {get;}

        #endregion

        #region Métodos

        void Inserir();
        void Apagar();
        void Editar();
        void Pesquisar();
        //void Ingredientes();

        #endregion
    }
}
