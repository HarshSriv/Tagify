namespace tagify
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.uiButtonIcons = new System.Windows.Forms.ImageList(this.components);
            this.addressBar = new System.Windows.Forms.TextBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.taskbarNotificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.searchingAnimation = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.treeViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.mainViewIcons = new System.Windows.Forms.ImageList(this.components);
            this.mainView = new System.Windows.Forms.ListView();
            this.listViewItemOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameText = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileTypeText = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.editTagsButton = new System.Windows.Forms.Button();
            this.tagsBar = new System.Windows.Forms.TextBox();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.editTagsHelp = new System.Windows.Forms.Label();
            this.deleteTagsButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchingAnimation)).BeginInit();
            this.listViewItemOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButtonIcons
            // 
            this.uiButtonIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.uiButtonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uiButtonIcons.ImageStream")));
            this.uiButtonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.uiButtonIcons.Images.SetKeyName(0, "back.png");
            this.uiButtonIcons.Images.SetKeyName(1, "delete.png");
            this.uiButtonIcons.Images.SetKeyName(2, "edit.png");
            this.uiButtonIcons.Images.SetKeyName(3, "enter.png");
            this.uiButtonIcons.Images.SetKeyName(4, "home.png");
            this.uiButtonIcons.Images.SetKeyName(5, "reload.png");
            this.uiButtonIcons.Images.SetKeyName(6, "search.png");
            // 
            // addressBar
            // 
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addressBar.Location = new System.Drawing.Point(104, 21);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(706, 40);
            this.addressBar.TabIndex = 2;
            this.addressBar.Text = " home";
            this.addressBar.Enter += new System.EventHandler(this.addressBar_Enter);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            this.addressBar.Leave += new System.EventHandler(this.addressBar_Leave);
            // 
            // searchBar
            // 
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBar.Location = new System.Drawing.Point(924, 21);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(600, 40);
            this.searchBar.TabIndex = 4;
            this.searchBar.Text = " Search your Tag";
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ImageIndex = 4;
            this.homeButton.ImageList = this.uiButtonIcons;
            this.homeButton.Location = new System.Drawing.Point(12, 21);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(40, 40);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ImageIndex = 6;
            this.searchButton.ImageList = this.uiButtonIcons;
            this.searchButton.Location = new System.Drawing.Point(1530, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.TabIndex = 5;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // taskbarNotificationIcon
            // 
            this.taskbarNotificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarNotificationIcon.Icon")));
            this.taskbarNotificationIcon.Text = "notifyIcon";
            this.taskbarNotificationIcon.Visible = true;
            // 
            // searchingAnimation
            // 
            this.searchingAnimation.BackColor = System.Drawing.Color.Transparent;
            this.searchingAnimation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchingAnimation.Image = global::tagify.Properties.Resources.searching;
            this.searchingAnimation.Location = new System.Drawing.Point(-31, 663);
            this.searchingAnimation.Name = "searchingAnimation";
            this.searchingAnimation.Size = new System.Drawing.Size(427, 397);
            this.searchingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchingAnimation.TabIndex = 16;
            this.searchingAnimation.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.treeViewIcons;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowPlusMinus = false;
            this.treeView.Size = new System.Drawing.Size(347, 692);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // treeViewIcons
            // 
            this.treeViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.treeViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewIcons.ImageStream")));
            this.treeViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewIcons.Images.SetKeyName(0, "folder.png");
            this.treeViewIcons.Images.SetKeyName(1, "hard-drive.png");
            // 
            // mainViewIcons
            // 
            this.mainViewIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainViewIcons.ImageStream")));
            this.mainViewIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.mainViewIcons.Images.SetKeyName(0, "3ds.png");
            this.mainViewIcons.Images.SetKeyName(1, "aac.png");
            this.mainViewIcons.Images.SetKeyName(2, "avi.png");
            this.mainViewIcons.Images.SetKeyName(3, "bmp.png");
            this.mainViewIcons.Images.SetKeyName(4, "cad.png");
            this.mainViewIcons.Images.SetKeyName(5, "cdr.png");
            this.mainViewIcons.Images.SetKeyName(6, "css.png");
            this.mainViewIcons.Images.SetKeyName(7, "dat.png");
            this.mainViewIcons.Images.SetKeyName(8, "dll.png");
            this.mainViewIcons.Images.SetKeyName(9, "dmg.png");
            this.mainViewIcons.Images.SetKeyName(10, "doc.png");
            this.mainViewIcons.Images.SetKeyName(11, "eps.png");
            this.mainViewIcons.Images.SetKeyName(12, "file.png");
            this.mainViewIcons.Images.SetKeyName(13, "fla.png");
            this.mainViewIcons.Images.SetKeyName(14, "flv.png");
            this.mainViewIcons.Images.SetKeyName(15, "gif.png");
            this.mainViewIcons.Images.SetKeyName(16, "html.png");
            this.mainViewIcons.Images.SetKeyName(17, "indd.png");
            this.mainViewIcons.Images.SetKeyName(18, "iso.png");
            this.mainViewIcons.Images.SetKeyName(19, "jpg.png");
            this.mainViewIcons.Images.SetKeyName(20, "js.png");
            this.mainViewIcons.Images.SetKeyName(21, "midi.png");
            this.mainViewIcons.Images.SetKeyName(22, "mov.png");
            this.mainViewIcons.Images.SetKeyName(23, "mp3.png");
            this.mainViewIcons.Images.SetKeyName(24, "mp4.png");
            this.mainViewIcons.Images.SetKeyName(25, "mpg.png");
            this.mainViewIcons.Images.SetKeyName(26, "pdf.png");
            this.mainViewIcons.Images.SetKeyName(27, "php.png");
            this.mainViewIcons.Images.SetKeyName(28, "png.png");
            this.mainViewIcons.Images.SetKeyName(29, "ppt.png");
            this.mainViewIcons.Images.SetKeyName(30, "ps.png");
            this.mainViewIcons.Images.SetKeyName(31, "psd.png");
            this.mainViewIcons.Images.SetKeyName(32, "raw.png");
            this.mainViewIcons.Images.SetKeyName(33, "sql.png");
            this.mainViewIcons.Images.SetKeyName(34, "svg.png");
            this.mainViewIcons.Images.SetKeyName(35, "tif.png");
            this.mainViewIcons.Images.SetKeyName(36, "txt.png");
            this.mainViewIcons.Images.SetKeyName(37, "wmv.png");
            this.mainViewIcons.Images.SetKeyName(38, "xls.png");
            this.mainViewIcons.Images.SetKeyName(39, "xml.png");
            this.mainViewIcons.Images.SetKeyName(40, "zip.png");
            this.mainViewIcons.Images.SetKeyName(41, "folder.png");
            this.mainViewIcons.Images.SetKeyName(42, "hard-drive.png");
            // 
            // mainView
            // 
            this.mainView.BackColor = System.Drawing.SystemColors.Window;
            this.mainView.ContextMenuStrip = this.listViewItemOptions;
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.LargeImageList = this.mainViewIcons;
            this.mainView.Location = new System.Drawing.Point(0, 0);
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(1205, 692);
            this.mainView.SmallImageList = this.mainViewIcons;
            this.mainView.TabIndex = 0;
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.SelectedIndexChanged += new System.EventHandler(this.mainView_SelectedIndexChanged);
            this.mainView.DoubleClick += new System.EventHandler(this.mainView_DoubleClick);
            // 
            // listViewItemOptions
            // 
            this.listViewItemOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listViewItemOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInExplorer});
            this.listViewItemOptions.Name = "listViewItemOptions";
            this.listViewItemOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.listViewItemOptions.Size = new System.Drawing.Size(190, 28);
            // 
            // openInExplorer
            // 
            this.openInExplorer.Name = "openInExplorer";
            this.openInExplorer.Size = new System.Drawing.Size(189, 24);
            this.openInExplorer.Text = "Open In Explorer";
            this.openInExplorer.Click += new System.EventHandler(this.openInExplorer_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.uiButtonIcons;
            this.backButton.Location = new System.Drawing.Point(58, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameLabel.Location = new System.Drawing.Point(371, 801);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(126, 35);
            this.fileNameLabel.TabIndex = 15;
            this.fileNameLabel.Text = "File Name";
            // 
            // fileNameText
            // 
            this.fileNameText.AutoSize = true;
            this.fileNameText.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameText.Location = new System.Drawing.Point(503, 801);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(35, 35);
            this.fileNameText.TabIndex = 14;
            this.fileNameText.Text = "--";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileTypeLabel.Location = new System.Drawing.Point(371, 870);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(111, 35);
            this.fileTypeLabel.TabIndex = 13;
            this.fileTypeLabel.Text = "File Type";
            // 
            // fileTypeText
            // 
            this.fileTypeText.AutoSize = true;
            this.fileTypeText.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileTypeText.Location = new System.Drawing.Point(503, 870);
            this.fileTypeText.Name = "fileTypeText";
            this.fileTypeText.Size = new System.Drawing.Size(35, 35);
            this.fileTypeText.TabIndex = 12;
            this.fileTypeText.Text = "--";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagsLabel.Location = new System.Drawing.Point(938, 801);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(64, 35);
            this.tagsLabel.TabIndex = 11;
            this.tagsLabel.Text = "Tags";
            // 
            // editTagsButton
            // 
            this.editTagsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editTagsButton.FlatAppearance.BorderSize = 0;
            this.editTagsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editTagsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editTagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTagsButton.ImageIndex = 2;
            this.editTagsButton.ImageList = this.uiButtonIcons;
            this.editTagsButton.Location = new System.Drawing.Point(996, 801);
            this.editTagsButton.Name = "editTagsButton";
            this.editTagsButton.Size = new System.Drawing.Size(40, 40);
            this.editTagsButton.TabIndex = 6;
            this.editTagsButton.UseVisualStyleBackColor = true;
            this.editTagsButton.Click += new System.EventHandler(this.editTagsButton_Click);
            // 
            // tagsBar
            // 
            this.tagsBar.BackColor = System.Drawing.SystemColors.Control;
            this.tagsBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagsBar.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagsBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tagsBar.Location = new System.Drawing.Point(1055, 801);
            this.tagsBar.Name = "tagsBar";
            this.tagsBar.ReadOnly = true;
            this.tagsBar.Size = new System.Drawing.Size(515, 33);
            this.tagsBar.TabIndex = 10;
            this.tagsBar.TabStop = false;
            this.tagsBar.Text = "--";
            this.tagsBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagsBar_KeyDown);
            this.tagsBar.Leave += new System.EventHandler(this.tagsBar_Leave);
            // 
            // mainContainer
            // 
            this.mainContainer.Location = new System.Drawing.Point(14, 76);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.treeView);
            this.mainContainer.Panel1MinSize = 300;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.mainView);
            this.mainContainer.Panel2MinSize = 600;
            this.mainContainer.Size = new System.Drawing.Size(1556, 692);
            this.mainContainer.SplitterDistance = 347;
            this.mainContainer.TabIndex = 9;
            // 
            // editTagsHelp
            // 
            this.editTagsHelp.AutoSize = true;
            this.editTagsHelp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.editTagsHelp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editTagsHelp.Location = new System.Drawing.Point(1055, 847);
            this.editTagsHelp.Name = "editTagsHelp";
            this.editTagsHelp.Size = new System.Drawing.Size(188, 23);
            this.editTagsHelp.TabIndex = 8;
            this.editTagsHelp.Text = "Press Enter to Save Tags";
            this.editTagsHelp.Visible = false;
            // 
            // deleteTagsButton
            // 
            this.deleteTagsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteTagsButton.FlatAppearance.BorderSize = 0;
            this.deleteTagsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteTagsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteTagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTagsButton.ImageIndex = 1;
            this.deleteTagsButton.ImageList = this.uiButtonIcons;
            this.deleteTagsButton.Location = new System.Drawing.Point(996, 847);
            this.deleteTagsButton.Name = "deleteTagsButton";
            this.deleteTagsButton.Size = new System.Drawing.Size(40, 40);
            this.deleteTagsButton.TabIndex = 7;
            this.deleteTagsButton.UseVisualStyleBackColor = true;
            this.deleteTagsButton.Click += new System.EventHandler(this.deleteTagsButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.ImageIndex = 5;
            this.reloadButton.ImageList = this.uiButtonIcons;
            this.reloadButton.Location = new System.Drawing.Point(816, 21);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(40, 40);
            this.reloadButton.TabIndex = 17;
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.deleteTagsButton);
            this.Controls.Add(this.editTagsHelp);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.tagsBar);
            this.Controls.Add(this.editTagsButton);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.fileTypeText);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameText);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.searchingAnimation);
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tagify";
            ((System.ComponentModel.ISupportInitialize)(this.searchingAnimation)).EndInit();
            this.listViewItemOptions.ResumeLayout(false);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Button goButton;
        protected internal TextBox addressBar;
        protected internal TextBox searchBar;
        protected internal Button homeButton;
        protected internal ImageList uiButtonIcons;
        protected internal Button searchButton;
        protected internal NotifyIcon taskbarNotificationIcon;
        protected internal PictureBox searchingAnimation;
        protected internal TreeView treeView;
        protected internal ListView mainView;
        protected internal Button backButton;
        protected internal Label fileNameLabel;
        protected internal Label fileNameText;
        protected internal Label fileTypeLabel;
        protected internal Label fileTypeText;
        protected internal Label tagsLabel;
        protected internal Button editTagsButton;
        protected internal TextBox tagsBar;
        protected internal ImageList mainViewIcons;
        protected internal ImageList treeViewIcons;
        protected internal SplitContainer mainContainer;
        protected internal ContextMenuStrip listViewItemOptions;
        protected internal ToolStripMenuItem openInExplorer;
        protected internal Label editTagsHelp;
        protected internal Button deleteTagsButton;
        protected internal Button reloadButton;
    }
}