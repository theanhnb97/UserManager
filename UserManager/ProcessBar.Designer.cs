namespace UserManager
{
    partial class ProcessBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessBar));
            this.lblRam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCPU = new System.Windows.Forms.Label();
            this.pcbRAM = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pcbCPU = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.Color.White;
            this.lblRam.Location = new System.Drawing.Point(7, 77);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(107, 25);
            this.lblRam.TabIndex = 9;
            this.lblRam.Text = "Loading...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnTrans);
            this.panel1.Controls.Add(this.btnPin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(77, -2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(20, 22);
            this.btnColor.TabIndex = 9;
            this.btnColor.TabStop = false;
            this.btnColor.Text = "D";
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnTrans.FlatAppearance.BorderSize = 0;
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.Color.White;
            this.btnTrans.Location = new System.Drawing.Point(51, -2);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(20, 22);
            this.btnTrans.TabIndex = 8;
            this.btnTrans.TabStop = false;
            this.btnTrans.Text = "T";
            this.btnTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnPin
            // 
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.FlatAppearance.BorderSize = 0;
            this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.ForeColor = System.Drawing.Color.White;
            this.btnPin.Location = new System.Drawing.Point(26, -2);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(20, 22);
            this.btnPin.TabIndex = 7;
            this.btnPin.TabStop = false;
            this.btnPin.Text = "P";
            this.btnPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPin.UseVisualStyleBackColor = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(7, 22);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(107, 25);
            this.lblCPU.TabIndex = 10;
            this.lblCPU.Text = "Loading...";
            // 
            // pcbRAM
            // 
            this.pcbRAM.BackColor = System.Drawing.Color.Silver;
            this.pcbRAM.BorderRadius = 10;
            this.pcbRAM.Location = new System.Drawing.Point(12, 104);
            this.pcbRAM.MaximumValue = 100;
            this.pcbRAM.Name = "pcbRAM";
            this.pcbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pcbRAM.Size = new System.Drawing.Size(170, 16);
            this.pcbRAM.TabIndex = 11;
            this.pcbRAM.Value = 0;
            // 
            // pcbCPU
            // 
            this.pcbCPU.BackColor = System.Drawing.Color.Silver;
            this.pcbCPU.BorderRadius = 10;
            this.pcbCPU.Location = new System.Drawing.Point(12, 49);
            this.pcbCPU.MaximumValue = 100;
            this.pcbCPU.Name = "pcbCPU";
            this.pcbCPU.ProgressColor = System.Drawing.Color.Lime;
            this.pcbCPU.Size = new System.Drawing.Size(170, 16);
            this.pcbCPU.TabIndex = 12;
            this.pcbCPU.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnExit;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // ProcessBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 140);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.pcbRAM);
            this.Controls.Add(this.pcbCPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCPU;
        private Bunifu.Framework.UI.BunifuProgressBar pcbRAM;
        private Bunifu.Framework.UI.BunifuProgressBar pcbCPU;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnColor;
    }
}