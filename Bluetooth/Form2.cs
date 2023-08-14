using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth
{
    public partial class Form2 : Form
    {
        private readonly Form1 form1;
        Thread form2Thread;
        bool thread_run = false;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            CallForm2thread();
            thread_run = true;
            //SetText("Hello");
        }

        delegate void StringArgReturningVoidDelegate(string text);

        private void StringArgReturnMethod(string text)
        {
            Value.Text = text;
            

        }

        private void SetText(string text)
        {
            //Console.WriteLine("SetText_ThreadID: " +
            //    Thread.CurrentThread.ManagedThreadId.ToString());

            StringArgReturningVoidDelegate StringArgReturnHnd = StringArgReturnMethod;
            this.Invoke(StringArgReturnHnd, text);

        }

        private void CallForm2thread()
        {

           form2Thread = new Thread(new ThreadStart(ProcessForm2));
           form2Thread.Start();
        }

        
        private void ProcessForm2()
        {
            
            while (thread_run)
            {
                form1.getEvent.WaitOne();
                if (thread_run)
                {
                    double temp = form1.getSensorValue;
                    SetText(temp.ToString());
                }
               
                
               
            }
            Console.WriteLine("Thread ended");



        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread_run = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            thread_run = false;
            form1.getEvent.Set();
        }
    }
}
