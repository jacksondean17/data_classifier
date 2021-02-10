
namespace data_classifier
{
    partial class Form1
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
            this.sourceDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noButton = new System.Windows.Forms.Button();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.skipButton = new System.Windows.Forms.Button();
            this.noDestinationDirectoryLabel = new System.Windows.Forms.Label();
            this.yesDirectoryPickButton = new System.Windows.Forms.Button();
            this.noDirectoryPickButton = new System.Windows.Forms.Button();
            this.yesDestinationDirectoryLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.yesDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.noDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.currentFileNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalFilesLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.noFileCountLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.yesFileCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.40112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 678F));
            this.tableLayoutPanel1.Controls.Add(this.noButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chooseFolderButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.yesButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1395, 873);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Red;
            this.noButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noButton.Location = new System.Drawing.Point(719, 662);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(673, 103);
            this.noButton.TabIndex = 5;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.AutoSize = true;
            this.chooseFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseFolderButton.Location = new System.Drawing.Point(3, 771);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(105, 99);
            this.chooseFolderButton.TabIndex = 0;
            this.chooseFolderButton.Text = "Choose Folder";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Green;
            this.yesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesButton.Location = new System.Drawing.Point(114, 662);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(599, 103);
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1389, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.directoryLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.fileLabel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(114, 771);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 99);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Directory:";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(3, 42);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(33, 13);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "None";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current File:";
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(3, 82);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(33, 13);
            this.fileLabel.TabIndex = 7;
            this.fileLabel.Text = "None";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.05663F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.94337F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel3.Controls.Add(this.skipButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.noDestinationDirectoryLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.yesDirectoryPickButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.noDirectoryPickButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.yesDestinationDirectoryLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.finishButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.undoButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(719, 771);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(673, 99);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // skipButton
            // 
            this.skipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skipButton.Location = new System.Drawing.Point(94, 3);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(317, 27);
            this.skipButton.TabIndex = 12;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // noDestinationDirectoryLabel
            // 
            this.noDestinationDirectoryLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.noDestinationDirectoryLabel, 2);
            this.noDestinationDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noDestinationDirectoryLabel.Location = new System.Drawing.Point(94, 65);
            this.noDestinationDirectoryLabel.Name = "noDestinationDirectoryLabel";
            this.noDestinationDirectoryLabel.Size = new System.Drawing.Size(576, 34);
            this.noDestinationDirectoryLabel.TabIndex = 11;
            this.noDestinationDirectoryLabel.Text = "None";
            this.noDestinationDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yesDirectoryPickButton
            // 
            this.yesDirectoryPickButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesDirectoryPickButton.Location = new System.Drawing.Point(3, 36);
            this.yesDirectoryPickButton.Name = "yesDirectoryPickButton";
            this.yesDirectoryPickButton.Size = new System.Drawing.Size(85, 26);
            this.yesDirectoryPickButton.TabIndex = 8;
            this.yesDirectoryPickButton.Text = "Yes Destination Directory";
            this.yesDirectoryPickButton.UseVisualStyleBackColor = true;
            this.yesDirectoryPickButton.Click += new System.EventHandler(this.yesDirectoryPickButton_Click);
            // 
            // noDirectoryPickButton
            // 
            this.noDirectoryPickButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noDirectoryPickButton.Location = new System.Drawing.Point(3, 68);
            this.noDirectoryPickButton.Name = "noDirectoryPickButton";
            this.noDirectoryPickButton.Size = new System.Drawing.Size(85, 28);
            this.noDirectoryPickButton.TabIndex = 9;
            this.noDirectoryPickButton.Text = "No Destination Directory";
            this.noDirectoryPickButton.UseVisualStyleBackColor = true;
            this.noDirectoryPickButton.Click += new System.EventHandler(this.noDirectoryPickButton_Click);
            // 
            // yesDestinationDirectoryLabel
            // 
            this.yesDestinationDirectoryLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.yesDestinationDirectoryLabel, 2);
            this.yesDestinationDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesDestinationDirectoryLabel.Location = new System.Drawing.Point(94, 33);
            this.yesDestinationDirectoryLabel.Name = "yesDestinationDirectoryLabel";
            this.yesDestinationDirectoryLabel.Size = new System.Drawing.Size(576, 32);
            this.yesDestinationDirectoryLabel.TabIndex = 10;
            this.yesDestinationDirectoryLabel.Text = "None";
            this.yesDestinationDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // finishButton
            // 
            this.finishButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishButton.Location = new System.Drawing.Point(3, 3);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(85, 27);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoButton.Location = new System.Drawing.Point(417, 3);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(253, 27);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 662);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(105, 103);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.currentFileNumberLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.totalFilesLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(99, 27);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // currentFileNumberLabel
            // 
            this.currentFileNumberLabel.AutoSize = true;
            this.currentFileNumberLabel.Location = new System.Drawing.Point(35, 0);
            this.currentFileNumberLabel.Name = "currentFileNumberLabel";
            this.currentFileNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.currentFileNumberLabel.TabIndex = 1;
            this.currentFileNumberLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            // 
            // totalFilesLabel
            // 
            this.totalFilesLabel.AutoSize = true;
            this.totalFilesLabel.Location = new System.Drawing.Point(72, 0);
            this.totalFilesLabel.Name = "totalFilesLabel";
            this.totalFilesLabel.Size = new System.Drawing.Size(13, 13);
            this.totalFilesLabel.TabIndex = 2;
            this.totalFilesLabel.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.noFileCountLabel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(99, 31);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "No:";
            // 
            // noFileCountLabel
            // 
            this.noFileCountLabel.AutoSize = true;
            this.noFileCountLabel.Location = new System.Drawing.Point(33, 0);
            this.noFileCountLabel.Name = "noFileCountLabel";
            this.noFileCountLabel.Size = new System.Drawing.Size(13, 13);
            this.noFileCountLabel.TabIndex = 1;
            this.noFileCountLabel.Text = "0";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Controls.Add(this.yesFileCountLabel);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(99, 27);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yes:";
            // 
            // yesFileCountLabel
            // 
            this.yesFileCountLabel.AutoSize = true;
            this.yesFileCountLabel.Location = new System.Drawing.Point(37, 0);
            this.yesFileCountLabel.Name = "yesFileCountLabel";
            this.yesFileCountLabel.Size = new System.Drawing.Size(13, 13);
            this.yesFileCountLabel.TabIndex = 1;
            this.yesFileCountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 873);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Data Classifier";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog sourceDirectoryBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button yesDirectoryPickButton;
        private System.Windows.Forms.Button noDirectoryPickButton;
        private System.Windows.Forms.Label noDestinationDirectoryLabel;
        private System.Windows.Forms.Label yesDestinationDirectoryLabel;
        private System.Windows.Forms.FolderBrowserDialog yesDirectoryBrowser;
        private System.Windows.Forms.FolderBrowserDialog noDirectoryBrowser;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label yesFileCountLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noFileCountLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentFileNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalFilesLabel;
    }
}

