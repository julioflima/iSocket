using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;


namespace User_1
{
    public partial class Form1 : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int nUser = rnd.Next(10000, 10000000);
            user.Text = "USER" + nUser.ToString();

        }
        
        public void btnSend()
        {
            try { 
                string data = user.Text + " says: " + subject.Text + "\r\n"+ text.Text;
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(data + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                text.Text = "";
            }
            catch (Exception ex)
            {
                //Console.WriteLine(" >> " + ex.ToString());
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                content.Text = "Chat: Conected to Chat Server ...";
                status.Text = "ONLINE";
                status.ForeColor = System.Drawing.Color.FromArgb(87, 238, 121);
                Random rnd = new Random();
                int ipAddr = rnd.Next(1, 100);
                string ipStr = "127.0.0." + ipAddr.ToString();
                clientSocket.Connect(ipStr, 8888);
                serverStream = clientSocket.GetStream();

                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                Thread ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(" >> " + ex.ToString());
            }



        }

        private void getMessage()
        {
            while (true)
            {
                try
                {
                    NetworkStream serverStream = clientSocket.GetStream();
                    // When using magic numbers, at least use nice ones :)
                    byte[] inStream = new byte[4096];

                    // This will read at most inStream.Length bytes - it can be less, and it
                    // doesn't tell us how much data there is left for reading.
                    int bytesRead = serverStream.Read(inStream, 0, inStream.Length);

                    // Only convert bytesRead bytes - the rest is garbage
                    string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                    readData = "" + returndata;
                    msg();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(" >> " + ex.ToString());
                }
                
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                content.Text = content.Text + Environment.NewLine + " >> " + readData;
        }

        private void send_Click(object sender, EventArgs e)
        {
            btnSend();
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //content.Text = text.Text;
                btnSend();
            }
        }
    }
}