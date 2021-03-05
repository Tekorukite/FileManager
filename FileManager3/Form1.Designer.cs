
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox_Drives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Drives.Name = "groupBox_Drives";
            this.groupBox_Drives.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Drives.Size = new System.Drawing.Size(748, 75);
            this.groupBox_Drives.TabIndex = 0;
            this.groupBox_Drives.TabStop = false;
            this.groupBox_Drives.Text = "Logical Drives";
            // 
            // dataGridView_Drives
            // 
            this.dataGridView_Drives.AllowUserToAddRows = false;
            this.dataGridView_Drives.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Drives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_Drives.ColumnHeadersHeight = 29;
            this.dataGridView_Drives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Drives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriveName,
            this.DriveType,
            this.FileSystem,
            this.TotalDriveSpace,
            this.FreeDriveSpace,
            this.FreeDriveSpacePercent});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Drives.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_Drives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Drives.Location = new System.Drawing.Point(2, 14);
            this.dataGridView_Drives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Drives.Name = "dataGridView_Drives";
            this.dataGridView_Drives.ReadOnly = true;
            this.dataGridView_Drives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Drives.RowTemplate.Height = 24;
            this.dataGridView_Drives.Size = new System.Drawing.Size(744, 59);
            this.dataGridView_Drives.TabIndex = 0;
            // 
            // DriveName
            // 
            this.DriveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DriveName.DefaultCellStyle = dataGridViewCellStyle23;
            this.DriveName.HeaderText = "Name";
            this.DriveName.MinimumWidth = 6;
            this.DriveName.Name = "DriveName";
            this.DriveName.ReadOnly = true;
            // 
            // DriveType
            // 
            this.DriveType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DriveType.DefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalDriveSpace.DefaultCellStyle = dataGridViewCellStyle25;
            this.TotalDriveSpace.HeaderText = "Total Space";
            this.TotalDriveSpace.MinimumWidth = 6;
            this.TotalDriveSpace.Name = "TotalDriveSpace";
            this.TotalDriveSpace.ReadOnly = true;
            // 
            // FreeDriveSpace
            // 
            this.FreeDriveSpace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FreeDriveSpace.DefaultCellStyle = dataGridViewCellStyle26;
            this.FreeDriveSpace.HeaderText = "Free Space";
            this.FreeDriveSpace.MinimumWidth = 6;
            this.FreeDriveSpace.Name = "FreeDriveSpace";
            this.FreeDriveSpace.ReadOnly = true;
            // 
            // FreeDriveSpacePercent
            // 
            this.FreeDriveSpacePercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FreeDriveSpacePercent.DefaultCellStyle = dataGridViewCellStyle27;
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
            this.button_Delete.Location = new System.Drawing.Point(609, 567);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(60, 20);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.TabStop = false;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Quit.Location = new System.Drawing.Point(685, 523);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(60, 64);
            this.button_Quit.TabIndex = 3;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            // 
            // button_Copy
            // 
            this.button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Copy.Location = new System.Drawing.Point(609, 479);
            this.button_Copy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(60, 40);
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
            this.splitContainer1.Location = new System.Drawing.Point(-3, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(748, 465);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.splitContainer2.Size = new System.Drawing.Size(748, 387);
            this.splitContainer2.SplitterDistance = 247;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_SourceFiles
            // 
            this.label_SourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SourceFiles.AutoSize = true;
            this.label_SourceFiles.BackColor = System.Drawing.SystemColors.Menu;
            this.label_SourceFiles.Location = new System.Drawing.Point(2, 373);
            this.label_SourceFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SourceFiles.Name = "label_SourceFiles";
            this.label_SourceFiles.Size = new System.Drawing.Size(65, 13);
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
            this.treeView1_SourceFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1_SourceFiles.Name = "treeView1_SourceFiles";
            this.treeView1_SourceFiles.SelectedImageIndex = 0;
            this.treeView1_SourceFiles.Size = new System.Drawing.Size(247, 387);
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
            this.label1.Location = new System.Drawing.Point(1, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Directory";
            // 
            // treeView_TargetDir
            // 
            this.treeView_TargetDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TargetDir.Location = new System.Drawing.Point(0, 20);
            this.treeView_TargetDir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.treeView_TargetDir.Name = "treeView_TargetDir";
            this.treeView_TargetDir.Size = new System.Drawing.Size(498, 367);
            this.treeView_TargetDir.TabIndex = 3;
            this.treeView_TargetDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_TargetDir_AfterSelect);
            // 
            // textBox_TargetDir
            // 
            this.textBox_TargetDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_TargetDir.Location = new System.Drawing.Point(0, 0);
            this.textBox_TargetDir.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_TargetDir.Name = "textBox_TargetDir";
            this.textBox_TargetDir.Size = new System.Drawing.Size(498, 20);
            this.textBox_TargetDir.TabIndex = 2;
            // 
            // label_TargetDir
            // 
            this.label_TargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TargetDir.AutoSize = true;
            this.label_TargetDir.Location = new System.Drawing.Point(1, 373);
            this.label_TargetDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TargetDir.Name = "label_TargetDir";
            this.label_TargetDir.Size = new System.Drawing.Size(83, 13);
            this.label_TargetDir.TabIndex = 1;
            this.label_TargetDir.Text = "Target Directory";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Refresh.Location = new System.Drawing.Point(2, 479);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(60, 40);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "Clear";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Move
            // 
            this.button_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Move.Location = new System.Drawing.Point(609, 523);
            this.button_Move.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Move.Name = "button_Move";
            this.button_Move.Size = new System.Drawing.Size(60, 40);
            this.button_Move.TabIndex = 7;
            this.button_Move.Text = "Move";
            this.button_Move.UseVisualStyleBackColor = true;
            this.button_Move.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // checkBox_Overwrite
            // 
            this.checkBox_Overwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Overwrite.AutoSize = true;
            this.checkBox_Overwrite.Location = new System.Drawing.Point(497, 492);
            this.checkBox_Overwrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_Overwrite.Name = "checkBox_Overwrite";
            this.checkBox_Overwrite.Size = new System.Drawing.Size(108, 17);
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
            this.textBox_Status.Location = new System.Drawing.Point(2, 567);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(602, 20);
            this.textBox_Status.TabIndex = 9;
            this.textBox_Status.Text = "Status";
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 592);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.checkBox_Overwrite);
            this.Controls.Add(this.button_Move);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Delete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(771, 630);
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
    }
}

