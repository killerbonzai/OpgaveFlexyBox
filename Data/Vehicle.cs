using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; set; }
        public int MaxPassengers { get; private set; }

        public Vehicle(int maxSpeed, int maxPassengers)
        {
            MaxSpeed = maxSpeed;
            MaxPassengers = maxPassengers;
        }
    }
}
