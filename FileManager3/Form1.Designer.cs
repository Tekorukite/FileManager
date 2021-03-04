
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
            this.treeView1_left = new System.Windows.Forms.TreeView();
            this.treeViewr_right = new System.Windows.Forms.TreeView();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Move = new System.Windows.Forms.Button();
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
            this.groupBox_Drives.Name = "groupBox_Drives";
            this.groupBox_Drives.Size = new System.Drawing.Size(998, 100);
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
            this.dataGridView_Drives.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_Drives.Name = "dataGridView_Drives";
            this.dataGridView_Drives.ReadOnly = true;
            this.dataGridView_Drives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Drives.RowTemplate.Height = 24;
            this.dataGridView_Drives.Size = new System.Drawing.Size(992, 79);
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
            this.button_Delete.Location = new System.Drawing.Point(919, 628);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Quit
            // 
            this.button_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Quit.Location = new System.Drawing.Point(919, 657);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 52);
            this.button_Quit.TabIndex = 3;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            // 
            // button_Copy
            // 
            this.button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Copy.Location = new System.Drawing.Point(618, 628);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(78, 46);
            this.button_Copy.TabIndex = 4;
            this.button_Copy.Text = "Copy";
            this.button_Copy.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-4, 12);
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
            this.splitContainer1.Size = new System.Drawing.Size(998, 610);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1_left);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeViewr_right);
            this.splitContainer2.Size = new System.Drawing.Size(998, 506);
            this.splitContainer2.SplitterDistance = 332;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1_left
            // 
            this.treeView1_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1_left.Location = new System.Drawing.Point(0, 0);
            this.treeView1_left.Name = "treeView1_left";
            this.treeView1_left.Size = new System.Drawing.Size(332, 506);
            this.treeView1_left.TabIndex = 0;
            // 
            // treeViewr_right
            // 
            this.treeViewr_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewr_right.Location = new System.Drawing.Point(0, 0);
            this.treeViewr_right.Name = "treeViewr_right";
            this.treeViewr_right.Size = new System.Drawing.Size(662, 506);
            this.treeViewr_right.TabIndex = 0;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Refresh.Location = new System.Drawing.Point(12, 628);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(82, 46);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // button_Move
            // 
            this.button_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Move.Location = new System.Drawing.Point(769, 628);
            this.button_Move.Name = "button_Move";
            this.button_Move.Size = new System.Drawing.Size(81, 46);
            this.button_Move.TabIndex = 7;
            this.button_Move.Text = "Move";
            this.button_Move.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button_Move);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Delete);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
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
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TreeView treeView1_left;
        private System.Windows.Forms.TreeView treeViewr_right;
    }
}

