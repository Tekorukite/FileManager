using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoLibFW
{
    public class Creator
    {
        public Creator()
        {
            this.Name = "David Akhmadeev";
            this.Nickname = "Tekorukite";
            this.Group = "KS-24";
        }
        private string Name { get; set; }
        private string Nickname { get; set; }
        private string Group { get; set; }
        private void ThreadProcMsg()
        {
            MessageBox.Show($"This masterpiece was created by:\n {Nickname} aka {Name} group {Group}");
        }
        public void Show()
        {
            Thread th = new Thread(ThreadProcMsg);
            th.Start();
        }
    }
}
