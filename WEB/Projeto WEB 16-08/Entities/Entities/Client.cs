using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; protected set; }
        public string CPF { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public DateTime CreatedTime { get; protected set; }
        public bool Ativo { get; protected set; }
        public int? ClientID { get; set; }
        public Client Dependent { get; set; }

        public ICollection<Location> Locations { get; protected set; }

        public Client() { }

        public Client(string name, string cpf, string email, string phoneNumber, DateTime birthDate)
        {
            this.Name = name;
            this.CPF = cpf;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - this.BirthDate.Year;

            if (this.BirthDate.Date > today.AddYears(-age)) age--;

            return age;
        }

        public Client SetCreatedTime()
        {
            this.CreatedTime = DateTime.Now;
            return this;
        }
    }
}
