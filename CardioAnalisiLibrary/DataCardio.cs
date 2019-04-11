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
    }
}
