using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Film : EntityBase
    {
        public string Name { get; protected set; }
        public int Duration { get; protected set; }
        public int ReleaseYear { get; protected set; }
        public int GenderID { get; protected set; }
        public Gender Gender { get; protected set; }
        public ParentalRating ParentalRating { get; protected set; }
        public ICollection<Location> Locations { get; protected set; }

        public Film() { }

        public Film(string name, int duration, int releaseYear, int genderID, ParentalRating parentalRating)
        {
            this.Name = name;
            this.Duration = duration;
            this.ReleaseYear = releaseYear;
            this.GenderID = genderID;
            this.ParentalRating = parentalRating;
        }
        
        public double GetPrice()
        {
            var year = DateTime.Now.Year;
            var timeDifference = year - this.ReleaseYear;

            if (timeDifference == 0)
                return 10;
            else if (timeDifference < 3)
                return 8;
            else if (timeDifference < 5)
                return 6;
            else
                return 5;
        }
    }
}
