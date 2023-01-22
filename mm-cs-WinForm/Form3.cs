using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mm_cs_WinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mm_cs_Working.Cars.Sql();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show( DelegateClass.Instance.Calc(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), DelegateClass.Instance.Plus).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DelegateClass.Instance.Calc(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), DelegateClass.Instance.Minus).ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mm_cs_Reference.Mythread mythread = new mm_cs_Reference.Mythread();
            
        }
    }
}
