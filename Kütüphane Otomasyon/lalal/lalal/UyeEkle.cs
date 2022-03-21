using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace lalal
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;Persist Security Info=False;");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Bilgiler(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okudugukitap) values (@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okudugukitap)", baglanti);         
            komut.Parameters.AddWithValue("@tc",txtTC.Text);
              komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
              komut.Parameters.AddWithValue("@yas", txtYas.Text.ToString());
              komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
              komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
              komut.Parameters.AddWithValue("@adres", txtAdres.Text);
              komut.Parameters.AddWithValue("@email", txtEmail.Text);
              komut.Parameters.AddWithValue("@okudugukitap", txtOkuduguKitap.Text);
              komut.ExecuteNonQuery();
              baglanti.Close();
              MessageBox.Show("Kayıt Sisteme Eklendi !!");
              foreach (Control item in Controls)
              {
                  if(item is TextBox)
                  {
                      if (item!=txtOkuduguKitap)
	                   {
                           item.Text = "";
	                   }
                     

                  }
              }
        }
    }
}
