using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtotomasyon
{
    public partial class yemekhane : Form
    {
        private PersonelVeritabani personelVeritabani = new PersonelVeritabani();
        public yemekhane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bölümler n = new bölümler();
            n.Show();
            this.Hide();
        }

        private void yemekhane_Load(object sender, EventArgs e)
        {
            List<Personel> yemekhanePersonelleri = personelVeritabani.YemekhanePersonelListele();

            // ListBox'ı temizle
            listBox1.Items.Clear();

            // Personel bilgilerini ListBox'a ekle
            foreach (Personel personel in yemekhanePersonelleri)
            {
                listBox1.Items.Add(personel.BilgileriGetir());  // Polymorphism kullanarak
            }
        }
        // Form açıldığında Yemekhane bölümündeki personelleri listele
        private void YemekhaneFormu_Load(object sender, EventArgs e)
        {
            List<Personel> yemekhanePersonelleri = personelVeritabani.YemekhanePersonelListele();

            // ListBox'ı temizle
            listBox1.Items.Clear();

            // Personel bilgilerini ListBox'a ekle
            foreach (Personel personel in yemekhanePersonelleri)
            {
                listBox1.Items.Add(personel.BilgileriGetir());  // Polymorphism kullanarak
            }
        }
    }
}
