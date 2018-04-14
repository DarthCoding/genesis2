//using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Transactions;
using System.Configuration;
using System.Collections.Generic;
using Shapes;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the multiple of them for you:");
            var first = args.Length > 0 ? Convert.ToInt16(args[0]) : 0;
            var second = args.Length > 1 ? Convert.ToInt16(args[1]) : 0;
            var third = args.Length > 2 ? Convert.ToInt16(args[2]) : 0;

            Console.WriteLine(first * second);
            
            int[] numbers = new int[5];
            var i = 0;
            foreach (var arg in args) {
                numbers[i] = int.Parse(arg);
                i++;
            }


            Shape ball = new Shape();
            ball.Construct();

            Random thing = new Random(first);
            thing.Message();

            var dataPath = @"./Data";

            Console.WriteLine($"These files are in {dataPath}");

            var data = Directory.GetFiles(@"./Data");


            ReadData(data);
            ReadData(data, numbers);
            
            


        }

        public static void ReadData(string[] data) {


            Console.WriteLine("\n\nFirstOverLoaded Function");
            Console.WriteLine("============================\n");

            Console.WriteLine(data.Length);

            foreach (var p in data) {

                Console.WriteLine(p);
                Console.WriteLine(File.ReadAllText(p));

                var nums = File.ReadAllText(p);
                var getNums = nums.Split();

                Console.WriteLine(getNums[0]);

                //var num1 = Convert.ToInt32(getNums[0]);
                var num1 = int.Parse(getNums[0]);
                //var num2 = Convert.ToInt32(first);

                Console.WriteLine(num1);

            }



        }

        public static void ReadData(string[] data, int[] numbers) {

            Console.WriteLine("\n\nSecondOverLoaded Function");
            Console.WriteLine("============================\n");

            Console.WriteLine(data.Length);
            Console.WriteLine(numbers.Length);

            var a = numbers[0];
            var b = numbers[1];
            var c = numbers[2];

            foreach (var p in data) {

                Console.WriteLine(p);
                Console.WriteLine(File.ReadAllText(p));

                var nums = File.ReadAllText(p);
                var getNums = nums.Split();

                Console.WriteLine(getNums[0]);

                //var num1 = Convert.ToInt32(getNums[0]);
                var num1 = int.Parse(getNums[0]);
                //var num2 = Convert.ToInt32(first);

                Console.WriteLine(a + num1);
                Console.WriteLine(b + num1);
                Console.WriteLine(c + num1);

            }



        }










    }
}
