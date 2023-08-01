namespace LinkedList.Model.Base
{
    /// <summary> Ячейка списка.</summary>
    public class Node<T>
    {
        // Использование "default(T)" обеспечит инициализацию поля "data" с его значением по умолчанию
        private T data = default;

        /// <summary> хранимые в ячейке списка. </summary>
        public T Data
        {
            get => data;
            set => data = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary> Следующая ячейка списка </summary>
        public Node<T> Next { get; set; }

        public Node(T data) => Data = data;

        public override string ToString() => Data.ToString();
    }
}
