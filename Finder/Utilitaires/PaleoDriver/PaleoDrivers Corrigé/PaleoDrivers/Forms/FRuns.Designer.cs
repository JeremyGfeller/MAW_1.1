namespace PaleoDrivers
{
    partial class FRuns
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
            this.dgvRuns = new System.Windows.Forms.DataGridView();
            this.colIdRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogistics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRuns
            // 
            this.dgvRuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRun,
            this.colArtist,
            this.colPax,
            this.colTime,
            this.colPath,
            this.colLogistics,
            this.colInfo});
            this.dgvRuns.Location = new System.Drawing.Point(-1, 0);
            this.dgvRuns.Name = "dgvRuns";
            this.dgvRuns.Size = new System.Drawing.Size(864, 474);
            this.dgvRuns.TabIndex = 3;
            this.dgvRuns.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRuns_RowHeaderMouseClick);
            // 
            // colIdRun
            // 
            this.colIdRun.HeaderText = "#";
            this.colIdRun.Name = "colIdRun";
            this.colIdRun.ReadOnly = true;
            this.colIdRun.Width = 20;
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artiste";
            this.colArtist.Name = "colArtist";
            // 
            // colPax
            // 
            this.colPax.HeaderText = "#Pax";
            this.colPax.Name = "colPax";
            this.colPax.Width = 40;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Heure";
            this.colTime.Name = "colTime";
            // 
            // colPath
            // 
            this.colPath.HeaderText = "Parcours";
            this.colPath.Name = "colPath";
            // 
            // colLogistics
            // 
            this.colLogistics.HeaderText = "Logistique";
            this.colLogistics.Name = "colLogistics";
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Infos";
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 140;
            // 
            // FRuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 645);
            this.ControlBox = false;
            this.Controls.Add(this.dgvRuns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRuns";
            this.Text = "FRuns";
            this.Load += new System.EventHandler(this.FRuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRuns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
    }
}