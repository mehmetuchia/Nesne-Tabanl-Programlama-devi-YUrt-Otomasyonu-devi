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
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemFormu a = new IslemFormu();
            a.Show();
            this.Hide();
        }



        private void öğrenciekle_Click(object sender, EventArgs e)
        {
            ogrekle nn = new ogrekle();
            nn.Show();
            this.Hide();
        }



        private void oda1_Click_1(object sender, EventArgs e)
        {
            oda1 a = new oda1();
            a.Show();
            this.Hide();

        }

        private void odalar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oda2 a = new oda2();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oda3 a = new oda3();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oda4 a = new oda4();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oda5 a = new oda5();
            a.Show(); this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            oda6 a = new oda6();
            a.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            oda7 a = new oda7();
            a.Show(); this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            oda8 a = new oda8();
            a.Show(); this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            oda9 a = new oda9();
            a.Show(); this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            oda10 a = new oda10();
            a.Show(); this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            oda11 a = new oda11();
            a.Show(); this.Hide();
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            oda12 a = new oda12();
            a.Show(); this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            oda13 a = new oda13();
            a.Show(); this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oda14 a = new oda14();
            a.Show(); this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            oda15 a = new oda15();
            a.Show(); this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            oda16 a = new oda16();
            a.Show(); this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            oda17 a = new oda17();
            a.Show(); this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            oda18 a = new oda18();  
            a.Show(); this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            oda19 a = new oda19();
            a.Show(); this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
             oda20 a = new oda20();
            a.Show(); this.Hide();
        }
    }

}



