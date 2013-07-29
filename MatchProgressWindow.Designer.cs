namespace CompareDir
{
    partial class MatchProgressWindow
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblLeft1 = new System.Windows.Forms.Label();
			this.lblNoMatch1 = new System.Windows.Forms.Label();
			this.lblMatch1 = new System.Windows.Forms.Label();
			this.lblRight1 = new System.Windows.Forms.Label();
			this.lblLeft2 = new System.Windows.Forms.Label();
			this.lblNoMatch2 = new System.Windows.Forms.Label();
			this.lblMatch2 = new System.Windows.Forms.Label();
			this.lblRight2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBar1.Location = new System.Drawing.Point(0, 0);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(292, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblLeft1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblNoMatch1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblMatch1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblRight1, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblLeft2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblNoMatch2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblMatch2, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblRight2, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 78);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(76, 49);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(140, 26);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblLeft1
			// 
			this.lblLeft1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLeft1.Location = new System.Drawing.Point(3, 0);
			this.lblLeft1.Name = "lblLeft1";
			this.lblLeft1.Size = new System.Drawing.Size(67, 16);
			this.lblLeft1.TabIndex = 0;
			this.lblLeft1.Text = "Left only:";
			this.lblLeft1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNoMatch1
			// 
			this.lblNoMatch1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblNoMatch1.Location = new System.Drawing.Point(76, 0);
			this.lblNoMatch1.Name = "lblNoMatch1";
			this.lblNoMatch1.Size = new System.Drawing.Size(67, 16);
			this.lblNoMatch1.TabIndex = 1;
			this.lblNoMatch1.Text = "No match:";
			this.lblNoMatch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMatch1
			// 
			this.lblMatch1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMatch1.Location = new System.Drawing.Point(149, 0);
			this.lblMatch1.Name = "lblMatch1";
			this.lblMatch1.Size = new System.Drawing.Size(67, 16);
			this.lblMatch1.TabIndex = 2;
			this.lblMatch1.Text = "Match:";
			this.lblMatch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRight1
			// 
			this.lblRight1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblRight1.Location = new System.Drawing.Point(222, 0);
			this.lblRight1.Name = "lblRight1";
			this.lblRight1.Size = new System.Drawing.Size(67, 16);
			this.lblRight1.TabIndex = 3;
			this.lblRight1.Text = "Right only:";
			this.lblRight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLeft2
			// 
			this.lblLeft2.AutoSize = true;
			this.lblLeft2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeft2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
			this.lblLeft2.Location = new System.Drawing.Point(3, 16);
			this.lblLeft2.Name = "lblLeft2";
			this.lblLeft2.Size = new System.Drawing.Size(67, 30);
			this.lblLeft2.TabIndex = 4;
			this.lblLeft2.Text = "888";
			this.lblLeft2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblNoMatch2
			// 
			this.lblNoMatch2.AutoSize = true;
			this.lblNoMatch2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblNoMatch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoMatch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblNoMatch2.Location = new System.Drawing.Point(76, 16);
			this.lblNoMatch2.Name = "lblNoMatch2";
			this.lblNoMatch2.Size = new System.Drawing.Size(67, 30);
			this.lblNoMatch2.TabIndex = 5;
			this.lblNoMatch2.Text = "888";
			this.lblNoMatch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblMatch2
			// 
			this.lblMatch2.AutoSize = true;
			this.lblMatch2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMatch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
			this.lblMatch2.Location = new System.Drawing.Point(149, 16);
			this.lblMatch2.Name = "lblMatch2";
			this.lblMatch2.Size = new System.Drawing.Size(67, 30);
			this.lblMatch2.TabIndex = 6;
			this.lblMatch2.Text = "888";
			this.lblMatch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblRight2
			// 
			this.lblRight2.AutoSize = true;
			this.lblRight2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRight2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
			this.lblRight2.Location = new System.Drawing.Point(222, 16);
			this.lblRight2.Name = "lblRight2";
			this.lblRight2.Size = new System.Drawing.Size(67, 30);
			this.lblRight2.TabIndex = 7;
			this.lblRight2.Text = "888";
			this.lblRight2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MatchProgressWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 101);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.progressBar1);
			this.Name = "MatchProgressWindow";
			this.Text = "Please wait...";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLeft1;
        private System.Windows.Forms.Label lblNoMatch1;
        private System.Windows.Forms.Label lblMatch1;
        private System.Windows.Forms.Label lblRight1;
        private System.Windows.Forms.Label lblLeft2;
        private System.Windows.Forms.Label lblNoMatch2;
        private System.Windows.Forms.Label lblMatch2;
        private System.Windows.Forms.Label lblRight2;
        private System.Windows.Forms.Button btnCancel;
    }
}