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
    public partial class frm_hareketler : Form
    {
        public frm_hareketler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void MusteriHareketler_listele()
        {
            //MUSTERİ HAREKETLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketleri", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void FirmaHareketler_listele()
        {
            //FİRMA HAREKETLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketleri", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void TedarikciHareketler_listele()
        {
            //TEDARİKCİ HAREKETLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute TedarikciHareketleri", bgl.Baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void frm_hareketler_Load(object sender, EventArgs e)
        {
            MusteriHareketler_listele();
            FirmaHareketler_listele();
            TedarikciHareketler_listele();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SAYFA YENİLEME
            MusteriHareketler_listele();
            FirmaHareketler_listele();
            TedarikciHareketler_listele();
        }
    }
}
