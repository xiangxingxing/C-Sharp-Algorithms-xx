using System;
using System.Collections.Generic;

namespace OnlineTest
{
    public class MyQueue
    {
        // public static void Main(string[] args)
        // {
        //     var myQueue = new MyQueue();
        //     var numOfPerform = int.Parse(Console.ReadLine().Trim());
        //     var array = new List<int>();
        //     while (numOfPerform > 0)
        //     {
        //         var perform = Console.ReadLine().Trim();
        //         var numToBeAdd = 0;
        //         if (perform.Contains("add"))
        //         {
        //             var strings = perform.Split();
        //             perform = strings[0];
        //             numToBeAdd = int.Parse(strings[1]);
        //         }
        //         switch (perform)
        //         {
        //             case "add":
        //                 myQueue.Add(numToBeAdd);
        //                 break;
        //             case "peek":
        //                 var peek = myQueue.Peek();
        //                 if (peek != int.MinValue)
        //                 {
        //                     array.Add(peek);
        //                 }
        //                 break;
        //             case "poll":
        //                 myQueue.Poll();
        //                 break;
        //         }
        //         numOfPerform--;
        //     }
        //     
        //     array.ForEach(Console.WriteLine);
        // }
        private Stack<int> _stack1;
        private Stack<int> _stack2;

        public MyQueue()
        {
            _stack1 = new Stack<int>();
            _stack2 = new Stack<int>();
        }

        public void Add(int num)
        {
            if (_stack1.Count > 0 && _stack2.Count > 0)
            {
                return;
            }
            if (_stack1.Count == 0)
            {
                _stack1.Push(num);
                return;
            }

            if (_stack2.Count == 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
                
                _stack1.Push(num);
            }
        }

        public void Poll()
        {
            if (_stack1.Count == 0 && _stack2.Count == 0)
            {
                return;
            }
            
            if (_stack2.Count > 0)
            {
                _stack2.Pop();
                return;
            }

            if (_stack1.Count > 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }

                _stack2.Pop();
            }
        }

        public int Peek()
        {
            if (_stack2.Count > 0)
            {
                return _stack2.Peek();
            }

            if (_stack1.Count > 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }

                return _stack2.Peek();
            }

            return int.MinValue;
        }
    }
}