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
    public partial class frm_faturaUrunler : Form
    {
        public frm_faturaUrunler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string id;
        void Listele()
        {
            //FATURANIN URUN DETAYLARIN LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_faturaUrunDetay where FATURABID='"+id+"'", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frm_faturaUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
