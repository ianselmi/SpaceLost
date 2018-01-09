using System;

namespace SpaceLost.Win.UI
{
    public class MediaStatsEventArgs : EventArgs
    {
        public string CurrentFileName { get; private set; }
        public long FileCount { get; private set; }
        public long CurrentFileIndex { get; private set; }

        public MediaStatsEventArgs(string filename, long fileCount, long currentFileIndex)
        {
            CurrentFileName = filename;
            FileCount = fileCount;
            CurrentFileIndex = currentFileIndex;
        }
    }
}