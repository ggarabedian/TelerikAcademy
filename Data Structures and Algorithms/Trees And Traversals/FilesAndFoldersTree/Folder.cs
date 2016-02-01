namespace FilesAndFoldersTree
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Folder
    {
        public Folder(string name, string fullPath)
        {
            this.Name = name;
            this.DirectoryInfo = new DirectoryInfo(fullPath);
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public DirectoryInfo DirectoryInfo { get; set; }

        public long GetSize()
        {
            return this.Files.Sum(file => file.Size) + this.ChildFolders.Sum(folder => folder.GetSize());
        }
    }
}
