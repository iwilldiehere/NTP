using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       //color a
        // xantares aim transfer tunç kurt matematik
        //sinx = 5 tunçkurt matematik
        //tunçkurt motivation
        List<Yazar> yazarlar = new List<Yazar>();
        List<Kitap> Kitaplar = new List<Kitap>();
        List<Müşteri> Musteriler = new List<Müşteri>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            #region YAZAR EKLE
            Yazar yzr = new Yazar();
            yzr.Adi = txtYazarAdi.Text;
            yzr.DogumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked == true)
            {
                yzr.NobelVarMi = true;
            }
            else
            {
                yzr.NobelVarMi = false;
            }
            yazarlar.Add(yzr);
            txtYazarAdi.Text = null;
            
            cmbYazar.Items.Add(yzr);
            cmbYazar.DisplayMember = "Adi";
           
            
            
            #endregion

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            #region KİTAP EKLE
          
            Kitap kitapbilgi = new Kitap();
            kitapbilgi.KitapAdi = txtKitapAdi.Text;

            kitapbilgi.KitapTuru = cmbKitapTuru.Text;

             kitapbilgi.KitapSayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            kitapbilgi.KitapFiyat = decimal.Parse(txtFiyat.Text);
            kitapbilgi.KitapYazar = (Yazar)cmbYazar.SelectedItem;

            Kitaplar.Add(kitapbilgi);
            cmbKitap.Items.Add(kitapbilgi);
            cmbKitap.DisplayMember = "KitapAdi";

            
            
            
            
            
            
            #endregion
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            #region MÜŞTERİ EKLE
            Müşteri musteri = new Müşteri();
            musteri.MusteriAdi = txtMusteriAdi.Text;
            musteri.MusteriMeslek = txtMeslegi.Text;
            musteri.MusteriKitap = (Kitap)cmbKitap.SelectedItem;
            musteri.MusteriYasi = Convert.ToInt32(txtMusteriYas.Text);
          

            Musteriler.Add(musteri);
           




            #endregion
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            lsbMusteriler.Items.Add("|Müsteri|" + "|Kitap Adı|" + "|Sayfa Sayisi|" + "|Kitap Yazar Adi|");
            foreach (Müşteri item in Musteriler)
            {
                
                lsbMusteriler.Items.Add("  " + "  " + "  " + "  " + "  " + "  ");
               
                lsbMusteriler.Items.Add(item.MusteriAdi+"  "+item.MusteriKitap.KitapAdi+"  "+item.MusteriKitap.KitapSayfaSayisi+"  "+item.MusteriKitap.KitapYazar.Adi);
                lsbMusteriler.Items.Add("  " + "  " + "  " + "  " + "  " + "  ");
            }
          
        }


       
        
    }
}
