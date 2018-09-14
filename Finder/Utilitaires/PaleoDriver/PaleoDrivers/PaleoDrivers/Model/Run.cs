using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaleoDrivers.Model;

namespace PaleoDrivers.Model
{
    public class Run
    {
        public List<DrivenVehicle> _drivenvehicle;
        public DateTime _datehour;
        public List<string> _parcours;
        public string _artist;
        public int _passengers;
        public string _info;

        public Run(List<DrivenVehicle> DrivenVehicle, DateTime DateHour, List<string> Parcours, string Artist, int Passengers, string Info)
        {
            _drivenvehicle = DrivenVehicle;
            _datehour = DateHour;
            _parcours = Parcours;
            _artist = Artist;
            _passengers = Passengers;
            _info = Info;
        }

        public string getParcours()
        {
            {
                string parcours = "";
                foreach (string s in _parcours)
                {
                    parcours += s;
                    parcours += " => ";
                }
                parcours = parcours.Substring(0, parcours.Length - 4);
                return parcours;
            }
        }

        public string getDriverVehicles()
        {
            string drivervehicle = "";
            foreach (DrivenVehicle DV in _drivenvehicle)
            {
                drivervehicle += (DV._vehicle._name) + " => " + (DV._driver._nom) + " // ";
            }
            drivervehicle = drivervehicle.Substring(0, drivervehicle.Length - 4);
            return drivervehicle;
        }
    }
}
