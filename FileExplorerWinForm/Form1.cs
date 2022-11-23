using System.Diagnostics;

namespace FileExplorerWinForm
{
    public partial class FileExplorerForm : Form
    {
        private string filepath = "F:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public FileExplorerForm()
        {
            InitializeComponent();
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            // заполняем дерево дисками
            FillDriveNodes();
        }

        private void FileExplorerForm_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = filepath;
            loadFilesAndDirectories();
        }
        public void loadFilesAndDirectories()
        {
            DirectoryInfo filelist;
            string tempFilePath = "";
            FileAttributes? FAttributes;
            try
            {
                if (isFile)
                {
                    tempFilePath = filepath + "\\" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    lb_filename.Text = fileDetails.Name;
                    lb_filetype.Text = fileDetails.Extension;
                    FAttributes = File.GetAttributes(tempFilePath);
                    Process.Start(fileName: tempFilePath);
                }
                else
                {
                    FAttributes = File.GetAttributes(filepath);

                }
                if ((FAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    filelist = new DirectoryInfo(filepath);
                    FileInfo[] files = filelist.GetFiles();
                    DirectoryInfo[] dirs = filelist.GetDirectories();
                    string fileextension = "";
                    listView.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileextension = files[i].Extension.ToUpper();
                        switch (fileextension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView.Items.Add(files[i].Name, 6);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView.Items.Add(files[i].Name, 8);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView.Items.Add(files[i].Name, 5);
                                break;
                            case ".PDF":
                                listView.Items.Add(files[i].Name, 7);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView.Items.Add(files[i].Name, 3);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView.Items.Add(files[i].Name, 4);
                                break;

                            default:
                                listView.Items.Add(files[i].Name, 0);
                                break;
                        }
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView.Items.Add(dirs[i].Name, 1);
                    }
                }
                else
                {
                    lb_filename.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filepath = textBoxPath.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        public void removeBackSlash()
        {
            string path = textBoxPath.Text;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                textBoxPath.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = textBoxPath.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                textBoxPath.Text = path;
                removeBackSlash();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_forward_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileattr = File.GetAttributes(filepath + "\\" + currentlySelectedItemName);
            if ((fileattr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                textBoxPath.Text = filepath + "\\" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            currentlySelectedItemName = e.Node.FullPath;
            FileAttributes fileattr = File.GetAttributes(currentlySelectedItemName);
            if ((fileattr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                textBoxPath.Text = currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
            loadButtonAction();
        }
    }
}