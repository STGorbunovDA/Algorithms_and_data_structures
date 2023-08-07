using RedBlackTree.Base.Enum;

namespace RedBlackTree.Base
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public NodeColor Color { get; set; }

        public Node(int value)
        {
            Value = value;
            Color = NodeColor.Red;
        }
    }
}
