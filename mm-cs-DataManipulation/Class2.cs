using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_DataManipulation
{
    internal class Class2

        public class Rootobject
        {
            public Employee[] employees { get; set; }
        }

        public class Employee
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
        }


        public class Rootobject
        {
            public Employee employee { get; set; }
        }

        public class Employee
        {
            public string name { get; set; }
            public int salary { get; set; }
            public bool married { get; set; }
        }


        public class Rootobject
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public Glossdiv GlossDiv { get; set; }
        }

        public class Glossdiv
        {
            public string title { get; set; }
            public Glosslist GlossList { get; set; }
        }

        public class Glosslist
        {
            public Glossentry GlossEntry { get; set; }
        }

        public class Glossentry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public Glossdef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class Glossdef
        {
            public string para { get; set; }
            public string[] GlossSeeAlso { get; set; }
        }

    }
}
