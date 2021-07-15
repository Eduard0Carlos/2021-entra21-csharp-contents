using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IFuncionarioService
    {
        SingleResponse<Funcionario> Authenticate(string email, string senha);
    }
}
