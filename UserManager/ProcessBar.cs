using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManager
{
    public partial class ProcessBar : Form
    {
        public ProcessBar()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            InitializeRAMCounter();
        }
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        int maxRam;
        private void Form2_Load(object sender, EventArgs e)
        {
            RamMax();
            BackColor = Color.DarkCyan;
            TransparencyKey = Color.Blue;
            this.TopMost = true;
            TransparentForm();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top + scrn.WorkingArea.Height / 2);
                    this.TopMost = true;
                    return;
                }
            }
            GetInfo();
        }
        void TransparentForm()
        {
            float fontSize = 12;
            lblCPU.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            lblRam.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            lblCPU.ForeColor = Color.White;
            lblRam.ForeColor = Color.White;
        }
        private void GetInfo()
        {
            int cpu = Convert.ToInt32(cpuCounter.NextValue());
            int ram = Convert.ToInt32(ramCounter.NextValue());
            int ramused = maxRam - ram;
            int ramPercent = (int)((ramused * 1.0 / maxRam) * 100);
            lblCPU.Text = "CPU: " + cpu + "%";
            lblRam.Text = "RAM: " + ramused + " MB (" + ramPercent + "%) ";
            pcbCPU.Value = (int)cpu;
            pcbRAM.Value = ramPercent;
            if (cpu > 90)
            {
                pcbCPU.ProgressColor = Color.Red;
            }
            else
            {
                if (cpu > 70) pcbCPU.ProgressColor = Color.OrangeRed;
                else
                {
                    if (cpu > 40) pcbCPU.ProgressColor = Color.Salmon;
                    else
                        pcbCPU.ProgressColor = Color.Lime;
                }
            }
            if (ramPercent > 80)
            {
                pcbRAM.ProgressColor = Color.Red;
            }
            else
            {
                if (ramPercent > 60) pcbRAM.ProgressColor = Color.OrangeRed;
                else
                {
                    pcbRAM.ProgressColor = Color.Lime;
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetInfo();

        }
        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        }
        private void InitializeRAMCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
        }

        void RamMax()
        {
            ulong Ram = GetTotalMemoryInBytes();
            Ram /= 1024;
            Ram /= 1024;
            maxRam = (int)Ram;
        }

        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }







        // design system
        private bool mouseDown;
        private Point lastLocation;
        bool Pin = false;
        private Point lastLocationPin;
        bool changedSize = false;
        bool hideStatus = false;
        bool colorStatus = false; // while
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.TopMost = true;
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            ChangeDisplaySize();
        }


        // change display size
        void ChangeDisplaySize()
        {
            if (!changedSize)
            {
                changedSize = true;
                this.Size = new Size(200 * 2, 140 / 2);
                lblRam.Location = new Point(pcbCPU.Location.X + pcbCPU.Width + 20, lblCPU.Location.Y);
                pcbRAM.Location = new Point(pcbCPU.Location.X + pcbCPU.Width + 20, pcbCPU.Location.Y);
            }
            else
            {
                changedSize = false;
                this.Size = new Size(200, 140);
                lblRam.Location = new Point(pcbCPU.Location.X, pcbCPU.Location.Y + pcbCPU.Height + 15);
                pcbRAM.Location = new Point(lblRam.Location.X, lblRam.Location.Y + pcbCPU.Height + 10);
            }


            if (!Pin)
            {
                lastLocationPin = this.Location;
                foreach (var scrn in Screen.AllScreens)
                {
                    if (scrn.Bounds.Contains(this.Location))
                    {
                        this.Location = new Point(scrn.Bounds.Right - this.Width - this.Width / 2, scrn.Bounds.Top);
                        this.TopMost = true;
                        Pin = true;
                        return;
                    }
                }
            }
            else
            {
                this.Location = lastLocationPin;
                this.TopMost = true;
                Pin = false;
            }
        }

        void HideParent()
        {
            if (!hideStatus)
            {
                BackColor = Color.DarkCyan;
                TransparencyKey = Color.DarkCyan;
                hideStatus = true;
            }
            else
            {
                BackColor = Color.DarkCyan;
                TransparencyKey = Color.Blue;
                hideStatus = false;
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            HideParent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (!colorStatus)
            {
                lblCPU.ForeColor = Color.Teal;
                lblRam.ForeColor = Color.Teal;
                if (!hideStatus) this.BackColor = Color.LightCoral;
                colorStatus = true;
            }
            else
            {
                lblCPU.ForeColor = Color.White;
                lblRam.ForeColor = Color.White;
                if (!hideStatus) this.BackColor = Color.Teal;
                colorStatus = false;
            }
        }
    }
}
