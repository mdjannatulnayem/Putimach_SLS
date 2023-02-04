namespace Putimach_SLS
{
    partial class LandingPage
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
            this.backPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.header_i = new System.Windows.Forms.Label();
            this.header_ii = new System.Windows.Forms.Label();
            this._start = new System.Windows.Forms.Button();
            this._abort = new System.Windows.Forms.Button();
            this._termnt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.connPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.@__connect = new System.Windows.Forms.Button();
            this.connstatus = new System.Windows.Forms.Label();
            this.@__disconn = new System.Windows.Forms.Button();
            this.portfield = new System.Windows.Forms.TextBox();
            this.ctd_label = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.flightlog = new System.Windows.Forms.RichTextBox();
            this.UsbSerial = new System.IO.Ports.SerialPort(this.components);
            this.flightTimer = new System.Windows.Forms.Timer(this.components);
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.backPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.connPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.AutoSize = true;
            this.backPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.backPanel.Controls.Add(this.sidePanel);
            this.backPanel.Controls.Add(this.flowLayoutPanel1);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.backPanel.Size = new System.Drawing.Size(634, 461);
            this.backPanel.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.AutoSize = true;
            this.sidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.headerPanel);
            this.sidePanel.Controls.Add(this._start);
            this.sidePanel.Controls.Add(this._abort);
            this.sidePanel.Controls.Add(this._termnt);
            this.sidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidePanel.Location = new System.Drawing.Point(13, 18);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.sidePanel.Size = new System.Drawing.Size(220, 416);
            this.sidePanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerPanel.Controls.Add(this.header_i);
            this.headerPanel.Controls.Add(this.header_ii);
            this.headerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.headerPanel.Location = new System.Drawing.Point(8, 13);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.headerPanel.Size = new System.Drawing.Size(197, 68);
            this.headerPanel.TabIndex = 0;
            // 
            // header_i
            // 
            this.header_i.AutoSize = true;
            this.header_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_i.ForeColor = System.Drawing.SystemColors.Info;
            this.header_i.Location = new System.Drawing.Point(8, 10);
            this.header_i.Name = "header_i";
            this.header_i.Size = new System.Drawing.Size(88, 24);
            this.header_i.TabIndex = 1;
            this.header_i.Text = "Putimach";
            // 
            // header_ii
            // 
            this.header_ii.AutoSize = true;
            this.header_ii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_ii.ForeColor = System.Drawing.SystemColors.Info;
            this.header_ii.Location = new System.Drawing.Point(8, 34);
            this.header_ii.Name = "header_ii";
            this.header_ii.Size = new System.Drawing.Size(181, 24);
            this.header_ii.TabIndex = 2;
            this.header_ii.Text = "Safe Launch System";
            // 
            // _start
            // 
            this._start.BackColor = System.Drawing.Color.DodgerBlue;
            this._start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._start.ForeColor = System.Drawing.SystemColors.Info;
            this._start.Location = new System.Drawing.Point(8, 87);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(200, 100);
            this._start.TabIndex = 2;
            this._start.Text = "Start";
            this._start.UseVisualStyleBackColor = false;
            this._start.Click += new System.EventHandler(this._start_Click);
            // 
            // _abort
            // 
            this._abort.BackColor = System.Drawing.Color.Silver;
            this._abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._abort.ForeColor = System.Drawing.SystemColors.Info;
            this._abort.Location = new System.Drawing.Point(8, 193);
            this._abort.Name = "_abort";
            this._abort.Size = new System.Drawing.Size(200, 100);
            this._abort.TabIndex = 3;
            this._abort.Text = "Abort";
            this._abort.UseVisualStyleBackColor = false;
            this._abort.Click += new System.EventHandler(this._abort_Click);
            // 
            // _termnt
            // 
            this._termnt.BackColor = System.Drawing.Color.Silver;
            this._termnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._termnt.ForeColor = System.Drawing.SystemColors.Info;
            this._termnt.Location = new System.Drawing.Point(8, 299);
            this._termnt.Name = "_termnt";
            this._termnt.Size = new System.Drawing.Size(200, 100);
            this._termnt.TabIndex = 4;
            this._termnt.Text = "Terminate";
            this._termnt.UseVisualStyleBackColor = false;
            this._termnt.Click += new System.EventHandler(this._termnt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.connPanel);
            this.flowLayoutPanel1.Controls.Add(this.ctd_label);
            this.flowLayoutPanel1.Controls.Add(this.countLabel);
            this.flowLayoutPanel1.Controls.Add(this.flightlog);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(239, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 416);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // connPanel
            // 
            this.connPanel.AutoSize = true;
            this.connPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.connPanel.Controls.Add(this.btnPanel);
            this.connPanel.Controls.Add(this.portfield);
            this.connPanel.Location = new System.Drawing.Point(8, 13);
            this.connPanel.Name = "connPanel";
            this.connPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.connPanel.Size = new System.Drawing.Size(206, 97);
            this.connPanel.TabIndex = 2;
            // 
            // btnPanel
            // 
            this.btnPanel.AutoSize = true;
            this.btnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPanel.Controls.Add(this.@__connect);
            this.btnPanel.Controls.Add(this.connstatus);
            this.btnPanel.Controls.Add(this.@__disconn);
            this.btnPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.btnPanel.Location = new System.Drawing.Point(8, 13);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(84, 71);
            this.btnPanel.TabIndex = 3;
            // 
            // __connect
            // 
            this.@__connect.BackColor = System.Drawing.Color.DodgerBlue;
            this.@__connect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.@__connect.Location = new System.Drawing.Point(3, 3);
            this.@__connect.Name = "__connect";
            this.@__connect.Size = new System.Drawing.Size(75, 23);
            this.@__connect.TabIndex = 0;
            this.@__connect.Text = "Connect";
            this.@__connect.UseVisualStyleBackColor = false;
            this.@__connect.Click += new System.EventHandler(this.@__connect_Click);
            // 
            // connstatus
            // 
            this.connstatus.AutoSize = true;
            this.connstatus.ForeColor = System.Drawing.SystemColors.Info;
            this.connstatus.Location = new System.Drawing.Point(3, 29);
            this.connstatus.Name = "connstatus";
            this.connstatus.Size = new System.Drawing.Size(78, 13);
            this.connstatus.TabIndex = 2;
            this.connstatus.Text = "Not connected";
            // 
            // __disconn
            // 
            this.@__disconn.Location = new System.Drawing.Point(3, 45);
            this.@__disconn.Name = "__disconn";
            this.@__disconn.Size = new System.Drawing.Size(75, 23);
            this.@__disconn.TabIndex = 3;
            this.@__disconn.Text = "Disconnect";
            this.@__disconn.UseVisualStyleBackColor = true;
            this.@__disconn.Click += new System.EventHandler(this.@__disconn_Click);
            // 
            // portfield
            // 
            this.portfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfield.Location = new System.Drawing.Point(98, 17);
            this.portfield.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.portfield.Name = "portfield";
            this.portfield.Size = new System.Drawing.Size(100, 20);
            this.portfield.TabIndex = 1;
            // 
            // ctd_label
            // 
            this.ctd_label.AutoSize = true;
            this.ctd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctd_label.ForeColor = System.Drawing.SystemColors.Info;
            this.ctd_label.Location = new System.Drawing.Point(5, 118);
            this.ctd_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ctd_label.Name = "ctd_label";
            this.ctd_label.Size = new System.Drawing.Size(93, 18);
            this.ctd_label.TabIndex = 4;
            this.ctd_label.Text = "Countdown";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.countLabel.Location = new System.Drawing.Point(10, 151);
            this.countLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(120, 25);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "00 : 00 : 30";
            // 
            // flightlog
            // 
            this.flightlog.BackColor = System.Drawing.SystemColors.Window;
            this.flightlog.Enabled = false;
            this.flightlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightlog.ForeColor = System.Drawing.SystemColors.InfoText;
            this.flightlog.Location = new System.Drawing.Point(8, 189);
            this.flightlog.Name = "flightlog";
            this.flightlog.Size = new System.Drawing.Size(300, 210);
            this.flightlog.TabIndex = 0;
            this.flightlog.Text = "";
            // 
            // flightTimer
            // 
            this.flightTimer.Enabled = true;
            this.flightTimer.Interval = 200;
            this.flightTimer.Tick += new System.EventHandler(this.flightTimer_Tick);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.backPanel);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Putimach SLS ~ v 1.0.0";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.connPanel.ResumeLayout(false);
            this.connPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel backPanel;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Label header_i;
        private System.Windows.Forms.Label header_ii;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.IO.Ports.SerialPort UsbSerial;
        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Button _abort;
        private System.Windows.Forms.Button _termnt;
        private System.Windows.Forms.FlowLayoutPanel connPanel;
        private System.Windows.Forms.Button __connect;
        private System.Windows.Forms.TextBox portfield;
        private System.Windows.Forms.Label connstatus;
        private System.Windows.Forms.FlowLayoutPanel btnPanel;
        private System.Windows.Forms.Button __disconn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox flightlog;
        private System.Windows.Forms.Timer flightTimer;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label ctd_label;
        private System.Windows.Forms.Label countLabel;
    }
}

