using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemViewer.Cursor
{
    internal class Cursor
    {
        private int currenttPlace;
        private int maxValueOfCursor;

        public Cursor()
        {
            currenttPlace = 0;
            maxValueOfCursor = 0;
        }

        public int CurrentPlace
        {
            get { return currenttPlace; }
            set
            {
                if (0 <= value && value < maxValueOfCursor)
                {
                    currenttPlace = value;
                }
            }
        }

        public int MaxValueOfCursor
        {
            get { return maxValueOfCursor; }
            set
            {
                if (value >= 0)
                {
                    maxValueOfCursor = value;
                }
            }
        }
    }
}
