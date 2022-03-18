using System;

namespace AbstractionTAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Cadellac","Escalade","Black",2018,200000,"Suv","Long",4);
            Console.WriteLine("Car Information");
            car.FullInfo();
            Console.WriteLine("\n-------------------------------------------------------------\n");
            Buss buss = new Buss("Mercedess", "Vito", "White", 2013, 8, 65000, "MiniBus", "Short", 4);
            Console.WriteLine("Bus Information");
            buss.FullInfo();
            Console.WriteLine("\n-------------------------------------------------------------\n");
            MotoBike mb = new MotoBike("Yamaha","Black and Yellow",2019,25000,"Sport","Short",2);
            Console.WriteLine("MotoBike Information");
            mb.FullInfo();
        }
    }
}
