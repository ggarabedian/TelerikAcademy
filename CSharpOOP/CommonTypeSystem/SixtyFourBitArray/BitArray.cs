namespace SixtyFourBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BitArray : IEnumerable<int>, IComparable
    {
        private ulong number;

        public BitArray(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get 
            {
                return number; 
            }
            set 
            { 
                number = value; 
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index out of range. Must be between 0 and 64");
                }

                return ((int)(this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index out of range. Must be between 0 and 64");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Bit value must be 0 or 1");
                }

                if (((int)(this.Number >> index) & 1) != value)
                {
                    this.Number ^= (1ul << index);
                }
            }
        }

        public static bool operator ==(BitArray firstArray, BitArray secondArray)
        {
            return (firstArray.Equals(secondArray));
        }

        public static bool operator !=(BitArray firstArray, BitArray secondArray)
        {
            return !(firstArray.Equals(secondArray));
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int index = 64; index >= 0; index--)
            {
                result.Append((this.Number >> index) & 1);
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int index = 0; index < 64; index++)
            {
                yield return this[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray).Number);
        }
    }
}