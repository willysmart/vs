using com.lau.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lau.Implementation
{
    public class Man: Person
    {
        public Man():base()
        { 
        }
        public Man(string name, int age): base(name, age)
        {

        }

        public override void display()
        {
            //base.display();
            Console.WriteLine("Man: name: {0}, age: {1}", this.Name, this.Age.ToString());
        }
    }
}
