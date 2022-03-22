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
namespace telefon_otom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        güncelle();
        OleDbCommand command;
        }

private void güncelle()
{
         DataTable dt = new DataTable();
            adtr= new OleDbDataAdapter("select * from Rehber", baglanti);

            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
}
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=False;");
        OleDbDataAdapter adtr;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
                baglanti.Open();
            try
            {
                OleDbCommand komut = new OleDbCommand("insert into Rehber(numara,adı,soyadı,telefonu) values (@numara,@adı,@soyadı,@telefonu)", baglanti);
                DataTable ekl = new DataTable();
                komut.Parameters.AddWithValue("@numara", txtÖğrenciNO.Text);
                komut.Parameters.AddWithValue("@adı", txtAdı.Text);
                komut.Parameters.AddWithValue("@soyadı", txtSoyadı.Text);
                komut.Parameters.AddWithValue("@telefonu", txtTelefon.Text);
                komut.ExecuteNonQuery();
                güncelle();
                DialogResult dialog;
                dialog = MessageBox.Show("Üye sisteme eklenmiştir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Question);
                
            }
            catch (Exception)
            {

                DialogResult dialog;
                dialog = MessageBox.Show("Zaten bu numaraya sahip bir öğrenci mevcut", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }
          finally
            {

            }
                baglanti.Close();

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtÖğrenciNO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
           
            command.Connection = baglanti;
            command.CommandText = " update Rehber set adı='" + txtAdı.Text + "', soyadı='" + txtSoyadı.Text + "',telefonu='" + txtTelefon.Text + "' where numara='" + txtÖğrenciNO.Text + "'   ";
            command.ExecuteNonQuery();
            baglanti.Close();
            gridDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kayıtı silmek istiyor musunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Rehber where numara=@numara", baglanti);
            komut.Parameters.AddWithValue("numara",dataGridView1.CurrentRow.Cells["numara"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        DialogResult dia;
               dia= MessageBox.Show("Silme işlemi başarılı","Silindi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            güncelle();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        

                
            
            
            }
            
            
        }

        DataSet daset = new DataSet();
        private void txtİsimeGöreAra_TextChanged(object sender, EventArgs e)
        {

            daset.Tables["Rehber"].Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Rehber where numara like '%" + txtÖğrenciNO.Text + "%'", baglanti);
            adtr.Fill(daset, "Rehber");
            dataGridView1.DataSource = daset.Tables["Rehber"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtÖğrenciNO_TextChanged(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void gridDoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database2.accdb");
            OleDbDataAdapter dataAtapter = new OleDbDataAdapter("select * from Rehber", baglanti);
            DataTable table = new DataTable();
            baglanti.Open();
            dataAtapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database2.accdb");
            OleDbDataAdapter dataAtapter = new OleDbDataAdapter("select * from Rehber where adı like  '" + textBox1.Text + "%'  ", baglanti);
            DataTable table = new DataTable();
            baglanti.Open();
            dataAtapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
         
    }
}
