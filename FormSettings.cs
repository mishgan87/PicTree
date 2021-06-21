using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicTree
{
	public partial class FormSettings : Form
	{
		public Font fontSet;
		public PictureBoxSizeMode sizeModeSet;
		public FormSettings(Font defaultFont, PictureBoxSizeMode defaultSizeMode)
		{
			InitializeComponent();
			fontSet = defaultFont;
			sizeModeSet = defaultSizeMode;
			textBoxFont.Text = defaultFont.ToString();
			comboBoxImage.Items.Clear();
			foreach (PictureBoxSizeMode val in Enum.GetValues(typeof(PictureBoxSizeMode)))
			{
				comboBoxImage.Items.Add(val);
			}
			comboBoxImage.SelectedItem = defaultSizeMode;
		}
		private void ButtonSetFont_Click(object sender, EventArgs e)
		{
			fontDialog1.Font = fontSet;
			fontDialog1.ShowColor = true;
			fontDialog1.Color = textBoxFont.ForeColor;
			if (fontDialog1.ShowDialog() != DialogResult.Cancel)
			{
				fontSet = fontDialog1.Font;
				textBoxFont.Text = fontDialog1.Font.ToString();
			}
		}

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void ComboBoxImage_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (PictureBoxSizeMode val in Enum.GetValues(typeof(PictureBoxSizeMode)))
			{
				if (val.ToString() == comboBoxImage.SelectedItem.ToString())
				{
					sizeModeSet = val;
				}
			}
		}
	}
}
