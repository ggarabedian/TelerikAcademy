namespace DefiningClassesPart2Main.PathOfPoints
{
    using System;
    using System.IO;

    public class PathOfPointsMain
    {
        static void Main()
        {
            Path pathOfPoints = new Path();

            for (int i = 0; i < 3; i++)
            {
                Point3D point = new Point3D((i * 2) + 0.1d, i + 0.4d, (i * 3) + 0.7d);
                pathOfPoints.AddPoint(point);
            }

            PathStorage.SavePaths(pathOfPoints, "../../PathToSave.txt");

            Path textFilePath = PathStorage.LoadPaths("../../PathToLoad.txt");

            Console.WriteLine(textFilePath.ToString());
        }
    }
}
