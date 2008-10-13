namespace RBArtMan
{
    partial class frmExportHTML
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
            this.rbLinkToView = new System.Windows.Forms.RadioButton();
            this.rbLinkToBuy = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbLinkTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLinkTo
            // 
            this.gbLinkTo.Controls.Add( this.rbLinkToBuy );
            this.gbLinkTo.Controls.Add( this.rbLinkToView );
            this.gbLinkTo.Location = new System.Drawing.Point( 6, 12 );
            this.gbLinkTo.Name = "gbLinkTo";
            this.gbLinkTo.Size = new System.Drawing.Size( 225, 72 );
            this.gbLinkTo.TabIndex = 0;
            this.gbLinkTo.TabStop = false;
            this.gbLinkTo.Text = "Link To:";
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
            // btnExport
            // 
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExport.Location = new System.Drawing.Point( 75, 90 );
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size( 75, 23 );
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 156, 90 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmExportHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 238, 121 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnExport );
            this.Controls.Add( this.gbLinkTo );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportHTML";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export To HTML";
            this.gbLinkTo.ResumeLayout( false );
            this.gbLinkTo.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLinkTo;
        private System.Windows.Forms.RadioButton rbLinkToBuy;
        private System.Windows.Forms.RadioButton rbLinkToView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
    }
}