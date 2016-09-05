using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpaceLost.Win.UI
{
    public class SpaceLostManager
    {
        public delegate void GotMediaHandler(object sender, MediaStatsEventArgs ms);
        public event GotMediaHandler OnGotMedia;
       

        public ReadOnlyCollection <MediaInfo> CheckLostSpace(string basePath, long maxMediaSize, bool showInSubFolder)
        {
            List<MediaInfo> medias = new List<MediaInfo>();

            SearchOption so = showInSubFolder ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            string []allFiles = Directory.GetFiles(basePath, "*.*", so);

            for (int  fileIndex =0; fileIndex<allFiles.Length; fileIndex++) 
            {                
                string filename = allFiles[fileIndex];

                if (OnGotMedia != null)
                    OnGotMedia(this, new MediaStatsEventArgs(filename, allFiles.Length, fileIndex));

                FileInfo fi = new FileInfo(filename);

                MediaInfo bestMedia = GetBestMedia(fi.Length, medias, maxMediaSize);

                bestMedia.Add(fi);
                if (bestMedia.MediaName == null)
                    bestMedia.MediaName = string.Format("Media{0:000}", medias.Count);

                
            }

            // Ordina per dimensione crescente
            SortedList<string, MediaInfo> sl = new SortedList<string, MediaInfo>();
            int c = 0;
            foreach (MediaInfo mi in medias)
            {                
                sl.Add(mi.MediaSize.ToString().PadLeft(20, '0') + c.ToString(), mi);
                c++;
            }

            return new ReadOnlyCollection<MediaInfo>(sl.Values);
        }

        private MediaInfo GetBestMedia(long fileLen, List<MediaInfo> medias, long maxMediaSize)
        {             
            foreach (MediaInfo mi in medias)
            {
                if (mi.MediaSize + fileLen <= maxMediaSize)
                    return mi;
            }
            MediaInfo newMi = new MediaInfo();
            medias.Add(newMi);
            return newMi;        
        }
        

    }
}

