using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Telefone { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }

        public override string ToString()
        {
            return Nome + "\r\n" +
                   CPF + "\r\n" +
                   Email + "\r\n" +
                   DataNascimento + "\r\n" +
                   Cidade + "\r\n" +
                   UF + "\r\n" +
                   Rua + "\r\n" +
                   Bairro + "\r\n" +
                   CEP + "\r\n" +
                   Complemento + "\r\n" +
                   Numero + "\r\n" +
                   Telefone + "\r\n" +
                   EstadoCivil + "\r\n" +
                   Genero + "\r\n";
        }
    }
}
