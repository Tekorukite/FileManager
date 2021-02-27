
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DriveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDriveSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeDriveSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeDriveSpacePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Drives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drives)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Drives
            // 
            this.groupBox_Drives.AutoSize = true;
            this.groupBox_Drives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Drives.Controls.Add(this.dataGridView_Drives);
            this.groupBox_Drives.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Drives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Drives.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Drives.Name = "groupBox_Drives";
            this.groupBox_Drives.Size = new System.Drawing.Size(1006, 71);
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
            this.dataGridView_Drives.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Drives.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_Drives.Name = "dataGridView_Drives";
            this.dataGridView_Drives.ReadOnly = true;
            this.dataGridView_Drives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_Drives.RowTemplate.Height = 24;
            this.dataGridView_Drives.Size = new System.Drawing.Size(1000, 50);
            this.dataGridView_Drives.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.FreeDriveSpacePercent.HeaderText = "Free Drive (%)";
            this.FreeDriveSpacePercent.MinimumWidth = 6;
            this.FreeDriveSpacePercent.Name = "FreeDriveSpacePercent";
            this.FreeDriveSpacePercent.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox_Drives);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Drives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Drives;
        private System.Windows.Forms.DataGridView dataGridView_Drives;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDriveSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeDriveSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeDriveSpacePercent;
    }
}

