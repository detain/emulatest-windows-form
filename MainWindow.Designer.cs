namespace WindowsFormsApp1
{
    partial class MainWindow
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
            this.PathsGroup = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ScanPathButton = new System.Windows.Forms.Button();
            this.RemovePathButton = new System.Windows.Forms.Button();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.PathsList = new System.Windows.Forms.ListBox();
            this.LogGroup = new System.Windows.Forms.GroupBox();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.BucketsGroup = new System.Windows.Forms.GroupBox();
            this.BucketLogoLabel = new System.Windows.Forms.Label();
            this.BucketLogoImage = new System.Windows.Forms.PictureBox();
            this.BucketDescriptionText = new System.Windows.Forms.Label();
            this.BucketDescriptionLabel = new System.Windows.Forms.Label();
            this.BucketVersionText = new System.Windows.Forms.Label();
            this.BucketVersionLabel = new System.Windows.Forms.Label();
            this.BucketsLoadedText = new System.Windows.Forms.Label();
            this.BucketsLoadedLabel = new System.Windows.Forms.Label();
            this.EmulatorsCountText = new System.Windows.Forms.Label();
            this.EmulatorsCountLabel = new System.Windows.Forms.Label();
            this.BucketHomeText = new System.Windows.Forms.Label();
            this.BucketHomeLabel = new System.Windows.Forms.Label();
            this.BucketLicenseText = new System.Windows.Forms.Label();
            this.BucketLicenseLabel = new System.Windows.Forms.Label();
            this.BucketNameText = new System.Windows.Forms.Label();
            this.BucketNameLabel = new System.Windows.Forms.Label();
            this.BucketsList = new System.Windows.Forms.ListBox();
            this.EmulatorsGroup = new System.Windows.Forms.GroupBox();
            this.EmulatorsTable = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emulator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathsGroup.SuspendLayout();
            this.LogGroup.SuspendLayout();
            this.BucketsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketLogoImage)).BeginInit();
            this.EmulatorsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PathsGroup
            // 
            this.PathsGroup.Controls.Add(this.UpdateButton);
            this.PathsGroup.Controls.Add(this.ScanPathButton);
            this.PathsGroup.Controls.Add(this.RemovePathButton);
            this.PathsGroup.Controls.Add(this.AddPathButton);
            this.PathsGroup.Controls.Add(this.PathsList);
            this.PathsGroup.Location = new System.Drawing.Point(12, 254);
            this.PathsGroup.Name = "PathsGroup";
            this.PathsGroup.Size = new System.Drawing.Size(292, 145);
            this.PathsGroup.TabIndex = 1;
            this.PathsGroup.TabStop = false;
            this.PathsGroup.Text = "Scan Paths";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(203, 107);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(83, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Run Updates";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ScanPathButton
            // 
            this.ScanPathButton.Location = new System.Drawing.Point(202, 77);
            this.ScanPathButton.Name = "ScanPathButton";
            this.ScanPathButton.Size = new System.Drawing.Size(84, 23);
            this.ScanPathButton.TabIndex = 3;
            this.ScanPathButton.Text = "Scan Paths";
            this.ScanPathButton.UseVisualStyleBackColor = true;
            // 
            // RemovePathButton
            // 
            this.RemovePathButton.Location = new System.Drawing.Point(202, 48);
            this.RemovePathButton.Name = "RemovePathButton";
            this.RemovePathButton.Size = new System.Drawing.Size(84, 23);
            this.RemovePathButton.TabIndex = 2;
            this.RemovePathButton.Text = "Remove Path";
            this.RemovePathButton.UseVisualStyleBackColor = true;
            // 
            // AddPathButton
            // 
            this.AddPathButton.Location = new System.Drawing.Point(202, 19);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(84, 23);
            this.AddPathButton.TabIndex = 1;
            this.AddPathButton.Text = "Add Path";
            this.AddPathButton.UseVisualStyleBackColor = true;
            // 
            // PathsList
            // 
            this.PathsList.FormattingEnabled = true;
            this.PathsList.Location = new System.Drawing.Point(6, 19);
            this.PathsList.Name = "PathsList";
            this.PathsList.Size = new System.Drawing.Size(190, 108);
            this.PathsList.TabIndex = 0;
            // 
            // LogGroup
            // 
            this.LogGroup.Controls.Add(this.LogText);
            this.LogGroup.Location = new System.Drawing.Point(12, 12);
            this.LogGroup.Name = "LogGroup";
            this.LogGroup.Size = new System.Drawing.Size(286, 143);
            this.LogGroup.TabIndex = 2;
            this.LogGroup.TabStop = false;
            this.LogGroup.Text = "Log";
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(6, 19);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(274, 118);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "";
            // 
            // BucketsGroup
            // 
            this.BucketsGroup.Controls.Add(this.BucketLogoLabel);
            this.BucketsGroup.Controls.Add(this.BucketLogoImage);
            this.BucketsGroup.Controls.Add(this.BucketDescriptionText);
            this.BucketsGroup.Controls.Add(this.BucketDescriptionLabel);
            this.BucketsGroup.Controls.Add(this.BucketVersionText);
            this.BucketsGroup.Controls.Add(this.BucketVersionLabel);
            this.BucketsGroup.Controls.Add(this.BucketsLoadedText);
            this.BucketsGroup.Controls.Add(this.BucketsLoadedLabel);
            this.BucketsGroup.Controls.Add(this.EmulatorsCountText);
            this.BucketsGroup.Controls.Add(this.EmulatorsCountLabel);
            this.BucketsGroup.Controls.Add(this.BucketHomeText);
            this.BucketsGroup.Controls.Add(this.BucketHomeLabel);
            this.BucketsGroup.Controls.Add(this.BucketLicenseText);
            this.BucketsGroup.Controls.Add(this.BucketLicenseLabel);
            this.BucketsGroup.Controls.Add(this.BucketNameText);
            this.BucketsGroup.Controls.Add(this.BucketNameLabel);
            this.BucketsGroup.Controls.Add(this.BucketsList);
            this.BucketsGroup.Location = new System.Drawing.Point(311, 12);
            this.BucketsGroup.Name = "BucketsGroup";
            this.BucketsGroup.Size = new System.Drawing.Size(566, 210);
            this.BucketsGroup.TabIndex = 3;
            this.BucketsGroup.TabStop = false;
            this.BucketsGroup.Text = "Emulators Database";
            // 
            // BucketLogoLabel
            // 
            this.BucketLogoLabel.AutoSize = true;
            this.BucketLogoLabel.Location = new System.Drawing.Point(338, 75);
            this.BucketLogoLabel.Name = "BucketLogoLabel";
            this.BucketLogoLabel.Size = new System.Drawing.Size(31, 13);
            this.BucketLogoLabel.TabIndex = 16;
            this.BucketLogoLabel.Text = "Logo";
            // 
            // BucketLogoImage
            // 
            this.BucketLogoImage.Location = new System.Drawing.Point(375, 75);
            this.BucketLogoImage.Name = "BucketLogoImage";
            this.BucketLogoImage.Size = new System.Drawing.Size(185, 122);
            this.BucketLogoImage.TabIndex = 15;
            this.BucketLogoImage.TabStop = false;
            // 
            // BucketDescriptionText
            // 
            this.BucketDescriptionText.AutoSize = true;
            this.BucketDescriptionText.Location = new System.Drawing.Point(404, 19);
            this.BucketDescriptionText.Name = "BucketDescriptionText";
            this.BucketDescriptionText.Size = new System.Drawing.Size(10, 13);
            this.BucketDescriptionText.TabIndex = 14;
            this.BucketDescriptionText.Text = "-";
            // 
            // BucketDescriptionLabel
            // 
            this.BucketDescriptionLabel.AutoSize = true;
            this.BucketDescriptionLabel.Location = new System.Drawing.Point(336, 19);
            this.BucketDescriptionLabel.Name = "BucketDescriptionLabel";
            this.BucketDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.BucketDescriptionLabel.TabIndex = 13;
            this.BucketDescriptionLabel.Text = "Description";
            // 
            // BucketVersionText
            // 
            this.BucketVersionText.AutoSize = true;
            this.BucketVersionText.Location = new System.Drawing.Point(224, 104);
            this.BucketVersionText.Name = "BucketVersionText";
            this.BucketVersionText.Size = new System.Drawing.Size(10, 13);
            this.BucketVersionText.TabIndex = 12;
            this.BucketVersionText.Text = "-";
            // 
            // BucketVersionLabel
            // 
            this.BucketVersionLabel.AutoSize = true;
            this.BucketVersionLabel.Location = new System.Drawing.Point(156, 104);
            this.BucketVersionLabel.Name = "BucketVersionLabel";
            this.BucketVersionLabel.Size = new System.Drawing.Size(42, 13);
            this.BucketVersionLabel.TabIndex = 11;
            this.BucketVersionLabel.Text = "Version";
            // 
            // BucketsLoadedText
            // 
            this.BucketsLoadedText.AutoSize = true;
            this.BucketsLoadedText.Location = new System.Drawing.Point(290, 184);
            this.BucketsLoadedText.Name = "BucketsLoadedText";
            this.BucketsLoadedText.Size = new System.Drawing.Size(10, 13);
            this.BucketsLoadedText.TabIndex = 10;
            this.BucketsLoadedText.Text = "-";
            // 
            // BucketsLoadedLabel
            // 
            this.BucketsLoadedLabel.AutoSize = true;
            this.BucketsLoadedLabel.Location = new System.Drawing.Point(155, 184);
            this.BucketsLoadedLabel.Name = "BucketsLoadedLabel";
            this.BucketsLoadedLabel.Size = new System.Drawing.Size(129, 13);
            this.BucketsLoadedLabel.TabIndex = 9;
            this.BucketsLoadedLabel.Text = "Emulator Buckets Loaded";
            // 
            // EmulatorsCountText
            // 
            this.EmulatorsCountText.AutoSize = true;
            this.EmulatorsCountText.Location = new System.Drawing.Point(226, 162);
            this.EmulatorsCountText.Name = "EmulatorsCountText";
            this.EmulatorsCountText.Size = new System.Drawing.Size(10, 13);
            this.EmulatorsCountText.TabIndex = 8;
            this.EmulatorsCountText.Text = "-";
            // 
            // EmulatorsCountLabel
            // 
            this.EmulatorsCountLabel.AutoSize = true;
            this.EmulatorsCountLabel.Location = new System.Drawing.Point(156, 162);
            this.EmulatorsCountLabel.Name = "EmulatorsCountLabel";
            this.EmulatorsCountLabel.Size = new System.Drawing.Size(63, 13);
            this.EmulatorsCountLabel.TabIndex = 7;
            this.EmulatorsCountLabel.Text = "# Emulators";
            // 
            // BucketHomeText
            // 
            this.BucketHomeText.AutoSize = true;
            this.BucketHomeText.Location = new System.Drawing.Point(224, 75);
            this.BucketHomeText.Name = "BucketHomeText";
            this.BucketHomeText.Size = new System.Drawing.Size(10, 13);
            this.BucketHomeText.TabIndex = 6;
            this.BucketHomeText.Text = "-";
            // 
            // BucketHomeLabel
            // 
            this.BucketHomeLabel.AutoSize = true;
            this.BucketHomeLabel.Location = new System.Drawing.Point(156, 75);
            this.BucketHomeLabel.Name = "BucketHomeLabel";
            this.BucketHomeLabel.Size = new System.Drawing.Size(63, 13);
            this.BucketHomeLabel.TabIndex = 5;
            this.BucketHomeLabel.Text = "Home Page";
            // 
            // BucketLicenseText
            // 
            this.BucketLicenseText.AutoSize = true;
            this.BucketLicenseText.Location = new System.Drawing.Point(224, 48);
            this.BucketLicenseText.Name = "BucketLicenseText";
            this.BucketLicenseText.Size = new System.Drawing.Size(10, 13);
            this.BucketLicenseText.TabIndex = 4;
            this.BucketLicenseText.Text = "-";
            // 
            // BucketLicenseLabel
            // 
            this.BucketLicenseLabel.AutoSize = true;
            this.BucketLicenseLabel.Location = new System.Drawing.Point(156, 48);
            this.BucketLicenseLabel.Name = "BucketLicenseLabel";
            this.BucketLicenseLabel.Size = new System.Drawing.Size(44, 13);
            this.BucketLicenseLabel.TabIndex = 3;
            this.BucketLicenseLabel.Text = "License";
            // 
            // BucketNameText
            // 
            this.BucketNameText.AutoSize = true;
            this.BucketNameText.Location = new System.Drawing.Point(224, 19);
            this.BucketNameText.Name = "BucketNameText";
            this.BucketNameText.Size = new System.Drawing.Size(10, 13);
            this.BucketNameText.TabIndex = 2;
            this.BucketNameText.Text = "-";
            // 
            // BucketNameLabel
            // 
            this.BucketNameLabel.AutoSize = true;
            this.BucketNameLabel.Location = new System.Drawing.Point(156, 19);
            this.BucketNameLabel.Name = "BucketNameLabel";
            this.BucketNameLabel.Size = new System.Drawing.Size(35, 13);
            this.BucketNameLabel.TabIndex = 1;
            this.BucketNameLabel.Text = "Name";
            // 
            // BucketsList
            // 
            this.BucketsList.FormattingEnabled = true;
            this.BucketsList.Location = new System.Drawing.Point(7, 19);
            this.BucketsList.Name = "BucketsList";
            this.BucketsList.Size = new System.Drawing.Size(142, 186);
            this.BucketsList.TabIndex = 0;
            // 
            // EmulatorsGroup
            // 
            this.EmulatorsGroup.Controls.Add(this.EmulatorsTable);
            this.EmulatorsGroup.Location = new System.Drawing.Point(311, 228);
            this.EmulatorsGroup.Name = "EmulatorsGroup";
            this.EmulatorsGroup.Size = new System.Drawing.Size(566, 168);
            this.EmulatorsGroup.TabIndex = 4;
            this.EmulatorsGroup.TabStop = false;
            this.EmulatorsGroup.Text = "Discovered Emulators";
            // 
            // EmulatorsTable
            // 
            this.EmulatorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmulatorsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Path,
            this.Emulator,
            this.CurrentVersion,
            this.NewVersion});
            this.EmulatorsTable.Location = new System.Drawing.Point(6, 19);
            this.EmulatorsTable.Name = "EmulatorsTable";
            this.EmulatorsTable.Size = new System.Drawing.Size(554, 150);
            this.EmulatorsTable.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.Width = 30;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.Width = 200;
            // 
            // Emulator
            // 
            this.Emulator.HeaderText = "Emulator";
            this.Emulator.Name = "Emulator";
            this.Emulator.Width = 120;
            // 
            // CurrentVersion
            // 
            this.CurrentVersion.HeaderText = "Current Version";
            this.CurrentVersion.Name = "CurrentVersion";
            this.CurrentVersion.Width = 80;
            // 
            // NewVersion
            // 
            this.NewVersion.HeaderText = "New Version";
            this.NewVersion.Name = "NewVersion";
            this.NewVersion.Width = 80;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 411);
            this.Controls.Add(this.EmulatorsGroup);
            this.Controls.Add(this.BucketsGroup);
            this.Controls.Add(this.LogGroup);
            this.Controls.Add(this.PathsGroup);
            this.Name = "MainWindow";
            this.Text = "Emulatest";
            this.PathsGroup.ResumeLayout(false);
            this.LogGroup.ResumeLayout(false);
            this.BucketsGroup.ResumeLayout(false);
            this.BucketsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketLogoImage)).EndInit();
            this.EmulatorsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PathsGroup;
        private System.Windows.Forms.Button ScanPathButton;
        private System.Windows.Forms.Button RemovePathButton;
        private System.Windows.Forms.Button AddPathButton;
        private System.Windows.Forms.ListBox PathsList;
        private System.Windows.Forms.GroupBox LogGroup;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.GroupBox BucketsGroup;
        private System.Windows.Forms.GroupBox EmulatorsGroup;
        private System.Windows.Forms.Label BucketNameLabel;
        private System.Windows.Forms.ListBox BucketsList;
        private System.Windows.Forms.DataGridView EmulatorsTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emulator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewVersion;
        private System.Windows.Forms.Label BucketNameText;
        private System.Windows.Forms.Label BucketHomeText;
        private System.Windows.Forms.Label BucketHomeLabel;
        private System.Windows.Forms.Label BucketLicenseText;
        private System.Windows.Forms.Label BucketLicenseLabel;
        private System.Windows.Forms.Label BucketDescriptionText;
        private System.Windows.Forms.Label BucketDescriptionLabel;
        private System.Windows.Forms.Label BucketVersionText;
        private System.Windows.Forms.Label BucketVersionLabel;
        private System.Windows.Forms.Label BucketsLoadedText;
        private System.Windows.Forms.Label BucketsLoadedLabel;
        private System.Windows.Forms.Label EmulatorsCountText;
        private System.Windows.Forms.Label EmulatorsCountLabel;
        private System.Windows.Forms.Label BucketLogoLabel;
        private System.Windows.Forms.PictureBox BucketLogoImage;
        private System.Windows.Forms.Button UpdateButton;
    }
}

