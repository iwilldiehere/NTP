using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MüşteriEkle musteri = new MüşteriEkle();
            musteri.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MüşteriListeleme MusteriListeleme = new MüşteriListeleme();
            MusteriListeleme.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Kategori kategorii = new Kategori();
            kategorii.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            Marka frmmarka = new Marka();
            frmmarka.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ÜrünEkle urunekle = new ÜrünEkle();
            urunekle.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ÜrünListele urunlistele = new ÜrünListele();
            urunlistele.ShowDialog();
        }


    }
}
