using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaleoDrivers.Model
{
    public class Vehicle
    {
        const int EmptyThreshold = 15;

        public int _id;
        public string _name;
        public string _licensePlate;
        public string _model;
        public int _nbSeats;
        public bool _ready;
        public bool _needgas;
        public char _type;
        public string _renter;
        public int _km;

        public Vehicle (int id, string name, string license, string model, int seats, bool ready, bool needgas, char type, string renter, int km)
        {
            _id = id;
            _name = name;
            _licensePlate=license;
            _model = model;
            _nbSeats = seats;
            _ready = ready;
            _needgas = needgas;
            _type = type;
            _renter = renter;
            _km = km;
        }

        public string description()
        {
            return _id.ToString() + ", " + _model+ ", "+_nbSeats+" places";
        }
    }
}
