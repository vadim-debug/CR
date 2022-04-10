using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    internal class Program
    {
        static void Main(string[] args)

        {
           User user = new User();
            user.SGEmail = "12";
            Console.WriteLine(user.SGEmail);
        }
    }
}
