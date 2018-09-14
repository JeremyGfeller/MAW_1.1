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

        public string _name;
        public string _license;
        public string _model;
        public int _nbseats;
        public bool _ready;
        public bool _needgas;
        public char _type;
        public string _renter;
        public int _km;
        /*public string _brand;
        public string _model;
        public string _licensePlate;
        public int _nbSeats;
        public int _id;
        public int _fillPercentage;*/
        public Vehicle (string Name, string License, string Model, int NbSeats, bool Ready, bool NeedGas, char Type, string Renter, int Km /*string brand, string model, int seats, int id*/)
        {
            _name = Name;
            _license = License;
            _model = Model;
            _nbseats = NbSeats;
            _ready = Ready;
            _needgas = NeedGas;
            _type = Type;
            _renter = Renter;
            _km = Km;
            /*_brand = brand;
            _model = model;
            _nbSeats = seats;
            _licensePlate = "?";
            _id = id;
            _fillPercentage = -1;*/
        }

        /*public bool isEmpty()
        {
            return (_fillPercentage < EmptyThreshold);
        }
        public string description()
        {
            return _id.ToString() + " " + _brand + " " + _model;
        }*/

    }
}
