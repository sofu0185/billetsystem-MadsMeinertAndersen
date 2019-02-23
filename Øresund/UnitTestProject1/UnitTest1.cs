using System;
using BilletLibary2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using �resund;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void �resundBilPriserMedBrobizz()
        {
            //Arrange
            Bil testBil = new Bil("testBil", new DateTime(2019, 2, 23));

            //Act
            testBil.Brobizz = true;
            �resundPriser priser = new �resundPriser();
            double pris = priser.Priser(testBil);

            //Assert
            Assert.AreEqual(161, pris);
        }
        [TestMethod]
        public void �resundBilPriserUdenBrobizz()
        {
            //Arrange
            Bil testBil = new Bil("testBil", new DateTime(2019, 2, 23));

            //Act
            �resundPriser priser = new �resundPriser();
            double pris = priser.Priser(testBil);

            //Assert
            Assert.AreEqual(410, pris);
        }


        [TestMethod]
        public void �resundMCPriserUdenBrobizz()
        {
            //Arrange
            MC testMC = new MC("testBil", new DateTime(2019, 2, 23));

            //Act
            �resundPriser priser = new �resundPriser();
            double pris = priser.Priser(testMC);

            //Assert
            Assert.AreEqual(210, pris);
        }
        [TestMethod]
        public void �resundMCPriserMedBrobizz()
        {
            //Arrange
            MC testMC = new MC("testBil", new DateTime(2019, 2, 23));

            //Act
            testMC.Brobizz = true;
            �resundPriser priser = new �resundPriser();
            double pris = priser.Priser(testMC);

            //Assert
            Assert.AreEqual(73, pris);
        }
    }
}
