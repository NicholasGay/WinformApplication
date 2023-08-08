﻿using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        BluetoothDeviceInfo[] peers;
        BluetoothDeviceInfo device = null;
        BluetoothAddress addr = null;
        Guid serviceClass;
        BluetoothEndPoint ep = null;
        BluetoothClient cli = null;
        Stream peerStream = null;
        bool run = true;
        bool test_run = true;
        AutoResetEvent discoverevent = new AutoResetEvent(false);
        AutoResetEvent DataSendEvent = new AutoResetEvent(false);
        AutoResetEvent DataRecvEvent = new AutoResetEvent(false);
        Thread t_discover;
        Thread t_discoverend;

        System.Windows.Forms.Timer chartTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer chart2Timer = new System.Windows.Forms.Timer();
        Thread chartupdateThread;
        Thread chart2updateThread;
        int count;
        string recv_msg;

        public Form1()
        {
            InitializeComponent();
            t_discover = new Thread(new ThreadStart(Discover));
            t_discoverend = new Thread(new ThreadStart(Discoverend));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serviceClass = BluetoothService.SerialPort;

            chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = -32767;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 32768;
            chart1.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 0;
            chart1.Series["Series1"].Color = Color.Navy;

            chart2.Series["Series1"].ChartType = SeriesChartType.FastLine;
            chart2.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart2.ChartAreas["ChartArea1"].AxisY.Minimum = -32767;
            chart2.ChartAreas["ChartArea1"].AxisY.Maximum = 32768;
            chart2.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 0;
            chart2.Series["Series1"].Color = Color.Navy;

            Callchartthread();
            Callchart2thread();
        }

        private void Callchartthread()
        {
            chart1.Series["Series1"].Points.Clear();
            run = true;
            chartupdateThread = new Thread(new ThreadStart(ProcessChart));
            chartupdateThread.Start();
        }

        private void Callchart2thread()
        {
            chart2.Series["Series1"].Points.Clear();
            run = true;
            chart2updateThread = new Thread(new ThreadStart(ProcessChart2));
            chart2updateThread.Start();
        }

        private void ProcessChart()
        {
            int i = 0;
            while (true)
            {
                
                DataSendEvent.WaitOne();
                int numberOfPoints = chart1.Series["Series1"].Points.Count;
                Console.WriteLine($"Number of points in Series1: {numberOfPoints}");
                if(numberOfPoints == 0)
                {
                    i = 0;
                }
                String temp = txtSend.Text;
                if (temp.Length >= 2)
                {
                    temp = temp.Remove(0, 1);
                    temp = temp.Remove(temp.Length - 1, 1);
                    //Console.WriteLine(temp);
                }
                else
                {
                    // Handle cases where the string has less than 2 characters
                    Console.WriteLine("String is too short to remove first and last characters.");
                }

                UpdateChart updatecharthandle = UpdateChartMethod;
                try
                {
                    int f = int.Parse(temp);
                    this.Invoke(updatecharthandle, i, int.Parse(temp));
                    i++;

                }
                catch (Exception ex)
                {
                    SetDisplaySendText(temp);
                    Console.WriteLine(ex.ToString());
                }


            }



        }

        private void ProcessChart2()
        {
            int i = 0;
            while (true)
            {
               

                DataRecvEvent.WaitOne();
                
                int numberOfPoints = chart2.Series["Series1"].Points.Count;
                //Console.WriteLine($"Number of points in Series1: {numberOfPoints}");
                if (numberOfPoints == 0)
                {
                    i = 0;
                }

                UpdateChart updatecharthandle = UpdateChart2Method;
                try
                {
                    int f = int.Parse(recv_msg);
                    this.Invoke(updatecharthandle, i, int.Parse(recv_msg));
                    i++;

                }
                catch (Exception ex)
                {
                    SetDisplaySendText("recieved wrong");
                }


            }
        }

        private delegate void UpdateChart(int ih, int rdnh);
        private void UpdateChartMethod(int ih, int rdnh)
        {

            chart1.Series["Series1"].Points.AddXY(ih, rdnh);
            if (ih > 12)
            {     
                chart1.Series["Series1"].Points.RemoveAt(0);
                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Math.Max(0, ih - 12);
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = ih - 1;
            }
           
        }

        private void UpdateChart2Method(int ih, int rdnh)
        {
            chart2.Series["Series1"].Points.AddXY(ih, rdnh);
            if (ih > 12)
            {
                chart2.Series["Series1"].Points.RemoveAt(0);
                chart2.ChartAreas["ChartArea1"].AxisX.Minimum = Math.Max(0, ih - 12);
                chart2.ChartAreas["ChartArea1"].AxisX.Maximum = ih - 1;
            }
        }

        private void cbBTDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBTDevices.SelectedIndex != -1)
            {
                device = (BluetoothDeviceInfo)cbBTDevices.SelectedItem;
            }
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            //btnDiscover.Enabled = false;
            //cli = new BluetoothClient();
            //peers = cli.DiscoverDevices();
            //this.cbBTDevices.DisplayMember = "DeviceName";
            //this.cbBTDevices.ValueMember = null;
            //this.cbBTDevices.DataSource = peers;
            //btnDiscover.Enabled = true;

            //if (cbBTDevices.Items.Count != 0)
            //{
            //    btnConnect.Enabled = true;
            //}
            //else
            //{
            //    btnConnect.Enabled = false;
            //}
            if (!t_discover.IsAlive)
            {
                if (t_discover.ThreadState == ThreadState.Stopped)
                {
                    t_discover = new Thread(new ThreadStart(Discover));
                    t_discoverend = new Thread(new ThreadStart(Discoverend));
                    t_discover.Start();
                    t_discoverend.Start();
                }
                else
                {
                    Console.WriteLine(t_discover.ThreadState.ToString());
                    t_discover.Start();
                    t_discoverend.Start();
                }


            }
            else
            {
                ;
            }


        }
        private void Discover()
        {
            discoverhandle discoverhndl = Discoverupdate;
            this.Invoke(discoverhndl, false);
            cli = new BluetoothClient();
            peers = cli.DiscoverDevices();
            discoverevent.Set();

        }

        private void Discoverend()
        {
            discoverevent.WaitOne();
            discoverhandle discoverhndl = Discoverupdate;
            this.Invoke(discoverhndl, true);
        }
        delegate void discoverhandle(bool enablevar);
        private void Discoverupdate(bool enablevar)
        {
            if (enablevar == true)
            {
                txtDisplay.AppendText("Discovery Completed\r\n");
                this.cbBTDevices.DisplayMember = "DeviceName";
                this.cbBTDevices.ValueMember = null;
                this.cbBTDevices.DataSource = peers;
                btnDiscover.Enabled = enablevar;

                if (cbBTDevices.Items.Count != 0)
                    btnConnect.Enabled = true;
                else
                    btnConnect.Enabled = false;
            }
            else
            {
                btnDiscover.Enabled = enablevar;
                txtDisplay.AppendText("Discovery in Progress\r\n");
            }

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                if (cbBTDevices.SelectedIndex != -1)
                {
                    addr = device.DeviceAddress;
                    ep = new BluetoothEndPoint(addr, serviceClass);
                    cli = new BluetoothClient();
                    cli.Connect(ep);
                    txtDisplay.AppendText("\nDevice connected\r\n");
                    peerStream = cli.GetStream();

                }
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;
                run = true;
                Console.WriteLine("Button_ThreadID: " +
                Thread.CurrentThread.ManagedThreadId.ToString());

                Thread recvthread = new Thread(new ThreadStart(RecvThread));
                recvthread.Start();
                //Console.WriteLine(device.DeviceName.ToString());
                SetConnectionStatusLabel("Connected to \n" + device.DeviceName.ToString());

            }
            catch (Exception ex)
            {
                txtDisplay.AppendText("\nConnection Unsuccessful\r\n");
                btnConnect.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            run = false;
            peerStream.Dispose();
            cli.Dispose();
            txtDisplay.AppendText("\nDevice disconnected\r\n");
            SetConnectionStatusLabel("Device\nDisconnected");
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String temp = txtSend.Text;
            Byte[] buffer = Encoding.ASCII.GetBytes(txtSend.Text);
            peerStream.Write(buffer, 0, buffer.Length);
            //Console.WriteLine("Send_ThreadID: " + Thread.CurrentThread.ManagedThreadId.ToString());
            //Console.WriteLine("temp length " + temp.Length.ToString());
            if (temp.Length == 6 && test_run)
            {
                DataSendEvent.Set();
            }
            else
            {
                SetText("Length is wrong or test is not running");
            }
            
        }

        public void RecvThread()
        {
            byte[] data = new byte[100];
            int i, j;
            try
            {
                //Console.WriteLine("Form_Recv_ThreadID: " +
                //    Thread.CurrentThread.ManagedThreadId.ToString());
                while (run)
                {
                    //var count = peerStream.Read(data, 0, 99);
                    //data[count] = 0;

                    //String strtemp = new
                    //String(System.Text.Encoding.UTF8.GetString(data).ToCharArray());
                    //String(System.Text.Encoding.Unicode.GetString(data).ToCharArray());
                    do
                    {
                        Console.WriteLine("data[0]: " + data[0] + "Start");
                        data[0] = (byte)peerStream.ReadByte();
                    } while (data[0] != '~');
                    i = 1;
                    for (i = 1; i < 6; i++)
                    {
                        data[i] = (byte)peerStream.ReadByte();
                        if (data[i] == '_')
                        {
                            byte[] f_data = new byte[i - 1];
                            for (j = 0; j < i - 1; j++)
                            {
                                f_data[j] = data[j + 1];
                            }
                            //Console.WriteLine("Set text");
                            SetText(Encoding.UTF8.GetString(f_data));
                            if (test_run) {
                                recv_msg = Encoding.UTF8.GetString(f_data);
                                DataRecvEvent.Set();
                                
                            }
                            i = 6;
                        }
                        else
                        {

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                //log errors
                Console.WriteLine(ex.Message);
            }
        }

        delegate void StringArgReturningVoidDelegate(string text);

        private void StringArgReturnMethod(string text)
        {
            //Console.WriteLine("txtDisplay_ThreadID-Invoke: " +
            //    Thread.CurrentThread.ManagedThreadId.ToString());
            txtDisplay.AppendText(">>" + text);
            txtDisplay.AppendText("\r\n");

        }

        private void StringSendMethod(string text)
        {
            //Console.WriteLine("txtDisplay_ThreadID-Invoke: " +
            //    Thread.CurrentThread.ManagedThreadId.ToString());
            txtDisplay.AppendText("Wrong Format String send: " + text);
            txtDisplay.AppendText("\r\n");

        }

        private void LabelArgReturnMethod(string text)
        {
            //Console.WriteLine("txtDisplay_ThreadID-Invoke: " +
            //    Thread.CurrentThread.ManagedThreadId.ToString());
            connection_status_text.Text = text;

        }

        /*private void SetText(string text)
        {
            if (this.txtDisplay.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new
                StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtDisplay.Text += ">> " + text;
                this.txtDisplay.Text += "\r\n";
            }
        }*/
        /*
        private void SetText(string text)
        {
            txtDisplay.AppendText(">>" + text);

        }*/
        private void SetText(string text)
        {
            //Console.WriteLine("SetText_ThreadID: " +
            //    Thread.CurrentThread.ManagedThreadId.ToString());

            StringArgReturningVoidDelegate StringArgReturnHnd = StringArgReturnMethod;
            this.Invoke(StringArgReturnHnd, text);

        }

        private void SetDisplaySendText(string text)
        {

            StringArgReturningVoidDelegate StringSendHnd = StringSendMethod;
            this.Invoke(StringSendHnd, text);

        }

        private void SetConnectionStatusLabel(string text)
        {
            Console.WriteLine("SetConnectionStatusLabel_ThreadID: " +
                Thread.CurrentThread.ManagedThreadId.ToString());
            StringArgReturningVoidDelegate LabelArgReturnHnd = LabelArgReturnMethod;
            this.Invoke(LabelArgReturnHnd, text);
        }

        private void tabPageconnectivity_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        private void btnStart_Test_Click(object sender, EventArgs e)
        {
            test_run = true;
            
        }

        private void btnStop_Test_Click(object sender, EventArgs e)
        {
            test_run = false;
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
        }
    }
}