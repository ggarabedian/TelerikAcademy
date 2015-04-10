namespace DefiningClassesPart2Main.PathOfPoints
{
    using System;
    using System.Linq;
    using System.IO;

    public class PathStorage
    {
        public static void SavePaths(Path path, string filePath)
        {
            File.WriteAllText(filePath, path.ToString());
        }

        public static Path LoadPaths(string filePath)
        {
            Path path = new Path();

            string[] points = File.ReadAllText(filePath).Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < points.Length; i++)
            {
                double[] coordinates = points[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(double.Parse)
                                                .ToArray();
                path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
            }

            return path;
        }
    }
}
