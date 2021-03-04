using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManager3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView(dataGridView_Drives);
            

        }

        static void PopulateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            DriveInfo[] Drives = DriveInfo.GetDrives();
            int height = 29;
            foreach (DriveInfo drive in Drives)
            {
                string[] row = {drive.Name, drive.DriveType.ToString(), drive.DriveFormat, (ToGiB(drive.TotalSize)).ToString() + " GiB", 
                    ToGiB(drive.TotalFreeSpace).ToString() + " GiB", (drive.TotalFreeSpace * 100 / drive.TotalSize).ToString()};
                dataGridView.Rows.Add(row);
                height += 25;
            }
            dataGridView.Height = height;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            PopulateDataGridView(dataGridView_Drives);
            
        }

        static double ToGiB(long bytes)
        {
            return ((bytes / (long)1e7) / 100.0);
        }
    }

    
}
