using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Mail_Gonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        MailMessage eposta = new MailMessage();

        public int i { get; private set; }


        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential(textBox4.Text, textBox5.Text);
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(textBox1.Text);
            mesajım.From = new MailAddress(textBox4.Text);
            mesajım.Subject = textBox2.Text;
            mesajım.Body = textBox3.Text;
            istemci.Send(mesajım);
            MessageBox.Show("Mesaj Gönderilmiştir");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mailkaynak = textBox4.Text;
            string mailsifre = textBox5.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox5.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox5.PasswordChar = '*';
            }
        }
    }
}

