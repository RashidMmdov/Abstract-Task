using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTAsk
{
    abstract class Vehicle
    {
        public string Types;//car,track,bike,motobike...
        public string Shape;//Suv,sedan,LongSize,sport...
        public byte Wheel;

        public Vehicle(string types, string shape, byte wheel)
        {
            Types = types;
            Shape = shape;
            Wheel = wheel;
        }
        public abstract void FullInfo();

    }
}
