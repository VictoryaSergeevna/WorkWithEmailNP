using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WP_laba_
{
    public partial class Form1 : Form
    {
        List<string> AttachFile = null;
        MailMessage mes = null;
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {

            AttachFile = new List<string>();
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                AttachFile.Add(open.FileName);
                listBoxAttach.Items.Add(open.FileName);
            }              
           
            
        }

     

        private void btnSend_Click(object sender, EventArgs e)
        {
            string google = "smtp.gmail.com";
            mes = new MailMessage(txtBoxFrom.Text, txtBoxTo.Text, txtBoxSubject.Text, txtBoxMessage.Text);
            SmtpClient client = new SmtpClient(google);
            client.UseDefaultCredentials = true;
            client.Port = 587;
            client.Credentials = new NetworkCredential("vikusyachk@gmail.com", "*******");
            client.EnableSsl = true;
            if (AttachFile != null)
            {
                for (int i = 0; i < AttachFile.Count; i++)
                {
                    Attachment attach = new Attachment(AttachFile[i]);
                    mes.Attachments.Add(attach);
                }
            }
            try
            {
                client.SendAsync(mes, "That's all");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNewLetter_Click(object sender, EventArgs e)
        {
            txtBoxFrom.Clear();
            txtBoxTo.Clear();
            txtBoxSubject.Clear();
            txtBoxSubject.Clear();
            txtBoxMessage.Clear();
            listBoxAttach.Items.Clear();
        }
    }
}
