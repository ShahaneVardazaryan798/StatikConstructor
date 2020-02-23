using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class User
    {
        public string name, location;
        public long mark = 470;
        public User(string name,string location)
        {
            this.name = name;
            this.location = location;
        }
        public void GetUserDetails()
        {
            WriteLine("Name:{0}", name);
            WriteLine("Location:{0}", location);
            WriteLine("Mark:{0}", Exam.GetPersentAge(this));

        }
    }
}
