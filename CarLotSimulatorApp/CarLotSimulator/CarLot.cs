using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarsInLot { get; set; } = new List<Car>();

        public static int numberOfCars = 0;

        public void UpdateCarAmount()
        {
            numberOfCars = CarsInLot.Count;
        }

        public void AllDetails()
        {
            foreach (Car car in CarsInLot)
            {
                car.GetCarDetails();
            }
        }
    }
}
