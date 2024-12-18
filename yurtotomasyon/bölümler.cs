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
    public partial class bölümler : Form
    {
        public bölümler()
        {
            InitializeComponent();
        }

        private void btnPDZN_Click(object sender, EventArgs e)
        {
            personel nn = new personel();
            nn.Show();
            this.Hide();
        }

        private void btnIDR_Click(object sender, EventArgs e)
        {
            idareformu n = new idareformu();
            n.Show();
            this.Hide();
        }

        private void bölümler_Load(object sender, EventArgs e)
        {

        }

        private void btnYMK_Click(object sender, EventArgs e)
        {
            yemekhane yemekhane = new yemekhane();
            yemekhane.Show();
            this.Hide();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            çamaşırhane çamaşırhane = new çamaşırhane();
            çamaşırhane.Show();
            this.Hide();
        }

        private void gvnlk_Click(object sender, EventArgs e)
        {
            güvenlikformu g = new güvenlikformu();
            g.Show();   
            this.Hide();    
        }

        private void btnTMZ_Click(object sender, EventArgs e)
        {
            temizlik aa = new temizlik();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemFormu id=new IslemFormu();
            id.Show();
            this.Hide();
        }
    }
}
