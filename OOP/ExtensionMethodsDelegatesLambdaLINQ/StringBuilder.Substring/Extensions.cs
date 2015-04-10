namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index + length > sb.Length)
            {
                throw new IndexOutOfRangeException("Index + length must be less or equal to the length of the original string");
            }

            StringBuilder result = new StringBuilder();

            for (int i = index; i < length + index; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }
}
