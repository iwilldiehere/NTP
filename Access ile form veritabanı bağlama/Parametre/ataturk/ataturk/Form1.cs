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
namespace ataturk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
         DataTable dt;
         OleDbCommand command;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void GridDoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Basvuru.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Bilgiler ", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "insert into Bilgiler(Adı,Soyadı,Dogum_Tarihi,Kardes_Sayisi,Cinsiyet,Not_Ortalamasi,Aylik_Gelir,Egitim_Durumu,Basvuru) values (@Adi,@Soyadi,@DogumTarihi,@KardesSayisi,@Cinsiyet,@NotOrtalamasi,@AylikGelir,@EgitimDurumu,@Basvuru)";
           //@Adi,@Soyadi,@DogumTarihi,@KardesSayisi,@Cinsiyet,@NotOrtalamasi,@AylikGelir,@EgitimDurumu,@Basvuru
            command.Parameters.AddWithValue("@Adi", txtAd.Text);
            command.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
            command.Parameters.AddWithValue("@DogumTarihi", dtp.Value.ToShortDateString());
            command.Parameters.AddWithValue("@KardesSayisi", int.Parse(txtKardeş.Text));
            if (rbErkek.Checked)
                command.Parameters.AddWithValue("@Cinsiyet", "Erkek");
            else
                command.Parameters.AddWithValue("@Cinsiyet", "Kadın");
            command.Parameters.AddWithValue("@NotOrtalamasi", double.Parse(txtOrtalama.Text));
            command.Parameters.AddWithValue("@AylikGelir", decimal.Parse(txtAylikGelir.Text));
            command.Parameters.AddWithValue("@EgitimDurumu", cbEgitimDurumu.SelectedItem.ToString());
            if (cbBasvuru.Checked)
                command.Parameters.AddWithValue("@Basvuru", true);
            else
                command.Parameters.AddWithValue("@Basvuru", false);
            
            
            command.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

 
      
    }
}
