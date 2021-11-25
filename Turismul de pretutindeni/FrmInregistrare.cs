using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Turismul_de_pretutindeni
{
    public partial class FrmInregistrare : Form
    {

        int prevCaptcha;

        public FrmInregistrare()
        {
            InitializeComponent();
            prevCaptcha = -1;

        }

        //////////////////////////////// Captcha engine ////////////////////////////////

        private void LoadCaptchaImage()
        {
            int generatedPos;

            do
            {
                Random rand = new Random();
                generatedPos = rand.Next(0, Resource.captchaFiles.Length);
            } while (generatedPos == prevCaptcha);

            AreaCaptcha.Tag = Path.GetFileNameWithoutExtension(Resource.captchaFiles[generatedPos]);
            AreaCaptcha.Image = Image.FromFile(Resource.captchaFiles[generatedPos]);

        }

        ////////////////////////////////////////////////////////////////////////////////
        
        private void ConfirmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInregistrare_Load(object sender, EventArgs e)
        {
            LoadCaptchaImage();
        }
        //////////////////////////////// Verificare format input ////////////////////////////////

        private bool CheckEmail(string email)
        {
            try
            {
                var convert = new System.Net.Mail.MailAddress(email);

                int count = Convert.ToInt32(
                        dbManage.singleQuery(String.Format("CheckEmail '{0}'",email))
                    );

                if(count > 0)
                {
                    MessageBox.Show("Email deja existent!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                MessageBox.Show("E-mail scris gresit! (Ai lasat spatii albe?)", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private bool CheckPassword(string p1, string p2)
        {
            if (p1 == p2)
            {
                if (p1.Length >= 3)
                    return true;
                else
                {
                    MessageBox.Show("Parola nu are minimum 3 caractere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputParola.Clear();
                    InputConfirmParola.Clear();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Cele doua parole nu sunt identice!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputParola.Clear();
                InputConfirmParola.Clear();
                return false;
            }
        }

        private bool CheckCaptcha(string captcha)
        {
            if (captcha != AreaCaptcha.Tag.ToString())
            {
                MessageBox.Show("Captcha rezolvat incorect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private bool FormIsFilled()
        {
            bool completat = true;

            foreach(Control instance in this.groupBox1.Controls)
            {
                if(instance is TextBox)
                {
                    if(String.IsNullOrWhiteSpace(instance.Text) == true)
                    {
                        MessageBox.Show("Formularul nu este completat complet!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        completat = false;
                        break;
                    }
                }
            }

            return completat;
        }

        private void InsertData()
        {
            if (FormIsFilled() == true)
            {
                if (CheckEmail(inputEmail.Text) == true)
                {
                    if (CheckPassword(inputParola.Text, InputConfirmParola.Text) == true)
                    {
                        if (CheckCaptcha(inputCaptcha.Text) == true)
                        {
                            dbManage.nonQuery(
                                String.Format("InsertUser '{0}','{1}','{2}','{3}','{4}'", inputNume.Text, inputPrenume.Text, inputEmail.Text, inputParola.Text,1)  
                            );

                            this.Close();
                        }
                        else
                        {
                            inputCaptcha.Clear();
                            LoadCaptchaImage();
                        }
                    }
                    else
                    {
                        inputParola.Clear();
                        InputConfirmParola.Clear();
                    }
                }
                else
                {
                    inputEmail.Clear();
                }
            }
        }

        private void ConfirmRegister_Click(object sender, EventArgs e)
        {
            InsertData();
            
        }

        private void generateCaptcha_Click(object sender, EventArgs e)
        {
            LoadCaptchaImage();
        }

    }
}