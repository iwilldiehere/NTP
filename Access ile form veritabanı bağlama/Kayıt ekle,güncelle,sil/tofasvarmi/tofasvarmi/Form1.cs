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
namespace tofasvarmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter data;
        DataTable dt;
        OleDbCommand command;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataDoldur();
        }

        private void dataDoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=okul1.accdb");
            data = new OleDbDataAdapter("select * from Ogretmen", con);
            dt = new DataTable();
            con.Open();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            command = new OleDbCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "insert into Ogretmen (Ad,Soyad,Sinif) values('"+txtAd.Text+"','"+txtSoyad.Text+"','"+txtSinif.Text+"')" ;
          command.ExecuteNonQuery();
                
                
                con.Close();
            dataDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "update Ogretmen set Ad='"+txtAd.Text+"',Soyad='"+txtSoyad.Text+"',Sinif='"+txtSinif.Text+"' where Kimlik="+txtKimlik.Text+"";
           
            command.ExecuteNonQuery();

             
            con.Close();
            dataDoldur();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSinif.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "delete from Ogretmen where Kimlik=" + txtKimlik.Text + "";
            command.ExecuteNonQuery();


            con.Close();
            dataDoldur();
        }
    }
}
