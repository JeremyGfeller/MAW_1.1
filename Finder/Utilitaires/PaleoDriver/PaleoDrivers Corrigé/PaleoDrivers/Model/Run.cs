using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaleoDrivers.Model
{
    public class Run
    {
        private static int _lastIdRun;

        public int _idRun;
        public List<DrivenVehicle> _logistics;
        public DateTime _moment;
        public List<string> _path;
        public string _artist;
        public int _nbpax;
        public string _infos;

        public Run(List<DrivenVehicle> logistics, DateTime moment, List<string> path, string artist, int passagers, string infos)
        {
            _idRun = _lastIdRun++;
            _logistics = logistics;
            _moment = moment;
            _path = path;
            _artist = artist;
            _nbpax = passagers;
            _infos = infos;
        }

        public string GetPath()
        {
            return String.Join(Environment.NewLine, _path);
        }

        public string GetLogistics()
        {
            string res = "";
            foreach (DrivenVehicle d in _logistics) res += (d._vehicle._name + " / " + d._driver._lname + Environment.NewLine);
            res = res.Substring(0, res.Length - Environment.NewLine.Length);
            return res;
        }

    }

}
