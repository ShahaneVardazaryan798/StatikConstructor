using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Constructor
{
    class User
    {
        static User()
        {
            WriteLine("Iam static Constructor");
        }
        public User()
        {
            WriteLine("Iam public Constructor");
        }
    }
}
