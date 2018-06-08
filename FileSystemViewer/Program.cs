using System.IO;
using System;

namespace FileSystemViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFiles = new CompositeOfFoldersAndFiles.Folder(new DirectoryInfo("C:\\"));
            myFiles.Open();
            myFiles.ShowInfo();
            Console.ReadKey();
        }
    }
}
