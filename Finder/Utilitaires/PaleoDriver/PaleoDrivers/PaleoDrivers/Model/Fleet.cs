using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PaleoDrivers.Model
{
    class Fleet
    {
        List<Vehicle> _vehicles;

        public Fleet()
        {
            _vehicles = new List<Vehicle>()
             {   
                 /*new Vehicle("Mercedes","Vito",9,1),
                 new Vehicle("Mercedes","Vito",9,2),
                 new Vehicle("Peugeot","Cageot",9,3),
                 new Vehicle("Ferrari","Enzo",9,4),
                 new Vehicle("Renaut","C5",9,5),
                 new Vehicle("Audi","RS6",9,6),
                 new Vehicle("Mercedes","Vito",9,7),
                 new Vehicle("Mercedes","Vito",9,8),
                 new Vehicle("Mercedes","Vito",9,9),
                 new Vehicle("Mercedes","Vito",9,10),*/
             };             
        }


        public List<Vehicle> getlist()
        {
            return _vehicles;
        }
    }
}

