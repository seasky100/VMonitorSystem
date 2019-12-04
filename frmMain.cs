
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

using RDCenter.PacketTransProtocol;
using VMonitorSystem.dbDataSetTableAdapters;

namespace VMonitorSystem
{
    public partial class frmMain : Form
    {
        dbDataSet db = null;
        private void InitializeIPList()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry ipHE = Dns.Resolve(hostname);
            foreach (IPAddress item in ipHE.AddressList)
            {
                cmbIP.Items.Add(item.ToString());
            }

            if (cmbIP.Items.Count > 0) cmbIP.SelectedIndex = 0;

            if (db == null) db=new dbDataSet();
        }

        public frmMain()
        {
            InitializeComponent();

            InitializeIPList();
        }

        private volatile bool exit = false;

        VSystem system = null;
        bool IsBindEvent = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            exit = false;
            
            system = VSystem.GetInstance();

            if (!IsBindEvent)
            {
                
                
                var conversationService = (ConversationService)system.GetSystemService(ServiceType.ConversationService);
                conversationService.IPString = cmbIP.Text;
                conversationService.Port = int.Parse(txtPort.Text);
                conversationService.BufferSize = PacketHelper.PacketLength;
                // 服务启动成功事件处理函数
                conversationService.OnSuccessService += new EventHandler(conversationService_OnStartSuccessService);
                // 服务启动失败事件处理函数
                conversationService.OnFaultService += new EventHandler(conversationService_OnFaultService);
                // 客户端接收线路建立事件处理函数
                conversationService.OnCreateThread+=new ThreadEventHandler(conversationService_OnCreateThread);
                // 客户端退出事件处理函数
                conversationService.OnLogout+=new ClientEventHandler(conversationService_OnLogout);
                // 收到数据包处理函数
                conversationService.OnReceivePocketData += new ReceiveDataEventHandler(conversationService_OnReceivePocketData);
                // 运行状态消息处理函数
                conversationService.OnRunStateMessage += new CommonRunStateMessageEventHandler(conversationService_OnRunStateMessage);

                
                conversationService.OnReplyTimeout += new ClientEventHandler(conversationService_OnReplyTimeout);
                conversationService.OnReplyOnline += new ClientEventHandler(conversationService_OnReplyOnline);
                IsBindEvent = true;
            }          

