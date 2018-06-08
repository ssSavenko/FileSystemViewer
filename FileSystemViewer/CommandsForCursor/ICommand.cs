using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal interface ICommand
    {
        void PeformCommand(ConsoleKey key);
    }
}
