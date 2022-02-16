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
    public partial class frm_firmalar : Form
    {
        public frm_firmalar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_firmalar", bgl.Baglanti());
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

        void Kod_aciklamalar()
        {
            SqlCommand kod = new SqlCommand("Select FIRMAKOD1 from tbl_firmakodlar", bgl.Baglanti());
            SqlDataReader dr_kod = kod.ExecuteReader();
            while (dr_kod.Read())
            {
                rchSektorKod.Text = dr_kod[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void frm_firmalar_Load(object sender, EventArgs e)
        {
            Listele();
            Sehir_listesi();
            Kod_aciklamalar();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //FİRMA KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_firmalar (AD, SEKTOR, YETKILIADSOYAD, YETKILISTATU, YETKILITC, TELEFON1, TELEFON2, TELEFON3, FAX, MAIL, VERGIDAIRE, IL, ILCE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3) values (@ad, @sektor, @yetkiliad, @yetkilistatu, @yetkilitc, @tel1, @tel2, @tel3, @fax, @mail, @vergi, @il, @ilce, @adres, @kod1, @kod2,  @kod3)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@ad", txtAd.Text);
            kaydet.Parameters.AddWithValue("@sektor", txtSektor.Text);
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
            kaydet.Parameters.AddWithValue("@kod1", txtSektorKod.Text);
            kaydet.Parameters.AddWithValue("@kod2", txtKod2.Text);
            kaydet.Parameters.AddWithValue("@kod3", txtKod3.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Firma bilgileri sisteme eklendi.", "Firma Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //FİRMA SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_firmalar where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Firma silindi.", "Firma Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSektor.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtYetkili.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKonum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            mskTel2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskTel3.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            mskFax.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtVergi.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            txtSektorKod.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            txtKod2.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            txtKod3.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //FİRMA GÜNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_firmalar set AD=@ad, SEKTOR=@sektor, YETKILIADSOYAD=@yetkiliad, YETKILISTATU=@yetkilistatu, YETKILITC=@yetkilitc, TELEFON1=@tel1, TELEFON2=@tel2, TELEFON3=@tel3, FAX=@fax, MAIL=@mail, VERGIDAIRE=@vergi, IL=@il, ILCE=@ilce, ADRES=@adres, OZELKOD1=@kod1, OZELKOD2=@kod2, OZELKOD3=@kod3 Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);     
            guncelle.Parameters.AddWithValue("@sektor", txtSektor.Text);
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
            guncelle.Parameters.AddWithValue("@kod1", txtSektorKod.Text);
            guncelle.Parameters.AddWithValue("@kod2", txtKod2.Text);
            guncelle.Parameters.AddWithValue("@kod3", txtKod3.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Firma bilgileri güncellendi.", "Firma Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtAd.Text = "";
            txtSektor.Text = "";
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
            txtSektorKod.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtAd.Focus();
        }
    }
}