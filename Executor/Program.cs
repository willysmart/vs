using com.lau.Abstract;
using com.lau.Implementation;
using System;

namespace Executor
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executor");
            //Extra e = new ExtraSon();
            //Console.WriteLine(((ExtraSon)e).show());


            Person m1 = new Man("JL", 10);
            ((Man)m1).display();

            Person m2 = new Man() { Name = "ZL", Age = 100};
            ((Man)m2).display();

            Console.Read();
        }
    }
}
