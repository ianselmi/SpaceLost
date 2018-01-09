using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SpaceLost.Win.UI
{
    public partial class frmMain : Form
    {
        private SpaceLostManager _lsdm = new SpaceLostManager();
        private ReadOnlyCollection<MediaInfo> _allMedia;

        public frmMain()
        {
            InitializeComponent();
            cmbSize.Items.Add(new ListItem("Floppy 1,4 MB", 1470000));
            cmbSize.Items.Add(new ListItem("CD 740 MB", 740000000));
            cmbSize.Items.Add(new ListItem("DVD 4,7 GB", 4700000000));
            cmbSize.SelectedIndex = 2;
        }

        private void cmdStartScan_Click(object sender, EventArgs e)
        {
            pb.Visible = true;
            long maxSize = GetSelectedSize();
            _lsdm.OnGotMedia += new SpaceLostManager.GotMediaHandler(lsdm_OnGotMedia);
            _allMedia = _lsdm.CheckLostSpace(txtPath.Text, maxSize, chkShowInSubFolder.Checked);
            LoadMedias(_allMedia, maxSize);
            pb.Visible = false;
        }

        private void lsdm_OnGotMedia(object sender, MediaStatsEventArgs ms)
        {
            pb.Maximum = (int)ms.FileCount;
            pb.Value = (int)ms.CurrentFileIndex;
            pb.Refresh();
        }

        private long GetSelectedSize()
        {
            ListItem li = cmbSize.SelectedItem as ListItem;
            return li == null ? Convert.ToInt64(cmbSize.Text) : Convert.ToInt64(li.Value);
        }

        private void LoadMedias(ReadOnlyCollection<MediaInfo> allMedia, long maxSize)
        {
            long totSize = 0;
            long totCount = 0;

            lvMedia.Items.Clear();
            foreach (MediaInfo mi in allMedia)
            {
                ListViewItem lvi = new ListViewItem(mi.MediaName);

                lvi.SubItems.Add(mi.Items.Count.ToString());
                lvi.SubItems.Add(mi.MediaSize.ToString());
                lvi.SubItems.Add(maxSize.ToString());
                float percOccupato = ((float)(mi.MediaSize) / (float)maxSize) * 100;
                lvi.SubItems.Add(Convert.ToString(percOccupato));
                lvi.ForeColor = percOccupato > 100.0 ? Color.Red : Color.Black;
                lvi.Tag = mi;
                lvMedia.Items.Add(lvi);
            }

            foreach (MediaInfo mi in allMedia)
            {
                totSize += mi.MediaSize;
                totCount += mi.Count;
            }

            long totAvailableSize = maxSize * allMedia.Count;
            long totFreeSpace = totAvailableSize - totSize;

            lblTotSize.Text = String.Format("{0}", totSize);
            lblAvailableSize.Text = Convert.ToString(totAvailableSize);

            lblTotFreeSpace.Text = Convert.ToString(totFreeSpace);
            lblPercFreeSpace.Text = Convert.ToString(((double)totFreeSpace / (double)totAvailableSize) * 100);
        }

        private void cmdFolderBrowser_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }
        }

        private void lvMedia_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragDropEffects allowedEffects = DragDropEffects.Copy | DragDropEffects.Link | DragDropEffects.Move;
                List<string> filesToDrop = new List<string>();

                foreach (ListViewItem lvi in lvMedia.SelectedItems)
                {
                    MediaInfo mi = (MediaInfo)lvi.Tag;

                    filesToDrop.AddRange(mi.GetListOfFiles());
                }

                DataObject doe = new DataObject(DataFormats.FileDrop, filesToDrop.ToArray());
                lvMedia.DoDragDrop(doe, allowedEffects);
            }
        }

        private void btnDettaglioCompilation_Click(object sender, EventArgs e)
        {
            frmDetails f = new frmDetails();
            if (lvMedia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nessun item selezionato");
                return;
            }
            f.ShowDetails((MediaInfo)lvMedia.SelectedItems[0].Tag);
            f.ShowDialog(this);

            LoadMedias(_allMedia, GetSelectedSize());
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminare la compilation?", "Richiesta", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            MediaInfo mi = (MediaInfo)lvMedia.SelectedItems[0].Tag;

            foreach (FileInfo fi in mi)
            {
                fi.Delete();
            }

            lvMedia.Items.Remove(lvMedia.SelectedItems[0]);
        }
    }
}