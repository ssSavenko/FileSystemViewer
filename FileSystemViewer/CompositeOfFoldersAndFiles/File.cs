using System;
using System.IO;
using System.Text;

namespace FileSystemViewer.CompositeOfFoldersAndFiles
{
    internal class File : IComponent
    {
        FileInfo currentFile;
        double currentFileSize;
        int spacing = 0;

        public File(FileInfo currentFile, int spacing = 0)
        {
            this.currentFile = currentFile;
            currentFileSize = currentFile.Length;
            this.spacing = spacing;
        }

        public File()
        {
        }

        public void Open()
        {
            
        }

        public int GetCountOfElements()
        {
            return 1;
        }

        public int Spacing
        {
            get { return spacing; }
            set
            {
                if (value > 0)
                {
                    spacing = value;
                }
            }
        }

        public void ShowInfo()
        {
           
            string spaces = new string(' ', spacing * 2);
            Console.WriteLine(spaces + currentFile.Name);
        }

        public void Close()
        {

        }

        public int CloseCertainComponent(int numberOfComponent)
        {
            if (numberOfComponent != 0)
            {
                numberOfComponent--;
            }
            return numberOfComponent;
        }

        public int OpenCertainComponent(int numberOfComponent)
        {
            if (numberOfComponent != 0)
            {
                numberOfComponent--;
            }
            return numberOfComponent;
        }
    }
}
