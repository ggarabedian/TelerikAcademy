namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }

        public override string ToString()
        {
            return string.Format("I am a rectangle, my width is {0}, my height is {1} and my area is ", this.Width, this.Height);
        }
    }
}
