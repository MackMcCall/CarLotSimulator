using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new CarLot();
            
            Car myCar = new Car();
            myCar.Year = 2014;
            myCar.Make = "Nisan";
            myCar.Model = "Altima";
            myCar.EngineNoise = "brrrrrrr";
            myCar.HonkNoise = "eerr-eer";
            myCar.IsDriveable = true;

            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            parkingLot.AllCars.Add(myCar);


            Car wifesCar = new Car() 
            { 
                Year = 2018, 
                Make = "Subaru", 
                Model = "Crosstrek", 
                EngineNoise = "hrmmmmm", 
                HonkNoise = "neet-neet", 
                IsDriveable = true
            };
            wifesCar.MakeEngineNoise(wifesCar.EngineNoise);
            wifesCar.MakeHonkNoise(wifesCar.HonkNoise);
            parkingLot.AllCars.Add(wifesCar);


            Car neighborCar = new Car(2012, "Ford", "Explorer", "ggrrr", "ernk-ernk", true);
            neighborCar.MakeEngineNoise(neighborCar.EngineNoise);
            neighborCar.MakeHonkNoise(neighborCar.HonkNoise);
            parkingLot.AllCars.Add(neighborCar);

            Console.WriteLine("");
            Console.WriteLine($"These are all the cars in the lot:");
            parkingLot.AllDetails();
        }
    }
}


//TODO

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
