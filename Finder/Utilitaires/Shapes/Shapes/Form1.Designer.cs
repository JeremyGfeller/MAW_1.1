namespace Shapes
{
    partial class frmShapes
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
            this.cmdDessiner = new System.Windows.Forms.Button();
            this.picCanevas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanevas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDessiner
            // 
            this.cmdDessiner.Location = new System.Drawing.Point(12, 12);
            this.cmdDessiner.Name = "cmdDessiner";
            this.cmdDessiner.Size = new System.Drawing.Size(86, 23);
            this.cmdDessiner.TabIndex = 7;
            this.cmdDessiner.Text = "Dessiner";
            this.cmdDessiner.UseVisualStyleBackColor = true;
            this.cmdDessiner.Click += new System.EventHandler(this.cmdDessiner_Click);
            // 
            // picCanevas
            // 
            this.picCanevas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanevas.Location = new System.Drawing.Point(114, 12);
            this.picCanevas.Name = "picCanevas";
            this.picCanevas.Size = new System.Drawing.Size(800, 600);
            this.picCanevas.TabIndex = 2;
            this.picCanevas.TabStop = false;
            // 
            // frmShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 617);
            this.Controls.Add(this.picCanevas);
            this.Controls.Add(this.cmdDessiner);
            this.Name = "frmShapes";
            this.Text = "Shapes";
            ((System.ComponentModel.ISupportInitialize)(this.picCanevas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDessiner;
        private System.Windows.Forms.PictureBox picCanevas;
    }
}

