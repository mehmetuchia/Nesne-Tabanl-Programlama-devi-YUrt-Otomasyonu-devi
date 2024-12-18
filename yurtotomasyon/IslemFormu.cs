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
    public partial class IslemFormu : Form
    {
        public IslemFormu()
        {
            InitializeComponent();
        }

        private void btnPRS_Click(object sender, EventArgs e)
        {
            bölümler bölümler= new bölümler();
            bölümler.Show();
            this.Hide();
        }

        private void btnOGR_Click(object sender, EventArgs e)
        {
            odalar odalar = new odalar();
            odalar.Show();
            this.Hide();
        }

        private void IslemFormu_Load(object sender, EventArgs e)
        {
            label1.Text= DateTime.Now.ToLongDateString();
            label2.Text= DateTime.Now.ToShortTimeString();
            // Yuvarlak köşeler için bir elips şekli tanımla
            

        }
    }
}
