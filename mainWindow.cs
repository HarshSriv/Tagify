using System.Diagnostics;
using System.IO;

namespace tagify
{
    public partial class mainWindow : Form
    {
        protected static mainWindow Interactor;
        protected static Stack<DirectoryInfo> locationHistory;
        public mainWindow()
        {
            Interactor = this;
            locationHistory = new Stack<DirectoryInfo>();
            InitializeComponent();
            treeBuilder.buildTree();
            viewBuilder.loadView();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            viewBuilder.updateFromTree(selectedNode);
        }

        private void mainView_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewBuilder.updateFileInformation();
        }

        private void openInExplorer_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if (selectedItems.Count == 1)
                viewBuilder.openItemLocation(selectedItems[0].Tag);
            else
                viewBuilder.openLocation();
        }

        private void mainView_DoubleClick(object sender, EventArgs e)
        {
            viewBuilder.processItem(Interactor.mainView.SelectedItems[0]);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            viewBuilder.goBack();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            viewBuilder.clearHistory();
        }
        private void addressBar_Enter(object sender, EventArgs e)
        {
            addressBar.ForeColor = SystemColors.WindowText;
            addressBar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void addressBar_Leave(object sender, EventArgs e)
        {
            viewBuilder.goToAddress();

            addressBar.ForeColor = SystemColors.GrayText;
            addressBar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                viewBuilder.goToAddress();
        }
        private void reloadButton_Click(object sender, EventArgs e)
        {
            viewBuilder.loadView();
        }

        private void editTagsButton_Click(object sender, EventArgs e)
        {
            viewBuilder.editTags();
        }

        private void tagsBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                viewBuilder.editTags();
            }
        }

        private void tagsBar_Leave(object sender, EventArgs e)
        {
            Interactor.tagsBar.ReadOnly = true;
            Interactor.tagsBar.BorderStyle = BorderStyle.None;
            Interactor.tagsBar.BackColor = SystemColors.Control;
            Interactor.editTagsHelp.Visible = false;

            viewBuilder.loadView();
        }

        private void deleteTagsButton_Click(object sender, EventArgs e)
        {
            viewBuilder.deleteTags();
        }
    }
}