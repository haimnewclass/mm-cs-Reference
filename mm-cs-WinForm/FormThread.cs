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
    public partial class FormThread : Form
    {
        public FormThread()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            

            int g = 90;

            var fun = delegate (int h)
            {
                return h * h + calc(h);
            };

           Task.Run(() => { }).Wait();
            g = calc(80);
            int calc(int a)
            {
                return a * a + 90;
            }

            object i1 = new Dictionary<int, int>();
            object i2 = new List<int>();

           /* object i3 = i1.GetType() switch
            {
                (Dictionary<int, int>) => new Dictionary<int, int>(),
                "33123" => new Dictionary<int, int>(),
                _ => new Dictionary<int, int>()
            };*/


            var f = await EndLessLoop();
        }

        Task<int> EndLessLoop()
        {
            return Task<int>.Run(() =>
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < int.MaxValue; i++)
                    {

                    }

                }
                
                return 89;
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var t = await GotoInternet();
            label1.Text = t ;
          //  t.Result 
        }

        public Task<string> GotoInternet()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "ResultFrom Internet";
            });


        }
    }
}
