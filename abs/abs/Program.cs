using System;

namespace abs
{
    class Program
    {
        static void Main(string[] args)
        {
            GGList a = new GGList(5);
            Console.WriteLine(a);
            a.Add(5);
            
            Console.WriteLine(a);
            a.Remove(a.Len()-1);
            Console.WriteLine(a);
            
            a[0] = 5;

            Console.WriteLine(a);
            a.Remove(0);
            Console.WriteLine(a);
            a.Insert(1, 9);
            Console.WriteLine(a);
        }
    }
}
