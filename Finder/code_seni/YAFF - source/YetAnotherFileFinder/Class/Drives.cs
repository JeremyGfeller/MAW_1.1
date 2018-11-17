using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

/// <summary>
/// Drive Class. 
/// In this class, we gonna load all our drives on our computer and show it with an another method.
/// </summary>

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */

namespace YetAnotherFileFinder.Class
{
    class Drives
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private YetAnotherFileFinder yaffDrive;

        public void LoadDrive(YetAnotherFileFinder yaffParentForm){
           
        }

        //Goes into the selected repository
        public void LoadFolderInExplorer(string selectedPath){
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = selectedPath,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }


        public void LoadFoldersFromSelectedDrive(string selectedDrive)
        {
            
        }
    }
}
