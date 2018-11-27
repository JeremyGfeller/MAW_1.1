﻿namespace Finder
{
    partial class Finder
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
            this.btn_path = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_keyWord = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_files = new System.Windows.Forms.Label();
            this.txt_keyWord = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.lst_files = new System.Windows.Forms.ListView();
            this.NomFichier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Auteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_path
            // 
            this.btn_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_path.Location = new System.Drawing.Point(202, 79);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(106, 27);
            this.btn_path.TabIndex = 11;
            this.btn_path.Text = "Sélectionner";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(87, 119);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(339, 22);
            this.txt_path.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sélectionner un dossier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paramètres de recherche";
            // 
            // lbl_keyWord
            // 
            this.lbl_keyWord.AutoSize = true;
            this.lbl_keyWord.Location = new System.Drawing.Point(720, 79);
            this.lbl_keyWord.Name = "lbl_keyWord";
            this.lbl_keyWord.Size = new System.Drawing.Size(52, 13);
            this.lbl_keyWord.TabIndex = 15;
            this.lbl_keyWord.Text = "Mots-clés";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(720, 119);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(38, 13);
            this.lbl_author.TabIndex = 16;
            this.lbl_author.Text = "Auteur";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(720, 158);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(109, 13);
            this.lbl_date.TabIndex = 17;
            this.lbl_date.Text = "Date de modifications";
            // 
            // lbl_files
            // 
            this.lbl_files.AutoSize = true;
            this.lbl_files.Location = new System.Drawing.Point(720, 200);
            this.lbl_files.Name = "lbl_files";
            this.lbl_files.Size = new System.Drawing.Size(75, 13);
            this.lbl_files.TabIndex = 18;
            this.lbl_files.Text = "Nom du fichier";
            // 
            // txt_keyWord
            // 
            this.txt_keyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_keyWord.Location = new System.Drawing.Point(914, 74);
            this.txt_keyWord.Name = "txt_keyWord";
            this.txt_keyWord.Size = new System.Drawing.Size(167, 22);
            this.txt_keyWord.TabIndex = 19;
            // 
            // txt_author
            // 
            this.txt_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(914, 114);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(167, 22);
            this.txt_author.TabIndex = 20;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(914, 158);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(167, 22);
            this.txt_date.TabIndex = 21;
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(914, 200);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(167, 22);
            this.txt_file.TabIndex = 22;
            // 
            // lst_files
            // 
            this.lst_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomFichier,
            this.Taille,
            this.Auteur,
            this.Date});
            this.lst_files.Location = new System.Drawing.Point(87, 335);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(994, 266);
            this.lst_files.TabIndex = 23;
            this.lst_files.UseCompatibleStateImageBehavior = false;
            this.lst_files.View = System.Windows.Forms.View.Details;
            // 
            // NomFichier
            // 
            this.NomFichier.Text = "Nom";
            this.NomFichier.Width = 300;
            // 
            // Taille
            // 
            this.Taille.Text = "Taille";
            this.Taille.Width = 110;
            // 
            // Auteur
            // 
            this.Auteur.Text = "Auteur";
            this.Auteur.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 115;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_search.Location = new System.Drawing.Point(555, 258);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 23);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Rechercher";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Finder
            // 
            this.AccessibleName = "Finder";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 636);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lst_files);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_keyWord);
            this.Controls.Add(this.lbl_files);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_keyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_path);
            this.Name = "Finder";
            this.Text = "Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_keyWord;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_files;
        public System.Windows.Forms.ListView lst_files;
        private System.Windows.Forms.ColumnHeader NomFichier;
        private System.Windows.Forms.ColumnHeader Taille;
        private System.Windows.Forms.ColumnHeader Auteur;
        private System.Windows.Forms.ColumnHeader Date;
        public System.Windows.Forms.TextBox txt_path;
        public System.Windows.Forms.TextBox txt_keyWord;
        public System.Windows.Forms.TextBox txt_author;
        public System.Windows.Forms.TextBox txt_date;
        public System.Windows.Forms.TextBox txt_file;
        public System.Windows.Forms.Button btn_search;
    }
}

