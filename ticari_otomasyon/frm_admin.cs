using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ticari_otomasyon
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("Select * from tbl_adminler where KULLANICIAD=@ad and SIFRE=@sifre", bgl.Baglanti());
            giris.Parameters.AddWithValue("@ad", txtKullanıcı.Text);
            giris.Parameters.AddWithValue("@sifre", txtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                //textboxlardan okunan değerler doğru ise anamenuye gidecek 
                frm_anamenu fr_anamenu = new frm_anamenu();
                fr_anamenu.Kullanici = txtKullanıcı.Text; //Kullanıcı adı bilgisini anamodüle taşıdık oradan da kasa modülüne taşıyacağız
                fr_anamenu.KulSifre = txtSifre.Text;
                fr_anamenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girildi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullanıcı.Text = "";
                txtSifre.Text = "";
            }
            bgl.Baglanti().Close();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            //SİFREYİ GORUNTULEME
            if (checkButton1.Checked)
            {
                txtSifre.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            frm_hesapolusturma fr_hesapolusturma = new frm_hesapolusturma();
            fr_hesapolusturma.Show();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            frm_parolaguncelleme fr_parolaguncelleme = new frm_parolaguncelleme();
            fr_parolaguncelleme.kullaniciadi = txtKullanıcı.Text;
            fr_parolaguncelleme.Show();            
        }
    }
}
