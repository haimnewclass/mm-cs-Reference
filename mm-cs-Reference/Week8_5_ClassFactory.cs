using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week8_5_ClassFactory
    {
        public static void Run()
        {
            // Book.GenerateNewId();
            /*
                        Book book1 = new Book("Lassi");
                        Book book2 = new Book("Bob");
                        Book book3 = new Book("Harrissi");
                        Book book4 = new Book("Harrissi");
                        Book book5 = new Book("Harrissi");
                        Book book6 = new Book("Harrissi");
            */
            Book book1 = Book.Create("Lassi");
            Book book2 = Book.Create("Hasamba");
            Book book3 = Book.Create("Aladin");
            Book book4 = Book.Create("Kofiko");
            Book book5 = Book.Create("Jinji");

            if(book5!=null)
                Console.WriteLine(book5.Name);

           // Book book6 = new Book("Pressed");
        }
        public class Book
        {

            public string GetName()
            {
                return Name;
            }
            public static Book Create(string name)
            {
                if (counter < 3)
                {
                    Book ret = new Book(name);
                    return ret;
                }
                else
                    return null;
            }



            private int _Id;
            public int Id
            {
                get { return _Id; }
                private set { _Id = value; }
            }
            public string Name { get; set; }
            private Book(string aName)
            {
                Name = aName;
                _Id = GenerateNewId();
            }

            private static int counter = 0;
            private static int GenerateNewId()
            {
          
                return ++counter;
                
            }
        }
    }
}
