using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VMonitorSystem
{
    public partial class frmSysLog : Form
    {
        public frmSysLog()
        {
            InitializeComponent();
        }

        private void frmSysLog_Load(object sender, EventArgs e)
        {
            dateTimePickerMin.Value = DateTime.Today;
            dateTimePickerMax.Value = DateTime.Today.AddDays(1).AddMilliseconds(-1);

            if (dataGrid1.TableStyles.Count < 1)
            {
                DataGridTableStyle s = new DataGridTableStyle();
                s.MappingName = this.dbDataSet.SysLog.TableName;

                dataGrid1.TableStyles.Add(s);

                //AutoRowGUID
                s.GridColumnStyles[5].HeaderText = "编号";
                s.GridColumnStyles[5].Width = 0;


                //ReveiveDateTime
                s.GridColumnStyles[0].HeaderText = "接收时间";
                s.GridColumnStyles[0].Width = 90;
                //EventLevel
                s.GridColumnStyles[1].HeaderText = "级别";
                s.GridColumnStyles[1].Width = 40;

                //EventDescriptor
                s.GridColumnStyles[2].HeaderText = "事件描述";
                s.GridColumnStyles[2].Width = 500;

                //EventSource
                s.GridColumnStyles[3].HeaderText = "事件源";
                s.GridColumnStyles[3].Width = 60;
                s.GridColumnStyles[3].NullText = "";

                s.GridColumnStyles[4].HeaderText = "事件id";
                s.GridColumnStyles[4].Width = 60;
            }

            btnQuery_Click(null, null);
        }

        private void fillByButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sysLogTableAdapter.FillBy(this.dbDataSet.SysLog, ((System.DateTime)(System.Convert.ChangeType(reveiveDateTimeMINTextBox.Text, typeof(System.DateTime), null))), ((System.DateTime)(System.Convert.ChangeType(reveiveDateTimeMAXTextBox.Text, typeof(System.DateTime), null))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            // TODO: 这行代码将数据加载到表“dbDataSet.SysLog”中。您可以根据需要移动或移除它。
            this.sysLogTableAdapter.FillBy(this.dbDataSet.SysLog,dateTimePickerMin.Value,dateTimePickerMax.Value);


        }




    }
}