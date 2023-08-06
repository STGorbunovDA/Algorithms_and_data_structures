using SuperHashTable.Base;

namespace SuperHashTable
{
    public class Program
    {
        public static void Main()
        {
            var superHashTable =  new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Катя", Age = 18, Gender = 1 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}