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
    public partial class frm_bankalar : Form
    {
        public frm_bankalar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute TedarikciBanka", bgl.Baglanti()); //sql prosedürü kullandık
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Sehir_listesi()
        {
            //İLLERİ LİSTELEME
            SqlCommand komutsehir = new SqlCommand("Select SEHIR From tbl_iller", bgl.Baglanti());
            SqlDataReader dr_sehir = komutsehir.ExecuteReader();
            while (dr_sehir.Read())
            {
                cmbIl.Properties.Items.Add(dr_sehir[0]);
            }
            bgl.Baglanti().Close();
        }

        private void cmbIl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //İLÇELERİ LİSTELEME
            cmbIlce.Properties.Items.Clear();
            SqlCommand komutilce = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@sehir", bgl.Baglanti());
            komutilce.Parameters.AddWithValue("@sehir", cmbIl.SelectedIndex + 1);
            SqlDataReader dr_ilce = komutilce.ExecuteReader();
            while (dr_ilce.Read())
            {
                cmbIlce.Properties.Items.Add(dr_ilce[0]);
            }
            bgl.Baglanti().Close();
        }

        void Tedarikci_listele()
        {
            //TEDARİKCİLERİ LİSTELEME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from tbl_tedarikciler", bgl.Baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void frm_bankalar_Load(object sender, EventArgs e)
        {
            Listele();
            Sehir_listesi();
            Tedarikci_listele();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            //BANKA KAYDETME
            SqlCommand kaydet = new SqlCommand("insert into tbl_bankalar (BANKAADI, SUBE, IL, ILCE, IBAN, HESAPNO, YETKILI, YETKILITELEFON, YETKILIMAIL, HESAPTURU, HESAPSAHIBI) values (@banka, @sube, @il, @ilce, @iban, @hesapno, @yetkili, @ytel, @ymail, @hesapturu, @hesapsahibi)", bgl.Baglanti());
            kaydet.Parameters.AddWithValue("@banka", txtBanka.Text);
            kaydet.Parameters.AddWithValue("@sube", txtSube.Text);
            kaydet.Parameters.AddWithValue("@il", cmbIl.Text);
            kaydet.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            kaydet.Parameters.AddWithValue("@iban", mskIban.Text);
            kaydet.Parameters.AddWithValue("@hesapno", mskHesapNo.Text);
            kaydet.Parameters.AddWithValue("@yetkili", txtYetkili.Text);
            kaydet.Parameters.AddWithValue("@ytel", mskTel.Text);
            kaydet.Parameters.AddWithValue("@ymail", txtMail.Text);
            kaydet.Parameters.AddWithValue("@hesapturu", txtTur.Text);
            kaydet.Parameters.AddWithValue("@hesapsahibi", lookUpEdit1.EditValue); //lookup'daki düzenlenecek değer
            kaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Banka bilgileri sisteme eklendi.", "Banka Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            //BANKA SİLME
            SqlCommand sil = new SqlCommand("Delete From tbl_bankalar where ID=@id", bgl.Baglanti());
            sil.Parameters.AddWithValue("@id", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Banka silindi.", "Banka Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN ARAÇLARA VERİ TAŞIMA
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBanka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSube.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskIban.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskHesapNo.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtYetkili.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            lookUpEdit1.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            //BANKA GUNCELLEME
            SqlCommand guncelle = new SqlCommand("Update tbl_bankalar set BANKAADI=@banka,SUBE=@sube, IL=@il, ILCE=@ilce, IBAN=@iban, HESAPNO=@hesapno, YETKILI=@yetkili, YETKILITELEFON=@ytel, YETKILIMAIL=@ymail, HESAPTURU=@hesapturu, HESAPSAHIBI=@hesapsahibi Where ID=@id", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@banka", txtBanka.Text);
            guncelle.Parameters.AddWithValue("@sube", txtSube.Text);
            guncelle.Parameters.AddWithValue("@il", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@iban", mskIban.Text);
            guncelle.Parameters.AddWithValue("@hesapno", mskHesapNo.Text);
            guncelle.Parameters.AddWithValue("@yetkili", txtYetkili.Text);
            guncelle.Parameters.AddWithValue("@ytel", mskTel.Text);
            guncelle.Parameters.AddWithValue("@ymail", txtMail.Text);
            guncelle.Parameters.AddWithValue("@hesapturu", txtTur.Text);
            guncelle.Parameters.AddWithValue("@hesapsahibi", lookUpEdit1.EditValue);
            guncelle.Parameters.AddWithValue("@id", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            Listele();
            MessageBox.Show("Banka bilgileri güncellendi.", "Banka Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            //ARAÇLARI TEMİZLEME
            txtId.Text = "";
            txtBanka.Text = "";
            txtSube.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            mskIban.Text = "";
            mskHesapNo.Text = "";
            txtYetkili.Text = "";
            mskTel.Text = "";
            txtMail.Text = "";
            //txtTur.Text = "";
            lookUpEdit1.EditValue = null;
            txtBanka.Focus();
        }


    }
}
