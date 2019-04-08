using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Eta = "0";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_ContInsDat(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string Eta = "150";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_ContInsDat(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
    }
}
