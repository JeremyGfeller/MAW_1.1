using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaleoDriversTest
{
    [TestClass]
    public class FleetTest
    {
        [TestMethod]
        public void SansFichier() // Test sans fichier
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            f.LoadFleet("Void.txt");
            Assert.IsFalse(f.isOK());
        }
        [TestMethod]
        public void TestFichier01() // Test du fichier fleet01.txt
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            f.LoadFleet("Fleet01.txt");
            if (!f.isOK())
            {
                Assert.Fail();
            }
            // test de détail
            Assert.IsTrue(f._fleet.Count == 15);
        }

        [TestMethod]
        public void TestFichier02() // Test du fichier fleet02.txt
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            f.LoadFleet("Fleet02.txt");
            Assert.IsFalse(f.isOK());
        }
    }
}
