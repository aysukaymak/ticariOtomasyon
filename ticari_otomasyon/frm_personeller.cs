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
    public partial class frm_personeller : Form
    {
        public frm_personeller()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt_personeller = new DataTable();
            SqlDataAdapter da_personeller = new SqlDataAdapter("Select * from tbl_personeller", bgl.Baglanti());
            da_personeller.Fill(dt_personeller);
            dataGridView1.DataSource = dt_personeller;
        }

        void Sehir_listesi()
        {
            //İLLERİ LİSTELEME
            SqlCommand komutsehir = new SqlCommand("Select SEHIR From tbl_iller", bgl.Baglanti());
            SqlDataReader dr_sehir = komutsehir.ExecuteReader();
            while (dr_sehir.Read())
            {
                cmbIl.Properties.Items.Add(dr_sehir[0]);
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

        private void frm_personeller_Load(object sender, EventArgs e)
        {
            txtMaas.Text = "0";
            Listele();
            Sehir_listesi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //PERSONEL KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_personeller (ADSOYAD, TELEFON, TC, MAIL, GOREV, MAAS, IL, ILCE, ADRES) values (@adsoyad, @tel, @tc, @mail, @gorev, @maas, @il, @ilce, @adres)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@tel", mskTel.Text);
            kaydet.Parameters.AddWithValue("@tc", mskTc.Text);
            kaydet.Parameters.AddWithValue("@mail", txtMail.Text);
            kaydet.Parameters.AddWithValue("@gorev", txtGorev.Text);
            kaydet.Parameters.AddWithValue("@maas", int.Parse(txtMaas.Text).ToString());
            kaydet.Parameters.AddWithValue("@il", cmbIl.Text);
            kaydet.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            kaydet.Parameters.AddWithValue("@adres", rchAdres.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Personel sisteme eklendi.", "Personel Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //PERSONEL SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_personeller where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Personel silindi.", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtGorev.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //PERSONEL GUNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_personeller set ADSOYAD=@adsoyad, TELEFON=@tel, TC=@tc, MAIL=@mail, GOREV=@gorev, MAAS=@maas, IL=@il, ILCE=@ilce, ADRES=@adres Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@tel", mskTel.Text);
            guncelle.Parameters.AddWithValue("@tc", mskTc.Text);
            guncelle.Parameters.AddWithValue("@mail", txtMail.Text);
            guncelle.Parameters.AddWithValue("@gorev", txtGorev.Text);
            guncelle.Parameters.AddWithValue("@maas", int.Parse(txtMaas.Text).ToString());
            guncelle.Parameters.AddWithValue("@il", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@adres", rchAdres.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Personel bilgileri güncellendi.", "Personel Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtAd.Text = "";
            mskTel.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            txtGorev.Text = "";
            txtMaas.Text= "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }
    }
}
