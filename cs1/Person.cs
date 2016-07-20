using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lau.Abstract
{
    public class Person
    {
        public Person() { }

        public Person(string name= "WL", int age= 20)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get;set;
        }
        public int Age
        {
            get;set;
        }
        public virtual void display()
        {
            Console.WriteLine("Person: name: {0}, age: {1}", this.Name, this.Age.ToString());
        }
    }
}
