
namespace PicTree
{
	partial class FormSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSetFont = new System.Windows.Forms.Button();
			this.labelImage = new System.Windows.Forms.Label();
			this.labelFont = new System.Windows.Forms.Label();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.textBoxFont = new System.Windows.Forms.TextBox();
			this.comboBoxImage = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(216, 182);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(74, 24);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "Ок";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(296, 182);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(74, 24);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// buttonSetFont
			// 
			this.buttonSetFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSetFont.Location = new System.Drawing.Point(337, 6);
			this.buttonSetFont.Name = "buttonSetFont";
			this.buttonSetFont.Size = new System.Drawing.Size(33, 24);
			this.buttonSetFont.TabIndex = 2;
			this.buttonSetFont.Text = "...";
			this.buttonSetFont.UseVisualStyleBackColor = true;
			this.buttonSetFont.Click += new System.EventHandler(this.ButtonSetFont_Click);
			// 
			// labelImage
			// 
			this.labelImage.AutoSize = true;
			this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelImage.Location = new System.Drawing.Point(12, 35);
			this.labelImage.Name = "labelImage";
			this.labelImage.Size = new System.Drawing.Size(141, 16);
			this.labelImage.TabIndex = 3;
			this.labelImage.Text = "Режим отображения";
			// 
			// labelFont
			// 
			this.labelFont.AutoSize = true;
			this.labelFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFont.Location = new System.Drawing.Point(12, 9);
			this.labelFont.Name = "labelFont";
			this.labelFont.Size = new System.Drawing.Size(53, 16);
			this.labelFont.TabIndex = 4;
			this.labelFont.Text = "Шрифт";
			// 
			// fontDialog1
			// 
			this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			// 
			// textBoxFont
			// 
			this.textBoxFont.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxFont.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxFont.Location = new System.Drawing.Point(111, 9);
			this.textBoxFont.Name = "textBoxFont";
			this.textBoxFont.Size = new System.Drawing.Size(220, 13);
			this.textBoxFont.TabIndex = 5;
			// 
			// comboBoxImage
			// 
			this.comboBoxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxImage.FormattingEnabled = true;
			this.comboBoxImage.Location = new System.Drawing.Point(159, 35);
			this.comboBoxImage.Name = "comboBoxImage";
			this.comboBoxImage.Size = new System.Drawing.Size(211, 24);
			this.comboBoxImage.TabIndex = 6;
			this.comboBoxImage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxImage_SelectedIndexChanged);
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 212);
			this.Controls.Add(this.comboBoxImage);
			this.Controls.Add(this.labelFont);
			this.Controls.Add(this.buttonSetFont);
			this.Controls.Add(this.textBoxFont);
			this.Controls.Add(this.labelImage);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.MaximumSize = new System.Drawing.Size(400, 250);
			this.MinimumSize = new System.Drawing.Size(400, 250);
			this.Name = "FormSettings";
			this.Text = "Настройки";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSetFont;
		private System.Windows.Forms.Label labelImage;
		private System.Windows.Forms.Label labelFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.TextBox textBoxFont;
		private System.Windows.Forms.ComboBox comboBoxImage;
	}
}