namespace PaleoDrivers
{
    partial class FMenu
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
            this.cmdFleet = new System.Windows.Forms.Button();
            this.cmdRuns = new System.Windows.Forms.Button();
            this.cmdStaff = new System.Windows.Forms.Button();
            this.cmdStats = new System.Windows.Forms.Button();
            this.cmdSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFleet
            // 
            this.cmdFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFleet.Location = new System.Drawing.Point(12, 12);
            this.cmdFleet.Name = "cmdFleet";
            this.cmdFleet.Size = new System.Drawing.Size(260, 43);
            this.cmdFleet.TabIndex = 0;
            this.cmdFleet.Text = "Parc de véhicules";
            this.cmdFleet.UseVisualStyleBackColor = true;
            this.cmdFleet.Click += new System.EventHandler(this.cmdFleet_Click);
            // 
            // cmdRuns
            // 
            this.cmdRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRuns.Location = new System.Drawing.Point(12, 109);
            this.cmdRuns.Name = "cmdRuns";
            this.cmdRuns.Size = new System.Drawing.Size(260, 43);
            this.cmdRuns.TabIndex = 1;
            this.cmdRuns.Text = "Runs";
            this.cmdRuns.UseVisualStyleBackColor = true;
            this.cmdRuns.Click += new System.EventHandler(this.cmdRuns_Click);
            // 
            // cmdStaff
            // 
            this.cmdStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStaff.Location = new System.Drawing.Point(12, 60);
            this.cmdStaff.Name = "cmdStaff";
            this.cmdStaff.Size = new System.Drawing.Size(260, 43);
            this.cmdStaff.TabIndex = 2;
            this.cmdStaff.Text = "Staff";
            this.cmdStaff.UseVisualStyleBackColor = true;
            this.cmdStaff.Click += new System.EventHandler(this.cmdStaff_Click);
            // 
            // cmdStats
            // 
            this.cmdStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStats.Location = new System.Drawing.Point(12, 158);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(260, 43);
            this.cmdStats.TabIndex = 3;
            this.cmdStats.Text = "Statistiques";
            this.cmdStats.UseVisualStyleBackColor = true;
            this.cmdStats.Click += new System.EventHandler(this.cmdStats_Click);
            // 
            // cmdSchedule
            // 
            this.cmdSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSchedule.Location = new System.Drawing.Point(12, 207);
            this.cmdSchedule.Name = "cmdSchedule";
            this.cmdSchedule.Size = new System.Drawing.Size(260, 43);
            this.cmdSchedule.TabIndex = 4;
            this.cmdSchedule.Text = "Horaires";
            this.cmdSchedule.UseVisualStyleBackColor = true;
            this.cmdSchedule.Click += new System.EventHandler(this.cmdSchedule_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.cmdSchedule);
            this.Controls.Add(this.cmdStats);
            this.Controls.Add(this.cmdStaff);
            this.Controls.Add(this.cmdRuns);
            this.Controls.Add(this.cmdFleet);
            this.Name = "FMenu";
            this.Text = "PaleoDrivers";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFleet;
        private System.Windows.Forms.Button cmdRuns;
        private System.Windows.Forms.Button cmdStaff;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.Button cmdSchedule;
    }
}