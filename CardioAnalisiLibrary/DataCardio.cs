using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public static string Met_1_MaxMinAllEff(string Eta)
        {
            string Risposta = "";
            double MaxEff = 0;
            double Max = 0;
            double Min = 0;
            try
            {
                int eta = Convert.ToInt32(Eta);
                if (eta <= 0 || eta >= 150)
                {
                    Risposta = "ERRORE!!";
                }
                else
                {
                    MaxEff = 220 - eta;
                    Min = MaxEff * 0.7;
                    Max = MaxEff * 0.9;
                    Risposta = "Il valore massimo è " + Convert.ToString(Max) + " Il valore minimo è " + Convert.ToString(Min);
                }
            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }



        public static string Met_2_IntValFreCardRip(string CardRip)
        {
            string Risposta = "";
            int Battito = 0;
            try
            {
                Battito = Convert.ToInt32(CardRip);
                if (Battito <= 0)
                {
                    Risposta = "ERRORE!!";
                }
                else if (Battito < 60)
                {
                    Risposta = "Hai un battito Bradicardico";
                }
                else if (Battito >= 60 && Battito < 100)
                {
                    Risposta = "Hai un battito Normale";
                }
                else
                {
                    Risposta = "Hai un battito Tachicardico";
                }

            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }



        public static string Met_3_CalBruSesEs(string F, string P, string A, string T, string S)
        {
            string Risposta = "";
            double CalorieBruciate = 0;
            double Frequenza = 0;
            double Peso = 0;
            double Età = 0;
            double Tempo = 0;
            string Sesso = "";
            bool B = true;
            try
            {
                Frequenza = Convert.ToDouble(F);
                Peso = Convert.ToDouble(P);
                Età = Convert.ToDouble(A);
                Tempo = Convert.ToDouble(T);
                Sesso = Convert.ToString(S);
                if (Sesso != "M" && Sesso != "m" && Sesso != "F" && Sesso != "f")
                {
                    Risposta = "ERRORE!!";
                    B = false;
                }
                else if (B = true && Sesso == "M" || Sesso == "m")
                {
                    CalorieBruciate = ((Età * 0.2017) + (Peso * 0.199) + (Frequenza * 0.6309) - 55.0969) * Tempo / 4.184;
                    Risposta = "Le calorie bruciate durante la sessione di esercizi sono state " + CalorieBruciate;
                    B = false;
                }
                else if (B = true && Sesso == "F" || Sesso == "f")
                {
                    CalorieBruciate = ((Età * 0.074) - (Peso * 0.126) + (Frequenza * 0.4472) - 20.4022) * Tempo / 4.184;
                    Risposta = "Le calorie bruciate durante la sessione di esercizi sono state " + CalorieBruciate;
                    B = false;
                }
            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }



        public static string Met_4_CalcoSpesaEnergetica(string Pa, string Km, string Pe)
        {
            double KmPercorsi = 0;
            double Peso = 0;
            string Risposta = "";
            double SpesaEner = 0;
            try
            {
                KmPercorsi = Convert.ToDouble(Km);
                Peso = Convert.ToDouble(Pe);

                if (Pa == "CORSA" || Pa == "Corsa" || Pa == "corsa")
                {
                    SpesaEner = 0.9 * KmPercorsi * Peso;
                    Risposta = "La spesa energetica è di " + SpesaEner;
                }
                if (Pa == "CAMMINATA" || Pa == "Camminata" || Pa == "camminata")
                {
                    SpesaEner = 0.50 * KmPercorsi * Peso;
                    Risposta = "La spesa energetica è di " + SpesaEner;
                }
                if (Pa != "CAMMINATA" && Pa != "Camminata" && Pa != "camminata" && Pa != "CORSA" && Pa != "Corsa" && Pa != "corsa")
                {
                    Risposta = "ERRORE!!";
                }
            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }


        public static string Met_5_1_MedGiorBattCard(string[] NB)
        {
            string Risposta = "";
            double MedGiorn = 0;
            double[] B = new double[7];
            bool b = false;
            try
            {
                for (int i = 0; i < NB.Length; i++)
                {
                    if(Convert.ToDouble(NB[i])<=0)
                    {
                        Risposta = "ERRORE!!";
                        b = true;
                    }
                    else
                    {
                        B[i] = Convert.ToDouble(NB[i]);
                    }
                }
                if(b==false)
                {
                    MedGiorn = (B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6]) / 7;
                    Risposta = "La media di battiti cardiaci oggi è stata di " + MedGiorn;
                }
                
            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }
        public static string Met_5_2_BatCardRip(string[] NB)
        {
            string Risposta = "";
            double BattRip = 0;
            double[] B = new double[7];
            bool b = false;
            try
            {
                for (int i = 0; i < NB.Length; i++)
                {
                    if (Convert.ToDouble(NB[i]) <= 0)
                    {
                        Risposta = "ERRORE!!";
                        b = true;
                    }
                    else
                    {
                        B[i] = Convert.ToDouble(NB[i]);
                    }
                }
                if (b == false)
                {
                    BattRip = (((B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6]) * 4)/28);

                    Risposta = "Il battito cardiaco a riposo è " + BattRip;
                }

            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }


        public static string Met_5_3_VarBatCard(string Max,string Min)
        {
            string Risposta = "";
            double BatMax = 0;
            double BatMin = 0;
            double Variabilita = 0;
            bool b = true;
            try
            {
                BatMin = Convert.ToDouble(Min);
                BatMax = Convert.ToDouble(Max);
                if (BatMax <= 0 || BatMin <= 0)
                {
                    Risposta = "ERRORE!!";
                    b = false;
                }
                if (b == true)
                {
                    Variabilita = BatMax - BatMin;
                    Risposta = "La variabilità del battito cardiaco è " + Variabilita;
                }
            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }

        public static string Met_5_4_OrdCreBatt(string[] NB)
        {
            string Risposta = "";
            double[] B = new double[7];
            bool b = false;
            try
            {
                for (int i = 0; i < NB.Length; i++)
                {
                    if (Convert.ToDouble(NB[i]) <= 0)
                    {
                        Risposta = "ERRORE!!";
                        b = true;
                    }
                    else
                    {
                        B[i] = Convert.ToDouble(NB[i]);
                    }
                }
                if (b == false)
                {
                    Array.Sort(B);
                    Risposta =Convert.ToString(B[0]);
                    for (int i = 1; i < B.Length; i++)
                    {
                        Risposta = Risposta + "," + Convert.ToString(B[i]) ;
                    }
                }

            }
            catch
            {
                Risposta = "ERRORE!!";
            }
            return Risposta;
        }
    }
}
