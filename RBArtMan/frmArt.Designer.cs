namespace RBArtMan
{
    partial class frmArt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmArt ) );
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.edtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.ssArt = new System.Windows.Forms.StatusStrip();
            this.lblLastDownload = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lvArt = new System.Windows.Forms.ListView();
            this.colArtID = new System.Windows.Forms.ColumnHeader();
            this.colArtTitle = new System.Windows.Forms.ColumnHeader();
            this.popArt = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.popArtDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.popArtExport = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtExportTSV = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtExportHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtExportMediaRSS = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtPromote = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtPromoteWork = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtPromoteProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.visitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtVisitProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtVisitArt = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtVisitWork = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtVisitEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.popArtVisitSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.popArtVisitMyBubble = new System.Windows.Forms.ToolStripMenuItem();
            this.sdCSV = new System.Windows.Forms.SaveFileDialog();
            this.sdTSV = new System.Windows.Forms.SaveFileDialog();
            this.fbHTML = new System.Windows.Forms.FolderBrowserDialog();
            this.sdMediaRSS = new System.Windows.Forms.SaveFileDialog();
            this.pnlTop.SuspendLayout();
            this.ssArt.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.popArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add( this.lblStatus );
            this.pnlTop.Controls.Add( this.edtUserID );
            this.pnlTop.Controls.Add( this.lblUserID );
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point( 0, 0 );
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size( 514, 38 );
            this.pnlTop.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point( 166, 9 );
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size( 0, 13 );
            this.lblStatus.TabIndex = 2;
            // 
            // edtUserID
            // 
            this.edtUserID.Location = new System.Drawing.Point( 60, 6 );
            this.edtUserID.Name = "edtUserID";
            this.edtUserID.Size = new System.Drawing.Size( 100, 20 );
            this.edtUserID.TabIndex = 1;
            this.edtUserID.TextChanged += new System.EventHandler( this.edtUserID_TextChanged );
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point( 8, 9 );
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size( 46, 13 );
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "&User ID:";
            // 
            // ssArt
            // 
            this.ssArt.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.lblLastDownload,
            this.lblItems} );
            this.ssArt.Location = new System.Drawing.Point( 0, 358 );
            this.ssArt.Name = "ssArt";
            this.ssArt.Size = new System.Drawing.Size( 514, 22 );
            this.ssArt.TabIndex = 2;
            this.ssArt.Text = "statusStrip1";
            // 
            // lblLastDownload
            // 
            this.lblLastDownload.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides) ( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.lblLastDownload.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblLastDownload.Name = "lblLastDownload";
            this.lblLastDownload.Size = new System.Drawing.Size( 129, 17 );
            this.lblLastDownload.Text = "Last Downloaded: Never";
            // 
            // lblItems
            // 
            this.lblItems.BorderSides = ( (System.Windows.Forms.ToolStripStatusLabelBorderSides) ( ( ( ( System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right )
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom ) ) );
            this.lblItems.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size( 70, 17 );
            this.lblItems.Text = "Items: None";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add( this.lvArt );
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point( 0, 38 );
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size( 514, 320 );
            this.pnlBody.TabIndex = 3;
            // 
            // lvArt
            // 
            this.lvArt.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.colArtID,
            this.colArtTitle} );
            this.lvArt.ContextMenuStrip = this.popArt;
            this.lvArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArt.FullRowSelect = true;
            this.lvArt.GridLines = true;
            this.lvArt.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvArt.HideSelection = false;
            this.lvArt.Location = new System.Drawing.Point( 0, 0 );
            this.lvArt.Name = "lvArt";
            this.lvArt.Size = new System.Drawing.Size( 514, 320 );
            this.lvArt.TabIndex = 2;
            this.lvArt.UseCompatibleStateImageBehavior = false;
            this.lvArt.View = System.Windows.Forms.View.Details;
            this.lvArt.DoubleClick += new System.EventHandler( this.lvArt_DoubleClick );
            // 
            // colArtID
            // 
            this.colArtID.Text = "ID";
            this.colArtID.Width = 100;
            // 
            // colArtTitle
            // 
            this.colArtTitle.Text = "Title";
            this.colArtTitle.Width = 300;
            // 
            // popArt
            // 
            this.popArt.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.popArtDownload,
            this.popArtSep0,
            this.popArtExport,
            this.popArtPromote,
            this.visitToolStripMenuItem} );
            this.popArt.Name = "popArt";
            this.popArt.Size = new System.Drawing.Size( 153, 120 );
            this.popArt.Opening += new System.ComponentModel.CancelEventHandler( this.popArt_Opening );
            // 
            // popArtDownload
            // 
            this.popArtDownload.Image = global::RBArtMan.Properties.Resources.Download;
            this.popArtDownload.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.popArtDownload.Name = "popArtDownload";
            this.popArtDownload.Size = new System.Drawing.Size( 152, 22 );
            this.popArtDownload.Text = "&Download";
            this.popArtDownload.Click += new System.EventHandler( this.popArtDownload_Click );
            // 
            // popArtSep0
            // 
            this.popArtSep0.Name = "popArtSep0";
            this.popArtSep0.Size = new System.Drawing.Size( 149, 6 );
            // 
            // popArtExport
            // 
            this.popArtExport.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.popArtExportCSV,
            this.popArtExportTSV,
            this.popArtExportHTML,
            this.popArtExportMediaRSS} );
            this.popArtExport.Name = "popArtExport";
            this.popArtExport.Size = new System.Drawing.Size( 152, 22 );
            this.popArtExport.Text = "&Export";
            // 
            // popArtExportCSV
            // 
            this.popArtExportCSV.Name = "popArtExportCSV";
            this.popArtExportCSV.Size = new System.Drawing.Size( 152, 22 );
            this.popArtExportCSV.Text = "&CSV...";
            this.popArtExportCSV.Click += new System.EventHandler( this.popArtExportCSV_Click );
            // 
            // popArtExportTSV
            // 
            this.popArtExportTSV.Name = "popArtExportTSV";
            this.popArtExportTSV.Size = new System.Drawing.Size( 152, 22 );
            this.popArtExportTSV.Text = "&TSV...";
            this.popArtExportTSV.Click += new System.EventHandler( this.popArtExportTSV_Click );
            // 
            // popArtExportHTML
            // 
            this.popArtExportHTML.Name = "popArtExportHTML";
            this.popArtExportHTML.Size = new System.Drawing.Size( 152, 22 );
            this.popArtExportHTML.Text = "&HTML...";
            this.popArtExportHTML.Click += new System.EventHandler( this.popArtExportHTML_Click );
            // 
            // popArtExportMediaRSS
            // 
            this.popArtExportMediaRSS.Name = "popArtExportMediaRSS";
            this.popArtExportMediaRSS.Size = new System.Drawing.Size( 152, 22 );
            this.popArtExportMediaRSS.Text = "&MediaRSS...";
            this.popArtExportMediaRSS.Click += new System.EventHandler( this.popArtExportMediaRSS_Click );
            // 
            // popArtPromote
            // 
            this.popArtPromote.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.popArtPromoteWork,
            this.popArtPromoteProfile} );
            this.popArtPromote.Name = "popArtPromote";
            this.popArtPromote.Size = new System.Drawing.Size( 152, 22 );
            this.popArtPromote.Text = "&Promote";
            // 
            // popArtPromoteWork
            // 
            this.popArtPromoteWork.Image = global::RBArtMan.Properties.Resources.Promote;
            this.popArtPromoteWork.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.popArtPromoteWork.Name = "popArtPromoteWork";
            this.popArtPromoteWork.Size = new System.Drawing.Size( 127, 22 );
            this.popArtPromoteWork.Text = "&Work...";
            this.popArtPromoteWork.Click += new System.EventHandler( this.popArtPromoteWork_Click );
            // 
            // popArtPromoteProfile
            // 
            this.popArtPromoteProfile.Image = global::RBArtMan.Properties.Resources.Profile;
            this.popArtPromoteProfile.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.popArtPromoteProfile.Name = "popArtPromoteProfile";
            this.popArtPromoteProfile.Size = new System.Drawing.Size( 127, 22 );
            this.popArtPromoteProfile.Text = "&Profile...";
            this.popArtPromoteProfile.Click += new System.EventHandler( this.popArtPromoteProfile_Click );
            // 
            // visitToolStripMenuItem
            // 
            this.visitToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.popArtVisitProfile,
            this.popArtVisitArt,
            this.popArtVisitWork,
            this.popArtVisitEdit,
            this.popArtVisitSep0,
            this.popArtVisitMyBubble} );
            this.visitToolStripMenuItem.Name = "visitToolStripMenuItem";
            this.visitToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.visitToolStripMenuItem.Text = "&Visit";
            // 
            // popArtVisitProfile
            // 
            this.popArtVisitProfile.Name = "popArtVisitProfile";
            this.popArtVisitProfile.Size = new System.Drawing.Size( 143, 22 );
            this.popArtVisitProfile.Text = "&Profile...";
            this.popArtVisitProfile.Click += new System.EventHandler( this.popArtVisitProfile_Click );
            // 
            // popArtVisitArt
            // 
            this.popArtVisitArt.Name = "popArtVisitArt";
            this.popArtVisitArt.Size = new System.Drawing.Size( 143, 22 );
            this.popArtVisitArt.Text = "&Art...";
            this.popArtVisitArt.Click += new System.EventHandler( this.popArtVisitArt_Click );
            // 
            // popArtVisitWork
            // 
            this.popArtVisitWork.Name = "popArtVisitWork";
            this.popArtVisitWork.Size = new System.Drawing.Size( 143, 22 );
            this.popArtVisitWork.Text = "&Work...";
            this.popArtVisitWork.Click += new System.EventHandler( this.popArtVisitWork_Click );
            // 
            // popArtVisitEdit
            // 
            this.popArtVisitEdit.Image = global::RBArtMan.Properties.Resources.Edit;
            this.popArtVisitEdit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.popArtVisitEdit.Name = "popArtVisitEdit";
            this.popArtVisitEdit.Size = new System.Drawing.Size( 143, 22 );
            this.popArtVisitEdit.Text = "&Edit...";
            this.popArtVisitEdit.ToolTipText = "Visit the edit page for this work";
            this.popArtVisitEdit.Click += new System.EventHandler( this.popArtVisitEdit_Click );
            // 
            // popArtVisitSep0
            // 
            this.popArtVisitSep0.Name = "popArtVisitSep0";
            this.popArtVisitSep0.Size = new System.Drawing.Size( 140, 6 );
            // 
            // popArtVisitMyBubble
            // 
            this.popArtVisitMyBubble.Name = "popArtVisitMyBubble";
            this.popArtVisitMyBubble.Size = new System.Drawing.Size( 143, 22 );
            this.popArtVisitMyBubble.Text = "&MyBubble...";
            this.popArtVisitMyBubble.Click += new System.EventHandler( this.popArtVisitMyBubble_Click );
            // 
            // sdCSV
            // 
            this.sdCSV.DefaultExt = "csv";
            this.sdCSV.Filter = "CSV Files|*.csv";
            this.sdCSV.Title = "Export to CSV File";
            // 
            // sdTSV
            // 
            this.sdTSV.Filter = "TSV Files|*.tsv";
            this.sdTSV.Title = "Export to TSV File";
            // 
            // fbHTML
            // 
            this.fbHTML.Description = "Select where you want the HTML to be generated.";
            this.fbHTML.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // sdMediaRSS
            // 
            this.sdMediaRSS.Filter = "RSS Files|*.rss|XML Files|*.xml";
            this.sdMediaRSS.Title = "Export to MediaRSS File";
            // 
            // frmArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 514, 380 );
            this.Controls.Add( this.pnlBody );
            this.Controls.Add( this.ssArt );
            this.Controls.Add( this.pnlTop );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmArt";
            this.Text = "Art";
            this.Shown += new System.EventHandler( this.frmArt_Shown );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.frmArt_FormClosing );
            this.pnlTop.ResumeLayout( false );
            this.pnlTop.PerformLayout();
            this.ssArt.ResumeLayout( false );
            this.ssArt.PerformLayout();
            this.pnlBody.ResumeLayout( false );
            this.popArt.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.StatusStrip ssArt;
        private System.Windows.Forms.ToolStripStatusLabel lblLastDownload;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ColumnHeader colArtID;
        private System.Windows.Forms.ColumnHeader colArtTitle;
        internal System.Windows.Forms.ListView lvArt;
        private System.Windows.Forms.ContextMenuStrip popArt;
        private System.Windows.Forms.ToolStripMenuItem popArtDownload;
        private System.Windows.Forms.ToolStripMenuItem visitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popArtVisitProfile;
        private System.Windows.Forms.ToolStripMenuItem popArtVisitArt;
        private System.Windows.Forms.ToolStripMenuItem popArtVisitWork;
        private System.Windows.Forms.ToolStripSeparator popArtVisitSep0;
        private System.Windows.Forms.ToolStripMenuItem popArtVisitMyBubble;
        private System.Windows.Forms.SaveFileDialog sdCSV;
        private System.Windows.Forms.SaveFileDialog sdTSV;
        private System.Windows.Forms.FolderBrowserDialog fbHTML;
        private System.Windows.Forms.ToolStripMenuItem popArtExport;
        private System.Windows.Forms.ToolStripMenuItem popArtExportCSV;
        private System.Windows.Forms.ToolStripMenuItem popArtExportTSV;
        private System.Windows.Forms.ToolStripMenuItem popArtExportHTML;
        private System.Windows.Forms.ToolStripSeparator popArtSep0;
        private System.Windows.Forms.ToolStripMenuItem popArtPromote;
        private System.Windows.Forms.ToolStripMenuItem popArtPromoteWork;
        private System.Windows.Forms.ToolStripMenuItem popArtVisitEdit;
        private System.Windows.Forms.ToolStripStatusLabel lblItems;
        private System.Windows.Forms.ToolStripMenuItem popArtPromoteProfile;
        internal System.Windows.Forms.TextBox edtUserID;
        private System.Windows.Forms.ToolStripMenuItem popArtExportMediaRSS;
        private System.Windows.Forms.SaveFileDialog sdMediaRSS;
    }
}