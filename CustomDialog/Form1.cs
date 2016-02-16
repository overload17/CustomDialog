using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDialog
{
    public partial class CustomDialog : Form
    {
        public CustomDialog()
        {
            InitializeComponent();
            dirstree.BeforeExpand += dirstree_BeforeExpand;
            
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)
            {
                driverslist.Items.Add(s);
            }
        }

        private void driverslist_SelectedValueChanged(object sender, EventArgs e)
        {
            // заполняем дерево дисками
            dirstree.Nodes.Clear();
            TreeNode driveNode = new TreeNode { Text = driverslist.Text };
            FillTreeNode(driveNode, driverslist.Text);
            dirstree.Nodes.Add(driveNode);
        }

        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("/") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        //// событие перед раскрытием узла
        void dirstree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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

        private void dirstree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string fullPath = dirstree.SelectedNode.FullPath;

            DirectoryInfo di = new DirectoryInfo(fullPath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;

            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }

            fileslist.Items.Clear();

            foreach (DirectoryInfo dirInfo in diArray)
            {
                ListViewItem lvi = new ListViewItem(dirInfo.Name);
                lvi.SubItems.Add("0");
                lvi.SubItems.Add(dirInfo.LastWriteTime.ToString());
                fileslist.Items.Add(lvi);
            }

            foreach (FileInfo fileInfo in fiArray)
            {
                ListViewItem lvi = new ListViewItem(fileInfo.Name);
                lvi.SubItems.Add(fileInfo.Length.ToString());
                lvi.SubItems.Add(fileInfo.LastWriteTime.ToString());

                string filenameExtension =
                  Path.GetExtension(fileInfo.Name).ToLower();

                fileslist.Items.Add(lvi);
            }
        }

        private void fileslist_Click(object sender, EventArgs e)
        {
            filepath.Clear();
            filepath.Text = dirstree.SelectedNode.FullPath + "\\" + fileslist.SelectedItems[0].Text;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
