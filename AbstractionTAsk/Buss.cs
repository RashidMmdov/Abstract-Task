using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTAsk
{
    internal class Buss : Vehicle
    {
        public string Model;
        public string Color;
        public string Series;
        public int Year;
        public byte PassengerCount;
        public int Price;

        public Buss(string model, string series, string color, int year, byte pcount, int price, string types, string shape, byte wheel) : base(types, shape, wheel)
        {
            Model = model;
            Series = series;
            Color = color;
            Year = year;
            PassengerCount = pcount;
            Price = price;
        }
        public override void FullInfo()
        {
            Console.WriteLine($"Bus model: {Model} | Bus series: {Series} | Bus color: {Color} | Bus year: {Year}\n" +
                $"Bus price:{Price}$ | Bus passenger count:{PassengerCount} | Bus type: {Types} | Bus shape: {Shape} | Bus wheel count: {Wheel}");
        }
    }
}
