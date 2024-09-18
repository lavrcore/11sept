using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _11sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayInt = { 5, 34, 67, 12, 94, 42 , 100 , 7 , 58 , 93 , 45};
            //IEnumerable<int> query = from i in arrayInt select i;
            //foreach (int item in query ) 
            //{
            //    Console.WriteLine($"{item}\t");
            //}
            //var query2 = arrayInt.ToList()
            //                     .Where(x => x % 2 == 0);
            //var query3 = from x in arrayInt
            //             where x % 2 == 0
            //             orderby x descending
            //             select x;

            ////Dictionary<string, int> key = new Dictionary<string, int>();
            //var query4 = from i in arrayInt
            //             group i by i % 10;
            //foreach(var item in query4)
            //{
            //    Console.WriteLine($" Key: {item.Key}\t\n");
            //    foreach(var i in item)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //var query5 = from i in arrayInt
            //             group i by i % 10 into res
            //             where res.Count() > 1
            //             select res;
            //foreach (var item in query5)
            //{
            //    Console.WriteLine($"\n Key:  {item.Key}\n");
            //    foreach (var i in item)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    string[] poem = { "All the worlds a stage,",
            //                    "And all the men and women merely players;",
            //                    "They have their exists and their entrances,",
            //                    "And one man in his time plays many parts,",
            //                    "His acts being seven ages..."};
            //    var query6 = from i in poem
            //                 let words = i.Split(' ', ';', ',')
            //                 from word in words
            //                 where word.Length > 6
            //                 select word;

            //    foreach (var i in query6) Console.WriteLine(i);

            //    var query7 = from x in arrayInt
            //                 where x % 2 != 0
            //                 select x;
            //    foreach(var i in query7) Console.WriteLine(i + " \n");

            //    var query8 = from v in arrayInt
            //                 where v >= 10
            //                 where v < 100
            //                 orderby v ascending
            //                 select v;
            //    Console.WriteLine("\n");
            //    foreach (var i in query8) Console.WriteLine(i + " ");

            //    string[] latinskiy = { "KSBGS AB ABC ABCD ABCDE ABCDEF ABCAAA AOAKSL SBKCKSHJW A" };
            //    var query9 = from v in latinskiy
            //                 let words = v.Split(' ', ';', ',')
            //                 from word in words
            //                 orderby word.Length ascending
            //                 select word;
            //    Console.WriteLine("\n");
            //    foreach(var i in query9) Console.WriteLine(i + " ");
            int K1 = 5;
            int K2 = 10;
            int[] A = { 1, 6, 2, 8, 3 };
            int[] B = { 9, 7, 5, 12 };
            var result = from a in A
                         where a > K1
                         orderby a ascending
                         select a;
            foreach (var i in result) Console.WriteLine(i + " ");
            var result2 = from b in B
                          where b < K2
                          orderby b ascending
                          select b;
            Console.WriteLine("\n");
            foreach (var i in result2) Console.WriteLine(i + " ");

            int[] sequence = { 23, -1, 15, 15, 30, 22, 5, -3, 5, 10 };
            var query11 = (from number in sequence
                           where number > 0
                           let lastDigit = number % 10
                           select lastDigit)
                             .Distinct();// удаляет повторы
            foreach (var i in query11) Console.WriteLine(i + " ");

        }
    }

}