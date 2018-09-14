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
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.Permis,
            this.Pret});
            this.dgvDriver.Location = new System.Drawing.Point(12, 28);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(561, 482);
            this.dgvDriver.TabIndex = 4;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Permis
            // 
            this.Permis.HeaderText = "Permis";
            this.Permis.Name = "Permis";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 522);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDriver);
            this.Name = "FStaff";
            this.Text = "Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStaff_FormClosed);
            this.Load += new System.EventHandler(this.FStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pret;
    }
}