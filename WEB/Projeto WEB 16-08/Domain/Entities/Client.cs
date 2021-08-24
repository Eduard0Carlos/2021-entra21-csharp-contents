using System;

namespace Domain.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF {  get; set; }
        public string RG { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
