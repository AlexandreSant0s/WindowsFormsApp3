using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private object textBox2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { }
        static void SendUdp(int PortId, string IpConf, int PortIdAberta, byte[] data)
            {
                using (UdpClient c = new UdpClient(PortId))
                    c.Send(data, data.Length, IpConf, PortIdAberta);
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { }
        public string Recebe()
            {
                UdpClient receivingUdpClient = new UdpClient(Convert.ToInt32(textBox2));
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                try
                {



                    Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);


                    string returnData = Encoding.ASCII.GetString(receiveBytes);


                    return returnData.ToString();

                }
                catch (Exception e)
                {

                    return e.ToString();
                }

            }
        
    }
}
