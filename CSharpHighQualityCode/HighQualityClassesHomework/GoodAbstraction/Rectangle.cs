namespace GoodAbstraction
{
    using System;

    public class Rectangle : Figure
    {
        private const string InvalidWidthMessage = "Width must be a number greater than 0.";
        private const string InvalidHeightMessage = "Height must be a number greater than 0.";

        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException(Rectangle.InvalidWidthMessage);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException(Rectangle.InvalidHeightMessage);
                }

                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}