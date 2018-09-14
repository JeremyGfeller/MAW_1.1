namespace Krohonde
{
    partial class CJardin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFond = new System.Windows.Forms.Label();
            this.tmrPulse = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblRéserveNourriture = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRéserveMatériau = new System.Windows.Forms.Label();
            this.cmdPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFond
            // 
            this.lblFond.BackColor = System.Drawing.Color.Green;
            this.lblFond.Location = new System.Drawing.Point(0, 0);
            this.lblFond.Name = "lblFond";
            this.lblFond.Size = new System.Drawing.Size(960, 560);
            this.lblFond.TabIndex = 0;
            this.lblFond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Jardin_MouseClick);
            // 
            // tmrPulse
            // 
            this.tmrPulse.Tick += new System.EventHandler(this.tmrPulse_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nourriture:";
            // 
            // lblRéserveNourriture
            // 
            this.lblRéserveNourriture.AutoSize = true;
            this.lblRéserveNourriture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRéserveNourriture.Location = new System.Drawing.Point(392, 571);
            this.lblRéserveNourriture.Name = "lblRéserveNourriture";
            this.lblRéserveNourriture.Size = new System.Drawing.Size(22, 29);
            this.lblRéserveNourriture.TabIndex = 5;
            this.lblRéserveNourriture.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Matériau:";
            // 
            // lblRéserveMatériau
            // 
            this.lblRéserveMatériau.AutoSize = true;
            this.lblRéserveMatériau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRéserveMatériau.Location = new System.Drawing.Point(671, 571);
            this.lblRéserveMatériau.Name = "lblRéserveMatériau";
            this.lblRéserveMatériau.Size = new System.Drawing.Size(22, 29);
            this.lblRéserveMatériau.TabIndex = 10;
            this.lblRéserveMatériau.Text = "-";
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(885, 577);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 11;
            this.cmdPause.Text = "Démarrer";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // CJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 609);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.lblRéserveMatériau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRéserveNourriture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CJardin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krohonde";
            this.Load += new System.EventHandler(this.Jardin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFond;
        private System.Windows.Forms.Timer tmrPulse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRéserveNourriture;
        // RFU private System.Windows.Forms.Label label3;
        // RFU private System.Windows.Forms.Label lblRéserveMatériau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRéserveMatériau;
        private System.Windows.Forms.Button cmdPause;
    }
}

