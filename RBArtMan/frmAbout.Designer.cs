namespace RBArtMan
{
    partial class frmAbout
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDavePearson = new System.Windows.Forms.LinkLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblRedBubble1 = new System.Windows.Forms.Label();
            this.lblRedBubble2 = new System.Windows.Forms.Label();
            this.gbTesters = new System.Windows.Forms.GroupBox();
            this.lblShelleyHeath = new System.Windows.Forms.LinkLabel();
            this.lblJulieLangford = new System.Windows.Forms.LinkLabel();
            this.lblPigleT = new System.Windows.Forms.LinkLabel();
            this.lblBobbie = new System.Windows.Forms.LinkLabel();
            this.lblshawhouse = new System.Windows.Forms.LinkLabel();
            this.lblReflexio = new System.Windows.Forms.LinkLabel();
            this.gbTesters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point( 203, 208 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.lblTitle.Location = new System.Drawing.Point( 9, 13 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 270, 16 );
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RBArtMan - A RedBubble Art Manager";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point( 9, 29 );
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size( 62, 13 );
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: {0}";
            // 
            // lblDavePearson
            // 
            this.lblDavePearson.AutoSize = true;
            this.lblDavePearson.LinkArea = new System.Windows.Forms.LinkArea( 3, 13 );
            this.lblDavePearson.Location = new System.Drawing.Point( 187, 29 );
            this.lblDavePearson.Name = "lblDavePearson";
            this.lblDavePearson.Size = new System.Drawing.Size( 92, 17 );
            this.lblDavePearson.TabIndex = 3;
            this.lblDavePearson.TabStop = true;
            this.lblDavePearson.Text = "By Dave Pearson";
            this.lblDavePearson.UseCompatibleTextRendering = true;
            this.lblDavePearson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.lblDavePearson_LinkClicked );
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point( 9, 54 );
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size( 161, 13 );
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Copyright © 2008 Dave Pearson";
            // 
            // lblRedBubble1
            // 
            this.lblRedBubble1.AutoSize = true;
            this.lblRedBubble1.Location = new System.Drawing.Point( 9, 84 );
            this.lblRedBubble1.MaximumSize = new System.Drawing.Size( 300, 0 );
            this.lblRedBubble1.Name = "lblRedBubble1";
            this.lblRedBubble1.Size = new System.Drawing.Size( 253, 26 );
            this.lblRedBubble1.TabIndex = 5;
            this.lblRedBubble1.Text = "This software is not connected with or endorsed by  RedBubble Pty Ltd.";
            // 
            // lblRedBubble2
            // 
            this.lblRedBubble2.AutoSize = true;
            this.lblRedBubble2.Location = new System.Drawing.Point( 9, 97 );
            this.lblRedBubble2.Name = "lblRedBubble2";
            this.lblRedBubble2.Size = new System.Drawing.Size( 0, 13 );
            this.lblRedBubble2.TabIndex = 6;
            // 
            // gbTesters
            // 
            this.gbTesters.Controls.Add( this.lblReflexio );
            this.gbTesters.Controls.Add( this.lblshawhouse );
            this.gbTesters.Controls.Add( this.lblShelleyHeath );
            this.gbTesters.Controls.Add( this.lblJulieLangford );
            this.gbTesters.Controls.Add( this.lblPigleT );
            this.gbTesters.Controls.Add( this.lblBobbie );
            this.gbTesters.Location = new System.Drawing.Point( 12, 124 );
            this.gbTesters.Name = "gbTesters";
            this.gbTesters.Size = new System.Drawing.Size( 267, 78 );
            this.gbTesters.TabIndex = 7;
            this.gbTesters.TabStop = false;
            this.gbTesters.Text = "Thanks to the testers:";
            // 
            // lblShelleyHeath
            // 
            this.lblShelleyHeath.AutoSize = true;
            this.lblShelleyHeath.Location = new System.Drawing.Point( 6, 55 );
            this.lblShelleyHeath.Name = "lblShelleyHeath";
            this.lblShelleyHeath.Size = new System.Drawing.Size( 73, 13 );
            this.lblShelleyHeath.TabIndex = 3;
            this.lblShelleyHeath.TabStop = true;
            this.lblShelleyHeath.Tag = "http://www.redbubble.com/people/bundygal";
            this.lblShelleyHeath.Text = "Shelley Heath";
            this.lblShelleyHeath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // lblJulieLangford
            // 
            this.lblJulieLangford.AutoSize = true;
            this.lblJulieLangford.Location = new System.Drawing.Point( 6, 42 );
            this.lblJulieLangford.Name = "lblJulieLangford";
            this.lblJulieLangford.Size = new System.Drawing.Size( 73, 13 );
            this.lblJulieLangford.TabIndex = 2;
            this.lblJulieLangford.TabStop = true;
            this.lblJulieLangford.Tag = "http://www.redbubble.com/people/nannajul";
            this.lblJulieLangford.Text = "Julie Langford";
            this.lblJulieLangford.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // lblPigleT
            // 
            this.lblPigleT.AutoSize = true;
            this.lblPigleT.Location = new System.Drawing.Point( 6, 29 );
            this.lblPigleT.Name = "lblPigleT";
            this.lblPigleT.Size = new System.Drawing.Size( 37, 13 );
            this.lblPigleT.TabIndex = 1;
            this.lblPigleT.TabStop = true;
            this.lblPigleT.Tag = "http://www.redbubble.com/people/piglet";
            this.lblPigleT.Text = "PigleT";
            this.lblPigleT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // lblBobbie
            // 
            this.lblBobbie.AutoSize = true;
            this.lblBobbie.Location = new System.Drawing.Point( 6, 16 );
            this.lblBobbie.Name = "lblBobbie";
            this.lblBobbie.Size = new System.Drawing.Size( 40, 13 );
            this.lblBobbie.TabIndex = 0;
            this.lblBobbie.TabStop = true;
            this.lblBobbie.Tag = "http://www.redbubble.com/people/bobbie";
            this.lblBobbie.Text = "Bobbie";
            this.lblBobbie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // lblshawhouse
            // 
            this.lblshawhouse.AutoSize = true;
            this.lblshawhouse.Location = new System.Drawing.Point( 85, 16 );
            this.lblshawhouse.Name = "lblshawhouse";
            this.lblshawhouse.Size = new System.Drawing.Size( 61, 13 );
            this.lblshawhouse.TabIndex = 4;
            this.lblshawhouse.TabStop = true;
            this.lblshawhouse.Tag = "http://www.redbubble.com/people/shawhouse";
            this.lblshawhouse.Text = "shawhouse";
            this.lblshawhouse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // lblReflexio
            // 
            this.lblReflexio.AutoSize = true;
            this.lblReflexio.Location = new System.Drawing.Point( 85, 29 );
            this.lblReflexio.Name = "lblReflexio";
            this.lblReflexio.Size = new System.Drawing.Size( 40, 13 );
            this.lblReflexio.TabIndex = 5;
            this.lblReflexio.TabStop = true;
            this.lblReflexio.Tag = "http://www.redbubble.com/people/reflexio";
            this.lblReflexio.Text = "reflexio";
            this.lblReflexio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.VisitTester );
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size( 290, 240 );
            this.Controls.Add( this.gbTesters );
            this.Controls.Add( this.lblRedBubble2 );
            this.Controls.Add( this.lblRedBubble1 );
            this.Controls.Add( this.lblCopyright );
            this.Controls.Add( this.lblDavePearson );
            this.Controls.Add( this.lblVersion );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.btnOK );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About RBArtMan";
            this.Shown += new System.EventHandler( this.frmAbout_Shown );
            this.gbTesters.ResumeLayout( false );
            this.gbTesters.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel lblDavePearson;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblRedBubble1;
        private System.Windows.Forms.Label lblRedBubble2;
        private System.Windows.Forms.GroupBox gbTesters;
        private System.Windows.Forms.LinkLabel lblBobbie;
        private System.Windows.Forms.LinkLabel lblPigleT;
        private System.Windows.Forms.LinkLabel lblJulieLangford;
        private System.Windows.Forms.LinkLabel lblShelleyHeath;
        private System.Windows.Forms.LinkLabel lblshawhouse;
        private System.Windows.Forms.LinkLabel lblReflexio;
    }
}