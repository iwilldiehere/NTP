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
namespace Pizzacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbDataAdapter adtr;
        DataTable dt;
        OleDbCommand command;
        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }
        private void datadoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Pizzacı.accdb");
            adtr = new OleDbDataAdapter("select * from Bilgiler", baglanti);
            dt = new DataTable();
            baglanti.Open();
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datadoldur();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           baglanti.Open();
           OleDbCommand komut = new OleDbCommand("insert into Bilgiler(adsoyad,telefon,adres,pizzaboy,icecek,barkodno) values (@adsoyad,@telefon,@adres,@pizzaboy,@icecek,@barkodno)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad",txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@pizzaboy", cmbPizzaBoy.Text);
            komut.Parameters.AddWithValue("@icecek", cmbİçecek.Text);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNO.Text);
            komut.ExecuteNonQuery();

       
        baglanti.Close();
        datadoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtBarkodNO.Clear();
            cmbPizzaBoy.Text = "";
            cmbİçecek.Text = "";

          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bu kayıtı silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("delete from Bilgiler where barkodno=@barkodno", baglanti);
                    komut.Parameters.AddWithValue("barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    DialogResult dia;
                    dia = MessageBox.Show("Silme işlemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datadoldur();
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                            cmbİçecek.Text = "";
                            cmbPizzaBoy.Text = "";
                        }   
                    }





                }


            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbPizzaBoy.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbİçecek.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBarkodNO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

          


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
           command = new OleDbCommand();
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = " update  Bilgiler set adsoyad='" + txtAdSoyad.Text + "', telefon='" + txtTelefon.Text + "',pizzaboy='" + cmbPizzaBoy.Text + "' ,icecek='" + cmbİçecek.Text + "' where barkodno='"+ txtBarkodNO.Text + "'   ";
            command.ExecuteNonQuery();
            baglanti.Close();
            datadoldur();
            baglanti.Close();
        }
    }
}
