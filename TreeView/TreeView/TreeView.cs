using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class FileSystemForm : Form
    {
        public FileSystemForm()
        {
            InitializeComponent();
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo driveInfo = new DriveInfo(drive);

                TreeNode node = new TreeNode(drive.Substring(0, 1));
                node.Tag = drive;

                if (driveInfo.IsReady == true)
                    node.Nodes.Add("...");

                drivesSystemTreeView.Nodes.Add(node);
            }
        }

        private void DrivesSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    string[] directories = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string directory in directories)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                        TreeNode node = new TreeNode(directoryInfo.Name, 0, 1);
                       
                        node.Tag = directory;
                        
                        if (directoryInfo.GetDirectories().Count() > 0)
                            node.Nodes.Add(null, "...", 0, 0);

                        foreach (var file in directoryInfo.GetFiles())
                        {
                            TreeNode n = new TreeNode(file.Name);
                            node.Nodes.Add(n);
                        }
                        e.Node.Nodes.Add(node);
                    }
                }
            }
        }
    }
}
