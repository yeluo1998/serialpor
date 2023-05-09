namespace WindowsFormsApp1
{
    partial class Form1
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
            this.receive_rtb = new System.Windows.Forms.RichTextBox();
            this.send_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receive_txb = new System.Windows.Forms.TextBox();
            this.storeDate_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.autoclear_ckb = new System.Windows.Forms.CheckBox();
            this.receiveHEX_ckb = new System.Windows.Forms.CheckBox();
            this.choose_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeGap_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendFile_btn = new System.Windows.Forms.Button();
            this.sendFile_txb = new System.Windows.Forms.TextBox();
            this.cleanSend_btn = new System.Windows.Forms.Button();
            this.sendHEX_ckb = new System.Windows.Forms.CheckBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.autosend_ckb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendConut_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveCount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearConut_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.port_cbb = new System.Windows.Forms.ComboBox();
            this.baud_cbb = new System.Windows.Forms.ComboBox();
            this.check_cbb = new System.Windows.Forms.ComboBox();
            this.date_cbb = new System.Windows.Forms.ComboBox();
            this.stop_cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RTS_checkbox = new System.Windows.Forms.CheckBox();
            this.ATR_ckb = new System.Windows.Forms.CheckBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receive_rtb
            // 
            this.receive_rtb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receive_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receive_rtb.Location = new System.Drawing.Point(3, 21);
            this.receive_rtb.Name = "receive_rtb";
            this.receive_rtb.Size = new System.Drawing.Size(526, 406);
            this.receive_rtb.TabIndex = 4;
            this.receive_rtb.Text = "";
            // 
            // send_rtb
            // 
            this.send_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_rtb.Location = new System.Drawing.Point(3, 21);
            this.send_rtb.Name = "send_rtb";
            this.send_rtb.Size = new System.Drawing.Size(529, 168);
            this.send_rtb.TabIndex = 6;
            this.send_rtb.Text = "";
            this.send_rtb.TextChanged += new System.EventHandler(this.Send_rtb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receive_txb);
            this.groupBox2.Controls.Add(this.storeDate_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.autoclear_ckb);
            this.groupBox2.Controls.Add(this.receiveHEX_ckb);
            this.groupBox2.Controls.Add(this.choose_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // receive_txb
            // 
            this.receive_txb.Location = new System.Drawing.Point(6, 126);
            this.receive_txb.Name = "receive_txb";
            this.receive_txb.Size = new System.Drawing.Size(243, 25);
            this.receive_txb.TabIndex = 24;
            this.receive_txb.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // storeDate_btn
            // 
            this.storeDate_btn.Location = new System.Drawing.Point(149, 88);
            this.storeDate_btn.Name = "storeDate_btn";
            this.storeDate_btn.Size = new System.Drawing.Size(88, 29);
            this.storeDate_btn.TabIndex = 23;
            this.storeDate_btn.Text = "保存数据";
            this.storeDate_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(149, 53);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(88, 29);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(149, 18);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(88, 29);
            this.stop_btn.TabIndex = 21;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // autoclear_ckb
            // 
            this.autoclear_ckb.AutoSize = true;
            this.autoclear_ckb.Location = new System.Drawing.Point(19, 30);
            this.autoclear_ckb.Name = "autoclear_ckb";
            this.autoclear_ckb.Size = new System.Drawing.Size(89, 19);
            this.autoclear_ckb.TabIndex = 20;
            this.autoclear_ckb.Text = "自动清空";
            this.autoclear_ckb.UseVisualStyleBackColor = true;
            this.autoclear_ckb.CheckedChanged += new System.EventHandler(this.autoclear_ckb_CheckedChanged);
            // 
            // receiveHEX_ckb
            // 
            this.receiveHEX_ckb.AutoSize = true;
            this.receiveHEX_ckb.Location = new System.Drawing.Point(19, 56);
            this.receiveHEX_ckb.Name = "receiveHEX_ckb";
            this.receiveHEX_ckb.Size = new System.Drawing.Size(89, 19);
            this.receiveHEX_ckb.TabIndex = 19;
            this.receiveHEX_ckb.Text = "十六进制";
            this.receiveHEX_ckb.UseVisualStyleBackColor = true;
            this.receiveHEX_ckb.CheckedChanged += new System.EventHandler(this.receiveHEX_ckb_CheckedChanged);
            // 
            // choose_btn
            // 
            this.choose_btn.Location = new System.Drawing.Point(19, 89);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(88, 29);
            this.choose_btn.TabIndex = 18;
            this.choose_btn.Text = "选择路径";
            this.choose_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeGap_txb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendFile_btn);
            this.groupBox3.Controls.Add(this.sendFile_txb);
            this.groupBox3.Controls.Add(this.cleanSend_btn);
            this.groupBox3.Controls.Add(this.sendHEX_ckb);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Controls.Add(this.openFile_btn);
            this.groupBox3.Controls.Add(this.autosend_ckb);
            this.groupBox3.Location = new System.Drawing.Point(12, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 192);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // timeGap_txb
            // 
            this.timeGap_txb.Location = new System.Drawing.Point(149, 159);
            this.timeGap_txb.Name = "timeGap_txb";
            this.timeGap_txb.Size = new System.Drawing.Size(100, 25);
            this.timeGap_txb.TabIndex = 31;
            this.timeGap_txb.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(11, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "自动发送周期(ms)";
            // 
            // sendFile_btn
            // 
            this.sendFile_btn.Location = new System.Drawing.Point(149, 88);
            this.sendFile_btn.Name = "sendFile_btn";
            this.sendFile_btn.Size = new System.Drawing.Size(88, 29);
            this.sendFile_btn.TabIndex = 30;
            this.sendFile_btn.Text = "发送文件";
            this.sendFile_btn.UseVisualStyleBackColor = true;
            // 
            // sendFile_txb
            // 
            this.sendFile_txb.Location = new System.Drawing.Point(6, 124);
            this.sendFile_txb.Name = "sendFile_txb";
            this.sendFile_txb.Size = new System.Drawing.Size(243, 25);
            this.sendFile_txb.TabIndex = 25;
            // 
            // cleanSend_btn
            // 
            this.cleanSend_btn.Location = new System.Drawing.Point(149, 53);
            this.cleanSend_btn.Name = "cleanSend_btn";
            this.cleanSend_btn.Size = new System.Drawing.Size(88, 29);
            this.cleanSend_btn.TabIndex = 29;
            this.cleanSend_btn.Text = "清空发送";
            this.cleanSend_btn.UseVisualStyleBackColor = true;
            // 
            // sendHEX_ckb
            // 
            this.sendHEX_ckb.AutoSize = true;
            this.sendHEX_ckb.Location = new System.Drawing.Point(19, 57);
            this.sendHEX_ckb.Name = "sendHEX_ckb";
            this.sendHEX_ckb.Size = new System.Drawing.Size(89, 19);
            this.sendHEX_ckb.TabIndex = 26;
            this.sendHEX_ckb.Text = "十六进制";
            this.sendHEX_ckb.UseVisualStyleBackColor = true;
            this.sendHEX_ckb.CheckedChanged += new System.EventHandler(this.sendHEX_ckb_CheckedChanged);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(149, 18);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(88, 29);
            this.send_btn.TabIndex = 28;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // openFile_btn
            // 
            this.openFile_btn.Location = new System.Drawing.Point(19, 89);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(88, 29);
            this.openFile_btn.TabIndex = 25;
            this.openFile_btn.Text = "打开文件";
            this.openFile_btn.UseVisualStyleBackColor = true;
            // 
            // autosend_ckb
            // 
            this.autosend_ckb.AutoSize = true;
            this.autosend_ckb.Location = new System.Drawing.Point(19, 31);
            this.autosend_ckb.Name = "autosend_ckb";
            this.autosend_ckb.Size = new System.Drawing.Size(89, 19);
            this.autosend_ckb.TabIndex = 27;
            this.autosend_ckb.Text = "自动发送";
            this.autosend_ckb.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.receive_rtb);
            this.groupBox4.Location = new System.Drawing.Point(276, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 430);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接受区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.send_rtb);
            this.groupBox5.Location = new System.Drawing.Point(273, 448);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 192);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // state_tssl
            // 
            this.state_tssl.AutoSize = false;
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(200, 20);
            this.state_tssl.Text = "初始化正常";
            this.state_tssl.Click += new System.EventHandler(this.ToolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel3.Text = "发送计数";
            // 
            // sendConut_tssl
            // 
            this.sendConut_tssl.AutoSize = false;
            this.sendConut_tssl.Name = "sendConut_tssl";
            this.sendConut_tssl.Size = new System.Drawing.Size(50, 20);
            this.sendConut_tssl.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel5.Text = "接收计数";
            // 
            // receiveCount_tssl
            // 
            this.receiveCount_tssl.AutoSize = false;
            this.receiveCount_tssl.Name = "receiveCount_tssl";
            this.receiveCount_tssl.Size = new System.Drawing.Size(50, 20);
            this.receiveCount_tssl.Text = "0";
            // 
            // clearConut_tssl
            // 
            this.clearConut_tssl.Name = "clearConut_tssl";
            this.clearConut_tssl.Size = new System.Drawing.Size(69, 20);
            this.clearConut_tssl.Text = "清空计数";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state_tssl,
            this.toolStripStatusLabel3,
            this.sendConut_tssl,
            this.toolStripStatusLabel5,
            this.receiveCount_tssl,
            this.clearConut_tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // port_cbb
            // 
            this.port_cbb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port_cbb.FormattingEnabled = true;
            this.port_cbb.Location = new System.Drawing.Point(105, 21);
            this.port_cbb.Name = "port_cbb";
            this.port_cbb.Size = new System.Drawing.Size(132, 28);
            this.port_cbb.TabIndex = 2;
            this.port_cbb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // baud_cbb
            // 
            this.baud_cbb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baud_cbb.FormattingEnabled = true;
            this.baud_cbb.Location = new System.Drawing.Point(105, 55);
            this.baud_cbb.Name = "baud_cbb";
            this.baud_cbb.Size = new System.Drawing.Size(132, 28);
            this.baud_cbb.TabIndex = 3;
            this.baud_cbb.SelectedIndexChanged += new System.EventHandler(this.Baud_cbb_SelectedIndexChanged);
            // 
            // check_cbb
            // 
            this.check_cbb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_cbb.FormattingEnabled = true;
            this.check_cbb.Location = new System.Drawing.Point(105, 89);
            this.check_cbb.Name = "check_cbb";
            this.check_cbb.Size = new System.Drawing.Size(132, 28);
            this.check_cbb.TabIndex = 4;
            this.check_cbb.SelectedIndexChanged += new System.EventHandler(this.Check_cbb_SelectedIndexChanged);
            // 
            // date_cbb
            // 
            this.date_cbb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_cbb.FormattingEnabled = true;
            this.date_cbb.Location = new System.Drawing.Point(105, 123);
            this.date_cbb.Name = "date_cbb";
            this.date_cbb.Size = new System.Drawing.Size(132, 28);
            this.date_cbb.TabIndex = 5;
            // 
            // stop_cbb
            // 
            this.stop_cbb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop_cbb.FormattingEnabled = true;
            this.stop_cbb.Location = new System.Drawing.Point(105, 157);
            this.stop_cbb.Name = "stop_cbb";
            this.stop_cbb.Size = new System.Drawing.Size(132, 28);
            this.stop_cbb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(18, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "停止位";
            // 
            // RTS_checkbox
            // 
            this.RTS_checkbox.AutoSize = true;
            this.RTS_checkbox.Location = new System.Drawing.Point(22, 201);
            this.RTS_checkbox.Name = "RTS_checkbox";
            this.RTS_checkbox.Size = new System.Drawing.Size(53, 19);
            this.RTS_checkbox.TabIndex = 12;
            this.RTS_checkbox.Text = "RTS";
            this.RTS_checkbox.UseVisualStyleBackColor = true;
            // 
            // ATR_ckb
            // 
            this.ATR_ckb.AutoSize = true;
            this.ATR_ckb.Location = new System.Drawing.Point(22, 226);
            this.ATR_ckb.Name = "ATR_ckb";
            this.ATR_ckb.Size = new System.Drawing.Size(53, 19);
            this.ATR_ckb.TabIndex = 13;
            this.ATR_ckb.Text = "ATR";
            this.ATR_ckb.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(105, 201);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(132, 44);
            this.open_btn.TabIndex = 14;
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.ATR_ckb);
            this.groupBox1.Controls.Add(this.RTS_checkbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stop_cbb);
            this.groupBox1.Controls.Add(this.date_cbb);
            this.groupBox1.Controls.Add(this.check_cbb);
            this.groupBox1.Controls.Add(this.baud_cbb);
            this.groupBox1.Controls.Add(this.port_cbb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 674);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox receive_rtb;
        private System.Windows.Forms.RichTextBox send_rtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox autoclear_ckb;
        private System.Windows.Forms.CheckBox receiveHEX_ckb;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button storeDate_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TextBox receive_txb;
        private System.Windows.Forms.TextBox sendFile_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeGap_txb;
        private System.Windows.Forms.Button sendFile_btn;
        private System.Windows.Forms.Button cleanSend_btn;
        private System.Windows.Forms.CheckBox sendHEX_ckb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.CheckBox autosend_ckb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendConut_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel receiveCount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel clearConut_tssl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ComboBox port_cbb;
        private System.Windows.Forms.ComboBox baud_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox date_cbb;
        private System.Windows.Forms.ComboBox stop_cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox RTS_checkbox;
        private System.Windows.Forms.CheckBox ATR_ckb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

