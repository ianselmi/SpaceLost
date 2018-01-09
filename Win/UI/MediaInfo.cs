using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace SpaceLost.Win.UI
{
    [Serializable()]
    public class MediaInfo : Collection<FileInfo>
    {
        private string _mediaName = null;
        private long _mediaSize = 0;

        public string MediaName
        {
            get { return _mediaName; }
            set { _mediaName = value; }
        }

        public long MediaSize
        {
            get { return _mediaSize; }
        }

        public new void Add(FileInfo fi)
        {
            _mediaSize += fi.Length;
            base.Add(fi);
        }

        public new void Remove(FileInfo fi)
        {
            _mediaSize -= fi.Length;
            base.Remove(fi);
        }

        public MediaInfo()
        {
        }

        public MediaInfo(string basePath)
        {
            foreach (string fileName in Directory.GetFiles(basePath))
            {
                this.Add(new FileInfo(fileName));
            }
        }

        public string NameAndSize
        {
            get { return String.Format("{0}-{1}", _mediaName, _mediaSize); }
        }

        public new ReadOnlyCollection<FileInfo> Items
        {
            get
            {
                return new ReadOnlyCollection<FileInfo>(base.Items);
            }
        }

        public List<string> GetListOfFiles()
        {
            List<string> listOfFile = new List<string>(this.Items.Count);
            foreach (FileInfo fi in this.Items)
            {
                listOfFile.Add(fi.FullName);
            }
            return listOfFile;
        }
    }
}