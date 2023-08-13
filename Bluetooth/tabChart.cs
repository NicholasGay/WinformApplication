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

            chart1.Series["Temperature"].ChartType = SeriesChartType.FastLine;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 60;
            chart1.ChartAreas["ChartArea1"].AxisX.IntervalOffset = 0;
            chart1.Series["Temperature"].Color = Color.Navy;

 

            Callchartthread();
         
        }
        private void Callchartthread()
        {
            chart1.Series["Temperature"].Points.Clear();
            run = true;
            chartupdateThread = new Thread(new ThreadStart(ProcessChart));
            chartupdateThread.Start();
        }

       

        private void ProcessChart()
        {
            int i = 0;
            while (true)
            {

                DataSendEvent.WaitOne();
                int numberOfPoints = chart1.Series["Temperature"].Points.Count;
                Console.WriteLine($"Number of points in Temperature: {numberOfPoints}");
                

                UpdateChart updatecharthandle = UpdateChartMethod;
                try
                {
                    
                    this.Invoke(updatecharthandle, i, sensor1.Data);
                    i++;

                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine(ex.ToString());
                }


            }



        }

       
        private delegate void UpdateChart(double ih, double rdnh);
        private void UpdateChartMethod(double ih, double rdnh)
        {

            chart1.Series["Temperature"].Points.AddXY(ih, rdnh);
            if (ih > 12)
            {
                chart1.Series["Temperature"].Points.RemoveAt(0);
                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Math.Max(0, ih - 12);
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = ih - 1;
            }

        }

    }
}
