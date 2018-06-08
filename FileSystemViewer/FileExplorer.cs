using FileSystemViewer.CompositeOfFoldersAndFiles;
using System;
using System.IO;
using System.Text;

namespace FileSystemViewer
{
    class FileExplorer
    {
        CompositeOfFoldersAndFiles.IComponent[] drives;
        Cursor.Cursor cursor;
        int countOfOpenedComponents;
        CommandsForCursor.CursorCommands commands;

        public FileExplorer()
        {
            var namesOfDrives = Directory.GetLogicalDrives();
            drives = new CompositeOfFoldersAndFiles.IComponent[namesOfDrives.Length];
            countOfOpenedComponents = namesOfDrives.Length;

            commands = new CommandsForCursor.CursorCommands(cursor, this);

            for (int i = 0; i < countOfOpenedComponents; i++)
            {
                drives[i] = new Folder(new DirectoryInfo(namesOfDrives[i]));
            }
        }

        public void CloseCurrentDirectory()
        {
            int placeOfCursor = cursor.CurrentPlace;
            cursor.CurrentPlace = 0;
            for (int i =0;i < drives.Length && placeOfCursor != 0; i++)
            {
                placeOfCursor = drives[i].CloseCertainComponent(placeOfCursor);
                cursor.CurrentPlace += drives[i].GetCountOfElements();
            }
        }

        public void OpenCurrentDirectory()
        {
            int placeOfCursor = cursor.CurrentPlace;
            cursor.MaxValueOfCursor = 0;
            for (int i = 0; i < drives.Length && placeOfCursor != 0; i++)
            {
                placeOfCursor = drives[i].OpenCertainComponent(placeOfCursor);
                cursor.MaxValueOfCursor += drives[i].GetCountOfElements();
            }
        }

        public void ShowFileInfo()
        {
            for (int i = 0; i < drives.Length; i++)
            {
                drives[i].ShowInfo();
            }
        }
    }
}
