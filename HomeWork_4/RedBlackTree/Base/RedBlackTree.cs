using RedBlackTree.Base.Enum;

namespace RedBlackTree.Base
{
    public class RedBlackTree
    {
        private Node _root;

        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _root.Color = NodeColor.Black;
            }
            else
            {
                _root = Insert(_root, value);
                _root.Color = NodeColor.Black;
            }
        }

        private Node Insert(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }

            if (IsRed(node.Right) && !IsRed(node.Left))
            {
                node = RotateLeft(node);
            }
            if (IsRed(node.Left) && IsRed(node.Left?.Left))
            {
                node = RotateRight(node);
            }
            if (IsRed(node.Left) && IsRed(node.Right))
            {
                FlipColors(node);
            }

            return node;
        }

        private bool IsRed(Node node)
        {
            if (node == null)
            {
                return false;
            }
            return node.Color == NodeColor.Red;
        }

        private Node RotateLeft(Node node)
        {
            Node x = node.Right;
            node.Right = x.Left;
            x.Left = node;
            x.Color = node.Color;
            node.Color = NodeColor.Red;
            return x;
        }

        private Node RotateRight(Node node)
        {
            Node x = node.Left;
            node.Left = x.Right;
            x.Right = node;
            x.Color = node.Color;
            node.Color = NodeColor.Red;
            return x;
        }

        private void FlipColors(Node node)
        {
            node.Color = NodeColor.Red;
            node.Left.Color = NodeColor.Black;
            node.Right.Color = NodeColor.Black;
        }
    }
}
