using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comm
{
    public partial class MainForm : Form
    {
        private Serial serial;  //串口句柄

        private bool recvHex;   //是否以HEX方式显示
        private bool display;   //是否实时显示数据

        private bool sendHex;   //是否以HEX方式发送
        private bool repeat;    //是否定时发送数据

        private int recv_bytes;
        private int send_bytes;

        private byte[] repeat_data;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //端口设置
            this.serial = new Serial();
            this.serial.SerialRecvData += Serial_SerialRecvData;
            this.comboBoxPort_DropDown(null, null);
            this.comboBoxBaudrate.SelectedIndex = 4;
            this.comboBoxDataBit.SelectedIndex = 1;
            this.comboBoxStopBit.SelectedIndex = 0;
            this.comboBoxCheckBit.SelectedIndex = 0;
            this.btnOpen.Text = "打开串口";

            //接收设置
            this.radioButtonRecvHex.Select();
            this.recvHex = true;
            this.checkBoxDisplay.Checked = true;
            this.display = true;

            //发送设置
            this.radioButtonSendHex.Select();
            this.sendHex = true;
            this.checkBoxRepeat.Checked = false;
            this.repeat = false;
            this.textBoxInterval.Text = "1000";
            this.textBoxInterval.Enabled = false;

            this.recv_bytes = 0;
            this.send_bytes = 0;
            this.repeat_data = null;

            this.toolStripStatusRecv.Alignment = ToolStripItemAlignment.Right;
            this.toolStripStatusSend.Alignment = ToolStripItemAlignment.Right;
            this.toolStripStatusAuthor.Alignment = ToolStripItemAlignment.Right;

            this.toolStripStatusRecv.Text = "接收： " + recv_bytes.ToString();
            this.toolStripStatusSend.Text = "发送： " + send_bytes.ToString();
            this.toolStripStatusComm.Text = "端口已关闭";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.btnOpen.Text != "打开串口")
            {
                this.serial.Close();
            }
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            if (this.serial != null)
            {
                string[] ports = this.serial.GetPorts();
                this.comboBoxPort.Items.Clear();
                if (ports.Length > 0)
                {
                    this.comboBoxPort.Items.AddRange(ports);
                    this.comboBoxPort.SelectedIndex = 0;
                }
            }
        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxInterval.Enabled = this.checkBoxRepeat.Checked;
            repeat = this.checkBoxRepeat.Checked;
        }

        private void radioButtonRecvAscii_CheckedChanged(object sender, EventArgs e)
        {
            this.recvHex = this.radioButtonRecvHex.Checked;
        }

        private void radioButtonSendAscii_CheckedChanged(object sender, EventArgs e)
        {
            this.sendHex = this.radioButtonSendHex.Checked;
        }

        private void checkBoxDisplay_CheckedChanged(object sender, EventArgs e)
        {
            this.display = this.checkBoxDisplay.Checked;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.btnOpen.Text == "打开串口")
            {
                string info;
                bool re = this.serial.Open(this.comboBoxPort.Text,
                                            Convert.ToInt32(this.comboBoxBaudrate.Text),
                                            this.comboBoxCheckBit.SelectedIndex,
                                            Convert.ToInt32(this.comboBoxDataBit.Text),
                                            this.comboBoxStopBit.SelectedIndex, out info);

                if (re)
                {
                    this.comboBoxPort.Enabled = false;
                    this.comboBoxBaudrate.Enabled = false;
                    this.comboBoxDataBit.Enabled = false;
                    this.comboBoxCheckBit.Enabled = false;
                    this.comboBoxStopBit.Enabled = false;

                    this.btnOpen.Text = "关闭串口";

                    this.toolStripStatusComm.Text = string.Format("{0}已打开 波特率{1}", this.comboBoxPort.Text, this.comboBoxBaudrate.Text);
                }
                else
                {
                    MessageBox.Show("串口打开失败！\r\n\r\n" + info, "错误");
                }
            }
            else
            {
                this.serial.Close();

                this.comboBoxPort.Enabled = true;
                this.comboBoxBaudrate.Enabled = true;
                this.comboBoxDataBit.Enabled = true;
                this.comboBoxCheckBit.Enabled = true;
                this.comboBoxStopBit.Enabled = true;

                this.btnOpen.Text = "打开串口";
                this.toolStripStatusComm.Text = "端口已关闭";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxRecv.Text = "";
            this.recv_bytes = 0;
            this.send_bytes = 0;
            this.toolStripStatusRecv.Text = "接收： " + recv_bytes.ToString();
            this.toolStripStatusSend.Text = "发送： " + send_bytes.ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void Serial_SerialRecvData(byte[] data, int size)
        {
            string tmp = "";
            recv_bytes += size;

            if (this.display)
            {
                if (this.recvHex)
                {
                    for (int i = 0; i < size; i++)
                        tmp += data[i].ToString("X2") + " ";
                }
                else
                {
                    for (int i = 0; i < size; i++)
                        tmp += Convert.ToChar(data[i]).ToString();
                }
            }

            Action<string> AsyncRecvDelegate = delegate (string s)
            {
                if (tmp != "")
                {
                    this.textBoxRecv.Text += s;
                    this.textBoxRecv.Select(this.textBoxRecv.Text.Length, 0);
                    this.textBoxRecv.ScrollToCaret();
                }
                this.toolStripStatusRecv.Text = "接收： " + recv_bytes.ToString();
            };
            this.Invoke(AsyncRecvDelegate, new object[] { tmp });
        }

        private byte[] str2hex(string s)
        {
            s = s.Replace(" ", "").Replace("\r", "").Replace("\n", "");

            if (s.Length % 2 == 1)
                return null;

            byte[] b = new byte[s.Length / 2];

            try
            {
                for (int i = 0; i < s.Length; i += 2)
                {
                    b[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
                }
                return b;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.btnSend.Text == "发送")
            {
                byte[] send_data;
                string str = this.textBoxSend.Text;

                if (str == "")
                    return;

                if (this.sendHex)
                    send_data = str2hex(str);
                else
                    send_data = Encoding.Default.GetBytes(str);

                if (send_data == null)
                {
                    MessageBox.Show("数据错误，无法发送！","错误");
                    return;
                }

                if (this.repeat)
                {
                    //定时重复发送数据
                    try
                    {
                        this.timerSend.Interval = Convert.ToInt32(this.textBoxInterval.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("定时发送时间异常！", "错误");
                        return;
                    }

                    this.repeat_data = send_data;
                    this.timerSend.Enabled = true;

                    this.groupBoxSetup.Enabled = false;
                    this.groupBoxSend.Enabled = false;
                    this.btnList.Enabled = false;

                    this.btnSend.Text = "结束";
                }
                else
                {
                    //直接发送数据
                    this.serial.SendData(send_data);

                    this.send_bytes += send_data.Length;
                    this.toolStripStatusSend.Text = "发送： " + send_bytes.ToString();
                }
            }
            else
            {
                //停止定时重复发送
                this.repeat_data = null;
                this.timerSend.Enabled = false;

                this.groupBoxSetup.Enabled = true;
                this.groupBoxSend.Enabled = true;
                this.btnList.Enabled = true;

                this.btnSend.Text = "发送";
            }
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            if (this.repeat_data != null)
            {
                this.serial.SendData(repeat_data);

                this.send_bytes += repeat_data.Length;
                this.toolStripStatusSend.Text = "发送： " + send_bytes.ToString();
            }
        }
    }
}
