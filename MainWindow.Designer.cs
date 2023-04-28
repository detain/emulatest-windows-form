namespace EmulatestApp
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.LogGroup = new System.Windows.Forms.GroupBox();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.PathsGroup = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ScanPathButton = new System.Windows.Forms.Button();
            this.RemovePathButton = new System.Windows.Forms.Button();
            this.AddPathButton = new System.Windows.Forms.Button();
            this.PathsList = new System.Windows.Forms.ListBox();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.BucketsGroup = new System.Windows.Forms.GroupBox();
            this.BucketsTable = new System.Windows.Forms.TableLayoutPanel();
            this.BucketsList = new System.Windows.Forms.ListBox();
            this.BucketLogoImage = new System.Windows.Forms.PictureBox();
            this.BucketDescriptionText = new System.Windows.Forms.TextBox();
            this.BucketsLoadedLabel = new System.Windows.Forms.Label();
            this.BucketLogoLabel = new System.Windows.Forms.Label();
            this.BucketsLoadedText = new System.Windows.Forms.Label();
            this.EmulatorsCountLabel = new System.Windows.Forms.Label();
            this.BucketDescriptionLabel = new System.Windows.Forms.Label();
            this.EmulatorsCountText = new System.Windows.Forms.Label();
            this.BucketNameLabel = new System.Windows.Forms.Label();
            this.BucketLicenseLabel = new System.Windows.Forms.Label();
            this.BucketHomeLabel = new System.Windows.Forms.Label();
            this.BucketVersionLabel = new System.Windows.Forms.Label();
            this.BucketVersionText = new System.Windows.Forms.Label();
            this.BucketHomeText = new System.Windows.Forms.Label();
            this.BucketLicenseText = new System.Windows.Forms.Label();
            this.BucketNameText = new System.Windows.Forms.Label();
            this.EmulatorsGroup = new System.Windows.Forms.GroupBox();
            this.EmulatorsTable = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emulator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.LogGroup.SuspendLayout();
            this.PathsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.BucketsGroup.SuspendLayout();
            this.BucketsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketLogoImage)).BeginInit();
            this.EmulatorsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(5, 5);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Size = new System.Drawing.Size(1116, 516);
            this.splitContainerMain.SplitterDistance = 370;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.LogGroup);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.PathsGroup);
            this.splitContainerLeft.Size = new System.Drawing.Size(370, 516);
            this.splitContainerLeft.SplitterDistance = 239;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // LogGroup
            // 
            this.LogGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogGroup.Controls.Add(this.LogText);
            this.LogGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogGroup.Location = new System.Drawing.Point(0, 0);
            this.LogGroup.Name = "LogGroup";
            this.LogGroup.Size = new System.Drawing.Size(370, 239);
            this.LogGroup.TabIndex = 3;
            this.LogGroup.TabStop = false;
            this.LogGroup.Text = "Log";
            // 
            // LogText
            // 
            this.LogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogText.Location = new System.Drawing.Point(3, 16);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(364, 220);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "";
            // 
            // PathsGroup
            // 
            this.PathsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathsGroup.Controls.Add(this.LoadButton);
            this.PathsGroup.Controls.Add(this.SaveButton);
            this.PathsGroup.Controls.Add(this.UpdateButton);
            this.PathsGroup.Controls.Add(this.ScanPathButton);
            this.PathsGroup.Controls.Add(this.RemovePathButton);
            this.PathsGroup.Controls.Add(this.AddPathButton);
            this.PathsGroup.Controls.Add(this.PathsList);
            this.PathsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathsGroup.Location = new System.Drawing.Point(0, 0);
            this.PathsGroup.Name = "PathsGroup";
            this.PathsGroup.Size = new System.Drawing.Size(370, 273);
            this.PathsGroup.TabIndex = 2;
            this.PathsGroup.TabStop = false;
            this.PathsGroup.Text = "Scan Paths";
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(281, 163);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(82, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load Config";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(281, 133);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save Config";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(281, 103);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(83, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Run Updates";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ScanPathButton
            // 
            this.ScanPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanPathButton.Location = new System.Drawing.Point(280, 73);
            this.ScanPathButton.Name = "ScanPathButton";
            this.ScanPathButton.Size = new System.Drawing.Size(84, 23);
            this.ScanPathButton.TabIndex = 3;
            this.ScanPathButton.Text = "Scan Paths";
            this.ScanPathButton.UseVisualStyleBackColor = true;
            // 
            // RemovePathButton
            // 
            this.RemovePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePathButton.Location = new System.Drawing.Point(280, 44);
            this.RemovePathButton.Name = "RemovePathButton";
            this.RemovePathButton.Size = new System.Drawing.Size(84, 23);
            this.RemovePathButton.TabIndex = 2;
            this.RemovePathButton.Text = "Remove Path";
            this.RemovePathButton.UseVisualStyleBackColor = true;
            // 
            // AddPathButton
            // 
            this.AddPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPathButton.Location = new System.Drawing.Point(280, 15);
            this.AddPathButton.Name = "AddPathButton";
            this.AddPathButton.Size = new System.Drawing.Size(84, 23);
            this.AddPathButton.TabIndex = 1;
            this.AddPathButton.Text = "Add Path";
            this.AddPathButton.UseVisualStyleBackColor = true;
            // 
            // PathsList
            // 
            this.PathsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathsList.FormattingEnabled = true;
            this.PathsList.Location = new System.Drawing.Point(3, 16);
            this.PathsList.Name = "PathsList";
            this.PathsList.Size = new System.Drawing.Size(275, 251);
            this.PathsList.TabIndex = 0;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.BucketsGroup);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.EmulatorsGroup);
            this.splitContainerRight.Size = new System.Drawing.Size(742, 516);
            this.splitContainerRight.SplitterDistance = 254;
            this.splitContainerRight.TabIndex = 0;
            // 
            // BucketsGroup
            // 
            this.BucketsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BucketsGroup.Controls.Add(this.BucketsTable);
            this.BucketsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BucketsGroup.Location = new System.Drawing.Point(0, 0);
            this.BucketsGroup.Name = "BucketsGroup";
            this.BucketsGroup.Size = new System.Drawing.Size(742, 254);
            this.BucketsGroup.TabIndex = 4;
            this.BucketsGroup.TabStop = false;
            this.BucketsGroup.Text = "Emulators Database";
            // 
            // BucketsTable
            // 
            this.BucketsTable.ColumnCount = 5;
            this.BucketsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.BucketsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.BucketsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.BucketsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.BucketsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.BucketsTable.Controls.Add(this.BucketsList, 0, 0);
            this.BucketsTable.Controls.Add(this.BucketLogoImage, 4, 3);
            this.BucketsTable.Controls.Add(this.BucketDescriptionText, 4, 0);
            this.BucketsTable.Controls.Add(this.BucketsLoadedLabel, 1, 5);
            this.BucketsTable.Controls.Add(this.BucketLogoLabel, 3, 3);
            this.BucketsTable.Controls.Add(this.BucketsLoadedText, 2, 5);
            this.BucketsTable.Controls.Add(this.EmulatorsCountLabel, 1, 4);
            this.BucketsTable.Controls.Add(this.BucketDescriptionLabel, 3, 0);
            this.BucketsTable.Controls.Add(this.EmulatorsCountText, 2, 4);
            this.BucketsTable.Controls.Add(this.BucketNameLabel, 1, 0);
            this.BucketsTable.Controls.Add(this.BucketLicenseLabel, 1, 1);
            this.BucketsTable.Controls.Add(this.BucketHomeLabel, 1, 2);
            this.BucketsTable.Controls.Add(this.BucketVersionLabel, 1, 3);
            this.BucketsTable.Controls.Add(this.BucketVersionText, 2, 3);
            this.BucketsTable.Controls.Add(this.BucketHomeText, 2, 2);
            this.BucketsTable.Controls.Add(this.BucketLicenseText, 2, 1);
            this.BucketsTable.Controls.Add(this.BucketNameText, 2, 0);
            this.BucketsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BucketsTable.Location = new System.Drawing.Point(3, 16);
            this.BucketsTable.Name = "BucketsTable";
            this.BucketsTable.RowCount = 6;
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BucketsTable.Size = new System.Drawing.Size(736, 235);
            this.BucketsTable.TabIndex = 18;
            // 
            // BucketsList
            // 
            this.BucketsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BucketsList.FormattingEnabled = true;
            this.BucketsList.Location = new System.Drawing.Point(3, 3);
            this.BucketsList.Name = "BucketsList";
            this.BucketsTable.SetRowSpan(this.BucketsList, 6);
            this.BucketsList.Size = new System.Drawing.Size(139, 229);
            this.BucketsList.TabIndex = 0;
            // 
            // BucketLogoImage
            // 
            this.BucketLogoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BucketLogoImage.Location = new System.Drawing.Point(480, 120);
            this.BucketLogoImage.Name = "BucketLogoImage";
            this.BucketsTable.SetRowSpan(this.BucketLogoImage, 3);
            this.BucketLogoImage.Size = new System.Drawing.Size(253, 112);
            this.BucketLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BucketLogoImage.TabIndex = 15;
            this.BucketLogoImage.TabStop = false;
            // 
            // BucketDescriptionText
            // 
            this.BucketDescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BucketDescriptionText.Location = new System.Drawing.Point(480, 3);
            this.BucketDescriptionText.Multiline = true;
            this.BucketDescriptionText.Name = "BucketDescriptionText";
            this.BucketDescriptionText.ReadOnly = true;
            this.BucketsTable.SetRowSpan(this.BucketDescriptionText, 3);
            this.BucketDescriptionText.Size = new System.Drawing.Size(253, 111);
            this.BucketDescriptionText.TabIndex = 17;
            // 
            // BucketsLoadedLabel
            // 
            this.BucketsLoadedLabel.AutoSize = true;
            this.BucketsLoadedLabel.Location = new System.Drawing.Point(148, 195);
            this.BucketsLoadedLabel.Name = "BucketsLoadedLabel";
            this.BucketsLoadedLabel.Size = new System.Drawing.Size(56, 13);
            this.BucketsLoadedLabel.TabIndex = 9;
            this.BucketsLoadedLabel.Text = "# Buckets";
            // 
            // BucketLogoLabel
            // 
            this.BucketLogoLabel.AutoSize = true;
            this.BucketLogoLabel.Location = new System.Drawing.Point(400, 117);
            this.BucketLogoLabel.Name = "BucketLogoLabel";
            this.BucketLogoLabel.Size = new System.Drawing.Size(31, 13);
            this.BucketLogoLabel.TabIndex = 16;
            this.BucketLogoLabel.Text = "Logo";
            // 
            // BucketsLoadedText
            // 
            this.BucketsLoadedText.AutoSize = true;
            this.BucketsLoadedText.Location = new System.Drawing.Point(228, 195);
            this.BucketsLoadedText.Name = "BucketsLoadedText";
            this.BucketsLoadedText.Size = new System.Drawing.Size(13, 13);
            this.BucketsLoadedText.TabIndex = 10;
            this.BucketsLoadedText.Text = "0";
            // 
            // EmulatorsCountLabel
            // 
            this.EmulatorsCountLabel.AutoSize = true;
            this.EmulatorsCountLabel.Location = new System.Drawing.Point(148, 156);
            this.EmulatorsCountLabel.Name = "EmulatorsCountLabel";
            this.EmulatorsCountLabel.Size = new System.Drawing.Size(63, 13);
            this.EmulatorsCountLabel.TabIndex = 7;
            this.EmulatorsCountLabel.Text = "# Emulators";
            // 
            // BucketDescriptionLabel
            // 
            this.BucketDescriptionLabel.AutoSize = true;
            this.BucketDescriptionLabel.Location = new System.Drawing.Point(400, 0);
            this.BucketDescriptionLabel.Name = "BucketDescriptionLabel";
            this.BucketDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.BucketDescriptionLabel.TabIndex = 13;
            this.BucketDescriptionLabel.Text = "Description";
            // 
            // EmulatorsCountText
            // 
            this.EmulatorsCountText.AutoSize = true;
            this.EmulatorsCountText.Location = new System.Drawing.Point(228, 156);
            this.EmulatorsCountText.Name = "EmulatorsCountText";
            this.EmulatorsCountText.Size = new System.Drawing.Size(13, 13);
            this.EmulatorsCountText.TabIndex = 8;
            this.EmulatorsCountText.Text = "0";
            // 
            // BucketNameLabel
            // 
            this.BucketNameLabel.AutoSize = true;
            this.BucketNameLabel.Location = new System.Drawing.Point(148, 0);
            this.BucketNameLabel.Name = "BucketNameLabel";
            this.BucketNameLabel.Size = new System.Drawing.Size(35, 13);
            this.BucketNameLabel.TabIndex = 1;
            this.BucketNameLabel.Text = "Name";
            // 
            // BucketLicenseLabel
            // 
            this.BucketLicenseLabel.AutoSize = true;
            this.BucketLicenseLabel.Location = new System.Drawing.Point(148, 39);
            this.BucketLicenseLabel.Name = "BucketLicenseLabel";
            this.BucketLicenseLabel.Size = new System.Drawing.Size(44, 13);
            this.BucketLicenseLabel.TabIndex = 3;
            this.BucketLicenseLabel.Text = "License";
            // 
            // BucketHomeLabel
            // 
            this.BucketHomeLabel.AutoSize = true;
            this.BucketHomeLabel.Location = new System.Drawing.Point(148, 78);
            this.BucketHomeLabel.Name = "BucketHomeLabel";
            this.BucketHomeLabel.Size = new System.Drawing.Size(63, 13);
            this.BucketHomeLabel.TabIndex = 5;
            this.BucketHomeLabel.Text = "Home Page";
            // 
            // BucketVersionLabel
            // 
            this.BucketVersionLabel.AutoSize = true;
            this.BucketVersionLabel.Location = new System.Drawing.Point(148, 117);
            this.BucketVersionLabel.Name = "BucketVersionLabel";
            this.BucketVersionLabel.Size = new System.Drawing.Size(42, 13);
            this.BucketVersionLabel.TabIndex = 11;
            this.BucketVersionLabel.Text = "Version";
            // 
            // BucketVersionText
            // 
            this.BucketVersionText.AutoSize = true;
            this.BucketVersionText.Location = new System.Drawing.Point(228, 117);
            this.BucketVersionText.Name = "BucketVersionText";
            this.BucketVersionText.Size = new System.Drawing.Size(13, 13);
            this.BucketVersionText.TabIndex = 12;
            this.BucketVersionText.Text = "v";
            // 
            // BucketHomeText
            // 
            this.BucketHomeText.AutoSize = true;
            this.BucketHomeText.Location = new System.Drawing.Point(228, 78);
            this.BucketHomeText.Name = "BucketHomeText";
            this.BucketHomeText.Size = new System.Drawing.Size(38, 13);
            this.BucketHomeText.TabIndex = 6;
            this.BucketHomeText.Text = "http://";
            // 
            // BucketLicenseText
            // 
            this.BucketLicenseText.AutoSize = true;
            this.BucketLicenseText.Location = new System.Drawing.Point(228, 39);
            this.BucketLicenseText.Name = "BucketLicenseText";
            this.BucketLicenseText.Size = new System.Drawing.Size(53, 13);
            this.BucketLicenseText.TabIndex = 4;
            this.BucketLicenseText.Text = "Unknown";
            // 
            // BucketNameText
            // 
            this.BucketNameText.AutoSize = true;
            this.BucketNameText.Location = new System.Drawing.Point(228, 0);
            this.BucketNameText.Name = "BucketNameText";
            this.BucketNameText.Size = new System.Drawing.Size(74, 13);
            this.BucketNameText.TabIndex = 2;
            this.BucketNameText.Text = "none selected";
            // 
            // EmulatorsGroup
            // 
            this.EmulatorsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmulatorsGroup.Controls.Add(this.EmulatorsTable);
            this.EmulatorsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmulatorsGroup.Location = new System.Drawing.Point(0, 0);
            this.EmulatorsGroup.Name = "EmulatorsGroup";
            this.EmulatorsGroup.Size = new System.Drawing.Size(742, 258);
            this.EmulatorsGroup.TabIndex = 5;
            this.EmulatorsGroup.TabStop = false;
            this.EmulatorsGroup.Text = "Discovered Emulators";
            // 
            // EmulatorsTable
            // 
            this.EmulatorsTable.AllowUserToOrderColumns = true;
            this.EmulatorsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmulatorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmulatorsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Path,
            this.Emulator,
            this.CurrentVersion,
            this.NewVersion});
            this.EmulatorsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmulatorsTable.Location = new System.Drawing.Point(3, 16);
            this.EmulatorsTable.Name = "EmulatorsTable";
            this.EmulatorsTable.Size = new System.Drawing.Size(736, 239);
            this.EmulatorsTable.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FillWeight = 10F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            // 
            // Path
            // 
            this.Path.FillWeight = 40F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Emulator
            // 
            this.Emulator.FillWeight = 20F;
            this.Emulator.HeaderText = "Emulator";
            this.Emulator.Name = "Emulator";
            this.Emulator.ReadOnly = true;
            // 
            // CurrentVersion
            // 
            this.CurrentVersion.FillWeight = 15F;
            this.CurrentVersion.HeaderText = "Current Version";
            this.CurrentVersion.Name = "CurrentVersion";
            this.CurrentVersion.ReadOnly = true;
            // 
            // NewVersion
            // 
            this.NewVersion.FillWeight = 15F;
            this.NewVersion.HeaderText = "New Version";
            this.NewVersion.Name = "NewVersion";
            this.NewVersion.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1126, 526);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "EmuLatest";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.LogGroup.ResumeLayout(false);
            this.PathsGroup.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.BucketsGroup.ResumeLayout(false);
            this.BucketsTable.ResumeLayout(false);
            this.BucketsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BucketLogoImage)).EndInit();
            this.EmulatorsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmulatorsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox LogGroup;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.GroupBox PathsGroup;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ScanPathButton;
        private System.Windows.Forms.Button RemovePathButton;
        private System.Windows.Forms.Button AddPathButton;
        private System.Windows.Forms.ListBox PathsList;
        private System.Windows.Forms.GroupBox EmulatorsGroup;
        private System.Windows.Forms.DataGridView EmulatorsTable;
        private System.Windows.Forms.GroupBox BucketsGroup;
        private System.Windows.Forms.TextBox BucketDescriptionText;
        private System.Windows.Forms.Label BucketLogoLabel;
        private System.Windows.Forms.PictureBox BucketLogoImage;
        private System.Windows.Forms.Label BucketDescriptionLabel;
        private System.Windows.Forms.Label BucketVersionText;
        private System.Windows.Forms.Label BucketVersionLabel;
        private System.Windows.Forms.Label BucketsLoadedText;
        private System.Windows.Forms.Label BucketsLoadedLabel;
        private System.Windows.Forms.Label EmulatorsCountText;
        private System.Windows.Forms.Label EmulatorsCountLabel;
        private System.Windows.Forms.Label BucketHomeText;
        private System.Windows.Forms.Label BucketHomeLabel;
        private System.Windows.Forms.Label BucketLicenseText;
        private System.Windows.Forms.Label BucketLicenseLabel;
        private System.Windows.Forms.Label BucketNameText;
        private System.Windows.Forms.Label BucketNameLabel;
        private System.Windows.Forms.TableLayoutPanel BucketsTable;
        private System.Windows.Forms.ListBox BucketsList;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emulator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewVersion;
    }
}
