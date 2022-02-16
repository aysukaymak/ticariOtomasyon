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
    public partial class frm_giderler : Form
    {
        public frm_giderler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt_giderler = new DataTable();
            SqlDataAdapter da_giderler = new SqlDataAdapter("Select * from tbl_giderler", bgl.Baglanti());
            da_giderler.Fill(dt_giderler);
            dataGridView1.DataSource = dt_giderler;
        }

        private void frm_giderler_Load(object sender, EventArgs e)
        {
            txtElektrik.Text = "0,00";
            txtSu.Text = "0,00";
            txtDogalgaz.Text = "0,00";
            txtInternet.Text = "0,00";
            txtEkstra.Text = "0,00";
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //GİDER KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_giderler (AY, YIL, ELEKTRIK, SU, DOGALGAZ, INTERNET, EKSTRA, EKSTRADETAYI) values (@ay, @yil, @elektrik, @su, @dogalgaz, @internet, @ekstra, @detay)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@ay", cmbAy.Text);
            kaydet.Parameters.AddWithValue("@yil", cmbYil.Text);
            kaydet.Parameters.AddWithValue("@elektrik", decimal.Parse(txtElektrik.Text));
            kaydet.Parameters.AddWithValue("@su", decimal.Parse(txtSu.Text));
            kaydet.Parameters.AddWithValue("@dogalgaz", decimal.Parse(txtDogalgaz.Text));
            kaydet.Parameters.AddWithValue("@internet", decimal.Parse(txtInternet.Text));
            kaydet.Parameters.AddWithValue("@ekstra", decimal.Parse(txtEkstra.Text));
            kaydet.Parameters.AddWithValue("@detay", rchDetay.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Gider bilgisi eklendi.", "Gider Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //GİDER SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_giderler where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Gider silindi.", "Gider Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbAy.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbYil.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtElektrik.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSu.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtDogalgaz.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtInternet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtEkstra.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            rchDetay.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //GİDER GÜNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_giderler set AY=@ay, YIL=@yil, ELEKTRIK=@elektrik, SU=@su, DOGALGAZ=@dogalgaz, INTERNET=@internet, EKSTRA=@ekstra, EKSTRADETAYI=@detay Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@ay", cmbAy.Text);
            guncelle.Parameters.AddWithValue("@yil", cmbYil.Text);
            guncelle.Parameters.AddWithValue("@elektrik", decimal.Parse(txtElektrik.Text));
            guncelle.Parameters.AddWithValue("@su", decimal.Parse(txtSu.Text));
            guncelle.Parameters.AddWithValue("@dogalgaz", decimal.Parse(txtDogalgaz.Text));
            guncelle.Parameters.AddWithValue("@internet", decimal.Parse(txtInternet.Text));
            guncelle.Parameters.AddWithValue("@ekstra", decimal.Parse(txtEkstra.Text));
            guncelle.Parameters.AddWithValue("@detay", rchDetay.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Gider bilgileri güncellendi.", "Gider Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            cmbAy.Text = "";
            cmbYil.Text = "";
            txtElektrik.Text = "0,00";
            txtSu.Text = "0,00";
            txtDogalgaz.Text = "0,00";
            txtInternet.Text = "0,00";
            txtEkstra.Text = "0,00";
            rchDetay.Text = "";
            cmbAy.Focus();
        }
    }
}
