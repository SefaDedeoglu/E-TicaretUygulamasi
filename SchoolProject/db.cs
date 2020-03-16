using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SchoolProject
{
    class db
    {
        public MySqlConnection baglan() // class içinde baglan adında fonksiyon oluşturduk
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=schoolproject;Uid=root;Pwd=;");
            //bağlantı yolunu verdik

            baglanti.Open();//bağlantıyı açtık
            MySqlConnection.ClearPool(baglanti);
            MySqlConnection.ClearAllPools();//bundan önceki bağlantıları temizledik
            return (baglanti);//çağırıldığı yere bağlantıyı yolladık
        }
        public MySqlConnection kapat()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=schoolproject;Uid=root;Pwd=;");
            baglanti.Close();
            return (baglanti);
        }
    }
}
