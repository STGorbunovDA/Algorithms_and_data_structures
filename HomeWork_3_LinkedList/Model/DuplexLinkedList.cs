using LinkedList.Model.Base;
using LinkedList.Model.Base.Interface;
using System.Collections;

namespace LinkedList.Model
{
    public class DuplexLinkedList<T> : IEnumerable, IPrintList<DuplexLinkedList<T>>
    {
        /// <summary> Первый элемент списка. </summary>
        public DuplexNode<T> Head { get; private set; }

        /// <summary> Последний элемент списка.</summary>
        public DuplexNode<T> Tail { get; private set; }

        /// <summary> Кол-во элеметов в списке. </summary>
        public int Count { get; set; }

        public DuplexLinkedList() { }

        public DuplexLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new DuplexNode<T>(data);
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
            else SetHeadAndTail(data);
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current != null) 
            {
                if(current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();
            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new DuplexNode<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary> Печать данных. </summary>
        public void PrintList(DuplexLinkedList<T> list)
        {
            Console.Write("[ ");

            foreach (var item in list)
                Console.Write(item + " ");

            Console.WriteLine($"] size: {list.Count}");
        }
    }
}
