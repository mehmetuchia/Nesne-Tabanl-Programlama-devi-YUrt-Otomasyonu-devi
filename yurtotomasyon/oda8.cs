using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtotomasyon
{
    public partial class oda8 : Form
    {
        public oda8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odalar n = new odalar();
            n.Show();
            this.Hide();
        }

        private void oda8_Load(object sender, EventArgs e)
        {
            ListeleOgrenciler();
        }
        private string connectionString = @"Data Source=DESKTOP-DU4N016\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True";

        private void ListeleOgrenciler()
        {
            // SQL bağlantısını aç
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL Sorgusu: OdaNumarası = 1 olan öğrencileri getir
                    string query = "SELECT * FROM Ogrenciler WHERE Oda = 8";

                    // SqlCommand ile sorgu çalıştır
                    SqlCommand command = new SqlCommand(query, connection);

                    // SqlDataReader ile sonuçları oku
                    SqlDataReader reader = command.ExecuteReader();

                    // ListBox'ı temizle
                    listBox1.Items.Clear();

                    // Her bir sonucu ListBox'a ekle
                    while (reader.Read())
                    {
                        string ogrenciBilgi = $"{reader["Ad"]} {reader["Soyad"]} - {reader["Oda"]} - {reader["Unı"]}-{reader["Bolum"]}- {reader["Ikamet"]}-{reader["Telefon"]}";
                        listBox1.Items.Add(ogrenciBilgi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekilirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
