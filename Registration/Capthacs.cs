using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
     class Capthacs
    {
        
        static public string capt { get; set; } 
       public static string Capcha()
        {
            
            Random rnd = new Random();
            string rndCapth = "";
            string sim = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
            {
                rndCapth += sim[rnd.Next(sim.Length)];
            }
            capt = rndCapth;
            
            return rndCapth;

        }
        
        
    }
}
