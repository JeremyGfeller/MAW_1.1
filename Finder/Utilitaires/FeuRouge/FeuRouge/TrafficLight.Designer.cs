namespace FeuRouge
{
    partial class TrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.pctTLight = new System.Windows.Forms.PictureBox();
            this.pctGreenOn = new System.Windows.Forms.PictureBox();
            this.pctRedOn = new System.Windows.Forms.PictureBox();
            this.pctYellowOn = new System.Windows.Forms.PictureBox();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.cmdNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctTLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGreenOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYellowOn)).BeginInit();
            this.SuspendLayout();
            // 
            // pctTLight
            // 
            this.pctTLight.Image = global::FeuRouge.Properties.Resources.trafficlight;
            this.pctTLight.Location = new System.Drawing.Point(96, 16);
            this.pctTLight.Name = "pctTLight";
            this.pctTLight.Size = new System.Drawing.Size(58, 155);
            this.pctTLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctTLight.TabIndex = 0;
            this.pctTLight.TabStop = false;
            // 
            // pctGreenOn
            // 
            this.pctGreenOn.Image = global::FeuRouge.Properties.Resources.greenon;
            this.pctGreenOn.Location = new System.Drawing.Point(104, 113);
            this.pctGreenOn.Name = "pctGreenOn";
            this.pctGreenOn.Size = new System.Drawing.Size(42, 42);
            this.pctGreenOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctGreenOn.TabIndex = 1;
            this.pctGreenOn.TabStop = false;
            this.pctGreenOn.Visible = false;
            // 
            // pctRedOn
            // 
            this.pctRedOn.Image = global::FeuRouge.Properties.Resources.redon;
            this.pctRedOn.Location = new System.Drawing.Point(105, 23);
            this.pctRedOn.Name = "pctRedOn";
            this.pctRedOn.Size = new System.Drawing.Size(42, 42);
            this.pctRedOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctRedOn.TabIndex = 2;
            this.pctRedOn.TabStop = false;
            this.pctRedOn.Visible = false;
            // 
            // pctYellowOn
            // 
            this.pctYellowOn.Image = global::FeuRouge.Properties.Resources.yellowon;
            this.pctYellowOn.Location = new System.Drawing.Point(104, 69);
            this.pctYellowOn.Name = "pctYellowOn";
            this.pctYellowOn.Size = new System.Drawing.Size(42, 42);
            this.pctYellowOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctYellowOn.TabIndex = 3;
            this.pctYellowOn.TabStop = false;
            this.pctYellowOn.Visible = false;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Enabled = true;
            this.tmrBlink.Interval = 500;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(171, 88);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 4;
            this.cmdNext.Text = "Suivant";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Heure d\'extension des feux";
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(153, 221);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(27, 20);
            this.txtFin.TabIndex = 6;
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(153, 252);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(27, 20);
            this.txtDebut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Heure pour ralumer les feux";
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(11, 88);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 9;
            this.cmdStop.Text = "Panne";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "h00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "h00";
            // 
            // TrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.pctYellowOn);
            this.Controls.Add(this.pctRedOn);
            this.Controls.Add(this.pctGreenOn);
            this.Controls.Add(this.pctTLight);
            this.Name = "TrafficLight";
            this.Text = "Feu";
            ((System.ComponentModel.ISupportInitialize)(this.pctTLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGreenOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYellowOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTLight;
        private System.Windows.Forms.PictureBox pctGreenOn;
        private System.Windows.Forms.PictureBox pctRedOn;
        private System.Windows.Forms.PictureBox pctYellowOn;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

