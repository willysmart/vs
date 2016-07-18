using com.lau.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lau.Implementation
{
    public class ExtraSon : Extra
    {
        public ExtraSon()
        {
            Console.WriteLine("calling cs2.ExtraSon()");
        }

        public string show()
        {
            return "ExtraSon";
        }
    }
}
