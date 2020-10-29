using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace cykabot
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new Core();
            while (true)
            {
                var s = Console.ReadLine();
                Console.WriteLine(C.O(s));
             }
        }
    }
}
