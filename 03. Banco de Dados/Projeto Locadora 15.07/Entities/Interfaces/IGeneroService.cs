using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IGeneroService
    {
        Response Insert(Genero g);
        Response Update(Genero g);
        Response Delete(int id);

        DataResponse<Genero> GetAll();
    }
}
