using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal class CursorCommands
    {
        private ICommand[] commands;

        public CursorCommands(Cursor.Cursor cursor, FileExplorer fileExplorer)
        {
            commands = new ICommand[]
            {
                new CursorCommandDown(cursor),
                new CursorCommandUp(cursor),
                new CursorCommandRight(fileExplorer),
                new CursorCommandLeft(fileExplorer)
            };
        }

        public void PerformCommands(ConsoleKey key)
        {
            for (int i = 0; i < commands.Length;i++)
            {
                commands[i].PeformCommand(key);
            }
        }
    }
}
