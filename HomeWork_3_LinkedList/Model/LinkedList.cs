using LinkedList.Model.Base;
using LinkedList.Model.Base.Interface;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary> Односвязный список. </summary>
    public class LinkedList<T> : IEnumerable, IPrintList<LinkedList<T>>
    {
        /// <summary> Первый элемент списка. </summary>
        public Node<T> Head { get; private set; }

        /// <summary> Последний элемент списка.</summary>
        public Node<T> Tail { get; private set; }

        /// <summary> Кол-во элеметов в списке. </summary>
        public int Count { get; private set; }

        /// <summary> Создать пустой список. </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary> Создать список с начальнм элементом. </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary> Добавить данные в конец списка</summary>
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Node<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else SetHeadAndTail(data);

        }
        /// <summary> Удалить первое вхождение данных в список. </summary>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }
        /// <summary> Добавить данные в начало списка. </summary>
        public void AppendHead(T data)
        {
            var item = new Node<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }

        /// <summary> Добавить данные после искомого элемента. </summary>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Node<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else current = current.Next;
                }
            }
        }

        /// <summary> Очистить список. </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
            //P.s. сборщик мусора разберётся
        }


        /// <summary> Проверить наличие элемента в списке. </summary>
        public bool Contains(T data)
        {
            var current = Head;
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data)) return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary> Разворот односвязного списка. </summary>
        public void Reverse()
        {
            var current = Head;
            Node<T> previous = null;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Head = previous;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Node<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary> Получить перечесление всех элементов списка. </summary>
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
        public void PrintList(LinkedList<T> list)
        {
            Console.Write("[ ");

            foreach (var item in list)
                Console.Write(item + " ");

            Console.WriteLine($"] size: {list.Count}");
        }
    }
}
