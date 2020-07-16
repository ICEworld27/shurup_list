using System;

namespace abs
{
    class Program
    {
        static void Main(string[] args)
        {
            MEGA_GGList a = new MEGA_GGList(5);
            Console.WriteLine(a["h"]);

            Console.WriteLine(a);
            a["h"].Add(5);

            Console.WriteLine(a["h"]);
            Console.WriteLine(a);
            a["h", 0] = 9;
            Console.WriteLine(a["h"]);
            Console.WriteLine(a);

        }
    }
}
