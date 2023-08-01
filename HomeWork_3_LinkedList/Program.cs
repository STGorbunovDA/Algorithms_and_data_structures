using LinkedList.Model;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            var list = new Model.LinkedList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            list.PrintList(list);

            list.Delete(3);
            list.Delete(1);

            list.AppendHead(100);
            list.InsertAfter(100, 200);
            list.PrintList(list);
            //Console.WriteLine(list.Contains(100));
            list.Reverse();
            list.PrintList(list);


            Console.ReadLine();
        }
        
    }
}
