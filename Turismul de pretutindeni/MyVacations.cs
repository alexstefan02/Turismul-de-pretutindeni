using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Turismul_de_pretutindeni
{
    public partial class MyVacations : Form
    {
        List<List<string>> RezervariUser;

        public MyVacations()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            RezervariUser = dbManage.Query(String.Format("ShowUserReserve {0}", Resource.IdUser));
            Importer.LoadRezervari(); ///Da refresh si la toata tabela stocata in Resource
            int row = RezervariUser.Count;

            foreach(var entry in RezervariUser)
            {
                dataGridView1.Rows.Add(entry.ToArray());
            }

        }


        private void MyVacations_Load(object sender, EventArgs e)
        {

            LoadData();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && RezervariUser.Count>0)
            {
                string indexID = RezervariUser[e.RowIndex][5];
                try
                {
                    dbManage.nonQuery(String.Format("DELETE FROM Rezervari WHERE IdRezervare = {0}", indexID));
                    MessageBox.Show("Rezervare ștearsă cu succes!", "Rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Eroare necunoscuta!", "E R O A R E", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
