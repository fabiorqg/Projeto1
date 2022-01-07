using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas_XPTO
{
    interface IUtilizador
    {
        #region Properties
        string Username { get; }
        string Password { get; }
        int Pin { get; }

        #endregion

        #region Methods  

        bool Login(string username, string password);
        bool Login(int _pin);

        #endregion
    }
}
