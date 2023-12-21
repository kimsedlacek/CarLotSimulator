using System;

namespace CarLotSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            // Dot Notation Syntax

            Console.WriteLine($"There are {CarLot._numberOfCars} cars right now.");
            var theFirstCar = new Car();

            theFirstCar.Year = 2010;
            theFirstCar.Make = "Ford";
            theFirstCar.Model = "Explorer";
            theFirstCar.EngineNoise = "as expected";
            theFirstCar.HonkNoise = "as expected";
            theFirstCar.IsDriveable = true;

            Console.WriteLine($"Now there is {CarLot._numberOfCars} car.");
            carLot.ParkingLot.Add(theFirstCar);
            

            // Object Initializer Syntax
            var theSecondCar = new Car()
            {
                Year = 2014,
                Make = "Mini",
                Model = "Cooper S",
                EngineNoise = "sporty",
                HonkNoise = "cute & sporty",
                IsDriveable = true

            };

            Console.WriteLine($"Now there are {CarLot._numberOfCars} cars.");
            carLot.ParkingLot.Add(theSecondCar);
            
            
            // Custom Constructor Syntax
            var theThirdCar = new Car(2015, "Dodge", "Ram 1500", "tough, like a truck", "loud", true);

            Console.WriteLine($"Now there are {CarLot._numberOfCars} cars.\n");
            carLot.ParkingLot.Add(theThirdCar);
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.CheckCars();
        }
    }
}
