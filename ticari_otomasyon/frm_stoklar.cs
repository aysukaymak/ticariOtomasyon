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
    public partial class frm_stoklar : Form
    {
        public frm_stoklar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUN, sum(ADET) as 'ADET' from tbl_urunler group by URUN", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Stok_chart()
        {
            //STOKLARI CHARTA ÇEKME
            chartControl1.Series["Stoklar"].Points.Clear();
            SqlCommand chart = new SqlCommand("Select URUN, sum(ADET) as 'ADET' from tbl_urunler group by URUN", bgl.Baglanti());
            SqlDataReader dr = chart.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Stoklar"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
        }

        private void frm_stoklar_Load(object sender, EventArgs e)
        {
            Listele();
            Stok_chart();          
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //MARKALARI CHARTA ÇEKME
            chartControl2.Series["Markalar"].Points.Clear();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            SqlCommand chart = new SqlCommand("Select MARKA, sum(ADET) as 'ADET' from tbl_urunler where URUN=@urun group by MARKA", bgl.Baglanti());
            chart.Parameters.AddWithValue("@urun", label1.Text);
            SqlDataReader dr = chart.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["Markalar"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
            Stok_chart();
        }
    }
}
