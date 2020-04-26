using System;
using System.Collections.Generic;

namespace OnlineTest
{
    public class MyList
    {
        // public static void Main(string[] args)
        // {
        //     var count = int.Parse(Console.ReadLine().Trim());
        //     var array = new List<int>();
        //     while (count > 0)
        //     {
        //         var myList = new MyList();
        //         var numOfPerform = int.Parse(Console.ReadLine().Trim());
        //         while (numOfPerform > 0)
        //         {
        //             var perform = Console.ReadLine().Trim();
        //             var numToBePushed = 0;
        //             if (perform.Contains("PUSH"))
        //             {
        //                 var strings = perform.Split();
        //                 perform = strings[0];
        //                 numToBePushed = int.Parse(strings[1]);
        //             }
        //             
        //
        //             switch (perform)
        //             {
        //                 case "PUSH":
        //                     myList.Push(numToBePushed);
        //                     break;
        //                 case "TOP":
        //                     array.Add(myList.Top());
        //                     break;
        //                 case "POP":
        //                     var pop = myList.Pop();
        //                     if (pop == -1)
        //                     {
        //                         array.Add(pop);
        //                     };
        //                     break;
        //                 case "SIZE":
        //                     array.Add(myList.Size());
        //                     break;
        //                 case "CLEAR":
        //                     myList.Clear();
        //                     break;
        //             }
        //             numOfPerform--;
        //         }
        //         count--;
        //     }
        //     array.ForEach(Console.WriteLine);
        // }

        public MyList()
        {
            _collection = new List<int>();
        }

        private List<int> _collection;
        public void Push(int num)
        {
            _collection.Add(num);
        }

        public int Top()
        {
            if (_collection.Count == 0)
            {
                return -1;
            }

            return _collection[0];
        }


        public int Pop()
        {
            if (_collection.Count == 0)
            {
                return -1;
            }
            else
            {
                _collection.RemoveAt(0);
                return 1;
            }
        }

        public int Size()
        {
            return _collection.Count;
        }

        public void Clear()
        {
            _collection.Clear();
        }
    }
}