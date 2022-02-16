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
    public partial class frm_notlar : Form
    {
        public frm_notlar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_notlar", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Olusturan_Listele()
        {
            //PERSONELLERİ LİSTELEME
            SqlCommand komutpersonel = new SqlCommand("Select ADSOYAD From tbl_personeller", bgl.Baglanti());
            SqlDataReader dr_personel = komutpersonel.ExecuteReader();
            while (dr_personel.Read())
            {
                cmbOlusturan.Properties.Items.Add(dr_personel[0]);
            }
            bgl.Baglanti().Close();
        }

        private void frm_notlar_Load(object sender, EventArgs e)
        {
            Listele();
            Olusturan_Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //NOT KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_notlar (OLUSTURAN, KIME, TARIH, SAAT, KONU, DETAY) values (@olusturan, @kime, @tarih, @saat, @konu, @detay)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@olusturan", cmbOlusturan.Text);
            kaydet.Parameters.AddWithValue("@kime", txtKime.Text);
            kaydet.Parameters.AddWithValue("@tarih", mskTarih.Text);
            kaydet.Parameters.AddWithValue("@saat", mskSaat.Text);
            kaydet.Parameters.AddWithValue("@konu", txtKonu.Text);
            kaydet.Parameters.AddWithValue("@detay", rchNot.Text);
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Not sisteme eklendi.", "Not Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //NOT SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_notlar where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Not silindi.", "Not Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbOlusturan.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKime.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            rchNot.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //NOT GUNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_notlar set OLUSTURAN=@olusturan, KIME=@kime, TARIH=@tarih, SAAT=@saat, KONU=@konu, DETAY=@detay Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@olusturan", cmbOlusturan.Text);
            guncelle.Parameters.AddWithValue("@kime", txtKime.Text);
            guncelle.Parameters.AddWithValue("@tarih", mskTarih.Text);
            guncelle.Parameters.AddWithValue("@saat", mskSaat.Text);
            guncelle.Parameters.AddWithValue("@konu", txtKonu.Text);
            guncelle.Parameters.AddWithValue("@detay", rchNot.Text);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Not bilgileri güncellendi.", "Not Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            cmbOlusturan.Text = "";
            txtKime.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtKonu.Text = "";
            rchNot.Text = "";
            cmbOlusturan.Focus();
        }
    }
}
