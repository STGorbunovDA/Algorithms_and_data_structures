namespace LinkedList.Model.Base
{
    public class DuplexNode<T>
    {
        public T Data { get; set; }
        public DuplexNode<T> Previous { get; set; }
        public DuplexNode<T> Next { get; set; }

        public DuplexNode(T data)
        {
            Data = data;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
