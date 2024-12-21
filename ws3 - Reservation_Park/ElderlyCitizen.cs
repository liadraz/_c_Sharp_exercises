using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws3___Reservation_Park
{
    public class ElderlyCitizen : Traveler
    {
        public ElderlyCitizen(string firstName, string lastName) : base(firstName, lastName) { }

        public override void Behavior()
        {
            Console.WriteLine($"{FirstName} {LastName} reacts to storm intensity {Storm.Intensity}");
        }
    }
}
