using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> AllCars { get; set; } = new List<Car>();

        public void AllDetails()
        {
            foreach (Car car in AllCars)
            {
                car.GetCarDetails();
            }
        }
    }
}
