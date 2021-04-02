
namespace FileManager3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Drives = new System.Windows.Forms.GroupBox();
            this.dataGridView_Drives = new System.Windows.Forms.DataGridView();
            this.DriveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDriveSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeDriveSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeDriveSpacePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Copy = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_SourceFiles = new System.Windows.Forms.Label();
            this.treeView1_SourceFiles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.treeView_TargetDir = new System.Windows.Forms.TreeView();
            this.textBox_TargetDir = new System.Windows.Forms.TextBox();
            this.label_TargetDir = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Move = new System.Windows.Forms.Button();
            this.checkBox_Overwrite = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button_Info = new System.Windows.Forms.Button();
            this.groupBox_Drives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Drives
            // 
            this.groupBox_Drives.AutoSize = true;
            this.groupBox_Drives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Drives.Controls.Add(this.dataGridView_Drives);
            this.groupBox_Drives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Drives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Drives.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Drives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Drives.Name = "groupBox_Drives";
            this.groupBox_Drives.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Drives.Size = new System.Drawing.Size(997, 92);
            this.groupBox_Drives.TabIndex = 0;
            this.groupBox_Drives.TabStop = false;
            this.groupBox_Drives.Text = "Logical Drives";
            // 
            // dataGridView_Drives
            // 
            this.dataGridView_Drives.AllowUserToAddRows = false;
            this.dataGridView_Drives.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Drives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Drives.ColumnHeadersHeight = 29;
            this.dataGridView_Drives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Drives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriveName,
            this.DriveType,
            this.FileSystem,
            this.TotalDriveSpace,
            this.FreeDriveSpace,
            this.FreeDriveSpacePercent});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Drives.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Drives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Drives.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_Drives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Drives.Name = "dataGridView_Drives";
            this.dataGridView_Drives.ReadOnly = true;
            this.dataGridView_Drives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Drives.RowTemplate.Height = 24;
            this.dataGridView_Drives.Size = new System.Drawing.Size(991, 73);
            this.dataGridView_Drives.TabIndex = 0;
            // 
            // DriveName
            // 
            this.DriveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DriveName.DefaultCellStyle = dataGridViewCellStyle2;
            this.DriveName.HeaderText = "Name";
            this.DriveName.MinimumWidth = 6;
            this.DriveName.Name = "DriveName";
            this.DriveName.ReadOnly = true;
            // 
            // DriveType
            // 
            this.DriveType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DriveType.DefaultCellStyle = dataGridViewCellStyle3;
            this.DriveType.HeaderText = "Type";
            this.DriveType.MinimumWidth = 6;
            this.DriveType.Name = "DriveType";
            this.DriveType.ReadOnly = true;
            // 
            // FileSystem
            // 
            this.FileSystem.HeaderText = "Filesystem";
            this.FileSystem.MinimumWidth = 6;
            this.FileSystem.Name = "FileSystem";
            this.FileSystem.ReadOnly = true;
            this.FileSystem.Width = 125;
            // 
            // TotalDriveSpace
            // 
            this.TotalDriveSpace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalDriveSpace.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalDriveSpace.HeaderText = "Total Space";
            this.TotalDriveSpace.MinimumWidth = 6;
            this.TotalDriveSpace.Name = "TotalDriveSpace";
            this.TotalDriveSpace.ReadOnly = true;
            // 
            // FreeDriveSpace
            // 
            this.FreeDriveSpace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FreeDriveSpace.DefaultCellStyle = dataGridViewCellStyle5;
            this.FreeDriveSpace.HeaderText = "Free Space";
            this.FreeDriveSpace.MinimumWidth = 6;
            this.FreeDriveSpace.Name = "FreeDriveSpace";
            this.FreeDriveSpace.ReadOnly = true;
            // 
            // FreeDriveSpacePercent
            // 
            this.FreeDriveSpacePercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FreeDriveSpacePercent.DefaultCellStyle = dataGridViewCellStyle6;
            this.FreeDriveSpacePercent.HeaderText = "Free Space (%)";
            this.FreeDriveSpacePercent.MinimumWidth = 6;
            this.FreeDriveSpacePercent.Name = "FreeDriveSpacePercent";
            this.FreeDriveSpacePercent.ReadOnly = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(812, 698);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(80, 25);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.TabStop = false;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Quit.Location = new System.Drawing.Point(913, 644);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(80, 79);
            this.button_Quit.TabIndex = 3;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Copy
            // 
            this.button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Copy.Location = new System.Drawing.Point(812, 590);
            this.button_Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(80, 49);
            this.button_Copy.TabIndex = 4;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-4, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Drives);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 572);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label_SourceFiles);
            this.splitContainer2.Panel1.Controls.Add(this.treeView1_SourceFiles);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.treeView_TargetDir);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_TargetDir);
            this.splitContainer2.Panel2.Controls.Add(this.label_TargetDir);
            this.splitContainer2.Size = new System.Drawing.Size(997, 476);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_SourceFiles
            // 
            this.label_SourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SourceFiles.AutoSize = true;
            this.label_SourceFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.label_SourceFiles.Location = new System.Drawing.Point(3, 459);
            this.label_SourceFiles.Name = "label_SourceFiles";
            this.label_SourceFiles.Size = new System.Drawing.Size(86, 17);
            this.label_SourceFiles.TabIndex = 1;
            this.label_SourceFiles.Text = "Source Files";
            // 
            // treeView1_SourceFiles
            // 
            this.treeView1_SourceFiles.CheckBoxes = true;
            this.treeView1_SourceFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1_SourceFiles.ImageIndex = 0;
            this.treeView1_SourceFiles.ImageList = this.imageList1;
            this.treeView1_SourceFiles.Location = new System.Drawing.Point(0, 0);
            this.treeView1_SourceFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1_SourceFiles.Name = "treeView1_SourceFiles";
            this.treeView1_SourceFiles.SelectedImageIndex = 0;
            this.treeView1_SourceFiles.Size = new System.Drawing.Size(329, 476);
            this.treeView1_SourceFiles.TabIndex = 0;
            this.treeView1_SourceFiles.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_SourceFiles_BeforeCheck);
            this.treeView1_SourceFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_SourceFiles_AfterCheck);
            this.treeView1_SourceFiles.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_SourceFiles_AfterExpand);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder");
            this.imageList1.Images.SetKeyName(1, "file");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Directory";
            // 
            // treeView_TargetDir
            // 
            this.treeView_TargetDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TargetDir.Location = new System.Drawing.Point(0, 22);
            this.treeView_TargetDir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.treeView_TargetDir.Name = "treeView_TargetDir";
            this.treeView_TargetDir.Size = new System.Drawing.Size(664, 454);
            this.treeView_TargetDir.TabIndex = 3;
            this.treeView_TargetDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_TargetDir_AfterSelect);
            // 
            // textBox_TargetDir
            // 
            this.textBox_TargetDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_TargetDir.Location = new System.Drawing.Point(0, 0);
            this.textBox_TargetDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.textBox_TargetDir.Name = "textBox_TargetDir";
            this.textBox_TargetDir.Size = new System.Drawing.Size(664, 22);
            this.textBox_TargetDir.TabIndex = 2;
            // 
            // label_TargetDir
            // 
            this.label_TargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TargetDir.AutoSize = true;
            this.label_TargetDir.Location = new System.Drawing.Point(1, 459);
            this.label_TargetDir.Name = "label_TargetDir";
            this.label_TargetDir.Size = new System.Drawing.Size(111, 17);
            this.label_TargetDir.TabIndex = 1;
            this.label_TargetDir.Text = "Target Directory";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Refresh.Location = new System.Drawing.Point(3, 590);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(80, 49);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "Clear";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Move
            // 
            this.button_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Move.Location = new System.Drawing.Point(812, 644);
            this.button_Move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Move.Name = "button_Move";
            this.button_Move.Size = new System.Drawing.Size(80, 49);
            this.button_Move.TabIndex = 7;
            this.button_Move.Text = "Move";
            this.button_Move.UseVisualStyleBackColor = true;
            this.button_Move.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // checkBox_Overwrite
            // 
            this.checkBox_Overwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Overwrite.AutoSize = true;
            this.checkBox_Overwrite.Location = new System.Drawing.Point(667, 606);
            this.checkBox_Overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Overwrite.Name = "checkBox_Overwrite";
            this.checkBox_Overwrite.Size = new System.Drawing.Size(140, 21);
            this.checkBox_Overwrite.TabIndex = 8;
            this.checkBox_Overwrite.Text = "Overwrite if exists";
            this.checkBox_Overwrite.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Status.Location = new System.Drawing.Point(3, 698);
            this.textBox_Status.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(801, 22);
            this.textBox_Status.TabIndex = 9;
            this.textBox_Status.Text = "Status";
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(899, 598);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(95, 28);
            this.progressBar.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(3, 644);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(80, 47);
            this.button_Info.TabIndex = 12;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.checkBox_Overwrite);
            this.Controls.Add(this.button_Move);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1022, 765);
            this.Name = "Form1";
            this.Text = "OrthodoxFileManager";
            this.groupBox_Drives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drives)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Drives;
        private System.Windows.Forms.DataGridView dataGridView_Drives;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Move;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDriveSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeDriveSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeDriveSpacePercent;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1_SourceFiles;
        private System.Windows.Forms.Label label_SourceFiles;
        private System.Windows.Forms.Label label_TargetDir;
        private System.Windows.Forms.CheckBox checkBox_Overwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView_TargetDir;
        private System.Windows.Forms.TextBox textBox_TargetDir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_Info;
    }
}

