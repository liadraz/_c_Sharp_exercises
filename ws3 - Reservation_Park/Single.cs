using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws3___Reservation_Park
{
    public class Single : Traveler
    {
        public Single(string firstName, string lasName) : base(firstName, lasName) { }

        public override void Behavior()
        {
            Console.WriteLine($"{FirstName} {LastName} reacts to storm intensity {Storm.Intensity}");
        }
    }
}
