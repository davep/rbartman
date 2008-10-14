namespace RBArtMan
{
    partial class frmExportMediaRSS
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
            this.gbLinkTo = new System.Windows.Forms.GroupBox();
            this.rbLinkToBuy = new System.Windows.Forms.RadioButton();
            this.rbLinkToView = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.edtTitle = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.edtLink = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.edtAuthor = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.edtCopyright = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbLinkTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLinkTo
            // 
            this.gbLinkTo.Controls.Add( this.rbLinkToBuy );
            this.gbLinkTo.Controls.Add( this.rbLinkToView );
            this.gbLinkTo.Location = new System.Drawing.Point( 12, 12 );
            this.gbLinkTo.Name = "gbLinkTo";
            this.gbLinkTo.Size = new System.Drawing.Size( 225, 72 );
            this.gbLinkTo.TabIndex = 1;
            this.gbLinkTo.TabStop = false;
            this.gbLinkTo.Text = "Link To:";
            // 
            // rbLinkToBuy
            // 
            this.rbLinkToBuy.AutoSize = true;
            this.rbLinkToBuy.Location = new System.Drawing.Point( 6, 42 );
            this.rbLinkToBuy.Name = "rbLinkToBuy";
            this.rbLinkToBuy.Size = new System.Drawing.Size( 190, 17 );
            this.rbLinkToBuy.TabIndex = 1;
            this.rbLinkToBuy.Text = "Link to the buy page for each work";
            this.rbLinkToBuy.UseVisualStyleBackColor = true;
            // 
            // rbLinkToView
            // 
            this.rbLinkToView.AutoSize = true;
            this.rbLinkToView.Checked = true;
            this.rbLinkToView.Location = new System.Drawing.Point( 6, 19 );
            this.rbLinkToView.Name = "rbLinkToView";
            this.rbLinkToView.Size = new System.Drawing.Size( 211, 17 );
            this.rbLinkToView.TabIndex = 0;
            this.rbLinkToView.TabStop = true;
            this.rbLinkToView.Text = "Link to normal view page for each work";
            this.rbLinkToView.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point( 9, 92 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 30, 13 );
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "&Title:";
            // 
            // edtTitle
            // 
            this.edtTitle.Location = new System.Drawing.Point( 12, 108 );
            this.edtTitle.Name = "edtTitle";
            this.edtTitle.Size = new System.Drawing.Size( 225, 20 );
            this.edtTitle.TabIndex = 3;
            this.edtTitle.Text = "Art on RedBubble";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point( 9, 131 );
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size( 30, 13 );
            this.lblLink.TabIndex = 4;
            this.lblLink.Text = "&Link:";
            // 
            // edtLink
            // 
            this.edtLink.Location = new System.Drawing.Point( 12, 147 );
            this.edtLink.Name = "edtLink";
            this.edtLink.Size = new System.Drawing.Size( 225, 20 );
            this.edtLink.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point( 9, 170 );
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size( 41, 13 );
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "&Author:";
            // 
            // edtAuthor
            // 
            this.edtAuthor.Location = new System.Drawing.Point( 12, 186 );
            this.edtAuthor.Name = "edtAuthor";
            this.edtAuthor.Size = new System.Drawing.Size( 225, 20 );
            this.edtAuthor.TabIndex = 7;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point( 9, 209 );
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size( 54, 13 );
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "&Copyright:";
            // 
            // edtCopyright
            // 
            this.edtCopyright.Location = new System.Drawing.Point( 12, 225 );
            this.edtCopyright.Name = "edtCopyright";
            this.edtCopyright.Size = new System.Drawing.Size( 225, 20 );
            this.edtCopyright.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 162, 251 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExport.Location = new System.Drawing.Point( 81, 251 );
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size( 75, 23 );
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // frmExportMediaRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 251, 281 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnExport );
            this.Controls.Add( this.edtCopyright );
            this.Controls.Add( this.lblCopyright );
            this.Controls.Add( this.edtAuthor );
            this.Controls.Add( this.lblAuthor );
            this.Controls.Add( this.edtLink );
            this.Controls.Add( this.lblLink );
            this.Controls.Add( this.edtTitle );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.gbLinkTo );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportMediaRSS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Media RSS File";
            this.gbLinkTo.ResumeLayout( false );
            this.gbLinkTo.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLinkTo;
        private System.Windows.Forms.RadioButton rbLinkToBuy;
        private System.Windows.Forms.RadioButton rbLinkToView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox edtTitle;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox edtLink;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox edtAuthor;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox edtCopyright;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
    }
}