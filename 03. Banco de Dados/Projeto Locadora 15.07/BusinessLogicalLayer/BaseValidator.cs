using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    /// <summary>
    /// Classe base para os BLL's do sistema
    /// </summary>
    /// <typeparam name="T">Entidade que será validada</typeparam>
    public class BaseValidator<T>
    {
        //Objeto que conterá todos os erros da entidade
        private StringBuilder erros = new StringBuilder();

        /// <summary>
        /// Método protegido que apenas quem herda de BaseValidator enxerga
        /// </summary>
        /// <param name="error"></param>
        protected void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                this.erros.AppendLine(error);
            }
        }

        public virtual Response Validate(T item)
        {
            Response response = new Response();
            if (this.erros.Length != 0)
            {
                response.Success = false;
                response.Message = this.erros.ToString();
                this.erros.Clear();
                return response;
            }

            response.Success = true;
            response.Message = "Validação realizada com sucesso!";
            return response;
        }


    }
}
