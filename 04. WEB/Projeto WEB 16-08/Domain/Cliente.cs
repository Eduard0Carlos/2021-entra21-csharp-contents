using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public int? ClienteID { get; set; } // permite que todas as structs recebam null
        public Cliente Dependente { get; set; }

        public int Idade
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - this.DataNascimento.Year;

                if (this.DataNascimento.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public ICollection<Locacao> Locacao { get; set; }


    }
}
