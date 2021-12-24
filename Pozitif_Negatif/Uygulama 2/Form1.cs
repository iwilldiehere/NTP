using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 listBox1.Items.Clear();
            Random rnd = new Random();
            int a;
            for (int i = 0; i < 50; i++)
            {
                a = rnd.Next(-100, 100);
                listBox1.Items.Add(a);
             
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            #region pozitif
            
            
            for (int i = 0; i < 50; i++)
            {
                int sayi = (int)listBox1.Items[i];
                if (radioButton1.Checked && (sayi > 0 ) && radioButton3.Checked)
                {

                  if (sayi % 3 == 0)
                    {
                        listBox2.Items.Add(sayi);
                    }
                    }
        
                  if (radioButton1.Checked && (sayi > 0) && radioButton4.Checked)
                  {

                      if (sayi % 5 == 0)
                      {
                          listBox2.Items.Add(sayi);
                      }
                       }
         
              
            if (radioButton1.Checked && (sayi > 0) && radioButton5.Checked)
                  {

                      if (sayi % 7 == 0)
                      {
                          listBox2.Items.Add(sayi);
                      }
             }
            #endregion
               
                 #region negatif
            
         
     
            {
                int ab = (int)listBox1.Items[i];
                if (radioButton2.Checked && (sayi < 0 ) && radioButton3.Checked)
                {

                  if (sayi % 3 == 0)
                    {
                        listBox2.Items.Add(ab);
                    }
                    }
        
                  if (radioButton2.Checked && (sayi < 0) && radioButton4.Checked)
                  {

                      if (sayi % 5 == 0)
                      {
                          listBox2.Items.Add(ab);
                      }
                       }
         
              
            if (radioButton2.Checked && (sayi < 0) && radioButton5.Checked)
                  {

                      if (sayi % 7 == 0)
                      {
                          listBox2.Items.Add(ab);
                      }
             }
         
                #endregion
            }



            }      
    }

    }
}