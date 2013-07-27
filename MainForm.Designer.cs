namespace CompareDir
{
    partial class MainForm
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
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeLeftRightItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeCenterItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plainText2ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutCompareDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filenamesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.ColumnCount = 3;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(0, 24);
			this.table.Name = "table";
			this.table.RowCount = 1;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
			this.table.Size = new System.Drawing.Size(284, 237);
			this.table.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDirectoriesToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// changeDirectoriesToolStripMenuItem
			// 
			this.changeDirectoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLeftRightItem,
            this.changeCenterItem,
            this.filenamesOnlyToolStripMenuItem});
			this.changeDirectoriesToolStripMenuItem.Name = "changeDirectoriesToolStripMenuItem";
			this.changeDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.changeDirectoriesToolStripMenuItem.Text = "Change directories";
			// 
			// changeLeftRightItem
			// 
			this.changeLeftRightItem.Name = "changeLeftRightItem";
			this.changeLeftRightItem.Size = new System.Drawing.Size(153, 22);
			this.changeLeftRightItem.Text = "Left/Right";
			this.changeLeftRightItem.Click += new System.EventHandler(this.changeLeftRightItem_Click);
			// 
			// changeCenterItem
			// 
			this.changeCenterItem.Name = "changeCenterItem";
			this.changeCenterItem.Size = new System.Drawing.Size(153, 22);
			this.changeCenterItem.Text = "Center";
			this.changeCenterItem.Click += new System.EventHandler(this.changeCenterItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plainText2ColumnsToolStripMenuItem,
            this.hTMLToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// plainText2ColumnsToolStripMenuItem
			// 
			this.plainText2ColumnsToolStripMenuItem.Name = "plainText2ColumnsToolStripMenuItem";
			this.plainText2ColumnsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.plainText2ColumnsToolStripMenuItem.Text = "Plain text (2 columns)";
			this.plainText2ColumnsToolStripMenuItem.Click += new System.EventHandler(this.plainText2ColumnsToolStripMenuItem_Click);
			// 
			// hTMLToolStripMenuItem
			// 
			this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
			this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.hTMLToolStripMenuItem.Text = "HTML";
			this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCompareDirToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutCompareDirToolStripMenuItem
			// 
			this.aboutCompareDirToolStripMenuItem.Name = "aboutCompareDirToolStripMenuItem";
			this.aboutCompareDirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.aboutCompareDirToolStripMenuItem.Text = "About CompareDir";
			this.aboutCompareDirToolStripMenuItem.Click += new System.EventHandler(this.aboutCompareDirToolStripMenuItem_Click);
			// 
			// filenamesOnlyToolStripMenuItem
			// 
			this.filenamesOnlyToolStripMenuItem.Checked = true;
			this.filenamesOnlyToolStripMenuItem.CheckOnClick = true;
			this.filenamesOnlyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.filenamesOnlyToolStripMenuItem.Name = "filenamesOnlyToolStripMenuItem";
			this.filenamesOnlyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.filenamesOnlyToolStripMenuItem.Text = "Filenames only";
			this.filenamesOnlyToolStripMenuItem.Click += new System.EventHandler(this.filenamesOnlyToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.table);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "CompareDir";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TableLayoutPanel table;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeDirectoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeLeftRightItem;
		private System.Windows.Forms.ToolStripMenuItem changeCenterItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutCompareDirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainText2ColumnsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filenamesOnlyToolStripMenuItem;

	}
}

