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
    public partial class Giriş : Form
    {

        // SQL bağlantı dizesi (kendi veritabanı yolunuza göre düzenleyin)
        string connectionString = "Data Source=DESKTOP-DU4N016\\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True;";
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;
            if (KullaniciDogrula(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // İşlemler formunu aç
                IslemFormu islemFormu = new IslemFormu();
                this.Hide();
                islemFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            bool dogrulandi = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        dogrulandi = count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dogrulandi;
        }



        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

