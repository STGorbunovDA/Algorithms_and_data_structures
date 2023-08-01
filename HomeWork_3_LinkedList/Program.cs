using LinkedList.Model;

namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            #region Односвязный

            var list = new Model.LinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            Console.WriteLine("Односвязный список: ");
            list.PrintList(list);
            list.Reverse();
            Console.WriteLine("Разворот односвязного списка: ");
            list.PrintList(list);

            #endregion

            #region Двухсвязный

            var duplexList = new DuplexLinkedList<int>()
            {
                6,
                7,
                8,
                9,
                10
            };

            Console.WriteLine("Двухсвязный список: ");
            duplexList.PrintList(duplexList);
            Console.WriteLine("Разворот двухсвязного списка: ");
            duplexList.PrintList(duplexList.Reverse());

            #endregion

            Console.ReadLine();
        }

    }
}
