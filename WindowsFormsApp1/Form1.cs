using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
       
        private bool isShow = true;

        //创建一个List<>对象，作为缓存区，可动态变化，不需要开辟固定空间,更灵活
        private List<byte> receiveBuffer = new List<byte>();

        //计数接收到的数据
        private int receiveCount = 0;
        public Form1()
        {
            InitializeComponent();

            //禁用对跨线程调用的检查
            //Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            SerialLoad();
           
            
        }

        //加载集合方法，将串口加载到下拉组件中
        private void SerialLoad()
        {
            //打开Windows注册表中的特定键，让应用程序能够查询和操作计算机上可用的串口。
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComn");
            port_cbb.Items.Clear();//清除操作   

            //获取当前计算机上可用的串口端口名并放在port数组中
            string[] port = SerialPort.GetPortNames();

            //遍历port数组，每一次循环都将port数组中的元素付给portName，然后再执行语句
            foreach (string portName in port)
            {
                // 将每个串口名添加为下拉组件的一个选项
                port_cbb.Items.Add(portName);
            }


            //将port下拉框索引定位0，也就是第一个选项。
            this.port_cbb.SelectedIndex = 0;
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Send_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (port_cbb.Text!=" ")
                {
                    //选择下拉菜单中的串口
                    serialPort1.PortName = port_cbb.Text;
                }

                //打开串口
                serialPort1.Open();

                //如果串口已被打开，弹出打开成功窗口
                if (serialPort1.IsOpen)
                {
                    MessageBox.Show(serialPort1.PortName+"打开成功");
                }
            }
            catch (Exception ex)
            {
                //显示一个包含异常信息和串口名称的消息框,已字符串显示
                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (this.send_rtb.Text!=" "&&serialPort1.IsOpen)//发送区不为空且串口打开
            {
                string str = send_rtb.Text;
                byte[] by = Encoding.GetEncoding("gb2312").GetBytes(str);
                //将发送区的内容写入串口
                serialPort1.Write(by,0,by.Length);
            }
        }

        private void Baud_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Check_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //在接收到一段数据后自动执行
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (isShow==false)
            {
                return;
            }
            //创建一个大小和串口缓冲区可供读取的字节数相等的数组
            byte[] dateTemp = new byte[serialPort1.BytesToRead];

            //读取串口数据
            serialPort1.Read(dateTemp, 0, dateTemp.Length);

            //将读取的数据写入之前定义的动态数组
            receiveBuffer.AddRange(dateTemp);

            //接收计数
            receiveCount += dateTemp.Length;

            //切换至主线程
            this.Invoke(new EventHandler(delegate
            {
                //显示接收数据的长度
                receiveCount_tssl.Text = receiveCount.ToString();

                //如果没有选择十六进制，执行
                if (!receiveHEX_ckb.Checked)
                {
                    //使用gb2312字符编码对二进制数据\进行解码为字符串
                    string str = Encoding.GetEncoding("gb2312").GetString(dateTemp);
                    //0X00代表 \0，不会显示，使用转移字符将其显示
                   str=str.Replace("\0","\\0");
                    receive_rtb.AppendText(str);
                }
                //将接收到的byte数组转化成16进制输出
                else
                {
                    receive_rtb.AppendText(BitConverter.ToString(dateTemp));
                }

         
            }));

            ////读取接收到的在串口缓存区的字符串数据
            //string dateReceive = serialPort1.ReadExisting();
            ////在接受区中展示接收到的数据
            //receive_rtb.AppendText(dateReceive);
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            //切换暂停按钮的文本状态
            if (isShow==true)
            {
                isShow = false;
                stop_btn.Text = "取消暂停";
            }
            else
            {
                isShow = true;
                stop_btn.Text = "暂停";
            }


        }

        private void receiveHEX_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (receive_rtb.Text == " ") return;
            if (receiveHEX_ckb.Checked)
            {
                //将之前接收到的所有数据转换为16进制显示
                receive_rtb.Text = (BitConverter.ToString(receiveBuffer.ToArray()));
            }
            else
            {
                receive_rtb.Text=Encoding.GetEncoding("gb2312").GetString(receiveBuffer.ToArray()).Replace ("/0","//0");
            }
        }

        private void sendHEX_ckb_CheckedChanged(object sender, EventArgs e)
        {

        }
        //手动清空接收数据
        private void clear_btn_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            receive_rtb.Text = " ";
            receiveCount_tssl.Text = "0";
            receiveCount = 0;
        }
        //自动清空接收数据
        private void autoclear_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (autoclear_ckb.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果接收大于4kb，清空数据
            if (receive_rtb.TextLength>4096)
            {
                receiveBuffer.Clear();
                receive_rtb.Text = " ";
                receiveCount_tssl.Text = "0";
                receiveCount = 0;
            }
        }
    }
}       
