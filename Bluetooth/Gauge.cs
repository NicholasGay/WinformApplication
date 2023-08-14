using System;
using System.Threading;
using System.Windows.Forms;
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
                triggerGauge.WaitOne();
                this.Invoke(updategaugehandle, sensor1.Data);
                Console.Write("Called gauges\n");
            }




        }

        private void UpdateGaugeMethod(double ih)
        {

            tempGuage.Value = (float)ih;


        }
    }
}