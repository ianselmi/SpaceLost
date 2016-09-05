namespace SpaceLost.Win.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdStartScan = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbMediaInfo = new System.Windows.Forms.GroupBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDettaglioCompilation = new System.Windows.Forms.Button();
            this.lvMedia = new XPExplorerBar.XPListView();
            this.chNomeMedia = new System.Windows.Forms.ColumnHeader();
            this.chNumeroFiles = new System.Windows.Forms.ColumnHeader();
            this.chDimensioneTotaleFiles = new System.Windows.Forms.ColumnHeader();
            this.chDimensioneMassima = new System.Windows.Forms.ColumnHeader();
            this.chPercOccupato = new System.Windows.Forms.ColumnHeader();
            this.lblAvailableSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPercFreeSpace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotFreeSpace = new System.Windows.Forms.Label();
            this.lblTotSize = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowInSubFolder = new System.Windows.Forms.CheckBox();
            this.cmdFolderBrowser = new System.Windows.Forms.Button();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMediaInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStartScan
            // 
            this.cmdStartScan.Location = new System.Drawing.Point(7, 103);
            this.cmdStartScan.Name = "cmdStartScan";
            this.cmdStartScan.Size = new System.Drawing.Size(87, 23);
            this.cmdStartScan.TabIndex = 0;
            this.cmdStartScan.Text = "Analizza";
            this.cmdStartScan.UseVisualStyleBackColor = true;
            this.cmdStartScan.Click += new System.EventHandler(this.cmdStartScan_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(79, 28);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(198, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "c:\\WINDOWS";
            // 
            // gbMediaInfo
            // 
            this.gbMediaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMediaInfo.Controls.Add(this.btnDeleteFile);
            this.gbMediaInfo.Controls.Add(this.btnDettaglioCompilation);
            this.gbMediaInfo.Controls.Add(this.lvMedia);
            this.gbMediaInfo.Location = new System.Drawing.Point(0, 150);
            this.gbMediaInfo.Name = "gbMediaInfo";
            this.gbMediaInfo.Size = new System.Drawing.Size(694, 241);
            this.gbMediaInfo.TabIndex = 8;
            this.gbMediaInfo.TabStop = false;
            this.gbMediaInfo.Text = "Media info";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(117, 202);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(203, 23);
            this.btnDeleteFile.TabIndex = 13;
            this.btnDeleteFile.Text = "Elimina file della compilation";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDettaglioCompilation
            // 
            this.btnDettaglioCompilation.Location = new System.Drawing.Point(6, 202);
            this.btnDettaglioCompilation.Name = "btnDettaglioCompilation";
            this.btnDettaglioCompilation.Size = new System.Drawing.Size(87, 23);
            this.btnDettaglioCompilation.TabIndex = 12;
            this.btnDettaglioCompilation.Text = "Dettaglio";
            this.btnDettaglioCompilation.UseVisualStyleBackColor = true;
            this.btnDettaglioCompilation.Click += new System.EventHandler(this.btnDettaglioCompilation_Click);
            // 
            // lvMedia
            // 
            this.lvMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMedia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNomeMedia,
            this.chNumeroFiles,
            this.chDimensioneTotaleFiles,
            this.chDimensioneMassima,
            this.chPercOccupato});
            this.lvMedia.FullRowSelect = true;
            this.lvMedia.Location = new System.Drawing.Point(6, 20);
            this.lvMedia.Name = "lvMedia";
            this.lvMedia.Size = new System.Drawing.Size(689, 176);
            this.lvMedia.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMedia.TabIndex = 11;
            this.lvMedia.UseCompatibleStateImageBehavior = false;
            this.lvMedia.View = System.Windows.Forms.View.Details;
            this.lvMedia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMedia_MouseDown);
            // 
            // chNomeMedia
            // 
            this.chNomeMedia.Text = "Media";
            this.chNomeMedia.Width = 112;
            // 
            // chNumeroFiles
            // 
            this.chNumeroFiles.Text = "# files";
            this.chNumeroFiles.Width = 101;
            // 
            // chDimensioneTotaleFiles
            // 
            this.chDimensioneTotaleFiles.Text = "Totale bytes file";
            this.chDimensioneTotaleFiles.Width = 138;
            // 
            // chDimensioneMassima
            // 
            this.chDimensioneMassima.Text = "Dim. supporto";
            this.chDimensioneMassima.Width = 139;
            // 
            // chPercOccupato
            // 
            this.chPercOccupato.Text = "% occupato";
            this.chPercOccupato.Width = 147;
            // 
            // lblAvailableSize
            // 
            this.lblAvailableSize.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailableSize.Location = new System.Drawing.Point(182, 17);
            this.lblAvailableSize.Name = "lblAvailableSize";
            this.lblAvailableSize.Size = new System.Drawing.Size(173, 14);
            this.lblAvailableSize.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dimensione totale disponibile:";
            // 
            // lblPercFreeSpace
            // 
            this.lblPercFreeSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblPercFreeSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPercFreeSpace.Location = new System.Drawing.Point(179, 59);
            this.lblPercFreeSpace.Name = "lblPercFreeSpace";
            this.lblPercFreeSpace.Size = new System.Drawing.Size(176, 16);
            this.lblPercFreeSpace.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "% Spazio sprecato:";
            // 
            // lblTotFreeSpace
            // 
            this.lblTotFreeSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblTotFreeSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotFreeSpace.Location = new System.Drawing.Point(179, 45);
            this.lblTotFreeSpace.Name = "lblTotFreeSpace";
            this.lblTotFreeSpace.Size = new System.Drawing.Size(176, 16);
            this.lblTotFreeSpace.TabIndex = 11;
            // 
            // lblTotSize
            // 
            this.lblTotSize.BackColor = System.Drawing.Color.Transparent;
            this.lblTotSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotSize.Location = new System.Drawing.Point(179, 31);
            this.lblTotSize.Name = "lblTotSize";
            this.lblTotSize.Size = new System.Drawing.Size(176, 16);
            this.lblTotSize.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 45);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(86, 13);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Spazio libero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dimensione totale occupata:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShowInSubFolder);
            this.groupBox2.Controls.Add(this.cmdFolderBrowser);
            this.groupBox2.Controls.Add(this.cmbSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmdStartScan);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impostazioni";
            // 
            // chkShowInSubFolder
            // 
            this.chkShowInSubFolder.AutoSize = true;
            this.chkShowInSubFolder.Location = new System.Drawing.Point(7, 80);
            this.chkShowInSubFolder.Name = "chkShowInSubFolder";
            this.chkShowInSubFolder.Size = new System.Drawing.Size(138, 17);
            this.chkShowInSubFolder.TabIndex = 7;
            this.chkShowInSubFolder.Text = "Includi sottocartelle";
            this.chkShowInSubFolder.UseVisualStyleBackColor = true;
            // 
            // cmdFolderBrowser
            // 
            this.cmdFolderBrowser.Location = new System.Drawing.Point(285, 28);
            this.cmdFolderBrowser.Name = "cmdFolderBrowser";
            this.cmdFolderBrowser.Size = new System.Drawing.Size(35, 23);
            this.cmdFolderBrowser.TabIndex = 6;
            this.cmdFolderBrowser.Text = "...";
            this.cmdFolderBrowser.UseVisualStyleBackColor = true;
            this.cmdFolderBrowser.Click += new System.EventHandler(this.cmdFolderBrowser_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(79, 54);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(198, 21);
            this.cmbSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimensione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Percorso";
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 395);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(708, 20);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 10;
            this.pb.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAvailableSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.lblPercFreeSpace);
            this.groupBox1.Controls.Add(this.lblTotSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotFreeSpace);
            this.groupBox1.Location = new System.Drawing.Point(333, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiche totali";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMediaInfo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceLost V 0.2";
            this.gbMediaInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button cmdStartScan;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox gbMediaInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotSize;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotFreeSpace;
        private System.Windows.Forms.Label lblPercFreeSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAvailableSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.CheckBox chkShowInSubFolder;
        private System.Windows.Forms.ProgressBar pb;
        private XPExplorerBar.XPListView lvMedia;
        private System.Windows.Forms.ColumnHeader chNomeMedia;
        private System.Windows.Forms.ColumnHeader chNumeroFiles;
        private System.Windows.Forms.ColumnHeader chDimensioneTotaleFiles;
        private System.Windows.Forms.ColumnHeader chDimensioneMassima;
        private System.Windows.Forms.ColumnHeader chPercOccupato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDettaglioCompilation;
        private System.Windows.Forms.Button btnDeleteFile;
    }
}

