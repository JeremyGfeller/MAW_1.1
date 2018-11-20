using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Finder.Class
{
    class OpenRep
    {
        public void openRep(string pathDirectory)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = pathDirectory,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }
    }
}