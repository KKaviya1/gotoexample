using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("enter user name");
            userName = Console.ReadLine();
            if (userName.Length>=6)
            {
            Console.WriteLine("Welcome: \t "+userName);

            }
            else
            {
                Console.WriteLine("Invalid UserName");
                goto Again;
            }
            Console.ReadKey();
        }

    }
}
