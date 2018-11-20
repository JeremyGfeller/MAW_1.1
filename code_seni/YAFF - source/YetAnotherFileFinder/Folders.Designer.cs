namespace YetAnotherFileFinder
{
    partial class frmFolder
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
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvFolder
            // 
            this.tvFolder.Location = new System.Drawing.Point(3, 1);
            this.tvFolder.Name = "tvFolder";
            this.tvFolder.Size = new System.Drawing.Size(279, 413);
            this.tvFolder.TabIndex = 23;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(107, 420);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 24;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // frmFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.tvFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFolder";
            this.Text = "Folders";
            this.Load += new System.EventHandler(this.Folder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.Button btnSelectFolder;
    }
}