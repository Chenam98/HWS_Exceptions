using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Cararray = { "suzuki", "shevrolet", "ferarri" };
            Car car1 = new Car("ferarri", false, true);
            Car car2 = new Car("suzuki", true, false);
            Car car3 = new Car("shevrolet", false, false);

            Garage garage = new Garage(Cararray);
            garage.AddCar(car1);

            garage.AddCar(car2);

            garage.FixCar(car1);

            garage.TakeOutCar(car1);
        }
    }
}
