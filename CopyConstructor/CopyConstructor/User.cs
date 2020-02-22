using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CopyConstructor
{
    class User
    {
        public string name, location;
        public User(string a,string b)
        {
            name = a;
            location = b;
        }
        public User(User user)//copy constructor
        {
            name = user.name;
            location = user.location;
        }
    }
}