            system.Run();


        }

        void conversationService_OnReplyOnline(byte clientId, object data)
        {
            Debug.WriteLine(string.Format("检查是否在线围栏{0}: {1}", clientId, data));
            AppendList(clientId);
        }

        void conversationService_OnReplyTimeout(byte clientId,object data)
        {
            Debug.WriteLine(string.Format("应答超时:{0}", clientId));
            RemoveList(clientId);
            SysLog(6, string.Format("围栏{0}下线",clientId));
        }

        void conversationService_OnReceivePocketData(object sender, ReceiveDataEventArgs e, NetworkStream stream)
        {
            //如果收到 客户端的关机信号 则移除
            var newrow = db.TPacketData.NewTPacketDataRow();

            PacketHelper ph = new PacketHelper(e.Data);
            var clientid = ph.SenderID;
            AppendList(clientid);


            #region XXX
            switch (ph.CommandCode)
            {
                //客户端 关机 通知
                case CommandCodeType.ClientNotifyToServerShutdown:
                    RemoveList(clientid);
                    break;

                //客户端 报警 通知
                case CommandCodeType.ClientNotifyToServerAlarm:
                    //在LED屏显示合适的信息

                    //播放声音文件

                    //显示日志里
                    SysLog(0, string.Format("收到未处理指令包：{0}", BitConverter.ToString(e.Data)));

                    break;
                //客户端 检查是否在线
                case CommandCodeType.ClientReplyOnline:
                    AppendList(clientid);
                    break;

                default:
                    SysLog(0,string.Format( "收到未处理指令包：{0}",BitConverter.ToString(e.Data)));
                    break;

            }


            #endregion

            //newrow.AutoRowGUID
            newrow.ReveiveDateTime = DateTime.Now;
            newrow.SendDateTime = DateTime.Now;
            newrow.PacketData = BitConverter.ToString(e.Data);
            newrow.CommandCode = (short)ph.CommandCode;
            newrow.CommandPara = (short)ph.CommandPara;
            newrow.PacketType = (byte)ph.PacketType;
            newrow.SenderId = ph.SenderID;
            db.TPacketData.AddTPacketDataRow(newrow);
            new TPacketDataTableAdapter().Update(db.TPacketData);
            db.AcceptChanges();
        }

        Dictionary<byte, ListViewItem> items = new Dictionary<byte,ListViewItem>();
        void conversationService_OnLogout(byte clientid,object data)
        {
            RemoveList(clientid);
        }

        private void RemoveList(byte clientid)
        {
            this.Invoke(new Action(() =>
            {
                if (items.ContainsKey(clientid))
                {

                    lstClient.Items.Remove(items[clientid]);

                    items.Remove(clientid);
                }
            }));
        }

        private void AppendList(byte clientid)
        {
            this.Invoke(new Action(() =>
            {
                if (!items.ContainsKey(clientid))
                {
                    items.Add(clientid, new ListViewItem("围栏" + clientid.ToString()));
                    lstClient.Items.Add(items[clientid]);
                }
            }));
        }

        void conversationService_OnCreateThread(Thread thread, NetworkStream stream)
        {
            var data=PacketHelper.GetPacketServerAskClientIsOnline();
            stream.Write(data, 0, data.Length);
            //AppendList(clientid);
        }

        void conversationService_OnFaultService(object sender, EventArgs e)
        {
            this.Invoke(new Action(()=>{
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                })
            );
        }

        void conversationService_OnStartSuccessService(object sender, EventArgs e)
        {
            this.Invoke(new Action(()=>{
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                })
            );
        }

        
       
        void conversationService_OnRunStateMessage(object sender, int eventLevel, RunStateMessageEventArgs e)
        {

            var msg = string.Format("事件级别：{0} 详细：{1}", string.Format("{0,-2:G}", eventLevel), e.Message);

            try
            {
                this.Invoke(new Action(() =>
                {
                    txtLog.Text += (msg + "\r\n");
                }));

                SysLog(eventLevel, e.Message);
            }
            catch (Exception er)
            {

            }
        }

        void recever_OnRunStateMessage(object sender, int eventType, RunStateMessageEventArgs e)
        {
            //C# 3.0 4.0 语法

            try
            {
                this.Invoke(new Action(() =>
                {
                    txtLog.Text+=e.Message + "\r\n";
                    txtLog.Text += string.Format("当前线程名:{0} 线程ID:{1}\r\n", Thread.CurrentThread.Name,Thread.CurrentThread.ManagedThreadId);

                }));
            }
            catch (Exception ex)
            {

            }

            //C# 2.0 语法
            //this.Invoke(new EventHandler((s, a) =>
            //{
            //    listBox1.Items.Add(e.Message + "\r\n");
            //    listBox1.Items.Add(string.Format("当前线程id:{0}", Thread.CurrentThread.Name + "\r\n"));
            //}));

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort1_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {

        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {

        }

        
        private void SysLog(int eventLevel, string EventDescriptor)
        {
            try
            {
                var newrow = db.SysLog.NewSysLogRow();

                //newrow.AutoRowGUID自增列
                var max = EventDescriptor.Length > 500 ? 500 : EventDescriptor.Length;
                newrow.EventDescriptor = EventDescriptor.Substring(0, max);
                newrow.EventLevel = eventLevel;
                newrow.EventSource = null;
                newrow.ReveiveDateTime = DateTime.Now;
                newrow.EventId = 0;
                db.SysLog.AddSysLogRow(newrow);
                new SysLogTableAdapter().Update(db.SysLog);
            }
            catch (Exception e)
            {
                this.Invoke(new Action(() =>
                {
                    txtLog.Text += (string.Format("写日志异常:{0}\r\n", e.Message));
                }));            
            }
        }

        private void btnSysTest_Click(object sender, EventArgs e)
        {
            try
            {
                CreateMultiClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int mMN = 0;
        private void CreateMultiClient()
        {
            var receveService = (ConversationService)system.GetSystemService(ServiceType.ConversationService);
            if (receveService == null) return;
            TcpClient Client = new TcpClient(receveService.IPString, receveService.Port);

            var readThread = new Thread(() =>
            {
                try
                {
                    Thread.CurrentThread.Name = "测试读" + new Random().Next(9999).ToString("D4");

                    TcpClient client = (TcpClient)Thread.GetData(Thread.GetNamedDataSlot(Thread.CurrentThread.ManagedThreadId.ToString()));
                    
                    NetworkStream stream = client.GetStream();
                    //-----------------------------------------------------------------------------------------------------
                    //PacketHelper ap = new PacketHelper();
                    //-----------------------------------------------------------------------------------------------------
                    DisassembleBuffer db = new DisassembleBuffer();

                    //var mn = "0001"; 
                    var mn = ++mMN;
                   // 收到服务端的数据 目前先不实同
                    db.OnReceivePocketData += new ReceivePocketDataEventHandler((s, rd) =>
                    {
                        string error = null;
                        var items = new Dictionary<object, string>();
                        

                    });
                    // Buffer for reading data
                    Byte[] bytes = new Byte[3 * PacketHelper.PacketLength];

                    string data = null;

                    Byte[] first = PacketHelper.GetPacketClientNotifyToServerShutdown((byte)mn);
                        
                    stream.Write(first, 0, first.Length);
                    // Loop to receive all the data sent by the client.
                    while (/*Thread.CurrentThread.ThreadState != System.Threading.ThreadState.AbortRequested &&*/ !exit)
                    {
                        int i = 0;
                        Console.WriteLine("线程:{0} {1}", Thread.CurrentThread.Name, "准备再次读...");
                        if ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {

                            db.Processing(bytes, i);
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                            Console.WriteLine("Received: {0}", data);


                        }
                    }
                }
                catch (ThreadAbortException tae)
                {
                    //Console.WriteLine("线程:{0} {1}", Thread.CurrentThread.Name, "放弃");
                    //if (OnAlarmAsyncRunStateMessage != null) OnAlarmAsyncRunStateMessage.BeginInvoke(this, new RunStateMessageEventArgs(string.Format("线程放弃:{0} {1}", Thread.CurrentThread.Name, tae.InnerException == null ? tae.Message : tae.Message + " " + tae.InnerException.Message)));
                }
                catch (IOException ioe)
                {
                    if (this == null) return;
                    this.Invoke(new Action(() =>
                    {
                        txtLog.Text+=(string.Format("异常:{0}\r\n", ioe.InnerException == null ? ioe.Message + "\r\n" + ioe.StackTrace : ioe.Message + " " + ioe.InnerException.Message + "\r\n" + ioe.StackTrace));
                    }));

                }
                catch (Exception ex)
                {

                    Console.WriteLine("异常:{0}", ex.InnerException == null ? ex.Message + "\r\n" + ex.StackTrace : ex.Message + " " + ex.InnerException.Message + "\r\n" + ex.StackTrace);
                    this.Invoke(new Action(() =>
                    {
                        txtLog.Text += (string.Format("异常:{0}\r\n", ex.InnerException == null ? ex.Message + "\r\n" + ex.StackTrace : ex.Message + " " + ex.InnerException.Message + "\r\n" + ex.StackTrace));
                    }));
                }
                finally
                {
                    //Console.WriteLine("线程:{0} {1}\addMN\n", Thread.CurrentThread.Name, "退出");
                    this.Invoke(new Action(() =>
                    {
                        txtLog.Text += (string.Format("线程退出:{0}\r\n", Thread.CurrentThread.Name));
                    }));
                }
                //Shutdown and end connection
                //client.Close();
                //if (OnAlarmAsyncRunStateMessage != null) OnAlarmAsyncRunStateMessage.BeginInvoke(this, new RunStateMessageEventArgs(string.Format("线程退出:{0}", Thread.CurrentThread.Name)));
            });

            
            readThread.Start();
            //receiveThread.Start(Client);

            

            tcpClientMgr.Add(Client);
            threadMgr.Add(readThread);
            //ReceiveThreadMgr.Add(sendThread);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            #if(DEBUG)
                btnStart_Click(null,null);
            #endif
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            Stop();
        }

        private void Stop()
        {
            exit = true;
            new Thread(() =>
            {
                try
                {

                    if (system != null) system.Shutdown();

                    foreach (var t in tcpClientMgr)
                    {
                        t.Close();
                    }

                    foreach (var t in threadMgr)
                    {
                        t.Abort();
                    }

                    // UI 最好放在最后 窗体关闭后 更新UI会异常 而引发异常的语句之后的代码会被跳过
                    //this.Invoke(new Action(() =>
                    //{

                    //    this.btnStart.Enabled = exit;
                    //    this.btnStop.Enabled = !exit;
                    //}));


                }
                catch (Exception ex)
                {
                    //this.Invoke(new Action(() =>
                    //{
                    //    this.btnStop.Enabled = false;
                    //}));
                }
            }).Start();
        }

        private List<TcpClient> tcpClientMgr = new List<TcpClient>();
        public List<Thread> threadMgr = new List<Thread>();

        private void frmMain_Closed(object sender, EventArgs e)
        {
            Stop();
        }

        private void frmMain_Closing(object sender, CancelEventArgs e)
        {
            
            
        }

        frmSysLog f = null;
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new frmSysLog();
            }
            f.ShowDialog();
        }

        frmQueryPacketData fp = null;
        private void btnPacketdataQuery_Click(object sender, EventArgs e)
        {
            if (fp == null)
            {
                fp = new frmQueryPacketData();
            }

            fp.ShowDialog();
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            //txtLog.Select(txtLog.Text.Length, 0);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();

            //Regex x = new Regex("\n");
            //MatchCollection xs = x.Matches(txtLog.Text);
            //if (xs.Count > 1000)
            //{
            //    txtLog.Text = "";
            //}

            if (txtLog.TextLength > 8000)
            {
                txtLog.Text = "";
            }

            
            
        }
    }
}