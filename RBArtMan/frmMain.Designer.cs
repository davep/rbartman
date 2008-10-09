namespace RBArtMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmMain ) );
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.ttslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSplit0 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuArtExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtExportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtExportTSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtExportHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtExportCoolIris = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtPromote = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtPromoteWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtPromoteProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisitProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisitArt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisitWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisitEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArtVisitSplit0 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuArtVisitMyBubble = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdArt = new System.Windows.Forms.OpenFileDialog();
            this.sfdArt = new System.Windows.Forms.SaveFileDialog();
            this.tbMain = new System.Windows.Forms.ToolStrip();
            this.tbMainFileNew = new System.Windows.Forms.ToolStripButton();
            this.tbMainFileOpen = new System.Windows.Forms.ToolStripButton();
            this.tbMainFileSave = new System.Windows.Forms.ToolStripButton();
            this.tbMainFileSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tbMainFileClose = new System.Windows.Forms.ToolStripButton();
            this.tbMainSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMainArtDownload = new System.Windows.Forms.ToolStripButton();
            this.tbMainSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMainArtPromoteWork = new System.Windows.Forms.ToolStripButton();
            this.tbMainArtVisitEdit = new System.Windows.Forms.ToolStripButton();
            this.tbMainSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMainArtPromoteProfile = new System.Windows.Forms.ToolStripButton();
            this.tbMainSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMainFileExit = new System.Windows.Forms.ToolStripButton();
            this.ssMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.ttslVersion} );
            this.ssMain.Location = new System.Drawing.Point( 0, 451 );
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size( 592, 22 );
            this.ssMain.TabIndex = 2;
            // 
            // ttslVersion
            // 
            this.ttslVersion.Name = "ttslVersion";
            this.ttslVersion.Size = new System.Drawing.Size( 42, 17 );
            this.ttslVersion.Text = "Version";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuArt,
            this.mnuWindow,
            this.mnuHelp} );
            this.mnuMain.Location = new System.Drawing.Point( 0, 0 );
            this.mnuMain.MdiWindowListItem = this.mnuWindow;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size( 592, 24 );
            this.mnuMain.TabIndex = 3;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileClose,
            this.mnuFileSplit0,
            this.exitToolStripMenuItem} );
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size( 35, 20 );
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Image = global::RBArtMan.Properties.Resources.New;
            this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Silver;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
            this.mnuFileNew.Size = new System.Drawing.Size( 195, 22 );
            this.mnuFileNew.Text = "&New...";
            this.mnuFileNew.ToolTipText = "Create a new art management document";
            this.mnuFileNew.Click += new System.EventHandler( this.newArtWindow );
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = global::RBArtMan.Properties.Resources.Open;
            this.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Silver;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
            this.mnuFileOpen.Size = new System.Drawing.Size( 195, 22 );
            this.mnuFileOpen.Text = "&Open...";
            this.mnuFileOpen.ToolTipText = "Open an existing art management document";
            this.mnuFileOpen.Click += new System.EventHandler( this.mnuFileOpen_Click );
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = global::RBArtMan.Properties.Resources.Save;
            this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Silver;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
            this.mnuFileSave.Size = new System.Drawing.Size( 195, 22 );
            this.mnuFileSave.Text = "&Save...";
            this.mnuFileSave.ToolTipText = "Save the current art management document";
            this.mnuFileSave.Click += new System.EventHandler( this.mnuFileSave_Click );
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Image = global::RBArtMan.Properties.Resources.SaveAs;
            this.mnuFileSaveAs.ImageTransparentColor = System.Drawing.Color.Silver;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt )
                        | System.Windows.Forms.Keys.S ) ) );
            this.mnuFileSaveAs.Size = new System.Drawing.Size( 195, 22 );
            this.mnuFileSaveAs.Text = "Save &As...";
            this.mnuFileSaveAs.ToolTipText = "Save the current art management document with a new name";
            this.mnuFileSaveAs.Click += new System.EventHandler( this.mnuFileSaveAs_Click );
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Image = global::RBArtMan.Properties.Resources.Close;
            this.mnuFileClose.ImageTransparentColor = System.Drawing.Color.Silver;
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size( 195, 22 );
            this.mnuFileClose.Text = "&Close";
            this.mnuFileClose.ToolTipText = "Close the current art management document";
            this.mnuFileClose.Click += new System.EventHandler( this.closeArtWindow );
            // 
            // mnuFileSplit0
            // 
            this.mnuFileSplit0.Name = "mnuFileSplit0";
            this.mnuFileSplit0.Size = new System.Drawing.Size( 192, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::RBArtMan.Properties.Resources.Exit;
            this.exitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Olive;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4 ) ) );
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 195, 22 );
            this.exitToolStripMenuItem.Text = "E&xit...";
            this.exitToolStripMenuItem.ToolTipText = "Exit the application";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.closeApplication );
            // 
            // mnuArt
            // 
            this.mnuArt.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuArtDownload,
            this.mnuArtSep0,
            this.mnuArtExport,
            this.mnuArtPromote,
            this.mnuArtVisit} );
            this.mnuArt.Name = "mnuArt";
            this.mnuArt.Size = new System.Drawing.Size( 34, 20 );
            this.mnuArt.Text = "&Art";
            // 
            // mnuArtDownload
            // 
            this.mnuArtDownload.Image = global::RBArtMan.Properties.Resources.Download;
            this.mnuArtDownload.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuArtDownload.Name = "mnuArtDownload";
            this.mnuArtDownload.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D ) ) );
            this.mnuArtDownload.Size = new System.Drawing.Size( 183, 22 );
            this.mnuArtDownload.Text = "&Download...";
            this.mnuArtDownload.ToolTipText = "Download a list of your art from RedBubble";
            this.mnuArtDownload.Click += new System.EventHandler( this.mnuArtDownload_Click );
            // 
            // mnuArtSep0
            // 
            this.mnuArtSep0.Name = "mnuArtSep0";
            this.mnuArtSep0.Size = new System.Drawing.Size( 180, 6 );
            // 
            // mnuArtExport
            // 
            this.mnuArtExport.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuArtExportCSV,
            this.mnuArtExportTSV,
            this.mnuArtExportHTML,
            this.mnuArtExportCoolIris} );
            this.mnuArtExport.Name = "mnuArtExport";
            this.mnuArtExport.Size = new System.Drawing.Size( 183, 22 );
            this.mnuArtExport.Text = "&Export";
            this.mnuArtExport.ToolTipText = "Export your list of art";
            // 
            // mnuArtExportCSV
            // 
            this.mnuArtExportCSV.Name = "mnuArtExportCSV";
            this.mnuArtExportCSV.Size = new System.Drawing.Size( 152, 22 );
            this.mnuArtExportCSV.Text = "CSV...";
            this.mnuArtExportCSV.ToolTipText = "Export your art list as a comma-seperated text file";
            this.mnuArtExportCSV.Click += new System.EventHandler( this.mnuArtExportCSV_Click );
            // 
            // mnuArtExportTSV
            // 
            this.mnuArtExportTSV.Name = "mnuArtExportTSV";
            this.mnuArtExportTSV.Size = new System.Drawing.Size( 152, 22 );
            this.mnuArtExportTSV.Text = "TSV...";
            this.mnuArtExportTSV.ToolTipText = "Export your art list as a tab-seperated text file";
            this.mnuArtExportTSV.Click += new System.EventHandler( this.mnuArtExportTSV_Click );
            // 
            // mnuArtExportHTML
            // 
            this.mnuArtExportHTML.Name = "mnuArtExportHTML";
            this.mnuArtExportHTML.Size = new System.Drawing.Size( 152, 22 );
            this.mnuArtExportHTML.Text = "&HTML...";
            this.mnuArtExportHTML.ToolTipText = "Export your art list as HTML";
            this.mnuArtExportHTML.Click += new System.EventHandler( this.mnuArtExportHTML_Click );
            // 
            // mnuArtExportCoolIris
            // 
            this.mnuArtExportCoolIris.Name = "mnuArtExportCoolIris";
            this.mnuArtExportCoolIris.Size = new System.Drawing.Size( 152, 22 );
            this.mnuArtExportCoolIris.Text = "&MediaRSS...";
            this.mnuArtExportCoolIris.ToolTipText = "Export your art list as a MediaRSS file";
            this.mnuArtExportCoolIris.Click += new System.EventHandler( this.mnuArtExportMediaRSS_Click );
            // 
            // mnuArtPromote
            // 
            this.mnuArtPromote.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuArtPromoteWork,
            this.mnuArtPromoteProfile} );
            this.mnuArtPromote.Name = "mnuArtPromote";
            this.mnuArtPromote.Size = new System.Drawing.Size( 183, 22 );
            this.mnuArtPromote.Text = "&Promote";
            // 
            // mnuArtPromoteWork
            // 
            this.mnuArtPromoteWork.Image = global::RBArtMan.Properties.Resources.Promote;
            this.mnuArtPromoteWork.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuArtPromoteWork.Name = "mnuArtPromoteWork";
            this.mnuArtPromoteWork.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P ) ) );
            this.mnuArtPromoteWork.Size = new System.Drawing.Size( 186, 22 );
            this.mnuArtPromoteWork.Text = "&Work...";
            this.mnuArtPromoteWork.ToolTipText = "Generate promotion code for the current work";
            this.mnuArtPromoteWork.Click += new System.EventHandler( this.mnuArtPromoteWork_Click );
            // 
            // mnuArtPromoteProfile
            // 
            this.mnuArtPromoteProfile.Image = global::RBArtMan.Properties.Resources.Profile;
            this.mnuArtPromoteProfile.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuArtPromoteProfile.Name = "mnuArtPromoteProfile";
            this.mnuArtPromoteProfile.ShortcutKeys = ( (System.Windows.Forms.Keys) ( ( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt )
                        | System.Windows.Forms.Keys.P ) ) );
            this.mnuArtPromoteProfile.Size = new System.Drawing.Size( 186, 22 );
            this.mnuArtPromoteProfile.Text = "&Profile...";
            this.mnuArtPromoteProfile.ToolTipText = "Generate promotion code for the current profile";
            this.mnuArtPromoteProfile.Click += new System.EventHandler( this.mnuArtPromoteProfile_Click );
            // 
            // mnuArtVisit
            // 
            this.mnuArtVisit.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuArtVisitProfile,
            this.mnuArtVisitArt,
            this.mnuArtVisitWork,
            this.mnuArtVisitEdit,
            this.mnuArtVisitSplit0,
            this.mnuArtVisitMyBubble} );
            this.mnuArtVisit.Name = "mnuArtVisit";
            this.mnuArtVisit.Size = new System.Drawing.Size( 183, 22 );
            this.mnuArtVisit.Text = "&Visit";
            this.mnuArtVisit.ToolTipText = "Visit pages on RedBubble";
            // 
            // mnuArtVisitProfile
            // 
            this.mnuArtVisitProfile.Name = "mnuArtVisitProfile";
            this.mnuArtVisitProfile.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuArtVisitProfile.Size = new System.Drawing.Size( 162, 22 );
            this.mnuArtVisitProfile.Text = "&Profile...";
            this.mnuArtVisitProfile.ToolTipText = "Visit your profile at RedBubble";
            this.mnuArtVisitProfile.Click += new System.EventHandler( this.mnuArtVisitProfile_Click );
            // 
            // mnuArtVisitArt
            // 
            this.mnuArtVisitArt.Name = "mnuArtVisitArt";
            this.mnuArtVisitArt.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuArtVisitArt.Size = new System.Drawing.Size( 162, 22 );
            this.mnuArtVisitArt.Text = "&Art...";
            this.mnuArtVisitArt.ToolTipText = "Visit your art pages at RedBubble";
            this.mnuArtVisitArt.Click += new System.EventHandler( this.mnuArtVisitArt_Click );
            // 
            // mnuArtVisitWork
            // 
            this.mnuArtVisitWork.Name = "mnuArtVisitWork";
            this.mnuArtVisitWork.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuArtVisitWork.Size = new System.Drawing.Size( 162, 22 );
            this.mnuArtVisitWork.Text = "&Work...";
            this.mnuArtVisitWork.ToolTipText = "Visit the RedBubble page for the highlighted work";
            this.mnuArtVisitWork.Click += new System.EventHandler( this.mnuArtVisitWork_Click );
            // 
            // mnuArtVisitEdit
            // 
            this.mnuArtVisitEdit.Image = global::RBArtMan.Properties.Resources.Edit;
            this.mnuArtVisitEdit.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuArtVisitEdit.Name = "mnuArtVisitEdit";
            this.mnuArtVisitEdit.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuArtVisitEdit.Size = new System.Drawing.Size( 162, 22 );
            this.mnuArtVisitEdit.Text = "&Edit...";
            this.mnuArtVisitEdit.ToolTipText = "Visit the edit page for this work";
            this.mnuArtVisitEdit.Click += new System.EventHandler( this.mnuArtVisitEdit_Click );
            // 
            // mnuArtVisitSplit0
            // 
            this.mnuArtVisitSplit0.Name = "mnuArtVisitSplit0";
            this.mnuArtVisitSplit0.Size = new System.Drawing.Size( 159, 6 );
            // 
            // mnuArtVisitMyBubble
            // 
            this.mnuArtVisitMyBubble.Name = "mnuArtVisitMyBubble";
            this.mnuArtVisitMyBubble.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuArtVisitMyBubble.Size = new System.Drawing.Size( 162, 22 );
            this.mnuArtVisitMyBubble.Text = "&MyBubble...";
            this.mnuArtVisitMyBubble.ToolTipText = "Visit \'MyBubble\'";
            this.mnuArtVisitMyBubble.Click += new System.EventHandler( this.mnuArtVisitMyBubble_Click );
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowCascade,
            this.mnuWindowTileHorizontal,
            this.mnuWindowTileVertical} );
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size( 57, 20 );
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Image = global::RBArtMan.Properties.Resources.Cascade;
            this.mnuWindowCascade.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size( 152, 22 );
            this.mnuWindowCascade.Text = "&Cascade";
            this.mnuWindowCascade.Click += new System.EventHandler( this.mnuWindowCascade_Click );
            // 
            // mnuWindowTileHorizontal
            // 
            this.mnuWindowTileHorizontal.Image = global::RBArtMan.Properties.Resources.TileHorizontal;
            this.mnuWindowTileHorizontal.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal";
            this.mnuWindowTileHorizontal.Size = new System.Drawing.Size( 152, 22 );
            this.mnuWindowTileHorizontal.Text = "Tile &Horizontal";
            this.mnuWindowTileHorizontal.Click += new System.EventHandler( this.mnuWindowTileHorizontal_Click );
            // 
            // mnuWindowTileVertical
            // 
            this.mnuWindowTileVertical.Image = global::RBArtMan.Properties.Resources.TileVertical;
            this.mnuWindowTileVertical.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnuWindowTileVertical.Name = "mnuWindowTileVertical";
            this.mnuWindowTileVertical.Size = new System.Drawing.Size( 152, 22 );
            this.mnuWindowTileVertical.Text = "Tile &Vertical";
            this.mnuWindowTileVertical.Click += new System.EventHandler( this.mnuWindowTileVertical_Click );
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout} );
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size( 40, 20 );
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelpAbout.Size = new System.Drawing.Size( 145, 22 );
            this.mnuHelpAbout.Text = "&About...";
            this.mnuHelpAbout.ToolTipText = "About this application";
            this.mnuHelpAbout.Click += new System.EventHandler( this.mnuHelpAbout_Click );
            // 
            // ofdArt
            // 
            this.ofdArt.DefaultExt = "rbart";
            this.ofdArt.Filter = "RedBubble Art List|*.rbart";
            this.ofdArt.Title = "Open Art List";
            // 
            // sfdArt
            // 
            this.sfdArt.Filter = "RedBubble Art List|*.rbart";
            this.sfdArt.Title = "Save RedBubble Art List";
            // 
            // tbMain
            // 
            this.tbMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbMain.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.tbMainFileNew,
            this.tbMainFileOpen,
            this.tbMainFileSave,
            this.tbMainFileSaveAs,
            this.tbMainFileClose,
            this.tbMainSep0,
            this.tbMainArtDownload,
            this.tbMainSep1,
            this.tbMainArtPromoteWork,
            this.tbMainArtVisitEdit,
            this.tbMainSep2,
            this.tbMainArtPromoteProfile,
            this.tbMainSep3,
            this.tbMainFileExit} );
            this.tbMain.Location = new System.Drawing.Point( 0, 24 );
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size( 592, 25 );
            this.tbMain.TabIndex = 5;
            // 
            // tbMainFileNew
            // 
            this.tbMainFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileNew.Image = global::RBArtMan.Properties.Resources.New;
            this.tbMainFileNew.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tbMainFileNew.Name = "tbMainFileNew";
            this.tbMainFileNew.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileNew.ToolTipText = "Create a new RedBubble art document";
            this.tbMainFileNew.Click += new System.EventHandler( this.newArtWindow );
            // 
            // tbMainFileOpen
            // 
            this.tbMainFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileOpen.Image = global::RBArtMan.Properties.Resources.Open;
            this.tbMainFileOpen.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tbMainFileOpen.Name = "tbMainFileOpen";
            this.tbMainFileOpen.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileOpen.ToolTipText = "Open an existing RedBubble art document";
            this.tbMainFileOpen.Click += new System.EventHandler( this.mnuFileOpen_Click );
            // 
            // tbMainFileSave
            // 
            this.tbMainFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileSave.Image = global::RBArtMan.Properties.Resources.Save;
            this.tbMainFileSave.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tbMainFileSave.Name = "tbMainFileSave";
            this.tbMainFileSave.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileSave.ToolTipText = "Save the current RedBubble art document";
            this.tbMainFileSave.Click += new System.EventHandler( this.mnuFileSave_Click );
            // 
            // tbMainFileSaveAs
            // 
            this.tbMainFileSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileSaveAs.Image = global::RBArtMan.Properties.Resources.SaveAs;
            this.tbMainFileSaveAs.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tbMainFileSaveAs.Name = "tbMainFileSaveAs";
            this.tbMainFileSaveAs.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileSaveAs.ToolTipText = "Save the current RedBubble art document with a new name";
            this.tbMainFileSaveAs.Click += new System.EventHandler( this.mnuFileSaveAs_Click );
            // 
            // tbMainFileClose
            // 
            this.tbMainFileClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileClose.Image = global::RBArtMan.Properties.Resources.Close;
            this.tbMainFileClose.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tbMainFileClose.Name = "tbMainFileClose";
            this.tbMainFileClose.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileClose.ToolTipText = "Close the current RedBubble art document";
            this.tbMainFileClose.Click += new System.EventHandler( this.closeArtWindow );
            // 
            // tbMainSep0
            // 
            this.tbMainSep0.Name = "tbMainSep0";
            this.tbMainSep0.Size = new System.Drawing.Size( 6, 25 );
            // 
            // tbMainArtDownload
            // 
            this.tbMainArtDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainArtDownload.Image = global::RBArtMan.Properties.Resources.Download;
            this.tbMainArtDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMainArtDownload.Name = "tbMainArtDownload";
            this.tbMainArtDownload.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainArtDownload.ToolTipText = "Download your art list from RedBubble";
            this.tbMainArtDownload.Click += new System.EventHandler( this.mnuArtDownload_Click );
            // 
            // tbMainSep1
            // 
            this.tbMainSep1.Name = "tbMainSep1";
            this.tbMainSep1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // tbMainArtPromoteWork
            // 
            this.tbMainArtPromoteWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainArtPromoteWork.Image = global::RBArtMan.Properties.Resources.Promote;
            this.tbMainArtPromoteWork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMainArtPromoteWork.Name = "tbMainArtPromoteWork";
            this.tbMainArtPromoteWork.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainArtPromoteWork.ToolTipText = "Generate promotion code for the current work";
            this.tbMainArtPromoteWork.Click += new System.EventHandler( this.mnuArtPromoteWork_Click );
            // 
            // tbMainArtVisitEdit
            // 
            this.tbMainArtVisitEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainArtVisitEdit.Image = global::RBArtMan.Properties.Resources.Edit;
            this.tbMainArtVisitEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMainArtVisitEdit.Name = "tbMainArtVisitEdit";
            this.tbMainArtVisitEdit.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainArtVisitEdit.ToolTipText = "Visit the edit page for the current work";
            this.tbMainArtVisitEdit.Click += new System.EventHandler( this.mnuArtVisitEdit_Click );
            // 
            // tbMainSep2
            // 
            this.tbMainSep2.Name = "tbMainSep2";
            this.tbMainSep2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // tbMainArtPromoteProfile
            // 
            this.tbMainArtPromoteProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainArtPromoteProfile.Image = global::RBArtMan.Properties.Resources.Profile;
            this.tbMainArtPromoteProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMainArtPromoteProfile.Name = "tbMainArtPromoteProfile";
            this.tbMainArtPromoteProfile.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainArtPromoteProfile.Text = "Generate promotion code for the current profile";
            this.tbMainArtPromoteProfile.Click += new System.EventHandler( this.mnuArtPromoteProfile_Click );
            // 
            // tbMainSep3
            // 
            this.tbMainSep3.Name = "tbMainSep3";
            this.tbMainSep3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // tbMainFileExit
            // 
            this.tbMainFileExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMainFileExit.Image = global::RBArtMan.Properties.Resources.Exit;
            this.tbMainFileExit.ImageTransparentColor = System.Drawing.Color.Olive;
            this.tbMainFileExit.Name = "tbMainFileExit";
            this.tbMainFileExit.Size = new System.Drawing.Size( 23, 22 );
            this.tbMainFileExit.ToolTipText = "Exit the RedBubble Art Manager";
            this.tbMainFileExit.Click += new System.EventHandler( this.closeApplication );
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 592, 473 );
            this.Controls.Add( this.tbMain );
            this.Controls.Add( this.ssMain );
            this.Controls.Add( this.mnuMain );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "RedBubble Art Manager";
            this.Shown += new System.EventHandler( this.frmMain_Shown );
            this.MdiChildActivate += new System.EventHandler( this.mdiRefresh );
            this.ssMain.ResumeLayout( false );
            this.ssMain.PerformLayout();
            this.mnuMain.ResumeLayout( false );
            this.mnuMain.PerformLayout();
            this.tbMain.ResumeLayout( false );
            this.tbMain.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator mnuFileSplit0;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuArt;
        private System.Windows.Forms.ToolStripMenuItem mnuArtDownload;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisit;
        private System.Windows.Forms.OpenFileDialog ofdArt;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.SaveFileDialog sfdArt;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisitProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisitArt;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisitWork;
        private System.Windows.Forms.ToolStripSeparator mnuArtVisitSplit0;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisitMyBubble;
        private System.Windows.Forms.ToolStripMenuItem mnuArtExport;
        private System.Windows.Forms.ToolStripMenuItem mnuArtExportCSV;
        private System.Windows.Forms.ToolStripMenuItem mnuArtExportTSV;
        private System.Windows.Forms.ToolStripMenuItem mnuArtExportHTML;
        private System.Windows.Forms.ToolStrip tbMain;
        private System.Windows.Forms.ToolStripButton tbMainFileExit;
        private System.Windows.Forms.ToolStripButton tbMainFileNew;
        private System.Windows.Forms.ToolStripButton tbMainFileOpen;
        private System.Windows.Forms.ToolStripButton tbMainFileSave;
        private System.Windows.Forms.ToolStripButton tbMainFileSaveAs;
        private System.Windows.Forms.ToolStripButton tbMainFileClose;
        private System.Windows.Forms.ToolStripSeparator tbMainSep0;
        private System.Windows.Forms.ToolStripSeparator tbMainSep1;
        private System.Windows.Forms.ToolStripButton tbMainArtDownload;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel ttslVersion;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripSeparator mnuArtSep0;
        private System.Windows.Forms.ToolStripMenuItem mnuArtPromote;
        private System.Windows.Forms.ToolStripMenuItem mnuArtPromoteWork;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileVertical;
        private System.Windows.Forms.ToolStripSeparator tbMainSep2;
        private System.Windows.Forms.ToolStripButton tbMainArtPromoteWork;
        private System.Windows.Forms.ToolStripMenuItem mnuArtVisitEdit;
        private System.Windows.Forms.ToolStripButton tbMainArtVisitEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuArtPromoteProfile;
        private System.Windows.Forms.ToolStripButton tbMainArtPromoteProfile;
        private System.Windows.Forms.ToolStripSeparator tbMainSep3;
        private System.Windows.Forms.ToolStripMenuItem mnuArtExportCoolIris;

    }
}

