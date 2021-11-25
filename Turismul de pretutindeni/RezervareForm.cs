using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Turismul_de_pretutindeni
{
    public partial class RezervareForm : Form
    {
        private int IDvacation, nrLocuri,nrPersoane,nrDisponibile;
        private float totalPlata,pretPerPersoana;
        DateTime begin, end;

        public RezervareForm(int RefID)
        {
            InitializeComponent();
            IDvacation = RefID;
            nrLocuri = int.Parse(Resource.InfoVacante[RefID][5]);
            pretPerPersoana = int.Parse(Resource.InfoVacante[RefID][4]);

            dateTimePicker1.MinDate = dateTimePicker2.MinDate = DateTime.Now;
        }

        private void SetPrice(Label tag, string val)
        {
            tag.Text = val + " LEI";
        }

        private void SetDisponibilitate(bool ok)
        {
            //suma=pret*număr de locuri*nr zile

            if (ok == true)
            {
                disponibilitate.Visible = true;
                disponibilitate.Text = "DA";

                DataLocatie.Visible = true;
                DataLocatie.Text = String.Format("{0} - {1}", begin.ToShortDateString(), end.ToShortDateString());

                totalPlata = pretPerPersoana * nrPersoane * (end.Day - begin.Day + 1);
                label6.Visible = true;
                PretTotal.Visible = true;
                PretTotal.Text = totalPlata.ToString() + " LEI";

                BoxConfirm.Visible = true;
                btnStartCheck.Enabled = false;
            }
            else
            {
                disponibilitate.Visible = true;
                disponibilitate.Text = "NU";
            }

        }

        private void LoadUserInput()
        {

            begin = dateTimePicker1.Value.Date;
            end = dateTimePicker2.Value.Date;

            nrTotal.Visible = true;
            nrTotal.Text = textBox1.Text;
            nrPersoane = int.Parse(textBox1.Text);

        }

        private void CheckDisponibilitate()
        {
            int nrRezervari = 0;
            foreach(var entry in Resource.InfoRezervari)
            {
                if ( (DateTime.Parse(entry[3]) >= begin && DateTime.Parse(entry[4]) <= end) && int.Parse(entry[1]) == (IDvacation+1))
                    nrRezervari+= int.Parse(entry[5]);
            }

           bool ok = true;

            foreach(var entry in Resource.InfoRezervari)
            {
                if (entry[1] == (IDvacation+1).ToString() && entry[2]==Resource.IdUser.ToString() && DateTime.Parse(entry[3]) == begin.Date && DateTime.Parse(entry[4]) == end.Date && entry[5] == nrPersoane.ToString())
                {
                    ok = false;
                    break;
                }
            }

            nrDisponibile = nrLocuri - nrRezervari;
            AvaliableSeats.Visible = true;
            AvaliableSeats.Text = nrDisponibile.ToString();
            
            if ((nrDisponibile - nrPersoane <= 0) || ok == false)
                SetDisponibilitate(false);
            else
                SetDisponibilitate(true);
            
        }

        private void RegisterRezervatie()
        {
            try
            {


                dbManage.nonQuery(
                    String.Format("InsertRezervare '{0}','{1}','{2}','{3}','{4}','{5}'", IDvacation+1, Resource.IdUser, begin.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss"), nrPersoane, totalPlata)
                    );

                Importer.LoadRezervari(); //refresh

                MessageBox.Show("Rezervarea a fost confirmată cu succes", "Vacanță plăcută!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void RezervareForm_Load(object sender, EventArgs e)
        {
            
            ImaginePrezentare.Image = Image.FromFile(Resource.InfoVacante[IDvacation][3]);
            NumeLocatie.Text = Resource.InfoVacante[IDvacation][1];
            SetPrice(SinglePrice, pretPerPersoana.ToString());
        }

        private void btnStartCheck_Click(object sender, EventArgs e)
        {
            try
            {
                LoadUserInput();
                CheckDisponibilitate();
            }
            catch
            {
                MessageBox.Show("Eroare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            RegisterRezervatie();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();

            printDialog.Document = printDocument1;

            printDialog.ShowDialog();

                

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);

            int fontHeight = (int)font.GetHeight();

            int startX = 10; int startY = 10; int offset = 40;

            Bitmap destinationPreview = new Bitmap(Image.FromFile(Resource.InfoVacante[IDvacation][3]),new Size(150,150));

            

            graphic.DrawImage(destinationPreview, new Point(startX, startY));

            startY += destinationPreview.Height + offset + 5;

            graphic.DrawString("Turism de pretutindeni", new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY));

            graphic.DrawString("----------------------------------", new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY + offset));

            offset += (fontHeight + 20);

            graphic.DrawString("Locație: " + NumeLocatie.Text, new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY + offset));

            offset += (fontHeight + 5);

            graphic.DrawString("Pret per persoană: " + SinglePrice.Text, new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY+offset));

            offset += (fontHeight+5);

            graphic.DrawString("-----------------------------", new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY + offset));

            offset += (fontHeight + 20);

            graphic.DrawString(DataLocatie.Text, new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY+offset));

            offset += (fontHeight + 5);

            graphic.DrawString(label4.Text + nrTotal.Text, new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY+offset));

            offset += (fontHeight + 5);

            graphic.DrawString("-----------------------------", new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY + offset));

            offset += (fontHeight + 20);

            graphic.DrawString("Preț total: " + PretTotal.Text,new Font("Courier New", 18), new SolidBrush(Color.Black), new Point(startX, startY+offset));


        }


    }
}
