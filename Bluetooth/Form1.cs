using InTheHand.Net;
using InTheHand.Net.Sockets;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
        Sensor sensor1 = new Sensor("Sensor1", 0x00);
        Sensor sensor2 = new Sensor("Sensor2", 0x00);

        public Form1()
        {
            InitializeComponent();
            t_discover = new Thread(new ThreadStart(Discover));
            t_discoverend = new Thread(new ThreadStart(Discoverend));


        }

        private void cbBTDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBTDevices.SelectedIndex != -1)
            {
                device = (BluetoothDeviceInfo)cbBTDevices.SelectedItem;
                SetMACLabel(device.DeviceAddress.ToString());
            }
            else
            {
                SetMACLabel("");
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
                {
                    btnConnect.Enabled = true;
                    SetMACLabel(device.DeviceAddress.ToString());
                }
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

                    do
                    {
                        Console.WriteLine("data[0]: " + data[0] + "Start");
                        data[0] = (byte)peerStream.ReadByte();
                    } while (data[0] != Receving_Config_Constants.START_BYTE);
                    i = 1;
                    for (i = 1; i < 7; i++)
                    {
                        Console.WriteLine("data[" + i.ToString() + "]: " + data[i]);
                        data[i] = (byte)peerStream.ReadByte();
                        if (data[6] == Receving_Config_Constants.END_BYTE)
                        {
                            double value = (double)data[4];
                            value = value + ((double)data[5] * 256);
                            double temp_value = 212.009 - (value * (639.9 / 4095));
                            sensor1.Data = temp_value;
                            SetText(temp_value.ToString());
                            DataSendEvent.Set();
                            i = 7;
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
            mac_address_label.Text = text;

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

        private void SetMACLabel(string text)
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


    }

}
