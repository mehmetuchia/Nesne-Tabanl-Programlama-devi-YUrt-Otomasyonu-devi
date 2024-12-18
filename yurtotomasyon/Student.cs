using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yurtotomasyon
{
    public class Student
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Oda { get; set; }
        public string Unı { get; set; }
        public string Bolum { get; set; }
        public string Ikamet { get; set; }
        public string Telefon { get; set; }

        public void AddToDatabase()
        {
            string connectionString = "Data Source=DESKTOP-DU4N016\\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True;";

            string query = "INSERT INTO Ogrenciler (Ad, Soyad, Oda, Unı, Bolum, Ikamet, Telefon) " +
                           "VALUES (@Ad, @Soyad, @Oda, @Unı, @Bolum, @Ikamet, @Telefon)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", Ad);
                cmd.Parameters.AddWithValue("@Soyad", Soyad);
                cmd.Parameters.AddWithValue("@Oda", Oda);
                cmd.Parameters.AddWithValue("@Unı", Unı);
                cmd.Parameters.AddWithValue("@Bolum", Bolum);
                cmd.Parameters.AddWithValue("@Ikamet", Ikamet);
                cmd.Parameters.AddWithValue("@Telefon", Telefon);

                conn.Open();
                cmd.ExecuteNonQuery();  // Veritabanına ekler
            }
        }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string connectionString = "Data Source=DESKTOP-DU4N016\\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True;";

            string query = "SELECT ID, Ad, Soyad, Oda, Unı, Bolum, Ikamet, Telefon FROM Ogrenciler";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        Oda = reader["Oda"].ToString(),
                        Unı = reader["Unı"].ToString(),
                        Bolum = reader["Bolum"].ToString(),
                        Ikamet = reader["Ikamet"].ToString(),
                        Telefon = reader["Telefon"].ToString()
                    });
                }
            }

            return students;
        }

        // Öğrenci silme
        public void DeleteFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-DU4N016\\SQLEXPRESS01;Initial Catalog=YURT;Integrated Security=True;";

            string query = "DELETE FROM Ogrenciler WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                cmd.ExecuteNonQuery();  // Öğrenciyi siler
            }
        }
    }
}
