using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPAsynchronousChat;

namespace UDPChatClientForm
{
    public partial class Form1 : Form
    {
        UDPAsynchronousChat.UDPAsyncChatClient mClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSendBroadcast_Click(object sender, EventArgs e)
        {
            if (mClient == null)
            {
                if (int.TryParse(tbLocalPort.Text, out int localPort)
                    && int.TryParse(tbRemotePort.Text, out int RemotePort)
                    && localPort >= 0 && localPort <= 65535
                    && RemotePort >= 0 && RemotePort <= 65535)
                {
                    mClient = new UDPAsynchronousChat.UDPAsyncChatClient(localPort, RemotePort);
                    mClient.RaiseTextUpdateEvent += ConsoleTextUpdate;

                }
                else
                {
                    Console.WriteLine($"Invalid port values: Local Port = {tbLocalPort.Text}; Remote Port = {tbRemotePort.Text}");
                }
            }
            mClient.SendBroadcast(tbBroadcastText.Text);
        }

        private void ConsoleTextUpdate(object sender, TextUpdateEventArgs e)
        {
            tbConsole.AppendText(e.Text + Environment.NewLine);
            Console.WriteLine(e.Text);
        }
    }
}
