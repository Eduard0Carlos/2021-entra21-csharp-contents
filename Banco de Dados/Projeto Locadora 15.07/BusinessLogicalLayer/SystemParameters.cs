using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public static class SystemParameters
    {
        private static Funcionario _funcionario;

        public static void Authenticate(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public static void Logout()
        {
            _funcionario = null;
        }

        public static Funcionario GetCurrentFuncionario()
        {
            return _funcionario;
        }
    }
}
