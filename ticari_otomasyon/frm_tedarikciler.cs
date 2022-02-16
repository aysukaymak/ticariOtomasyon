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
    public partial class frm_tedarikciler : Form
    {
        public frm_tedarikciler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_tedarikciler", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Sehir_listesi()
        {
            //İLLERİ LİSTELEME
            SqlCommand komutsehir = new SqlCommand("Select SEHIR From tbl_iller", bgl.Baglanti());
            SqlDataReader dr_sehir = komutsehir.ExecuteReader();
            while (dr_sehir.Read())
            {
                cmbIl.Properties.Items.Add(dr_sehir[0]); //comboboxa iller veritabanındaki verileri yazdırıdık
            }
            bgl.Baglanti().Close();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İLÇELERİ LİSTELEME
            cmbIlce.Properties.Items.Clear();
            SqlCommand komutilce = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@sehir", bgl.Baglanti()); 
            komutilce.Parameters.AddWithValue("@sehir", cmbIl.SelectedIndex + 1); 
            SqlDataReader dr_ilce = komutilce.ExecuteReader();
            while (dr_ilce.Read())
            {
                cmbIlce.Properties.Items.Add(dr_ilce[0]);
            }
            bgl.Baglanti().Close();
        }

        private void frm_tedarikciler_Load(object sender, EventArgs e)
        {
            Listele();
            Sehir_listesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //TEDARİKCİ SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_tedarikciler where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Tedarikçi silindi.", "Tedarikçi Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYetkili.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKonum.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskTel2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mskTel3.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskFax.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtVergi.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TEDARİKCİ GÜNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_tedarikciler set AD=@ad, YETKILIADSOYAD=@yetkiliad, YETKILISTATU=@yetkilistatu, YETKILITC=@yetkilitc, TELEFON1=@tel1, TELEFON2=@tel2, TELEFON3=@tel3, FAX=@fax, MAIL=@mail, VERGIDAIRE=@vergi, IL=@il, ILCE=@ilce, ADRES=@adres Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@yetkiliad", txtYetkili.Text);
            guncelle.Parameters.AddWithValue("@yetkilistatu", txtKonum.Text);
            guncelle.Parameters.AddWithValue("@yetkilitc", mskTc.Text);
            guncelle.Parameters.AddWithValue("@tel1", mskTel.Text);
            guncelle.Parameters.AddWithValue("@tel2", mskTel2.Text);
            guncelle.Parameters.AddWithValue("@tel3", mskTel3.Text);
            guncelle.Parameters.AddWithValue("@fax", mskFax.Text);
            guncelle.Parameters.AddWithValue("@mail", txtMail.Text);
            guncelle.Parameters.AddWithValue("@vergi", txtVergi.Text);
            guncelle.Parameters.AddWithValue("@il", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@adres", rchAdres.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Tedarikçi bilgileri güncellendi.", "Tedarikçi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtAd.Text = "";
            txtYetkili.Text = "";
            txtKonum.Text = "";
            mskTc.Text = "";
            mskTel.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            mskFax.Text = "";
            txtMail.Text = "";
            txtVergi.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TEDARİKCİ KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_tedarikciler (AD, YETKILIADSOYAD, YETKILISTATU, YETKILITC, TELEFON1, TELEFON2, TELEFON3, FAX, MAIL, VERGIDAIRE, IL, ILCE, ADRES) values (@ad, @yetkiliad, @yetkilistatu, @yetkilitc, @tel1, @tel2, @tel3, @fax, @mail, @vergi, @il, @ilce, @adres)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@ad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@yetkiliad", txtYetkili.Text);
            kaydet.Parameters.AddWithValue("@yetkilistatu", txtKonum.Text);
            kaydet.Parameters.AddWithValue("@yetkilitc", mskTc.Text);
            kaydet.Parameters.AddWithValue("@tel1", mskTel.Text);
            kaydet.Parameters.AddWithValue("@tel2", mskTel2.Text);
            kaydet.Parameters.AddWithValue("@tel3", mskTel3.Text);
            kaydet.Parameters.AddWithValue("@fax", mskFax.Text);
            kaydet.Parameters.AddWithValue("@mail", txtMail.Text);
            kaydet.Parameters.AddWithValue("@vergi", txtVergi.Text);
            kaydet.Parameters.AddWithValue("@il", cmbIl.Text);
            kaydet.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            kaydet.Parameters.AddWithValue("@adres", rchAdres.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Tedarikçi bilgileri sisteme eklendi.", "Tedarikçi Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
