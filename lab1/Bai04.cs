namespace lab1
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Thuchien_Click(object sender, EventArgs e)
        {      
            int demicals;
            string hex;
            string bin;
            int x;
            if (Pick1.Text == "Binary" && Pick2.Text == "Demical")
            {
                demicals = Convert.ToInt32(Nhap.Text, 2);
                KQ.Text = demicals.ToString();
            }

            else if (Pick1.Text == "Binary" && Pick2.Text == "Hexademical")
            {
                demicals = Convert.ToInt32(Nhap.Text, 2);
                hex = Convert.ToString(demicals, 16);
                KQ.Text = hex;
            }

            else if (Pick1.Text == "Binary" && Pick2.Text == "Binary")
                KQ.Text = Nhap.Text;

            else if (Pick1.Text == "Demical" && Pick2.Text == "Binary")
            {
                x = Convert.ToInt32(Nhap.Text);
                bin = Convert.ToString(x, 2);
                KQ.Text = bin;
            }

            else if (Pick1.Text == "Demical" && Pick2.Text == "Hexademical")
            {
                x = Convert.ToInt32(Nhap.Text);
                hex = Convert.ToString(x, 16);
                KQ.Text = hex;
            }

            else if (Pick1.Text == "Demical" && Pick2.Text == "Demical")
                KQ.Text = Nhap.Text;

            else if (Pick1.Text == "Hexademical" && Pick2.Text == "Binary")
            {
                demicals = Convert.ToInt32(Nhap.Text, 16);
                bin = Convert.ToString(demicals, 2);
                KQ.Text = bin;
            }

            else if (Pick1.Text == "Hexademical" && Pick2.Text == "Demical")
            {
                demicals = Convert.ToInt32(Nhap.Text, 16);
                KQ.Text = demicals.ToString();
            }

            else if (Pick1.Text == "Hexademical" && Pick2.Text == "Hexademical")
                KQ.Text = Nhap.Text;

            else if (Pick1.Text == "" || Pick2.Text == "")
                MessageBox.Show("Vui lòng chọn định dạng cần chuyển đổi!");
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            Nhap.Text = Pick1.Text = Pick2.Text = KQ.Text = "";
        }
    }
}
