namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception e = null)
            : base(String.Format("{0}Parameter must be between {1} and {2}", message, start, end), e)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) { }

        public T Start
        {
            get 
            { 
                return start; 
            }
            set 
            { 
                start = value; 
            }
        }

        public T End
        {
            get 
            { 
                return end; 
            }
            set 
            { 
                end = value;
            }
        }
    }
}
