using System;

namespace MyAlgorithms.Lists
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        private MyLinkedListNode<T> Head { get; set; }
        private MyLinkedListNode<T> Tail { get; set; }

        public int Count { get; set; }

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public MyLinkedListNode<T> GetNodeAt(int index)
        {
            CheckIndex(index);

            if (index == 0) return Head;
            if (index == Count - 1) return Tail;

            var cur = Head;
            while (index > 0)
            {
                cur = cur.Next;
                index--;
            }

            return cur;
        }

        public void InsertAt(T data, int index)
        {
            CheckIndex(index);
            if (index == 0)
            {
                Prepend(data);
            }
            else if (index == Count - 1)
            {
                Append(data);
            }
            else
            {
                var pre = Head;
                var i = 0;
                while (i < index - 1)
                {
                    pre = pre.Next;
                    i++;
                }

                var newNode = new MyLinkedListNode<T>(data);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                Count++;
            }
        }

        public void Prepend(T data)
        {
            var node = new MyLinkedListNode<T>(data);
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

            Count++;
        }


        public void Append(T data)
        {
            var node = new MyLinkedListNode<T>(data);
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            Count++;
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);
            if (index == 0)
            {
                Head = Head.Next;
                Count--;
            }
            else if (index == Count - 1)
            {
                var cur = Head;
                while (cur.Next != Tail)
                {
                    cur = cur.Next;
                }

                Tail = cur;
                cur.Next = null;
                Count--;
            }
            else
            {
                var pre = Head;
                var i = 0;
                while (i < index - 1)
                {
                    pre = pre.Next;
                    i++;
                }

                pre.Next = pre.Next.Next;
                Count--;
            }
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }


        public class MyLinkedListNode<T> : IComparable<MyLinkedListNode<T>> where T : IComparable<T>
        {
            public T Data { get; set; }
            public MyLinkedListNode<T> Next { get; set; }

            public MyLinkedListNode(T data = default, MyLinkedListNode<T> node = null)
            {
                Data = data;
            }

            public int CompareTo(MyLinkedListNode<T> other)
            {
                if (other == null) return -1;

                return Data.CompareTo(other.Data);
            }
        }
    }
}