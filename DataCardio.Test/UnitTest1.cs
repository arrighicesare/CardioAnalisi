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
            string F = "0";
            string P = "0";
            string A = "0";
            string T = "0";
            string S = "m";
            string Atteso = "Le calorie bruciate durante la sessione di esercizi sono state 0";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_3_CalBruSesEs(F, P, A, T, S);
            Assert.AreEqual(Atteso, Ottenuto);
        }


        [TestMethod]
        public void TestMethod14()
        {
            string KmPercorsi = "err";
            string Peso = "err";
            string Passo = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_4_CalcoSpesaEnergetica(Passo,KmPercorsi,Peso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string KmPercorsi = "10";
            string Peso = "70";
            string Passo = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_4_CalcoSpesaEnergetica(Passo, KmPercorsi, Peso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod16()
        {
            string KmPercorsi = "10";
            string Peso = "10";
            string Passo = "Camminata";
            string Atteso = "La spesa energetica è di 50";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_4_CalcoSpesaEnergetica(Passo, KmPercorsi, Peso);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod18()
        {
            string[] NB = new string[] { "err", "err", "err", "err", "err", "err", "err" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_1_MedGiorBattCard(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod19()
        {
            string[] NB = new string[] { "0", "0", "0", "0", "0", "0", "0" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_1_MedGiorBattCard(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod20()
        {
            string[] NB = new string[] { "36", "36", "36", "36", "36", "36", "36" };
            string Atteso = "La media di battiti cardiaci oggi è stata di 36";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_1_MedGiorBattCard(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod21()
        {
            string[] NB = new string[] { "36", "36", "36", "36", "36", "36", "36" };
            string Atteso = "Il battito cardiaco a riposo è 36";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_2_BatCardRip(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod22()
        {
            string[] NB = new string[] { "0", "0", "0", "0", "0", "0", "0" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_2_BatCardRip(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod23()
        {
            string[] NB = new string[] { "err", "err", "err", "err", "err", "err", "err" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_2_BatCardRip(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod24()
        {
            string Max = "err";
            string Min = "err";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_3_VarBatCard(Max,Min);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod25()
        {
            string Max = "0";
            string Min = "0";
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_3_VarBatCard(Max, Min);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod26()
        {
            string Max = "30";
            string Min = "15";
            string Atteso = "La variabilità del battito cardiaco è 15";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_3_VarBatCard(Max, Min);
            Assert.AreEqual(Atteso, Ottenuto);
        }

        [TestMethod]
        public void TestMethod27()
        {
            string[] NB = new string[] { "0", "0", "0", "0", "0", "0", "0" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_4_OrdCreBatt(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod28()
        {
            string[] NB = new string[] { "err", "err", "err", "err", "err", "err", "err" };
            string Atteso = "ERRORE!!";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_4_OrdCreBatt(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
        [TestMethod]
        public void TestMethod29()
        {
            string[] NB = new string[] { "31", "33", "35", "32", "36", "34", "37" };
            string Atteso = "31,32,33,34,35,36,37";
            string Ottenuto = CardioAnalisiLibrary.DataCardio.Met_5_4_OrdCreBatt(NB);
            Assert.AreEqual(Atteso, Ottenuto);
        }
    }
}
