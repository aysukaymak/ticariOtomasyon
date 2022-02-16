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
    public partial class frm_urunler : Form
    {
        public frm_urunler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); //veritabanı adresini içeren sınıfı çağırdık

        void Listele()
        {
            DataTable dt_urunler = new DataTable();
            SqlDataAdapter da_urunler = new SqlDataAdapter("Execute UrunTedarikci", bgl.Baglanti());
            da_urunler.Fill(dt_urunler);
            dataGridView1.DataSource = dt_urunler;
        }

        void Tedarikci_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from tbl_tedarikciler", bgl.Baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void frm_urunler_Load(object sender, EventArgs e)
        {
            Listele();
            Tedarikci_listele();
            nudAdet.Text = "0";
            txtAlis.Text = "0";
            txtSatis.Text = "0";
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            //URUN KAYIT
            SqlCommand kaydet = new SqlCommand("insert into tbl_urunler (URUN, MARKA, MODEL, YIL, ADET, ALISFIYAT, SATISFIYAT, TEDARIKCIID, DETAY) values (@urun, @marka, @model, @yil, @adet, @alis, @satis, @tedarikci, @detay)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@urun", txtUrun.Text);
            kaydet.Parameters.AddWithValue("@marka", txtMarka.Text);
            kaydet.Parameters.AddWithValue("@model", txtModel.Text);
            kaydet.Parameters.AddWithValue("@yil", mskYil.Text);
            kaydet.Parameters.AddWithValue("@adet", int.Parse((nudAdet.Value).ToString())); //veritabanindaki formatına dönüştürdük
            kaydet.Parameters.AddWithValue("@alis", decimal.Parse(txtAlis.Text));
            kaydet.Parameters.AddWithValue("@satis", decimal.Parse(txtSatis.Text));
            kaydet.Parameters.AddWithValue("@tedarikci", lookUpEdit1.EditValue);
            kaydet.Parameters.AddWithValue("@detay", rchDetay.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Ürün sisteme eklendi.", "Ürün Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //URUN SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_urunler where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Ürün silindi.", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex; //çift tıklanan hücrenin satır değerini secilen değişkenine atadık
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrun.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtModel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskYil.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            nudAdet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtAlis.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtSatis.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            lookUpEdit1.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            rchDetay.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //URUN GUNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_urunler set URUN=@urun, MARKA=@marka, MODEL=@model, YIL=@yil, ADET=@adet, ALISFIYAT=@alis, SATISFIYAT=@satis, TEDARIKCIID=@tedarikci, DETAY=@detay Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@urun", txtUrun.Text);
            guncelle.Parameters.AddWithValue("@marka", txtMarka.Text);
            guncelle.Parameters.AddWithValue("@model", txtModel.Text);
            guncelle.Parameters.AddWithValue("@yil", mskYil.Text);
            guncelle.Parameters.AddWithValue("@adet", int.Parse((nudAdet.Text).ToString()));
            guncelle.Parameters.AddWithValue("@alis", decimal.Parse(txtAlis.Text));
            guncelle.Parameters.AddWithValue("@satis", decimal.Parse(txtSatis.Text));
            guncelle.Parameters.AddWithValue("@tedarikci", lookUpEdit1.EditValue);
            guncelle.Parameters.AddWithValue("@detay", rchDetay.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text); //bunu şart olarak eklemezsek sadece yukarıdaki komutlarla güncelleme sonunda veritabanındaki tüm kayıtları aynı yapar
                                                                 //bu şart yazılınca sadece alınan id ye sahip personelin kaydını güncellemiş olur
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Ürün güncellendi.", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtUrun.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYil.Text = "";
            nudAdet.Text = "0";
            txtAlis.Text = "0";
            txtSatis.Text = "0";
            lookUpEdit1.EditValue = null;
            rchDetay.Text = "";
            txtUrun.Focus();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
