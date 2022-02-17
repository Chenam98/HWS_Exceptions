using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Exceptions
{
    internal class Garage : IGarage
    {
        public Car[] Cars { get; set; }
        public string[] CarTypes { get; set; }

        public Garage(string[] CarTypes)
        {
            this.CarTypes = CarTypes;
        }

        public void AddCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars.Contains(car))
                    throw new CarAlreadyHereException();
                if (Cars[i].TotalLost == true)
                    throw new WeDoNotFixTotalLostException();
                if (car.Brand != Cars[i].Brand)
                    throw new WrongGarageException();
                if (Cars[i] == null)
                    throw new CarNullException();
                if (Cars[i].NeedRepair == false)
                    throw new CarNotReadyException();

                else
                    i++;

            }
        }

        public void FixCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (car == null)
                    throw new CarNullException();
                if (car.Brand != Cars[i].Brand)
                    throw new CarNotInGarageException();
                if (car.NeedRepair == false)
                    throw new RepairMismatchException();
                else
                    car.NeedRepair = false;
            }

        }

        public void TakeOutCar(Car car)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (car == null)
                    throw new CarNullException();
                if (car.Brand != Cars[i].Brand)
                    throw new CarNotInGarageException();
                if (car.NeedRepair == true)
                    throw new CarNotReadyException();
                else
                    i--;
            }
        }
    }
}
