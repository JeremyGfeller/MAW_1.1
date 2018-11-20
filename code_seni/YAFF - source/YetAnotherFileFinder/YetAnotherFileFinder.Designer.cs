namespace YetAnotherFileFinder
{
    partial class YetAnotherFileFinder
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
            this.lblSelectDriveHeader = new System.Windows.Forms.Label();
            this.lblInfoDrive = new System.Windows.Forms.Label();
            this.lblResearch = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblModifDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cboExtension = new System.Windows.Forms.ComboBox();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.FilesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModificationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblSelectFolderFromDrive = new System.Windows.Forms.Label();
            this.btnSelectFFD = new System.Windows.Forms.Button();
            this.fbdFolderLookup = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDateModif = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSelectDriveHeader
            // 
            this.lblSelectDriveHeader.AutoSize = true;
            this.lblSelectDriveHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDriveHeader.Location = new System.Drawing.Point(44, 19);
            this.lblSelectDriveHeader.Name = "lblSelectDriveHeader";
            this.lblSelectDriveHeader.Size = new System.Drawing.Size(233, 25);
            this.lblSelectDriveHeader.TabIndex = 0;
            this.lblSelectDriveHeader.Text = "Sélectionner un lecteur";
            // 
            // lblInfoDrive
            // 
            this.lblInfoDrive.AutoSize = true;
            this.lblInfoDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDrive.Location = new System.Drawing.Point(544, 19);
            this.lblInfoDrive.Name = "lblInfoDrive";
            this.lblInfoDrive.Size = new System.Drawing.Size(219, 25);
            this.lblInfoDrive.TabIndex = 1;
            this.lblInfoDrive.Text = "Information du lecteur";
            // 
            // lblResearch
            // 
            this.lblResearch.AutoSize = true;
            this.lblResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearch.Location = new System.Drawing.Point(96, 189);
            this.lblResearch.Name = "lblResearch";
            this.lblResearch.Size = new System.Drawing.Size(116, 25);
            this.lblResearch.TabIndex = 2;
            this.lblResearch.Text = "Recherche";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(46, 251);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(48, 13);
            this.lblKeyword.TabIndex = 3;
            this.lblKeyword.Text = "Mot clé :";
            // 
            // lblModifDate
            // 
            this.lblModifDate.AutoSize = true;
            this.lblModifDate.Location = new System.Drawing.Point(46, 295);
            this.lblModifDate.Name = "lblModifDate";
            this.lblModifDate.Size = new System.Drawing.Size(110, 13);
            this.lblModifDate.TabIndex = 4;
            this.lblModifDate.Text = "Date de modification :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(46, 340);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Auteur :";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(49, 383);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(59, 13);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Extension :";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(675, 189);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(88, 25);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Fichiers";
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(49, 464);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(75, 23);
            this.btnResearch.TabIndex = 8;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.Location = new System.Drawing.Point(367, 463);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(138, 23);
            this.btnRepo.TabIndex = 10;
            this.btnRepo.Text = "Ouvrir le répértoire";
            this.btnRepo.UseVisualStyleBackColor = true;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(181, 248);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(166, 20);
            this.txtKeyWord.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(181, 337);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(166, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // cboExtension
            // 
            this.cboExtension.FormattingEnabled = true;
            this.cboExtension.Items.AddRange(new object[] {
            ".exe",
            ".jpg",
            ".png",
            ".docx",
            ".pdf",
            ".xlsx"});
            this.cboExtension.Location = new System.Drawing.Point(181, 380);
            this.cboExtension.Name = "cboExtension";
            this.cboExtension.Size = new System.Drawing.Size(166, 21);
            this.cboExtension.TabIndex = 15;
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackgroundImageTiled = true;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilesName,
            this.Size,
            this.Author,
            this.ModificationDate});
            this.lvwFiles.Location = new System.Drawing.Point(367, 189);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(608, 227);
            this.lvwFiles.TabIndex = 18;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.SelectedIndexChanged += new System.EventHandler(this.lvwFiles_SelectedIndexChanged);
            // 
            // FilesName
            // 
            this.FilesName.Text = "Name";
            this.FilesName.Width = 210;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 110;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 150;
            // 
            // ModificationDate
            // 
            this.ModificationDate.Text = "Last modification date";
            this.ModificationDate.Width = 116;
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 197;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(837, 463);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(138, 23);
            this.btnOpenFile.TabIndex = 19;
            this.btnOpenFile.Text = "Ouvrir le fichier";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblSelectFolderFromDrive
            // 
            this.lblSelectFolderFromDrive.AutoSize = true;
            this.lblSelectFolderFromDrive.Location = new System.Drawing.Point(98, 71);
            this.lblSelectFolderFromDrive.Name = "lblSelectFolderFromDrive";
            this.lblSelectFolderFromDrive.Size = new System.Drawing.Size(134, 13);
            this.lblSelectFolderFromDrive.TabIndex = 20;
            this.lblSelectFolderFromDrive.Text = "Sélectionner un répertoire :";
            // 
            // btnSelectFFD
            // 
            this.btnSelectFFD.Location = new System.Drawing.Point(112, 100);
            this.btnSelectFFD.Name = "btnSelectFFD";
            this.btnSelectFFD.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFFD.TabIndex = 21;
            this.btnSelectFFD.Text = "Sélectionner...";
            this.btnSelectFFD.UseVisualStyleBackColor = true;
            this.btnSelectFFD.Click += new System.EventHandler(this.btnSelectFFD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Debug Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDateModif
            // 
            this.dtpDateModif.CustomFormat = " ";
            this.dtpDateModif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateModif.Location = new System.Drawing.Point(181, 289);
            this.dtpDateModif.Name = "dtpDateModif";
            this.dtpDateModif.Size = new System.Drawing.Size(166, 20);
            this.dtpDateModif.TabIndex = 23;
            this.dtpDateModif.ValueChanged += new System.EventHandler(this.dtpDateModif_ValueChanged);
            // 
            // YetAnotherFileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 515);
            this.Controls.Add(this.dtpDateModif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectFFD);
            this.Controls.Add(this.lblSelectFolderFromDrive);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.cboExtension);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnRepo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblModifDate);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblResearch);
            this.Controls.Add(this.lblInfoDrive);
            this.Controls.Add(this.lblSelectDriveHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YetAnotherFileFinder";
            this.Text = "YAFF - Yet Another File Finder";
            this.Load += new System.EventHandler(this.YetAnotherFileFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDriveHeader;
        private System.Windows.Forms.Label lblInfoDrive;
        private System.Windows.Forms.Label lblResearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblModifDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRepo;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblSelectFolderFromDrive;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderLookup;
        public System.Windows.Forms.Button btnSelectFFD;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView lvwFiles;
        public System.Windows.Forms.TextBox txtKeyWord;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.ComboBox cboExtension;
        public System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FilesName;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader ModificationDate;
        public System.Windows.Forms.DateTimePicker dtpDateModif;
    }
}

