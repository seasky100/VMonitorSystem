namespace VMonitorSystem
{
    partial class frmSysLog
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
            this.sysLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.fillByPanel = new System.Windows.Forms.Panel();
            this.reveiveDateTimeMINLabel = new System.Windows.Forms.Label();
            this.reveiveDateTimeMINTextBox = new System.Windows.Forms.TextBox();
            this.reveiveDateTimeMAXLabel = new System.Windows.Forms.Label();
            this.reveiveDateTimeMAXTextBox = new System.Windows.Forms.TextBox();
            this.fillByButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dbDataSet = new VMonitorSystem.dbDataSet();
            this.sysLogTableAdapter = new VMonitorSystem.dbDataSetTableAdapters.SysLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sysLogBindingSource)).BeginInit();
            this.fillByPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sysLogBindingSource
            // 
            this.sysLogBindingSource.DataMember = "SysLog";
            this.sysLogBindingSource.DataSource = this.dbDataSet;
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.sysLogBindingSource;
            this.dataGrid1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.dataGrid1.Location = new System.Drawing.Point(6, 37);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(624, 402);
            this.dataGrid1.TabIndex = 0;
            // 
            // fillByPanel
            // 
            this.fillByPanel.AutoScroll = true;
            this.fillByPanel.Controls.Add(this.reveiveDateTimeMINLabel);
            this.fillByPanel.Controls.Add(this.reveiveDateTimeMINTextBox);
            this.fillByPanel.Controls.Add(this.reveiveDateTimeMAXLabel);
            this.fillByPanel.Controls.Add(this.reveiveDateTimeMAXTextBox);
            this.fillByPanel.Controls.Add(this.fillByButton);
            this.fillByPanel.Location = new System.Drawing.Point(10, 449);
            this.fillByPanel.Name = "fillByPanel";
            this.fillByPanel.Size = new System.Drawing.Size(230, 0);
            // 
            // reveiveDateTimeMINLabel
            // 
            this.reveiveDateTimeMINLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.reveiveDateTimeMINLabel.Location = new System.Drawing.Point(8, 11);
            this.reveiveDateTimeMINLabel.Name = "reveiveDateTimeMINLabel";
            this.reveiveDateTimeMINLabel.Size = new System.Drawing.Size(173, 17);
            this.reveiveDateTimeMINLabel.Text = "Reveive Date Time MIN:";
            // 
            // reveiveDateTimeMINTextBox
            // 
            this.reveiveDateTimeMINTextBox.Location = new System.Drawing.Point(190, 8);
            this.reveiveDateTimeMINTextBox.Name = "reveiveDateTimeMINTextBox";
            this.reveiveDateTimeMINTextBox.Size = new System.Drawing.Size(100, 23);
            this.reveiveDateTimeMINTextBox.TabIndex = 1;
            // 
            // reveiveDateTimeMAXLabel
            // 
            this.reveiveDateTimeMAXLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.reveiveDateTimeMAXLabel.Location = new System.Drawing.Point(8, 41);
            this.reveiveDateTimeMAXLabel.Name = "reveiveDateTimeMAXLabel";
            this.reveiveDateTimeMAXLabel.Size = new System.Drawing.Size(175, 17);
            this.reveiveDateTimeMAXLabel.Text = "Reveive Date Time MAX:";
            // 
            // reveiveDateTimeMAXTextBox
            // 
            this.reveiveDateTimeMAXTextBox.Location = new System.Drawing.Point(190, 38);
            this.reveiveDateTimeMAXTextBox.Name = "reveiveDateTimeMAXTextBox";
            this.reveiveDateTimeMAXTextBox.Size = new System.Drawing.Size(100, 23);
            this.reveiveDateTimeMAXTextBox.TabIndex = 3;
            // 
            // fillByButton
            // 
            this.fillByButton.Location = new System.Drawing.Point(8, 74);
            this.fillByButton.Name = "fillByButton";
            this.fillByButton.Size = new System.Drawing.Size(72, 20);
            this.fillByButton.TabIndex = 4;
            this.fillByButton.Text = "Fill By:";
            this.fillByButton.Click += new System.EventHandler(this.fillByButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(199, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.Text = "结束";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.Text = "开始";
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMax.Location = new System.Drawing.Point(239, 7);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(152, 24);
            this.dateTimePickerMax.TabIndex = 32;
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMin.Location = new System.Drawing.Point(43, 7);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(151, 24);
            this.dateTimePickerMin.TabIndex = 31;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.btnQuery.Location = new System.Drawing.Point(555, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 36;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.Prefix = "";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysLogTableAdapter
            // 
            this.sysLogTableAdapter.ClearBeforeFill = true;
            // 
            // frmSysLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dateTimePickerMax);
            this.Controls.Add(this.dateTimePickerMin);
            this.Controls.Add(this.fillByPanel);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmSysLog";
            this.Text = "日志";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysLogBindingSource)).EndInit();
            this.fillByPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource sysLogBindingSource;
        private VMonitorSystem.dbDataSetTableAdapters.SysLogTableAdapter sysLogTableAdapter;
        private System.Windows.Forms.Panel fillByPanel;
        private System.Windows.Forms.Label reveiveDateTimeMINLabel;
        private System.Windows.Forms.TextBox reveiveDateTimeMINTextBox;
        private System.Windows.Forms.Label reveiveDateTimeMAXLabel;
        private System.Windows.Forms.TextBox reveiveDateTimeMAXTextBox;
        private System.Windows.Forms.Button fillByButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerMax;
        private System.Windows.Forms.DateTimePicker dateTimePickerMin;
        private System.Windows.Forms.Button btnQuery;

    }
}