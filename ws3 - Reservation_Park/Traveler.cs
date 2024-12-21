using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws3___Reservation_Park
{
    public abstract class Traveler
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Traveler(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void Behavior();
    }
}
