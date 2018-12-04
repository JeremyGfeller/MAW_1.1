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