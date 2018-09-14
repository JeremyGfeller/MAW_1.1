namespace PaleoDrivers
{
    partial class FFleet
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
            this.dgvFleet = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFleet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFleet
            // 
            this.dgvFleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFleet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLicense,
            this.colBrand,
            this.colSeats,
            this.colOK,
            this.colType,
            this.colRenter,
            this.colKM,
            this.colGas});
            this.dgvFleet.Location = new System.Drawing.Point(12, 12);
            this.dgvFleet.Name = "dgvFleet";
            this.dgvFleet.Size = new System.Drawing.Size(716, 335);
            this.dgvFleet.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nom";
            this.colName.Name = "colName";
            // 
            // colLicense
            // 
            this.colLicense.HeaderText = "Plaque";
            this.colLicense.Name = "colLicense";
            // 
            // colBrand
            // 
            this.colBrand.HeaderText = "Modèle";
            this.colBrand.Name = "colBrand";
            // 
            // colSeats
            // 
            this.colSeats.HeaderText = "#Pl.";
            this.colSeats.Name = "colSeats";
            this.colSeats.Width = 40;
            // 
            // colOK
            // 
            this.colOK.HeaderText = "OK";
            this.colOK.Name = "colOK";
            this.colOK.Width = 30;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 40;
            // 
            // colRenter
            // 
            this.colRenter.HeaderText = "Loué chez";
            this.colRenter.Name = "colRenter";
            // 
            // colKM
            // 
            this.colKM.HeaderText = "Km";
            this.colKM.Name = "colKM";
            // 
            // colGas
            // 
            this.colGas.HeaderText = "Vide";
            this.colGas.Name = "colGas";
            this.colGas.Width = 40;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(12, 353);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Sauver";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // FFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 388);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dgvFleet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FFleet";
            this.Text = "Véhicules";
            this.Load += new System.EventHandler(this.FFleet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFleet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFleet;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeats;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGas;

    }
}