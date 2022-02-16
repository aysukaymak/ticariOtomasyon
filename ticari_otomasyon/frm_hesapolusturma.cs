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
    public partial class frm_hesapolusturma : Form
    {
        public frm_hesapolusturma()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //KULLANICI KAYDETME
            SqlCommand kaydet = new SqlCommand("Insert  into tbl_adminler (KULLANICIAD, SIFRE) values (@ad, @sifre)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@ad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@sifre", txtSifre.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kullanıcı bilgileri sisteme eklendi.", "Kullanıcı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
