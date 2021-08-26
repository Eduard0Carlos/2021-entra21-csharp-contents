using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Location : EntityBase
    {
        public double Value { get; protected set; }
        public DateTime LocationDate { get; protected set; }
        public DateTime ReturnDeadline { get; protected set; }
        public DateTime? ReturnDate { get; protected set; }
        public double Fine { get; protected set; }
        public int ClientID { get; protected set; }
        public Client Client { get; protected set; }
        public ICollection<Film> Films { get; protected set; }

        public Location() { }

        public Location(double value, DateTime locationDate, DateTime returnDeadline, double fine, int clientID)
        {
            this.Value = value;
            this.LocationDate = locationDate;
            this.ReturnDeadline = returnDeadline;
            this.Fine = fine;
            this.ClientID = clientID;
        }

        public Location SetReturnDate(DateTime returnDate)
        {
            this.ReturnDate = returnDate;
            return this;
        }
    }
}
