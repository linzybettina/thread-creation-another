using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }
        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
                Console.Write('?');
            Console.ReadLine();
        }
    }
}
