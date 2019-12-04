namespace VMonitorSystem
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSysTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstClient = new System.Windows.Forms.ListView();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPacketdataQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(350, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.Text = "版本";
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.Location = new System.Drawing.Point(391, 2);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(76, 23);
            this.txtVersion.TabIndex = 57;
            this.txtVersion.Text = "2015053100";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnStart.Location = new System.Drawing.Point(476, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 20);
            this.btnStart.TabIndex = 54;
            this.btnStart.Text = "启动(&S)";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lbladdress.Location = new System.Drawing.Point(4, 6);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(42, 20);
            this.lbladdress.Text = "地址";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // cmbIP
            // 
            this.cmbIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbIP.Location = new System.Drawing.Point(46, 3);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(118, 23);
            this.cmbIP.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(170, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.Text = "端口";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(215, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 23);
            this.txtPort.TabIndex = 52;
            this.txtPort.Text = "8383";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.txtLog.Location = new System.Drawing.Point(215, 61);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(420, 372);
            this.txtLog.TabIndex = 61;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnStop.Location = new System.Drawing.Point(554, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 20);
            this.btnStop.TabIndex = 62;
            this.btnStop.Text = "停止(&E)";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSysTest
            // 
            this.btnSysTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSysTest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnSysTest.Location = new System.Drawing.Point(269, 29);
            this.btnSysTest.Name = "btnSysTest";
            this.btnSysTest.Size = new System.Drawing.Size(161, 23);
            this.btnSysTest.TabIndex = 66;
            this.btnSysTest.Text = "建立测试客户端(&R)";
            this.btnSysTest.Click += new System.EventHandler(this.btnSysTest_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.Text = "在线电子围栏列表";
            // 
            // lstClient
            // 
            this.lstClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lstClient.Location = new System.Drawing.Point(6, 61);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(205, 372);
            this.lstClient.TabIndex = 68;
            this.lstClient.View = System.Windows.Forms.View.List;
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnLog.Location = new System.Drawing.Point(554, 29);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(72, 22);
            this.btnLog.TabIndex = 72;
            this.btnLog.Text = "日志(&L)";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPacketdataQuery
            // 
            this.btnPacketdataQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPacketdataQuery.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnPacketdataQuery.Location = new System.Drawing.Point(436, 29);
            this.btnPacketdataQuery.Name = "btnPacketdataQuery";
            this.btnPacketdataQuery.Size = new System.Drawing.Size(112, 23);
            this.btnPacketdataQuery.TabIndex = 77;
            this.btnPacketdataQuery.Text = "数据包查询";
            this.btnPacketdataQuery.Click += new System.EventHandler(this.btnPacketdataQuery_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.btnPacketdataQuery);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClient);
            this.Controls.Add(this.btnSysTest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.label2);
            this.Name = "frmMain";
            this.Text = "测试版v2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Closed += new System.EventHandler(this.frmMain_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbladdress;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSysTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstClient;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPacketdataQuery;
    }
}

