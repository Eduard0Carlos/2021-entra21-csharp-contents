using Domain;
using FluentValidation.Results;
using Service.Validations;
using System;

namespace Service
{
    public class GeneroService
    {
        public Response Cadastrar(Genero genero)
        {
            GeneroValidation validation = new GeneroValidation();
            ValidationResult result = validation.Validate(genero);
            if (!result.IsValid)
            {
                return result;
            }
            //

        }

    }
}
