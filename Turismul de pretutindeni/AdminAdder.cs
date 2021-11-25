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
    public partial class AdminAdder : Form
    {
        List<List<string>> Utilizatori;

        public AdminAdder()
        {
            InitializeComponent();
        }

        private void DatabaseLoad()
        {
            //Utilizatori.Clear();
            Utilizatori = dbManage.Query("SELECT * FROM Utilizatori WHERE TipCont = '1'");

            comboBox.Items.Clear();
            
            foreach(var entry in Utilizatori)
                comboBox.Items.Add(entry[3]);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FrmInregistrare().ShowDialog();

            DatabaseLoad();
        }

        private void AdminAdder_Load(object sender, EventArgs e)
        {
            DatabaseLoad();

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            try
            {
                dbManage.nonQuery(
                    String.Format("CreateAdmin {0}", Utilizatori[comboBox.SelectedIndex][0])
                    );

                MessageBox.Show(String.Format("Utilizatorul cu adresa \"{0}\" a fost transformat în admin", Utilizatori[comboBox.SelectedIndex][3]), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DatabaseLoad();
            }
            catch
            {
                MessageBox.Show("Eroare apăruta la înregistrarea utilizatorului! Contactați dezvoltatorul","Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startPlaying_Tick(object sender, EventArgs e)
        {
            tutorialPlayer.URL = Application.StartupPath + "\\Resurse\\adminTutorial.avi";

            tutorialPlayer.Ctlcontrols.play();

            startPlaying.Stop();
        }
    }
}
