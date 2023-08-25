using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class FuncionarioBLL : BaseValidator<Funcionario>, IFuncionarioService
    {
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public override Response Validate(Funcionario item)
        {
            return base.Validate(item);
        }

        public SingleResponse<Funcionario> Authenticate(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                this.AddError("Email deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                this.AddError("Senha deve ser informada.");
            }
            //se chamar o this.Validate(), todas as validações seriam repetidas! Não queremos isso, queremos apenas validar
            //o que está neste método de autenticação e chamar o método da classe pai que transforma os erros em um response!
            Response response = base.Validate(null);
            if (response.Success)
            {
                SingleResponse<Funcionario> responseFuncionario = funcionarioDAL.Authenticate(email, senha);
                if (responseFuncionario.Success)
                {
                    SystemParameters.Authenticate(responseFuncionario.Item);
                }
                return responseFuncionario;
            }
            return new SingleResponse<Funcionario>()
            {
                Message = response.Message,
                Success = false
            };
        }
    }
}
