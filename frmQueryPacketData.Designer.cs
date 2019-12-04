namespace VMonitorSystem
{
    partial class frmQueryPacketData
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.chxDT = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCmdCode = new System.Windows.Forms.TextBox();
            this.txtSenderId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblCmdCodeDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.dataGrid1.Location = new System.Drawing.Point(7, 64);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(624, 376);
            this.dataGrid1.TabIndex = 0;
            // 
            // chxDT
            // 
            this.chxDT.Checked = true;
            this.chxDT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxDT.Enabled = false;
            this.chxDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.chxDT.Location = new System.Drawing.Point(187, 7);
            this.chxDT.Name = "chxDT";
            this.chxDT.Size = new System.Drawing.Size(23, 22);
            this.chxDT.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(400, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.Text = "结束";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.Text = "开始";
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dateTimePickerMax.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMax.Location = new System.Drawing.Point(439, 5);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(147, 24);
            this.dateTimePickerMax.TabIndex = 27;
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dateTimePickerMin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerMin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dateTimePickerMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMin.Location = new System.Drawing.Point(251, 5);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(145, 23);
            this.dateTimePickerMin.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.Text = "指令编码";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.Text = "围栏编号";
            // 
            // txtCmdCode
            // 
            this.txtCmdCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.txtCmdCode.Location = new System.Drawing.Point(76, 35);
            this.txtCmdCode.Name = "txtCmdCode";
            this.txtCmdCode.Size = new System.Drawing.Size(108, 26);
            this.txtCmdCode.TabIndex = 25;
            this.txtCmdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCmdCode_KeyDown);
            this.txtCmdCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCmdCode_KeyUp);
            // 
            // txtSenderId
            // 
            this.txtSenderId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.txtSenderId.Location = new System.Drawing.Point(76, 6);
            this.txtSenderId.Name = "txtSenderId";
            this.txtSenderId.Size = new System.Drawing.Size(108, 26);
            this.txtSenderId.TabIndex = 24;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnQuery.Location = new System.Drawing.Point(556, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 33;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblCmdCodeDesc
            // 
            this.lblCmdCodeDesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblCmdCodeDesc.Location = new System.Drawing.Point(187, 38);
            this.lblCmdCodeDesc.Name = "lblCmdCodeDesc";
            this.lblCmdCodeDesc.Size = new System.Drawing.Size(23, 19);
            this.lblCmdCodeDesc.Tag = "指令描述";
            // 
            // frmQueryPacketData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.lblCmdCodeDesc);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.chxDT);
            this.Controls.Add(this.dateTimePickerMax);
            this.Controls.Add(this.dateTimePickerMin);
            this.Controls.Add(this.txtCmdCode);
            this.Controls.Add(this.txtSenderId);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "frmQueryPacketData";
            this.Text = "数据包查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQueryPacketData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.CheckBox chxDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerMax;
        private System.Windows.Forms.DateTimePicker dateTimePickerMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCmdCode;
        private System.Windows.Forms.TextBox txtSenderId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblCmdCodeDesc;
        private dbDataSet dbDataSet;
    }
}