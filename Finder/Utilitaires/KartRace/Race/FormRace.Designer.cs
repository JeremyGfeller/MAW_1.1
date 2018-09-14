namespace Race
{
    partial class FormRace
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
            this.lstRace = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNewRace = new System.Windows.Forms.Button();
            this.lblKartsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRace
            // 
            this.lstRace.Location = new System.Drawing.Point(12, 23);
            this.lstRace.Name = "lstRace";
            this.lstRace.Size = new System.Drawing.Size(260, 197);
            this.lstRace.TabIndex = 0;
            this.lstRace.UseCompatibleStateImageBehavior = false;
            this.lstRace.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course";
            // 
            // cmdNewRace
            // 
            this.cmdNewRace.Location = new System.Drawing.Point(15, 226);
            this.cmdNewRace.Name = "cmdNewRace";
            this.cmdNewRace.Size = new System.Drawing.Size(118, 23);
            this.cmdNewRace.TabIndex = 2;
            this.cmdNewRace.Text = "Nouvelle Course";
            this.cmdNewRace.UseVisualStyleBackColor = true;
            this.cmdNewRace.Click += new System.EventHandler(this.cmdNewRace_Click);
            // 
            // lblKartsLeft
            // 
            this.lblKartsLeft.AutoSize = true;
            this.lblKartsLeft.Location = new System.Drawing.Point(9, 256);
            this.lblKartsLeft.Name = "lblKartsLeft";
            this.lblKartsLeft.Size = new System.Drawing.Size(34, 13);
            this.lblKartsLeft.TabIndex = 3;
            this.lblKartsLeft.Text = "Karts:";
            // 
            // FormRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.lblKartsLeft);
            this.Controls.Add(this.cmdNewRace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRace);
            this.Name = "FormRace";
            this.Text = "Courses de Karts";
            this.Load += new System.EventHandler(this.FormRace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNewRace;
        private System.Windows.Forms.Label lblKartsLeft;
    }
}

