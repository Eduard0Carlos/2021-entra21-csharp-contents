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
    public class FormaPagamentoBLL : BaseValidator<FormaPagamento>, IFormaPagamentoService
    {
        private FormaPagamentoDAL formaPagamentoDAL = new FormaPagamentoDAL();
        public override Response Validate(FormaPagamento item)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("Gênero deve ser informado");
            }
            else
            {
                item.Descricao = Normatization.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 30)
                {
                    this.AddError("Gênero deve conter entre 3 e 30 caracteres");
                }
            }


            return base.Validate(item);
        }

        public DataResponse<FormaPagamento> GetAll()
        {
            return formaPagamentoDAL.GetAll();
        }

        public Response Insert(FormaPagamento formaPagamento)
        {
            Response response = this.Validate(formaPagamento);
            if (!response.Success)
            {
                return response;
            }

            return formaPagamentoDAL.Insert(formaPagamento);
        }

        public Response Updated(FormaPagamento formaPagamento)
        {
            Response response = this.Validate(formaPagamento);
            if (!response.Success)
            {
                return response;
            }

            return formaPagamentoDAL.Updated(formaPagamento);
        }

        public Response Delete(int id)
        {
            return formaPagamentoDAL.Delete(id);
        }
    }
}
