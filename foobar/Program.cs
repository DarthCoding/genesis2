using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the multiple of them for you:");
            var first = args.Length > 0 ? Convert.ToInt16(args[0]) : 0;
            var second = args.Length > 1 ? Convert.ToInt16(args[1]) : 0;

            Console.WriteLine(first * second);
            

        }
    }
}
