using Domain;
using FluentValidation.Results;
using Service.Interfaces;
using Service.Validations;
using System;
using Service.Extensions;
using DataInfrastructure;
using System.Linq;

namespace Service
{

    public class GeneroService : IGeneroService
    {
        public Response Cadastrar(Genero genero)
        {
            GeneroValidation validation = new GeneroValidation();
            ValidationResult result = validation.Validate(genero);

            Response r = result.ToResponse();
            if (!r.DeuBoa)
            {
                return r;
            }

            try
            {
                using (LocadoraDBContext db = new LocadoraDBContext())
                {
                    //Verifica se o gênero já existe
                    Genero generoCadastrado = db.Generos.FirstOrDefault(g => g.Nome == genero.Nome);
                    if (generoCadastrado != null)
                    {
                        //Retorna pois a chave única estouraria este registro
                        return new Response()
                        {
                            DeuBoa = false,
                            Mensagem = "Gênero já cadastrado."
                        };
                    }

                    db.Generos.Add(genero);
                    db.SaveChanges();
                    return new Response()
                    {
                        DeuBoa = true,
                        Mensagem = "Gênero cadastrado com sucesso."

                    };
                }
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    DeuBoa = false,
                    Mensagem = "Erro no banco de dados, contate o administrador."
                };
            }
        }

    }
}
