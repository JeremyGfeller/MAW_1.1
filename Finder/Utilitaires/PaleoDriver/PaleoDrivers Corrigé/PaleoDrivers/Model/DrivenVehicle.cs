using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaleoDrivers.Model
{
    /// <summary>
    /// This class binds a vehicle to a driver
    /// </summary>
    public class DrivenVehicle
    {
        public Vehicle _vehicle;
        public Driver _driver;

        public DrivenVehicle(Driver driver, Vehicle vehicle)
        {
            _driver = driver;
            _vehicle = vehicle;
        }
    }

}
