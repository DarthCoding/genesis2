//using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Transactions;
using System.Configuration;
using System.Collections.Generic;

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
            
            var dataPath = @"./Data";

            Console.WriteLine($"These files are in {dataPath}");

            var data = Directory.GetFiles(@"./Data");

            foreach (var p in data) {

                Console.WriteLine(p);
                Console.WriteLine(File.ReadAllText(p));

                var nums = File.ReadAllText(p);
                var getNums = nums.Split();

                Console.WriteLine(getNums[0]);

                //var num1 = Convert.ToInt32(getNums[0]);
                var num1 = int.Parse(getNums[0]);
                var num2 = Convert.ToInt32(first);

                Console.WriteLine(first + num1);

            }




            ReadData(data);









        }

        public static void ReadData(string[] dataPoints) {

            Console.WriteLine(dataPoints.Length);


        }










    }
}
