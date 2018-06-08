using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal class CursorCommandUp : ICommand
    {
        private Cursor.Cursor cursor;

        public CursorCommandUp(Cursor.Cursor cursor)
        {
            this.cursor = cursor;
        }

        public void PeformCommand(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow)
            {
                cursor.CurrentPlace += 1;
            }
        }
    }
}
