using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yurtotomasyon
{
    public partial class personel : Form
    {
        private PersonelVeritabani personelVeritabani = new PersonelVeritabani();
        public personel()
        {
            InitializeComponent();
        }

        private void personel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyisim = textBox2.Text;
            string bolum = textBox3.Text;
            string gorev = textBox4.Text;

            Personel personel = new Personel(isim, soyisim, bolum, gorev);
            personelVeritabani.PersonelEkle(personel);

            MessageBox.Show("Personel başarıyla eklendi.");
        }

        private void listBoxPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string soyisim = textBox2.Text;

            personelVeritabani.PersonelSil(isim, soyisim);

            MessageBox.Show("Personel başarıyla silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = personelVeritabani.PersonelListele();
            listBoxPersonel.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                listBoxPersonel.Items.Add($"{row["Isim"]} {row["Soyisim"]} - {row["Bolum"]} - {row["Gorev"]}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           bölümler a = new bölümler();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
    }
