using InTheHand.Net.Bluetooth;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
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
                if (numberOfPoints == 0)
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

        private void btnStart_Test_Click(object sender, EventArgs e)
        {
            test_run = true;
            Console.WriteLine("Testbutton Clicked");

        }

        private void btnStop_Test_Click(object sender, EventArgs e)
        {
            test_run = false;
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
            Console.WriteLine("Testbutton Stopped");
        }
    }
}
