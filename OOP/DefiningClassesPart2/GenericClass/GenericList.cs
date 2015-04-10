namespace DefiningClassesPart2Main.GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int InitialCapacity = 4;
        private const int InitialIndex = 0;

        private int capacity;
        private T[] genericListArr;
        private int currentIndex;

        public GenericList()
            : base()
        {
            this.Capacity = InitialCapacity;
            this.currentIndex = InitialIndex;
            this.genericListArr = new T[capacity];
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public T this[int index]
        {
            get
            {
                IndexRange(index);
                return this.genericListArr[index];
            }
            set
            {
                IndexRange(index);
                this.genericListArr[index] = value;
            }
        }

        public void AddElement(T element)
        {
            if (this.currentIndex >= Capacity)
            {
                IncreaseCapacity();
                this.genericListArr[currentIndex] = element;
            }
            else
            {
                this.genericListArr[currentIndex] = element;
            }
            this.currentIndex++;
        }

        public void RemoveElement(int index)
        {
            if (index > this.genericListArr.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            T[] currentArr = new T[capacity - 1];
            for (int i = 0; i < index; i++)
            {
                currentArr[i] = this.genericListArr[i];
            }
            for (int i = index; i < this.genericListArr.Length - 1; i++)
            {
                currentArr[i] = this.genericListArr[i + 1];
            }
            this.currentIndex--;
            this.Capacity = this.genericListArr.Length;
            this.genericListArr = currentArr;
        }

        public void InsertElement(T element, int index)
        {
            IndexRange(index);

            if (currentIndex + 1 == this.genericListArr.Length)
            {
                IncreaseCapacity();
            }

            for (int i = currentIndex + 1; i > index; i--)
            {
                this.genericListArr[i] = this.genericListArr[i - 1];
            }

            this.genericListArr[index] = element;
            currentIndex++;
        }

        public T ElementAtIndex(int index)
        {
            IndexRange(index);

            return genericListArr[index];
        }


        public void Clear()
        {
            this.genericListArr = new T[InitialCapacity];
        }

        public int FindElementByValue(T value) // returns index
        {
            int index = -1;
            for (int i = 0; i < this.genericListArr.Length; i++)
            {
                if (this.genericListArr[i].CompareTo(value) == 0)
                {
                    index = i;
                }
            }

            if (index >= 0)
            {
                return index;
            }
            else
            {
                throw new ArgumentException("The list does not contain that element");
            }
        }

        public T Max()
        {
            T result = default(T);

            if (this.currentIndex > 0)
            {
                result = this.genericListArr[0];

                for (int i = 1; i < this.currentIndex; i++)
                {
                    if (result.CompareTo(this.genericListArr[i]) < 0)
                    {
                        result = this.genericListArr[i];
                    }
                }
            }

            return result;
        }

        public T Min()
        {
            T result = default(T);

            if (this.currentIndex > 0)
            {
                result = this.genericListArr[0];

                for (int i = 1; i < this.currentIndex; i++)
                {
                    if (result.CompareTo(this.genericListArr[i]) > 0)
                    {
                        result = this.genericListArr[i];
                    }
                }
            }

            return result;
        }

        private void IncreaseCapacity()
        {
            Capacity = Capacity * 2;
            T[] newGenericListArr = new T[Capacity];

            for (int i = 0; i < genericListArr.Length; i++)
            {
                newGenericListArr[i] = genericListArr[i];
            }

            this.genericListArr = newGenericListArr;
        }

        private void IndexRange(int index)
        {
            if (index < 0 || index > this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", this.genericListArr);
        }
    }
}
