using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceLost.Win.UI
{
    public partial class frmDetails : Form
    {
        private MediaInfo _mediaInfos = null;

        public frmDetails()
        {
            InitializeComponent();
        }

        public void ShowDetails(MediaInfo mi)
        {
            _mediaInfos = mi;
            foreach (FileInfo fi in _mediaInfos)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = fi.DirectoryName;
                lvi.SubItems.Add(fi.Name);
                lvi.SubItems.Add(fi.Length.ToString());
                lvi.Tag = fi;
                lvDetails.Items.Add(lvi);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lvDetails.SelectedItems)
            {                
                FileInfo fi = li.Tag as FileInfo;

                if (fi != null)
                    _mediaInfos.Remove(fi);

                lvDetails.Items.Remove(li);
            }
        }
    }
}