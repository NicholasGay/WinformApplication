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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbBTDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.communication_test_tab = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.mac_address_label = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.Chart_tab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabGuage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.communication_test_tab.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Chart_tab.SuspendLayout();
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
            this.communication_test_tab.Controls.Add(this.Settings);
            this.communication_test_tab.Controls.Add(this.Chart_tab);
            this.communication_test_tab.Controls.Add(this.tabGuage);
            this.communication_test_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.communication_test_tab.Location = new System.Drawing.Point(0, 0);
            this.communication_test_tab.Name = "communication_test_tab";
            this.communication_test_tab.SelectedIndex = 0;
            this.communication_test_tab.Size = new System.Drawing.Size(918, 297);
            this.communication_test_tab.TabIndex = 9;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.mac_address_label);
            this.Settings.Controls.Add(this.btnDisconnect);
            this.Settings.Controls.Add(this.cbBTDevices);
            this.Settings.Controls.Add(this.btnSend);
            this.Settings.Controls.Add(this.txtDisplay);
            this.Settings.Controls.Add(this.txtSend);
            this.Settings.Controls.Add(this.btnConnect);
            this.Settings.Controls.Add(this.btnDiscover);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(910, 271);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.tabPageconnectivity_Click_1);
            // 
            // mac_address_label
            // 
            this.mac_address_label.AutoSize = true;
            this.mac_address_label.Location = new System.Drawing.Point(42, 30);
            this.mac_address_label.Name = "mac_address_label";
            this.mac_address_label.Size = new System.Drawing.Size(0, 13);
            this.mac_address_label.TabIndex = 8;
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
            this.btnSend.Location = new System.Drawing.Point(804, 224);
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
            this.txtDisplay.Size = new System.Drawing.Size(828, 155);
            this.txtDisplay.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(45, 225);
            this.txtSend.Margin = new System.Windows.Forms.Padding(2);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(743, 20);
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
            // Chart_tab
            // 
            this.Chart_tab.Controls.Add(this.chart1);
            this.Chart_tab.Location = new System.Drawing.Point(4, 22);
            this.Chart_tab.Name = "Chart_tab";
            this.Chart_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Chart_tab.Size = new System.Drawing.Size(910, 271);
            this.Chart_tab.TabIndex = 1;
            this.Chart_tab.Text = "Chart";
            this.Chart_tab.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Temperature";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(904, 265);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
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
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Chart_tab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label mac_address_label;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.TabPage Chart_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabGuage;
        private System.Windows.Forms.Label label5;
    }
}

