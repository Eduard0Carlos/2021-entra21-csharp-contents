using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class ClienteBusinessValidator
    {
        public string Cadastrar(Cliente cliente)
        {
            ClienteFileDAL clienteDAL = new ClienteFileDAL();

            string erros = "";

            cliente.Nome = Normatization.NormatizeString(cliente.Nome);
            erros += CommonValidations.IsValidNome(cliente.Nome);

            erros += CommonValidations.IsEmail(cliente.Email, true);

            cliente.CPF = cliente.CPF?.Trim().Replace("-", "").Replace(".", "");
            string erroCPF = CommonValidations.IsCpf(cliente.CPF);
            if (erroCPF == "" && clienteDAL.Exists(cliente))
            {
                erroCPF = "Cliente já cadastrado.\r\n";
            }
            erros += erroCPF;


            cliente.Rua = Normatization.NormatizeString(cliente.Rua);
            erros += CommonValidations.IsValidRua(cliente.Rua);

            cliente.Bairro = Normatization.NormatizeString(cliente.Bairro);
            erros += CommonValidations.IsValidBairro(cliente.Bairro);

            cliente.Complemento = Normatization.NormatizeString(cliente.Complemento);
            erros += CommonValidations.IsValidComplementoNumero(cliente.Complemento, cliente.Numero);

            cliente.CEP = cliente.CEP?.Trim().Replace("-", "");
            erros += CommonValidations.IsValidCEP(cliente.CEP);

            cliente.Telefone = Normatization.NormatizeString(cliente.Telefone);
            erros += CommonValidations.IsValidTelefone(cliente.Telefone);

            cliente.EstadoCivil = Normatization.NormatizeString(cliente.EstadoCivil);
            erros += CommonValidations.IsValidEstadoCivil(cliente.EstadoCivil);

            cliente.Genero = Normatization.NormatizeString(cliente.Genero);
            erros += CommonValidations.IsValidGenero(cliente.Genero);

            erros += CommonValidations.IsValidAge(cliente.DataNascimento);

            cliente.Cidade = Normatization.NormatizeString(cliente.Cidade);
            erros += CommonValidations.IsValidCidadeUF(cliente.UF, cliente.Cidade);

            if (erros != "")
            {
                return erros;
            }

            //Se chegou aqui, podemos jogar no banco de dados!
            return clienteDAL.Cadastrar(cliente);
        }

    }
}
