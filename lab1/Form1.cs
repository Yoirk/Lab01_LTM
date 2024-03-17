namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 frm1 = new Bai01();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 frm2 = new Bai02();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 frm3 = new Bai03();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 frm4 = new Bai04();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 frm5 = new Bai5();   
            frm5.Show();
        }
    }
}
