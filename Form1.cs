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
            FillFilesTree();
        }
        /// <summary>
        /// Вызов диалога открытия папки и заполнение дерева файлами из этой папки
        /// </summary>
        private void FillFilesTree()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                treeViewPicture.Nodes.Clear();
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
                        treeViewPicture.Nodes.Add(rootNode);
                    }
                    if (treeViewPicture.Nodes.Count > 0)
                    {
                        treeViewPicture.SelectedNode = treeViewPicture.Nodes[0];
                        treeViewPicture.Focus();
                    }
                }
            }
        }
        /// <summary>
        /// Отображает картинку на PictureBox
        /// </summary>
        /// <param name="treeNode">Узел дерева, у которого в поле Tag записан путь к изображению</param>
        private void ShowPicture(TreeNode treeNode)
        {
            try
            {
                pictureBox1.Image = new Bitmap(treeNode.Tag.ToString());
                pictureBox1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FillFilesTree();
        }

        private void ButtonNext_Click_1(object sender, EventArgs e)
        {
            if (treeViewPicture.SelectedNode.Index == treeViewPicture.Nodes.Count - 1)
            {
                treeViewPicture.SelectedNode = treeViewPicture.Nodes[0];
            }
            else
            {
                treeViewPicture.SelectedNode = treeViewPicture.SelectedNode.NextNode;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (treeViewPicture.SelectedNode.Index == 0)
            {
                treeViewPicture.SelectedNode = treeViewPicture.Nodes[treeViewPicture.Nodes.Count - 1];
            }
            else
            {
                treeViewPicture.SelectedNode = treeViewPicture.SelectedNode.PrevNode;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void treeViewPicture_AfterSelect_1(object sender, TreeViewEventArgs e) => ShowPicture(treeViewPicture.SelectedNode);

    }
}
