namespace FilesAndFoldersTree
{
    using System;
    using System.Text;

    /*
    03. Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } 
    and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. 
    Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. 
    Use recursive DFS traversal.
    */
    public class Startup
    {
        public static void Main()
        {
            // using the Help folder to shorten the time. 
            // you can try it with C:\Windows too, but it will take some time
            var entryPoint = new Folder("Boot", @"C:\WINDOWS\Boot"); // Using "Boot"/"Help"/"Web" cause Windows has many access denied folders.

            GetSubFolders(entryPoint);

            StringBuilder result = new StringBuilder();
            GetFileSystemString(entryPoint, result, 0);

            Console.WriteLine(result);
        }

        private static void GetFileSystemString(Folder folder, StringBuilder result, int depth)
        {
            string indentation = new string(' ', depth * 4);

            result.AppendLine(string.Format("(Folder)> {0}{1} - size: {2} bytes.", indentation, folder.Name, folder.GetSize()));

            foreach (var file in folder.Files)
            {
                result.AppendLine(string.Format("(File)> {0}-{1} - size: {2} bytes.", indentation, file.Name, file.Size));
            }

            foreach (var subFolder in folder.ChildFolders)
            {
                GetFileSystemString(subFolder, result, depth + 1);
            }
        }

        private static void GetSubFolders(Folder folder)
        {
            foreach (var file in folder.DirectoryInfo.GetFiles())
            {
                folder.Files.Add(new File(file.Name, file.Length));
            }

            foreach (var subDir in folder.DirectoryInfo.GetDirectories())
            {
                var subFolder = new Folder(subDir.Name, subDir.FullName);
                folder.ChildFolders.Add(subFolder);
                GetSubFolders(subFolder);
            }
        }
    }
}
