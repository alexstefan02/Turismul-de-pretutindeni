using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_de_pretutindeni
{
    static class Resource
    {
        public static int IdUser;
        public static string loggedEmail = null;
        public static int tipCont;
        public static string[] captchaFiles;
        public static string[] photoFiles;
        public static List<List<string>> InfoVacante;
        public static List<List<string>> InfoRezervari;

        public static bool prepareExit = false;


        public static void updateEmail(string email, int tip, int id)
        {
            loggedEmail = email;
            tipCont = tip;
            IdUser = id;
        }

        public static void UserReset()
        {
            IdUser = -1;
            loggedEmail = null;
            tipCont = -1;
        }
    }
}
