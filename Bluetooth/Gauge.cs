using InTheHand.Net.Bluetooth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.WinControls.UI.Gauges;
namespace Bluetooth
{
    public partial class Form1 : Form
    {
        
        Thread gaugeupdateThread;
        private void CallRadialthread()
        {
            
            gaugeupdateThread = new Thread(new ThreadStart(ProcessGauge));
            gaugeupdateThread.Start();
        }

        private delegate void UpdateGauge(double ih);
        private void ProcessGauge()
        {
            UpdateGauge updategaugehandle = UpdateGaugeMethod;
            while (true)
            {
                DataRecvEvent.WaitOne();
                this.Invoke(updategaugehandle, sensor1.Data);
                Console.Write("Called gauges");
            }
            



        }

        private void UpdateGaugeMethod(double ih)
        {

            tempGuage.Value = (float) ih;
            
            

        }
    }
}