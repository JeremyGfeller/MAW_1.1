﻿using System;
using System.Diagnostics;

namespace maw1._1
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSort = new System.Windows.Forms.TextBox();
            this.LabelSort = new System.Windows.Forms.Label();
            this.txtSort2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(695, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(31, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(69, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(608, 20);
            this.txtPath.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(709, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 147);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(768, 382);
            this.treeView1.TabIndex = 5;
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(69, 38);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(100, 20);
            this.txtSort.TabIndex = 7;
            // 
            // LabelSort
            // 
            this.LabelSort.AutoSize = true;
            this.LabelSort.Location = new System.Drawing.Point(14, 45);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(45, 13);
            this.LabelSort.TabIndex = 8;
            this.LabelSort.Text = "FirstSort";
            // 
            // txtSort2
            // 
            this.txtSort2.Location = new System.Drawing.Point(69, 68);
            this.txtSort2.Name = "txtSort2";
            this.txtSort2.Size = new System.Drawing.Size(100, 20);
            this.txtSort2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 538);
            this.Controls.Add(this.txtSort2);
            this.Controls.Add(this.LabelSort);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label LabelSort;
        private System.Windows.Forms.TextBox txtSort2;
    }
}

