using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Shahane", "Erevan");
            User user1 = new User(user);
            user.name = "Garik";
            user.location = "Goris";
            WriteLine(user.name+","+user.location);
            WriteLine(user1.name+","+user1.location);
            ReadLine();
        }
    }
}
