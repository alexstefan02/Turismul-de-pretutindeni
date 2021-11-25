using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Diagnostics;


namespace Turismul_de_pretutindeni
{
    public partial class FrmVacanta : Form
    {
        int select;


        private void LoadCurrentUser()
        {
            ///Functie ce incarca datele utilizatorului din cache.
            AccountTab.Text = Resource.loggedEmail;
            if (Resource.tipCont == 0) ///Admin - 0 | User - 1
                AdminToolsTab.Enabled = true;
            else
                AdminToolsTab.Enabled = false;
        }

        private void LoadLocationData(int count)
        {
            if(count < Resource.InfoVacante.Count && count >= 0)
            {
                ShowVacation.Tag = Resource.InfoVacante[count][1];
                ShowVacation.Image = Image.FromFile(Resource.InfoVacante[count][3]);

                

                NameLocation.Text = Resource.InfoVacante[count][1];
                PriceLocation.Text = Resource.InfoVacante[count][4] + " Lei";
                SeatsLocation.Text = Resource.InfoVacante[count][5];

                DescriptionLocation.Text = Resource.InfoVacante[count][2];
            }
        }

        public FrmVacanta()
        {
            InitializeComponent();
            select = 0;
        }

        private void FrmVacanta_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
            LoadLocationData(select);
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (select + 1 < Resource.InfoVacante.Count)
                LoadLocationData(++select);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (select - 1 >= 0)
                LoadLocationData(--select);
        }

        private void DeconectareOption_Click(object sender, EventArgs e)
        {
            DialogResult optionChosen = MessageBox.Show("Doresti să te deconectezi?", "Deconectare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (optionChosen == DialogResult.Yes)
            {
                Resource.UserReset();
                this.Close();
            }
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult optionChosen = MessageBox.Show("Doresti să închizi aplicația? \n\n Veți fi deconectat automat din cont.", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (optionChosen == DialogResult.Yes)
            {
                Resource.UserReset();
                this.Close();
                Resource.prepareExit = true;
            }
        }

        private void SlideShowOption_CheckedChanged(object sender, EventArgs e)
        {
            if (SlideShowOption.Checked == true)
            {
                timerSlideShow.Start();
                btnPrev.Enabled = btnNext.Enabled = false;
            }
            else
            {
                timerSlideShow.Stop();
                btnPrev.Enabled = btnNext.Enabled = true;
            }
        }

        private void timerSlideShow_Tick(object sender, EventArgs e)
        {
            LoadLocationData(select++);
            select %= Resource.InfoVacante.Count;   
        }

        private void AddVacationEditor_Click(object sender, EventArgs e)
        {
            Process Editor = new Process();

            Editor.StartInfo.FileName = Application.StartupPath + "\\Resurse\\Vacante.txt";

            Editor.Start();

            Editor.WaitForInputIdle();

            this.Focus();
            Importer.ReloadData();

            LoadLocationData((select = 0));


        }

        private void AddAdminOption_Click(object sender, EventArgs e)
        {
            new AdminAdder().ShowDialog();
        }

        private void MyVacationsTab_Click(object sender, EventArgs e)
        {
            new MyVacations().ShowDialog();
        }

        private void butonRezervare_Click(object sender, EventArgs e)
        {
            new RezervareForm(select).ShowDialog();
        }

        /// <summary>
        /// Poster
        /// </summary>

        private int n, m;
        private int[,] Map;
        private int[,] Ref;
        Point fillStopped;

        private decimal Fill(Point cr,int val)
        {
            int[] di = new int[]{-1,0,1,0};
            int[] dj = new int[]{0,1,0,-1};

            decimal count = 1;
            Queue<Point> Q = new Queue<Point>();
            Point vecin;

            Q.Enqueue(cr);

            Map[cr.X,cr.Y] = -1;

            while(Q.Count > 0)
            {
                cr = Q.First();
                Q.Dequeue();

                for(int i=0; i<4; i++)
                {
                    if(!(cr.X+di[i]<0 || cr.Y+dj[i]<0 || cr.X+di[i]>n || cr.Y+dj[i]>m))
                    {
                        vecin = new Point(cr.X + di[i], cr.Y + dj[i]);

                        if (Map[vecin.X, vecin.Y] == val)
                        {
                            count++;
                            Map[vecin.X, vecin.Y] = -1;

                            Q.Enqueue(vecin);
                        }
                    }
                }
            }

            fillStopped = cr;

            return count;
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            Bitmap poster = new Bitmap(
                Image.FromFile(Resource.InfoVacante[select][3])
                );

            n = poster.Width; m = poster.Height;

            Map = new int[n+1,m+1];
            Ref = new int[n + 1, m + 1];

            ///Luminozitate^2 = 0,241*R^2 + 0,691*G^2 + 0,068*B^2

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Color pixel = poster.GetPixel(i, j);
                    double R = Math.Pow(pixel.R,2);
                    double G = Math.Pow(pixel.G,2);
                    double B = Math.Pow(pixel.B,2);
                    double LUMA = Math.Sqrt(0.241 * R + 0.691 * G + 0.068 * B);

                    if (LUMA <= 50)
                        Ref[i,j] = Map[i,j] = 0;
                    else
                        if (LUMA > 200)
                            Ref[i,j] = Map[i,j] = 1;

                }
            }

            decimal max = -1;
            Point textPos = new Point(0,0);
            int lumaType = 0;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                    if(Map[i,j] != -1)
                    {
                        decimal area = Fill(new Point(i, j), Map[i, j]);

                        if(area>max)
                        {
                            max = area;
                            textPos = new Point(

                                 (fillStopped.X - i) /2, (fillStopped.Y - j)/2

                                );
                            lumaType = Ref[textPos.X, textPos.Y];
                        }
                    }
            }


            Graphics graphic = Graphics.FromImage(poster);

            if(lumaType == 0)
                graphic.DrawString(Resource.InfoVacante[select][1], new Font("Roboto", 25), Brushes.White, textPos);
            else
            {
                graphic.DrawString(Resource.InfoVacante[select][1], new Font("Roboto", 25), Brushes.Black, textPos);
            }

            SaveFileDialog dialog = new SaveFileDialog();   
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                poster.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }
    }
}
