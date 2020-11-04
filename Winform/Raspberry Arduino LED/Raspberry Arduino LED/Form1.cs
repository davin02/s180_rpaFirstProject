using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Raspberry_Arduino_LED
{
    public partial class MainForm : Form
    {
        private TcpClient tcpClient = null;
        IPAddress ipAdd = IPAddress.Parse("192.168.0.45");
        int port = 7999;
        private NetworkStream ns;

        byte[] sendByte;
        String sentData = "";

        byte[] receiveBuffer = new byte[1024];
        String receivedData = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ipAdd, port);
                ns = tcpClient.GetStream();
                TestTextBox.AppendText("Connect Success!\n");
            }
            catch (Exception err)
            {
                TestTextBox.AppendText(err.ToString() + "\n");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sentData = "close";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);
            Thread.Sleep(500);
            ns.Close();
            tcpClient.Close();
        }

        private void RED_ON(object sender, EventArgs e)
        {
            TestTextBox.AppendText("1번 버튼 눌림^!^\n");

            sentData = "1";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }

        private void RED_OFF(object sender, EventArgs e)
        {
            TestTextBox.AppendText("2번 버튼 눌림^!^\n");

            sentData = "2";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }

        private void GREEN_ON(object sender, EventArgs e)
        {
            TestTextBox.AppendText("3번 버튼 눌림^!^\n");

            sentData = "3";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }

        private void GREEN_OFF(object sender, EventArgs e)
        {
            TestTextBox.AppendText("4번 버튼 눌림^!^\n");

            sentData = "4";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }

        private void BLUE_ON(object sender, EventArgs e)
        {
            TestTextBox.AppendText("5번 버튼 눌림^!^\n");

            sentData = "5";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }

        private void BLUE_OFF(object sender, EventArgs e)
        {
            TestTextBox.AppendText("6번 버튼 눌림^!^\n");

            sentData = "6";
            sendByte = Encoding.ASCII.GetBytes(sentData);
            ns.Write(sendByte, 0, sendByte.Length);


            ns.Read(receiveBuffer, 0, receiveBuffer.Length);
            receivedData = Encoding.ASCII.GetString(receiveBuffer);
            TestTextBox.AppendText(receivedData);
            TestTextBox.AppendText("\n");

            TestTextBox.ScrollToCaret();
        }
    }
}
