using Shared;

namespace Entities.Interfaces
{
    public interface IFormaPagamentoService
    {
        Response Insert(FormaPagamento g);
        Response Updated(FormaPagamento g);
        Response Delete(int id);
        DataResponse<FormaPagamento> GetAll();
    }
}
