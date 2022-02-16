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
    public partial class frm_faturalar : Form
    {
        public frm_faturalar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void FaturaDetay_Listele()
        {
            //DATAGRİDE LİSTELEME
            if (cmbAliciTur.Text == "Firma")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("execute FirmaFatura", bgl.Baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (cmbAliciTur.Text == "Müşteri")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("execute MusteriFatura", bgl.Baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            if (cmbAliciTur.Text == "Tedarikçi")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("execute TedarikciFatura", bgl.Baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void FaturaUrunDetay_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_faturaUrunDetay", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void LookAlici_listeleme()
        {
            //MÜŞTERİ, FİRMA ve TEDARİKÇİLERDEKİ ALICILARI LİSTELEME
            if (cmbAliciTur.Text == "Firma")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from tbl_firmalar", bgl.Baglanti());
                da.Fill(dt);
                lookAlici.Properties.ValueMember = "ID";
                lookAlici.Properties.DisplayMember = "AD";
                lookAlici.Properties.DataSource = dt;
            }

            if (cmbAliciTur.Text == "Müşteri")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select ID, ADSOYAD from tbl_musteriler", bgl.Baglanti());
                da.Fill(dt);
                lookAlici.Properties.ValueMember = "ID";
                lookAlici.Properties.DisplayMember = "ADSOYAD";
                lookAlici.Properties.DataSource = dt;
            }

            if (cmbAliciTur.Text == "Tedarikçi")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from tbl_tedarikciler", bgl.Baglanti());
                da.Fill(dt);
                lookAlici.Properties.ValueMember = "ID";
                lookAlici.Properties.DisplayMember = "AD";
                lookAlici.Properties.DataSource = dt;
            }
        }

        private void cmbAliciTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaDetay_Listele();
            LookAlici_listeleme();
        }

        void Personel_listele()
        {
            //PERSONELLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, ADSOYAD, GOREV from tbl_personeller", bgl.Baglanti());
            da.Fill(dt);
            lookPersonel.Properties.ValueMember = "ID";
            lookPersonel.Properties.DisplayMember = "ADSOYAD";
            lookPersonel.Properties.DataSource = dt;
        }

        void Urun_listele()
        {
            //URUNLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, URUN, MARKA, ALISFIYAT, SATISFIYAT from tbl_urunler", bgl.Baglanti());
            da.Fill(dt);
            lookUrun.Properties.ValueMember = "ID";
            lookUrun.Properties.DisplayMember = "URUN";
            lookUrun.Properties.DataSource = dt;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //LOOKUPEDİTTEN SECİLEN URUNUN BİLGİLERİNİ ARAÇLARA TAŞIMA
            if (cmbAliciTur.Text == "Firma" || cmbAliciTur.Text == "Müşteri")
            {
                SqlCommand urunBulFM = new SqlCommand("select URUN, MARKA, SATISFIYAT from tbl_urunler where ID=@id", bgl.Baglanti());
                urunBulFM.Parameters.AddWithValue("@id", lookUrun.EditValue);
                SqlDataReader drFM = urunBulFM.ExecuteReader();
                while (drFM.Read())
                {
                    txtUrun.Text = drFM[0].ToString();
                    txtMarka.Text = drFM[1].ToString();
                    txtFiyat.Text = drFM[2].ToString();
                }
                bgl.Baglanti().Close();
            }

            if (cmbAliciTur.Text == "Tedarikçi")
            {
                SqlCommand urunBulT = new SqlCommand("select URUN, MARKA, ADET, ALISFIYAT from tbl_urunler where ID=@id", bgl.Baglanti());
                urunBulT.Parameters.AddWithValue("@id", lookUrun.EditValue);
                SqlDataReader drT = urunBulT.ExecuteReader();
                while (drT.Read())
                {
                    txtUrun.Text = drT[0].ToString();
                    txtMarka.Text = drT[1].ToString();
                    nudAdet.Value = int.Parse(drT[2].ToString());
                    txtFiyat.Text = drT[3].ToString();
                }
                bgl.Baglanti().Close();
            }
        }

        private void frm_faturalar_Load(object sender, EventArgs e)
        {
            FaturaDetay_Listele();
            FaturaUrunDetay_Listele();
            Personel_listele();
            Urun_listele();
            nudAdet.Value = 0;
            txtFiyat.Text = "0,00";
            txtTutar.Text = "0,00";
        }

        private void btnKaydetF_Click_1(object sender, EventArgs e)
        {
            //FATURA DETAY KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_faturaBilgi (SERI, SIRANO, TARIH, SAAT, VERGIDAIRE, ALICITUR, ALICI, TESLIMEDEN, TESLIMALAN) values (@seri, @sirano, @tarih, @saat, @vergi, @alicitur, @alici, @teslimeden, @teslimalan)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@seri", txtSeri.Text);
            kaydet.Parameters.AddWithValue("@sirano", txtSiraNo.Text);
            kaydet.Parameters.AddWithValue("@tarih", mskTarih.Text);
            kaydet.Parameters.AddWithValue("@saat", mskSaat.Text);
            kaydet.Parameters.AddWithValue("@vergi", txtVergi.Text);
            kaydet.Parameters.AddWithValue("@alicitur", cmbAliciTur.Text);
            kaydet.Parameters.AddWithValue("@alici", lookAlici.EditValue);
            kaydet.Parameters.AddWithValue("@teslimeden", lookPersonel.EditValue);
            kaydet.Parameters.AddWithValue("@teslimalan", txtTeslimAlan.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaDetay_Listele();
            MessageBox.Show("Fatura detayları sisteme eklendi.", "Fatura Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSilF_Click_1(object sender, EventArgs e)
        {
            //FATURA DETAY SİLME  
            SqlCommand sil = new SqlCommand("Delete From tbl_faturaBilgi where FATURABILGIID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaDetay_Listele();
            MessageBox.Show("Fatura silindi.", "Fatura Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSeri.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSiraNo.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtVergi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbAliciTur.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            lookAlici.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            lookPersonel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtTeslimAlan.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtFaturaID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnGuncelleF_Click_1(object sender, EventArgs e)
        {
            //FATURA DETAY GÜNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_faturaBilgi set SERI=@seri, SIRANO=@sirano, TARIH=@tarih, SAAT=@saat, VERGIDAIRE=@vergi, ALICITUR=@alicitur, ALICI=@alici, TESLIMEDEN=@teslimeden, TESLIMALAN=@teslimalan Where FATURABILGIID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@seri", txtSeri.Text);
            guncelle.Parameters.AddWithValue("@sirano", txtSiraNo.Text);
            guncelle.Parameters.AddWithValue("@tarih", mskTarih.Text);
            guncelle.Parameters.AddWithValue("@saat", mskSaat.Text);
            guncelle.Parameters.AddWithValue("@vergi", txtVergi.Text);
            guncelle.Parameters.AddWithValue("@alicitur", cmbAliciTur.Text);
            guncelle.Parameters.AddWithValue("@alici", lookAlici.EditValue);
            guncelle.Parameters.AddWithValue("@teslimeden", lookPersonel.EditValue);
            guncelle.Parameters.AddWithValue("@teslimalan", txtTeslimAlan.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaDetay_Listele();
            MessageBox.Show("Firma bilgileri güncellendi.", "Firma Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizleF_Click_1(object sender, EventArgs e)
        {
            //FATURA DETAY ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergi.Text = "";
            cmbAliciTur.Text = "";
            lookAlici.EditValue = null;
            lookPersonel.EditValue = null;
            txtTeslimAlan.Text = "";
        }

        private void btnDetay_Click_1(object sender, EventArgs e)
        {
            //FATURA DETAYDAKİ FATURA ID'nın FATURA URUN DETAY FORMUNA TAŞINMASI
            //EKRANA GELECEK OLAN FORMDA SEÇİLMİŞ OLAN FATURANIN ÜRÜN İÇERİĞİ GÖSTERİLECEK
            frm_faturaUrunler fr_faturaUrunler = new frm_faturaUrunler();
            if (txtId.Text != null)
            {
                fr_faturaUrunler.id = txtId.Text;
            }
            fr_faturaUrunler.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------
        //URUN DETAY 
        //--------------------------------------------------------------------------------------------------------------------

        void Hareketler_kayıt()
        {
            if (cmbAliciTur.Text == "Müşteri")
            {
                //MUSTERİ HAREKET TABLOSUNA VERİ GİRİŞİ
                SqlCommand kaydetMusHar = new SqlCommand("insert into tbl_hareketlerMusteri (PERSONEL, MUSTERI, TARIH, URUN, MARKA, ADET, FIYAT, TUTAR, FATURAID) values (@Mpersonel, @Mmusteri, @Mtarih, @Murun, @Mmarka, @Madet, @Mfiyat, @Mtutar, @Mfaturaid)", bgl.Baglanti());
                kaydetMusHar.Parameters.AddWithValue("@Mpersonel", lookPersonel.EditValue);
                kaydetMusHar.Parameters.AddWithValue("@Mmusteri", lookAlici.EditValue);
                kaydetMusHar.Parameters.AddWithValue("@Mtarih", mskTarih.Text);
                kaydetMusHar.Parameters.AddWithValue("@Murun", lookUrun.EditValue);
                kaydetMusHar.Parameters.AddWithValue("@Mmarka", txtMarka.Text);
                kaydetMusHar.Parameters.AddWithValue("@Madet", int.Parse((nudAdet.Value).ToString()));
                kaydetMusHar.Parameters.AddWithValue("@Mfiyat", decimal.Parse(txtFiyat.Text));
                kaydetMusHar.Parameters.AddWithValue("@Mtutar", decimal.Parse(txtTutar.Text));
                kaydetMusHar.Parameters.AddWithValue("@Mfaturaid", txtFaturaID.Text);
                kaydetMusHar.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }

            if (cmbAliciTur.Text == "Firma")
            {
                //FİRMA HAREKET TABLOSUNA VERİ GİRİŞİ
                SqlCommand kaydetFirHar = new SqlCommand("insert into tbl_hareketlerFirma (PERSONEL, FIRMA, TARIH, URUN, MARKA, ADET, FIYAT, TUTAR, FATURAID) values (@Fpersonel, @Ffirma, @Ftarih, @Furun, @Fmarka, @Fadet, @Ffiyat, @Ftutar, @Ffaturaid)", bgl.Baglanti());
                kaydetFirHar.Parameters.AddWithValue("@Fpersonel", lookPersonel.EditValue);
                kaydetFirHar.Parameters.AddWithValue("@Ffirma", lookAlici.EditValue);
                kaydetFirHar.Parameters.AddWithValue("@Ftarih", mskTarih.Text);
                kaydetFirHar.Parameters.AddWithValue("@Furun", lookUrun.EditValue);
                kaydetFirHar.Parameters.AddWithValue("@Fmarka", txtMarka.Text);
                kaydetFirHar.Parameters.AddWithValue("@Fadet", int.Parse((nudAdet.Value).ToString()));
                kaydetFirHar.Parameters.AddWithValue("@Ffiyat", decimal.Parse(txtFiyat.Text));
                kaydetFirHar.Parameters.AddWithValue("@Ftutar", decimal.Parse(txtTutar.Text));
                kaydetFirHar.Parameters.AddWithValue("@Ffaturaid", txtFaturaID.Text);
                kaydetFirHar.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }

            if (cmbAliciTur.Text == "Tedarikçi")
            {
                //TEDARİKCİ HAREKET TABLOSUNA VERİ GİRİŞİ
                SqlCommand kaydetTedHar = new SqlCommand("insert into tbl_hareketlerTedarikci (PERSONEL, TEDARIKCI, TARIH, URUN, ADET, ALISFIYAT, TUTAR, FATURAID) values (@Tpersonel, @Ttedarikci, @Ttarih, @Turun, @Tadet, @Talis, @Ttutar, @Tfaturaid)", bgl.Baglanti());
                kaydetTedHar.Parameters.AddWithValue("@Tpersonel", lookPersonel.EditValue);
                kaydetTedHar.Parameters.AddWithValue("@Ttedarikci", lookAlici.EditValue);
                kaydetTedHar.Parameters.AddWithValue("@Ttarih", mskTarih.Text);
                kaydetTedHar.Parameters.AddWithValue("@Turun", lookUrun.EditValue);
                kaydetTedHar.Parameters.AddWithValue("@Tadet", int.Parse((nudAdet.Value).ToString()));
                kaydetTedHar.Parameters.AddWithValue("@Talis", decimal.Parse(txtFiyat.Text));
                kaydetTedHar.Parameters.AddWithValue("@Ttutar", decimal.Parse(txtTutar.Text));
                kaydetTedHar.Parameters.AddWithValue("@Tfaturaid", txtFaturaID.Text);
                kaydetTedHar.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }
        }

        void Stoklari_azaltma_artırma()
        {
            //FATURAYA URUN EKLENDIKCE STOK SAYISINI AZALTMA VEYA ARTIRMA
            if (cmbAliciTur.Text== "Müşteri" || cmbAliciTur.Text == "Firma")
            {
                SqlCommand stokguncelleme = new SqlCommand("Update tbl_urunler set ADET=ADET-@satilanAdet where ID=@id", bgl.Baglanti());
                stokguncelleme.Parameters.AddWithValue("@satilanAdet", int.Parse((nudAdet.Value).ToString()));
                stokguncelleme.Parameters.AddWithValue("@id", lookUrun.EditValue);
                stokguncelleme.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }
            if (cmbAliciTur.Text == "Tedarikçi")
            {
                SqlCommand stokguncelleme = new SqlCommand("Update tbl_urunler set ADET=ADET+@satilanAdet where ID=@id", bgl.Baglanti());
                stokguncelleme.Parameters.AddWithValue("@satilanAdet", int.Parse((nudAdet.Value).ToString()));
                stokguncelleme.Parameters.AddWithValue("@id", lookUrun.EditValue);
                stokguncelleme.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }
        }

        private void btnKaydetU_Click_1(object sender, EventArgs e)
        {
            //TUTAR HESAPLAMA
            double adet, fiyat, tutar;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            adet = Convert.ToDouble(nudAdet.Value);
            tutar = fiyat * adet;
            txtTutar.Text = tutar.ToString();

            //URUN DETAY KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_faturaUrunDetay (URUN, MARKA, ADET, FIYAT, TUTAR, FATURABID) values (@urun, @marka, @adet, @fiyat, @tutar, @faturaBid)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@urun", txtUrun.Text);
            kaydet.Parameters.AddWithValue("@marka", txtMarka.Text);
            kaydet.Parameters.AddWithValue("@adet", int.Parse((nudAdet.Value).ToString()));
            kaydet.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
            kaydet.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
            kaydet.Parameters.AddWithValue("@faturaBid", txtFaturaID.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaUrunDetay_Listele();

            Hareketler_kayıt();
            Stoklari_azaltma_artırma();

            MessageBox.Show("Ürün detayları sisteme eklendi.", "Fatura Ürün Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSilU_Click(object sender, EventArgs e)
        {
            //URUN DETAY SİLME  
            SqlCommand sil = new SqlCommand("Delete From tbl_faturaUrunDetay where FATURAURUNID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtUrunID.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaUrunDetay_Listele();
            MessageBox.Show("Ürün faturadan silindi.", "Faturadan Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtUrunID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtUrun.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            nudAdet.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            txtTutar.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            txtFaturaID.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGuncelleU_Click(object sender, EventArgs e)
        {
            //TUTAR HESAPLAMA
            double adet, fiyat, tutar;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            adet = Convert.ToDouble(nudAdet.Value);
            tutar = fiyat * adet;
            txtTutar.Text = tutar.ToString();

            //FATURA URUN DETAY GÜNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_faturaUrunDetay set URUN=@urun, MARKA=@marka, ADET=@adet, FIYAT=@fiyat, TUTAR=@tutar, FATURABID=@faturaBid Where FATURAURUNID=@id ", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@urun", txtUrun.Text);
            guncelle.Parameters.AddWithValue("@marka", txtMarka.Text);
            guncelle.Parameters.AddWithValue("@adet", int.Parse((nudAdet.Value).ToString()));
            guncelle.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
            guncelle.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
            guncelle.Parameters.AddWithValue("@faturaBid", txtFaturaID.Text);
            guncelle.Parameters.AddWithValue("@id", txtUrunID.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            FaturaUrunDetay_Listele();
            MessageBox.Show("Faturadaki ürün bilgileri güncellendi.", "Faturadaki Ürünü Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizleU_Click(object sender, EventArgs e)
        {
            //FATURA URUN DETAY ARAÇLARI TEMİZLEME
            txtUrunID.Text = "";
            lookUrun.EditValue = null;
            txtUrun.Text = "";
            txtMarka.Text = "";
            nudAdet.Value = 0;
            txtFiyat.Text = "0,00";
            txtTutar.Text = "0,00";
            txtFaturaID.Text = "";
        }
    }
}
