using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = args.Length > 0 ? args[0] : String.Empty;
            var second = args.Length > 1 ? args[1] : String.Empty;

            Console.WriteLine(first);
            Console.WriteLine(second);

        }
    }
}
