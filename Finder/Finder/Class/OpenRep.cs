using System.Diagnostics;

namespace Finder.Class
{
    class OpenRep
    {
        public void openRep(string pathDirectory, bool HasFile)
        {
            if(HasFile)
            {
                string cmd = "explorer.exe";
                string arg = "/select," + pathDirectory;
                Process.Start(cmd, arg);
            }
            else
            {
                string cmd = pathDirectory;
                string arg = "explorer.exe";
                Process.Start(cmd, arg);
            }
                
        }
    }
}