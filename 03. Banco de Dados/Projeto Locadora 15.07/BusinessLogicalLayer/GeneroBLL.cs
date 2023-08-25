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
    public class GeneroBLL : BaseValidator<Genero>, IGeneroService
    {
        private GeneroDAL generoDAL = new GeneroDAL();

        public override Response Validate(Genero item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                this.AddError("Gênero deve ser informado.");
            }
            else
            {
                item.Nome = Normatization.NormatizeString(item.Nome);
                if (item.Nome.Length < 3 || item.Nome.Length > 30)
                {
                    this.AddError("Gênero deve conter entre 3 e 30 caracteres.");
                }
            }
            //TODO: Debater necessidade de prevenção de erro de chave unica!


            //Método pai que transforma os possíveis erros encontrados nas validações acima em um objeto Response!
            return base.Validate(item);
        }

        public Response Insert(Genero g)
        {
            Response response = this.Validate(g);
            if (!response.Success)
            {
                //Se a validação do Gênero falhou, retorne a interface gráfica :(
                return response;
            }

            //Se chegou aqui, nosso objeto gênero está correto e pronto pra ser inserido no banco de dados!
            return generoDAL.Insert(g);
        }

        public DataResponse<Genero> GetAll()
        {
            return generoDAL.GetAll();
        }

        public Response Update(Genero g)
        {
            Response response = this.Validate(g);
            if (!response.Success)
            {
                //Se a validação do Gênero falhou, retorne a interface gráfica :(
                return response;
            }

            //Se chegou aqui, nosso objeto gênero está correto e pronto pra ser editado no banco de dados!
            return generoDAL.Update(g);
        }

        public Response Delete(int id)
        {
            return generoDAL.Delete(id);
        }
    }
}
