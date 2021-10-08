using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace comport
{
    public partial class Form1 : Form
    {
        System_config system_config;
        public Form1()
        {
            InitializeComponent();
        }
       
        string[] com_name = new string[2];
      
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Startlistener();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\Output.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\Output.txt").Close();
                }
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\a.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\a.txt").Close();
                }
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\b.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\b.txt").Close();
                }
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\c.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\c.txt").Close();
                }
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\d.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\d.txt").Close();
                }
                if (!File.Exists(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\e.txt"))
                {
                    File.Create(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\e.txt").Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Create File " + ex.Message);
            }
            
        }

        private void connect_com_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Startlistener();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void SAVE_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        private void Startlistener()
        {
            Thread listenerThread = new Thread(LSThread);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }
        async Task WriteTextAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);
         
            using(var sourceStream =
                new FileStream(
                    filePath,
                    FileMode.Create, FileAccess.Write, FileShare.None,
                    bufferSize: 4096, useAsync: true)) 
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }

           
        }
        private void UpdateStatus(string message)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { UpdateStatus(message); });
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    string a = message.Substring(i, 1);
                    foreach (var item in a)
                    {
                        switch (item)
                        {
                            case 'a':
                                
                                var task = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\a.txt", item.ToString());
                                continue;                               
                            case 'b':                            
                                var taskb = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\b.txt", item.ToString());
                                continue;
                            case 'c':
                               
                                var taskc = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\c.txt", item.ToString());
                                continue;
                            case 'd':
                                
                                var taskd = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\d.txt", item.ToString());
                                continue;
                            case 'e':
                               
                                var taske = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\e.txt", item.ToString());
                                continue;
                            default:                                
                                var taskf = WriteTextAsync(@"C:\Users\Admin\source\repos\comport\comport\bin\Debug\Output.txt", item.ToString());
                                continue;
                        }
                    }
                   
                }
            }
        }
        private void LSThread()
        {

            TcpListener server = null;
            try
            {
                var port = 2000;
                var ipaddr = IPAddress.Parse("192.168.0.15");
                server = new TcpListener(ipaddr, port);
                server.Start();
                var bytes = new byte[256];
                while (true)
                {
                    var client = server.AcceptTcpClient();
                        if (client.Connected)
                    {
                        
                        NetworkStream stream = client.GetStream();
                        while (true)
                        {
                            if (stream.DataAvailable)
                            {
                                var i = stream.Read(bytes, 0, bytes.Length);
                                var data = Encoding.ASCII.GetString(bytes, 0, i);
                                UpdateStatus(data);
                            }
                            else
                            {
                                if (!server.Pending())
                                {
                                    continue;
                                }
                                break;
                            }
                        }
                        client.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                server.Stop();
            }
        }
       
        private void btntest_Click(object sender, EventArgs e)
        {
            Startlistener();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
