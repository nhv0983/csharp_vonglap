using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vonglap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so;
            so = Convert.ToDouble(txt1 .Text);
            int giaithua = 1;
            for (int i = 1; i <= so; i++)
            {
                giaithua = giaithua * i;//gt*=i;
            }
            txtketqua.Text = giaithua.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
