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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox1.Text, out txt);
            if (isnumber == false && textBox1.Text != "" && textBox1.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int txt;
            bool isnumber = Int32.TryParse(textBox2.Text, out txt);
            if (isnumber == false && textBox2.Text != "" && textBox2.Text != "-")
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Warning!");
                textBox2.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
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
        private void button2_Click(object sender, EventArgs e)
        {
            ResetControlValues(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
