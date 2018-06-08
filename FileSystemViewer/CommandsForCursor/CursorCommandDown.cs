using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.CommandsForCursor
{
    internal class CursorCommandDown : ICommand
    {
        private Cursor.Cursor cursor;

        public CursorCommandDown(Cursor.Cursor cursor)
        {
            this.cursor = cursor;
        }

        public void PeformCommand(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
            {
                cursor.CurrentPlace += 1;
            }
        }
    }
}
