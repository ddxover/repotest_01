using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_magic_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RedColor = rnd.Next(0, 256);
            int GreenColor = rnd.Next(0, 256);
            int BlueColor = rnd.Next(0, 256);

            btn_magic.BackColor = Color.FromArgb(RedColor, GreenColor, BlueColor);

            if (BlueColor == 255 & GreenColor == 255 & BlueColor == 255)
            {
                shutdown();
            }
        }

        private void shutdown()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + "shutdown -s -f -t 0";
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
