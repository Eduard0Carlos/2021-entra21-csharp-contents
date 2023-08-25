using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    internal class CommonValidations
    {
        public static string IsCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                return "CPF deve ser informado.\r\n";
            }

            if (cpf.Length != 11)
            {
                return "CPF deve conter 11 caracteres.\r\n";
            }


            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            bool valido = cpf.EndsWith(digito);
            if (!valido)
            {
                return "CPF inválido.\r\n";
            }
            return "";
        }

        public static string IsEmail(string email, bool isRequired)
        {
            if (isRequired && string.IsNullOrWhiteSpace(email))
            {
                return "Email deve ser informado.\r\n";
            }

            string erroEmail = IsValidLength(email, 8, 100, "Email");
            if (erroEmail != "")
            {
                return erroEmail;
            }

            string regex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            bool isValid = Regex.IsMatch(email, regex);
            if (!isValid)
            {
                return "Email inválido.\r\n";
            }
            return "";
        }

        public static string IsValidLength(string value, int min, int max, string fieldName)
        {
            if (value.Length < min || value.Length > max)
            {
                return string.Format("O campo {0} deve conter entre {1} e {2} caracteres.\r\n", fieldName, min, max);
                //return "O campo " + fieldName + " deve conter entre " + min + " e " + max + " caracteres.\r\n";
            }
            return "";
        }

        public static string AssertOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                char letra = value[i];
                if (!char.IsLetter(letra) && letra != ' ' && letra != '\'')
                {
                    //Se entrou aqui, o valor possui algum caracter que não é letra,
                    //nem espaço em branco e nem apóstrofe (')
                    return string.Format("O campo {0} não pode conter caracteres inválidos", fieldName);
                }
            }
            return "";
        }

        public static string IsValidCEP(string cep)
        {
            if (string.IsNullOrWhiteSpace(cep))
            {
                return "CEP deve ser informado.\r\n";
            }
            if (cep.Length != 8)
            {
                return "CEP deve conter 8 caracteres.\r\n";
            }
            if (!Regex.IsMatch(cep, @"^\d{5}\d{3}$"))
            {
                return "CEP inválido.\r\n";
            }
            return "";
        }

        public static string IsValidBairro(string bairro)
        {
            if (string.IsNullOrWhiteSpace(bairro))
            {
                return "Bairro deve ser informado.\r\n";
            }
            return IsValidLength(bairro, 3, 100, "Bairro");
        }

        public static string IsValidRua(string rua)
        {
            if (string.IsNullOrWhiteSpace(rua))
            {
                return "Rua deve ser informada.\r\n";
            }
            return IsValidLength(rua, 3, 100, "Rua");
        }

        public static string IsValidNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "O nome deve ser informado.\r\n";
            }
            string tamanhoEhValido = CommonValidations.IsValidLength(nome, 3, 70, "Nome");
            if (tamanhoEhValido != "")
            {
                return tamanhoEhValido;
            }
            return CommonValidations.AssertOnlyLetters(nome, "Nome");
        }

        public static string IsValidComplementoNumero(string complemento, string numeroCasa)
        {
            if (string.IsNullOrWhiteSpace(numeroCasa) && string.IsNullOrWhiteSpace(complemento))
            {
                return "Complemento obrigatório caso não tenha numero da casa.\r\n";
            }
            if (complemento?.Length > 30)
            {
                return "Complemento não pode conter mais de 30 caracteres.\r\n";
            }
            if (numeroCasa?.Length > 10)
            {
                return "Número da casa não pode conter mais de 6 caracteres.\r\n";
            }
            return "";
        }

        public static string IsValidTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
            {
                return "Telefone deve ser informado.\r\n";
            }
            if (telefone.Length < 8 || telefone.Length > 13)
            {
                return "Telefone deve conter entre 10 e 13 caracteres.\r\n";
            }
            if (!Regex.IsMatch(telefone, @"^\(?[1-9]{2}\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$"))
            {
                return "Telefone inválido.\r\n";
            }
            return "";
        }

        public static string IsValidGenero(string genero)
        {
            if (string.IsNullOrWhiteSpace(genero))
            {
                return "Gênero deve ser informado.\r\n";
            }

            string[] generos = { "Feminino", "Masculino", "Indeterminado" };
            if (!generos.Contains(genero))
            {
                return "Gênero inválido.\r\n";
            }

            return "";
        }

        public static string IsValidEstadoCivil(string estadoCivil)
        {
            if (string.IsNullOrWhiteSpace(estadoCivil))
            {
                return "Estado Civil deve ser informado.\r\n";
            }
            string[] estadosCivis = { "Solteiro", "Casado", "Viúvo", "Divorciado", "Separado", "União Estável" };
            if (!estadosCivis.Contains(estadoCivil))
            {
                return "Estado Civil inválido.\r\n";
            }
            return "";
        }

        public static string IsValidAge(DateTime dataNascimento)
        {
            DateTime birthdate = dataNascimento;
            DateTime today = DateTime.Now;
            int age = today.Year - birthdate.Year;
            //Necessário para ver se a pessoa já fez aniversário esse ano!
            if (birthdate > today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                return "Idade inválida. Apenas maiores de 18 anos podem ter cadastro.\r\n";
            }
            return "";
        }

        public static string IsValidCidadeUF(string uf, string cidade)
        {
            if (string.IsNullOrWhiteSpace(uf) || string.IsNullOrWhiteSpace(cidade))
            {
                return "UF e Cidade devem ser preenchidas.\r\n";
            }
            string[] uFs = { "SC", "SP", "RS", "PR" };
            if (!uFs.Contains(uf))
            {
                return "UF inválida.\r\n";
            }

            string[] cidadesValidasSP = { "São Paulo", "Santos", "Baurú" };
            string[] cidadesValidasSC = { "Blumenau", "Joaçaba", "Luiz Alves"};
            string[] cidadesValidasPR = { "Curitiba", "Londrina", "Ponta Grossa"};
            string[] cidadesValidasRS = { "Porto Alegre", "Não Me Toque", "Vacaria" };

            if (uf == "SP" && !cidadesValidasSP.Contains(cidade))
            {
                return "Município inválido para o UF de SP.\r\n";
            }
            if (uf == "SC" && !cidadesValidasSC.Contains(cidade))
            {
                return "Município inválido para o UF de SC.\r\n";
            }
            if (uf == "PR" && !cidadesValidasPR.Contains(cidade))
            {
                return "Município inválido para o UF de PR.\r\n";
            }
            if (uf == "RS" && !cidadesValidasRS.Contains(cidade))
            {
                return "Município inválido para o UF de RS.\r\n";
            }
            return "";
        }


}
}

