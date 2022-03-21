using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lalal
{
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kutuphane.accdb;Persist Security Info=False;");
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Bilgiler where tc like '"+txtTC.Text+"'"  ,baglanti );
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text=read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                cmbCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtOkuduguKitap.Text = read["okudugukitap"].ToString();
            }
            baglanti.Close();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString(); 
        }

        DataSet daset = new DataSet();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Bilgiler"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Bilgiler where tc like '*"+txtAra.Text+ "*'",baglanti);
            adtr.Fill(daset, "Bilgiler");
            dataGridView1.DataSource=daset.Tables["Bilgiler"];
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Bilgiler where tc =@tc",baglanti);
            komut.Parameters.AddWithValue("@tc",dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılır!");
            daset.Tables["Bilgiler"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void uyelistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Bilgiler ", baglanti);
        adtr.Fill(daset,"Bilgiler");
        dataGridView1.DataSource = daset.Tables["Bilgiler"];
        baglanti.Close();
        }
        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Bilgiler set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okudugukitap=@okudugukitap where tc=@tc", baglanti);
            //adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okudugukitap=@okudugukitap where tc=@tc"
            komut.Parameters.AddWithValue("@tc",txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okudugukitap", int.Parse(txtOkuduguKitap.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            //https://youtu.be/yXdovxYlr7A?t=4638
        }



    }
}
