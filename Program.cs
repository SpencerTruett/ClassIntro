using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            // Option 1 for building out a car (commented out due to constructor)
            // Constructor added now to build out the entire car
            Car myFordBronco = new Car(10000, "Ford", "Bronco", 1982);
            // myFordBronco.Make = "Ford";
            // myFordBronco.Model = "Bronco";
            // myFordBronco.Year = 1982;

            // Option 2 for building out a car
            // Constructor only used for milage
            Car mySubaru = new Car(10000)
            {
                Make = "Subaru",
                Model = "Forrester",
                Year = 1999
            };
            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(60);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service();
        }
    }
}