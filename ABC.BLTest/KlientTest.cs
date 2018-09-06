using System;
using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (zaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            // Arrange (zaranżuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste() 
        {
            // Arrange (zaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
