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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // PROGRAMI ÇALIŞTIRMAK İÇİN ACCESS'DE YAPTIĞINIZ TABLOYU BELGELER/VISUAL STUDIO/PROJENIZIN ISMI/ BIN / DEBUG KLASÖRÜNÜN İÇİNE ATIYORSUNUZ / Source=Database11.accdb 'DATABASE11' YAZAN KISIMA KAYIT ETTİĞİNİZ ACCESS PROJESİNİN İSMİNİ YAZIYORSUNUZ. ("SELECT * FROM Ogrenci ", con) "Ogrenci" YAZAN KISIMA ACCESS PROJENİZİN İÇERİSİNDEKİ TABLONUZUN İSMİNİ YAZIYORSUNUZ VE ÇALIŞTIRIYOSUNUZ.

        OleDbConnection con;
        OleDbDataAdapter da;
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 527; 
            lbl1.Text = "Öğenci";
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database11.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Ogrenci ", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 400; 
            lbl1.Text = "Öğretmen";
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database11.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Ogretmen ", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
