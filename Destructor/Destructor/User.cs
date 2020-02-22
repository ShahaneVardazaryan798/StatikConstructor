using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Destructor
{
    class User
    {
        public User()
        {
            WriteLine("I have Constructor");
        }
        ~User()
        {
            WriteLine("I have Destructor");
        }
    }
}
