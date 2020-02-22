using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            GC.Collect();
            ReadLine();

                
        }
        public static void Clear()
        {
            User user = new User();
                
        }
    }
}
