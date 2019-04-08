using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public static string Met_ContInsDat(string Eta)
        {
            string msg = "";
            try
            {
                int eta = Convert.ToInt32(Eta);
                if(eta<=0||eta>=150)
                {
                    msg = "ERRORE!!";
                }
            }
            catch
            {
                msg = "ERRORE!!";
            }
            return msg;
        }
    }
}
