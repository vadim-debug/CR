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
            user.SGEmail = "test@gmail.";
            Console.WriteLine(user.SGEmail);
        }
    }
}
