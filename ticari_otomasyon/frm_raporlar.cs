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
    public partial class frm_raporlar : Form
    {
        public frm_raporlar()
        {
            InitializeComponent();
        }

        private void frm_raporlar_Load(object sender, EventArgs e)
        {
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personellerTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_personeller);
            
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_giderlerTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_giderler);
            
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_faturaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_faturaBilgiTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_faturaBilgi);
            
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_tedarikciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_tedarikcilerTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_tedarikciler);
            
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_firmalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_firmalarTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_firmalar);
            
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_musterilerTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_musteriler);
           
            /// TODO: Bu kod satırı 'DboTicariOtomasyonDataSet.tbl_urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_urunlerTableAdapter.Fill(this.DboTicariOtomasyonDataSet.tbl_urunler);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
            this.reportViewer9.RefreshReport();
        }
    }
}
