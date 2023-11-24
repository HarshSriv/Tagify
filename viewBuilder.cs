using System.Diagnostics;
using System.IO;

namespace tagify
{
    internal class viewBuilder : mainWindow
    {
        internal static ListView.SelectedListViewItemCollection selectedItems;
        internal static void loadView()
        {
            Interactor.mainView.Items.Clear();
            Interactor.fileNameText.Text = "--";
            Interactor.fileTypeText.Text = "--";
            Interactor.tagsBar.Text = "--";

            if(locationHistory.Count == 0)
            {
                DriveInfo[] drives = null;
                Interactor.addressBar.Text = " home";

                try
                {
                    drives = DriveInfo.GetDrives();

                    foreach(DriveInfo drive in drives)
                    {
                        try
                        {
                            ListViewItem newDrive = new ListViewItem(drive.Name);
                            newDrive.Tag = drive;
                            newDrive.ImageIndex = 42;
                            Interactor.mainView.Items.Add(newDrive);
                        }
                        catch(Exception e)
                        {
                            // excpetion in accesing drives
                        }
                    }
                }
                catch(Exception ex)
                {
                    // exception in getting drives
                }
            }
            else
            {
                Interactor.addressBar.Text = " " + locationHistory.Peek().FullName;

                DirectoryInfo currentDirectory = null;

                try
                {
                    currentDirectory = locationHistory.Peek();

                    FileInfo[] files = currentDirectory.GetFiles();
                    DirectoryInfo[] directories = currentDirectory.GetDirectories();

                    foreach(FileInfo file in files)
                    {
                        addNewFile(file);
                    }

                    foreach(DirectoryInfo directory in directories)
                    {
                        addNewDirectory(directory);
                    }
                }
                catch
                {
                    // location invalid or inaccesible
                }
            }

            Interactor.mainView.Focus();
        }

        internal static void addNewFile(FileInfo file)
        {
            ListViewItem newFile = new ListViewItem(file.Name);
            newFile.ImageIndex = getImageIndex(file.Extension);
            newFile.Tag = file;
            Interactor.mainView.Items.Add(newFile);
        }

        internal static void addNewDirectory(DirectoryInfo directory)
        {
            ListViewItem newDirectory = new ListViewItem(directory.Name);
            newDirectory.ImageIndex = 41;
            newDirectory.Tag = directory;
            Interactor.mainView.Items.Add(newDirectory);
        }

        internal static void updateFromTree(TreeNode selectedNode)
        {
            bool isDirectory = selectedNode.Tag is DirectoryInfo;

            if (isDirectory)
            {
                DirectoryInfo currentDirectory = selectedNode.Tag as DirectoryInfo;
                treeBuilder.buildDirectories(currentDirectory, selectedNode);
                locationHistory.Push(currentDirectory);
            }
            else
            {
                DriveInfo currentDrive = selectedNode.Tag as DriveInfo;
                treeBuilder.buildDirectories(currentDrive.RootDirectory, selectedNode);
                locationHistory.Push(currentDrive.RootDirectory);
            }

            loadView();
        }

        internal static void openItemLocation(dynamic item)
        {
            string itemPath = "";

            if(locationHistory.Count == 0)
                itemPath = item.RootDirectory.FullName;
            else
                itemPath = item.FullName;


            Process.Start("explorer.exe", "/select," + itemPath);
        }

        internal static void openLocation()
        {

            if (locationHistory.Count == 0)
                Process.Start("explorer.exe");
            else
            {
                string currentLocation = locationHistory.Peek().FullName;
                Process.Start("explorer.exe", currentLocation);
            }  
        }

        internal static void processItem(dynamic item)
        {
            bool isFile = item.Tag is FileInfo;

            if(isFile)
            {
                FileInfo currentFile = item.Tag as FileInfo;
                Process.Start("explorer.exe", currentFile.FullName);
            }
            else
            {
                bool isDrive = item.Tag is DriveInfo;

                if(isDrive)
                {
                    DriveInfo currentDrive = item.Tag as DriveInfo;
                    locationHistory.Push(currentDrive.RootDirectory);
                }
                else
                {
                    DirectoryInfo currentDirectory = item.Tag as DirectoryInfo;
                    locationHistory.Push(currentDirectory);
                }

                loadView();
            }
        }

        internal static void updateFileInformation()
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if (selectedItems.Count == 1)
            {
                bool isFile = selectedItems[0].Tag is FileInfo;

                if (isFile)
                {
                    FileInfo currentFile = selectedItems[0].Tag as FileInfo;

                    if (currentFile.Name.Length < 32) Interactor.fileNameText.Text = currentFile.Name;
                    else Interactor.fileNameText.Text = currentFile.Name.Substring(0, 32) + " ...";

                    Interactor.fileTypeText.Text = currentFile.Extension;

                    string tags = tagInterface.getTags(currentFile.FullName);
                    if (tags != "") Interactor.tagsBar.Text = tags;

                    return;
                }
            }

