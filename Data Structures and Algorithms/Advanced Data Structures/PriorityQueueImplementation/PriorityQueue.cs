namespace PriorityQueueImplementation
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T>
    {
        private const int InitialCapacity = 8;

        private T[] data;
        private int size;
        private Comparison<T> comparator;

        public PriorityQueue()
        {
            this.Create(InitialCapacity, null);
        }

        public PriorityQueue(Comparison<T> comparator)
        {
            this.Create(InitialCapacity, comparator);
        }

        public PriorityQueue(int capacity)
        {
            this.Create(capacity, null);
        }

        public PriorityQueue(int capacity, Comparison<T> comparison)
        {
            this.Create(capacity, comparison);
        }

        private void Create(int capacity, Comparison<T> customComparator)
        {
            this.data = new T[capacity];
            this.comparator = customComparator;
            if (this.comparator == null)
            {
                this.comparator = Comparer<T>.Default.Compare;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void Insert(T item)
        {
            if (this.size == this.data.Length) this.Resize();
            this.data[this.size] = item;
            this.HeapifyUp(this.size);
            this.size++;
        }

        public T Peak()
        {
            return this.data[0];
        }

        public T Pop()
        {
            T item = this.data[0];
            this.size--;
            this.data[0] = this.data[this.size];
            this.HeapifyDown(0);
            return item;
        }

        private void Resize()
        {
            T[] resizedData = new T[this.data.Length * 2];
            Array.Copy(this.data, 0, resizedData, 0, this.data.Length);
            this.data = resizedData;
        }

        private void HeapifyUp(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (this.comparator.Invoke(this.data[childIndex], this.data[parentIndex]) > 0)
                {
                    // swap parent and child
                    T t = this.data[parentIndex];
                    this.data[parentIndex] = this.data[childIndex];
                    this.data[childIndex] = t;
                    this.HeapifyUp(parentIndex);
                }
            }
        }

        private void HeapifyDown(int parentIndex)
        {
            int leftChildIndex = 2 * parentIndex + 1;
            int rightChildIndex = leftChildIndex + 1;
            int largestChildIndex = parentIndex;
            if (leftChildIndex < this.size && this.comparator.Invoke(this.data[leftChildIndex], this.data[largestChildIndex]) > 0)
            {
                largestChildIndex = leftChildIndex;
            }
            if (rightChildIndex < this.size && this.comparator.Invoke(this.data[rightChildIndex], this.data[largestChildIndex]) > 0)
            {
                largestChildIndex = rightChildIndex;
            }
            if (largestChildIndex != parentIndex)
            {
                T t = this.data[parentIndex];
                this.data[parentIndex] = this.data[largestChildIndex];
                this.data[largestChildIndex] = t;
                this.HeapifyDown(largestChildIndex);
            }
        }
    }
}
