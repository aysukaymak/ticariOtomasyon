using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //sql sorgularını kullanabilmek için gerekli olan kütüphane

namespace ticari_otomasyon
{
    class SqlBaglanti
    {
        public SqlConnection Baglanti() //sqlconnection sınfından Baglanti adında geriye değer döndüren bir metot oluşturduk
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-9D4ELC7;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            //sqlconnection sınıfından bir nesne türettik ve onu veritabanına bağladık
            baglan.Open(); //veritabani bağlantısını open metodu ile bellekte açtık
            return baglan;
        }
    }
}
