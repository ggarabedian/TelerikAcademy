namespace Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2.0;
        }

        public override string ToString()
        {
            return string.Format("I am a triangle, my side is {0}, my height is {1} and my area is ", this.Width, this.Height);
        }
    }
}
