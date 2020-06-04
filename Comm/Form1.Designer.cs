namespace Comm
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxSetup = new System.Windows.Forms.GroupBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRecv = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusComm = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRecv = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSend = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.radioButtonRecvAscii = new System.Windows.Forms.RadioButton();
            this.radioButtonRecvHex = new System.Windows.Forms.RadioButton();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.radioButtonSendAscii = new System.Windows.Forms.RadioButton();
            this.radioButtonSendHex = new System.Windows.Forms.RadioButton();
            this.btnList = new System.Windows.Forms.Button();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSetup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSetup
            // 
            this.groupBoxSetup.Controls.Add(this.comboBoxDataBit);
            this.groupBoxSetup.Controls.Add(this.label5);
            this.groupBoxSetup.Controls.Add(this.comboBoxCheckBit);
            this.groupBoxSetup.Controls.Add(this.comboBoxStopBit);
            this.groupBoxSetup.Controls.Add(this.comboBoxBaudrate);
            this.groupBoxSetup.Controls.Add(this.comboBoxPort);
            this.groupBoxSetup.Controls.Add(this.btnOpen);
            this.groupBoxSetup.Controls.Add(this.label4);
            this.groupBoxSetup.Controls.Add(this.label3);
            this.groupBoxSetup.Controls.Add(this.label2);
            this.groupBoxSetup.Controls.Add(this.label1);
            this.groupBoxSetup.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSetup.Name = "groupBoxSetup";
            this.groupBoxSetup.Size = new System.Drawing.Size(157, 206);
            this.groupBoxSetup.TabIndex = 0;
            this.groupBoxSetup.TabStop = false;
            this.groupBoxSetup.Text = "端口设置";
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataBit.Location = new System.Drawing.Point(69, 78);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(70, 20);
            this.comboBoxDataBit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据位：";
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Items.AddRange(new object[] {
            "无校验",
            "奇校验",
            "偶校验"});
            this.comboBoxCheckBit.Location = new System.Drawing.Point(69, 138);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(70, 20);
            this.comboBoxCheckBit.TabIndex = 8;
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(69, 108);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(70, 20);
            this.comboBoxStopBit.TabIndex = 7;
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(69, 48);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(70, 20);
            this.comboBoxBaudrate.TabIndex = 6;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(69, 18);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(70, 20);
            this.comboBoxPort.TabIndex = 5;
            this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 171);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(124, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            // 
            // textBoxRecv
            // 
            this.textBoxRecv.Location = new System.Drawing.Point(178, 12);
            this.textBoxRecv.Multiline = true;
            this.textBoxRecv.Name = "textBoxRecv";
            this.textBoxRecv.ReadOnly = true;
            this.textBoxRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecv.Size = new System.Drawing.Size(486, 399);
            this.textBoxRecv.TabIndex = 1;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(178, 418);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(405, 56);
            this.textBoxSend.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(589, 448);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 26);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAuthor,
            this.toolStripStatusComm,
            this.toolStripStatusRecv,
            this.toolStripStatusSend});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusComm
            // 
            this.toolStripStatusComm.Name = "toolStripStatusComm";
            this.toolStripStatusComm.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusComm.Text = "串口已关闭";
            // 
            // toolStripStatusRecv
            // 
            this.toolStripStatusRecv.AutoSize = false;
            this.toolStripStatusRecv.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusRecv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusRecv.Name = "toolStripStatusRecv";
            this.toolStripStatusRecv.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusRecv.Text = "发送：123456";
            // 
            // toolStripStatusSend
            // 
            this.toolStripStatusSend.AutoSize = false;
            this.toolStripStatusSend.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusSend.Name = "toolStripStatusSend";
            this.toolStripStatusSend.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusSend.Text = "接收：123456 ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.checkBoxDisplay);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.radioButtonRecvAscii);
            this.groupBox2.Controls.Add(this.radioButtonRecvHex);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 104);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "导出数据";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Location = new System.Drawing.Point(15, 50);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(72, 16);
            this.checkBoxDisplay.TabIndex = 7;
            this.checkBoxDisplay.Text = "实时显示";
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            this.checkBoxDisplay.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radioButtonRecvAscii
            // 
            this.radioButtonRecvAscii.AutoSize = true;
            this.radioButtonRecvAscii.Location = new System.Drawing.Point(15, 25);
            this.radioButtonRecvAscii.Name = "radioButtonRecvAscii";
            this.radioButtonRecvAscii.Size = new System.Drawing.Size(53, 16);
            this.radioButtonRecvAscii.TabIndex = 1;
            this.radioButtonRecvAscii.Text = "ASCII";
            this.radioButtonRecvAscii.UseVisualStyleBackColor = true;
            this.radioButtonRecvAscii.CheckedChanged += new System.EventHandler(this.radioButtonRecvAscii_CheckedChanged);
            // 
            // radioButtonRecvHex
            // 
            this.radioButtonRecvHex.AutoSize = true;
            this.radioButtonRecvHex.Checked = true;
            this.radioButtonRecvHex.Location = new System.Drawing.Point(98, 25);
            this.radioButtonRecvHex.Name = "radioButtonRecvHex";
            this.radioButtonRecvHex.Size = new System.Drawing.Size(41, 16);
            this.radioButtonRecvHex.TabIndex = 0;
            this.radioButtonRecvHex.TabStop = true;
            this.radioButtonRecvHex.Text = "HEX";
            this.radioButtonRecvHex.UseVisualStyleBackColor = true;
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.label7);
            this.groupBoxSend.Controls.Add(this.label6);
            this.groupBoxSend.Controls.Add(this.textBoxInterval);
            this.groupBoxSend.Controls.Add(this.checkBoxRepeat);
            this.groupBoxSend.Controls.Add(this.radioButtonSendAscii);
            this.groupBoxSend.Controls.Add(this.radioButtonSendHex);
            this.groupBoxSend.Location = new System.Drawing.Point(12, 370);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(157, 105);
            this.groupBoxSend.TabIndex = 11;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "发送设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "ms";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "间隔：";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(59, 71);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(52, 21);
            this.textBoxInterval.TabIndex = 6;
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(15, 50);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(72, 16);
            this.checkBoxRepeat.TabIndex = 5;
            this.checkBoxRepeat.Text = "重复发送";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // radioButtonSendAscii
            // 
            this.radioButtonSendAscii.AutoSize = true;
            this.radioButtonSendAscii.Location = new System.Drawing.Point(15, 25);
            this.radioButtonSendAscii.Name = "radioButtonSendAscii";
            this.radioButtonSendAscii.Size = new System.Drawing.Size(53, 16);
            this.radioButtonSendAscii.TabIndex = 1;
            this.radioButtonSendAscii.Text = "ASCII";
            this.radioButtonSendAscii.UseVisualStyleBackColor = true;
            this.radioButtonSendAscii.CheckedChanged += new System.EventHandler(this.radioButtonSendAscii_CheckedChanged);
            // 
            // radioButtonSendHex
            // 
            this.radioButtonSendHex.AutoSize = true;
            this.radioButtonSendHex.Checked = true;
            this.radioButtonSendHex.Location = new System.Drawing.Point(98, 25);
            this.radioButtonSendHex.Name = "radioButtonSendHex";
            this.radioButtonSendHex.Size = new System.Drawing.Size(41, 16);
            this.radioButtonSendHex.TabIndex = 0;
            this.radioButtonSendHex.TabStop = true;
            this.radioButtonSendHex.Text = "HEX";
            this.radioButtonSendHex.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(589, 418);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 26);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "列表发送";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // timerSend
            // 
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // toolStripStatusAuthor
            // 
            this.toolStripStatusAuthor.AutoSize = false;
            this.toolStripStatusAuthor.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusAuthor.Name = "toolStripStatusAuthor";
            this.toolStripStatusAuthor.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusAuthor.Text = "Design by Terry";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 506);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxRecv);
            this.Controls.Add(this.groupBoxSetup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "串口调试助手";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSetup.ResumeLayout(false);
            this.groupBoxSetup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSetup;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRecv;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioButtonRecvAscii;
        private System.Windows.Forms.RadioButton radioButtonRecvHex;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.RadioButton radioButtonSendAscii;
        private System.Windows.Forms.RadioButton radioButtonSendHex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRecv;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSend;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusComm;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAuthor;
    }
}

