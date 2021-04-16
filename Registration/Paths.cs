using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    static class Paths
    {
        
   
        private static string pathUsers = "";
        private static string idGAme = "";
        public static string IdGame
        {

            get { return idGAme; }
            set { idGAme = value; }
        }


        public static string PathUsers
        {

            get { return pathUsers; }
            set { pathUsers = value; }
        }
        private static string pathsignup = "";
        public static string Pathsignup
        {

            get { return pathsignup; }
            set { pathsignup = value; }
        }

    }
}
