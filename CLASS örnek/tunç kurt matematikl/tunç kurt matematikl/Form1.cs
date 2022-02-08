using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tunç_kurt_matematikl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Liste> ogrlist = new List<Liste>();
 
        private void button1_Click(object sender, EventArgs e)
        {
         
           

                Liste ogrenc = new Liste();
              
                ogrenc.ad = textBox1.Text;
                ogrenc.soyad = textBox2.Text;
                ogrenc.numara = textBox3.Text;
                if(ogrenc.ad!=null && ogrenc.ad!="" && ogrenc.soyad!=null && ogrenc.soyad!="" && ogrenc.numara!=null && ogrenc.numara!="" )
                {
                    ogrlist.Add(ogrenc);  
                    MessageBox.Show("Kullanıcı listeye eklenmiştir.");
           
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                }
                else
                {
                    MessageBox.Show("Lütfen alanları doldurunuz");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                }
            
      
     
     
   }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach  (Liste item in ogrlist)
            {
            listBox1.Items.Add(item.ad);
            listBox2.Items.Add(item.soyad);
            listBox3.Items.Add(item.numara);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

        }
    }
}
