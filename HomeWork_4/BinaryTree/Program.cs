using BinaryTree.Base;

namespace BinaryTree
{
    public class Program
    {
        public static void Main()
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            Console.WriteLine("Префиксный обход дерева: ");
            foreach (var item in tree.Preorder()) 
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Постфиксный обход дерева: ");
            foreach (var item in tree.Postorder())
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Инфиксный обход дерева: ");
            foreach (var item in tree.Inorder())
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();
        }
    }
}