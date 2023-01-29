namespace Winform3
{
   

    public partial class Form1 : Form
    {
        System.Collections.Generic.Queue<Item> itemsQueue;
        Random random = new Random(900);
        Task queueTask = null;
        bool stop = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemsQueue = new Queue<Item>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemsQueue.Enqueue(new Item() { Id=random.Next(1,900),Name = textBox1.Text });
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            queueTask = Task.Run(() =>
            {
                while(!stop)
                {
                    if(itemsQueue.Count > 0)
                    {
                        Item item = itemsQueue.Dequeue();
                        // save item to file takes 11 second
                        System.Threading.Thread.Sleep(11000);
                        
                    }

                    System.Threading.Thread.Sleep(1000);
                }

            });
        
        }
    }

    class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}