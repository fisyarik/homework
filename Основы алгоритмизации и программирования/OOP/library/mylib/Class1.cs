using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib
{
    public class Class1
    {
        public class Person
        {
            public string name;
            public Person(string name)

            {
                this.name = name;
            }
            public void Print()

            {
                Console.WriteLine("Имя: " + name);
            }
        }

    }
}
