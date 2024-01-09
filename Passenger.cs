using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationships2
{
    internal class Passenger
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BusId {  get; set; } //foreign Key

        public Bus Bus { get; set; }//referencing Bus object that the passenger belongs
    }
}
