namespace Finder
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
            this.Directory = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.DateValue = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.ContentFile = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.FilesView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Directory.AccessibleName = "Directory";
            this.Directory.Location = new System.Drawing.Point(14, 18);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(75, 23);
            this.Directory.TabIndex = 0;
            this.Directory.Text = "Directory";
            this.Directory.UseVisualStyleBackColor = true;
            // 
            // Author
            // 
            this.Author.AccessibleName = "Author";
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(27, 49);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(38, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            // 
            // AuthorName
            // 
            this.AuthorName.AccessibleName = "AuthorName";
            this.AuthorName.Location = new System.Drawing.Point(118, 46);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(100, 20);
            this.AuthorName.TabIndex = 3;
            // 
            // DateValue
            // 
            this.DateValue.AccessibleName = "DateValue";
            this.DateValue.Location = new System.Drawing.Point(118, 72);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(100, 20);
            this.DateValue.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.AccessibleName = "Date";
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(27, 75);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.AccessibleName = "DirectoryPath";
            this.DirectoryPath.Location = new System.Drawing.Point(118, 20);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(100, 20);
            this.DirectoryPath.TabIndex = 6;
            // 
            // ContentFile
            // 
            this.ContentFile.AccessibleName = "ContentFile";
            this.ContentFile.Location = new System.Drawing.Point(118, 98);
            this.ContentFile.Multiline = true;
            this.ContentFile.Name = "ContentFile";
            this.ContentFile.Size = new System.Drawing.Size(335, 69);
            this.ContentFile.TabIndex = 8;
            // 
            // Content
            // 
            this.Content.AccessibleName = "Content";
            this.Content.AutoSize = true;
            this.Content.Location = new System.Drawing.Point(27, 101);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(44, 13);
            this.Content.TabIndex = 7;
            this.Content.Text = "Content";
            // 
            // Search
            // 
            this.Search.AccessibleName = "Search";
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Search.Location = new System.Drawing.Point(700, 133);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(88, 34);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // FilesView
            // 
            this.FilesView.AccessibleName = "FilesView";
            this.FilesView.Location = new System.Drawing.Point(12, 186);
            this.FilesView.Name = "FilesView";
            this.FilesView.Size = new System.Drawing.Size(776, 252);
            this.FilesView.TabIndex = 10;
            this.FilesView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilesView);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ContentFile);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.DateValue);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Directory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Directory;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox DateValue;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.TextBox ContentFile;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView FilesView;
    }
}

