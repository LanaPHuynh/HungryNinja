using System;

namespace HungryHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet AYCE = new Buffet();
            Ninja B = new Ninja();
            // Console.WriteLine(Bob.CalorieIntake);
            // Console.WriteLine(AYCE.Serve().PrintInfo());
            // Console.WriteLine(AYCE.Serve().PrintInfo());
            // Console.WriteLine(AYCE.Serve().PrintInfo());
            // Console.WriteLine(AYCE.Serve().PrintInfo());
            // Console.WriteLine(Bob.FoodHistory[0].PrintInfo());
            Console.WriteLine(B.currentCal);
            Console.WriteLine(B.isFull);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.isFull);
            Console.WriteLine(B.currentCal);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.isFull);
            Console.WriteLine(B.currentCal);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.isFull);
            Console.WriteLine(B.currentCal);
            Console.WriteLine(B.isFull);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.currentCal);
            Console.WriteLine(B.isFull);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.isFull);
            Console.WriteLine(B.currentCal);
            B.Eat(AYCE.Serve());
            Console.WriteLine(B.isFull);
            Console.WriteLine(B.currentCal);
        }
    }
}
