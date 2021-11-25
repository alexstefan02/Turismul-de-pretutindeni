using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismul_de_pretutindeni
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInput(int option)
        {
            if(option == 1) ///logat cu succes
            {
                if (rememberEmail.Checked == false)
                    inputEmail.Clear();
                inputPass.Clear();
            }
            else
            {
                inputEmail.Clear();
                inputPass.Clear();
            }
        }

        private void searchDB(string email, string password)
        {
            List<List<string>> query = dbManage.Query(

                    String.Format("CheckUser '{0}','{1}'",email,password)
                );


            if(query.Count == 1)
            {

                ClearInput(1);

                Resource.updateEmail(email, int.Parse(query[0][5]), int.Parse(query[0][0]));



                this.Hide();
                new FrmVacanta().ShowDialog();

                if (Resource.prepareExit == true)
                    Application.Exit();
                else
                    this.Show();

                
            }
            else
            {
                MessageBox.Show("Eroare de autentificare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ClearInput(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchDB(inputEmail.Text, inputPass.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearInput(0);


            this.Hide();
            new FrmInregistrare().ShowDialog();

            if (Resource.prepareExit == true)
                Application.Exit();
            else
                this.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ati ales să folosiți mediul de debug. \n\n Veți fi logat cu contul de administrator implicit\n Aplicația se va comporta ca și cum v-ați logat pentru a salva timp la testare. \n\n Aceasta caracteristica este pur pentru test si va fi dezactivata in release mode.","Atentie!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            List<List<string>> query = dbManage.Query(

        String.Format("CheckUser '{0}','{1}'", "admin@oti.ro", "oti2017")
    );
            ClearInput(1);

            Resource.updateEmail("admin@oti.ro", int.Parse(query[0][5]),int.Parse(query[0][0]));

            this.Hide();
            new FrmVacanta().ShowDialog();

            if(Resource.prepareExit == true)
                Application.Exit();
            else
                 this.Show();
        }
    }
}
