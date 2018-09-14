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
            this.dgvRun = new System.Windows.Forms.DataGridView();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRun
            // 
            this.dgvRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Driver,
            this.Vehicle,
            this.DateHour,
            this.StartRun,
            this.EndRun,
            this.Artist,
            this.Passengers,
            this.Info});
            this.dgvRun.Location = new System.Drawing.Point(12, 12);
            this.dgvRun.Name = "dgvRun";
            this.dgvRun.Size = new System.Drawing.Size(852, 377);
            this.dgvRun.TabIndex = 0;
            // 
            // Driver
            // 
            this.Driver.HeaderText = "Driver";
            this.Driver.Name = "Driver";
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle";
            this.Vehicle.Name = "Vehicle";
            // 
            // DateHour
            // 
            this.DateHour.HeaderText = "DateHour";
            this.DateHour.Name = "DateHour";
            // 
            // StartRun
            // 
            this.StartRun.HeaderText = "StartRun";
            this.StartRun.Name = "StartRun";
            // 
            // EndRun
            // 
            this.EndRun.HeaderText = "EndRun";
            this.EndRun.Name = "EndRun";
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // Passengers
            // 
            this.Passengers.HeaderText = "Passengers";
            this.Passengers.Name = "Passengers";
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 446);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRun);
            this.Name = "FRuns";
            this.Text = "FRuns";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRuns_FormClosed);
            this.Load += new System.EventHandler(this.FRuns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Button button1;
    }
}