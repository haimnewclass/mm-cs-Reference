using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference.Inder
{
    internal class Week16_1_Indexser
    {
        public void Run()
        { 
            Mng mng = new Mng();
            mng.Add("aaa", new Item() { Id = 12 });
            mng.Add("bbb", new Item() { Id = 13 });
            mng.Add("ccc", new Item() { Id = -18 });

            Item item = mng.Get("bbb");

            mng["aaa"] = new Item() { Id = 12 };
            mng["bbb"] = new Item() { Id = 13 };
            mng["ccc"] = new Item() { Id = -18 };
            mng["111"] = new Item() { Id = -18 };
            mng[111] = new Item() { Id = -18 };
            Console.WriteLine(mng["111"].Id);
        }

    }

    class Mng 
    {
        private Dictionary<string, Item> items = new  Dictionary<string, Item>();

        public Item this[int k]
        {
            set
            {
                Item v = value;
                if (items.ContainsKey(k.ToString()))
                {

                }
                else
                {
                    if (v.Id > 0)
                    {
                        items[k.ToString()] = v;
                    }
                    else
                    {
                        v.Id = Math.Abs(v.Id);
                        Add(k.ToString(), v);
                    }
                }
            }

            get
            {
                return items[k.ToString()];
            }

        }

        public Item this[string k]
        {
            set
            {
                Item v = value;
                if (items.ContainsKey(k))
                {

                }
                else
                {
                    if (v.Id > 0)
                    {
                        items[k] = v;
                    }
                    else
                    {
                        v.Id = Math.Abs(v.Id);
                        Add(k, v);
                    }
                }
            }

            get
            {
                return items[k];
            }

        }

        public void Add(string k,Item v)
        {
            if (items.ContainsKey(k))
            {

            }
            else
            {
                if (v.Id > 0)
                {
                    items[k] = v;
                }
                else
                {                    
                    v.Id = Math.Abs(v.Id);
                    Add(k, v);
                }
            }
        }
        public Item Get(string k)
        {
            return items[k];
        }
    }

    class Item
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }

}
