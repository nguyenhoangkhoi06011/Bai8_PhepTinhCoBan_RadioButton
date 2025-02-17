using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_PhepTinhCoBan_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);
            if (rdbCong.Checked)
            {
                txtKq.Text = (so1 + so2).ToString();
            }
            if (rdbTru.Checked)
            {
                txtKq.Text = (so1 - so2).ToString();
            }
            if (rdbNhan.Checked)
            {
                txtKq.Text = (so1 * so2).ToString();
            }
            if (rdbChia.Checked)
            {
                if (so2 == 0)
                {
                    txtKq.Text = "loi chia 0";
                }
                else
                {
                    txtKq.Text = (so1 / so2).ToString();
                }
            }
        }
    }
}
 
