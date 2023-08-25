using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

   //public static class ResponseFactory
   // {
   //     public static Response CreateSuccessResponse()
   //     {
   //         Response r = new Response();
   //         r.Success = true;
   //         r.Message = "Operação realizada com sucesso.";
   //         return r;
   //     }
   // }
}
