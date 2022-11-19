using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace mm_cs_Reference
{
    internal class Week8_4_Static
    {
        string id;
        public void Run()
        {
            string[] str = new string[4];
            str[0] = "1111111";
            str[1] = "22222222";
            str[2] = "5555555";
            str[3] = "rrrrrrrr";

            string[] str2;
            
            File.WriteAllLines(@"c:\a\MyFile.txt", str);
            string fileName = id + ".txt";
            if (File.Exists(fileName))
            {
                str2 = File.ReadAllLines(fileName);
            }
            else
            {
                Console.WriteLine("File Is not exites");
            }

        }
    }

    
}
