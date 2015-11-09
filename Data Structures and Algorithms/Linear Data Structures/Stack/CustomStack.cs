namespace Stack
{
    using System;

    public class CustomStack<T>
    {
        private T[] items;

        public CustomStack()
        {
            this.items = new T[4];
        }

        //// For testing
        public T[] Items
        {
            get
            {
                return this.items;
            }
        }

        public int Count { get; private set; }

        public void Push(T value)
        {
            if (this.Count >= this.items.Length)
            {
                Array.Resize(ref this.items, this.items.Length * 2);
            }

            this.items[this.Count] = value;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException("Can't pop values from empty stack.");
            }

            T result = this.items[this.Count - 1];
            this.Count--;

            return result;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException("Can't peek values from empty stack.");
            }

            return this.items[this.Count - 1];
        }
    }
}
