using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            

            var car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.Year = 2020;
            car1.EngineNoise = false;
            car1.HonkNoise = true;
            car1.IsDrivable = true;

            carLot.CarList.Add(car1);

            var car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Accord";
            car2.Year = 2005;
            car2.EngineNoise = true;
            car2.HonkNoise = true;
            car2.IsDrivable = false;

            carLot.CarList.Add(car2);

            var car3 = new Car();
            car3.Make = "Ford";
            car3.Model = "Edge";
            car3.Year = 2021;
            car3.EngineNoise = false;
            car3.HonkNoise = true;
            car3.IsDrivable = true;

            carLot.CarList.Add(car3);

            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            foreach (var car in carLot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} - Car Drives: {car.IsDrivable}; Engine Makes Noise: {car.MakeEngineNoise(true)}; Horn Works: {car.MakeHonkNoise(true)}");
                Console.WriteLine();
            }




            //TODO

            //---Create a seperate class file called Car
            //---Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //---Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //---The methods should take one string parameter: the respective noise property


            //---Now that the Car class is created we can instanciate 3 new cars
            //---Set the properties for each of the cars
            //---Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //---Create a CarLot class
            //---It should have at least one property: a List of cars
            //---Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //---At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
