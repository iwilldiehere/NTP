﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace StokTakip
{
    public partial class MüşteriListeleme : Form
    {
        public MüşteriListeleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StokTkp.accdb;Persist Security Info=False;");
        DataSet daset = new DataSet();
        
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
          daset.Tables["müşteri"].Clear();
          KayıtGoster();
            MessageBox.Show("Müşteri Güncellendi");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
        }

        private void MüşteriListeleme_Load(object sender, EventArgs e)
        {
            KayıtGoster();
        }

        private void KayıtGoster()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text=dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from müşteri where tc='"+dataGridView1.CurrentRow.Cells["tc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            KayıtGoster();
            MessageBox.Show("Kayıt silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from müşteri where  tc like '%"+txtTcAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close(); 

        }
    }
}
