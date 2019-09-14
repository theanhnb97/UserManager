using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace UserManager
{
    public partial class ProcessBar : Form
    {
        private bool _changedSize;
        private bool _colorStatus; // while
        private PerformanceCounter _cpuCounter;
        private bool _hideStatus;
        private Point _lastLocation;
        private Point _lastLocationPin;
        private int _maxRam;


        // design system
        private bool _mouseDown;
        private bool _pin;
        private PerformanceCounter _ramCounter;

        public ProcessBar()
        {
            InitializeComponent();
            InitCpuCounter();
            InitRamCounter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RamMax();
            BackColor = Color.DarkCyan;
            TransparencyKey = Color.Blue;
            TopMost = true;
            TransparentForm();
            StartPosition = FormStartPosition.Manual;
            foreach (var screen in Screen.AllScreens)
            {
                if (!screen.Bounds.Contains(Location)) continue;
                Location = new Point(screen.Bounds.Right - Width, screen.Bounds.Top + screen.WorkingArea.Height / 2);
                TopMost = true;
                return;
            }
            GetInfo();
        }

        private void TransparentForm()
        {
            const float fontSize = 12;
            lblCPU.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            lblRam.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            lblCPU.ForeColor = Color.White;
            lblRam.ForeColor = Color.White;
        }

        private void GetInfo()
        {
            var cpu = Convert.ToInt32(_cpuCounter.NextValue());
            var ram = Convert.ToInt32(_ramCounter.NextValue());
            var ramUsed = _maxRam - ram;
            var ramPercent = (int) (ramUsed * 1.0 / _maxRam * 100);
            lblCPU.Text = $@"CPU: {cpu}%";
            lblRam.Text = $@"RAM: {ramUsed} MB ({ramPercent}%) ";
            pcbCPU.Value = cpu;
            pcbRAM.Value = ramPercent;
            if (cpu > 90)
                pcbCPU.ProgressColor = Color.Red;
            else if (cpu > 70)
                pcbCPU.ProgressColor = Color.OrangeRed;
            else
                pcbCPU.ProgressColor = cpu > 40 ? Color.Salmon : Color.Lime;

            if (ramPercent > 80)
                pcbRAM.ProgressColor = Color.Red;
            else
                pcbRAM.ProgressColor = ramPercent > 60 ? Color.OrangeRed : Color.Lime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void InitCpuCounter()
        {
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
        }

        private void InitRamCounter()
        {
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
        }

        private void RamMax()
        {
            var ram = GetTotalMemoryInBytes();
            ram /= 1024;
            ram /= 1024;
            _maxRam = (int) ram;
        }

        private static ulong GetTotalMemoryInBytes()
        {
            return new ComputerInfo().TotalPhysicalMemory;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(
                Location.X - _lastLocation.X + e.X, Location.Y - _lastLocation.Y + e.Y);
            TopMost = true;
            Update();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            ChangeDisplaySize();
        }


        // change display size
        private void ChangeDisplaySize()
        {
            if (!_changedSize)
            {
                _changedSize = true;
                Size = new Size(200 * 2, 140 / 2);
                lblRam.Location = new Point(pcbCPU.Location.X + pcbCPU.Width + 20, lblCPU.Location.Y);
                pcbRAM.Location = new Point(pcbCPU.Location.X + pcbCPU.Width + 20, pcbCPU.Location.Y);
            }
            else
            {
                _changedSize = false;
                Size = new Size(200, 140);
                lblRam.Location = new Point(pcbCPU.Location.X, pcbCPU.Location.Y + pcbCPU.Height + 15);
                pcbRAM.Location = new Point(lblRam.Location.X, lblRam.Location.Y + pcbCPU.Height + 10);
            }


            if (!_pin)
            {
                _lastLocationPin = Location;
                foreach (var screen in Screen.AllScreens)
                {
                    if (!screen.Bounds.Contains(Location)) continue;
                    Location = new Point(screen.Bounds.Right - Width - Width / 2, screen.Bounds.Top);
                    TopMost = true;
                    _pin = true;
                    return;
                }
            }
            else
            {
                Location = _lastLocationPin;
                TopMost = true;
                _pin = false;
            }
        }

        private void HideParent()
        {
            if (!_hideStatus)
            {
                BackColor = Color.DarkCyan;
                TransparencyKey = Color.DarkCyan;
                _hideStatus = true;
            }
            else
            {
                BackColor = Color.DarkCyan;
                TransparencyKey = Color.Blue;
                _hideStatus = false;
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            HideParent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (!_colorStatus)
            {
                lblCPU.ForeColor = Color.Teal;
                lblRam.ForeColor = Color.Teal;
                if (!_hideStatus) BackColor = Color.LightCoral;
                _colorStatus = true;
            }
            else
            {
                lblCPU.ForeColor = Color.White;
                lblRam.ForeColor = Color.White;
                if (!_hideStatus) BackColor = Color.Teal;
                _colorStatus = false;
            }
        }
    }
}