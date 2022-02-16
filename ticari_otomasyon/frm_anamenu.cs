using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticari_otomasyon
{
    public partial class frm_anamenu : Form
    {
        public frm_anamenu()
        {
            InitializeComponent();
        }

        frm_urunler fr_urun;//global alanda bir nesne tanımladık
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (fr_urun == null || fr_urun.IsDisposed) //bu koşul ürünler sekmesinin birden fazla açılmasını engeller frm nesnesine daha komutverilmemişse, atama yapılmamışsa anlamında çünkü aşağıdaki komutlar girilince null olmaktan çıkacak
            {                                          //IsDisposed komutuda daha önce açılıp kapandıysa anlamında
                fr_urun = new frm_urunler(); 
                fr_urun.MdiParent = this; //frmyi şu an üzerinde çalışılan(this) Mdi'da aç
                fr_urun.Show(); //frmyi göster
            }
        }

        frm_musteriler fr_musteri; 
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_musteri == null || fr_musteri.IsDisposed)
            {
                fr_musteri = new frm_musteriler();
                fr_musteri.MdiParent = this;
                fr_musteri.Show(); 
            }
        }

        frm_firmalar fr_firmalar;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_firmalar == null || fr_firmalar.IsDisposed)
            {
                fr_firmalar = new frm_firmalar();
                fr_firmalar.MdiParent = this;
                fr_firmalar.Show();
            }
        }

        frm_personeller fr_personeller;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_personeller == null || fr_personeller.IsDisposed) 
            {
                fr_personeller = new frm_personeller();
                fr_personeller.MdiParent = this;
                fr_personeller.Show();
            }
        }

        frm_rehber fr_rehber;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_rehber == null || fr_rehber.IsDisposed)
            {
                fr_rehber = new frm_rehber();
                fr_rehber.MdiParent = this;
                fr_rehber.Show();
            }
        }

        frm_giderler fr_giderler;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_giderler == null || fr_giderler.IsDisposed)
            {
                fr_giderler = new frm_giderler();
                fr_giderler.MdiParent = this;
                fr_giderler.Show();
            }
        }

        frm_bankalar fr_bankalar;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_bankalar == null || fr_bankalar.IsDisposed)
            {
                fr_bankalar = new frm_bankalar();
                fr_bankalar.MdiParent = this;
                fr_bankalar.Show();
            }
        }

        frm_faturalar fr_faturalar;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_faturalar == null || fr_faturalar.IsDisposed)
            {
                fr_faturalar = new frm_faturalar();
                fr_faturalar.MdiParent = this;
                fr_faturalar.Show();
            }
        }

        frm_notlar fr_notlar;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_notlar == null || fr_notlar.IsDisposed)
            {
                fr_notlar = new frm_notlar();
                fr_notlar.MdiParent = this;
                fr_notlar.Show();
            }
        }

        frm_hareketler fr_hareketler;
        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_hareketler == null || fr_hareketler.IsDisposed)
            {
                fr_hareketler = new frm_hareketler();
                fr_hareketler.MdiParent = this;
                fr_hareketler.Show();
            }
        }

        frm_raporlar fr_raporlar;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_raporlar == null || fr_raporlar.IsDisposed)
            {
                fr_raporlar = new frm_raporlar();
                fr_raporlar.MdiParent = this;
                fr_raporlar.Show();
            }
        }

        frm_stoklar fr_stoklar;
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_stoklar == null ||fr_stoklar.IsDisposed)
            {
                fr_stoklar = new frm_stoklar();
                fr_stoklar.MdiParent = this;
                fr_stoklar.Show();
            }
        }

        public string Kullanici;
        public string KulSifre;
        frm_ayarlar fr_ayarlar;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_ayarlar == null || fr_ayarlar.IsDisposed)
            {
                fr_ayarlar = new frm_ayarlar();
                fr_ayarlar.ad = Kullanici; //admin modülünden aldığımız kullanıcı adı ve şifreyi ayarlar modülüne taşıdık
                fr_ayarlar.sifre = KulSifre;
                fr_ayarlar.Show();
            }
        }

        frm_kasa fr_kasa;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_kasa == null || fr_kasa.IsDisposed)
            {
                fr_kasa = new frm_kasa();
                fr_kasa.ad = Kullanici; //adminden modülünden aldığımız kullanıcı adını kasa modülüne taşıdık
                fr_kasa.MdiParent = this;
                fr_kasa.Show();
            }
        }

        frm_anasayfa fr_anasayfa; 
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_anasayfa == null || fr_anasayfa.IsDisposed)
            {
                fr_anasayfa = new frm_anasayfa();
                fr_anasayfa.MdiParent = this;
                fr_anasayfa.Show();
            }
        }

        private void frm_anamenu_Load(object sender, EventArgs e)
        {
            if (fr_anasayfa == null)
            {
                fr_anasayfa = new frm_anasayfa();
                fr_anasayfa.MdiParent = this;
                fr_anasayfa.Show();
            }
        }

        frm_tedarikciler fr_tedarikciler;
        private void btnTedarikci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr_tedarikciler == null || fr_tedarikciler.IsDisposed)
            {
                fr_tedarikciler = new frm_tedarikciler();
                fr_tedarikciler.MdiParent = this;
                fr_tedarikciler.Show();
            }
        }
    }
}
