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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }



        private void Tim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double ln = 0;
            double nn = 0;
            num1 = double.Parse(thu1.Text.Trim());
            num2 = double.Parse(thu2.Text.Trim());
            num3 = double.Parse(thu3.Text.Trim());
            if (num1 >= num2 && num1 >= num3 && num2 >= num3)
            {
                ln = num1;
                nn = num3;
            }
            else if (num2 >= num1 && num2 >= num3 && num1 >= num3)
            {
                ln = num2;
                nn = num3;
            }
            else if (num3 >= num1 && num3 >= num2 && num1 >= num2)
            {
                ln = num3;
                nn = num2;
            }
            textBox2.Text = ln.ToString();
            textBox1.Text = nn.ToString();
        }

        public static void ResetControlValues(Control Parent)
        {

            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {

                    (mycontrols as TextBox).Text = string.Empty;

                }

                else if (mycontrols is DateTimePicker)

                {

                    (mycontrols as DateTimePicker).Value = DateTime.Now;

                }

                else if (mycontrols is ComboBox)

                {

                    (mycontrols as ComboBox).SelectedIndex = 0;

                }

                else if (mycontrols is DataGridView)

                {

                    (mycontrols as DataGridView).Rows.Clear();

                }

        }
        private void xoa_Click(object sender, EventArgs e)
        {
            ResetControlValues(this);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thu1_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(thu1.Text, out txt);
            if (isnumber == false && thu1.Text != "" && thu1.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                thu1.Text = "";
            }
        }

        private void thu2_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(thu2.Text, out txt);
            if (isnumber == false && thu2.Text != "" && thu2.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                thu2.Text = "";
            }
        }

        private void thu3_TextChanged(object sender, EventArgs e)
        {
            double txt;
            bool isnumber = Double.TryParse(thu3.Text, out txt);
            if (isnumber == false && thu3.Text != "" && thu3.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập đúng!", "Warning!");
                thu3.Text = "";
            }
        }
    }
}
