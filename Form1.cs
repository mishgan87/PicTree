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

namespace PicTree
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
        }

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Clear();
                TreeNode rootNode;
                var path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo info = new DirectoryInfo(path);
                if (info.Exists)
                {
                    var extensions = new string[] { ".bmp", ".jpeg", ".jpg", ".png" };
                    FileInfo[] files = (from fi in new DirectoryInfo(path).GetFiles()
                                        where extensions.Contains(fi.Extension.ToLower())
                                        select fi).ToArray();
                    foreach (FileInfo fileInfo in files)
                    {
                        rootNode = new TreeNode(fileInfo.Name);
                        rootNode.Tag = fileInfo.FullName;
                        treeView1.Nodes.Add(rootNode);
                    }
                }
            }
        }
		private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
            try
            {
                pictureBox1.Image = new Bitmap(e.Node.Tag.ToString());
                pictureBox1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
