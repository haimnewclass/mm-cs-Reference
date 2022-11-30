namespace mm_cs_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            textBox1.Text = (r.Next(100, 2000)).ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            textBox1.Text = "sdfsdfsdfsdfsdf";
        }
    }
}