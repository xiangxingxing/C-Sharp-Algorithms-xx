using System;
using System.Linq;
using System.Collections.Generic;

namespace OnlineTest
{
    //标准main
    // using System;
    // using System.Linq;
    // using System.Collections.Generic;
    //
    // namespace OnlineTest
    // {
    //     class Program
    //     {
    //         static void Main(string[] args)
    //         {
    //         
    //         }
    //     }
    // }

    class Program
    {
        // static void Main(string[] args)
        // {
        //     //OjInOutput();
        //     //OjInOutput2();
        //     //OjInOutput3();
        //     //OjInOutput4();
        //     //OjInOutput5();
        //     //OjInOutput6();
        //     //OjInOutput7();
        //     //StringSort1();
        //     //StringSort2();
        //     //StringSort3();
        //     
        // }

        private static void LastTest()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var strings = str.Split();
                var sum = strings.Sum(long.Parse); //‼️用int只有50%通过率‼️
                Console.WriteLine(sum);
            }
        }

        private static void StringSort3()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var list = str.Split(',').ToList();
                list.Sort();
                for (var i = 0; i < list.Count; i++)
                {
                    Console.Write(i == list.Count - 1 ? list[i] : $"{list[i]},");
                }

                Console.WriteLine();
            }
        }

        private static void StringSort2()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var list = str.Split().ToList();
                list.Sort();
                for (var i = 0; i < list.Count; i++)
                {
                    Console.Write(i == list.Count - 1 ? list[i] : $"{list[i]} ");
                }

                Console.WriteLine();
            }
        }

        private static void StringSort1()
        {
            var count = int.Parse(Console.ReadLine());
            var strings = Console.ReadLine().Split();
            if (count != strings.Length)
            {
                return;
            }

            var list = strings.ToList();
            list.Sort();
            for (var i = 0; i < list.Count; i++)
            {
                Console.Write(i == list.Count - 1 ? list[i] : $"{list[i]} ");
            }
        }

        private static void OjInOutput7()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var strings = str.Trim().Split();
                var n = int.Parse(strings[0]);
                var sum = strings.Sum(int.Parse);
                Console.WriteLine(sum);
            }
        }

        private static void OjInOutput6()
        {
            string str;
            while (!string.IsNullOrEmpty(str = Console.ReadLine()))
            {
                var strings = str.Trim().Split();
                if (string.IsNullOrEmpty(strings[0]))
                {
                    break;
                }

                var n = int.Parse(strings[0]);
                var sum = strings.Sum(int.Parse) - n;
                Console.WriteLine(sum);
            }
        }

        private static void OjInOutput5()
        {
            var count = int.Parse(Console.ReadLine()); //需要输入的数据组数
            while (count > 0)
            {
                var strings = Console.ReadLine().Split();
                var n = int.Parse(strings[0]);
                var sum = strings.Sum(int.Parse) - n;
                Console.WriteLine(sum);
                count--;
            }
        }

        private static void OjInOutput4()
        {
            var n = -1;
            while (n != 0)
            {
                var strings = Console.ReadLine().Split();
                if ((n = int.Parse(strings[0])) == 0)
                {
                    break;
                }

                var sum = strings.Sum(int.Parse) - n;
                Console.WriteLine(sum);
            }
        }

        private static void OjInOutput3()
        {
            int a = -1, b = -1;
            while (a != 0 || b != 0)
            {
                var strings = Console.ReadLine().Split();
                a = int.Parse(strings[0]);
                b = int.Parse(strings[1]);
                if (a == 0 && b == 0)
                {
                    break;
                }

                Console.WriteLine(a + b);
            }
        }

        private static void OjInOutput2()
        {
            var count = Console.ReadLine(); //需要输入的数据组数
            string input;
            var i = int.Parse(count);
            while (i > 0 && (input = Console.ReadLine()) != "")
            {
                if (input == null)
                {
                    break;
                }

                var array = input.Split();

                var sum = array.Sum(int.Parse);
                //var sum = int.Parse(array[0]) + int.Parse(array[1]);

                Console.WriteLine(sum);
                i--;
            }

            // int n = int.Parse(Console.ReadLine());
            // while (n-- > 0)
            // {
            //     string[] sb = Console.ReadLine().Split();
            //     int x = int.Parse(sb[0]), y = int.Parse(sb[1]);
            //     Console.WriteLine(x + y);
            // }
        }

        //a+b
        private static void OjInOutput()
        {
            string sb;
            while ((sb = Console.ReadLine()) != "")
            {
                if (sb == null) break;
                var s = sb.Split();
                int x = int.Parse(s[0]), y = int.Parse(s[1]);
                Console.WriteLine(x + y);
            }
        }
    }
}