            Interactor.fileNameText.Text = "--";
            Interactor.fileTypeText.Text = "--";
            Interactor.tagsBar.Text = "--";
        }

        internal static void goBack()
        {
            if(locationHistory.Count > 0)
            {
                locationHistory.Pop();
                loadView();
            }
        }

        internal static void goToAddress()
        {
            string path = Interactor.addressBar.Text.Trim();

            if(path == "home") clearHistory();
            else if(path.Length > 2 && Directory.Exists(path))
            {
                DirectoryInfo currentDirectory = new DirectoryInfo(path);
                locationHistory.Push(currentDirectory);
            }

            Debug.WriteLine(path);

            loadView();
        }

        internal static void clearHistory()
        {
            locationHistory.Clear();
            loadView();
        }

        internal static void editTags()
        {
            if(Interactor.tagsBar.ReadOnly)
            {
                selectedItems = Interactor.mainView.SelectedItems;

                if (selectedItems.Count == 1)
                {
                    bool isFile = selectedItems[0].Tag is FileInfo;

                    if (isFile)
                        tagsBar_CustomFocus();
                }
                else if(selectedItems.Count > 1)
                    tagsBar_CustomFocus();
            }
            else
            {
                string currentTags = Interactor.tagsBar.Text;

                if (selectedItems.Count == 1)
                {
                    bool isFile = selectedItems[0].Tag is FileInfo;

                    if(isFile)
                    {
                        FileInfo currentFile = selectedItems[0].Tag as FileInfo;

                        tagInterface.setTags(currentFile.FullName, currentTags);
                    }
                }
                else
                {
                    tagInterface.setBatchTags(selectedItems, currentTags);
                }

                Interactor.mainView.Focus();
            }
        }

        internal static void deleteTags()
        {
            selectedItems = Interactor.mainView.SelectedItems;

            if(selectedItems.Count > 0)
            {
                deleteTagsDialog newDialog = new deleteTagsDialog();
                if (newDialog.ShowDialog() == DialogResult.OK)
                {
                    string tagsToDelete = newDialog.tagsTextBox.Text;
                    tagInterface.deleteBatchTags(selectedItems, tagsToDelete);
                }

                loadView();
            }
        }

        internal static void tagsBar_CustomFocus()
        {
            Interactor.tagsBar.ReadOnly = false;
            Interactor.tagsBar.BorderStyle = BorderStyle.Fixed3D;
            Interactor.tagsBar.BackColor = SystemColors.Window;
            if (Interactor.tagsBar.Text == "--") Interactor.tagsBar.Text = "";
            Interactor.editTagsHelp.Visible = true;
            Interactor.tagsBar.Focus();
        }

        internal static int getImageIndex(string extension)
        {
            switch(extension)
            {
                case ".3ds":
                    return 0;
                case ".aac":
                    return 1;
                case ".avi":
                    return 2;
                case ".bmp":
                    return 3;
                case ".cad":
                    return 4;
                case ".cdr":
                    return 5;
                case ".css":
                    return 6;
                case ".dat":
                    return 7;
                case ".dll":
                    return 8;
                case ".dmg":
                    return 9;
                case ".doc":
                    return 10;
                case ".eps":
                    return 11;
                case ".fla":
                    return 13;
                case ".flv":
                    return 14;
                case ".gif":
                    return 15;
                case ".html":
                    return 16;
                case ".indd":
                    return 17;
                case ".iso":
                    return 18;
                case ".jpg":
                    return 19;
                case ".js":
                    return 20;
                case ".midi":
                    return 21;
                case ".mov":
                    return 22;
                case ".mp3":
                    return 23;
                case ".mp4":
                    return 24;
                case ".mpg":
                    return 25;
                case ".pdf":
                    return 26;
                case ".php":
                    return 27;
                case ".png":
                    return 28;
                case ".ppt":
                    return 29;
                case ".ps":
                    return 30;
                case ".psd":
                    return 31;
                case ".raw":
                    return 32;
                case ".sql":
                    return 33;
                case ".svg":
                    return 34;
                case ".tif":
                    return 35;
                case ".txt":
                    return 36;
                case ".wmv":
                    return 37;
                case ".xls":
                    return 38;
                case ".xml":
                    return 39;
                case ".zip":
                    return 40;
                default:
                    return 12;
            }
        }
    }
}