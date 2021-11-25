using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Turismul_de_pretutindeni
{
    static class Importer
    {
        static string dbInfoPath = Application.StartupPath + "\\Resurse\\Vacante.txt";
        static string photoPath = Application.StartupPath + "\\Resurse\\Imagini\\";
        static string captchaPath = Application.StartupPath + "\\Resurse\\Logare\\";

        public static void Start()
        {
            Extract();
            Resource.InfoVacante = dbManage.Query("ShowAllVacante");
            LoadRezervari();
        }

        public static void LoadRezervari()
        {
            Resource.InfoRezervari = dbManage.Query("SELECT * FROM Rezervari");
        }


        private static string FindFile(string name)
        {
            string fileName = "implicit.jpg";

            foreach(var entry in Resource.photoFiles)
            {
                if (Path.GetFileNameWithoutExtension(entry) == name)
                {
                    fileName = Path.GetFileName(entry);
                    break;
                }
            }

            return photoPath + fileName;
        }
       
        private static void Extract()
        {
            Resource.photoFiles = Directory.GetFiles(photoPath, "*");
            Resource.captchaFiles = Directory.GetFiles(captchaPath, "*");
            

            using(StreamReader fin = new StreamReader(dbInfoPath))
            {
                string[] entries;
                string line;

                while((line = fin.ReadLine()) != null)
                {
                    entries = line.Split('|');

                    string photoFile = FindFile(entries[0]);

                    entries[1] = entries[1].Replace('\'','\"');

                    dbManage.nonQuery(

                        String.Format("InsertVacanta '{0}','{1}',{2},{3},'{4}'",entries[0],entries[1],entries[2],entries[3],photoFile)

                        );
                    
                }
            }
        }

        public static void ReloadData()
        {
            dbManage.nonQuery("DELETE FROM Vacante");
            dbManage.nonQuery("DELETE FROM Rezervari");

            MessageBox.Show("Date modificate! Reincarcare...");
            Start();
        }

    }
}
