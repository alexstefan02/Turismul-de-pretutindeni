using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Turismul_de_pretutindeni
{
    static class dbManage
    {
        private static SqlConnection connManager = null;

        private static void GetConnection()
        {
            connManager = new SqlConnection(Properties.Settings.Default.connS);
        }

        private static void OpenIfNotOpen()
        {
            if (connManager == null)
                GetConnection();

            if (connManager.State != ConnectionState.Open)
                connManager.Open();
        }

        public static void nonQuery(string instruct)
        {
            OpenIfNotOpen();

            using (SqlCommand cmd = new SqlCommand(instruct, connManager))
            {
                cmd.ExecuteNonQuery();
            }
            connManager.Close();
        }

        public static List<List<string>> Query(string instruct)
        {
            List<List<string>> returnList = new List<List<string>>();

            OpenIfNotOpen();
            SqlCommand cmd = new SqlCommand(instruct, connManager);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                int row = 0;

                while (reader.Read())
                {
                    returnList.Add(new List<string>());

                    for (int i = 0; i < reader.FieldCount; i++)
                        returnList[row].Add(reader[i].ToString());

                    row++;
                }

                reader.Close();
            }

            cmd.Dispose();
            return returnList;
        }

        public static string singleQuery(string instruct)
        {
            OpenIfNotOpen();
            SqlCommand cmd = new SqlCommand(instruct, connManager);

            string returnValue = cmd.ExecuteScalar().ToString();

            return returnValue;
        }

    }
}
