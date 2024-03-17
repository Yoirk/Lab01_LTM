using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            switch (Int32.Parse(textBox2.Text))
            {
                case 0:
                    kq.Text = "Không";
                    break;
                case 1:
                    kq.Text = "Một";
                    break;
                case 2:
                    kq.Text = "Hai";
                    break;
                case 3:
                    kq.Text = "Ba";
                    break;
                case 4:
                    kq.Text = "Bốn";
                    break;
                case 5:
                    kq.Text = "Năm";
                    break;
                case 6:
                    kq.Text = "Sáu";
                    break;
                case 7:
                    kq.Text = "Bảy";
                    break;
                case 8:
                    kq.Text = "Tám";
                    break;
                case 9:
                    kq.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                    textBox2.Text = "";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox2.Text, out txt);
            if (isnumber == false && textBox2.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                textBox2.Text = "";
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox2.Text = kq.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
