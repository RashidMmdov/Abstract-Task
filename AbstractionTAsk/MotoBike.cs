using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTAsk
{
    internal class MotoBike : Vehicle
    {
        public string Model;
        public string Color;
        public int Year;
        public int Price;

        public MotoBike(string model, string color, int year, int price, string types, string shape, byte wheel) : base(types, shape, wheel)
        {
            Model = model;
            Color = color;
            Year = year;
            Price = price;
        }
        public override void FullInfo()
        {
            Console.WriteLine($"MotoBike model: {Model} |  | MotoBike color: {Color} | MotoBike year: {Year}\n" +
                $"MotoBike price:{Price}$ | MotoBike type: {Types} | MotoBike shape: {Shape} | MotoBike wheel count: {Wheel}");
        }
    }
}
