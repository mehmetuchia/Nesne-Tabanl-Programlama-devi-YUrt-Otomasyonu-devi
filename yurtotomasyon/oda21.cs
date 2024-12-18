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
    public partial class oda21 : Form
    {
        public oda21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odalar n = new odalar();
            n.Show();
            this.Hide();
        }
    }
}
