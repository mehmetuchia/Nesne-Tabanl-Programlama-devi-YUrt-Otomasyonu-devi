using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace yurtotomasyon
{
    public class PersonelVeritabani
    {
        private string connectionString = @"Data Source=DESKTOP-DU4N016\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True";

        // Personel ekleme
        public void PersonelEkle(Personel personel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Personel (Isim, Soyisim, Bolum, Gorev) VALUES (@Isim, @Soyisim, @Bolum, @Gorev)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Isim", personel.Isim);
                command.Parameters.AddWithValue("@Soyisim", personel.Soyisim);
                command.Parameters.AddWithValue("@Bolum", personel.Bolum);
                command.Parameters.AddWithValue("@Gorev", personel.Gorev);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Personel silme
        public void PersonelSil(string isim, string soyisim)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Personel WHERE Isim =@Isim AND Soyisim = @Soyisim";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Isim", isim);
                command.Parameters.AddWithValue("@Soyisim", soyisim);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Personel listeleme
        public DataTable PersonelListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        // Personel listeleme
        public List<Personel> IdarePersonelListele()
        {
            List<Personel> personeller = new List<Personel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel WHERE Bolum = 'İdare'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    // İdarePersonel sınıfı kullanılacak
                    IdarePersonel personel = new IdarePersonel(
                        row["Isim"].ToString(),
                        row["Soyisim"].ToString(),
                        row["Gorev"].ToString()
                    );
                    personeller.Add(personel);
                }
            }

            return personeller;
        }
        // Yemekhane personellerini listeleme
        public List<Personel> YemekhanePersonelListele()
        {
            List<Personel> personeller = new List<Personel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel WHERE Bolum = 'Yemekhane'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    // YemekhanePersonel sınıfı kullanılacak
                    YemekhanePersonel personel = new YemekhanePersonel(
                        row["Isim"].ToString(),
                        row["Soyisim"].ToString(),
                        row["Gorev"].ToString()
                    );
                    personeller.Add(personel);
                }
            }

            return personeller;
        }
        public List<Personel> CamasirhanePersonelListele()
        {
            List<Personel> personeller = new List<Personel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel WHERE Bolum = 'Çamaşırhane'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    // ÇamaşırhanePersonel sınıfı kullanılacak
                    CamasirhanePersonel personel = new CamasirhanePersonel(
                        row["Isim"].ToString(),
                        row["Soyisim"].ToString(),
                        row["Gorev"].ToString()
                    );
                    personeller.Add(personel);
                }
            }

            return personeller;
        }
        // Güvenlik personellerini listeleme
        public List<Personel> GuvenlikPersonelListele()
        {
            List<Personel> personeller = new List<Personel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel WHERE Bolum = 'Güvenlik'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    // GüvenlikPersonel sınıfı kullanılacak
                    GuvenlikPersonel personel = new GuvenlikPersonel(
                        row["Isim"].ToString(),
                        row["Soyisim"].ToString(),
                        row["Gorev"].ToString()
                    );
                    personeller.Add(personel);
                }
            }

            return personeller;
        }
        // Temizlik personellerini listeleme
        public List<Personel> TemizlikPersonelListele()
        {
            List<Personel> personeller = new List<Personel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel WHERE Bolum = 'Temizlik'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    // TemizlikPersonel sınıfı kullanılacak
                    TemizlikPersonel personel = new TemizlikPersonel(
                        row["Isim"].ToString(),
                        row["Soyisim"].ToString(),
                        row["Gorev"].ToString()
                    );
                    personeller.Add(personel);
                }
            }

            return personeller;
        }
    }
}
