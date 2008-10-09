namespace RBArtMan
{
    partial class frmPromoteWorkPreview
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
            this.wbPreview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbPreview
            // 
            this.wbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPreview.IsWebBrowserContextMenuEnabled = false;
            this.wbPreview.Location = new System.Drawing.Point( 0, 0 );
            this.wbPreview.MinimumSize = new System.Drawing.Size( 20, 20 );
            this.wbPreview.Name = "wbPreview";
            this.wbPreview.Size = new System.Drawing.Size( 492, 373 );
            this.wbPreview.TabIndex = 0;
            this.wbPreview.WebBrowserShortcutsEnabled = false;
            this.wbPreview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler( this.wbPreview_DocumentCompleted );
            // 
            // frmPromoteWorkPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 492, 373 );
            this.Controls.Add( this.wbPreview );
            this.Name = "frmPromoteWorkPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promotion Preview";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPreview;
    }
}