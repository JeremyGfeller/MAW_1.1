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
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.License = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ready = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NeedGas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFleet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFleet
            // 
            this.dgvFleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFleet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.License,
            this.Model,
            this.NbSeats,
            this.Ready,
            this.NeedGas,
            this.Type,
            this.Renter,
            this.Km});
            this.dgvFleet.Location = new System.Drawing.Point(12, 28);
            this.dgvFleet.Name = "dgvFleet";
            this.dgvFleet.Size = new System.Drawing.Size(948, 481);
            this.dgvFleet.TabIndex = 3;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // License
            // 
            this.License.HeaderText = "License";
            this.License.Name = "License";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // NbSeats
            // 
            this.NbSeats.HeaderText = "NbSeats";
            this.NbSeats.Name = "NbSeats";
            // 
            // Ready
            // 
            this.Ready.HeaderText = "Ready";
            this.Ready.Name = "Ready";
            // 
            // NeedGas
            // 
            this.NeedGas.HeaderText = "NeedGas";
            this.NeedGas.Name = "NeedGas";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Renter
            // 
            this.Renter.HeaderText = "Renter";
            this.Renter.Name = "Renter";
            // 
            // Km
            // 
            this.Km.HeaderText = "Km";
            this.Km.Name = "Km";
            // 
            // FFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 522);
            this.ControlBox = false;
            this.Controls.Add(this.dgvFleet);
            this.Name = "FFleet";
            this.Text = "Véhicules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFleet_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFleet_FormClosed);
            this.Load += new System.EventHandler(this.FFleet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFleet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFleet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn License;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbSeats;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ready;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NeedGas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km;
    }
}