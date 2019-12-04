using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RDCenter.PacketTransProtocol;
using VMonitorSystem.dbDataSetTableAdapters;

namespace VMonitorSystem
{
    public partial class frmQueryPacketData : Form
    {
        public frmQueryPacketData()
        {
            InitializeComponent();

            if (dbDataSet == null) dbDataSet = new dbDataSet();
        }

        private void frmQueryPacketData_Load(object sender, EventArgs e)
        {

            
            dateTimePickerMin.Value = DateTime.Today;
            dateTimePickerMax.Value = DateTime.Today.AddDays(1).AddMilliseconds(-1);
            lblCmdCodeDesc.Width = 450;
            

            btnQuery_Click(null, null);


        }

        private void datagrid_head_config(string mappingName,DataTable dt)
        {
            if (dataGrid1.TableStyles.Count < 1)
            {
                DataGridTableStyle s = new DataGridTableStyle();
                s.MappingName = mappingName; ;// 

                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    DataGridTextBoxColumn c = new DataGridTextBoxColumn();
                    c.MappingName = dt.Columns[i].ColumnName;
                    s.GridColumnStyles.Add(c);
                }


                dataGrid1.TableStyles.Add(s);

                var ii = 0;
                //AutoRowGUID

                s.GridColumnStyles[ii].HeaderText = "发送者";
                s.GridColumnStyles[ii++].Width = 60;

                s.GridColumnStyles[ii].HeaderText = "接收时间";
                s.GridColumnStyles[ii++].Width = 160;


                s.GridColumnStyles[ii].HeaderText = "指令编码";
                s.GridColumnStyles[ii++].Width = 80;

                //EventSource
                s.GridColumnStyles[ii].HeaderText = "指令参数";
                s.GridColumnStyles[ii].Width = 80;
                s.GridColumnStyles[ii++].NullText = "";

                //发送时间
                //----------------------------------------
                s.GridColumnStyles[ii].HeaderText = "发送时间";
                s.GridColumnStyles[ii++].Width = 0;
                //----------------------------------------

                s.GridColumnStyles[ii].HeaderText = "数据包";
                s.GridColumnStyles[ii++].Width = 250;

                s.GridColumnStyles[ii].HeaderText = "包类型";
                s.GridColumnStyles[ii++].Width = 60;

                s.GridColumnStyles[ii].HeaderText = "编号";
                s.GridColumnStyles[ii++].Width = 0;
            }
        }

        private void chxDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        TPacketDataTableAdapter da = null;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            var senderid = txtSenderId.Text;

            if(da==null) da = new TPacketDataTableAdapter();

            var x = da.GetDataBy(dateTimePickerMin.Value, dateTimePickerMax.Value).Where(p => string.IsNullOrEmpty(senderid) ? true : p.SenderId == byte.Parse(senderid))
                //.Where(p => !chxDT.Checked ? true : (p.ReveiveDateTime <= dateTimePickerMax.Value && p.ReveiveDateTime >= dateTimePickerMin.Value))
                .Where(p => string.IsNullOrEmpty(txtCmdCode.Text) ? true : p.CommandCode == short.Parse(txtCmdCode.Text))
                .Select(p => new { 
                    AutoRowGUID = p.AutoRowGUID, 
                    SenderId = p.SenderId, 
                    ReveiveDateTime = p.ReveiveDateTime, 
                    CommandCode = p.CommandCode, 
                    CommandPara=p.CommandPara,
                    SendDateTime=p.SendDateTime,
                    PacketData=p.PacketData,
                    PacketType=p.PacketType
                });

            datagrid_head_config(x.ToList().GetType().Name, this.dbDataSet.TPacketData);
            dataGrid1.DataSource = x.ToList();
        }

        private void txtCmdCode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCmdCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lblCmdCodeDesc.Text = PacketHelper.Describe(short.Parse(txtCmdCode.Text));
            }
            catch (Exception ex)
            {
                lblCmdCodeDesc.Text = ex.Message;
            }
        }
    }
}