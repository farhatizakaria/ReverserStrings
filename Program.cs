using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverserStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write any name or string: ");
            string userString = Console.ReadLine();
            reverserStrings(userString);
            
            Console.ReadKey();
        }
        private static void reverserStrings(string message)
        {
            char[] messageCharArray = message.ToCharArray();
            Array.Reverse(messageCharArray);
            string theResult = string.Concat(messageCharArray);
            Console.WriteLine("\nThe reversed string is {0} ",theResult);

        }
    }
}
