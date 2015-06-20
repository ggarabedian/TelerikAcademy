namespace DefiningClassesPart2Main.PathOfPoints
{
    public struct Point3D
    {
        private static readonly Point3D startOfCoordinate;

        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            startOfCoordinate = new Point3D(0, 0, 0);
        }

        public static Point3D StartOfCoordinate
        {
            get { return startOfCoordinate; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.X, this.Y, this.Z);
        }
    }
}
