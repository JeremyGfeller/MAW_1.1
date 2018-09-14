namespace PaleoDrivers
{
    partial class FStaff
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
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.colFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReady = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFName,
            this.colLName,
            this.colAddr,
            this.colLicense,
            this.colReady});
            this.dgvDriver.Location = new System.Drawing.Point(0, -1);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(502, 522);
            this.dgvDriver.TabIndex = 0;
            // 
            // colFName
            // 
            this.colFName.HeaderText = "Prénom";
            this.colFName.Name = "colFName";
            // 
            // colLName
            // 
            this.colLName.HeaderText = "Nom";
            this.colLName.Name = "colLName";
            // 
            // colAddr
            // 
            this.colAddr.HeaderText = "Adresse";
            this.colAddr.Name = "colAddr";
            // 
            // colLicense
            // 
            this.colLicense.HeaderText = "No de Permis";
            this.colLicense.Name = "colLicense";
            // 
            // colReady
            // 
            this.colReady.HeaderText = "Prêt";
            this.colReady.Name = "colReady";
            this.colReady.Width = 40;
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 520);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDriver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FStaff";
            this.Text = "FStaff";
            this.Load += new System.EventHandler(this.FStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicense;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReady;
    }
}