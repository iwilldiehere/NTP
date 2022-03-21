using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lalal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListeleme uyelisteleme = new UyeListeleme();
            uyelisteleme.ShowDialog();
        }
    }
}
