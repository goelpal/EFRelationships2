using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationships2
{
    internal class Bus
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int NumberOfSeats { get; set; }
        public List<Passenger> PassengersList { get; set; }//A bus can have many passengers so we created a
                                                       //list but this list is not going to affect the table
    }
}
