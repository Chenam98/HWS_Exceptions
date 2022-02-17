using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Exceptions
{
    internal class Car
    {
        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedRepair { get; set; }

        public Car(string brand, bool totalLost, bool needRepair)
        {
            this.Brand = brand;
            this.TotalLost = totalLost;
            this.NeedRepair = needRepair;

            if (totalLost && needRepair)
                throw new RepairMismatchException();
        }

    }
}
