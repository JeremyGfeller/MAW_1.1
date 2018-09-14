using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaleoDrivers.Model
{
    public class Driver
    {
        public string _fname;
        public string _lname;
        public string _address;
        public int _license;
        public bool _ready;

        public Driver(string fname, string lname, string address, int license, bool ready)
        {
            _fname = fname;
            _lname = lname;
            _address = address;
            _license = license;
            _ready = ready;
        }
    }
}
