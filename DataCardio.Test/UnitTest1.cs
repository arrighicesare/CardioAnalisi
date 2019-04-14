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
        public void TestMethod3()
        {
            string Eta = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string Eta = "35";
            string Atteso ="Il valore massimo è 166,5 Il valore minimo è 129,5";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_1_MaxMinAllEff(Eta);
            Assert.AreEqual(Atteso, Ottenuto);
        }


        [TestMethod]
        public void TestMethod5()
        {
            string CardRip = "0";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_2_IntValFreCardRip(CardRip);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string CardRip = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_2_IntValFreCardRip(CardRip);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string CardRip = "35";
            string Atteso = "Hai un battito Bradicardico";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_2_IntValFreCardRip(CardRip);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string CardRip = "75";
            string Atteso = "Hai un battito Normale";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_2_IntValFreCardRip(CardRip);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string CardRip = "115";
            string Atteso = "Hai un battito Tachicardico";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_2_IntValFreCardRip(CardRip);
            Assert.AreEqual(Atteso, Ottenuto);
        }


        [TestMethod]
        public void TestMethod10()
        {
            string F="err";
            string P="err";
            string A="err";
            string T="err";
            string Sesso="err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_3_CalBruSesEs( F,  P,  A,  T,  Sesso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string F = "162";
            string P = "70";
            string A = "35";
            string T = "60";
            string Sesso = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_3_CalBruSesEs(F, P, A, T, Sesso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string F = "err";
            string P = "err";
            string A = "err";
            string T = "err";
            string Sesso = "F";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_3_CalBruSesEs(F, P, A, T, Sesso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string F = "162";
            string P = "70";
            string A = "35";
            string T = "60";
            string Sesso = "M";
            string Atteso = "Le calorie bruciate durante questa sessione di esercizi è 976.5544933078393881453154875717017208413";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_3_CalBruSesEs(F, P, A, T, Sesso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
    }
}
