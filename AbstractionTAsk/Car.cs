using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionTAsk
{
    internal class Car : Vehicle
    {
        public string Model;
        public string Series;
        public string Color;
        public int Year;
        public int Price;

        public Car(string model, string series, string color, int year, int price, string types, string shape, byte wheel) : base(types, shape, wheel)
        {
            Model = model;
            Series = series;
            Color = color;
            Year = year;
            Price = price;
        }
        public override void FullInfo()
        {
            Console.WriteLine($"Car model: {Model} | Car series: {Series} | Car color: {Color} | Car year: {Year}\n" +
                $"Car price:{Price}$ | Car type: {Types} | Car shape: {Shape} | Car wheel count: {Wheel}");
        }

    }
}
