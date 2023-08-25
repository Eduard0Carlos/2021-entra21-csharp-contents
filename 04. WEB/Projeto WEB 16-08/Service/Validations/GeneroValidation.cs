using Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    class GeneroValidation : AbstractValidator<Genero>
    {
        public GeneroValidation()
        {
            RuleFor(g => g.Nome).NotEmpty().WithMessage("Nome deve ser informado.");
            RuleFor(g => g.Nome).Length(3, 50).WithMessage("Nome deve conter entre 3 e 50 caracteres.");
        }
    }
}
