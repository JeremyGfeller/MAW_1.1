namespace Krohonde
{
    partial class FormMenu
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
            this.cmdSoldat = new System.Windows.Forms.Button();
            this.cmdOuvrière = new System.Windows.Forms.Button();
            this.cmdScout = new System.Windows.Forms.Button();
            this.cmdFermière = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdMoveN = new System.Windows.Forms.Button();
            this.cmdMoveNW = new System.Windows.Forms.Button();
            this.cmdMoveSW = new System.Windows.Forms.Button();
            this.mdMoveS = new System.Windows.Forms.Button();
            this.cmdMoveW = new System.Windows.Forms.Button();
            this.cmdMoveE = new System.Windows.Forms.Button();
            this.cmdMoveSE = new System.Windows.Forms.Button();
            this.cmdMoveNE = new System.Windows.Forms.Button();
            this.CmdPheroE = new System.Windows.Forms.Button();
            this.CmdPheroSE = new System.Windows.Forms.Button();
            this.CmdPheroNE = new System.Windows.Forms.Button();
            this.CmdPheroW = new System.Windows.Forms.Button();
            this.CmdPheroSW = new System.Windows.Forms.Button();
            this.CmdPheroS = new System.Windows.Forms.Button();
            this.CmdPheroNW = new System.Windows.Forms.Button();
            this.CmdPheroN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSoldat
            // 
            this.cmdSoldat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSoldat.Location = new System.Drawing.Point(140, 214);
            this.cmdSoldat.Name = "cmdSoldat";
            this.cmdSoldat.Size = new System.Drawing.Size(156, 30);
            this.cmdSoldat.TabIndex = 27;
            this.cmdSoldat.Text = "Soldat";
            this.cmdSoldat.UseVisualStyleBackColor = true;
            this.cmdSoldat.Click += new System.EventHandler(this.cmdSoldat_Click);
            // 
            // cmdOuvrière
            // 
            this.cmdOuvrière.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOuvrière.Location = new System.Drawing.Point(140, 165);
            this.cmdOuvrière.Name = "cmdOuvrière";
            this.cmdOuvrière.Size = new System.Drawing.Size(156, 30);
            this.cmdOuvrière.TabIndex = 26;
            this.cmdOuvrière.Text = "Ouvrière";
            this.cmdOuvrière.UseVisualStyleBackColor = true;
            this.cmdOuvrière.Click += new System.EventHandler(this.cmdOuvrière_Click);
            // 
            // cmdScout
            // 
            this.cmdScout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScout.Location = new System.Drawing.Point(140, 115);
            this.cmdScout.Name = "cmdScout";
            this.cmdScout.Size = new System.Drawing.Size(156, 30);
            this.cmdScout.TabIndex = 25;
            this.cmdScout.Text = "Scout";
            this.cmdScout.UseVisualStyleBackColor = true;
            this.cmdScout.Click += new System.EventHandler(this.cmdScout_Click);
            // 
            // cmdFermière
            // 
            this.cmdFermière.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermière.Location = new System.Drawing.Point(140, 64);
            this.cmdFermière.Name = "cmdFermière";
            this.cmdFermière.Size = new System.Drawing.Size(156, 30);
            this.cmdFermière.TabIndex = 24;
            this.cmdFermière.Text = "Fermière";
            this.cmdFermière.UseVisualStyleBackColor = true;
            this.cmdFermière.Click += new System.EventHandler(this.cmdFermière_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Déplacer la reine :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Construire une case d\'extension :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Plus d\'énergie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pondre une larve :";
            // 
            // cmdMoveN
            // 
            this.cmdMoveN.Location = new System.Drawing.Point(201, 465);
            this.cmdMoveN.Name = "cmdMoveN";
            this.cmdMoveN.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveN.TabIndex = 29;
            this.cmdMoveN.Text = "N";
            this.cmdMoveN.UseVisualStyleBackColor = true;
            this.cmdMoveN.Click += new System.EventHandler(this.cmdMoveN_Click);
            // 
            // cmdMoveNW
            // 
            this.cmdMoveNW.Location = new System.Drawing.Point(160, 465);
            this.cmdMoveNW.Name = "cmdMoveNW";
            this.cmdMoveNW.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveNW.TabIndex = 30;
            this.cmdMoveNW.Text = "NW";
            this.cmdMoveNW.UseVisualStyleBackColor = true;
            this.cmdMoveNW.Click += new System.EventHandler(this.cmdMoveNW_Click);
            // 
            // cmdMoveSW
            // 
            this.cmdMoveSW.Location = new System.Drawing.Point(160, 544);
            this.cmdMoveSW.Name = "cmdMoveSW";
            this.cmdMoveSW.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveSW.TabIndex = 32;
            this.cmdMoveSW.Text = "SW";
            this.cmdMoveSW.UseVisualStyleBackColor = true;
            this.cmdMoveSW.Click += new System.EventHandler(this.cmdMoveSW_Click);
            // 
            // mdMoveS
            // 
            this.mdMoveS.Location = new System.Drawing.Point(201, 544);
            this.mdMoveS.Name = "mdMoveS";
            this.mdMoveS.Size = new System.Drawing.Size(35, 35);
            this.mdMoveS.TabIndex = 31;
            this.mdMoveS.Text = "S";
            this.mdMoveS.UseVisualStyleBackColor = true;
            this.mdMoveS.Click += new System.EventHandler(this.mdMoveS_Click);
            // 
            // cmdMoveW
            // 
            this.cmdMoveW.Location = new System.Drawing.Point(160, 504);
            this.cmdMoveW.Name = "cmdMoveW";
            this.cmdMoveW.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveW.TabIndex = 33;
            this.cmdMoveW.Text = "W";
            this.cmdMoveW.UseVisualStyleBackColor = true;
            this.cmdMoveW.Click += new System.EventHandler(this.cmdMoveW_Click);
            // 
            // cmdMoveE
            // 
            this.cmdMoveE.Location = new System.Drawing.Point(242, 504);
            this.cmdMoveE.Name = "cmdMoveE";
            this.cmdMoveE.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveE.TabIndex = 36;
            this.cmdMoveE.Text = "E";
            this.cmdMoveE.UseVisualStyleBackColor = true;
            this.cmdMoveE.Click += new System.EventHandler(this.cmdMoveE_Click);
            // 
            // cmdMoveSE
            // 
            this.cmdMoveSE.Location = new System.Drawing.Point(242, 544);
            this.cmdMoveSE.Name = "cmdMoveSE";
            this.cmdMoveSE.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveSE.TabIndex = 35;
            this.cmdMoveSE.Text = "SE";
            this.cmdMoveSE.UseVisualStyleBackColor = true;
            this.cmdMoveSE.Click += new System.EventHandler(this.cmdMoveSE_Click);
            // 
            // cmdMoveNE
            // 
            this.cmdMoveNE.Location = new System.Drawing.Point(242, 465);
            this.cmdMoveNE.Name = "cmdMoveNE";
            this.cmdMoveNE.Size = new System.Drawing.Size(35, 35);
            this.cmdMoveNE.TabIndex = 34;
            this.cmdMoveNE.Text = "NE";
            this.cmdMoveNE.UseVisualStyleBackColor = true;
            this.cmdMoveNE.Click += new System.EventHandler(this.cmdMoveNE_Click);
            // 
            // CmdPheroE
            // 
            this.CmdPheroE.Location = new System.Drawing.Point(242, 347);
            this.CmdPheroE.Name = "CmdPheroE";
            this.CmdPheroE.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroE.TabIndex = 44;
            this.CmdPheroE.Text = "E";
            this.CmdPheroE.UseVisualStyleBackColor = true;
            this.CmdPheroE.Click += new System.EventHandler(this.CmdPheroE_Click);
            // 
            // CmdPheroSE
            // 
            this.CmdPheroSE.Location = new System.Drawing.Point(242, 387);
            this.CmdPheroSE.Name = "CmdPheroSE";
            this.CmdPheroSE.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroSE.TabIndex = 43;
            this.CmdPheroSE.Text = "SE";
            this.CmdPheroSE.UseVisualStyleBackColor = true;
            this.CmdPheroSE.Click += new System.EventHandler(this.CmdPheroSE_Click);
            // 
            // CmdPheroNE
            // 
            this.CmdPheroNE.Location = new System.Drawing.Point(242, 308);
            this.CmdPheroNE.Name = "CmdPheroNE";
            this.CmdPheroNE.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroNE.TabIndex = 42;
            this.CmdPheroNE.Text = "NE";
            this.CmdPheroNE.UseVisualStyleBackColor = true;
            this.CmdPheroNE.Click += new System.EventHandler(this.CmdPheroNE_Click);
            // 
            // CmdPheroW
            // 
            this.CmdPheroW.Location = new System.Drawing.Point(160, 347);
            this.CmdPheroW.Name = "CmdPheroW";
            this.CmdPheroW.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroW.TabIndex = 41;
            this.CmdPheroW.Text = "W";
            this.CmdPheroW.UseVisualStyleBackColor = true;
            this.CmdPheroW.Click += new System.EventHandler(this.CmdPheroW_Click);
            // 
            // CmdPheroSW
            // 
            this.CmdPheroSW.Location = new System.Drawing.Point(160, 387);
            this.CmdPheroSW.Name = "CmdPheroSW";
            this.CmdPheroSW.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroSW.TabIndex = 40;
            this.CmdPheroSW.Text = "SW";
            this.CmdPheroSW.UseVisualStyleBackColor = true;
            this.CmdPheroSW.Click += new System.EventHandler(this.CmdPheroSW_Click);
            // 
            // CmdPheroS
            // 
            this.CmdPheroS.Location = new System.Drawing.Point(201, 387);
            this.CmdPheroS.Name = "CmdPheroS";
            this.CmdPheroS.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroS.TabIndex = 39;
            this.CmdPheroS.Text = "S";
            this.CmdPheroS.UseVisualStyleBackColor = true;
            this.CmdPheroS.Click += new System.EventHandler(this.CmdPheroS_Click);
            // 
            // CmdPheroNW
            // 
            this.CmdPheroNW.Location = new System.Drawing.Point(160, 308);
            this.CmdPheroNW.Name = "CmdPheroNW";
            this.CmdPheroNW.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroNW.TabIndex = 38;
            this.CmdPheroNW.Text = "NW";
            this.CmdPheroNW.UseVisualStyleBackColor = true;
            this.CmdPheroNW.Click += new System.EventHandler(this.CmdPheroNW_Click);
            // 
            // CmdPheroN
            // 
            this.CmdPheroN.Location = new System.Drawing.Point(201, 308);
            this.CmdPheroN.Name = "CmdPheroN";
            this.CmdPheroN.Size = new System.Drawing.Size(35, 35);
            this.CmdPheroN.TabIndex = 37;
            this.CmdPheroN.Text = "N";
            this.CmdPheroN.UseVisualStyleBackColor = true;
            this.CmdPheroN.Click += new System.EventHandler(this.CmdPheroN_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(376, 587);
            this.ControlBox = false;
            this.Controls.Add(this.CmdPheroE);
            this.Controls.Add(this.CmdPheroSE);
            this.Controls.Add(this.CmdPheroNE);
            this.Controls.Add(this.CmdPheroW);
            this.Controls.Add(this.CmdPheroSW);
            this.Controls.Add(this.CmdPheroS);
            this.Controls.Add(this.CmdPheroNW);
            this.Controls.Add(this.CmdPheroN);
            this.Controls.Add(this.cmdMoveE);
            this.Controls.Add(this.cmdMoveSE);
            this.Controls.Add(this.cmdMoveNE);
            this.Controls.Add(this.cmdMoveW);
            this.Controls.Add(this.cmdMoveSW);
            this.Controls.Add(this.mdMoveS);
            this.Controls.Add(this.cmdMoveNW);
            this.Controls.Add(this.cmdMoveN);
            this.Controls.Add(this.cmdSoldat);
            this.Controls.Add(this.cmdOuvrière);
            this.Controls.Add(this.cmdScout);
            this.Controls.Add(this.cmdFermière);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(980, 50);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSoldat;
        private System.Windows.Forms.Button cmdOuvrière;
        private System.Windows.Forms.Button cmdScout;
        private System.Windows.Forms.Button cmdFermière;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdMoveN;
        private System.Windows.Forms.Button cmdMoveNW;
        private System.Windows.Forms.Button cmdMoveSW;
        private System.Windows.Forms.Button mdMoveS;
        private System.Windows.Forms.Button cmdMoveW;
        private System.Windows.Forms.Button cmdMoveE;
        private System.Windows.Forms.Button cmdMoveSE;
        private System.Windows.Forms.Button cmdMoveNE;
        private System.Windows.Forms.Button CmdPheroE;
        private System.Windows.Forms.Button CmdPheroSE;
        private System.Windows.Forms.Button CmdPheroNE;
        private System.Windows.Forms.Button CmdPheroW;
        private System.Windows.Forms.Button CmdPheroSW;
        private System.Windows.Forms.Button CmdPheroS;
        private System.Windows.Forms.Button CmdPheroNW;
        private System.Windows.Forms.Button CmdPheroN;
    }
}