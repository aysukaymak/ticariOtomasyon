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
    public partial class frm_anasayfa : Form
    {
        public frm_anasayfa()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Azalan_stoklar()
        {
            //AZALAN STOKLARI LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUN, Sum(ADET) as 'ADET' From tbl_urunler group by URUN having Sum(ADET)<=20 order by Sum(ADET)", bgl.Baglanti());
            da.Fill(dt);
            gridAzalanStoklar.DataSource = dt;
        }

        void Marka_Azalan_stoklar()
        {
            //MARKALARA GÖRE AZALAN STOKLARI LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUN, MARKA, Sum(ADET) as 'ADET' from tbl_urunler group by MARKA, URUN having Sum(ADET)<=5 order by Sum(ADET)", bgl.Baglanti());
            da.Fill(dt);
            gridMarkalaraGoreStoklar.DataSource = dt;
        }

        void Satis_sorumlulari()
        {
            //SATIS SORUMLULARINI LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute SatisSorumlusuAnasayfa", bgl.Baglanti());
            da.Fill(dt);
            gridSatisSorumlulari.DataSource = dt;
        }

        private void frm_anasayfa_Load(object sender, EventArgs e)
        {
            Azalan_stoklar();
            Satis_sorumlulari();
            Marka_Azalan_stoklar();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Azalan_stoklar();
            Satis_sorumlulari();
            Marka_Azalan_stoklar();
        }
    }
}
