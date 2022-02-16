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
    public partial class frm_parolaguncelleme : Form
    {
        public frm_parolaguncelleme()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string kullaniciadi;
        private void frm_parolaguncelleme_Load(object sender, EventArgs e)
        {
            txtAd.Text = kullaniciadi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update tbl_adminler set KULLANICIAD=@ad, SIFRE=@sifre where KULLANICIAD=@ad", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@sifre", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Kullanıcı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
