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
    public partial class frm_rehber : Form
    {
        public frm_rehber()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        void Musteri_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, ADSOYAD,  TELEFON, TELEFON2, MAIL from tbl_musteriler", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Firma_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD, YETKILIADSOYAD, YETKILISTATU, TELEFON1, TELEFON2, TELEFON3, FAX, MAIL from tbl_firmalar", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void Tedarikci_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD, YETKILIADSOYAD, YETKILISTATU, TELEFON1, TELEFON2, TELEFON3, FAX, MAIL from tbl_tedarikciler", bgl.Baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        void Banka_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select tbl_bankalar.ID, BANKAADI, YETKILI, YETKILITELEFON, YETKILIMAIL, AD as 'HESAPSAHIBI' from tbl_bankalar inner join tbl_tedarikciler on  tbl_bankalar.HESAPSAHIBI= tbl_tedarikciler.ID", bgl.Baglanti());
            da.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void frm_rehber_Load(object sender, EventArgs e)
        {
            Musteri_listele();
            Firma_listele();
            Tedarikci_listele();
            Banka_listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MÜSTERİ MAİLİNİ, MAİL FORMUNA AKTARMA
            frm_mail fr_mail = new frm_mail();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.Rows[secilen].Cells[0].Value != null)
            {
                fr_mail.mail = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); //dataggridden seçilen değeri frm_mail üzerinde tanımladığımız değişkene yazdırdık
            }
            fr_mail.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FİRMA MAİLİNİ, MAİL FORMUNA AKTARMA
            frm_mail fr_mail = new frm_mail();
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            if (dataGridView2.Rows[secilen].Cells[0].Value != null)
            {
                fr_mail.mail = dataGridView2.Rows[secilen].Cells[8].Value.ToString(); 
            }
            fr_mail.Show();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TEDARİKÇİ MAİLİNİ, MAİL FORMUNA AKTARMA
            frm_mail fr_mail = new frm_mail();
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            if (dataGridView3.Rows[secilen].Cells[0].Value != null)
            {
                fr_mail.mail = dataGridView3.Rows[secilen].Cells[8].Value.ToString();
            }
            fr_mail.Show();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //BANKA YETKILISI MAİLİNİ, MAİL FORMUNA AKTARMA
            frm_mail fr_mail = new frm_mail();
            int secilen = dataGridView4.SelectedCells[0].RowIndex;
            if (dataGridView4.Rows[secilen].Cells[0].Value != null)
            {
                fr_mail.mail = dataGridView4.Rows[secilen].Cells[4].Value.ToString();
            }
            fr_mail.Show();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri_listele();
            Firma_listele();
            Tedarikci_listele();
            Banka_listele();
        }
    }
}
