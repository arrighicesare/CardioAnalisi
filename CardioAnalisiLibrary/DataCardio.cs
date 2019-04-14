using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public static string Met_1_MaxMinAllEff (string Eta)
        {
            string Risposta = "";
            double MaxEff = 0;
            double Max = 0;
            double Min = 0;
            try
            {
                int eta = Convert.ToInt32(Eta);
                if(eta<=0||eta>=150)
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
                if (Battito <= 0 )
                {
                    Risposta = "ERRORE!!";
                }
                else if (Battito<60)
                {
                    Risposta = "Hai un battito Bradicardico";
                }
                else if(Battito>=60&&Battito<100)
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
        public static string Met_3_CalBruSesEs(string F, string P, string A, string T, string Sesso)
        {
            string Risposta = "";
            double CalorieBruciate = 0;
            double Frequenza = 0;
            double Peso = 0;
            double Età = 0;
            double Tempo = 0;

            try
            {
                Frequenza = Convert.ToDouble(F);
                Peso = Convert.ToDouble(P);
                Età = Convert.ToDouble(A);
                Tempo = Convert.ToDouble(T);
                if (Sesso != "M" || Sesso != "m" && Sesso != "F" || Sesso != "f")
                {
                    Risposta = "ERRORE!!";
                }
                else if (Sesso == "M" || Sesso == "m")
                {
                    CalorieBruciate = ((Età * 0.2017) + (Peso * 0.199) + (Frequenza * 0.6309) - 55.0969) * Tempo / 4.184;
                    Risposta = "Le calorie bruciate durante questa sessione di esercizi è " + CalorieBruciate;
                }
                else
                {
                    CalorieBruciate = ((Età * 0.074) - (Peso * 0.126) + (Frequenza * 0.4472) - 20.4022) * Tempo / 4.184;
                    Risposta = "Le calorie bruciate durante questa sessione di esercizi è " + CalorieBruciate;
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

