namespace RBArtMan
{
    partial class frmPromoteProfile
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.edtPromoteCode = new System.Windows.Forms.TextBox();
            this.gbImageStyle = new System.Windows.Forms.GroupBox();
            this.rbVertical = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.gbCodeStyle.SuspendLayout();
            this.gbImageStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodeStyle
            // 
            this.gbCodeStyle.Controls.Add( this.rbHTML );
            this.gbCodeStyle.Controls.Add( this.rbBBCode );
            this.gbCodeStyle.Controls.Add( this.rbTextile );
            this.gbCodeStyle.Location = new System.Drawing.Point( 6, 12 );
            this.gbCodeStyle.Name = "gbCodeStyle";
            this.gbCodeStyle.Size = new System.Drawing.Size( 150, 91 );
            this.gbCodeStyle.TabIndex = 0;
            this.gbCodeStyle.TabStop = false;
            this.gbCodeStyle.Text = "C&ode Style";
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point( 10, 65 );
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size( 55, 17 );
            this.rbHTML.TabIndex = 2;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            this.rbHTML.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbBBCode
            // 
            this.rbBBCode.AutoSize = true;
            this.rbBBCode.Location = new System.Drawing.Point( 10, 42 );
            this.rbBBCode.Name = "rbBBCode";
            this.rbBBCode.Size = new System.Drawing.Size( 64, 17 );
            this.rbBBCode.TabIndex = 1;
            this.rbBBCode.Text = "BBCode";
            this.rbBBCode.UseVisualStyleBackColor = true;
            this.rbBBCode.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
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
            this.rbTextile.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point( 227, 200 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 61, 23 );
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point( 6, 200 );
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size( 109, 23 );
            this.btnClipboard.TabIndex = 3;
            this.btnClipboard.Text = "&Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler( this.btnClipboard_Click );
            // 
            // edtPromoteCode
            // 
            this.edtPromoteCode.Location = new System.Drawing.Point( 6, 109 );
            this.edtPromoteCode.Multiline = true;
            this.edtPromoteCode.Name = "edtPromoteCode";
            this.edtPromoteCode.ReadOnly = true;
            this.edtPromoteCode.Size = new System.Drawing.Size( 282, 85 );
            this.edtPromoteCode.TabIndex = 2;
            // 
            // gbImageStyle
            // 
            this.gbImageStyle.Controls.Add( this.rbVertical );
            this.gbImageStyle.Controls.Add( this.rbHorizontal );
            this.gbImageStyle.Location = new System.Drawing.Point( 162, 12 );
            this.gbImageStyle.Name = "gbImageStyle";
            this.gbImageStyle.Size = new System.Drawing.Size( 126, 91 );
            this.gbImageStyle.TabIndex = 1;
            this.gbImageStyle.TabStop = false;
            this.gbImageStyle.Text = "&Image Style";
            // 
            // rbVertical
            // 
            this.rbVertical.AutoSize = true;
            this.rbVertical.Location = new System.Drawing.Point( 13, 49 );
            this.rbVertical.Name = "rbVertical";
            this.rbVertical.Size = new System.Drawing.Size( 60, 17 );
            this.rbVertical.TabIndex = 1;
            this.rbVertical.TabStop = true;
            this.rbVertical.Text = "Vertical";
            this.rbVertical.UseVisualStyleBackColor = true;
            this.rbVertical.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Checked = true;
            this.rbHorizontal.Location = new System.Drawing.Point( 13, 26 );
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size( 72, 17 );
            this.rbHorizontal.TabIndex = 0;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "&Horizontal";
            this.rbHorizontal.UseVisualStyleBackColor = true;
            this.rbHorizontal.CheckedChanged += new System.EventHandler( this.codeStyleChanged );
            // 
            // frmPromoteProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size( 296, 229 );
            this.Controls.Add( this.gbImageStyle );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.btnClipboard );
            this.Controls.Add( this.edtPromoteCode );
            this.Controls.Add( this.gbCodeStyle );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPromoteProfile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promote Profile";
            this.Shown += new System.EventHandler( this.frmPromoteProfile_Shown );
            this.gbCodeStyle.ResumeLayout( false );
            this.gbCodeStyle.PerformLayout();
            this.gbImageStyle.ResumeLayout( false );
            this.gbImageStyle.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCodeStyle;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.RadioButton rbBBCode;
        private System.Windows.Forms.RadioButton rbTextile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.TextBox edtPromoteCode;
        private System.Windows.Forms.GroupBox gbImageStyle;
        private System.Windows.Forms.RadioButton rbVertical;
        private System.Windows.Forms.RadioButton rbHorizontal;
    }
}