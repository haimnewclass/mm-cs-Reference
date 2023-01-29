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
    public partial class FormTaskSample : Form
    {
        int counter = 0;
        public FormTaskSample()
        {
            InitializeComponent();
        }

        void func1()
        {
            
            for (int j = 0; j < 12; j++)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Start";
            Task t = Task.Run(func1);
            int f = 90;

            Task.Run(() => {
                f++;
                for (int i = 0; i < 10; i++)
                {
                    //label1.Text = $"{i}";
                    counter++;
                    Thread.Sleep(1000);
                }
            });


            int g = 9;
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string ret = await GoToInternet();
            label1.Text=ret;
        }

        public Task<string> GoToInternet()
        {
            Task.Run(() => {
                Thread.Sleep(1000);
                return "swdtetertert";
            });

            return Task.Run( () => {
            Thread.Sleep(1000);
                return "swdtetertert";
            });
        }
    }
}
