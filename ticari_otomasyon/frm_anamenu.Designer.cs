
namespace ticari_otomasyon
{
    partial class frm_anamenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_anamenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnTedarikci = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnaSayfa,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnRehber,
            this.btnFaturalar,
            this.btnBankalar,
            this.btnGiderler,
            this.btnKasa,
            this.btnNotlar,
            this.btnPersoneller,
            this.btnAyarlar,
            this.btnHareketler,
            this.btnRaporlar,
            this.btnTedarikci,
            this.barButtonItem2,
            this.btnYenile});
            this.ribbonControl1.ItemsVertAlign = DevExpress.Utils.VertAlignment.Bottom;
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbonControl1.ShowSearchItem = true;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnAnaSayfa
            // 
            resources.ApplyResources(this.btnAnaSayfa, "btnAnaSayfa");
            this.btnAnaSayfa.Id = 2;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnAnaSayfa.ItemAppearance.Hovered.Font")));
            this.btnAnaSayfa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAnaSayfa.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnAnaSayfa.ItemAppearance.Normal.Font")));
            this.btnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnaSayfa.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnAnaSayfa.ItemAppearance.Pressed.Font")));
            this.btnAnaSayfa.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnUrunler
            // 
            resources.ApplyResources(this.btnUrunler, "btnUrunler");
            this.btnUrunler.Id = 3;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnUrunler.ItemAppearance.Hovered.Font")));
            this.btnUrunler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUrunler.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnUrunler.ItemAppearance.Normal.Font")));
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnUrunler.ItemAppearance.Pressed.Font")));
            this.btnUrunler.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            resources.ApplyResources(this.btnStoklar, "btnStoklar");
            this.btnStoklar.Id = 4;
            this.btnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.Image")));
            this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
            this.btnStoklar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnStoklar.ItemAppearance.Hovered.Font")));
            this.btnStoklar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnStoklar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnStoklar.ItemAppearance.Normal.Font")));
            this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStoklar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnStoklar.ItemAppearance.Pressed.Font")));
            this.btnStoklar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoklar_ItemClick);
            // 
            // btnMusteriler
            // 
            resources.ApplyResources(this.btnMusteriler, "btnMusteriler");
            this.btnMusteriler.Id = 5;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnMusteriler.ItemAppearance.Hovered.Font")));
            this.btnMusteriler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnMusteriler.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnMusteriler.ItemAppearance.Normal.Font")));
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnMusteriler.ItemAppearance.Pressed.Font")));
            this.btnMusteriler.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            resources.ApplyResources(this.btnFirmalar, "btnFirmalar");
            this.btnFirmalar.Id = 6;
            this.btnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.Image")));
            this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
            this.btnFirmalar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnFirmalar.ItemAppearance.Hovered.Font")));
            this.btnFirmalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFirmalar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnFirmalar.ItemAppearance.Normal.Font")));
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnFirmalar.ItemAppearance.Pressed.Font")));
            this.btnFirmalar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnRehber
            // 
            resources.ApplyResources(this.btnRehber, "btnRehber");
            this.btnRehber.Id = 7;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnRehber.ItemAppearance.Hovered.Font")));
            this.btnRehber.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRehber.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnRehber.ItemAppearance.Normal.Font")));
            this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRehber.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnRehber.ItemAppearance.Pressed.Font")));
            this.btnRehber.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnFaturalar
            // 
            resources.ApplyResources(this.btnFaturalar, "btnFaturalar");
            this.btnFaturalar.Id = 8;
            this.btnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.Image")));
            this.btnFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.LargeImage")));
            this.btnFaturalar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnFaturalar.ItemAppearance.Hovered.Font")));
            this.btnFaturalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFaturalar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnFaturalar.ItemAppearance.Normal.Font")));
            this.btnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFaturalar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnFaturalar.ItemAppearance.Pressed.Font")));
            this.btnFaturalar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturalar_ItemClick);
            // 
            // btnBankalar
            // 
            resources.ApplyResources(this.btnBankalar, "btnBankalar");
            this.btnBankalar.Id = 9;
            this.btnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.Image")));
            this.btnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.LargeImage")));
            this.btnBankalar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnBankalar.ItemAppearance.Hovered.Font")));
            this.btnBankalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnBankalar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnBankalar.ItemAppearance.Normal.Font")));
            this.btnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBankalar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnBankalar.ItemAppearance.Pressed.Font")));
            this.btnBankalar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
            // 
            // btnGiderler
            // 
            resources.ApplyResources(this.btnGiderler, "btnGiderler");
            this.btnGiderler.Id = 10;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
            this.btnGiderler.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnGiderler.ItemAppearance.Hovered.Font")));
            this.btnGiderler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnGiderler.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnGiderler.ItemAppearance.Normal.Font")));
            this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGiderler.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnGiderler.ItemAppearance.Pressed.Font")));
            this.btnGiderler.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnKasa
            // 
            resources.ApplyResources(this.btnKasa, "btnKasa");
            this.btnKasa.Id = 11;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnKasa.ItemAppearance.Hovered.Font")));
            this.btnKasa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnKasa.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnKasa.ItemAppearance.Normal.Font")));
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnKasa.ItemAppearance.Pressed.Font")));
            this.btnKasa.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // btnNotlar
            // 
            resources.ApplyResources(this.btnNotlar, "btnNotlar");
            this.btnNotlar.Id = 12;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnNotlar.ItemAppearance.Hovered.Font")));
            this.btnNotlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnNotlar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnNotlar.ItemAppearance.Normal.Font")));
            this.btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotlar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnNotlar.ItemAppearance.Pressed.Font")));
            this.btnNotlar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnPersoneller
            // 
            resources.ApplyResources(this.btnPersoneller, "btnPersoneller");
            this.btnPersoneller.Id = 13;
            this.btnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.Image")));
            this.btnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.LargeImage")));
            this.btnPersoneller.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnPersoneller.ItemAppearance.Hovered.Font")));
            this.btnPersoneller.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPersoneller.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnPersoneller.ItemAppearance.Normal.Font")));
            this.btnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersoneller.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnPersoneller.ItemAppearance.Pressed.Font")));
            this.btnPersoneller.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
            // 
            // btnAyarlar
            // 
            resources.ApplyResources(this.btnAyarlar, "btnAyarlar");
            this.btnAyarlar.Id = 14;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnAyarlar.ItemAppearance.Hovered.Font")));
            this.btnAyarlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAyarlar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnAyarlar.ItemAppearance.Normal.Font")));
            this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAyarlar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnAyarlar.ItemAppearance.Pressed.Font")));
            this.btnAyarlar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // btnHareketler
            // 
            resources.ApplyResources(this.btnHareketler, "btnHareketler");
            this.btnHareketler.Id = 16;
            this.btnHareketler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHareketler.ImageOptions.Image")));
            this.btnHareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHareketler.ImageOptions.LargeImage")));
            this.btnHareketler.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnHareketler.ItemAppearance.Hovered.Font")));
            this.btnHareketler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnHareketler.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnHareketler.ItemAppearance.Normal.Font")));
            this.btnHareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHareketler.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnHareketler.ItemAppearance.Pressed.Font")));
            this.btnHareketler.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnHareketler.Name = "btnHareketler";
            this.btnHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHareketler_ItemClick);
            // 
            // btnRaporlar
            // 
            resources.ApplyResources(this.btnRaporlar, "btnRaporlar");
            this.btnRaporlar.Id = 17;
            this.btnRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.Image")));
            this.btnRaporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.LargeImage")));
            this.btnRaporlar.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnRaporlar.ItemAppearance.Hovered.Font")));
            this.btnRaporlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRaporlar.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnRaporlar.ItemAppearance.Normal.Font")));
            this.btnRaporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRaporlar.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnRaporlar.ItemAppearance.Pressed.Font")));
            this.btnRaporlar.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporlar_ItemClick);
            // 
            // btnTedarikci
            // 
            resources.ApplyResources(this.btnTedarikci, "btnTedarikci");
            this.btnTedarikci.Id = 18;
            this.btnTedarikci.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikci.ImageOptions.Image")));
            this.btnTedarikci.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTedarikci.ImageOptions.LargeImage")));
            this.btnTedarikci.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btnTedarikci.ItemAppearance.Hovered.Font")));
            this.btnTedarikci.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnTedarikci.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btnTedarikci.ItemAppearance.Normal.Font")));
            this.btnTedarikci.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTedarikci.ItemAppearance.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("btnTedarikci.ItemAppearance.Pressed.Font")));
            this.btnTedarikci.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTedarikci_ItemClick);
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnYenile
            // 
            resources.ApplyResources(this.btnYenile, "btnYenile");
            this.btnYenile.Id = 20;
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Name = "btnYenile";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup7,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTedarikci);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnHareketler);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRaporlar);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_anamenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frm_anamenu";
            this.Load += new System.EventHandler(this.frm_anamenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHareketler;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnTedarikci;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
    }
}

