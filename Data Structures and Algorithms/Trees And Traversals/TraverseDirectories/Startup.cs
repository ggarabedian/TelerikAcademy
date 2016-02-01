namespace TraverseDirectories
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    /*
    02.Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all 
    files matching the mask *.exe. Use the class System.IO.Directory.
    */
    public class Startup
    {
        public static void Main()
        {
            TraverseDirectory(@"C:\WINDOWS");
        }

        private static void TraverseDirectory(string dirPath)
        {
            foreach (var directory in Directory.GetDirectories(dirPath))
            {
                try
                {
                    foreach (var file in Directory.GetFiles(directory, "*.exe"))
                    {
                        Console.WriteLine(file);
                    }
                }
                catch (UnauthorizedAccessException uae)
                {
                    Console.WriteLine("Access to {0} is forbidden!", directory);
                }
            }
        }
    }
}
