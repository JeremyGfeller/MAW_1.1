using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaleoDriversTest
{
    [TestClass]
    public class FleetTest
    {
        private string[] errorMessages = { "Fichier introuvable", 
                                           "Trop de champs dans la ligne", 
                                           "Trop peu de champs dans la ligne",
                                           "Ligne trop courte",
                                           "Nombre de sièges invalide",
                                           "Nombre de sièges incorrect",
                                           "Valeur incorrecte pour KM"
                                         };

        [TestMethod]
        public void TestFichier01() // Test du fichier fleet01.txt
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            // Test de chargement des données
            f.LoadFile("Fleet01.txt");
            if (!f.isOK())
            {
                Assert.Fail();
            }
            // test de détail
            if (f._fleet.Count != 15)
            {
                Assert.Fail();
            }
            // Véhicules OK
            int nbvok = 0;
            foreach(PaleoDrivers.Model.Vehicle v in f._fleet)
            {
                if (v._ready) nbvok++;
            }
            Assert.IsTrue(nbvok == 13);
        }

        [TestMethod]
        public void TestFichier02() // Test du fichier fleet02.txt
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            f.LoadFile("Fleet02.txt");
            if (f.isOK()) Assert.Fail();

            Assert.IsTrue(f.errorMsg.Contains(errorMessages[6])); // Message: "Trop de km"
        }

        [TestMethod]
        public void TestFichier03() // Test du fichier fleet03.txt
        {
            PaleoDrivers.FFleet f = new PaleoDrivers.FFleet();
            f.LoadFile("Fleet03.txt");
            if (f.isOK()) Assert.Fail();

            Assert.IsTrue(f.errorMsg.Contains(errorMessages[2])); // Message: "Trop peu de champs"
        }
    }
}
