namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int price;
            price = Int32.Parse(txtPrice.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price, age;
            price = Int32.Parse(txtPrice.Text);
            age = Int32.Parse(txtAge.Text);

            if (age < 16)
            {
                price = price / 2;
            }
            if (chkDiscount.Checked == true)
            {
                price = price / 2;
            }
            else
            {
                price = price / 5;
            }
            MessageBox.Show("Price is " + price);
        }

    }
}
