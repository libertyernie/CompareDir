namespace CompareDir
{
    partial class FileDisplay
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
			this.lblName1 = new System.Windows.Forms.Label();
			this.lblName2 = new System.Windows.Forms.Label();
			this.lblSize1 = new System.Windows.Forms.Label();
			this.lblSize2 = new System.Windows.Forms.Label();
			this.lblMD51 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblMD52 = new System.Windows.Forms.Label();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblModified1 = new System.Windows.Forms.Label();
			this.lblModified2 = new System.Windows.Forms.Label();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.btnOpenLocation = new System.Windows.Forms.Button();
			this.btnOkay = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblInternalName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblName1
			// 
			this.lblName1.AutoSize = true;
			this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName1.Location = new System.Drawing.Point(3, 0);
			this.lblName1.Name = "lblName1";
			this.lblName1.Size = new System.Drawing.Size(43, 13);
			this.lblName1.TabIndex = 0;
			this.lblName1.Text = "Name:";
			// 
			// lblName2
			// 
			this.lblName2.AutoSize = true;
			this.lblName2.Location = new System.Drawing.Point(52, 0);
			this.lblName2.Name = "lblName2";
			this.lblName2.Size = new System.Drawing.Size(29, 13);
			this.lblName2.TabIndex = 1;
			this.lblName2.Text = "label";
			// 
			// lblSize1
			// 
			this.lblSize1.AutoSize = true;
			this.lblSize1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSize1.Location = new System.Drawing.Point(3, 0);
			this.lblSize1.Name = "lblSize1";
			this.lblSize1.Size = new System.Drawing.Size(35, 13);
			this.lblSize1.TabIndex = 2;
			this.lblSize1.Text = "Size:";
			// 
			// lblSize2
			// 
			this.lblSize2.AutoSize = true;
			this.lblSize2.Location = new System.Drawing.Point(44, 0);
			this.lblSize2.Name = "lblSize2";
			this.lblSize2.Size = new System.Drawing.Size(29, 13);
			this.lblSize2.TabIndex = 3;
			this.lblSize2.Text = "label";
			// 
			// lblMD51
			// 
			this.lblMD51.AutoSize = true;
			this.lblMD51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMD51.Location = new System.Drawing.Point(3, 0);
			this.lblMD51.Name = "lblMD51";
			this.lblMD51.Size = new System.Drawing.Size(37, 13);
			this.lblMD51.TabIndex = 4;
			this.lblMD51.Text = "MD5:";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 85);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.lblName1);
			this.flowLayoutPanel2.Controls.Add(this.lblName2);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(84, 13);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Controls.Add(this.lblSize1);
			this.flowLayoutPanel3.Controls.Add(this.lblSize2);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 13);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(76, 13);
			this.flowLayoutPanel3.TabIndex = 1;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.Controls.Add(this.lblMD51);
			this.flowLayoutPanel4.Controls.Add(this.lblMD52);
			this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 26);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(78, 13);
			this.flowLayoutPanel4.TabIndex = 2;
			// 
			// lblMD52
			// 
			this.lblMD52.AutoSize = true;
			this.lblMD52.Location = new System.Drawing.Point(46, 0);
			this.lblMD52.Name = "lblMD52";
			this.lblMD52.Size = new System.Drawing.Size(29, 13);
			this.lblMD52.TabIndex = 6;
			this.lblMD52.Text = "label";
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.AutoSize = true;
			this.flowLayoutPanel5.Controls.Add(this.lblModified1);
			this.flowLayoutPanel5.Controls.Add(this.lblModified2);
			this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 39);
			this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(100, 13);
			this.flowLayoutPanel5.TabIndex = 3;
			// 
			// lblModified1
			// 
			this.lblModified1.AutoSize = true;
			this.lblModified1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModified1.Location = new System.Drawing.Point(3, 0);
			this.lblModified1.Name = "lblModified1";
			this.lblModified1.Size = new System.Drawing.Size(59, 13);
			this.lblModified1.TabIndex = 0;
			this.lblModified1.Text = "Modified:";
			// 
			// lblModified2
			// 
			this.lblModified2.AutoSize = true;
			this.lblModified2.Location = new System.Drawing.Point(68, 0);
			this.lblModified2.Name = "lblModified2";
			this.lblModified2.Size = new System.Drawing.Size(29, 13);
			this.lblModified2.TabIndex = 1;
			this.lblModified2.Text = "label";
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(3, 3);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(110, 23);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "Open file";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// btnOpenLocation
			// 
			this.btnOpenLocation.Location = new System.Drawing.Point(3, 32);
			this.btnOpenLocation.Name = "btnOpenLocation";
			this.btnOpenLocation.Size = new System.Drawing.Size(110, 23);
			this.btnOpenLocation.TabIndex = 2;
			this.btnOpenLocation.Text = "Open file location";
			this.btnOpenLocation.UseVisualStyleBackColor = true;
			this.btnOpenLocation.Click += new System.EventHandler(this.btnOpenLocation_Click);
			// 
			// btnOkay
			// 
			this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkay.Location = new System.Drawing.Point(214, 32);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 0;
			this.btnOkay.Text = "OK";
			this.btnOkay.UseVisualStyleBackColor = true;
			this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btnOpenLocation, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnOpenFile, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOkay, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblInternalName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 58);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// lblInternalName
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.lblInternalName, 2);
			this.lblInternalName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblInternalName.Location = new System.Drawing.Point(119, 0);
			this.lblInternalName.Name = "lblInternalName";
			this.lblInternalName.Size = new System.Drawing.Size(170, 29);
			this.lblInternalName.TabIndex = 3;
			this.lblInternalName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(119, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "BrawlView";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FileDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 143);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FileDisplay";
			this.Text = "File Information";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblSize1;
        private System.Windows.Forms.Label lblSize2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblMD51;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenLocation;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMD52;
        private System.Windows.Forms.Label lblInternalName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblModified1;
        private System.Windows.Forms.Label lblModified2;
		private System.Windows.Forms.Button button1;

    }
}