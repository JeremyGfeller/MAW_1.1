namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnRuns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrivers
            // 
            this.btnDrivers.Location = new System.Drawing.Point(12, 12);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(106, 50);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "Chauffeurs";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(125, 13);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(116, 49);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "Voitures";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(125, 69);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(116, 49);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistiques";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnRuns
            // 
            this.btnRuns.Location = new System.Drawing.Point(12, 68);
            this.btnRuns.Name = "btnRuns";
            this.btnRuns.Size = new System.Drawing.Size(106, 50);
            this.btnRuns.TabIndex = 2;
            this.btnRuns.Text = "Courses";
            this.btnRuns.UseVisualStyleBackColor = true;
            this.btnRuns.Click += new System.EventHandler(this.btnRuns_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 128);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRuns);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnDrivers);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnRuns;
    }
}