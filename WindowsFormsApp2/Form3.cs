using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txtImie.Text, txtHaslo.Text);
            client = new SmtpClient(txtsmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chbssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtImie.Text + txtsmtp.Text.Replace("smtp.", "@"), "Problem z haslem.", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtDo.Text));
            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            msg.Subject = txtTemat.Text;
            msg.Body = txtTrescWiadomosci.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Wysylanie...";
            client.SendAsync(msg, userstate);
            
        }

            private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
            {
                if (e.Cancelled)
                    MessageBox.Show(string.Format("{0} wyslanie zamkniete", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (e.Error != null)
                    MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Twoja wiaomosc zostala wyslana.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

       // private void txtsmtp_TextChanged(object sender, EventArgs e)
        //{
        //    ToolTip toolTip1 = new ToolTip();
        //    toolTip1.SetToolTip(this.txtImie, "Tutaj wpisz server z ktorego sklada sie adres poczty elektronicznej.");
       // }

       private void txtImie_MouseMove(object sender, MouseEventArgs e)
       {
           ToolTip toolTip1 = new ToolTip();
           toolTip1.SetToolTip(this.txtImie, "Tutaj wpisz swoj inentyfikator uzytkownika adresu mail.");
        }

        private void txtsmtp2_MouseMove(object sender, MouseEventArgs e)
        {
          //  ToolTip toolTip1 = new ToolTip();
           // toolTip1.SetToolTip(this.txtImie, "Tutaj wpisz server z ktorego sklada sie adres poczty elektronicznej.");
        }
        
private void txtsmtp_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.txtsmtp, "Tutaj wpisz server z ktorego sklada sie adres poczty elektronicznej.");
        }
    }

}
