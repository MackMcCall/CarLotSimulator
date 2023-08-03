using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            engineNoise = EngineNoise;
            Console.WriteLine($"A roaring {engineNoise} echoes from the {Year} {Make} {Model}.");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            honkNoise = HonkNoise;
            Console.WriteLine($"The {Year} {Make} {Model} honks with a {honkNoise}.");
        }

        public Car()
        {
            //default constructor
            //added incrementer to constructor
            CarLot.numberOfCars++;
        }
        
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) : this()
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public void GetCarDetails()
        {
            Console.WriteLine($"This is the {Year} {Make} {Model}.");
        }
    };
}


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

//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console