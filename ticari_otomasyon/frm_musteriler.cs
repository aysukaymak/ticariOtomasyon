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
    public partial class frm_musteriler : Form
    {
        public frm_musteriler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_musteriler", bgl.Baglanti());
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
            cmbIlce.Properties.Items.Clear(); //farklı bir ile tıklandığında eski ilden kalan ilçeleri temizleyecek
            SqlCommand komutilce = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@sehir", bgl.Baglanti()); //il seçildikten sonra o ilin iilçelerini sıralamak için where şartı ile ilde seçilmiş olan SEHIR ın indeksini alacağız
                                                                                                                      //alınan indekse ait ilçeler ilçe comboboxında sıralanmış olacak
            komutilce.Parameters.AddWithValue("@sehir", cmbIl.SelectedIndex + 1); //cmbilde seçilmiş ilin indeksinden gelen değerin bir fazlası, yoksa bir alttakı ilin ilçelerini veriyor
            SqlDataReader dr_ilce = komutilce.ExecuteReader();
            while (dr_ilce.Read())
            {
                cmbIlce.Properties.Items.Add(dr_ilce[0]);
            }
            bgl.Baglanti().Close();
        }

        void frm_musteriler_Load(object sender, EventArgs e)
        {
            Listele();
            Sehir_listesi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MÜŞTERİ KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_musteriler (ADSOYAD, TELEFON, TELEFON2, TC, MAIL, VERGIDAIRE, IL, ILCE, ADRES) values (@adsoyad, @tel, @tel2, @tc, @mail, @vergi, @il, @ilce, @adres)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@tel", mskTel.Text);
            kaydet.Parameters.AddWithValue("@tel2", mskTel2.Text);
            kaydet.Parameters.AddWithValue("@tc", mskTc.Text);
            kaydet.Parameters.AddWithValue("@mail", txtMail.Text);
            kaydet.Parameters.AddWithValue("@vergi", txtVergi.Text);
            kaydet.Parameters.AddWithValue("@il", cmbIl.Text);
            kaydet.Parameters.AddWithValue("@ilce", cmbIlce.Text );
            kaydet.Parameters.AddWithValue("@adres", rchAdres.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Müşteri sisteme eklendi.", "Müşteri Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //MÜŞTERİ SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_musteriler where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Müşteri silindi.", "Müşteri Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTel2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtVergi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //MUSTERİ GUNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_musteriler set ADSOYAD=@adsoyad, TELEFON=@tel, TELEFON2=@tel2, TC=@tc, MAIL=@mail, VERGIDAIRE=@vergi, IL=@il, ILCE=@ilce, ADRES=@adres Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@tel", mskTel.Text);
            guncelle.Parameters.AddWithValue("@tel2", mskTel2.Text);
            guncelle.Parameters.AddWithValue("@tc", mskTc.Text);
            guncelle.Parameters.AddWithValue("@mail", txtMail.Text);
            guncelle.Parameters.AddWithValue("@vergi", txtVergi.Text);
            guncelle.Parameters.AddWithValue("@il", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@adres", rchAdres.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text); 
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Müşteri bilgileri güncellendi.", "Müşteri Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtAd.Text = "";
            mskTel.Text = "";
            mskTel2.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            txtVergi.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }
    }
}
