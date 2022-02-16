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
using DevExpress.Charts;

namespace ticari_otomasyon
{
    public partial class frm_kasa : Form
    {
        public frm_kasa()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Musterihareket_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareketleri", bgl.Baglanti());
            da.Fill(dt);
            gridMusteri.DataSource = dt;
        }

        void FirmaHareket_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareketleri", bgl.Baglanti());
            da.Fill(dt);
            gridFirma.DataSource = dt;
        }

        void TedarikciHareket_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute TedarikciHareketleri", bgl.Baglanti());
            da.Fill(dt);
            gridTedarikci.DataSource = dt;
        }

        void Giderler_Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_giderler", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void Kazanilan_tutar()
        {
            //KAZANILAN TUTARI YAZDIRMA
            SqlCommand kazanilan = new SqlCommand("Select Sum(TUTAR) from tbl_faturaUrunDetay", bgl.Baglanti());
            SqlDataReader dr = kazanilan.ExecuteReader();
            while (dr.Read())
            {
                lblKazanilan.Text = dr[0].ToString() + "TL";
            }
            bgl.Baglanti().Close();
        }

        void Fatura_odemeler()
        {
            //FATURA ÖDEMELERİ YAZDIRMA
            SqlCommand fatura = new SqlCommand("Select (ELEKTRIK + SU + DOGALGAZ + INTERNET + EKSTRA) from tbl_giderler order by ID asc", bgl.Baglanti()); //order by ID asc girdiğimiz son ayın yani son ıd değerine sahip giderlerin toplamını getirecek
            SqlDataReader dr = fatura.ExecuteReader();
            while (dr.Read())
            {
                lblOdemeler.Text = dr[0].ToString() + "TL";
            }
            bgl.Baglanti().Close();
        }

        void Urun_odemeler()
        {
            //URUNLERİN ALIS FIYATLARINI YAZDIRMA
            SqlCommand urun = new SqlCommand("Select Sum(ALISFIYAT) from tbl_urunler", bgl.Baglanti()); 
            SqlDataReader dr = urun.ExecuteReader();
            while (dr.Read())
            {
                lblAlisUrun.Text = dr[0].ToString() + "TL";
            }
            bgl.Baglanti().Close();
        }

        void Maaslar()
        {
            //PERSONEL MAAŞLARINI YAZDIRMA
            SqlCommand maas = new SqlCommand("Select Sum(MAAS) from tbl_personeller", bgl.Baglanti());
            SqlDataReader dr = maas.ExecuteReader();
            while (dr.Read())
            {
                lblMaas.Text = dr[0].ToString() + "TL";
            }
            bgl.Baglanti().Close();
        }

        void Personel_sayisi()
        {
            //PERSONEL SAYISINI YAZDIRMA
            SqlCommand personel = new SqlCommand("Select Count(*) from tbl_personeller", bgl.Baglanti());
            SqlDataReader dr = personel.ExecuteReader();
            while (dr.Read())
            {
                lblPersonel.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        void Musteri_sayisi()
        {
            //MUSTERİ SAYISINI YAZDIRMA
            SqlCommand musteri = new SqlCommand("Select Count(*) from tbl_musteriler", bgl.Baglanti());
            SqlDataReader dr = musteri.ExecuteReader();
            while (dr.Read())
            {
                lblMusteri.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        void Firma_sayisi()
        {
            //FİRMA SAYISINI YAZDIRMA
            SqlCommand firma = new SqlCommand("Select Count(*) from tbl_firmalar", bgl.Baglanti());
            SqlDataReader dr = firma.ExecuteReader();
            while (dr.Read())
            {
                lblFirma.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        void Tedarikci_sayisi()
        {
            //TEDARİKCİ SAYİSİNİ LİSTELEME
            SqlCommand tedarikci = new SqlCommand("Select Count(*) from tbl_tedarikciler", bgl.Baglanti());
            SqlDataReader dr = tedarikci.ExecuteReader();
            while (dr.Read())
            {
                lblTedarikci.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        void Stok()
        {
            //TOPLAM STOĞU YAZDIRMA
            SqlCommand stok = new SqlCommand("Select Sum(ADET) from tbl_urunler", bgl.Baglanti());
            SqlDataReader dr = stok.ExecuteReader();
            while (dr.Read())
            {
                lblStok.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
        }

        void Elektrik_chart()
        {
            //ELEKTRIK FATURASINI CHARTA AKTARMA
            SqlCommand elektrik = new SqlCommand("Select top 6 AY, ELEKTRIK from tbl_giderler order by ID Desc", bgl.Baglanti());
                                                         //top 12 son 12 girdiyi listelemeyi sağlayacak
                                                         //order by ID desc de sondan başa doğru listelemeyi sağlıyor
            SqlDataReader dr= elektrik.ExecuteReader();
            while (dr.Read())
            {
                chartelektrik.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));                                                         
            }
            bgl.Baglanti().Close();
        }

        void Su_chart()
        {
            //ELEKTRIK FATURASINI CHARTA AKTARMA
            SqlCommand su = new SqlCommand("Select top 6 AY, SU from tbl_giderler order by ID Desc", bgl.Baglanti());
            SqlDataReader dr = su.ExecuteReader();
            while (dr.Read())
            {
                chartSu.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            bgl.Baglanti().Close();
        }

        void Dogalgaz_chart()
        {
            //ELEKTRIK FATURASINI CHARTA AKTARMA
            SqlCommand dogalgaz = new SqlCommand("Select top 6 AY, DOGALGAZ from tbl_giderler order by ID Desc", bgl.Baglanti());
            SqlDataReader dr = dogalgaz.ExecuteReader();
            while (dr.Read())
            {
                chartDogalgaz.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            bgl.Baglanti().Close();
        }

        void Internet_chart()
        {
            //ELEKTRIK FATURASINI CHARTA AKTARMA
            SqlCommand internet = new SqlCommand("Select top 6 AY, INTERNET from tbl_giderler order by ID Desc", bgl.Baglanti());
            SqlDataReader dr = internet.ExecuteReader();
            while (dr.Read())
            {
                chartInternet.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            bgl.Baglanti().Close();
        }

        void Ekstra_chart()
        {
            //ELEKTRIK FATURASINI CHARTA AKTARMA
            SqlCommand ekstra = new SqlCommand("Select top 6 AY, EKSTRA from tbl_giderler order by ID Desc", bgl.Baglanti());
            SqlDataReader dr = ekstra.ExecuteReader();
            while (dr.Read())
            {
                chartEkstra.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
            bgl.Baglanti().Close();
        }

        void Tedarikci_chart()
        {
            //TEDARİKCİ ODEMELERİNİ CHARTA AKTARMA
            SqlCommand chart = new SqlCommand("Select AD as 'TEDARIKCI', sum(ALISFIYAT) as 'ODEMELER' from tbl_urunler inner join tbl_tedarikciler on  tbl_urunler.TEDARIKCIID=tbl_tedarikciler.ID group by AD", bgl.Baglanti());
            SqlDataReader dr = chart.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Tedarikçiler"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
            }
        }

        public string ad;
        private void frm_kasa_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = ad; //admin>anamenü>kasa

            Musterihareket_Listele();
            FirmaHareket_Listele();
            TedarikciHareket_Listele();
            Giderler_Listele();

            Kazanilan_tutar();
            Fatura_odemeler();
            Urun_odemeler();
            Maaslar();

            Personel_sayisi();
            Musteri_sayisi();
            Firma_sayisi();
            Tedarikci_sayisi();

            Stok();

            Elektrik_chart();
            Su_chart();
            Dogalgaz_chart();
            Internet_chart();
            Ekstra_chart();
            Tedarikci_chart();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SAYFA YENİLEME
            Musterihareket_Listele();
            FirmaHareket_Listele();
            TedarikciHareket_Listele();
            Giderler_Listele();

            Kazanilan_tutar();
            Fatura_odemeler();
            Urun_odemeler();
            Maaslar();

            Personel_sayisi();
            Musteri_sayisi();
            Firma_sayisi();
            Tedarikci_sayisi();

            Stok();

            Elektrik_chart();
            Su_chart();
            Dogalgaz_chart();
            Internet_chart();
            Ekstra_chart();
            Tedarikci_chart();
        }
    }
}
