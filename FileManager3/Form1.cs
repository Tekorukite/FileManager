using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using InfoLibFW;

namespace FileManager3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
            PopulateDataGridView(dataGridView_Drives);
            textBox_Status.Text = "Loading";
            Application.DoEvents();

            Thread thSource = new Thread(threadProcSource);
            thSource.Start();
            Thread thTarget = new Thread(threadProcTarget);
            thTarget.Start();

            textBox_Status.Text = "Ready.";
            Application.DoEvents();
        }

        private void threadProcSource(Object StateInfo)
        {
            PopulateDirTree(treeView1_SourceFiles, true);
        }

        private void threadProcTarget(Object StateInfo)
        {
            PopulateDirTree(treeView_TargetDir, false);

        }

        static void PopulateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            DriveInfo[] Drives = DriveInfo.GetDrives();
            int height = 29;
            foreach (DriveInfo drive in Drives)
            {
                if (drive.IsReady)
                {
                    string[] row = {drive.Name, drive.DriveType.ToString(), drive.DriveFormat, (ToGiB(drive.TotalSize)).ToString() + " GiB",
                    ToGiB(drive.TotalFreeSpace).ToString() + " GiB", (drive.TotalFreeSpace * 100 / drive.TotalSize).ToString()};
                    dataGridView.Rows.Add(row);
                    height += 25;
                }
            }
            dataGridView.Height = height;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            PopulateDataGridView(dataGridView_Drives);
            
        }

        static double ToGiB(long bytes)
        {
            return ((bytes / (long)1e7) / 100.0);
        }

        public void PopulateDirTree(TreeView treeView, bool isSource)
        {
            this.Invoke((MethodInvoker) delegate
            {
                treeView.Nodes.Clear();
                TreeNode rootNode;

                DriveInfo[] Drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in Drives)
                {
                    if (drive.IsReady)
                    {
                        DirectoryInfo dir = new DirectoryInfo(drive.Name);
                        rootNode = new TreeNode(drive.Name);
                        rootNode.Tag = drive.ToString();
                        GetDirs(dir.GetDirectories(), rootNode, isSource);
                        treeView.Nodes.Add(rootNode);
                    }
                }
            });
            
            
        }

        private void GetDirs(DirectoryInfo[] subDirs, TreeNode nodeToAddTo, bool isSource)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                if ((subDir.Attributes != FileAttributes.Hidden)&(subDir.Attributes != FileAttributes.System)&(subDir.Attributes == FileAttributes.Directory))
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "folder";
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        try { GetDirs(subSubDirs, aNode, isSource); }
                        catch { }
                        
                    }
                    nodeToAddTo.Nodes.Add(aNode);
                    if (isSource)
                    {
                        FileInfo[] files = subDir.GetFiles();
                        foreach (FileInfo file in files)
                        {
                            try
                            {
                                TreeNode fileNode = new TreeNode(file.Name);
                                fileNode.ImageIndex = 1;
                                aNode.Nodes.Add(fileNode);
                            }
                            catch { }
                        }
                    }
                }
            }
        }

        private void SetCheck(TreeNode node, bool check)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.Checked = check;

                if (n.Nodes.Count != 0)
                {
                    SetCheck(n, check);
                }
            }
        }

        private string GetParentString(TreeNode node)
        {
            if(node.Parent == null)
            {
                return node.Text;
            }
            else
            {
                return GetParentString(node.Parent) + node.Text + (node.Nodes.Count == 0 ? "" : "\\");
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It will take some time. Go drink coffee ;)");
            foreach (TreeNode node in treeView1_SourceFiles.Nodes)
            {
                
                SetCheck(node, false);

            }

        }

        private void treeView1_SourceFiles_AfterExpand(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView1_SourceFiles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node != treeView1_SourceFiles.TopNode)
            {
                SetCheck(e.Node, e.Node.Checked);

            }
            

        }

        private void treeView_TargetDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string theFullPath = GetParentString(e.Node);
            if (theFullPath.EndsWith("\\")) 
            {
                theFullPath = theFullPath.Substring(0, theFullPath.Length - 1); 
            }
            textBox_TargetDir.Text = theFullPath;
        }

        private void treeView1_SourceFiles_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node == treeView1_SourceFiles.TopNode)&&(treeView1_SourceFiles.TopNode.Checked == false))
            {
                MessageBox.Show("You shouldn't check the root node.\nUncheck it.\nNOW!!!");

            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(CopyFiles);
            th.Start();
        }

        private void CopyFiles()
        {
            List<FileInfo> fileList = GetFileList();
            int progress = 0;
            foreach (FileInfo file in fileList)
            {
                try
                {
                    textBox_Status.Text = "Copying " + textBox_TargetDir.Text + "\\" + file.Name + "...";
                    Application.DoEvents();
                    file.CopyTo(textBox_TargetDir.Text + "\\" + file.Name, checkBox_Overwrite.Checked);
                }
                catch { MessageBox.Show("Got sometroubles\n I'm SO sorry..."); }
                progress++;
                MethodInvoker m = new MethodInvoker(() => progressBar.Value = progress * 100 / fileList.Count);
                progressBar.Invoke(m);

            }
            this.Invoke((MethodInvoker)delegate
           {
               textBox_Status.Text = "Refresing the tree.";
               Application.DoEvents();
               PopulateDirTree(treeView1_SourceFiles, true);
               PopulateDirTree(treeView_TargetDir, false);
               textBox_Status.Text = "Ready";
               Application.DoEvents();

           });
        }

        private List<FileInfo> GetFileList()
        {
            List<string> fileNames = new List<string>();
            foreach (TreeNode node in treeView1_SourceFiles.Nodes)
            {
                GetCheckedFiles(node, fileNames);
            }
            List<FileInfo> fileList = new List<FileInfo>();
            foreach(string fileName in fileNames)
            {
                FileInfo file = new FileInfo(fileName);
                if (file.Exists)
                {
                    fileList.Add(file);
                }
            }
            IComparer<FileInfo> comparer = (IComparer<FileInfo>)new FileComparer();
            fileList.Sort(comparer);
            return fileList;
        }

        private void GetCheckedFiles(TreeNode node, List<string> fileNames)
        {
            if (node.Nodes.Count == 0)
            {
                if (node.Checked)
                {
                    string fullPath = GetParentString(node);
                    fileNames.Add(fullPath);
                }
            }
            else
            {
                foreach (TreeNode n in node.Nodes)
                {
                    GetCheckedFiles(n, fileNames);
                }
            }

        }

        public class FileComparer : IComparer<FileInfo>
        {
            public int Compare (FileInfo f1, FileInfo f2)
            {
                
                if (f1.Length > f2.Length) { return -1; }
                if (f1.Length < f2.Length) { return 1; }
                return 0;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = MessageBox.Show("Are you sure?", "Delete Files", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                List<FileInfo> fileList = GetFileList();
                foreach (FileInfo file in fileList)
                {
                    try
                    {
                        textBox_Status.Text = "Deleting " + textBox_TargetDir.Text + "\\" + file.Name + "...";
                        Application.DoEvents();
                        file.Delete();
                    }
                    catch { MessageBox.Show("Apparently, you cant't delete some of these files"); }

                }
                textBox_Status.Text = "Refresing the tree.";
                Application.DoEvents();
                PopulateDirTree(treeView1_SourceFiles, true);
                PopulateDirTree(treeView_TargetDir, false);
                textBox_Status.Text = "Ready.";
                Application.DoEvents();
            }

        }

        private void button_Move_Click(object sender, EventArgs e)
        {
            List<FileInfo> fileList = GetFileList();
            foreach (FileInfo file in fileList)
            {
                try
                {
                    textBox_Status.Text = "Moving " + textBox_TargetDir.Text + "\\" + file.Name + "...";
                    Application.DoEvents();
                    file.CopyTo(textBox_TargetDir.Text + "\\" + file.Name, checkBox_Overwrite.Checked);
                    file.Delete();
                }
                catch { MessageBox.Show("Got sometroubles\n I'm SO sorry..."); }


            }
            textBox_Status.Text = "Refresing the tree.";
            Application.DoEvents();
            PopulateDirTree(treeView1_SourceFiles, true);
            PopulateDirTree(treeView_TargetDir, false);
            textBox_Status.Text = "Ready.";
            Application.DoEvents();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            Creator creator = new Creator();
            creator.Show();
        }
    }
}
