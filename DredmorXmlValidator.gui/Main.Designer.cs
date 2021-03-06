﻿namespace DredmorModValidator
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.coreLocation = new System.Windows.Forms.TextBox();
			this.browseForMod = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.RichTextBox();
			this.validate = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.zoomIn = new System.Windows.Forms.Button();
			this.zoomOut = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Core Location:";
			// 
			// coreLocation
			// 
			this.coreLocation.Location = new System.Drawing.Point(11, 25);
			this.coreLocation.Name = "coreLocation";
			this.coreLocation.Size = new System.Drawing.Size(719, 20);
			this.coreLocation.TabIndex = 1;
			// 
			// browseForMod
			// 
			this.browseForMod.Location = new System.Drawing.Point(736, 24);
			this.browseForMod.Name = "browseForMod";
			this.browseForMod.Size = new System.Drawing.Size(65, 20);
			this.browseForMod.TabIndex = 2;
			this.browseForMod.Text = "Browse...";
			this.browseForMod.UseVisualStyleBackColor = true;
			this.browseForMod.Click += new System.EventHandler(this.browseForMod_Click);
			// 
			// output
			// 
			this.output.BackColor = System.Drawing.Color.White;
			this.output.DetectUrls = false;
			this.output.Font = new System.Drawing.Font("Corbel", 8.25F);
			this.output.Location = new System.Drawing.Point(11, 83);
			this.output.Name = "output";
			this.output.ReadOnly = true;
			this.output.Size = new System.Drawing.Size(949, 467);
			this.output.TabIndex = 3;
			this.output.Text = "";
			this.output.WordWrap = false;
			// 
			// validate
			// 
			this.validate.Location = new System.Drawing.Point(11, 54);
			this.validate.Name = "validate";
			this.validate.Size = new System.Drawing.Size(75, 23);
			this.validate.TabIndex = 4;
			this.validate.Text = "Validate";
			this.validate.UseVisualStyleBackColor = true;
			this.validate.Click += new System.EventHandler(this.validate_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Zip files|*.zip";
			// 
			// zoomIn
			// 
			this.zoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zoomIn.Location = new System.Drawing.Point(930, 47);
			this.zoomIn.Name = "zoomIn";
			this.zoomIn.Size = new System.Drawing.Size(29, 30);
			this.zoomIn.TabIndex = 8;
			this.zoomIn.Text = "+";
			this.zoomIn.UseVisualStyleBackColor = true;
			this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
			// 
			// zoomOut
			// 
			this.zoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zoomOut.Location = new System.Drawing.Point(895, 47);
			this.zoomOut.Name = "zoomOut";
			this.zoomOut.Size = new System.Drawing.Size(29, 30);
			this.zoomOut.TabIndex = 9;
			this.zoomOut.Text = "-";
			this.zoomOut.UseVisualStyleBackColor = true;
			this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(884, 556);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 10;
			this.save.Text = "Save As...";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Rich Text Format|*.rtf";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 589);
			this.Controls.Add(this.save);
			this.Controls.Add(this.zoomOut);
			this.Controls.Add(this.zoomIn);
			this.Controls.Add(this.validate);
			this.Controls.Add(this.output);
			this.Controls.Add(this.browseForMod);
			this.Controls.Add(this.coreLocation);
			this.Controls.Add(this.label1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dredmor XML Validator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox coreLocation;
		private System.Windows.Forms.Button browseForMod;
		private System.Windows.Forms.RichTextBox output;
		private System.Windows.Forms.Button validate;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button zoomIn;
		private System.Windows.Forms.Button zoomOut;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

