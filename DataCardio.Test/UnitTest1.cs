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
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string Eta = "150";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string Eta = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string Eta = "35";
            string Atteso ="Il valore massimo è 166,5 Il valore minimo è 129,5";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
