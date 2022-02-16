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
    public partial class frm_ayarlar : Form
    {
        public frm_ayarlar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string ad;
        public string sifre;
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, KULLANICIAD, SIFRE from tbl_adminler where KULLANICIAD=@ad", bgl.Baglanti());
            da.SelectCommand.Parameters.AddWithValue("@ad", ad);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frm_ayarlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydetF_Click(object sender, EventArgs e)
        {
            //KULLANICI KAYDETME
            SqlCommand kaydet = new SqlCommand("Insert  into tbl_adminler (KULLANICIAD, SIFRE) values (@ad, @sifre)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@ad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@sifre", txtSifre.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Kullanıcı bilgileri sisteme eklendi.", "Kullanıcı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //KULLANICI SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_adminler where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Kullanıcı silindi.", "Kullanıcı Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update tbl_adminler set KULLANICIAD=@ad, SIFRE=@sifre where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@sifre", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Kullanıcı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSifre.Text = "";
        }
    }
}
