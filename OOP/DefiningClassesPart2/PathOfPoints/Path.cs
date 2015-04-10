namespace DefiningClassesPart2Main.PathOfPoints
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> path;

        public Path()
            : base()
        {
            this.path = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }

        public int PointsInPath()
        {
            return this.path.Count;
        }

        public override string ToString()
        {
            return string.Join(" <-> ", this.path);
        }
    }
}
