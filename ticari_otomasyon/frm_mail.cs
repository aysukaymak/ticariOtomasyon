using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //mail gönderme işlemleri için gerekli kütüphaneler
using System.Net.Mail;

namespace ticari_otomasyon
{
    public partial class frm_mail : Form
    {
        public frm_mail()
        {
            InitializeComponent();
        }

        public string mail;
        private void frm_mail_Load(object sender, EventArgs e)
        {
            txtAlici.Text = mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();  //smtp istemci nesnesi
            istemci.Credentials = new System.Net.NetworkCredential("gazielektronik2021@gmail.com", "gazi2021.");
            istemci.Port = 587; //türkyede kullanılan mail adresi numarası
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true; //şifreleme yapacak
            mesaj.To.Add(txtAlici.Text); //kime gdiyor
            mesaj.From = new MailAddress("gazielektronik2021@gmail.com"); //kimden gidiyor
            mesaj.Subject = txtKonu.Text; //mail konusu
            mesaj.Body = rchMail.Text; //mail
            istemci.Send(mesaj); //maili gönder
            MessageBox.Show("Mail gönderildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
