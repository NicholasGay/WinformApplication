namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.communication_test_tab = new System.Windows.Forms.TabControl();
            this.tabPageconnectivity = new System.Windows.Forms.TabPage();
            this.connection_status_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStop_Test = new System.Windows.Forms.Button();
            this.btnStart_Test = new System.Windows.Forms.Button();
            this.tabGuage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.communication_test_tab.SuspendLayout();
            this.tabPageconnectivity.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabGuage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBTDevices
            // 
            this.cbBTDevices.FormattingEnabled = true;
            this.cbBTDevices.Location = new System.Drawing.Point(45, 7);
            this.cbBTDevices.Margin = new System.Windows.Forms.Padding(2);
            this.cbBTDevices.Name = "cbBTDevices";
            this.cbBTDevices.Size = new System.Drawing.Size(129, 21);
            this.cbBTDevices.TabIndex = 0;
            this.cbBTDevices.SelectedIndexChanged += new System.EventHandler(this.cbBTDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Display";
            // 
            // communication_test_tab
            // 
            this.communication_test_tab.Controls.Add(this.tabPageconnectivity);
            this.communication_test_tab.Controls.Add(this.tabPage2);
            this.communication_test_tab.Controls.Add(this.tabGuage);
            this.communication_test_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.communication_test_tab.Location = new System.Drawing.Point(0, 0);
            this.communication_test_tab.Name = "communication_test_tab";
            this.communication_test_tab.SelectedIndex = 0;
            this.communication_test_tab.Size = new System.Drawing.Size(918, 297);
            this.communication_test_tab.TabIndex = 9;
            // 
            // tabPageconnectivity
            // 
            this.tabPageconnectivity.Controls.Add(this.connection_status_text);
            this.tabPageconnectivity.Controls.Add(this.label2);
            this.tabPageconnectivity.Controls.Add(this.btnDisconnect);
            this.tabPageconnectivity.Controls.Add(this.cbBTDevices);
            this.tabPageconnectivity.Controls.Add(this.btnSend);
            this.tabPageconnectivity.Controls.Add(this.txtDisplay);
            this.tabPageconnectivity.Controls.Add(this.txtSend);
            this.tabPageconnectivity.Controls.Add(this.btnConnect);
            this.tabPageconnectivity.Controls.Add(this.btnDiscover);
            this.tabPageconnectivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageconnectivity.Name = "tabPageconnectivity";
            this.tabPageconnectivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageconnectivity.Size = new System.Drawing.Size(910, 271);
            this.tabPageconnectivity.TabIndex = 0;
            this.tabPageconnectivity.Text = "Connectivity";
            this.tabPageconnectivity.UseVisualStyleBackColor = true;
            this.tabPageconnectivity.Click += new System.EventHandler(this.tabPageconnectivity_Click_1);
            // 
            // connection_status_text
            // 
            this.connection_status_text.AutoSize = true;
            this.connection_status_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_status_text.Location = new System.Drawing.Point(468, 67);
            this.connection_status_text.Name = "connection_status_text";
            this.connection_status_text.Size = new System.Drawing.Size(417, 55);
            this.connection_status_text.TabIndex = 9;
            this.connection_status_text.Text = "Connection Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output Display";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(376, 7);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(382, 225);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 21);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(45, 55);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(406, 155);
            this.txtDisplay.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(45, 225);
            this.txtSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(314, 20);
            this.txtSend.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(284, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(194, 7);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(75, 23);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "Discover";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.btnStop_Test);
            this.tabPage2.Controls.Add(this.btnStart_Test);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Communication Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Received Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sent Data";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Location = new System.Drawing.Point(568, 14);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(277, 213);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(162, 21);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(343, 206);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // btnStop_Test
            // 
            this.btnStop_Test.Location = new System.Drawing.Point(49, 78);
            this.btnStop_Test.Name = "btnStop_Test";
            this.btnStop_Test.Size = new System.Drawing.Size(75, 35);
            this.btnStop_Test.TabIndex = 1;
            this.btnStop_Test.Text = "Stop Test";
            this.btnStop_Test.UseVisualStyleBackColor = true;
            this.btnStop_Test.Click += new System.EventHandler(this.btnStop_Test_Click);
            // 
            // btnStart_Test
            // 
            this.btnStart_Test.Location = new System.Drawing.Point(49, 21);
            this.btnStart_Test.Name = "btnStart_Test";
            this.btnStart_Test.Size = new System.Drawing.Size(75, 32);
            this.btnStart_Test.TabIndex = 0;
            this.btnStart_Test.Text = "Start Test";
            this.btnStart_Test.UseVisualStyleBackColor = true;
            this.btnStart_Test.Click += new System.EventHandler(this.btnStart_Test_Click);
            // 
            // tabGuage
            // 
            this.tabGuage.Controls.Add(this.label5);
            this.tabGuage.Location = new System.Drawing.Point(4, 22);
            this.tabGuage.Name = "tabGuage";
            this.tabGuage.Size = new System.Drawing.Size(910, 271);
            this.tabGuage.TabIndex = 2;
            this.tabGuage.Text = "Gauge";
            this.tabGuage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 297);
            this.Controls.Add(this.communication_test_tab);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.communication_test_tab.ResumeLayout(false);
            this.tabPageconnectivity.ResumeLayout(false);
            this.tabPageconnectivity.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabGuage.ResumeLayout(false);
            this.tabGuage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBTDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl communication_test_tab;
        private System.Windows.Forms.TabPage tabPageconnectivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label connection_status_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnStop_Test;
        private System.Windows.Forms.Button btnStart_Test;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabGuage;
        private System.Windows.Forms.Label label5;
    }
}

