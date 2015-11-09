namespace LinkedListImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class CustomLinkedList<T> : ICollection<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void AddFirst(T value)
        {
            ListItem<T> toAdd = new ListItem<T>();

            toAdd.Value = value;
            toAdd.NextItem = this.FirstElement;

            this.FirstElement = toAdd;
            this.Count++;
        }

        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>();

                this.FirstElement.Value = value;
                this.FirstElement.NextItem = null;
            }
            else
            {
                ListItem<T> toAdd = new ListItem<T>();
                toAdd.Value = value;

                ListItem<T> current = this.FirstElement;
                while (current.NextItem != null)
                {
                    current = current.NextItem;
                }

                current.NextItem = toAdd;
            }

            this.Count++;
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
            this.Count--;
        }

        public void Clear()
        {
            this.Count = 0;
            this.FirstElement = null;
        }

        public bool Contains(T item)
        {
            ListItem<T> currentItem = this.FirstElement;
            while (currentItem != null)
            {
                if (currentItem.Value.Equals(item))
                {
                    return true;
                }

                currentItem = currentItem.NextItem;
            }

            return false;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            ListItem<T> currentItem = this.FirstElement;
            while (currentItem != null)
            {
                yield return currentItem.Value;
                currentItem = currentItem.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        //// No reason to implement those. ICollection is used just for "string.Join" operation.
        public void Add(T item)
        {
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
        }

        public bool Remove(T item)
        {
            return false;
        }
    }
}
