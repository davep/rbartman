namespace RBArtMan
{
    partial class frmPromoteWork
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
            this.gbCodeStyle = new System.Windows.Forms.GroupBox();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            this.rbBBCode = new System.Windows.Forms.RadioButton();
            this.rbTextile = new System.Windows.Forms.RadioButton();
            this.edtPromoteCode = new System.Windows.Forms.TextBox();
            this.gbImageStyle = new System.Windows.Forms.GroupBox();
            this.tcTypes = new System.Windows.Forms.TabControl();
            this.tpImage = new System.Windows.Forms.TabPage();
            this.rbExtraSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.cbCropped = new System.Windows.Forms.CheckBox();
            this.tpCard = new System.Windows.Forms.TabPage();
            this.rbBackBlack = new System.Windows.Forms.RadioButton();
            this.rbBackWhite = new System.Windows.Forms.RadioButton();
            this.tpMatted = new System.Windows.Forms.TabPage();
            this.rbMatteBlack = new System.Windows.Forms.RadioButton();
            this.rbMatteBrightWhite = new System.Windows.Forms.RadioButton();
            this.rbMatteOffWhite = new System.Windows.Forms.RadioButton();
            this.tpLaminated = new System.Windows.Forms.TabPage();
            this.gbLaminatedSize = new System.Windows.Forms.GroupBox();
            this.rbLaminatedLarge = new System.Windows.Forms.RadioButton();
            this.rbLaminatedMedium = new System.Windows.Forms.RadioButton();
            this.rbLaminatedSmall = new System.Windows.Forms.RadioButton();
            this.gbLaminatedBorder = new System.Windows.Forms.GroupBox();
            this.rbLaminatedBorderWhite = new System.Windows.Forms.RadioButton();
            this.rbLaminatedBorderBlack = new System.Windows.Forms.RadioButton();
            this.tpMounted = new System.Windows.Forms.TabPage();
            this.rbMountedBlackBorder = new System.Windows.Forms.RadioButton();
            this.rbMountedWhiteBorder = new System.Windows.Forms.RadioButton();
            this.rbMountedNoBorder = new System.Windows.Forms.RadioButton();
            this.tpCanvas = new System.Windows.Forms.TabPage();
            this.lblCanvasOptions = new System.Windows.Forms.Label();
            this.tpFramed = new System.Windows.Forms.TabPage();
            this.gbFramedSize = new System.Windows.Forms.GroupBox();
            this.rbFramedLarge = new System.Windows.Forms.RadioButton();
            this.rbFramedMedium = new System.Windows.Forms.RadioButton();
            this.rbFramedSmall = new System.Windows.Forms.RadioButton();
            this.gbMatteColour = new System.Windows.Forms.GroupBox();
            this.rbFramedMatteBlack = new System.Windows.Forms.RadioButton();
            this.rbFramedMatteBrightWhite = new System.Windows.Forms.RadioButton();
            this.rbFramedMatteOffWhite = new System.Windows.Forms.RadioButton();
            this.gbFrameColour = new System.Windows.Forms.GroupBox();
            this.rbFrameWalnut = new System.Windows.Forms.RadioButton();
            this.rbFrameMocha = new System.Windows.Forms.RadioButton();
            this.rbFrameCherry = new System.Windows.Forms.RadioButton();
            this.rbFrameCharcoal = new System.Windows.Forms.RadioButton();
            this.rbFrameBlack = new System.Windows.Forms.RadioButton();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.gbCardBackgroundColour = new System.Windows.Forms.GroupBox();
            this.gbImageBackgroundColour = new System.Windows.Forms.GroupBox();
            this.cdImagebackground = new System.Windows.Forms.ColorDialog();
            this.pnlCardBackColourPreview = new System.Windows.Forms.Panel();
            this.btnPickCardBackColour = new System.Windows.Forms.Button();
            this.gbCodeStyle.SuspendLayout();
            this.gbImageStyle.SuspendLayout();
            this.tcTypes.SuspendLayout();
            this.tpImage.SuspendLayout();
            this.tpCard.SuspendLayout();
            this.tpMatted.SuspendLayout();
            this.tpLaminated.SuspendLayout();
            this.gbLaminatedSize.SuspendLayout();
            this.gbLaminatedBorder.SuspendLayout();
            this.tpMounted.SuspendLayout();
            this.tpCanvas.SuspendLayout();
            this.tpFramed.SuspendLayout();
            this.gbFramedSize.SuspendLayout();
            this.gbMatteColour.SuspendLayout();
            this.gbFrameColour.SuspendLayout();
            this.gbCardBackgroundColour.SuspendLayout();
            this.gbImageBackgroundColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodeStyle
            // 
            this.gbCodeStyle.Controls.Add( this.rbHTML );
            this.gbCodeStyle.Controls.Add( this.rbBBCode );
            this.gbCodeStyle.Controls.Add( this.rbTextile );
            this.gbCodeStyle.Location = new System.Drawing.Point( 12, 12 );
            this.gbCodeStyle.Name = "gbCodeStyle";
            this.gbCodeStyle.Size = new System.Drawing.Size( 364, 52 );
            this.gbCodeStyle.TabIndex = 0;
            this.gbCodeStyle.TabStop = false;
            this.gbCodeStyle.Text = "C&ode Style";
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point( 239, 19 );
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size( 55, 17 );
            this.rbHTML.TabIndex = 2;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            this.rbHTML.Click += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbBBCode
            // 
            this.rbBBCode.AutoSize = true;
            this.rbBBCode.Location = new System.Drawing.Point( 159, 19 );
            this.rbBBCode.Name = "rbBBCode";
            this.rbBBCode.Size = new System.Drawing.Size( 64, 17 );
            this.rbBBCode.TabIndex = 1;
            this.rbBBCode.Text = "BBCode";
            this.rbBBCode.UseVisualStyleBackColor = true;
            this.rbBBCode.Click += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbTextile
            // 
            this.rbTextile.AutoSize = true;
            this.rbTextile.Checked = true;
            this.rbTextile.Location = new System.Drawing.Point( 10, 19 );
            this.rbTextile.Name = "rbTextile";
            this.rbTextile.Size = new System.Drawing.Size( 133, 17 );
            this.rbTextile.TabIndex = 0;
            this.rbTextile.TabStop = true;
            this.rbTextile.Text = "Textile (for RedBubble)";
            this.rbTextile.UseVisualStyleBackColor = true;
            this.rbTextile.Click += new System.EventHandler( this.codeStyleChanged );
            // 
            // edtPromoteCode
            // 
            this.edtPromoteCode.Location = new System.Drawing.Point( 12, 227 );
            this.edtPromoteCode.Multiline = true;
            this.edtPromoteCode.Name = "edtPromoteCode";
            this.edtPromoteCode.ReadOnly = true;
            this.edtPromoteCode.Size = new System.Drawing.Size( 364, 85 );
            this.edtPromoteCode.TabIndex = 2;
            // 
            // gbImageStyle
            // 
            this.gbImageStyle.Controls.Add( this.tcTypes );
            this.gbImageStyle.Location = new System.Drawing.Point( 12, 70 );
            this.gbImageStyle.Name = "gbImageStyle";
            this.gbImageStyle.Size = new System.Drawing.Size( 364, 151 );
            this.gbImageStyle.TabIndex = 1;
            this.gbImageStyle.TabStop = false;
            this.gbImageStyle.Text = "&Image Style";
            // 
            // tcTypes
            // 
            this.tcTypes.Controls.Add( this.tpImage );
            this.tcTypes.Controls.Add( this.tpCard );
            this.tcTypes.Controls.Add( this.tpMatted );
            this.tcTypes.Controls.Add( this.tpLaminated );
            this.tcTypes.Controls.Add( this.tpMounted );
            this.tcTypes.Controls.Add( this.tpCanvas );
            this.tcTypes.Controls.Add( this.tpFramed );
            this.tcTypes.Location = new System.Drawing.Point( 6, 19 );
            this.tcTypes.Name = "tcTypes";
            this.tcTypes.SelectedIndex = 0;
            this.tcTypes.Size = new System.Drawing.Size( 352, 126 );
            this.tcTypes.TabIndex = 0;
            this.tcTypes.SelectedIndexChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpImage
            // 
            this.tpImage.Controls.Add( this.rbExtraSmall );
            this.tpImage.Controls.Add( this.rbLarge );
            this.tpImage.Controls.Add( this.rbMedium );
            this.tpImage.Controls.Add( this.rbSmall );
            this.tpImage.Controls.Add( this.cbCropped );
            this.tpImage.Location = new System.Drawing.Point( 4, 22 );
            this.tpImage.Name = "tpImage";
            this.tpImage.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpImage.Size = new System.Drawing.Size( 344, 100 );
            this.tpImage.TabIndex = 0;
            this.tpImage.Text = "Image";
            this.tpImage.UseVisualStyleBackColor = true;
            // 
            // rbExtraSmall
            // 
            this.rbExtraSmall.AutoSize = true;
            this.rbExtraSmall.Location = new System.Drawing.Point( 6, 31 );
            this.rbExtraSmall.Name = "rbExtraSmall";
            this.rbExtraSmall.Size = new System.Drawing.Size( 77, 17 );
            this.rbExtraSmall.TabIndex = 6;
            this.rbExtraSmall.Text = "Extra Small";
            this.rbExtraSmall.UseVisualStyleBackColor = true;
            this.rbExtraSmall.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point( 93, 54 );
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size( 52, 17 );
            this.rbLarge.TabIndex = 9;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point( 93, 31 );
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size( 62, 17 );
            this.rbMedium.TabIndex = 8;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point( 6, 54 );
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size( 50, 17 );
            this.rbSmall.TabIndex = 7;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // cbCropped
            // 
            this.cbCropped.AutoSize = true;
            this.cbCropped.Location = new System.Drawing.Point( 6, 6 );
            this.cbCropped.Name = "cbCropped";
            this.cbCropped.Size = new System.Drawing.Size( 66, 17 );
            this.cbCropped.TabIndex = 5;
            this.cbCropped.Text = "Cropped";
            this.cbCropped.UseVisualStyleBackColor = true;
            this.cbCropped.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpCard
            // 
            this.tpCard.Controls.Add( this.gbImageBackgroundColour );
            this.tpCard.Controls.Add( this.gbCardBackgroundColour );
            this.tpCard.Location = new System.Drawing.Point( 4, 22 );
            this.tpCard.Name = "tpCard";
            this.tpCard.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpCard.Size = new System.Drawing.Size( 344, 100 );
            this.tpCard.TabIndex = 1;
            this.tpCard.Text = "Card";
            this.tpCard.UseVisualStyleBackColor = true;
            // 
            // rbBackBlack
            // 
            this.rbBackBlack.AutoSize = true;
            this.rbBackBlack.Location = new System.Drawing.Point( 26, 51 );
            this.rbBackBlack.Name = "rbBackBlack";
            this.rbBackBlack.Size = new System.Drawing.Size( 113, 17 );
            this.rbBackBlack.TabIndex = 1;
            this.rbBackBlack.Text = "Black Background";
            this.rbBackBlack.UseVisualStyleBackColor = true;
            this.rbBackBlack.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbBackWhite
            // 
            this.rbBackWhite.AutoSize = true;
            this.rbBackWhite.Checked = true;
            this.rbBackWhite.Location = new System.Drawing.Point( 26, 28 );
            this.rbBackWhite.Name = "rbBackWhite";
            this.rbBackWhite.Size = new System.Drawing.Size( 114, 17 );
            this.rbBackWhite.TabIndex = 0;
            this.rbBackWhite.TabStop = true;
            this.rbBackWhite.Text = "White Background";
            this.rbBackWhite.UseVisualStyleBackColor = true;
            this.rbBackWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpMatted
            // 
            this.tpMatted.Controls.Add( this.rbMatteBlack );
            this.tpMatted.Controls.Add( this.rbMatteBrightWhite );
            this.tpMatted.Controls.Add( this.rbMatteOffWhite );
            this.tpMatted.Location = new System.Drawing.Point( 4, 22 );
            this.tpMatted.Name = "tpMatted";
            this.tpMatted.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpMatted.Size = new System.Drawing.Size( 344, 100 );
            this.tpMatted.TabIndex = 2;
            this.tpMatted.Text = "Matted";
            this.tpMatted.UseVisualStyleBackColor = true;
            // 
            // rbMatteBlack
            // 
            this.rbMatteBlack.AutoSize = true;
            this.rbMatteBlack.Location = new System.Drawing.Point( 13, 62 );
            this.rbMatteBlack.Name = "rbMatteBlack";
            this.rbMatteBlack.Size = new System.Drawing.Size( 82, 17 );
            this.rbMatteBlack.TabIndex = 2;
            this.rbMatteBlack.Text = "Black Matte";
            this.rbMatteBlack.UseVisualStyleBackColor = true;
            this.rbMatteBlack.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbMatteBrightWhite
            // 
            this.rbMatteBrightWhite.AutoSize = true;
            this.rbMatteBrightWhite.Location = new System.Drawing.Point( 13, 38 );
            this.rbMatteBrightWhite.Name = "rbMatteBrightWhite";
            this.rbMatteBrightWhite.Size = new System.Drawing.Size( 113, 17 );
            this.rbMatteBrightWhite.TabIndex = 1;
            this.rbMatteBrightWhite.Text = "Bright White Matte";
            this.rbMatteBrightWhite.UseVisualStyleBackColor = true;
            this.rbMatteBrightWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbMatteOffWhite
            // 
            this.rbMatteOffWhite.AutoSize = true;
            this.rbMatteOffWhite.Checked = true;
            this.rbMatteOffWhite.Location = new System.Drawing.Point( 13, 15 );
            this.rbMatteOffWhite.Name = "rbMatteOffWhite";
            this.rbMatteOffWhite.Size = new System.Drawing.Size( 100, 17 );
            this.rbMatteOffWhite.TabIndex = 0;
            this.rbMatteOffWhite.TabStop = true;
            this.rbMatteOffWhite.Text = "Off White Matte";
            this.rbMatteOffWhite.UseVisualStyleBackColor = true;
            this.rbMatteOffWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpLaminated
            // 
            this.tpLaminated.Controls.Add( this.gbLaminatedSize );
            this.tpLaminated.Controls.Add( this.gbLaminatedBorder );
            this.tpLaminated.Location = new System.Drawing.Point( 4, 22 );
            this.tpLaminated.Name = "tpLaminated";
            this.tpLaminated.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpLaminated.Size = new System.Drawing.Size( 344, 100 );
            this.tpLaminated.TabIndex = 3;
            this.tpLaminated.Text = "Laminated";
            this.tpLaminated.UseVisualStyleBackColor = true;
            // 
            // gbLaminatedSize
            // 
            this.gbLaminatedSize.Controls.Add( this.rbLaminatedLarge );
            this.gbLaminatedSize.Controls.Add( this.rbLaminatedMedium );
            this.gbLaminatedSize.Controls.Add( this.rbLaminatedSmall );
            this.gbLaminatedSize.Location = new System.Drawing.Point( 200, 10 );
            this.gbLaminatedSize.Name = "gbLaminatedSize";
            this.gbLaminatedSize.Size = new System.Drawing.Size( 138, 84 );
            this.gbLaminatedSize.TabIndex = 3;
            this.gbLaminatedSize.TabStop = false;
            this.gbLaminatedSize.Text = "Size";
            // 
            // rbLaminatedLarge
            // 
            this.rbLaminatedLarge.AutoSize = true;
            this.rbLaminatedLarge.Location = new System.Drawing.Point( 17, 61 );
            this.rbLaminatedLarge.Name = "rbLaminatedLarge";
            this.rbLaminatedLarge.Size = new System.Drawing.Size( 52, 17 );
            this.rbLaminatedLarge.TabIndex = 2;
            this.rbLaminatedLarge.Text = "Large";
            this.rbLaminatedLarge.UseVisualStyleBackColor = true;
            this.rbLaminatedLarge.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbLaminatedMedium
            // 
            this.rbLaminatedMedium.AutoSize = true;
            this.rbLaminatedMedium.Location = new System.Drawing.Point( 17, 40 );
            this.rbLaminatedMedium.Name = "rbLaminatedMedium";
            this.rbLaminatedMedium.Size = new System.Drawing.Size( 62, 17 );
            this.rbLaminatedMedium.TabIndex = 1;
            this.rbLaminatedMedium.Text = "Medium";
            this.rbLaminatedMedium.UseVisualStyleBackColor = true;
            this.rbLaminatedMedium.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbLaminatedSmall
            // 
            this.rbLaminatedSmall.AutoSize = true;
            this.rbLaminatedSmall.Checked = true;
            this.rbLaminatedSmall.Location = new System.Drawing.Point( 17, 19 );
            this.rbLaminatedSmall.Name = "rbLaminatedSmall";
            this.rbLaminatedSmall.Size = new System.Drawing.Size( 50, 17 );
            this.rbLaminatedSmall.TabIndex = 0;
            this.rbLaminatedSmall.TabStop = true;
            this.rbLaminatedSmall.Text = "Small";
            this.rbLaminatedSmall.UseVisualStyleBackColor = true;
            this.rbLaminatedSmall.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // gbLaminatedBorder
            // 
            this.gbLaminatedBorder.Controls.Add( this.rbLaminatedBorderWhite );
            this.gbLaminatedBorder.Controls.Add( this.rbLaminatedBorderBlack );
            this.gbLaminatedBorder.Location = new System.Drawing.Point( 6, 10 );
            this.gbLaminatedBorder.Name = "gbLaminatedBorder";
            this.gbLaminatedBorder.Size = new System.Drawing.Size( 188, 84 );
            this.gbLaminatedBorder.TabIndex = 2;
            this.gbLaminatedBorder.TabStop = false;
            this.gbLaminatedBorder.Text = "Border";
            // 
            // rbLaminatedBorderWhite
            // 
            this.rbLaminatedBorderWhite.AutoSize = true;
            this.rbLaminatedBorderWhite.Checked = true;
            this.rbLaminatedBorderWhite.Location = new System.Drawing.Point( 6, 26 );
            this.rbLaminatedBorderWhite.Name = "rbLaminatedBorderWhite";
            this.rbLaminatedBorderWhite.Size = new System.Drawing.Size( 173, 17 );
            this.rbLaminatedBorderWhite.TabIndex = 0;
            this.rbLaminatedBorderWhite.TabStop = true;
            this.rbLaminatedBorderWhite.Text = "White border with artist\'s details";
            this.rbLaminatedBorderWhite.UseVisualStyleBackColor = true;
            this.rbLaminatedBorderWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbLaminatedBorderBlack
            // 
            this.rbLaminatedBorderBlack.AutoSize = true;
            this.rbLaminatedBorderBlack.Location = new System.Drawing.Point( 6, 49 );
            this.rbLaminatedBorderBlack.Name = "rbLaminatedBorderBlack";
            this.rbLaminatedBorderBlack.Size = new System.Drawing.Size( 172, 17 );
            this.rbLaminatedBorderBlack.TabIndex = 1;
            this.rbLaminatedBorderBlack.Text = "Black border with artist\'s details";
            this.rbLaminatedBorderBlack.UseVisualStyleBackColor = true;
            this.rbLaminatedBorderBlack.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpMounted
            // 
            this.tpMounted.Controls.Add( this.rbMountedBlackBorder );
            this.tpMounted.Controls.Add( this.rbMountedWhiteBorder );
            this.tpMounted.Controls.Add( this.rbMountedNoBorder );
            this.tpMounted.Location = new System.Drawing.Point( 4, 22 );
            this.tpMounted.Name = "tpMounted";
            this.tpMounted.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpMounted.Size = new System.Drawing.Size( 344, 100 );
            this.tpMounted.TabIndex = 4;
            this.tpMounted.Text = "Mounted";
            this.tpMounted.UseVisualStyleBackColor = true;
            // 
            // rbMountedBlackBorder
            // 
            this.rbMountedBlackBorder.AutoSize = true;
            this.rbMountedBlackBorder.Location = new System.Drawing.Point( 19, 65 );
            this.rbMountedBlackBorder.Name = "rbMountedBlackBorder";
            this.rbMountedBlackBorder.Size = new System.Drawing.Size( 172, 17 );
            this.rbMountedBlackBorder.TabIndex = 2;
            this.rbMountedBlackBorder.Text = "Black border with artist\'s details";
            this.rbMountedBlackBorder.UseVisualStyleBackColor = true;
            this.rbMountedBlackBorder.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbMountedWhiteBorder
            // 
            this.rbMountedWhiteBorder.AutoSize = true;
            this.rbMountedWhiteBorder.Location = new System.Drawing.Point( 19, 42 );
            this.rbMountedWhiteBorder.Name = "rbMountedWhiteBorder";
            this.rbMountedWhiteBorder.Size = new System.Drawing.Size( 173, 17 );
            this.rbMountedWhiteBorder.TabIndex = 1;
            this.rbMountedWhiteBorder.Text = "White border with artist\'s details";
            this.rbMountedWhiteBorder.UseVisualStyleBackColor = true;
            this.rbMountedWhiteBorder.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbMountedNoBorder
            // 
            this.rbMountedNoBorder.AutoSize = true;
            this.rbMountedNoBorder.Checked = true;
            this.rbMountedNoBorder.Location = new System.Drawing.Point( 19, 19 );
            this.rbMountedNoBorder.Name = "rbMountedNoBorder";
            this.rbMountedNoBorder.Size = new System.Drawing.Size( 73, 17 );
            this.rbMountedNoBorder.TabIndex = 0;
            this.rbMountedNoBorder.TabStop = true;
            this.rbMountedNoBorder.Text = "No Border";
            this.rbMountedNoBorder.UseVisualStyleBackColor = true;
            this.rbMountedNoBorder.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // tpCanvas
            // 
            this.tpCanvas.Controls.Add( this.lblCanvasOptions );
            this.tpCanvas.Location = new System.Drawing.Point( 4, 22 );
            this.tpCanvas.Name = "tpCanvas";
            this.tpCanvas.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpCanvas.Size = new System.Drawing.Size( 344, 100 );
            this.tpCanvas.TabIndex = 5;
            this.tpCanvas.Text = "Canvas";
            this.tpCanvas.UseVisualStyleBackColor = true;
            // 
            // lblCanvasOptions
            // 
            this.lblCanvasOptions.AutoSize = true;
            this.lblCanvasOptions.Location = new System.Drawing.Point( 86, 44 );
            this.lblCanvasOptions.Name = "lblCanvasOptions";
            this.lblCanvasOptions.Size = new System.Drawing.Size( 179, 13 );
            this.lblCanvasOptions.TabIndex = 0;
            this.lblCanvasOptions.Text = "No options for canvas print previews";
            // 
            // tpFramed
            // 
            this.tpFramed.Controls.Add( this.gbFramedSize );
            this.tpFramed.Controls.Add( this.gbMatteColour );
            this.tpFramed.Controls.Add( this.gbFrameColour );
            this.tpFramed.Location = new System.Drawing.Point( 4, 22 );
            this.tpFramed.Name = "tpFramed";
            this.tpFramed.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpFramed.Size = new System.Drawing.Size( 344, 100 );
            this.tpFramed.TabIndex = 6;
            this.tpFramed.Text = "Framed";
            this.tpFramed.UseVisualStyleBackColor = true;
            // 
            // gbFramedSize
            // 
            this.gbFramedSize.Controls.Add( this.rbFramedLarge );
            this.gbFramedSize.Controls.Add( this.rbFramedMedium );
            this.gbFramedSize.Controls.Add( this.rbFramedSmall );
            this.gbFramedSize.Location = new System.Drawing.Point( 248, 6 );
            this.gbFramedSize.Name = "gbFramedSize";
            this.gbFramedSize.Size = new System.Drawing.Size( 90, 88 );
            this.gbFramedSize.TabIndex = 4;
            this.gbFramedSize.TabStop = false;
            this.gbFramedSize.Text = "Size";
            // 
            // rbFramedLarge
            // 
            this.rbFramedLarge.AutoSize = true;
            this.rbFramedLarge.Location = new System.Drawing.Point( 17, 61 );
            this.rbFramedLarge.Name = "rbFramedLarge";
            this.rbFramedLarge.Size = new System.Drawing.Size( 52, 17 );
            this.rbFramedLarge.TabIndex = 2;
            this.rbFramedLarge.Text = "Large";
            this.rbFramedLarge.UseVisualStyleBackColor = true;
            this.rbFramedLarge.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFramedMedium
            // 
            this.rbFramedMedium.AutoSize = true;
            this.rbFramedMedium.Location = new System.Drawing.Point( 17, 40 );
            this.rbFramedMedium.Name = "rbFramedMedium";
            this.rbFramedMedium.Size = new System.Drawing.Size( 62, 17 );
            this.rbFramedMedium.TabIndex = 1;
            this.rbFramedMedium.Text = "Medium";
            this.rbFramedMedium.UseVisualStyleBackColor = true;
            this.rbFramedMedium.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFramedSmall
            // 
            this.rbFramedSmall.AutoSize = true;
            this.rbFramedSmall.Checked = true;
            this.rbFramedSmall.Location = new System.Drawing.Point( 17, 19 );
            this.rbFramedSmall.Name = "rbFramedSmall";
            this.rbFramedSmall.Size = new System.Drawing.Size( 50, 17 );
            this.rbFramedSmall.TabIndex = 0;
            this.rbFramedSmall.TabStop = true;
            this.rbFramedSmall.Text = "Small";
            this.rbFramedSmall.UseVisualStyleBackColor = true;
            this.rbFramedSmall.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // gbMatteColour
            // 
            this.gbMatteColour.Controls.Add( this.rbFramedMatteBlack );
            this.gbMatteColour.Controls.Add( this.rbFramedMatteBrightWhite );
            this.gbMatteColour.Controls.Add( this.rbFramedMatteOffWhite );
            this.gbMatteColour.Location = new System.Drawing.Point( 150, 6 );
            this.gbMatteColour.Name = "gbMatteColour";
            this.gbMatteColour.Size = new System.Drawing.Size( 96, 88 );
            this.gbMatteColour.TabIndex = 1;
            this.gbMatteColour.TabStop = false;
            this.gbMatteColour.Text = "Matte Colour";
            // 
            // rbFramedMatteBlack
            // 
            this.rbFramedMatteBlack.AutoSize = true;
            this.rbFramedMatteBlack.Location = new System.Drawing.Point( 10, 65 );
            this.rbFramedMatteBlack.Name = "rbFramedMatteBlack";
            this.rbFramedMatteBlack.Size = new System.Drawing.Size( 52, 17 );
            this.rbFramedMatteBlack.TabIndex = 2;
            this.rbFramedMatteBlack.Text = "Black";
            this.rbFramedMatteBlack.UseVisualStyleBackColor = true;
            this.rbFramedMatteBlack.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFramedMatteBrightWhite
            // 
            this.rbFramedMatteBrightWhite.AutoSize = true;
            this.rbFramedMatteBrightWhite.Location = new System.Drawing.Point( 10, 42 );
            this.rbFramedMatteBrightWhite.Name = "rbFramedMatteBrightWhite";
            this.rbFramedMatteBrightWhite.Size = new System.Drawing.Size( 83, 17 );
            this.rbFramedMatteBrightWhite.TabIndex = 1;
            this.rbFramedMatteBrightWhite.Text = "Bright White";
            this.rbFramedMatteBrightWhite.UseVisualStyleBackColor = true;
            this.rbFramedMatteBrightWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFramedMatteOffWhite
            // 
            this.rbFramedMatteOffWhite.AutoSize = true;
            this.rbFramedMatteOffWhite.Checked = true;
            this.rbFramedMatteOffWhite.Location = new System.Drawing.Point( 10, 19 );
            this.rbFramedMatteOffWhite.Name = "rbFramedMatteOffWhite";
            this.rbFramedMatteOffWhite.Size = new System.Drawing.Size( 70, 17 );
            this.rbFramedMatteOffWhite.TabIndex = 0;
            this.rbFramedMatteOffWhite.TabStop = true;
            this.rbFramedMatteOffWhite.Text = "Off White";
            this.rbFramedMatteOffWhite.UseVisualStyleBackColor = true;
            this.rbFramedMatteOffWhite.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // gbFrameColour
            // 
            this.gbFrameColour.Controls.Add( this.rbFrameWalnut );
            this.gbFrameColour.Controls.Add( this.rbFrameMocha );
            this.gbFrameColour.Controls.Add( this.rbFrameCherry );
            this.gbFrameColour.Controls.Add( this.rbFrameCharcoal );
            this.gbFrameColour.Controls.Add( this.rbFrameBlack );
            this.gbFrameColour.Location = new System.Drawing.Point( 6, 6 );
            this.gbFrameColour.Name = "gbFrameColour";
            this.gbFrameColour.Size = new System.Drawing.Size( 142, 88 );
            this.gbFrameColour.TabIndex = 0;
            this.gbFrameColour.TabStop = false;
            this.gbFrameColour.Text = "Frame Colour";
            // 
            // rbFrameWalnut
            // 
            this.rbFrameWalnut.AutoSize = true;
            this.rbFrameWalnut.Location = new System.Drawing.Point( 78, 42 );
            this.rbFrameWalnut.Name = "rbFrameWalnut";
            this.rbFrameWalnut.Size = new System.Drawing.Size( 59, 17 );
            this.rbFrameWalnut.TabIndex = 4;
            this.rbFrameWalnut.Text = "Walnut";
            this.rbFrameWalnut.UseVisualStyleBackColor = true;
            this.rbFrameWalnut.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFrameMocha
            // 
            this.rbFrameMocha.AutoSize = true;
            this.rbFrameMocha.Location = new System.Drawing.Point( 79, 19 );
            this.rbFrameMocha.Name = "rbFrameMocha";
            this.rbFrameMocha.Size = new System.Drawing.Size( 58, 17 );
            this.rbFrameMocha.TabIndex = 3;
            this.rbFrameMocha.Text = "Mocha";
            this.rbFrameMocha.UseVisualStyleBackColor = true;
            this.rbFrameMocha.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFrameCherry
            // 
            this.rbFrameCherry.AutoSize = true;
            this.rbFrameCherry.Location = new System.Drawing.Point( 6, 65 );
            this.rbFrameCherry.Name = "rbFrameCherry";
            this.rbFrameCherry.Size = new System.Drawing.Size( 55, 17 );
            this.rbFrameCherry.TabIndex = 2;
            this.rbFrameCherry.Text = "Cherry";
            this.rbFrameCherry.UseVisualStyleBackColor = true;
            this.rbFrameCherry.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFrameCharcoal
            // 
            this.rbFrameCharcoal.AutoSize = true;
            this.rbFrameCharcoal.Location = new System.Drawing.Point( 6, 42 );
            this.rbFrameCharcoal.Name = "rbFrameCharcoal";
            this.rbFrameCharcoal.Size = new System.Drawing.Size( 67, 17 );
            this.rbFrameCharcoal.TabIndex = 1;
            this.rbFrameCharcoal.Text = "Charcoal";
            this.rbFrameCharcoal.UseVisualStyleBackColor = true;
            this.rbFrameCharcoal.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbFrameBlack
            // 
            this.rbFrameBlack.AutoSize = true;
            this.rbFrameBlack.Checked = true;
            this.rbFrameBlack.Location = new System.Drawing.Point( 6, 19 );
            this.rbFrameBlack.Name = "rbFrameBlack";
            this.rbFrameBlack.Size = new System.Drawing.Size( 52, 17 );
            this.rbFrameBlack.TabIndex = 0;
            this.rbFrameBlack.TabStop = true;
            this.rbFrameBlack.Text = "Black";
            this.rbFrameBlack.UseVisualStyleBackColor = true;
            this.rbFrameBlack.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point( 12, 318 );
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size( 123, 23 );
            this.btnClipboard.TabIndex = 3;
            this.btnClipboard.Text = "&Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler( this.btnClipboard_Click );
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point( 301, 318 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 75, 23 );
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point( 141, 318 );
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size( 75, 23 );
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler( this.btnPreview_Click );
            // 
            // gbCardBackgroundColour
            // 
            this.gbCardBackgroundColour.Controls.Add( this.rbBackWhite );
            this.gbCardBackgroundColour.Controls.Add( this.rbBackBlack );
            this.gbCardBackgroundColour.Location = new System.Drawing.Point( 6, 6 );
            this.gbCardBackgroundColour.Name = "gbCardBackgroundColour";
            this.gbCardBackgroundColour.Size = new System.Drawing.Size( 173, 88 );
            this.gbCardBackgroundColour.TabIndex = 2;
            this.gbCardBackgroundColour.TabStop = false;
            this.gbCardBackgroundColour.Text = "Card Background Colour";
            // 
            // gbImageBackgroundColour
            // 
            this.gbImageBackgroundColour.Controls.Add( this.btnPickCardBackColour );
            this.gbImageBackgroundColour.Controls.Add( this.pnlCardBackColourPreview );
            this.gbImageBackgroundColour.Location = new System.Drawing.Point( 185, 6 );
            this.gbImageBackgroundColour.Name = "gbImageBackgroundColour";
            this.gbImageBackgroundColour.Size = new System.Drawing.Size( 153, 88 );
            this.gbImageBackgroundColour.TabIndex = 3;
            this.gbImageBackgroundColour.TabStop = false;
            this.gbImageBackgroundColour.Text = "Image Background Colour";
            this.gbImageBackgroundColour.Visible = false;
            // 
            // cdImagebackground
            // 
            this.cdImagebackground.Color = System.Drawing.Color.White;
            // 
            // pnlCardBackColourPreview
            // 
            this.pnlCardBackColourPreview.BackColor = System.Drawing.Color.White;
            this.pnlCardBackColourPreview.Location = new System.Drawing.Point( 73, 20 );
            this.pnlCardBackColourPreview.Name = "pnlCardBackColourPreview";
            this.pnlCardBackColourPreview.Size = new System.Drawing.Size( 74, 62 );
            this.pnlCardBackColourPreview.TabIndex = 0;
            // 
            // btnPickCardBackColour
            // 
            this.btnPickCardBackColour.Location = new System.Drawing.Point( 13, 37 );
            this.btnPickCardBackColour.Name = "btnPickCardBackColour";
            this.btnPickCardBackColour.Size = new System.Drawing.Size( 46, 23 );
            this.btnPickCardBackColour.TabIndex = 1;
            this.btnPickCardBackColour.Text = "Pick";
            this.btnPickCardBackColour.UseVisualStyleBackColor = true;
            this.btnPickCardBackColour.Click += new System.EventHandler( this.btnPickCardBackColour_Click );
            // 
            // frmPromoteWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size( 388, 347 );
            this.Controls.Add( this.btnPreview );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.btnClipboard );
            this.Controls.Add( this.gbImageStyle );
            this.Controls.Add( this.edtPromoteCode );
            this.Controls.Add( this.gbCodeStyle );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPromoteWork";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Work Promoter";
            this.Shown += new System.EventHandler( this.frmPromoteWork_Shown );
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.frmPromoteWork_FormClosed );
            this.gbCodeStyle.ResumeLayout( false );
            this.gbCodeStyle.PerformLayout();
            this.gbImageStyle.ResumeLayout( false );
            this.tcTypes.ResumeLayout( false );
            this.tpImage.ResumeLayout( false );
            this.tpImage.PerformLayout();
            this.tpCard.ResumeLayout( false );
            this.tpMatted.ResumeLayout( false );
            this.tpMatted.PerformLayout();
            this.tpLaminated.ResumeLayout( false );
            this.gbLaminatedSize.ResumeLayout( false );
            this.gbLaminatedSize.PerformLayout();
            this.gbLaminatedBorder.ResumeLayout( false );
            this.gbLaminatedBorder.PerformLayout();
            this.tpMounted.ResumeLayout( false );
            this.tpMounted.PerformLayout();
            this.tpCanvas.ResumeLayout( false );
            this.tpCanvas.PerformLayout();
            this.tpFramed.ResumeLayout( false );
            this.gbFramedSize.ResumeLayout( false );
            this.gbFramedSize.PerformLayout();
            this.gbMatteColour.ResumeLayout( false );
            this.gbMatteColour.PerformLayout();
            this.gbFrameColour.ResumeLayout( false );
            this.gbFrameColour.PerformLayout();
            this.gbCardBackgroundColour.ResumeLayout( false );
            this.gbCardBackgroundColour.PerformLayout();
            this.gbImageBackgroundColour.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCodeStyle;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.RadioButton rbBBCode;
        private System.Windows.Forms.RadioButton rbTextile;
        private System.Windows.Forms.TextBox edtPromoteCode;
        private System.Windows.Forms.GroupBox gbImageStyle;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tcTypes;
        private System.Windows.Forms.TabPage tpImage;
        private System.Windows.Forms.RadioButton rbExtraSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.CheckBox cbCropped;
        private System.Windows.Forms.TabPage tpCard;
        private System.Windows.Forms.RadioButton rbBackBlack;
        private System.Windows.Forms.RadioButton rbBackWhite;
        private System.Windows.Forms.TabPage tpMatted;
        private System.Windows.Forms.RadioButton rbMatteBlack;
        private System.Windows.Forms.RadioButton rbMatteBrightWhite;
        private System.Windows.Forms.RadioButton rbMatteOffWhite;
        private System.Windows.Forms.TabPage tpLaminated;
        private System.Windows.Forms.RadioButton rbLaminatedBorderBlack;
        private System.Windows.Forms.RadioButton rbLaminatedBorderWhite;
        private System.Windows.Forms.TabPage tpMounted;
        private System.Windows.Forms.RadioButton rbMountedBlackBorder;
        private System.Windows.Forms.RadioButton rbMountedWhiteBorder;
        private System.Windows.Forms.RadioButton rbMountedNoBorder;
        private System.Windows.Forms.TabPage tpCanvas;
        private System.Windows.Forms.Label lblCanvasOptions;
        private System.Windows.Forms.TabPage tpFramed;
        private System.Windows.Forms.GroupBox gbMatteColour;
        private System.Windows.Forms.GroupBox gbFrameColour;
        private System.Windows.Forms.RadioButton rbFramedMatteBlack;
        private System.Windows.Forms.RadioButton rbFramedMatteBrightWhite;
        private System.Windows.Forms.RadioButton rbFramedMatteOffWhite;
        private System.Windows.Forms.RadioButton rbFrameWalnut;
        private System.Windows.Forms.RadioButton rbFrameMocha;
        private System.Windows.Forms.RadioButton rbFrameCherry;
        private System.Windows.Forms.RadioButton rbFrameCharcoal;
        private System.Windows.Forms.RadioButton rbFrameBlack;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox gbLaminatedSize;
        private System.Windows.Forms.RadioButton rbLaminatedLarge;
        private System.Windows.Forms.RadioButton rbLaminatedMedium;
        private System.Windows.Forms.RadioButton rbLaminatedSmall;
        private System.Windows.Forms.GroupBox gbLaminatedBorder;
        private System.Windows.Forms.GroupBox gbFramedSize;
        private System.Windows.Forms.RadioButton rbFramedLarge;
        private System.Windows.Forms.RadioButton rbFramedMedium;
        private System.Windows.Forms.RadioButton rbFramedSmall;
        private System.Windows.Forms.GroupBox gbImageBackgroundColour;
        private System.Windows.Forms.Panel pnlCardBackColourPreview;
        private System.Windows.Forms.GroupBox gbCardBackgroundColour;
        private System.Windows.Forms.ColorDialog cdImagebackground;
        private System.Windows.Forms.Button btnPickCardBackColour;
    }
}