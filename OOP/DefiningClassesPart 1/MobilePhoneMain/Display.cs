namespace MobilePhoneMain
{
    using System;
    using System.Text;

    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
            : base()
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size must be greater than zero");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of colors must be greater than zero");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder toStringOverride = new StringBuilder();

            toStringOverride.AppendLine(string.Format("Display size: {0}", this.Size));
            toStringOverride.AppendLine(string.Format("Colors: {0}", this.NumberOfColors));

            return toStringOverride.ToString();
        }
    }
}
