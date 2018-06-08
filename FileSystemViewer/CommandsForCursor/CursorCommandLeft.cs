using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal class CursorCommandLeft : ICommand
    {
        private FileExplorer fileExplorer;

        public CursorCommandLeft(FileExplorer fileExplorer)
        {
            this.fileExplorer = fileExplorer;
        }

        public void PeformCommand(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                fileExplorer.CloseCurrentDirectory();
            }
        }
    }
}
