using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person(string name, string lastname, int age)
        {
            name = this.Name;
            lastname = this.Lastname;
            age = this.Age;
        }



    }
}
