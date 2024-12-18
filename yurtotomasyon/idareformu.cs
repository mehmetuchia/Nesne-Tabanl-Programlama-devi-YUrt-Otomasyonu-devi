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
    public partial class idareformu : Form
    {
        private PersonelVeritabani personelVeritabani = new PersonelVeritabani();
        public idareformu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idareformu_Load(object sender, EventArgs e)
        {
            List<Personel> idarePersonelleri = personelVeritabani.IdarePersonelListele();

            // ListBox'ı temizle
            listBox1.Items.Clear();

            // Personel bilgilerini ListBox'a ekle
            foreach (Personel personel in idarePersonelleri)
            {
                listBox1.Items.Add(personel.BilgileriGetir());  // Polymorphism kullanarak
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bölümler n = new bölümler();
            n.Show();
            this.Hide();
        }
    }
}
