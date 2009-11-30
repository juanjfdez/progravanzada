using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication5
{
    public partial class frmContact : Form
    {
        protected SmtpClient cliente = new SmtpClient();
        protected MailMessage emailtecnico = new MailMessage();
        
        public frmContact()
        {
            InitializeComponent();
        }
        public void MandarCorreo(string sendfrom, string subject, string body)
        {
            string sendto = txtPara.Text;
            System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential(txtCorreo.Text, txtPass.Text);
            try
            {
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = credenciales;
                cliente.EnableSsl = true;

                MailAddress to = new MailAddress(sendto);
                MailAddress from = new MailAddress(sendfrom);

                emailtecnico.Subject = subject;
                emailtecnico.Body = body;
                emailtecnico.From = from;
                emailtecnico.To.Add(to);

                cliente.Send(emailtecnico);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MandarCorreo(txtCorreo.Text, txtNomContact.Text, txtdescripcion.Text);
            MessageBox.Show("Mensaje Enviado");
        }
    }
}
