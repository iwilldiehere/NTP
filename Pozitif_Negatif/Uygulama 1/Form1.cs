using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a, sayac=0, toplam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();

            for (int i = 100 ; i < 300; i++)
            {
                a = rnd.Next(100, 200);
                listBox1.Items.Add(a);
                sayac++;
                toplam = a;
                
            }
            #region if'ler

                
            
            if(toplam%3==0)
      {
      
                listBox2.Items.Add(toplam);
      } 
      if(toplam%5==0)
      {
      
          listBox4.Items.Add(toplam);
      }
       if(toplam%7==0)
        {   
            
           listBox6.Items.Add(a);
        }
   if(toplam%3==0 || toplam%5==0)
   {
      
       listBox3.Items.Add(a);
   }
   if (toplam % 3 == 0 || toplam % 7 == 0)
   {
  
       listBox5.Items.Add(a);
   }
   if (toplam % 3 == 0 || toplam % 5 == 0)
   {

       listBox7.Items.Add(a);
   }
            
            #endregion


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
