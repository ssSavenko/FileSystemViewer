using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal class CursorCommandRight : ICommand
    {
        private FileExplorer fileExplorer;
        public CursorCommandRight(FileExplorer fileExplorer)
        {
            this.fileExplorer = fileExplorer;
        }

        public void PeformCommand(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
            {
                fileExplorer.OpenCurrentDirectory();
            }
        }
    }
}
