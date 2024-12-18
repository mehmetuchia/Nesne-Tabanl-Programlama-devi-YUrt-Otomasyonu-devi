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
    public partial class ogrekle : Form

    {

        public ogrekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odalar nn = new odalar();
            nn.Show();
            this.Hide();
        }

        private void ogrekle_Load(object sender, EventArgs e)
        {

        }
        


        private void ekle_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Ad = textBox1.Text,
                Soyad = textBox2.Text,
                Oda = textBox3.Text,
                Unı = textBox4.Text,
                Bolum = textBox5.Text,
                Ikamet = textBox6.Text,
                Telefon = textBox7.Text,
                

            };

            newStudent.AddToDatabase();
            listBox1.Items.Clear();

            List<Student> students = Student.GetStudents();
            foreach (var student in students)
            {
                string studentInfo = $"{student.ID}{student.Ad}- {student.Soyad} - {student.Oda} - {student.Unı} - {student.Bolum} - { student.Ikamet} - {student.Telefon}";
                listBox1.Items.Add(studentInfo);
            }
          
        }
        
        private void StudentForm_Load(object sender, EventArgs e)
        {
              // Form yüklendiğinde öğrencileri listele

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<Student> students = Student.GetStudents();
            foreach (var student in students)
            {
                string studentInfo = $"{student.ID}{student.Ad}- {student.Soyad} - {student.Oda} - {student.Unı} - {student.Bolum} - { student.Ikamet} - {student.Telefon}";
                listBox1.Items.Add(studentInfo);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedStudentInfo = listBox1.SelectedItem.ToString();
                string studentIdStr = selectedStudentInfo.Split('-')[0].Trim();  // ID'yi çekmek için (örneğin: 1 Ad Soyad - Oda ...)

                int studentId;
                if (int.TryParse(studentIdStr, out studentId))
                {
                    Console.WriteLine("Başarıyla dönüştürüldü: " + studentId);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş: Sayıya dönüştürülemeyen bir değer girdiniz.");
                }

                Student studentToDelete = new Student { ID = studentId };
                studentToDelete.DeleteFromDatabase();
             
            }
            else
            {
                MessageBox.Show("Silmek için bir öğrenci seçin.");
            }
            listBox1.Items.Clear();

            List<Student> students = Student.GetStudents();
            foreach (var student in students)
            {
                string studentInfo = $"{student.ID}{student.Ad}- {student.Soyad} - {student.Oda} - {student.Unı} - {student.Bolum} - {student.Ikamet} - {student.Telefon}";
                listBox1.Items.Add(studentInfo);
            }
        }

        private void tmz_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
