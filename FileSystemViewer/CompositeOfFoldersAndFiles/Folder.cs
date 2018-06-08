using System;
using System.IO;
using System.Text;

namespace FileSystemViewer.CompositeOfFoldersAndFiles
{
    internal class Folder : IComponent
    {
        private DirectoryInfo currentDirectory;
        private IComponent[] componentsOfCurrentDirectory;
        static int counter;
        int spacing = 0;

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

        public Folder(DirectoryInfo currentDirectory, int spacing = 0)
        {
            this.currentDirectory = currentDirectory;
            componentsOfCurrentDirectory = null;
            this.spacing = spacing;
        }

        public void Open()
        {
            if (componentsOfCurrentDirectory == null)
            {
                var folderDirectories = currentDirectory.GetDirectories();
                var fileDirectories = currentDirectory.GetFiles();
                componentsOfCurrentDirectory = new IComponent[folderDirectories.Length + fileDirectories.Length];
                int i = 0;

                foreach (var directory in folderDirectories)
                {
                    componentsOfCurrentDirectory[i] = new Folder(folderDirectories[i], spacing + 1);
                    i++;
                }

                for (int j = 0; j < fileDirectories.Length; j++, i++)
                {
                    componentsOfCurrentDirectory[i] = new File(fileDirectories[j], spacing + 1);
                }
            }
        }

        public void ShowInfo()
        {
            string spaces = new string(' ', spacing * 2);
            Console.WriteLine(spaces + currentDirectory.Name);
            spacing++;
            if (componentsOfCurrentDirectory != null)
            {
                foreach (var component in componentsOfCurrentDirectory)
                {
                    if (component != null)
                    {
                        component.ShowInfo();
                    }
                }
            }
            spacing--;
        }

        public void Close()
        {
            if (currentDirectory.Parent != null)
            {
                componentsOfCurrentDirectory = null;
            }
        }

        public int GetCountOfElements()
        {
            int countOfElments = 1;
            for (int i = 0; i < componentsOfCurrentDirectory.Length; i++)
            {
                countOfElments += componentsOfCurrentDirectory[i].GetCountOfElements();
            }
            return countOfElments;
        }

        public int OpenCertainComponent(int numberOfComponent);

        public IComponent GetDirectory(int numberOfElement)
        {
            return this;
        }

        public IComponent this[int index]
        {
            get
            {
                IComponent directoryForReturn;
                counter = 0;
                foreach(var directory in componentsOfCurrentDirectory)
                {
                    directoryForReturn = directory.GetDirectory(index);
                }

                return directoryForReturn;
            }
            set { }
        }
    }
}