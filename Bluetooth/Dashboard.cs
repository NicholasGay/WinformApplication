using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        static double highest_temp = 0;
        Thread dashboardUpdateThread;

        private delegate void UpdateRecord(double ih);
        private void UpdateRecordMethod(double ih)
        {
            if(highest_temp < ih)
            {
                string label_set = ih.ToString("0.00");
                highest_temp = ih;
                highest_temp_label.Text = label_set;
                DateTime timestamp = DateTime.Now;
                string dataEntry = $"{timestamp}: {label_set}";
                File.AppendAllText(File_Config_Constants.FILE_PATH,dataEntry+Environment.NewLine);
                
                
               
            }
            
            
        }

        

        private void UpdateRecordProcess()
        {

            UpdateRecord updaterecordhandle = UpdateRecordMethod;
            while (true)
            {

                triggerDashboard.WaitOne();
                this.Invoke(updaterecordhandle, sensor1.Data);


            }
        }
        private void CallDashboardthread()
        {

            dashboardUpdateThread = new Thread(new ThreadStart(UpdateRecordProcess));
            dashboardUpdateThread.Start();
        }
    }
}
