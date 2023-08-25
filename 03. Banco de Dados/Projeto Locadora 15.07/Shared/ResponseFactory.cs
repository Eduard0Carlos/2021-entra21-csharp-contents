using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ResponseFactory
    {
        public static Response CreateSucessResponse()
        {
            Response r = new Response()
            {
                Success = true,
                Message = "Operação realizada com sucesso."
            };
            return r;
        }

        public static Response CreateFailureDbResponse()
        {
            Response r = new Response()
            {
                Success = false,
                Message = "Erro no banco de dados, contate o administrador."
            };
            return r;
        }

        public static SingleResponse<T> CreateSucessSingleResponse<T>(T item)
        {
            SingleResponse<T> response = new SingleResponse<T>()
            {
                Message = "Operação realizada com sucesso",
                Success = true,
                Item = item
            };
            return response;
        }



    }
}
